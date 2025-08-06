using InventoryControl.Communication.Enums;
using System.Windows.Forms;

namespace InventoryControl.UI.WinForms.Forms;

public partial class ItemListForm : Form
{
    public ItemListForm()
    {
        InitializeComponent();

        departmentListBox.DataSource = Enum.GetValues(typeof(Department));
    }
}
