namespace InventoryControl.UI.WinForms.Helpers;

public static class MessagesHelper
{
    public static void Success(string message, string title = "Sucesso")
    {
        MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    public static DialogResult Confirm(string message, string title = "Confirmar")
    {
        return MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
    }

    public static DialogResult Error(string message, string title = "Erro")
    {
        return MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
    }


    public static DialogResult Alert(string message, string title = "Erro")
    {
        return MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
}
