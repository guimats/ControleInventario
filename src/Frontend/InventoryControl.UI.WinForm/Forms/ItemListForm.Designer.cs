namespace InventoryControl.UI.WinForms.Forms
{
    partial class ItemListForm
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
            filterDepartmentLabel = new Label();
            departmentListBox = new CheckedListBox();
            filterCodeText = new TextBox();
            filterCodeLabel = new Label();
            filterNameText = new TextBox();
            filterNameLabel = new Label();
            filterGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // filterGroupBox
            // 
            filterGroupBox.Controls.Add(filterDepartmentLabel);
            filterGroupBox.Controls.Add(departmentListBox);
            filterGroupBox.Controls.Add(filterCodeText);
            filterGroupBox.Controls.Add(filterCodeLabel);
            filterGroupBox.Controls.Add(filterNameText);
            filterGroupBox.Controls.Add(filterNameLabel);
            filterGroupBox.Location = new Point(14, 4);
            filterGroupBox.Name = "filterGroupBox";
            filterGroupBox.Size = new Size(862, 186);
            filterGroupBox.TabIndex = 0;
            filterGroupBox.TabStop = false;
            filterGroupBox.Text = "Filtros";
            // 
            // filterDepartmentLabel
            // 
            filterDepartmentLabel.AutoSize = true;
            filterDepartmentLabel.Location = new Point(296, 22);
            filterDepartmentLabel.Name = "filterDepartmentLabel";
            filterDepartmentLabel.Size = new Size(121, 23);
            filterDepartmentLabel.TabIndex = 5;
            filterDepartmentLabel.Text = "Departamento";
            // 
            // departmentListBox
            // 
            departmentListBox.FormattingEnabled = true;
            departmentListBox.Items.AddRange(new object[] { "" });
            departmentListBox.Location = new Point(296, 48);
            departmentListBox.Name = "departmentListBox";
            departmentListBox.Size = new Size(157, 104);
            departmentListBox.TabIndex = 4;
            // 
            // filterCodeText
            // 
            filterCodeText.Location = new Point(87, 107);
            filterCodeText.Name = "filterCodeText";
            filterCodeText.Size = new Size(151, 30);
            filterCodeText.TabIndex = 3;
            // 
            // filterCodeLabel
            // 
            filterCodeLabel.AutoSize = true;
            filterCodeLabel.Location = new Point(16, 110);
            filterCodeLabel.Name = "filterCodeLabel";
            filterCodeLabel.Size = new Size(65, 23);
            filterCodeLabel.TabIndex = 2;
            filterCodeLabel.Text = "Código";
            // 
            // filterNameText
            // 
            filterNameText.Location = new Point(87, 59);
            filterNameText.Name = "filterNameText";
            filterNameText.Size = new Size(151, 30);
            filterNameText.TabIndex = 1;
            // 
            // filterNameLabel
            // 
            filterNameLabel.AutoSize = true;
            filterNameLabel.Location = new Point(16, 62);
            filterNameLabel.Name = "filterNameLabel";
            filterNameLabel.Size = new Size(57, 23);
            filterNameLabel.TabIndex = 0;
            filterNameLabel.Text = "Nome";
            // 
            // ItemListForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1595, 716);
            Controls.Add(filterGroupBox);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "ItemListForm";
            Text = "Listar Itens";
            filterGroupBox.ResumeLayout(false);
            filterGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox filterGroupBox;
        private TextBox filterCodeText;
        private Label filterCodeLabel;
        private TextBox filterNameText;
        private Label filterNameLabel;
        private CheckedListBox departmentListBox;
        private Label filterDepartmentLabel;
    }
}