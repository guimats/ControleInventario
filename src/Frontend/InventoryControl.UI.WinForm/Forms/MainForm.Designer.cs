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
            welcomeMenuItem = new ToolStripMenuItem();
            userProfileMenuItem = new ToolStripMenuItem();
            changePasswordMenuItem = new ToolStripMenuItem();
            usuáriosMenuItem = new ToolStripMenuItem();
            cadastrarUsuarioMenuItem = new ToolStripMenuItem();
            visualizarEditarMenuItem = new ToolStripMenuItem();
            itensToolStripMenuItem = new ToolStripMenuItem();
            cadastrarItemMenuItem = new ToolStripMenuItem();
            visualizarItemMenuItem = new ToolStripMenuItem();
            solicitaçãoToolStripMenuItem = new ToolStripMenuItem();
            inventoryControlImage = new PictureBox();
            logoImage = new PictureBox();
            mainFormMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)inventoryControlImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logoImage).BeginInit();
            SuspendLayout();
            // 
            // mainFormMenu
            // 
            mainFormMenu.BackColor = SystemColors.MenuBar;
            mainFormMenu.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mainFormMenu.ImageScalingSize = new Size(20, 20);
            mainFormMenu.Items.AddRange(new ToolStripItem[] { welcomeMenuItem, usuáriosMenuItem, itensToolStripMenuItem, solicitaçãoToolStripMenuItem });
            mainFormMenu.Location = new Point(0, 0);
            mainFormMenu.Name = "mainFormMenu";
            mainFormMenu.Size = new Size(750, 25);
            mainFormMenu.TabIndex = 0;
            mainFormMenu.Text = "menuStrip1";
            // 
            // welcomeMenuItem
            // 
            welcomeMenuItem.DropDownItems.AddRange(new ToolStripItem[] { userProfileMenuItem, changePasswordMenuItem });
            welcomeMenuItem.Name = "welcomeMenuItem";
            welcomeMenuItem.Size = new Size(47, 21);
            welcomeMenuItem.Text = "&Olá, ";
            // 
            // userProfileMenuItem
            // 
            userProfileMenuItem.Name = "userProfileMenuItem";
            userProfileMenuItem.Size = new Size(180, 22);
            userProfileMenuItem.Text = "&Meu perfil";
            userProfileMenuItem.Click += userProfileMenuItem_Click;
            // 
            // changePasswordMenuItem
            // 
            changePasswordMenuItem.Name = "changePasswordMenuItem";
            changePasswordMenuItem.Size = new Size(180, 22);
            changePasswordMenuItem.Text = "&Alterar senha";
            // 
            // usuáriosMenuItem
            // 
            usuáriosMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarUsuarioMenuItem, visualizarEditarMenuItem });
            usuáriosMenuItem.Margin = new Padding(10, 0, 5, 0);
            usuáriosMenuItem.Name = "usuáriosMenuItem";
            usuáriosMenuItem.Size = new Size(71, 21);
            usuáriosMenuItem.Text = "&Usuários";
            // 
            // cadastrarUsuarioMenuItem
            // 
            cadastrarUsuarioMenuItem.Name = "cadastrarUsuarioMenuItem";
            cadastrarUsuarioMenuItem.Size = new Size(170, 22);
            cadastrarUsuarioMenuItem.Text = "&Cadastrar";
            cadastrarUsuarioMenuItem.Click += cadastrarUsuarioMenuItem_Click;
            // 
            // visualizarEditarMenuItem
            // 
            visualizarEditarMenuItem.Name = "visualizarEditarMenuItem";
            visualizarEditarMenuItem.Size = new Size(170, 22);
            visualizarEditarMenuItem.Text = "&Visualizar/Editar";
            // 
            // itensToolStripMenuItem
            // 
            itensToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarItemMenuItem, visualizarItemMenuItem });
            itensToolStripMenuItem.Margin = new Padding(0, 0, 5, 0);
            itensToolStripMenuItem.Name = "itensToolStripMenuItem";
            itensToolStripMenuItem.Size = new Size(47, 21);
            itensToolStripMenuItem.Text = "&Itens";
            // 
            // cadastrarItemMenuItem
            // 
            cadastrarItemMenuItem.Name = "cadastrarItemMenuItem";
            cadastrarItemMenuItem.Size = new Size(108, 22);
            cadastrarItemMenuItem.Text = "&Novo";
            cadastrarItemMenuItem.Click += cadastrarItemMenuItem_Click;
            // 
            // visualizarItemMenuItem
            // 
            visualizarItemMenuItem.Name = "visualizarItemMenuItem";
            visualizarItemMenuItem.Size = new Size(108, 22);
            visualizarItemMenuItem.Text = "&Listar";
            visualizarItemMenuItem.Click += visualizarItemMenuItem_Click;
            // 
            // solicitaçãoToolStripMenuItem
            // 
            solicitaçãoToolStripMenuItem.Name = "solicitaçãoToolStripMenuItem";
            solicitaçãoToolStripMenuItem.Size = new Size(82, 21);
            solicitaçãoToolStripMenuItem.Text = "&Solicitação";
            // 
            // inventoryControlImage
            // 
            inventoryControlImage.Image = Properties.Resources.nome_inventário_nobg_opacity;
            inventoryControlImage.Location = new Point(59, 221);
            inventoryControlImage.Name = "inventoryControlImage";
            inventoryControlImage.Size = new Size(616, 131);
            inventoryControlImage.SizeMode = PictureBoxSizeMode.StretchImage;
            inventoryControlImage.TabIndex = 1;
            inventoryControlImage.TabStop = false;
            // 
            // logoImage
            // 
            logoImage.Image = Properties.Resources.logo_inventario;
            logoImage.Location = new Point(294, 103);
            logoImage.Name = "logoImage";
            logoImage.Size = new Size(123, 112);
            logoImage.SizeMode = PictureBoxSizeMode.StretchImage;
            logoImage.TabIndex = 2;
            logoImage.TabStop = false;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 411);
            Controls.Add(logoImage);
            Controls.Add(inventoryControlImage);
            Controls.Add(mainFormMenu);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainMenuStrip = mainFormMenu;
            Margin = new Padding(5);
            Name = "mainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Controle de inventário";
            Load += mainForm_Load;
            mainFormMenu.ResumeLayout(false);
            mainFormMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)inventoryControlImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)logoImage).EndInit();
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
        private ToolStripMenuItem cadastrarItemMenuItem;
        private ToolStripMenuItem visualizarItemMenuItem;
        private PictureBox inventoryControlImage;
        private PictureBox logoImage;
        private ToolStripMenuItem welcomeMenuItem;
        private ToolStripMenuItem userProfileMenuItem;
        private ToolStripMenuItem changePasswordMenuItem;
    }
}