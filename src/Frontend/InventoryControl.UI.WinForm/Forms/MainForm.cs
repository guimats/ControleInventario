using InventoryControl.UI.WinForms.Models;
using InventoryControl.UI.WinForms.Services.Interfaces.Item;
using InventoryControl.UI.WinForms.Services.Interfaces.ItemHistory;
using InventoryControl.UI.WinForms.Services.Interfaces.User;
using InventoryControl.UI.WinForms.Validators;

namespace InventoryControl.UI.WinForms.Forms
{
    public partial class MainForm : Form
    {
        private readonly IRegisterUserService _registerUserService;
        private readonly IWriteItemService _writeItemService;
        private readonly IFilterItensService _filterItensService;
        private readonly IUpdateItemService _updateItemService;
        private readonly IGetUserProfileService _getUserProfileService;
        private readonly IUpdateUserService _updateUserService;
        private readonly IChangePasswordService _changePasswordService;
        private readonly IItemHistoryService _itemHistoryService;
        private readonly PasswordValidator _passwordValidator;

        public MainForm(
            IRegisterUserService registerUserService,
            IWriteItemService writeItemService,
            IFilterItensService filterItensService,
            IUpdateItemService updateItemService,
            IGetUserProfileService getUserProfileService, 
            IUpdateUserService updateUserService,
            IChangePasswordService changePasswordService,
            IItemHistoryService itemHistoryService,
            PasswordValidator passwordValidator)
        {
            InitializeComponent();
            _registerUserService = registerUserService;
            _writeItemService = writeItemService;
            _filterItensService = filterItensService;
            _updateItemService = updateItemService;
            _getUserProfileService = getUserProfileService;
            _updateUserService = updateUserService;
            _changePasswordService = changePasswordService;
            _itemHistoryService = itemHistoryService;
            _passwordValidator = passwordValidator;
        }

        private async void mainForm_Load(object sender, EventArgs e)
        {
            var result = await _getUserProfileService.GetUserProfileAsync();
            var firstName = result!.Name.Split()[0];

            welcomeMenuItem.Text += $"{firstName}!";
        }

        private void cadastrarUsuarioMenuItem_Click(object sender, EventArgs e)
        {
            var userRegisterForm = new UserRegisterForm(_registerUserService);
            userRegisterForm.ShowDialog();
        }

        private void cadastrarItemMenuItem_Click(object sender, EventArgs e)
        {
            var itemRegisterForm = new ItemForm(_writeItemService, _updateItemService);
            itemRegisterForm.ShowDialog();
        }

        private void visualizarItemMenuItem_Click(object sender, EventArgs e)
        {
            var itemListForm = new ItemListForm(_filterItensService, _writeItemService, _updateItemService, _itemHistoryService);
            itemListForm.ShowDialog();
        }

        private async void userProfileMenuItem_Click(object sender, EventArgs e)
        {
            var response = await _getUserProfileService.GetUserProfileAsync();
            var profileUiModel = new UserProfileUiModel(response!.Name, response.Email, "Admin");

            var profileForm = new ProfileForm(_updateUserService, profileUiModel);
            profileForm.Show();
        }

        private void changePasswordMenuItem_Click(object sender, EventArgs e)
        {
            var changePasswordForm = new ChangePasswordForm(_changePasswordService, _passwordValidator);
            changePasswordForm.ShowDialog();
        }
    }
}
