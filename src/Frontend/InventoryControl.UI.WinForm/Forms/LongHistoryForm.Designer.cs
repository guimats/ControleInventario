namespace InventoryControl.UI.WinForms.Forms
{
    partial class LongHistoryForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            longHistoryDataGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)longHistoryDataGrid).BeginInit();
            SuspendLayout();
            // 
            // longHistoryDataGrid
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            longHistoryDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            longHistoryDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            longHistoryDataGrid.Location = new Point(8, 6);
            longHistoryDataGrid.Name = "longHistoryDataGrid";
            longHistoryDataGrid.Size = new Size(789, 442);
            longHistoryDataGrid.TabIndex = 0;
            longHistoryDataGrid.CellFormatting += longHistoryDataGrid_CellFormatting;
            longHistoryDataGrid.DataBindingComplete += longHistoryDataGrid_DataBindingComplete;
            // 
            // LongHistoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(longHistoryDataGrid);
            Name = "LongHistoryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Histórico Completo";
            Load += LongHistoryForm_Load;
            ((System.ComponentModel.ISupportInitialize)longHistoryDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView longHistoryDataGrid;
    }
}