using InventoryControl.UI.WinForms.DTOs;

namespace InventoryControl.UI.WinForms.Validators.PasswordRules
{
    public interface IPasswordRuleBase
    {
        string ErrorMessage { get; }
        bool IsValid(PasswordValidatorDto context);
    }
}
