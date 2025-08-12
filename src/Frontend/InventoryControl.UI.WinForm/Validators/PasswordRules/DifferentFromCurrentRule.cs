namespace InventoryControl.UI.WinForms.Validators.PasswordRules;

public class DifferentFromCurrentRule : IPasswordRuleBase
{
    public string ErrorMessage => "Nova senha deve ser diferente da atual.";
    public bool IsValid(string currentPassword, string newPassword, string confirmNewPassword)
        => newPassword != currentPassword;
}
