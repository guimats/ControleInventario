using InventoryControl.Communication.Responses;
using InventoryControl.UI.WinForms.Exceptions;
using InventoryControl.UI.WinForms.Services.ItemHistory;
using System.Data;

namespace InventoryControl.UI.WinForms.Forms;

public partial class ItemHistory : Form
{
    private readonly IItemHistoryService _itemHistoryService;
    private readonly ExceptionFilter _exceptionFilter;
    private readonly long _itemId;
    private IList<ResponseItemHistoryJson> _itemHistory;

    public ItemHistory(IItemHistoryService itemHistoryService, ExceptionFilter exceptionFilter, long id)
    {
        InitializeComponent();
        _itemHistoryService = itemHistoryService;
        _exceptionFilter = exceptionFilter;
        _itemId = id;
        _itemHistory = [];
    }

    private async void ItemHistory_Load(object sender, EventArgs e)
    {
        historyDataGrid.DefaultCellStyle.Font = new Font("Segoe UI", 11);
        historyDataGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);

        await _exceptionFilter.ExecuteAsync(async () =>
        {
            var response = await _itemHistoryService.GetItemHistoryAsync(_itemId);

            if (response?.Histories is null)
                return;

            _itemHistory = response.Histories;
            ShortHistory(_itemHistory);
        });
    }

    private void ShortHistory(IList<ResponseItemHistoryJson> itemHistory)
    {
        historyDataGrid.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "Id",
            DataPropertyName = "idField",
            HeaderText = "ID",
            Width = 50
        });

        historyDataGrid.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "dateField",
            HeaderText = "Data da modificação",
            Width = 250
        });

        historyDataGrid.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "userField",
            HeaderText = "Usúário",
            Width = 150
        });

        historyDataGrid.Columns.Add(new DataGridViewTextBoxColumn
        {
            DataPropertyName = "typeField",
            HeaderText = "Tipo",
            Width = 150
        });

        var shortFields = itemHistory.Select(item => new
        {
            idField = item.Id,
            dateField = item.CreatedOn.ToString("dd/MM/yyyy HH:mm"),
            userField = item.UserName,
            typeField = "Alteração" // IMPLEMENTAR
        }).ToList();

        historyDataGrid.AutoGenerateColumns = false;
        historyDataGrid.DataSource = shortFields;
    }

    private void historyDataGrid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left && e.RowIndex >= 0)
        {
            historyDataGrid.ClearSelection(); // limpando seleções anteriores
            historyDataGrid.Rows[e.RowIndex].Selected = true; // selecionando
            historyDataGrid.CurrentCell = historyDataGrid.Rows[e.RowIndex].Cells[0]; // prevenção de problemas

            var historyId = historyDataGrid.Rows[e.RowIndex].Cells["Id"].Value;

            var selectedHistory = _itemHistory.FirstOrDefault(h => h.Id == (long)historyId);

            var longHistory = new LongHistoryForm(selectedHistory!);
            longHistory.ShowDialog();
        }       
    }
}
