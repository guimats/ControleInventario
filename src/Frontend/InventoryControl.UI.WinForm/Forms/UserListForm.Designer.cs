namespace InventoryControl.UI.WinForms.Forms
{
    partial class UserListForm
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
            filterGroupBox = new GroupBox();
            totalLabel = new Label();
            searchBtn = new Button();
            permissionGroupBox = new GroupBox();
            readerPermission = new RadioButton();
            adminPermission = new RadioButton();
            userPermission = new RadioButton();
            cleanBtn = new Button();
            emailText = new TextBox();
            emailLabel = new Label();
            nameText = new TextBox();
            nameLabel = new Label();
            userGroupBox = new GroupBox();
            userDataGrid = new DataGridView();
            filterGroupBox.SuspendLayout();
            permissionGroupBox.SuspendLayout();
            userGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userDataGrid).BeginInit();
            SuspendLayout();
            // 
            // filterGroupBox
            // 
            filterGroupBox.Controls.Add(totalLabel);
            filterGroupBox.Controls.Add(searchBtn);
            filterGroupBox.Controls.Add(permissionGroupBox);
            filterGroupBox.Controls.Add(cleanBtn);
            filterGroupBox.Controls.Add(emailText);
            filterGroupBox.Controls.Add(emailLabel);
            filterGroupBox.Controls.Add(nameText);
            filterGroupBox.Controls.Add(nameLabel);
            filterGroupBox.Location = new Point(12, 12);
            filterGroupBox.Name = "filterGroupBox";
            filterGroupBox.Size = new Size(775, 186);
            filterGroupBox.TabIndex = 0;
            filterGroupBox.TabStop = false;
            filterGroupBox.Text = "Filtros";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalLabel.Location = new Point(36, 149);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(140, 20);
            totalLabel.TabIndex = 8;
            totalLabel.Text = "Total de usuários: 0";
            // 
            // searchBtn
            // 
            searchBtn.Location = new Point(601, 149);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(109, 31);
            searchBtn.TabIndex = 7;
            searchBtn.Text = "Pesquisar";
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += searchBtn_Click;
            // 
            // permissionGroupBox
            // 
            permissionGroupBox.Controls.Add(readerPermission);
            permissionGroupBox.Controls.Add(adminPermission);
            permissionGroupBox.Controls.Add(userPermission);
            permissionGroupBox.Location = new Point(445, 26);
            permissionGroupBox.Name = "permissionGroupBox";
            permissionGroupBox.Size = new Size(264, 100);
            permissionGroupBox.TabIndex = 4;
            permissionGroupBox.TabStop = false;
            permissionGroupBox.Text = "Permissão";
            // 
            // readerPermission
            // 
            readerPermission.AutoSize = true;
            readerPermission.Location = new Point(183, 46);
            readerPermission.Name = "readerPermission";
            readerPermission.Size = new Size(72, 24);
            readerPermission.TabIndex = 2;
            readerPermission.TabStop = true;
            readerPermission.Text = "Leitura";
            readerPermission.UseVisualStyleBackColor = true;
            // 
            // adminPermission
            // 
            adminPermission.AutoSize = true;
            adminPermission.Location = new Point(106, 46);
            adminPermission.Name = "adminPermission";
            adminPermission.Size = new Size(71, 24);
            adminPermission.TabIndex = 1;
            adminPermission.TabStop = true;
            adminPermission.Text = "Admin";
            adminPermission.UseVisualStyleBackColor = true;
            // 
            // userPermission
            // 
            userPermission.AutoSize = true;
            userPermission.Location = new Point(23, 46);
            userPermission.Name = "userPermission";
            userPermission.Size = new Size(77, 24);
            userPermission.TabIndex = 0;
            userPermission.TabStop = true;
            userPermission.Text = "Usuário";
            userPermission.UseVisualStyleBackColor = true;
            // 
            // cleanBtn
            // 
            cleanBtn.Location = new Point(486, 149);
            cleanBtn.Name = "cleanBtn";
            cleanBtn.Size = new Size(109, 31);
            cleanBtn.TabIndex = 6;
            cleanBtn.Text = "Limpar";
            cleanBtn.UseVisualStyleBackColor = true;
            // 
            // emailText
            // 
            emailText.Location = new Point(92, 92);
            emailText.Name = "emailText";
            emailText.RightToLeft = RightToLeft.No;
            emailText.Size = new Size(230, 27);
            emailText.TabIndex = 3;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(36, 95);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(52, 20);
            emailLabel.TabIndex = 2;
            emailLabel.Text = "E-mail";
            // 
            // nameText
            // 
            nameText.Location = new Point(92, 44);
            nameText.Name = "nameText";
            nameText.Size = new Size(230, 27);
            nameText.TabIndex = 1;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(36, 47);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(50, 20);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Nome";
            // 
            // userGroupBox
            // 
            userGroupBox.Controls.Add(userDataGrid);
            userGroupBox.Location = new Point(12, 204);
            userGroupBox.Name = "userGroupBox";
            userGroupBox.Size = new Size(775, 367);
            userGroupBox.TabIndex = 2;
            userGroupBox.TabStop = false;
            userGroupBox.Text = "Usuários";
            // 
            // userDataGrid
            // 
            userDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userDataGrid.Location = new Point(6, 26);
            userDataGrid.Name = "userDataGrid";
            userDataGrid.Size = new Size(773, 335);
            userDataGrid.TabIndex = 0;
            // 
            // UserListForm
            // 
            AcceptButton = searchBtn;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 583);
            Controls.Add(userGroupBox);
            Controls.Add(filterGroupBox);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "UserListForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista de usuários";
            filterGroupBox.ResumeLayout(false);
            filterGroupBox.PerformLayout();
            permissionGroupBox.ResumeLayout(false);
            permissionGroupBox.PerformLayout();
            userGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)userDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox filterGroupBox;
        private GroupBox permissionGroupBox;
        private TextBox emailText;
        private Label emailLabel;
        private TextBox nameText;
        private Label nameLabel;
        private RadioButton adminPermission;
        private RadioButton userPermission;
        private RadioButton readerPermission;
        private GroupBox userGroupBox;
        private DataGridView userDataGrid;
        private Button searchBtn;
        private Button cleanBtn;
        private Label totalLabel;
    }
}