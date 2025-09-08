using InventoryControl.Communication.Enums;
using InventoryControl.Communication.Requests;
using InventoryControl.Communication.Responses;
using InventoryControl.UI.WinForms.Exceptions;
using InventoryControl.UI.WinForms.Factories;
using InventoryControl.UI.WinForms.Helpers;
using InventoryControl.UI.WinForms.Services.User.Filter;

namespace InventoryControl.UI.WinForms.Forms
{
    public partial class UserListForm : Form
    {
        private readonly IFilterUsersService _filterUsersService;
        private readonly IFormFactory _formFactory;
        private readonly ExceptionFilter _exceptionFilter;
        private List<ResponseUserProfileJson> _cachedItems = [];

        public UserListForm(IFilterUsersService filterUsersService, IFormFactory formFactory, ExceptionFilter exceptionFilter)
        {
            InitializeComponent();
            _filterUsersService = filterUsersService;
            _formFactory = formFactory;
            _exceptionFilter = exceptionFilter;

            userPermission.Tag = Roles.User;
            adminPermission.Tag = Roles.Admin;
            readerPermission.Tag = Roles.Reader;

            DataGridHelper.ConfigureFont(userDataGrid);

            userGroupBox.Visible = false;
            userDataGrid.ContextMenuStrip = userMenuStrip;
        }

        private async void searchBtn_Click(object sender, EventArgs e)
        {
            var selectedRadioBtn = permissionGroupBox
                            .Controls
                            .OfType<RadioButton>()
                            .FirstOrDefault(radioButton => radioButton.Checked);

            var role = selectedRadioBtn?.Tag as Roles?;

            var request = new RequestFilterUserJson
            {
                Name = nameText.Text,
                Email = emailText.Text,
                Role = role
            };

            await _exceptionFilter.ExecuteAsync(async () =>
            {
                var response = await _filterUsersService.FilterUsersAsync(request);

                userGroupBox.Visible = true;

                if (response?.Users is null)
                {
                    _cachedItems.Clear();
                    userDataGrid.DataSource = null;
                    totalLabel.Text = "Total de itens: 0";
                    return;
                }

                var users = response!.Users;

                _cachedItems = users.ToList();

                userDataGrid.DataSource = users.ToList();

                // editando colunas e convertendo os nomes para pt-br
                foreach (DataGridViewTextBoxColumn column in userDataGrid.Columns)
                {
                    if (MapHelpers.FieldNameMap.TryGetValue(column.Name, out var headerText))
                    {
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                        column.MinimumWidth = 200;
                        column.HeaderText = headerText;
                    }
                }

                totalLabel.Text = $"Total de itens: {users.Count}";
            });
        }

        private void cleanBtn_Click(object sender, EventArgs e)
        {
            CleanForms.CleanFields(Controls);
        }

        private void editMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void changePasswordMenuItem_Click(object sender, EventArgs e)
        {
            var selectedRow = userDataGrid.SelectedRows[0];
            var user = (ResponseUserProfileJson)selectedRow.DataBoundItem;

            var itemForm = _formFactory.Create<AdminChangePasswordForm>(null, user.Id);
            itemForm.ShowDialog();
        }

        private void userDataGrid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                userDataGrid.ClearSelection(); // limpando seleções anteriores
                userDataGrid.Rows[e.RowIndex].Selected = true; // selecionando
                userDataGrid.CurrentCell = userDataGrid.Rows[e.RowIndex].Cells[0]; // prevenção de problemas
            }
        }
    }
}
