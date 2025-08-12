using InventoryControl.UI.WinForms.Validators.PasswordRules;

namespace InventoryControl.UI.WinForms.Validators;

public class PasswordValidator
{
    private readonly IEnumerable<IPasswordRuleBase> _rules;

    public PasswordValidator(IEnumerable<IPasswordRuleBase> rules)
    {
        _rules = rules;
    }

    public (bool IsValid, string? ErrorMessage) Validate(string currentPassword, string newPassword, string confirmPassword)
    {
        foreach(var rule in _rules)
        {
            if (!rule.IsValid(currentPassword, newPassword, confirmPassword))
                return (false, rule.ErrorMessage);
        }
        return (true, null);
    }
}
