namespace InventoryControl.UI.WinForms.Forms
{
    partial class ItemHistory
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
            historyDataGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)historyDataGrid).BeginInit();
            SuspendLayout();
            // 
            // historyDataGrid
            // 
            historyDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            historyDataGrid.Location = new Point(5, 12);
            historyDataGrid.Name = "historyDataGrid";
            historyDataGrid.Size = new Size(791, 426);
            historyDataGrid.TabIndex = 0;
            // 
            // ItemHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(historyDataGrid);
            Name = "ItemHistory";
            Text = "Histórico";
            Load += ItemHistory_Load;
            ((System.ComponentModel.ISupportInitialize)historyDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView historyDataGrid;
    }
}