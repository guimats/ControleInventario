namespace InventoryControl.UI.WinForms.Forms
{
    partial class ItemForm
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
            itemNameLabel = new Label();
            itemNameText = new TextBox();
            itemBrandText = new TextBox();
            itemBrandLabel = new Label();
            itemEmployeeText = new TextBox();
            itemEmployeeLabel = new Label();
            itemCodeText = new TextBox();
            itemCodeLabel = new Label();
            itemDepartmentLabel = new Label();
            itemDepartmentBox = new ComboBox();
            itemTypeBox = new ComboBox();
            itemTypeLabel = new Label();
            itemStatusLabel = new Label();
            productGroupBox = new GroupBox();
            statusGroupBox = new GroupBox();
            defeitoRadioBtn = new RadioButton();
            emUsoRadioBtn = new RadioButton();
            estoqueRadioBtn = new RadioButton();
            cleanBtn = new Button();
            saveBtn = new Button();
            productGroupBox.SuspendLayout();
            statusGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // itemNameLabel
            // 
            itemNameLabel.AutoSize = true;
            itemNameLabel.Location = new Point(22, 40);
            itemNameLabel.Name = "itemNameLabel";
            itemNameLabel.Size = new Size(47, 17);
            itemNameLabel.TabIndex = 0;
            itemNameLabel.Text = "Nome:";
            // 
            // itemNameText
            // 
            itemNameText.Location = new Point(142, 40);
            itemNameText.Name = "itemNameText";
            itemNameText.Size = new Size(255, 25);
            itemNameText.TabIndex = 1;
            // 
            // itemBrandText
            // 
            itemBrandText.Location = new Point(142, 73);
            itemBrandText.Name = "itemBrandText";
            itemBrandText.Size = new Size(255, 25);
            itemBrandText.TabIndex = 2;
            // 
            // itemBrandLabel
            // 
            itemBrandLabel.AutoSize = true;
            itemBrandLabel.Location = new Point(23, 73);
            itemBrandLabel.Name = "itemBrandLabel";
            itemBrandLabel.Size = new Size(48, 17);
            itemBrandLabel.TabIndex = 2;
            itemBrandLabel.Text = "Marca:";
            // 
            // itemEmployeeText
            // 
            itemEmployeeText.Location = new Point(142, 36);
            itemEmployeeText.Name = "itemEmployeeText";
            itemEmployeeText.Size = new Size(255, 25);
            itemEmployeeText.TabIndex = 4;
            // 
            // itemEmployeeLabel
            // 
            itemEmployeeLabel.AutoSize = true;
            itemEmployeeLabel.Location = new Point(23, 38);
            itemEmployeeLabel.Name = "itemEmployeeLabel";
            itemEmployeeLabel.Size = new Size(78, 17);
            itemEmployeeLabel.TabIndex = 4;
            itemEmployeeLabel.Text = "Funcionário:";
            // 
            // itemCodeText
            // 
            itemCodeText.Location = new Point(142, 106);
            itemCodeText.Name = "itemCodeText";
            itemCodeText.Size = new Size(255, 25);
            itemCodeText.TabIndex = 3;
            itemCodeText.KeyPress += itemCodeText_KeyPress;
            // 
            // itemCodeLabel
            // 
            itemCodeLabel.AutoSize = true;
            itemCodeLabel.Location = new Point(22, 106);
            itemCodeLabel.Name = "itemCodeLabel";
            itemCodeLabel.Size = new Size(54, 17);
            itemCodeLabel.TabIndex = 6;
            itemCodeLabel.Text = "Código:";
            // 
            // itemDepartmentLabel
            // 
            itemDepartmentLabel.AutoSize = true;
            itemDepartmentLabel.Location = new Point(22, 72);
            itemDepartmentLabel.Name = "itemDepartmentLabel";
            itemDepartmentLabel.Size = new Size(95, 17);
            itemDepartmentLabel.TabIndex = 8;
            itemDepartmentLabel.Text = "Departamento:";
            // 
            // itemDepartmentBox
            // 
            itemDepartmentBox.FormattingEnabled = true;
            itemDepartmentBox.Location = new Point(142, 69);
            itemDepartmentBox.Name = "itemDepartmentBox";
            itemDepartmentBox.Size = new Size(255, 25);
            itemDepartmentBox.TabIndex = 5;
            itemDepartmentBox.Text = "-- Selecione --";
            // 
            // itemTypeBox
            // 
            itemTypeBox.FormattingEnabled = true;
            itemTypeBox.Location = new Point(142, 103);
            itemTypeBox.Name = "itemTypeBox";
            itemTypeBox.Size = new Size(255, 25);
            itemTypeBox.TabIndex = 6;
            itemTypeBox.Text = "-- Selecione --";
            // 
            // itemTypeLabel
            // 
            itemTypeLabel.AutoSize = true;
            itemTypeLabel.Location = new Point(23, 106);
            itemTypeLabel.Name = "itemTypeLabel";
            itemTypeLabel.Size = new Size(37, 17);
            itemTypeLabel.TabIndex = 10;
            itemTypeLabel.Text = "Tipo:";
            // 
            // itemStatusLabel
            // 
            itemStatusLabel.AutoSize = true;
            itemStatusLabel.Location = new Point(23, 140);
            itemStatusLabel.Name = "itemStatusLabel";
            itemStatusLabel.Size = new Size(46, 17);
            itemStatusLabel.TabIndex = 12;
            itemStatusLabel.Text = "Status:";
            // 
            // productGroupBox
            // 
            productGroupBox.Controls.Add(itemNameText);
            productGroupBox.Controls.Add(itemNameLabel);
            productGroupBox.Controls.Add(itemBrandLabel);
            productGroupBox.Controls.Add(itemBrandText);
            productGroupBox.Controls.Add(itemCodeLabel);
            productGroupBox.Controls.Add(itemCodeText);
            productGroupBox.Location = new Point(19, 32);
            productGroupBox.Name = "productGroupBox";
            productGroupBox.Size = new Size(443, 158);
            productGroupBox.TabIndex = 14;
            productGroupBox.TabStop = false;
            productGroupBox.Text = "Dados do produto";
            // 
            // statusGroupBox
            // 
            statusGroupBox.Controls.Add(defeitoRadioBtn);
            statusGroupBox.Controls.Add(emUsoRadioBtn);
            statusGroupBox.Controls.Add(estoqueRadioBtn);
            statusGroupBox.Controls.Add(itemEmployeeLabel);
            statusGroupBox.Controls.Add(itemEmployeeText);
            statusGroupBox.Controls.Add(itemStatusLabel);
            statusGroupBox.Controls.Add(itemDepartmentLabel);
            statusGroupBox.Controls.Add(itemDepartmentBox);
            statusGroupBox.Controls.Add(itemTypeBox);
            statusGroupBox.Controls.Add(itemTypeLabel);
            statusGroupBox.Location = new Point(19, 206);
            statusGroupBox.Name = "statusGroupBox";
            statusGroupBox.Size = new Size(443, 182);
            statusGroupBox.TabIndex = 15;
            statusGroupBox.TabStop = false;
            statusGroupBox.Text = "Classificação e Status";
            // 
            // defeitoRadioBtn
            // 
            defeitoRadioBtn.AutoSize = true;
            defeitoRadioBtn.Location = new Point(316, 140);
            defeitoRadioBtn.Name = "defeitoRadioBtn";
            defeitoRadioBtn.Size = new Size(68, 21);
            defeitoRadioBtn.TabIndex = 10;
            defeitoRadioBtn.Text = "Defeito";
            defeitoRadioBtn.UseVisualStyleBackColor = true;
            // 
            // emUsoRadioBtn
            // 
            emUsoRadioBtn.AutoSize = true;
            emUsoRadioBtn.Location = new Point(232, 140);
            emUsoRadioBtn.Name = "emUsoRadioBtn";
            emUsoRadioBtn.Size = new Size(69, 21);
            emUsoRadioBtn.TabIndex = 9;
            emUsoRadioBtn.Text = "Em uso";
            emUsoRadioBtn.UseVisualStyleBackColor = true;
            // 
            // estoqueRadioBtn
            // 
            estoqueRadioBtn.AutoSize = true;
            estoqueRadioBtn.Checked = true;
            estoqueRadioBtn.Location = new Point(142, 140);
            estoqueRadioBtn.Name = "estoqueRadioBtn";
            estoqueRadioBtn.Size = new Size(73, 21);
            estoqueRadioBtn.TabIndex = 8;
            estoqueRadioBtn.TabStop = true;
            estoqueRadioBtn.Text = "Estoque";
            estoqueRadioBtn.UseVisualStyleBackColor = true;
            // 
            // cleanBtn
            // 
            cleanBtn.Location = new Point(267, 409);
            cleanBtn.Name = "cleanBtn";
            cleanBtn.Size = new Size(90, 35);
            cleanBtn.TabIndex = 11;
            cleanBtn.Text = "Limpar";
            cleanBtn.UseVisualStyleBackColor = true;
            cleanBtn.Click += cleanBtn_Click;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(372, 409);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(90, 35);
            saveBtn.TabIndex = 12;
            saveBtn.Text = "Salvar";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // ItemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 455);
            Controls.Add(saveBtn);
            Controls.Add(cleanBtn);
            Controls.Add(statusGroupBox);
            Controls.Add(productGroupBox);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "ItemForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Item";
            Load += ItemForm_Load;
            productGroupBox.ResumeLayout(false);
            productGroupBox.PerformLayout();
            statusGroupBox.ResumeLayout(false);
            statusGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label itemNameLabel;
        private TextBox itemNameText;
        private TextBox itemBrandText;
        private Label itemBrandLabel;
        private TextBox itemEmployeeText;
        private Label itemEmployeeLabel;
        private TextBox itemCodeText;
        private Label itemCodeLabel;
        private Label itemDepartmentLabel;
        private ComboBox itemDepartmentBox;
        private ComboBox itemTypeBox;
        private Label itemTypeLabel;
        private Label itemStatusLabel;
        private GroupBox productGroupBox;
        private GroupBox statusGroupBox;
        private RadioButton defeitoRadioBtn;
        private RadioButton emUsoRadioBtn;
        private RadioButton estoqueRadioBtn;
        private Button cleanBtn;
        private Button saveBtn;
    }
}