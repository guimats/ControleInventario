namespace InventoryControl.UI.WinForms.Forms
{
    partial class ItemRegisterForm
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
            registerBtn = new Button();
            productGroupBox.SuspendLayout();
            statusGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // itemNameLabel
            // 
            itemNameLabel.AutoSize = true;
            itemNameLabel.Location = new Point(25, 45);
            itemNameLabel.Name = "itemNameLabel";
            itemNameLabel.Size = new Size(65, 25);
            itemNameLabel.TabIndex = 0;
            itemNameLabel.Text = "Nome:";
            // 
            // itemNameText
            // 
            itemNameText.Location = new Point(162, 45);
            itemNameText.Name = "itemNameText";
            itemNameText.Size = new Size(291, 31);
            itemNameText.TabIndex = 1;
            // 
            // itemBrandText
            // 
            itemBrandText.Location = new Point(162, 82);
            itemBrandText.Name = "itemBrandText";
            itemBrandText.Size = new Size(291, 31);
            itemBrandText.TabIndex = 2;
            // 
            // itemBrandLabel
            // 
            itemBrandLabel.AutoSize = true;
            itemBrandLabel.Location = new Point(26, 82);
            itemBrandLabel.Name = "itemBrandLabel";
            itemBrandLabel.Size = new Size(64, 25);
            itemBrandLabel.TabIndex = 2;
            itemBrandLabel.Text = "Marca:";
            // 
            // itemEmployeeText
            // 
            itemEmployeeText.Location = new Point(162, 40);
            itemEmployeeText.Name = "itemEmployeeText";
            itemEmployeeText.Size = new Size(291, 31);
            itemEmployeeText.TabIndex = 4;
            // 
            // itemEmployeeLabel
            // 
            itemEmployeeLabel.AutoSize = true;
            itemEmployeeLabel.Location = new Point(26, 43);
            itemEmployeeLabel.Name = "itemEmployeeLabel";
            itemEmployeeLabel.Size = new Size(108, 25);
            itemEmployeeLabel.TabIndex = 4;
            itemEmployeeLabel.Text = "Funcionário:";
            // 
            // itemCodeText
            // 
            itemCodeText.Location = new Point(162, 119);
            itemCodeText.Name = "itemCodeText";
            itemCodeText.Size = new Size(291, 31);
            itemCodeText.TabIndex = 3;
            itemCodeText.KeyPress += itemCodeText_KeyPress;
            // 
            // itemCodeLabel
            // 
            itemCodeLabel.AutoSize = true;
            itemCodeLabel.Location = new Point(25, 119);
            itemCodeLabel.Name = "itemCodeLabel";
            itemCodeLabel.Size = new Size(75, 25);
            itemCodeLabel.TabIndex = 6;
            itemCodeLabel.Text = "Código:";
            // 
            // itemDepartmentLabel
            // 
            itemDepartmentLabel.AutoSize = true;
            itemDepartmentLabel.Location = new Point(25, 80);
            itemDepartmentLabel.Name = "itemDepartmentLabel";
            itemDepartmentLabel.Size = new Size(131, 25);
            itemDepartmentLabel.TabIndex = 8;
            itemDepartmentLabel.Text = "Departamento:";
            // 
            // itemDepartmentBox
            // 
            itemDepartmentBox.FormattingEnabled = true;
            itemDepartmentBox.Location = new Point(162, 77);
            itemDepartmentBox.Name = "itemDepartmentBox";
            itemDepartmentBox.Size = new Size(291, 33);
            itemDepartmentBox.TabIndex = 5;
            itemDepartmentBox.Text = "-- Selecione --";
            // 
            // itemTypeBox
            // 
            itemTypeBox.FormattingEnabled = true;
            itemTypeBox.Location = new Point(162, 115);
            itemTypeBox.Name = "itemTypeBox";
            itemTypeBox.Size = new Size(291, 33);
            itemTypeBox.TabIndex = 6;
            itemTypeBox.Text = "-- Selecione --";
            // 
            // itemTypeLabel
            // 
            itemTypeLabel.AutoSize = true;
            itemTypeLabel.Location = new Point(26, 118);
            itemTypeLabel.Name = "itemTypeLabel";
            itemTypeLabel.Size = new Size(51, 25);
            itemTypeLabel.TabIndex = 10;
            itemTypeLabel.Text = "Tipo:";
            // 
            // itemStatusLabel
            // 
            itemStatusLabel.AutoSize = true;
            itemStatusLabel.Location = new Point(26, 157);
            itemStatusLabel.Name = "itemStatusLabel";
            itemStatusLabel.Size = new Size(64, 25);
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
            productGroupBox.Location = new Point(22, 36);
            productGroupBox.Name = "productGroupBox";
            productGroupBox.Size = new Size(506, 177);
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
            statusGroupBox.Location = new Point(22, 230);
            statusGroupBox.Name = "statusGroupBox";
            statusGroupBox.Size = new Size(506, 203);
            statusGroupBox.TabIndex = 15;
            statusGroupBox.TabStop = false;
            statusGroupBox.Text = "Classificação e Status";
            // 
            // defeitoRadioBtn
            // 
            defeitoRadioBtn.AutoSize = true;
            defeitoRadioBtn.Location = new Point(361, 157);
            defeitoRadioBtn.Name = "defeitoRadioBtn";
            defeitoRadioBtn.Size = new Size(91, 29);
            defeitoRadioBtn.TabIndex = 10;
            defeitoRadioBtn.Text = "Defeito";
            defeitoRadioBtn.UseVisualStyleBackColor = true;
            // 
            // emUsoRadioBtn
            // 
            emUsoRadioBtn.AutoSize = true;
            emUsoRadioBtn.Location = new Point(265, 157);
            emUsoRadioBtn.Name = "emUsoRadioBtn";
            emUsoRadioBtn.Size = new Size(92, 29);
            emUsoRadioBtn.TabIndex = 9;
            emUsoRadioBtn.Text = "Em uso";
            emUsoRadioBtn.UseVisualStyleBackColor = true;
            // 
            // estoqueRadioBtn
            // 
            estoqueRadioBtn.AutoSize = true;
            estoqueRadioBtn.Checked = true;
            estoqueRadioBtn.Location = new Point(162, 157);
            estoqueRadioBtn.Name = "estoqueRadioBtn";
            estoqueRadioBtn.Size = new Size(97, 29);
            estoqueRadioBtn.TabIndex = 8;
            estoqueRadioBtn.TabStop = true;
            estoqueRadioBtn.Text = "Estoque";
            estoqueRadioBtn.UseVisualStyleBackColor = true;
            // 
            // cleanBtn
            // 
            cleanBtn.Location = new Point(305, 457);
            cleanBtn.Name = "cleanBtn";
            cleanBtn.Size = new Size(103, 39);
            cleanBtn.TabIndex = 11;
            cleanBtn.Text = "Limpar";
            cleanBtn.UseVisualStyleBackColor = true;
            cleanBtn.Click += cleanBtn_Click;
            // 
            // registerBtn
            // 
            registerBtn.Location = new Point(425, 457);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(103, 39);
            registerBtn.TabIndex = 12;
            registerBtn.Text = "Salvar";
            registerBtn.UseVisualStyleBackColor = true;
            registerBtn.Click += registerBtn_Click;
            // 
            // ItemRegisterForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 508);
            Controls.Add(registerBtn);
            Controls.Add(cleanBtn);
            Controls.Add(statusGroupBox);
            Controls.Add(productGroupBox);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "ItemRegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Item";
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
        private Button registerBtn;
    }
}