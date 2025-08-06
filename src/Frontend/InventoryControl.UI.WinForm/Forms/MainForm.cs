using InventoryControl.UI.WinForms.Services.Providers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
