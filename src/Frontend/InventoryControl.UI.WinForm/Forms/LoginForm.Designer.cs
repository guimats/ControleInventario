using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace InventoryControl.UI.WinForms.Forms
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            emailLabel = new Label();
            emailText = new TextBox();
            passwordText = new TextBox();
            passwordLabel = new Label();
            loginButton = new Button();
            loginPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)loginPictureBox).BeginInit();
            SuspendLayout();
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(53, 119);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(41, 15);
            emailLabel.TabIndex = 0;
            emailLabel.Text = "E-mail";
            // 
            // emailText
            // 
            emailText.Location = new Point(122, 116);
            emailText.Margin = new Padding(3, 2, 3, 2);
            emailText.Name = "emailText";
            emailText.Size = new Size(230, 23);
            emailText.TabIndex = 1;
            // 
            // passwordText
            // 
            passwordText.Location = new Point(122, 151);
            passwordText.Margin = new Padding(3, 2, 3, 2);
            passwordText.Name = "passwordText";
            passwordText.PasswordChar = '*';
            passwordText.Size = new Size(230, 23);
            passwordText.TabIndex = 3;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(53, 153);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(39, 15);
            passwordLabel.TabIndex = 2;
            passwordLabel.Text = "Senha";
            // 
            // loginButton
            // 
            loginButton.Location = new Point(166, 198);
            loginButton.Margin = new Padding(3, 2, 3, 2);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(122, 30);
            loginButton.TabIndex = 4;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // loginPictureBox
            // 
            loginPictureBox.Image = Properties.Resources.logo_inventario;
            loginPictureBox.Location = new Point(176, 11);
            loginPictureBox.Margin = new Padding(3, 2, 3, 2);
            loginPictureBox.Name = "loginPictureBox";
            loginPictureBox.Size = new Size(85, 85);
            loginPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            loginPictureBox.TabIndex = 5;
            loginPictureBox.TabStop = false;
            // 
            // LoginForm
            // 
            AcceptButton = loginButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 264);
            Controls.Add(loginPictureBox);
            Controls.Add(loginButton);
            Controls.Add(passwordText);
            Controls.Add(passwordLabel);
            Controls.Add(emailText);
            Controls.Add(emailLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Controle de Inventário";
            ((System.ComponentModel.ISupportInitialize)loginPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label emailLabel;
        private TextBox emailText;
        private TextBox passwordText;
        private Label passwordLabel;
        private Button loginButton;
        private PictureBox loginPictureBox;
    }
}