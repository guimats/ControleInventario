using InventoryControl.UI.WinForms.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace InventoryControl.UI.WinForms.Helpers;

public static class NavigationHelper
{
    private static IServiceProvider? _serviceProvider;
    private static Form? mainForm;

    public static void Configure(IServiceProvider serviceProvider) => _serviceProvider = serviceProvider;

    public static void ShowLoginForm()
    {
        foreach (Form form in Application.OpenForms.Cast<Form>().ToList())
        {
            if (form == Application.OpenForms[0])
            {
                mainForm = form;
                mainForm.Hide();
            }
            else
                form.Close();
        }

        mainForm!.BeginInvoke((Action)(() =>
        {
            var loginForm = _serviceProvider!.GetRequiredService<LoginForm>();
            MessagesHelper.Alert("Sua sessão espirou. Faça login novamente!");
            var dialogResult = loginForm.ShowDialog();

            if (dialogResult == DialogResult.OK)
                mainForm!.Show();
        }));
    }
}
