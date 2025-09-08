using InventoryControl.UI.WinForms.DTOs;
using InventoryControl.UI.WinForms.Validators.PasswordRules;

namespace InventoryControl.UI.WinForms.Validators;

public class PasswordValidator
{
    private readonly IEnumerable<IPasswordRuleBase> _rules;

    public PasswordValidator(IEnumerable<IPasswordRuleBase> rules)
    {
        _rules = rules;
    }

    public (bool IsValid, string? ErrorMessage) Validate(string newPassword, string confirmPassword, string currentPassword)
    {
        var context = new PasswordValidatorDto(newPassword, confirmPassword, currentPassword);
        return ValidateContext(context);
    }

    // Cenário admin: não precisa da senha atual
    public (bool IsValid, string? ErrorMessage) Validate(string newPassword, string confirmPassword)
    {
        var context = new PasswordValidatorDto(newPassword, confirmPassword, null, false);
        return ValidateContext(context);
    }

    private (bool IsValid, string? ErrorMessage) ValidateContext(PasswordValidatorDto context)
    {
        foreach (var rule in _rules)
        {
            if (!rule.IsValid(context))
                return (false, rule.ErrorMessage);
        }
        return (true, null);
    }
}
