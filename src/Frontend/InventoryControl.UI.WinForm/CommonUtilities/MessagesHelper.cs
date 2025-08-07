namespace InventoryControl.UI.WinForms.CommonUtilities;

public static class MessagesHelper
{
    public static void Success(string message, string title = "Sucesso")
    {
        MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
