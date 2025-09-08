using InventoryControl.Communication.Requests;
using InventoryControl.UI.WinForms.Exceptions;
using InventoryControl.UI.WinForms.Helpers;
using InventoryControl.UI.WinForms.Services.User.ChangePassword;
using InventoryControl.UI.WinForms.Validators;

namespace InventoryControl.UI.WinForms.Forms
{
    public partial class ChangePasswordForm : Form
    {
        private readonly IChangePasswordService _changePasswordService;
        private readonly PasswordValidator _passwordValidator;
        private readonly ExceptionFilter _exceptionFilter;

        public ChangePasswordForm(
            IChangePasswordService changePasswordService, 
            PasswordValidator passwordValidator, 
            ExceptionFilter exceptionFilter)
        {
            InitializeComponent();
            _changePasswordService = changePasswordService;
            _passwordValidator = passwordValidator;
            _exceptionFilter = exceptionFilter;
        }

        private async void confirmBtn_Click(object sender, EventArgs e)
        {
            var currentPassword = currentPasswordText.Text;
            var newPassword = newPasswordText.Text;
            var confirmNewPassword = validationPasswordText.Text;

            (var isValid, var errorMessage) = _passwordValidator.Validate(newPassword, confirmNewPassword, currentPassword);

            if (!isValid)
            {
                MessagesHelper.Alert(errorMessage!);
                return;
            }

            var request = new RequestChangePasswordJson
            {
                Password = currentPasswordText.Text,
                NewPassword = newPasswordText.Text
            };

            await _exceptionFilter.ExecuteAsync(async () =>
            {
                await _changePasswordService.ChangePasswordAsync(request);

                MessagesHelper.Success("Senha alterada com sucesso!");
                Close();
            });
        }
    }
}
