using InventoryControl.Communication.Requests;
using InventoryControl.UI.WinForms.Helpers;
using InventoryControl.UI.WinForms.Services.Interfaces.User;
using InventoryControl.UI.WinForms.Validators;

namespace InventoryControl.UI.WinForms.Forms
{
    public partial class ChangePasswordForm : Form
    {
        private readonly IChangePasswordService _changePasswordService;
        private readonly PasswordValidator _passwordValidator;

        public ChangePasswordForm(IChangePasswordService changePasswordService, PasswordValidator passwordValidator)
        {
            InitializeComponent();
            _changePasswordService = changePasswordService;
            _passwordValidator = passwordValidator;
        }

        private async void confirmBtn_Click(object sender, EventArgs e)
        {
            var currentPassword = currentPasswordText.Text;
            var newPassword = newPasswordText.Text;
            var confirmNewPassword = validationPasswordText.Text;

            (var isValid, var errorMessage) = _passwordValidator.Validate(currentPassword, newPassword, confirmNewPassword);

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

            await ExceptionHandler.TryExecuteAsync(async () =>
            {
                var result = await _changePasswordService.ChangePasswordAsync(request);

                if (result)
                {
                    MessagesHelper.Success("Senha alterada com sucesso!");
                    Close();
                }
            });
        }
    }
}
