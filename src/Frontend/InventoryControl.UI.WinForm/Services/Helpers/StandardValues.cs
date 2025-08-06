namespace InventoryControl.UI.WinForms.Services.Helpers
{
    public static class StandardValues
    {
        public static void SetComboBoxValue(ComboBox comboBox)
        {
            comboBox.SelectedIndex = -1;
            comboBox.Text = "-- Selecione --";
        }
    }
}
