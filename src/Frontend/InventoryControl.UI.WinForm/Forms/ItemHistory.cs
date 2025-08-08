using InventoryControl.Communication.Responses;
using InventoryControl.UI.WinForms.Services.Interfaces.ItemHistory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace InventoryControl.UI.WinForms.Forms
{
    public partial class ItemHistory : Form
    {
        private readonly IItemHistoryService _itemHistoryService;
        private readonly long _itemId;

        public ItemHistory(IItemHistoryService itemHistoryService, long id)
        {
            InitializeComponent();
            _itemHistoryService = itemHistoryService;
            _itemId = id;
        }

        private async void ItemHistory_Load(object sender, EventArgs e)
        {
            historyDataGrid.DefaultCellStyle.Font = new Font("Segoe UI", 11);
            historyDataGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);

            var response = await _itemHistoryService.GetItemHistoryAsync(_itemId);


            if (response?.Histories is null)
                return;

            var itemHistory = response.Histories;
            ShortHistory(itemHistory);
        }

        private void ShortHistory(IList<ResponseItemHistoryJson> itemHistory)
        {
            historyDataGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "dataField",
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
                dataField = item.CreatedOn.ToString("dd/MM/yyyy HH:mm"),
                userField = item.UserName,
                typeField = "Alteração" // IMPLEMENTAR
            }).ToList();

            historyDataGrid.AutoGenerateColumns = false;
            historyDataGrid.DataSource = shortFields;
        }
    }
}
