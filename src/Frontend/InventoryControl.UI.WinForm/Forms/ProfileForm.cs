using InventoryControl.Communication.Responses;
using InventoryControl.UI.WinForms.CommonUtilities;
using InventoryControl.UI.WinForms.Models;

namespace InventoryControl.UI.WinForms.Forms
{
    public partial class ProfileForm : Form
    {
        private readonly UserProfileUiModel _profile;

        public ProfileForm(UserProfileUiModel profile)
        {
            InitializeComponent();
            _profile = profile;
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            nameTextBox.Text = _profile.Name;
            emailTextBox.Text = _profile.Email;

            SwitchTextsState();
        }

        private void leftBtn_Click(object sender, EventArgs e)
        {
            if (leftBtn.Text == "Alterar")
                SwitchTextsState(editProfile: true);

            else if (leftBtn.Text == "Cancelar")
                SwitchTextsState();
        }

        private void rightBtn_Click(object sender, EventArgs e)
        {
            if (rightBtn.Text == "OK")
                Close();

            else if (rightBtn.Text == "Salvar")
            {
                var dialogResult = MessagesHelper.Confirm("Deseja realmente salvar?");

                if (dialogResult == DialogResult.OK)
                    SwitchTextsState();
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

                return;
            }

            // desabilitando os campos de texto por padrão
            textBox.ReadOnly = true;
            textBox.TabStop = false;
            textBox.BackColor = SystemColors.Control;
            textBox.GotFocus += TextBox_RemoveFocus;
        }

        private void SwitchTextsState(bool editProfile = false)
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
    }
}
