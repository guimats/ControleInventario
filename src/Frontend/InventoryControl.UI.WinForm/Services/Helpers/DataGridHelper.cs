namespace InventoryControl.UI.WinForms.Services.Helpers;

public static class DataGridHelper
{
    public static void ConfigureFont(DataGridView dataGrid, uint fontSize = 11)
    {
        dataGrid.DefaultCellStyle.Font = new Font("Segoe UI", fontSize);
        dataGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", fontSize, FontStyle.Bold);
    }
}
