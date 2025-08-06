namespace InventoryControl.UI.WinForms.Forms
{
    partial class mainForm
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
            mainFormMenu = new MenuStrip();
            usuáriosMenuItem = new ToolStripMenuItem();
            itensToolStripMenuItem = new ToolStripMenuItem();
            solicitaçãoToolStripMenuItem = new ToolStripMenuItem();
            cadastrarUsuarioMenuItem = new ToolStripMenuItem();
            visualizarEditarMenuItem = new ToolStripMenuItem();
            cadastrarToolStripMenuItem = new ToolStripMenuItem();
            visualizarToolStripMenuItem = new ToolStripMenuItem();
            mainFormMenu.SuspendLayout();
            SuspendLayout();
            // 
            // mainFormMenu
            // 
            mainFormMenu.BackColor = SystemColors.MenuBar;
            mainFormMenu.Items.AddRange(new ToolStripItem[] { usuáriosMenuItem, itensToolStripMenuItem, solicitaçãoToolStripMenuItem });
            mainFormMenu.Location = new Point(0, 0);
            mainFormMenu.Name = "mainFormMenu";
            mainFormMenu.Size = new Size(750, 24);
            mainFormMenu.TabIndex = 0;
            mainFormMenu.Text = "menuStrip1";
            // 
            // usuáriosMenuItem
            // 
            usuáriosMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarUsuarioMenuItem, visualizarEditarMenuItem });
            usuáriosMenuItem.Margin = new Padding(10, 0, 5, 0);
            usuáriosMenuItem.Name = "usuáriosMenuItem";
            usuáriosMenuItem.Size = new Size(64, 20);
            usuáriosMenuItem.Text = "&Usuários";
            // 
            // itensToolStripMenuItem
            // 
            itensToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarToolStripMenuItem, visualizarToolStripMenuItem });
            itensToolStripMenuItem.Margin = new Padding(0, 0, 5, 0);
            itensToolStripMenuItem.Name = "itensToolStripMenuItem";
            itensToolStripMenuItem.Size = new Size(44, 20);
            itensToolStripMenuItem.Text = "&Itens";
            // 
            // solicitaçãoToolStripMenuItem
            // 
            solicitaçãoToolStripMenuItem.Name = "solicitaçãoToolStripMenuItem";
            solicitaçãoToolStripMenuItem.Size = new Size(76, 20);
            solicitaçãoToolStripMenuItem.Text = "&Solicitação";
            // 
            // cadastrarUsuarioMenuItem
            // 
            cadastrarUsuarioMenuItem.Name = "cadastrarUsuarioMenuItem";
            cadastrarUsuarioMenuItem.Size = new Size(180, 22);
            cadastrarUsuarioMenuItem.Text = "&Cadastrar";
            cadastrarUsuarioMenuItem.Click += cadastrarUsuarioMenuItem_Click;
            // 
            // visualizarEditarMenuItem
            // 
            visualizarEditarMenuItem.Name = "visualizarEditarMenuItem";
            visualizarEditarMenuItem.Size = new Size(158, 22);
            visualizarEditarMenuItem.Text = "&Visualizar/Editar";
            // 
            // cadastrarToolStripMenuItem
            // 
            cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            cadastrarToolStripMenuItem.Size = new Size(180, 22);
            cadastrarToolStripMenuItem.Text = "&Cadastrar";
            // 
            // visualizarToolStripMenuItem
            // 
            visualizarToolStripMenuItem.Name = "visualizarToolStripMenuItem";
            visualizarToolStripMenuItem.Size = new Size(180, 22);
            visualizarToolStripMenuItem.Text = "&Visualizar";
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 411);
            Controls.Add(mainFormMenu);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainMenuStrip = mainFormMenu;
            Margin = new Padding(5, 5, 5, 5);
            Name = "mainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Controle de inventário";
            mainFormMenu.ResumeLayout(false);
            mainFormMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mainFormMenu;
        private ToolStripMenuItem usuáriosMenuItem;
        private ToolStripMenuItem itensToolStripMenuItem;
        private ToolStripMenuItem solicitaçãoToolStripMenuItem;
        private ToolStripMenuItem cadastrarUsuarioMenuItem;
        private ToolStripMenuItem visualizarEditarMenuItem;
        private ToolStripMenuItem cadastrarToolStripMenuItem;
        private ToolStripMenuItem visualizarToolStripMenuItem;
    }
}