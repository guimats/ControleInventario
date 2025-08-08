namespace InventoryControl.UI.WinForms.Forms
{
    partial class UserRegisterForm
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
            nameLabel = new Label();
            nameText = new TextBox();
            emailText = new TextBox();
            emailLabel = new Label();
            passwordText = new TextBox();
            passwordLabel = new Label();
            registerBtn = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameLabel.Location = new Point(49, 99);
            nameLabel.Margin = new Padding(4, 0, 4, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(53, 21);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Nome";
            // 
            // nameText
            // 
            nameText.Location = new Point(121, 99);
            nameText.Name = "nameText";
            nameText.Size = new Size(219, 29);
            nameText.TabIndex = 1;
            // 
            // emailText
            // 
            emailText.Location = new Point(121, 144);
            emailText.Name = "emailText";
            emailText.Size = new Size(219, 29);
            emailText.TabIndex = 3;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.BackColor = SystemColors.Control;
            emailLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailLabel.Location = new Point(49, 144);
            emailLabel.Margin = new Padding(4, 0, 4, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(54, 21);
            emailLabel.TabIndex = 2;
            emailLabel.Text = "E-mail";
            // 
            // passwordText
            // 
            passwordText.Location = new Point(121, 187);
            passwordText.Name = "passwordText";
            passwordText.PasswordChar = '*';
            passwordText.Size = new Size(219, 29);
            passwordText.TabIndex = 5;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.BackColor = SystemColors.Control;
            passwordLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordLabel.Location = new Point(49, 190);
            passwordLabel.Margin = new Padding(4, 0, 4, 0);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(53, 21);
            passwordLabel.TabIndex = 4;
            passwordLabel.Text = "Senha";
            // 
            // registerBtn
            // 
            registerBtn.BackColor = SystemColors.ControlLight;
            registerBtn.FlatStyle = FlatStyle.Popup;
            registerBtn.Location = new Point(164, 238);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(113, 44);
            registerBtn.TabIndex = 6;
            registerBtn.Text = "Cadastrar";
            registerBtn.UseVisualStyleBackColor = false;
            registerBtn.Click += registerBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user_icon;
            pictureBox1.Location = new Point(176, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(73, 69);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // UserRegisterForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 291);
            Controls.Add(pictureBox1);
            Controls.Add(registerBtn);
            Controls.Add(passwordText);
            Controls.Add(passwordLabel);
            Controls.Add(emailText);
            Controls.Add(emailLabel);
            Controls.Add(nameText);
            Controls.Add(nameLabel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "UserRegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Usuário";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private TextBox nameText;
        private TextBox emailText;
        private Label emailLabel;
        private TextBox passwordText;
        private Label passwordLabel;
        private Button registerBtn;
        private PictureBox pictureBox1;
    }
}