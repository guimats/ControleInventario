namespace InventoryControl.UI.WinForms.CommonUtilities;

public static class MessagesHelper
{
    public static void Success(string message, string title = "Sucesso")
    {
        MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    public static DialogResult Confirm(string message, string title = "Confirmar")
    {
        return MessageBox.Show(message, title, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
    }
}
