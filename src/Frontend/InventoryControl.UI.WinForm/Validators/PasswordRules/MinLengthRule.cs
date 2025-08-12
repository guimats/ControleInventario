namespace InventoryControl.UI.WinForms.Validators.PasswordRules;

public class MinLengthRule : IPasswordRuleBase
{
    public string ErrorMessage => "A senha deve ter mais de 6 caracteres.";
    public bool IsValid(string currentPassword, string newPassword, string confirmNewPassword)
        => newPassword.Length >= 6;
}
