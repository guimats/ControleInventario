namespace InventoryControl.UI.WinForms.Forms
{
    partial class ChangePasswordForm
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
            currentPasswordLabel = new Label();
            currentPasswordText = new TextBox();
            newPasswordText = new TextBox();
            newPasswordLabel = new Label();
            validationPasswordText = new TextBox();
            validationPasswordLabel = new Label();
            confirmBtn = new Button();
            SuspendLayout();
            // 
            // currentPasswordLabel
            // 
            currentPasswordLabel.AutoSize = true;
            currentPasswordLabel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            currentPasswordLabel.Location = new Point(25, 40);
            currentPasswordLabel.Name = "currentPasswordLabel";
            currentPasswordLabel.Size = new Size(82, 17);
            currentPasswordLabel.TabIndex = 0;
            currentPasswordLabel.Text = "Senha atual:";
            // 
            // currentPasswordText
            // 
            currentPasswordText.Location = new Point(113, 37);
            currentPasswordText.Name = "currentPasswordText";
            currentPasswordText.PasswordChar = '*';
            currentPasswordText.Size = new Size(147, 25);
            currentPasswordText.TabIndex = 1;
            // 
            // newPasswordText
            // 
            newPasswordText.Location = new Point(113, 78);
            newPasswordText.Name = "newPasswordText";
            newPasswordText.PasswordChar = '*';
            newPasswordText.Size = new Size(147, 25);
            newPasswordText.TabIndex = 3;
            // 
            // newPasswordLabel
            // 
            newPasswordLabel.AutoSize = true;
            newPasswordLabel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newPasswordLabel.Location = new Point(25, 81);
            newPasswordLabel.Name = "newPasswordLabel";
            newPasswordLabel.Size = new Size(83, 17);
            newPasswordLabel.TabIndex = 2;
            newPasswordLabel.Text = "Nova senha:";
            // 
            // validationPasswordText
            // 
            validationPasswordText.Location = new Point(113, 118);
            validationPasswordText.Name = "validationPasswordText";
            validationPasswordText.PasswordChar = '*';
            validationPasswordText.Size = new Size(147, 25);
            validationPasswordText.TabIndex = 5;
            // 
            // validationPasswordLabel
            // 
            validationPasswordLabel.AutoSize = true;
            validationPasswordLabel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            validationPasswordLabel.Location = new Point(14, 121);
            validationPasswordLabel.Name = "validationPasswordLabel";
            validationPasswordLabel.Size = new Size(94, 17);
            validationPasswordLabel.TabIndex = 4;
            validationPasswordLabel.Text = "Repetir senha:";
            // 
            // confirmBtn
            // 
            confirmBtn.Location = new Point(113, 175);
            confirmBtn.Name = "confirmBtn";
            confirmBtn.Size = new Size(96, 38);
            confirmBtn.TabIndex = 6;
            confirmBtn.Text = "Alterar";
            confirmBtn.UseVisualStyleBackColor = true;
            confirmBtn.Click += confirmBtn_Click;
            // 
            // ChangePasswordForm
            // 
            AcceptButton = confirmBtn;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(321, 234);
            Controls.Add(confirmBtn);
            Controls.Add(validationPasswordText);
            Controls.Add(validationPasswordLabel);
            Controls.Add(newPasswordText);
            Controls.Add(newPasswordLabel);
            Controls.Add(currentPasswordText);
            Controls.Add(currentPasswordLabel);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaximizeBox = false;
            Name = "ChangePasswordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alterar senha";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label currentPasswordLabel;
        private TextBox currentPasswordText;
        private TextBox newPasswordText;
        private Label newPasswordLabel;
        private TextBox validationPasswordText;
        private Label validationPasswordLabel;
        private Button confirmBtn;
    }
}