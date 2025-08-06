using InventoryControl.Exceptions.ExceptionsBase;
using InventoryControl.UI.WinForms.Services.Helpers;
using InventoryControl.UI.WinForms.Services.Interfaces.User;

namespace InventoryControl.UI.WinForms.Forms;

public partial class UserRegisterForm : Form
{
    private readonly IRegisterUserService _registerUserService;

    public UserRegisterForm(IRegisterUserService registerUserService)
    {
        InitializeComponent();
        _registerUserService = registerUserService;
    }

    private async void registerBtn_Click(object sender, EventArgs e)
    {
        await ExceptionHandler.TryExecuteAsync(async () =>
        {
            var result = await _registerUserService.RegisterAsync(nameText.Text, emailText.Text, passwordText.Text);

            MessageBox.Show($"Usuário registrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        });
    }
}
