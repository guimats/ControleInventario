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
            nameTextBox = new TextBox();
            emailTextBox = new TextBox();
            roleLabel = new Label();
            profileImage = new PictureBox();
            leftBtn = new Button();
            rightBtn = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)profileImage).BeginInit();
            SuspendLayout();
            // 
            // nameTextBox
            // 
            nameTextBox.BorderStyle = BorderStyle.None;
            nameTextBox.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameTextBox.Location = new Point(63, 121);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.ReadOnly = true;
            nameTextBox.Size = new Size(306, 20);
            nameTextBox.TabIndex = 1;
            nameTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // emailTextBox
            // 
            emailTextBox.BorderStyle = BorderStyle.None;
            emailTextBox.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            emailTextBox.Location = new Point(63, 159);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.ReadOnly = true;
            emailTextBox.Size = new Size(306, 20);
            emailTextBox.TabIndex = 3;
            emailTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roleLabel.Location = new Point(141, 201);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new Size(81, 20);
            roleLabel.TabIndex = 4;
            roleLabel.Text = "Permissão:";
            roleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // profileImage
            // 
            profileImage.Image = Properties.Resources.user_icon;
            profileImage.Location = new Point(168, 12);
            profileImage.Name = "profileImage";
            profileImage.Size = new Size(93, 93);
            profileImage.SizeMode = PictureBoxSizeMode.StretchImage;
            profileImage.TabIndex = 6;
            profileImage.TabStop = false;
            // 
            // leftBtn
            // 
            leftBtn.Location = new Point(91, 266);
            leftBtn.Name = "leftBtn";
            leftBtn.Size = new Size(120, 42);
            leftBtn.TabIndex = 7;
            leftBtn.Text = "Alterar";
            leftBtn.UseVisualStyleBackColor = true;
            leftBtn.Click += leftBtn_Click;
            // 
            // rightBtn
            // 
            rightBtn.Location = new Point(217, 266);
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
            label1.Location = new Point(219, 201);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 9;
            label1.Text = "Admin";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ProfileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 326);
            Controls.Add(label1);
            Controls.Add(rightBtn);
            Controls.Add(leftBtn);
            Controls.Add(profileImage);
            Controls.Add(roleLabel);
            Controls.Add(emailTextBox);
            Controls.Add(nameTextBox);
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
        private TextBox nameTextBox;
        private TextBox emailTextBox;
        private Label roleLabel;
        private PictureBox profileImage;
        private Button leftBtn;
        private Button rightBtn;
        private Label label1;
    }
}