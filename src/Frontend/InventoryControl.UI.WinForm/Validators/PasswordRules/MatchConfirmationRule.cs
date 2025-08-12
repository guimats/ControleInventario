namespace InventoryControl.UI.WinForms.Validators.PasswordRules;

public class MatchConfirmationRule : IPasswordRuleBase
{
    public string ErrorMessage => "As senhas novas devem ser iguais.";
    public bool IsValid(string currentPassword, string newPassword, string confirmNewPassword)
        => newPassword == confirmNewPassword;
}
