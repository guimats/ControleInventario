using InventoryControl.Communication.Requests;
using InventoryControl.UI.WinForms.Exceptions;
using InventoryControl.UI.WinForms.Helpers;
using InventoryControl.UI.WinForms.Models;
using InventoryControl.UI.WinForms.Services.User.Update;

namespace InventoryControl.UI.WinForms.Forms
{
    public partial class ProfileForm : Form
    {
        private readonly IUpdateUserService _updateUserService;
        private readonly ExceptionFilter _exceptionFilter;
        private UserProfileUiModel? _profile;

        public ProfileForm(IUpdateUserService updateUserService, ExceptionFilter exceptionFilter)
        {
            InitializeComponent();
            _updateUserService = updateUserService;
            _exceptionFilter = exceptionFilter;
        }

        public void ConfigureProfile(UserProfileUiModel profile)
        {
            _profile = profile;
            nameTextBox.Text = _profile.Name;
            emailTextBox.Text = _profile.Email;
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            SwitchBtnState();
        }

        private void leftBtn_Click(object sender, EventArgs e)
        {
            if (leftBtn.Text == "Alterar")
                SwitchBtnState(editProfile: true);

            else if (leftBtn.Text == "Cancelar")
            {
                nameTextBox.Text = _profile!.Name;
                emailTextBox.Text = _profile.Email;
                SwitchBtnState();
            }
        }

        private async void rightBtn_Click(object sender, EventArgs e)
        {
            if (rightBtn.Text == "OK")
            {
                Close();
                return;
            }

            var dialogResult = MessagesHelper.Confirm("Deseja realmente salvar?");

            if (dialogResult == DialogResult.Yes)
            {
                await _exceptionFilter.ExecuteAsync(async () =>
                {
                    await _updateUserService.UpdateUser(BuildUpdateRequest());

                    _profile = _profile! with { Name = nameTextBox.Text, Email = emailTextBox.Text };

                    MessagesHelper.Success("Usuário atualizado com sucesso!");
                    SwitchBtnState();
                });
            }
        }

        private void SetTextBox(TextBox textBox, bool editProfile = false)
        {
            // habilitando campos de texto quando editProfile for true
            if (editProfile)
            {
                textBox.ReadOnly = false;
                textBox.TabStop = true;
                textBox.BackColor = SystemColors.Window;
                textBox.GotFocus -= TextBox_RemoveFocus;
                textBox.BorderStyle = BorderStyle.Fixed3D;

                return;
            }

            // desabilitando os campos de texto por padrão
            textBox.ReadOnly = true;
            textBox.TabStop = false;
            textBox.BackColor = SystemColors.Control;
            textBox.GotFocus += TextBox_RemoveFocus;
            textBox.BorderStyle = BorderStyle.None;
        }

        private void SwitchBtnState(bool editProfile = false)
        {
            SetTextBox(nameTextBox, editProfile);
            SetTextBox(emailTextBox, editProfile);

            if (editProfile)
            {
                leftBtn.Text = "Cancelar";
                rightBtn.Text = "Salvar";
                return;
            }

            leftBtn.Text = "Alterar";
            rightBtn.Text = "OK";
        }

        private void TextBox_RemoveFocus(object? sender, EventArgs e)
        {
            this.SelectNextControl((Control)sender!, true, true, true, true);
        }

        private RequestUpdateUserJson BuildUpdateRequest()
        {
            return new RequestUpdateUserJson
            {
                Name = nameTextBox.Text,
                Email = emailTextBox.Text
            };
        }
    }
}
