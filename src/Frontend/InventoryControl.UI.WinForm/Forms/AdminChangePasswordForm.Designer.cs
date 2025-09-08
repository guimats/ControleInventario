namespace InventoryControl.UI.WinForms.Forms
{
    partial class AdminChangePasswordForm
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
            passwordLabel = new Label();
            passwordText = new TextBox();
            confirmPasswordText = new TextBox();
            confirmPasswordLabel = new Label();
            confirmBtn = new Button();
            cancelBtn = new Button();
            errorLabel = new Label();
            SuspendLayout();
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(43, 70);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(86, 20);
            passwordLabel.TabIndex = 0;
            passwordLabel.Text = "Nova senha";
            // 
            // passwordText
            // 
            passwordText.Location = new Point(135, 70);
            passwordText.Name = "passwordText";
            passwordText.PasswordChar = '*';
            passwordText.Size = new Size(187, 27);
            passwordText.TabIndex = 1;
            // 
            // confirmPasswordText
            // 
            confirmPasswordText.Location = new Point(135, 122);
            confirmPasswordText.Name = "confirmPasswordText";
            confirmPasswordText.PasswordChar = '*';
            confirmPasswordText.Size = new Size(187, 27);
            confirmPasswordText.TabIndex = 3;
            // 
            // confirmPasswordLabel
            // 
            confirmPasswordLabel.AutoSize = true;
            confirmPasswordLabel.Location = new Point(12, 122);
            confirmPasswordLabel.Name = "confirmPasswordLabel";
            confirmPasswordLabel.Size = new Size(117, 20);
            confirmPasswordLabel.TabIndex = 2;
            confirmPasswordLabel.Text = "Confirmar senha";
            // 
            // confirmBtn
            // 
            confirmBtn.Location = new Point(195, 204);
            confirmBtn.Name = "confirmBtn";
            confirmBtn.Size = new Size(100, 37);
            confirmBtn.TabIndex = 4;
            confirmBtn.Text = "Salvar";
            confirmBtn.UseVisualStyleBackColor = true;
            confirmBtn.Click += confirmBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(89, 204);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(100, 37);
            cancelBtn.TabIndex = 5;
            cancelBtn.Text = "Cancelar";
            cancelBtn.UseVisualStyleBackColor = true;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            errorLabel.ForeColor = Color.Firebrick;
            errorLabel.Location = new Point(135, 55);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(0, 12);
            errorLabel.TabIndex = 6;
            errorLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // AdminChangePasswordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 266);
            Controls.Add(errorLabel);
            Controls.Add(cancelBtn);
            Controls.Add(confirmBtn);
            Controls.Add(confirmPasswordText);
            Controls.Add(confirmPasswordLabel);
            Controls.Add(passwordText);
            Controls.Add(passwordLabel);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AdminChangePasswordForm";
            Text = "Alterar senha";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label passwordLabel;
        private TextBox passwordText;
        private TextBox confirmPasswordText;
        private Label confirmPasswordLabel;
        private Button cancelBtn;
        private Button confirmBtn;
        private Label errorLabel;
    }
}