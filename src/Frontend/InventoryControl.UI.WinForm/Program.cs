using InventoryControl.UI.WinForms.Services.Providers;

namespace InventoryControl.UI.WinForms.Forms
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            //Application.Run(new ItemListForm());

            var loginForm = new LoginForm(ServiceProvider.AuthService);
            var loginResult = loginForm.ShowDialog();

            if (loginResult == DialogResult.OK)
                Application.Run(new mainForm());
        }
    }
}