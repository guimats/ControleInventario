using InventoryControl.UI.WinForms.Forms;
using InventoryControl.UI.WinForms.Helpers;
using Microsoft.Extensions.DependencyInjection;

namespace InventoryControl.UI.WinForms;

static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        var services = new ServiceCollection();
        services.AddApplication();
        var serviceProvider = services.BuildServiceProvider();

        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        var mainForm = serviceProvider.GetRequiredService<MainForm>();
        var loginForm = serviceProvider.GetRequiredService<LoginForm>();
        var loginResult = loginForm.ShowDialog();

        NavigationHelper.Configure(serviceProvider);

        if (loginResult == DialogResult.OK)
            Application.Run(mainForm);

        //Application.Run(mainForm);
    }
}