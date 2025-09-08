using InventoryControl.UI.WinForms.DTOs;

namespace InventoryControl.UI.WinForms.Validators.PasswordRules;

public class NotEmptyRule : IPasswordRuleBase
{
    public string ErrorMessage => "Todos os campos devem estar preenchidos.";

    public bool IsValid(PasswordValidatorDto context)
    {
        if (context.RequireCurrentPassword && string.IsNullOrWhiteSpace(context.CurrentPassword))
            return false;

        if (string.IsNullOrWhiteSpace(context.NewPassword))
            return false;

        if (string.IsNullOrWhiteSpace(context.ConfirmPassword))
            return false;

        return true;
    }
}
