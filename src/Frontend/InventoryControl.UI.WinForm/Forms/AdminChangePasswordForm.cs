using InventoryControl.UI.WinForms.Validators;

namespace InventoryControl.UI.WinForms.Forms
{
    public partial class AdminChangePasswordForm : Form
    {
        private readonly PasswordValidator _passwordValidator;
        private readonly long _userId;

        public AdminChangePasswordForm(PasswordValidator passwordValidator, long userId)
        {
            InitializeComponent();
            _passwordValidator = passwordValidator;
            _userId = userId;
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            ValidatePassword();
        }


        private void ValidatePassword()
        {
            var newPassword = passwordText.Text;
            var confirmPassword = confirmPasswordText.Text;

            // Cenário admin: sem senha atual
            var result = _passwordValidator.Validate(newPassword, confirmPassword);

            if (!result.IsValid)
            {
                // Exibe mensagem acima do TextBox
                errorLabel.Text = $"*{result.ErrorMessage}";
                
                passwordText.BackColor = Color.MistyRose;
                confirmPasswordText.BackColor = Color.MistyRose;
            }
            else
            {
                errorLabel.Text = string.Empty;

                passwordText.BackColor = SystemColors.Window;
                confirmPasswordText.BackColor = SystemColors.Window;
            }
        }
    }
}
