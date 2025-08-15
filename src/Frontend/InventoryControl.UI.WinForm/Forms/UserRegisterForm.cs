using InventoryControl.UI.WinForms.Exceptions;
using InventoryControl.UI.WinForms.Exceptions.Handlers;
using InventoryControl.UI.WinForms.Services.User.Register;

namespace InventoryControl.UI.WinForms.Forms;

public partial class UserRegisterForm : Form
{
    private readonly IRegisterUserService _registerUserService;
    private readonly ExceptionFilter _exceptionFilter;

    public UserRegisterForm(IRegisterUserService registerUserService, ExceptionFilter exceptionFilter)
    {
        InitializeComponent();
        _registerUserService = registerUserService;
        _exceptionFilter = exceptionFilter;
    }

    private async void registerBtn_Click(object sender, EventArgs e)
    {
        await _exceptionFilter.ExecuteAsync(async () =>
        {
            var result = await _registerUserService.RegisterAsync(nameText.Text, emailText.Text, passwordText.Text);

            MessageBox.Show($"Usuário registrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        });
    }
}
