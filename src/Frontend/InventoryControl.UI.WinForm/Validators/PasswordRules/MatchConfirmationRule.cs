using InventoryControl.UI.WinForms.DTOs;

namespace InventoryControl.UI.WinForms.Validators.PasswordRules;

public class MatchConfirmationRule : IPasswordRuleBase
{
    public string ErrorMessage => "As senhas novas devem ser iguais.";
    public bool IsValid(PasswordValidatorDto context)
        => context.NewPassword == context.ConfirmPassword;
}
