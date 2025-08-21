using InventoryControl.Communication.Enums;
using InventoryControl.Communication.Requests;
using InventoryControl.Communication.Responses;
using InventoryControl.UI.WinForms.Exceptions;
using InventoryControl.UI.WinForms.Helpers;
using InventoryControl.UI.WinForms.Services.User.Filter;

namespace InventoryControl.UI.WinForms.Forms
{
    public partial class UserListForm : Form
    {
        private readonly IFilterUsersService _filterUsersService;
        private readonly ExceptionFilter _exceptionFilter;
        private List<ResponseUserProfileJson> _cachedItems = [];

        public UserListForm(IFilterUsersService filterUsersService, ExceptionFilter exceptionFilter)
        {
            InitializeComponent();
            _filterUsersService = filterUsersService;
            _exceptionFilter = exceptionFilter;

            userPermission.Tag = Roles.User;
            adminPermission.Tag = Roles.Admin;
            readerPermission.Tag = Roles.Reader;

            DataGridHelper.ConfigureFont(userDataGrid);

            userGroupBox.Visible = false;
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
    }
}
