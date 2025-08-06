using InventoryControl.Communication.Enums;
using InventoryControl.Communication.Requests;
using InventoryControl.Exceptions;
using InventoryControl.Exceptions.ExceptionsBase;
using InventoryControl.UI.WinForms.Services.Helpers;
using InventoryControl.UI.WinForms.Services.Interfaces.Item;

namespace InventoryControl.UI.WinForms.Forms
{
    public partial class ItemRegisterForm : Form
    {
        private readonly IRegisterItemService _registerItemService;

        public ItemRegisterForm(IRegisterItemService registerItemService)
        {
            InitializeComponent();
            _registerItemService = registerItemService;

            // cadastrando enums do radio btn
            estoqueRadioBtn.Tag = ItemStatus.Estoque;
            emUsoRadioBtn.Tag = ItemStatus.Em_Uso;
            defeitoRadioBtn.Tag = ItemStatus.Defeito;

            // cadastrando enums das combo box
            itemDepartmentBox.DataSource = Enum.GetValues(typeof(Department));
            itemTypeBox.DataSource = Enum.GetValues(typeof(ProductType));
            StandardValues.SetComboBoxValue(itemDepartmentBox);
            StandardValues.SetComboBoxValue(itemTypeBox);
        }

        private async void registerBtn_Click(object sender, EventArgs e)
        {
            await ExceptionHandler.TryExecuteAsync(async () =>
            {
                var name = itemNameText.Text;
                var brand = itemBrandText.Text;
                var employee = itemEmployeeText.Text;
                var internalCode = itemCodeText.Text;

                var requiredFields = new[] { name, internalCode };

                if (requiredFields.Any(string.IsNullOrWhiteSpace))
                    throw new ErrorOnValidationException(["Existem campos obrigatórios sem preencher."]);

                if (itemDepartmentBox.SelectedItem is not Department department)
                    throw new ErrorOnValidationException([ResourceMessagesException.DEPARTMENT_NOT_SUPORTED]);

                if (itemTypeBox.SelectedItem is not ProductType productType)
                    throw new ErrorOnValidationException([ResourceMessagesException.PRODUCT_TYPE_NOT_SUPORTED]);

                var status = statusGroupBox
                                .Controls
                                .OfType<RadioButton>()
                                .FirstOrDefault(radioButton => radioButton.Checked)!
                                .Tag as ItemStatus?;

                var request = new RequestItemJson
                {
                    Name = name,
                    Brand = brand,
                    Employee = employee,
                    InternalCode = internalCode,
                    Department = department,
                    ProductType = productType,
                    ItemStatus = status
                };

                var result = await _registerItemService.RegisterAsync(request);

                MessageBox.Show("Item cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CleanForms.CleanFields(Controls);
            });
        }

        private void cleanBtn_Click(object sender, EventArgs e)
        {
            CleanForms.CleanFields(Controls);
            estoqueRadioBtn.Checked = true;
        }

        private void itemCodeText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // cancela o pressionamento da tecla
            }
        }
    }
}
