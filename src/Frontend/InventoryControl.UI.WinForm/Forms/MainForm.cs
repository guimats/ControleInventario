using InventoryControl.UI.WinForms.Models;
using InventoryControl.UI.WinForms.Services.Interfaces.User;
using InventoryControl.UI.WinForms.Services.Providers;

namespace InventoryControl.UI.WinForms.Forms
{
    public partial class mainForm : Form
    {
        private readonly IGetUserProfileService _getUserProfileService;

        public mainForm(IGetUserProfileService getUserProfileService)
        {
            InitializeComponent();
            _getUserProfileService = getUserProfileService;
        }

        private async void mainForm_Load(object sender, EventArgs e)
        {
            var result = await _getUserProfileService.GetUserProfileAsync();
            var firstName = result!.Name.Split()[0];

            welcomeMenuItem.Text += $"{firstName}!";
        }

        private void cadastrarUsuarioMenuItem_Click(object sender, EventArgs e)
        {
            var userRegisterForm = new UserRegisterForm(ServiceProvider.RegisterUserService);
            userRegisterForm.ShowDialog();
        }

        private void cadastrarItemMenuItem_Click(object sender, EventArgs e)
        {
            var itemRegisterForm = new ItemForm(ServiceProvider.RegisterItemService);
            itemRegisterForm.ShowDialog();
        }

        private void visualizarItemMenuItem_Click(object sender, EventArgs e)
        {
            var itemListForm = new ItemListForm(ServiceProvider.FilterItensService, ServiceProvider.DeleteItemService);
            itemListForm.ShowDialog();
        }

        private async void userProfileMenuItem_Click(object sender, EventArgs e)
        {
            var response = await _getUserProfileService.GetUserProfileAsync();
            var profileUiModel = new UserProfileUiModel(response!.Name, response.Email, "Admin");

            var profileForm = new ProfileForm(profileUiModel);
            profileForm.Show();
        }
    }
}
