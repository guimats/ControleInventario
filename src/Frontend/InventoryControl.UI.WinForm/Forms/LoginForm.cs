using InventoryControl.UI.WinForms.Services.User.Auth;

namespace InventoryControl.UI.WinForms.Forms
{
    public partial class LoginForm : Form
    {
        private readonly IAuthService _authService;

        public LoginForm(IAuthService authService)
        {
            InitializeComponent();
            _authService = authService;
        }

        private async void loginButton_Click(object sender, EventArgs e)
        {
            var result = await _authService.LoginAsync(emailText.Text, passwordText.Text);
            if (result.Valid)
            {
                MessageBox.Show(result.Message[0], "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show(result.Message[0], "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
