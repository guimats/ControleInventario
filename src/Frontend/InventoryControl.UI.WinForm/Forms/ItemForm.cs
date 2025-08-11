using InventoryControl.Communication.Enums;
using InventoryControl.Communication.Requests;
using InventoryControl.Communication.Responses;
using InventoryControl.Exceptions;
using InventoryControl.Exceptions.ExceptionsBase;
using InventoryControl.UI.WinForms.CommonUtilities;
using InventoryControl.UI.WinForms.CommonUtilities.Validators;
using InventoryControl.UI.WinForms.Services.Helpers;
using InventoryControl.UI.WinForms.Services.Interfaces.Item;

namespace InventoryControl.UI.WinForms.Forms
{
    public partial class ItemForm : Form
    {
        private readonly ISaveItemService _saveItemService;
        private readonly ResponseItemJson? _itemToEdit;
        private readonly bool _isEditMode;

        public ItemForm(ISaveItemService registerItemService)
        {
            InitializeComponent();
            _saveItemService = registerItemService;

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

        public ItemForm(ISaveItemService registerItemService, ResponseItemJson item) : this(registerItemService)
        {
            _itemToEdit = item;
            _isEditMode = true;
        }

        private void ItemForm_Load(object sender, EventArgs e)
        {
            // carregando informações do item (se for editar)
            if (_isEditMode && _itemToEdit != null)
            {
                Text = "Atualizar Item";

                itemNameText.Text = _itemToEdit.Name;
                itemBrandText.Text = _itemToEdit.Brand;
                itemEmployeeText.Text = _itemToEdit.Employee;
                itemCodeText.Text = _itemToEdit.InternalCode;
                itemDepartmentBox.SelectedItem = _itemToEdit.Department;
                itemTypeBox.SelectedItem = _itemToEdit.ProductType;

                var radioMap = new Dictionary<ItemStatus, RadioButton>
                {
                    { ItemStatus.Estoque, estoqueRadioBtn },
                    { ItemStatus.Em_Uso, emUsoRadioBtn },
                    { ItemStatus.Defeito, defeitoRadioBtn },
                };

               radioMap[_itemToEdit.ItemStatus!.Value].Checked = true;
            }
        }

        private async void saveBtn_Click(object sender, EventArgs e)
        {
            await ExceptionHandler.TryExecuteAsync(async () =>
            {
                var request = BuildRequestFromForm();

                ValidateRequest.Validate(request);

                if (_isEditMode && _itemToEdit != null)
                {
                    await _saveItemService.UpdateAsync(request, _itemToEdit.Id);
                    MessagesHelper.Success("Item atualizado com sucesso!");
                    Close();
                }
                else
                {
                    var result = await _saveItemService.RegisterAsync(request);
                    MessagesHelper.Success("Item cadastro com sucesso");
                }

                CleanForms.CleanFields(Controls);
                estoqueRadioBtn.Checked = true;
            });
        }

        private void cleanBtn_Click(object sender, EventArgs e)
        {
            CleanForms.CleanFields(Controls);
            estoqueRadioBtn.Checked = true;
        }

        private void itemCodeText_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyControl.OnlyNumeric(e);
        }

        private RequestItemJson BuildRequestFromForm()
        {
            if (itemDepartmentBox.SelectedItem is not Department department)
                throw new ErrorOnValidationException([ResourceMessagesException.DEPARTMENT_NOT_SUPORTED]);

            if (itemTypeBox.SelectedItem is not ProductType productType) 
                throw new ErrorOnValidationException([ResourceMessagesException.PRODUCT_TYPE_NOT_SUPORTED]);

            var status = statusGroupBox
                            .Controls
                            .OfType<RadioButton>()
                            .FirstOrDefault(radioButton => radioButton.Checked)!
                            .Tag as ItemStatus?;

            return new RequestItemJson
            {
                Name = itemNameText.Text,
                Brand = itemBrandText.Text,
                Employee = itemEmployeeText.Text,
                InternalCode = itemCodeText.Text,
                Department = department,
                ProductType = productType,
                ItemStatus = status
            };
        }
    }
}
