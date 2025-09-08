using InventoryControl.UI.WinForms.DTOs;

namespace InventoryControl.UI.WinForms.Validators.PasswordRules;

public class DifferentFromCurrentRule : IPasswordRuleBase
{
    public string ErrorMessage => "Nova senha deve ser diferente da atual.";
    public bool IsValid(PasswordValidatorDto context)
    {
        if (!context.RequireCurrentPassword)
            return true;

        return context.NewPassword != context.CurrentPassword;
    }
}
