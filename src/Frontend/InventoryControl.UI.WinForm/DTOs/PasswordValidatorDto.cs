namespace InventoryControl.UI.WinForms.DTOs;

public class PasswordValidatorDto
{
    public string NewPassword { get; }
    public string ConfirmPassword { get; }
    public string? CurrentPassword { get; }
    public bool RequireCurrentPassword { get; }

    public PasswordValidatorDto(
        string newPassword, 
        string confirmPassword, 
        string? currentPassword,
        bool requireCurrentPassword = true) 
    {
        NewPassword = newPassword;
        ConfirmPassword = confirmPassword;
        CurrentPassword = currentPassword;
        RequireCurrentPassword = requireCurrentPassword;
    }
}
