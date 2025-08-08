using InventoryControl.Communication.Enums;
using InventoryControl.Communication.Requests;
using InventoryControl.Communication.Responses;
using InventoryControl.UI.WinForms.CommonUtilities;
using InventoryControl.UI.WinForms.Services.Helpers;
using InventoryControl.UI.WinForms.Services.Interfaces.Item;
using InventoryControl.UI.WinForms.Services.Providers;
using System.ComponentModel;

namespace InventoryControl.UI.WinForms.Forms;

public partial class ItemListForm : Form
{
    private readonly IFilterItensService _filterItensService;
    private readonly IDeleteItemService _deleteItemService;
    private List<ResponseItemJson> _cachedItems = [];

    public ItemListForm(IFilterItensService filterItensService, IDeleteItemService deleteItemService)
    {
        InitializeComponent();
        _filterItensService = filterItensService;
        _deleteItemService = deleteItemService;

        AcceptButton = searchBtn;
        CheckBoxHelper.CreateCheckBoxes<Department>(departmentGroupBox);
        CheckBoxHelper.CreateCheckBoxes<ProductType>(productTypeGroupBox);

        // cadastrando enums do radio btn
        estoqueRadioBtn.Tag = ItemStatus.Estoque;
        emUsoRadioBtn.Tag = ItemStatus.Em_Uso;
        defeitoRadioBtn.Tag = ItemStatus.Defeito;

        itensDataGrid.ContextMenuStrip = itemMenuStrip;
    }

    private void filterCodeText_KeyPress(object sender, KeyPressEventArgs e)
    {
        KeyControl.OnlyNumeric(e);
    }

    private async void searchBtn_Click(object sender, EventArgs e)
    {
        await ExceptionHandler.TryExecuteAsync(async () =>
        {
            var selectedRadioBtn = statusGroupBox
                            .Controls
                            .OfType<RadioButton>()
                            .FirstOrDefault(radioButton => radioButton.Checked);

            var status = selectedRadioBtn?.Tag as ItemStatus?;

            var request = new RequestFilterItemJson
            {
                ItemName = filterNameText.Text,
                InternalCode = filterCodeText.Text,
                Departments = CheckBoxHelper.GetValues<Department>(departmentGroupBox),
                ProductTypes = CheckBoxHelper.GetValues<ProductType>(productTypeGroupBox),
                ItemStatus = status
            };

            var response = await _filterItensService.FilterItensAsync(request);

            itensGroupBox.Visible = true;

            if (response?.Itens is null)
            {
                _cachedItems.Clear();
                itensDataGrid.DataSource = null;
                totalLabel.Text = "Total de itens: 0";
                return;
            }

            var itens = response!.Itens;

            _cachedItems = itens.ToList();
            itensDataGrid.DataSource = itens.ToList();

            totalLabel.Text = $"Total de itens: {itens.Count}";
        });
    }

    private void clenFilterBtn_Click(object sender, EventArgs e)
    {
        CleanForms.CleanFields(Controls);
    }

    private void itensDataGrid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
    {
        if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
        {
            itensDataGrid.ClearSelection(); // limpando seleções anteriores
            itensDataGrid.Rows[e.RowIndex].Selected = true; // selecionando
            itensDataGrid.CurrentCell = itensDataGrid.Rows[e.RowIndex].Cells[0]; // prevenção de problemas
        }
    }

    private async void deleteItem_Click(object sender, EventArgs e)
    {
        // pegando a linha selecionada e recuperando o item
        var selectedRow = itensDataGrid.SelectedRows[0];
        var item = (ResponseItemJson)selectedRow.DataBoundItem;

        var confirm = MessageBox.Show(
            $"Deseja realmente excluir o item '{item.Name} - {item.Brand}'",
            "Corfirmar Exclusão",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);

        if (confirm == DialogResult.Yes)
        {
            await _deleteItemService.DeleteItemAsync(item.Id);
            MessagesHelper.Success("Item excluído com sucesso!");

            RemoveItemFromGrid(item);
        }
    }

    private void editItem_Click(object sender, EventArgs e)
    {
        var selectedRow = itensDataGrid.SelectedRows[0];
        var item = (ResponseItemJson)selectedRow.DataBoundItem;

        var itemForm = new ItemForm(ServiceProvider.RegisterItemService, item);
        itemForm.ShowDialog();
    }

    private void ItemListForm_FormClosed(object sender, FormClosedEventArgs e)
    {
        _cachedItems.Clear();
    }

    private void RemoveItemFromGrid(ResponseItemJson item)
    {
        _cachedItems.Remove(item);
        itensDataGrid.DataSource = new BindingList<ResponseItemJson>(_cachedItems);
        totalLabel.Text = $"Total de itens: {_cachedItems.Count}";
    }

    private void historyItem_Click(object sender, EventArgs e)
    {
        var selectedRow = itensDataGrid.SelectedRows[0];
        var item = (ResponseItemJson)selectedRow.DataBoundItem;

        var itemHistoryForm = new ItemHistory(ServiceProvider.ItemHistoryService, item.Id);
        itemHistoryForm.ShowDialog();
    }
}
