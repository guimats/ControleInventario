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
            cadastrarUsuarioMenuItem = new ToolStripMenuItem();
            visualizarEditarMenuItem = new ToolStripMenuItem();
            itensToolStripMenuItem = new ToolStripMenuItem();
            cadastrarToolStripMenuItem = new ToolStripMenuItem();
            visualizarToolStripMenuItem = new ToolStripMenuItem();
            solicitaçãoToolStripMenuItem = new ToolStripMenuItem();
            mainFormMenu.SuspendLayout();
            SuspendLayout();
            // 
            // mainFormMenu
            // 
            mainFormMenu.BackColor = SystemColors.MenuBar;
            mainFormMenu.ImageScalingSize = new Size(20, 20);
            mainFormMenu.Items.AddRange(new ToolStripItem[] { usuáriosMenuItem, itensToolStripMenuItem, solicitaçãoToolStripMenuItem });
            mainFormMenu.Location = new Point(0, 0);
            mainFormMenu.Name = "mainFormMenu";
            mainFormMenu.Size = new Size(750, 28);
            mainFormMenu.TabIndex = 0;
            mainFormMenu.Text = "menuStrip1";
            // 
            // usuáriosMenuItem
            // 
            usuáriosMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarUsuarioMenuItem, visualizarEditarMenuItem });
            usuáriosMenuItem.Margin = new Padding(10, 0, 5, 0);
            usuáriosMenuItem.Name = "usuáriosMenuItem";
            usuáriosMenuItem.Size = new Size(79, 24);
            usuáriosMenuItem.Text = "&Usuários";
            // 
            // cadastrarUsuarioMenuItem
            // 
            cadastrarUsuarioMenuItem.Name = "cadastrarUsuarioMenuItem";
            cadastrarUsuarioMenuItem.Size = new Size(200, 26);
            cadastrarUsuarioMenuItem.Text = "&Cadastrar";
            cadastrarUsuarioMenuItem.Click += cadastrarUsuarioMenuItem_Click;
            // 
            // visualizarEditarMenuItem
            // 
            visualizarEditarMenuItem.Name = "visualizarEditarMenuItem";
            visualizarEditarMenuItem.Size = new Size(200, 26);
            visualizarEditarMenuItem.Text = "&Visualizar/Editar";
            // 
            // itensToolStripMenuItem
            // 
            itensToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarToolStripMenuItem, visualizarToolStripMenuItem });
            itensToolStripMenuItem.Margin = new Padding(0, 0, 5, 0);
            itensToolStripMenuItem.Name = "itensToolStripMenuItem";
            itensToolStripMenuItem.Size = new Size(54, 24);
            itensToolStripMenuItem.Text = "&Itens";
            // 
            // cadastrarToolStripMenuItem
            // 
            cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            cadastrarToolStripMenuItem.Size = new Size(224, 26);
            cadastrarToolStripMenuItem.Text = "&Novo";
            cadastrarToolStripMenuItem.Click += cadastrarToolStripMenuItem_Click;
            // 
            // visualizarToolStripMenuItem
            // 
            visualizarToolStripMenuItem.Name = "visualizarToolStripMenuItem";
            visualizarToolStripMenuItem.Size = new Size(224, 26);
            visualizarToolStripMenuItem.Text = "&Listar";
            visualizarToolStripMenuItem.Click += visualizarToolStripMenuItem_Click;
            // 
            // solicitaçãoToolStripMenuItem
            // 
            solicitaçãoToolStripMenuItem.Name = "solicitaçãoToolStripMenuItem";
            solicitaçãoToolStripMenuItem.Size = new Size(96, 24);
            solicitaçãoToolStripMenuItem.Text = "&Solicitação";
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 411);
            Controls.Add(mainFormMenu);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainMenuStrip = mainFormMenu;
            Margin = new Padding(5);
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