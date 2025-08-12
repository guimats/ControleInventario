namespace InventoryControl.UI.WinForms.Validators.PasswordRules
{
    public interface IPasswordRuleBase
    {
        string ErrorMessage { get; }
        bool IsValid(string currentPassword, string newPassword, string confirmNewPassword);
    }
}
