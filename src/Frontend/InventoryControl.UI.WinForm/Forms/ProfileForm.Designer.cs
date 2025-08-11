namespace InventoryControl.UI.WinForms.Forms
{
    partial class ProfileForm
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
            nameTextBox = new TextBox();
            emailTextBox = new TextBox();
            emailLabel = new Label();
            roleLabel = new Label();
            profileImage = new PictureBox();
            leftBtn = new Button();
            rightBtn = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)profileImage).BeginInit();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameLabel.Location = new Point(51, 136);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(55, 20);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Nome:";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(112, 136);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.ReadOnly = true;
            nameTextBox.Size = new Size(244, 27);
            nameTextBox.TabIndex = 1;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(111, 184);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.ReadOnly = true;
            emailTextBox.Size = new Size(244, 27);
            emailTextBox.TabIndex = 3;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            emailLabel.Location = new Point(49, 187);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(56, 20);
            emailLabel.TabIndex = 2;
            emailLabel.Text = "E-mail:";
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roleLabel.Location = new Point(26, 235);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new Size(81, 20);
            roleLabel.TabIndex = 4;
            roleLabel.Text = "Permissão:";
            // 
            // profileImage
            // 
            profileImage.Image = Properties.Resources.user_icon;
            profileImage.Location = new Point(171, 12);
            profileImage.Name = "profileImage";
            profileImage.Size = new Size(93, 93);
            profileImage.SizeMode = PictureBoxSizeMode.StretchImage;
            profileImage.TabIndex = 6;
            profileImage.TabStop = false;
            // 
            // leftBtn
            // 
            leftBtn.Location = new Point(96, 277);
            leftBtn.Name = "leftBtn";
            leftBtn.Size = new Size(120, 42);
            leftBtn.TabIndex = 7;
            leftBtn.Text = "Alterar";
            leftBtn.UseVisualStyleBackColor = true;
            leftBtn.Click += leftBtn_Click;
            // 
            // rightBtn
            // 
            rightBtn.Location = new Point(222, 277);
            rightBtn.Name = "rightBtn";
            rightBtn.Size = new Size(120, 42);
            rightBtn.TabIndex = 8;
            rightBtn.Text = "OK";
            rightBtn.UseVisualStyleBackColor = true;
            rightBtn.Click += rightBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(113, 235);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 9;
            label1.Text = "Admin";
            // 
            // ProfileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 331);
            Controls.Add(label1);
            Controls.Add(rightBtn);
            Controls.Add(leftBtn);
            Controls.Add(profileImage);
            Controls.Add(roleLabel);
            Controls.Add(emailTextBox);
            Controls.Add(emailLabel);
            Controls.Add(nameTextBox);
            Controls.Add(nameLabel);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "ProfileForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Perfil";
            Load += ProfileForm_Load;
            ((System.ComponentModel.ISupportInitialize)profileImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private TextBox nameTextBox;
        private TextBox emailTextBox;
        private Label emailLabel;
        private Label roleLabel;
        private PictureBox profileImage;
        private Button leftBtn;
        private Button rightBtn;
        private Label label1;
    }
}