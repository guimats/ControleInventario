namespace InventoryControl.UI.WinForms.Validators.PasswordRules;

public class NotEmptyRule : IPasswordRuleBase
{
    public string ErrorMessage => "Todos os campos devem estar preenchidos.";

    public bool IsValid(string currentPassword, string newPassword, string confirmNewPassword)
        => !string.IsNullOrWhiteSpace(currentPassword)
           && !string.IsNullOrWhiteSpace(newPassword)
           && !string.IsNullOrWhiteSpace(confirmNewPassword);
}
