using InventoryControl.Communication.Responses;
using InventoryControl.UI.WinForms.Helpers;
using System.Text.Json;

namespace InventoryControl.UI.WinForms.Forms;

public partial class LongHistoryForm : Form
{
    private readonly ResponseItemHistoryJson _selectedHistory;

    public LongHistoryForm(ResponseItemHistoryJson selectedHistory)
    {
        InitializeComponent();
        _selectedHistory = selectedHistory;
    }

    private void LongHistoryForm_Load(object sender, EventArgs e)
    {
        DataGridHelper.ConfigureFont(longHistoryDataGrid);

        // transformando dados de string para JSON
        var oldData = JsonSerializer.Deserialize<Dictionary<string, object>>(_selectedHistory.OldData!);
        var newData = JsonSerializer.Deserialize<Dictionary<string, object>>(_selectedHistory.NewData!);

        var comparisonList = new List<DataComparison>();

        // pegando todas as chaves uniques com Union
        var allKeys = oldData!.Keys.Union(newData!.Keys);

        foreach (var key in allKeys)
        {
            // pulando chaves que não foram definidas no mapeamento
            if (!MapHelpers.FieldNameMap.ContainsKey(key))
                continue;

            // criando um novo DataComparation (linha do data grid) com os dados antigos e novos
            comparisonList.Add(new DataComparison
            {
                Field = MapHelpers.FieldNameMap[key],
                OldValue = oldData.ContainsKey(key) ? ConvertWhenEnum(key, oldData[key]) : "",
                NewValue = newData.ContainsKey(key) ? ConvertWhenEnum(key, newData[key]) : ""
            });
        }

        longHistoryDataGrid.DataSource = comparisonList;
    }

    private void longHistoryDataGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
        // alterando cor do fundo da célula se dados forem diferentes
        if (longHistoryDataGrid.Rows[e.RowIndex].DataBoundItem is DataComparison comparison)
        {
            if (e.ColumnIndex == longHistoryDataGrid.Columns["OldValue"].Index ||
            e.ColumnIndex == longHistoryDataGrid.Columns["NewValue"].Index)
            {
                if (comparison.OldValue != comparison.NewValue)
                    e.CellStyle!.BackColor = ColorTranslator.FromHtml("#EF847A");
            }
        }
    }

    private void longHistoryDataGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
    {
        longHistoryDataGrid.Columns["Field"].HeaderText = "Campo";

        longHistoryDataGrid.Columns["OldValue"].Width = 200;
        longHistoryDataGrid.Columns["OldValue"].HeaderText = "Valor Antigo";

        longHistoryDataGrid.Columns["NewValue"].Width = 200;
        longHistoryDataGrid.Columns["NewValue"].HeaderText = "Valor Novo";
    }

    // função para converter o valor númerico do Enum para o Nome (se for Enum)
    private string ConvertWhenEnum(string key, object? value)
    {
        if (value == null) return "";

        if (MapHelpers.EnumFieldsMap.ContainsKey(key))
        {
            var enumType = MapHelpers.EnumFieldsMap[key]; // pega o tipo do enum
            if (int.TryParse(value.ToString(), out int intValue))
                return Enum.GetName(enumType, intValue) ?? value.ToString()!; // retorna o nome do Enum (ou o int se o GetName for nulo)
        }

        return value.ToString() ?? "";
    }
}

public class DataComparison
{
    public string Field { get; set; } = "";
    public string OldValue { get; set; } = "";
    public string NewValue { get; set; } = "";
}
