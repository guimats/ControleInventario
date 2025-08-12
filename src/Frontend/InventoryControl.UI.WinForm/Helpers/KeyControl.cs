namespace InventoryControl.UI.WinForms.Helpers;

public static class KeyControl
{
    public static void OnlyNumeric(KeyPressEventArgs e)
    {
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
        {
            e.Handled = true; // cancela o pressionamento da tecla
        }
    }
}
