using InventoryControl.UI.WinForms.DTOs;

namespace InventoryControl.UI.WinForms.Validators.PasswordRules;

public class MinLengthRule : IPasswordRuleBase
{
    public string ErrorMessage => "A senha deve ter mais de 6 caracteres.";
    public bool IsValid(PasswordValidatorDto context)
        => context.NewPassword.Length >= 6;
}
