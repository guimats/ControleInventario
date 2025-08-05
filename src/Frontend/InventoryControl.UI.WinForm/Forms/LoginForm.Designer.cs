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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
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
            emailLabel.Location = new Point(102, 145);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(52, 20);
            emailLabel.TabIndex = 0;
            emailLabel.Text = "E-mail";
            // 
            // emailText
            // 
            emailText.Location = new Point(181, 142);
            emailText.Name = "emailText";
            emailText.Size = new Size(262, 27);
            emailText.TabIndex = 1;
            // 
            // passwordText
            // 
            passwordText.Location = new Point(181, 188);
            passwordText.Name = "passwordText";
            passwordText.PasswordChar = '*';
            passwordText.Size = new Size(262, 27);
            passwordText.TabIndex = 3;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(102, 191);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(49, 20);
            passwordLabel.TabIndex = 2;
            passwordLabel.Text = "Senha";
            // 
            // loginButton
            // 
            loginButton.Location = new Point(231, 250);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(139, 40);
            loginButton.TabIndex = 4;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // loginPictureBox
            // 
            loginPictureBox.Image = (System.Drawing.Image)resources.GetObject("loginPictureBox.Image");
            loginPictureBox.Location = new Point(243, 24);
            loginPictureBox.Name = "loginPictureBox";
            loginPictureBox.Size = new Size(97, 86);
            loginPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            loginPictureBox.TabIndex = 5;
            loginPictureBox.TabStop = false;
            // 
            // LoginForm
            // 
            AcceptButton = loginButton;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(594, 328);
            Controls.Add(loginPictureBox);
            Controls.Add(loginButton);
            Controls.Add(passwordText);
            Controls.Add(passwordLabel);
            Controls.Add(emailText);
            Controls.Add(emailLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LoginForm";
            Text = "Controle de Inventário";
            Load += LoginForm_Load;
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