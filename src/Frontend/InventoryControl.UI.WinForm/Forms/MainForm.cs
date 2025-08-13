using InventoryControl.UI.WinForms.Factories;
using InventoryControl.UI.WinForms.Models;
using InventoryControl.UI.WinForms.Services.Interfaces.User;

namespace InventoryControl.UI.WinForms.Forms
{
    public partial class MainForm : Form
    {
        private readonly IFormFactory _formFactory;
        private readonly IGetUserProfileService _getUserProfileService;

        public MainForm(
            IFormFactory formFactory,
            IGetUserProfileService userProfileService)
        {
            InitializeComponent();
            _formFactory = formFactory;
            _getUserProfileService = userProfileService;
        }

        private async void mainForm_Load(object sender, EventArgs e)
        {
            var result = await _getUserProfileService.GetUserProfileAsync();
            var firstName = result!.Name.Split()[0];

            welcomeMenuItem.Text += $"{firstName}!";
        }

        private void cadastrarUsuarioMenuItem_Click(object sender, EventArgs e)
        {
            var userRegisterForm = _formFactory.Create<UserRegisterForm>();
            userRegisterForm.ShowDialog();
        }

        private void cadastrarItemMenuItem_Click(object sender, EventArgs e)
        {
            var itemRegisterForm = _formFactory.Create<ItemForm>();
            itemRegisterForm.ShowDialog();
        }

        private void visualizarItemMenuItem_Click(object sender, EventArgs e)
        {
            var itemListForm = _formFactory.Create<ItemListForm>();
            itemListForm.ShowDialog();
        }

        private async void userProfileMenuItem_Click(object sender, EventArgs e)
        {
            var response = await _getUserProfileService.GetUserProfileAsync();
            var profileUiModel = new UserProfileUiModel(response!.Name, response.Email, "Admin");

            var profileForm = _formFactory.Create<ProfileForm>(form => form.ConfigureProfile(profileUiModel));
            profileForm.Show();
        }

        private void changePasswordMenuItem_Click(object sender, EventArgs e)
        {
            var changePasswordForm = _formFactory.Create<ChangePasswordForm>();
            changePasswordForm.ShowDialog();
        }
    }
}
