using InventoryControl.Communication.Enums;
using InventoryControl.Communication.Requests;
using InventoryControl.Exceptions;
using InventoryControl.Exceptions.ExceptionsBase;
using InventoryControl.UI.WinForms.Exceptions;
using InventoryControl.UI.WinForms.Exceptions.Handlers;
using InventoryControl.UI.WinForms.Helpers;
using InventoryControl.UI.WinForms.Services.User.Register;
using System.Data;

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
            if (roleComboBox.SelectedItem is not Roles role)
                throw new ErrorOnValidationException([ResourceMessagesException.ROLE_NOT_SUPORTED]);

            var request = new RequestRegisterUserJson
            {
                Name = nameText.Text,
                Email = emailText.Text,
                Password = passwordText.Text,
                Role = role
            };

            var result = await _registerUserService.RegisterAsync(request);

            MessageBox.Show($"Usuário registrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        });
    }

    private void UserRegisterForm_Load(object sender, EventArgs e)
    {
        roleComboBox.DataSource = Enum.GetValues(typeof(Roles));
        StandardValues.SetComboBoxValue(roleComboBox);
    }
}
