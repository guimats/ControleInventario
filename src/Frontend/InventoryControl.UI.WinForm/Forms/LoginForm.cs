using InventoryControl.UI.WinForms.Services.Interfaces;

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
            var resultado = await _authService.LoginAsync(emailText.Text, passwordText.Text);

            if (resultado.Valid)
            {
                MessageBox.Show(resultado.Message[0], "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show(resultado.Message[0], "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
