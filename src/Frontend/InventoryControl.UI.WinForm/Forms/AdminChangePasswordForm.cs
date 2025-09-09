using InventoryControl.Communication.Requests;
using InventoryControl.UI.WinForms.Exceptions;
using InventoryControl.UI.WinForms.Helpers;
using InventoryControl.UI.WinForms.Services.Admin.ChangeUserPassword;
using InventoryControl.UI.WinForms.Validators;

namespace InventoryControl.UI.WinForms.Forms
{
    public partial class AdminChangePasswordForm : Form
    {
        private readonly IAdminChangePasswordService _service;
        private readonly ExceptionFilter _exceptionFilter;
        private readonly PasswordValidator _passwordValidator;
        private readonly long _userId;

        public AdminChangePasswordForm(
            IAdminChangePasswordService service,
            ExceptionFilter exceptionFilter,
            PasswordValidator passwordValidator,
            long userId)
        {
            InitializeComponent();
            _service = service;
            _exceptionFilter = exceptionFilter;
            _passwordValidator = passwordValidator;
            _userId = userId;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void confirmBtn_Click(object sender, EventArgs e)
        {
            var isValid = ValidatePassword();

            if (!isValid)
                return;

            var request = new RequestChangePasswordJson { NewPassword = passwordText.Text };

            await _exceptionFilter.ExecuteAsync(async () =>
            {
                await _service.ChangePasswordAsync(request, _userId);

                MessagesHelper.Success("Senha atualizada com sucesso!");
                Close();
            });
        }

        private bool ValidatePassword()
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

                return false;
            }
            else
            {
                errorLabel.Text = string.Empty;

                passwordText.BackColor = SystemColors.Window;
                confirmPasswordText.BackColor = SystemColors.Window;

                return true;
            }
        }
    }
}
