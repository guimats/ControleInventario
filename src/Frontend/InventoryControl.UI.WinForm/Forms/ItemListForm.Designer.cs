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
            components = new System.ComponentModel.Container();
            filterGroupBox = new GroupBox();
            clenFilterBtn = new Button();
            statusGroupBox = new GroupBox();
            defeitoRadioBtn = new RadioButton();
            emUsoRadioBtn = new RadioButton();
            estoqueRadioBtn = new RadioButton();
            searchBtn = new Button();
            totalLabel = new Label();
            productTypeGroupBox = new GroupBox();
            departmentGroupBox = new GroupBox();
            filterCodeText = new TextBox();
            filterCodeLabel = new Label();
            filterNameText = new TextBox();
            filterNameLabel = new Label();
            itensGroupBox = new GroupBox();
            itensDataGrid = new DataGridView();
            itemMenuStrip = new ContextMenuStrip(components);
            editItem = new ToolStripMenuItem();
            deleteItem = new ToolStripMenuItem();
            filterGroupBox.SuspendLayout();
            statusGroupBox.SuspendLayout();
            itensGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)itensDataGrid).BeginInit();
            itemMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // filterGroupBox
            // 
            filterGroupBox.Controls.Add(clenFilterBtn);
            filterGroupBox.Controls.Add(statusGroupBox);
            filterGroupBox.Controls.Add(searchBtn);
            filterGroupBox.Controls.Add(totalLabel);
            filterGroupBox.Controls.Add(productTypeGroupBox);
            filterGroupBox.Controls.Add(departmentGroupBox);
            filterGroupBox.Controls.Add(filterCodeText);
            filterGroupBox.Controls.Add(filterCodeLabel);
            filterGroupBox.Controls.Add(filterNameText);
            filterGroupBox.Controls.Add(filterNameLabel);
            filterGroupBox.Location = new Point(14, 4);
            filterGroupBox.Name = "filterGroupBox";
            filterGroupBox.Size = new Size(1089, 228);
            filterGroupBox.TabIndex = 0;
            filterGroupBox.TabStop = false;
            filterGroupBox.Text = "Filtros";
            // 
            // clenFilterBtn
            // 
            clenFilterBtn.Location = new Point(796, 184);
            clenFilterBtn.Name = "clenFilterBtn";
            clenFilterBtn.Size = new Size(115, 36);
            clenFilterBtn.TabIndex = 9;
            clenFilterBtn.Text = "Limpar";
            clenFilterBtn.UseVisualStyleBackColor = true;
            clenFilterBtn.Click += clenFilterBtn_Click;
            // 
            // statusGroupBox
            // 
            statusGroupBox.Controls.Add(defeitoRadioBtn);
            statusGroupBox.Controls.Add(emUsoRadioBtn);
            statusGroupBox.Controls.Add(estoqueRadioBtn);
            statusGroupBox.Location = new Point(883, 29);
            statusGroupBox.Name = "statusGroupBox";
            statusGroupBox.Size = new Size(149, 137);
            statusGroupBox.TabIndex = 8;
            statusGroupBox.TabStop = false;
            statusGroupBox.Text = "Status";
            // 
            // defeitoRadioBtn
            // 
            defeitoRadioBtn.AutoSize = true;
            defeitoRadioBtn.Location = new Point(6, 95);
            defeitoRadioBtn.Name = "defeitoRadioBtn";
            defeitoRadioBtn.Size = new Size(71, 23);
            defeitoRadioBtn.TabIndex = 2;
            defeitoRadioBtn.TabStop = true;
            defeitoRadioBtn.Text = "Defeito";
            defeitoRadioBtn.UseVisualStyleBackColor = true;
            // 
            // emUsoRadioBtn
            // 
            emUsoRadioBtn.AutoSize = true;
            emUsoRadioBtn.Location = new Point(6, 62);
            emUsoRadioBtn.Name = "emUsoRadioBtn";
            emUsoRadioBtn.Size = new Size(74, 23);
            emUsoRadioBtn.TabIndex = 1;
            emUsoRadioBtn.TabStop = true;
            emUsoRadioBtn.Text = "Em Uso";
            emUsoRadioBtn.UseVisualStyleBackColor = true;
            // 
            // estoqueRadioBtn
            // 
            estoqueRadioBtn.AutoSize = true;
            estoqueRadioBtn.Location = new Point(6, 29);
            estoqueRadioBtn.Name = "estoqueRadioBtn";
            estoqueRadioBtn.Size = new Size(76, 23);
            estoqueRadioBtn.TabIndex = 0;
            estoqueRadioBtn.TabStop = true;
            estoqueRadioBtn.Text = "Estoque";
            estoqueRadioBtn.UseVisualStyleBackColor = true;
            // 
            // searchBtn
            // 
            searchBtn.Location = new Point(917, 184);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(115, 36);
            searchBtn.TabIndex = 7;
            searchBtn.Text = "Procurar";
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += searchBtn_Click;
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalLabel.Location = new Point(16, 184);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(114, 19);
            totalLabel.TabIndex = 6;
            totalLabel.Text = "Total de itens: 0";
            // 
            // productTypeGroupBox
            // 
            productTypeGroupBox.BackColor = SystemColors.ButtonFace;
            productTypeGroupBox.FlatStyle = FlatStyle.Flat;
            productTypeGroupBox.Location = new Point(604, 29);
            productTypeGroupBox.Name = "productTypeGroupBox";
            productTypeGroupBox.Size = new Size(259, 137);
            productTypeGroupBox.TabIndex = 4;
            productTypeGroupBox.TabStop = false;
            productTypeGroupBox.Text = "Produtos";
            // 
            // departmentGroupBox
            // 
            departmentGroupBox.BackColor = SystemColors.ButtonFace;
            departmentGroupBox.FlatStyle = FlatStyle.Popup;
            departmentGroupBox.Location = new Point(310, 29);
            departmentGroupBox.Name = "departmentGroupBox";
            departmentGroupBox.Size = new Size(259, 137);
            departmentGroupBox.TabIndex = 3;
            departmentGroupBox.TabStop = false;
            departmentGroupBox.Text = "Departamentos";
            // 
            // filterCodeText
            // 
            filterCodeText.Location = new Point(87, 107);
            filterCodeText.Name = "filterCodeText";
            filterCodeText.Size = new Size(151, 26);
            filterCodeText.TabIndex = 2;
            filterCodeText.KeyPress += filterCodeText_KeyPress;
            // 
            // filterCodeLabel
            // 
            filterCodeLabel.AutoSize = true;
            filterCodeLabel.Location = new Point(16, 110);
            filterCodeLabel.Name = "filterCodeLabel";
            filterCodeLabel.Size = new Size(53, 19);
            filterCodeLabel.TabIndex = 2;
            filterCodeLabel.Text = "Código";
            // 
            // filterNameText
            // 
            filterNameText.Location = new Point(87, 59);
            filterNameText.Name = "filterNameText";
            filterNameText.Size = new Size(151, 26);
            filterNameText.TabIndex = 1;
            // 
            // filterNameLabel
            // 
            filterNameLabel.AutoSize = true;
            filterNameLabel.Location = new Point(16, 62);
            filterNameLabel.Name = "filterNameLabel";
            filterNameLabel.Size = new Size(46, 19);
            filterNameLabel.TabIndex = 0;
            filterNameLabel.Text = "Nome";
            // 
            // itensGroupBox
            // 
            itensGroupBox.Controls.Add(itensDataGrid);
            itensGroupBox.Location = new Point(14, 238);
            itensGroupBox.Name = "itensGroupBox";
            itensGroupBox.Size = new Size(1089, 480);
            itensGroupBox.TabIndex = 1;
            itensGroupBox.TabStop = false;
            itensGroupBox.Text = "Itens";
            itensGroupBox.Visible = false;
            // 
            // itensDataGrid
            // 
            itensDataGrid.AllowUserToAddRows = false;
            itensDataGrid.AllowUserToDeleteRows = false;
            itensDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            itensDataGrid.Location = new Point(16, 29);
            itensDataGrid.Name = "itensDataGrid";
            itensDataGrid.ReadOnly = true;
            itensDataGrid.RowHeadersWidth = 51;
            itensDataGrid.Size = new Size(1067, 445);
            itensDataGrid.TabIndex = 0;
            itensDataGrid.CellMouseDown += itensDataGrid_CellMouseDown;
            // 
            // itemMenuStrip
            // 
            itemMenuStrip.ImageScalingSize = new Size(20, 20);
            itemMenuStrip.Items.AddRange(new ToolStripItem[] { editItem, deleteItem });
            itemMenuStrip.Name = "itemMenuStrip";
            itemMenuStrip.RenderMode = ToolStripRenderMode.Professional;
            itemMenuStrip.Size = new Size(185, 78);
            // 
            // editItem
            // 
            editItem.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editItem.Name = "editItem";
            editItem.Size = new Size(184, 26);
            editItem.Text = "Editar";
            editItem.Click += editItem_Click;
            // 
            // deleteItem
            // 
            deleteItem.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteItem.Image = Properties.Resources.lixo_icon;
            deleteItem.Name = "deleteItem";
            deleteItem.Size = new Size(184, 26);
            deleteItem.Text = "Deletar";
            deleteItem.Click += deleteItem_Click;
            // 
            // ItemListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1125, 730);
            Controls.Add(itensGroupBox);
            Controls.Add(filterGroupBox);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "ItemListForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Listar Itens";
            FormClosed += ItemListForm_FormClosed;
            filterGroupBox.ResumeLayout(false);
            filterGroupBox.PerformLayout();
            statusGroupBox.ResumeLayout(false);
            statusGroupBox.PerformLayout();
            itensGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)itensDataGrid).EndInit();
            itemMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox filterGroupBox;
        private TextBox filterCodeText;
        private Label filterCodeLabel;
        private TextBox filterNameText;
        private Label filterNameLabel;
        private GroupBox departmentGroupBox;
        private GroupBox productTypeGroupBox;
        private Label totalLabel;
        private Button searchBtn;
        private GroupBox itensGroupBox;
        private DataGridView itensDataGrid;
        private GroupBox statusGroupBox;
        private RadioButton estoqueRadioBtn;
        private RadioButton defeitoRadioBtn;
        private RadioButton emUsoRadioBtn;
        private Button clenFilterBtn;
        private ContextMenuStrip itemMenuStrip;
        private ToolStripMenuItem deleteItem;
        private ToolStripMenuItem editItem;
    }
}