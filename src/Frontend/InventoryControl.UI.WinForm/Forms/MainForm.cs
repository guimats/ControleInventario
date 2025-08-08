using InventoryControl.UI.WinForms.Services.Providers;

namespace InventoryControl.UI.WinForms.Forms
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void cadastrarUsuarioMenuItem_Click(object sender, EventArgs e)
        {
            var userRegisterForm = new UserRegisterForm(ServiceProvider.RegisterUserService);
            userRegisterForm.ShowDialog();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var itemRegisterForm = new ItemForm(ServiceProvider.RegisterItemService);
            itemRegisterForm.ShowDialog();
        }

        private void visualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var itemListForm = new ItemListForm(ServiceProvider.FilterItensService, ServiceProvider.DeleteItemService);
            itemListForm.ShowDialog();
        }
    }
}
