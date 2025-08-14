using InventoryControl.UI.WinForms.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace InventoryControl.UI.WinForms.Helpers;

public static class NavigationHelper
{
    private static IServiceProvider? _serviceProvider;

    public static void Configure(IServiceProvider serviceProvider) => _serviceProvider = serviceProvider;

    public static void ShowLoginForm()
    {
        foreach (Form form in Application.OpenForms.Cast<Form>().ToList())
        {
            if (form != Application.OpenForms[0])
                form.Close();
        }

        var loginForm = _serviceProvider!.GetRequiredService<LoginForm>();
        loginForm.Show();
    }
}
