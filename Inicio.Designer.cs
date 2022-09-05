namespace Joyeria_Molina
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.title_menu = new System.Windows.Forms.MenuStrip();
            this.pnl_principal = new System.Windows.Forms.Panel();
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            this.client_ico = new FontAwesome.Sharp.IconMenuItem();
            this.product_ico = new FontAwesome.Sharp.IconMenuItem();
            this.sell_ico = new FontAwesome.Sharp.IconMenuItem();
            this.reports_ico = new FontAwesome.Sharp.IconMenuItem();
            this.backup_ico = new FontAwesome.Sharp.IconMenuItem();
            this.ico_logout = new FontAwesome.Sharp.IconMenuItem();
            this.menuStrip1.SuspendLayout();
            this.title_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconMenuItem1,
            this.client_ico,
            this.product_ico,
            this.sell_ico,
            this.reports_ico,
            this.backup_ico});
            this.menuStrip1.Location = new System.Drawing.Point(0, 110);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(1300, 83);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menu";
            // 
            // title_menu
            // 
            this.title_menu.AutoSize = false;
            this.title_menu.BackColor = System.Drawing.Color.Red;
            this.title_menu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.title_menu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.title_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ico_logout});
            this.title_menu.Location = new System.Drawing.Point(0, 0);
            this.title_menu.Name = "title_menu";
            this.title_menu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.title_menu.Size = new System.Drawing.Size(1300, 110);
            this.title_menu.TabIndex = 1;
            this.title_menu.Text = "menuStrip2";
            // 
            // pnl_principal
            // 
            this.pnl_principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_principal.Location = new System.Drawing.Point(0, 193);
            this.pnl_principal.Name = "pnl_principal";
            this.pnl_principal.Size = new System.Drawing.Size(1300, 607);
            this.pnl_principal.TabIndex = 9;
            // 
            // btncerrar
            // 
            this.btncerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btncerrar.BackColor = System.Drawing.Color.Red;
            this.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerrar.Image = ((System.Drawing.Image)(resources.GetObject("btncerrar.Image")));
            this.btncerrar.Location = new System.Drawing.Point(1240, 14);
            this.btncerrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(60, 62);
            this.btncerrar.TabIndex = 8;
            this.btncerrar.TabStop = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // iconMenuItem1
            // 
            this.iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconMenuItem1.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem1.IconSize = 50;
            this.iconMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuItem1.Name = "iconMenuItem1";
            this.iconMenuItem1.Size = new System.Drawing.Size(96, 79);
            this.iconMenuItem1.Text = "Usuarios";
            this.iconMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconMenuItem1.Click += new System.EventHandler(this.iconMenuItem1_Click);
            // 
            // client_ico
            // 
            this.client_ico.IconChar = FontAwesome.Sharp.IconChar.UserTag;
            this.client_ico.IconColor = System.Drawing.Color.Black;
            this.client_ico.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.client_ico.IconSize = 50;
            this.client_ico.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.client_ico.Name = "client_ico";
            this.client_ico.Size = new System.Drawing.Size(89, 79);
            this.client_ico.Text = "Clientes";
            this.client_ico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.client_ico.Click += new System.EventHandler(this.user_ico_Click);
            // 
            // product_ico
            // 
            this.product_ico.IconChar = FontAwesome.Sharp.IconChar.ClockFour;
            this.product_ico.IconColor = System.Drawing.Color.Black;
            this.product_ico.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.product_ico.IconSize = 50;
            this.product_ico.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.product_ico.Name = "product_ico";
            this.product_ico.Size = new System.Drawing.Size(109, 79);
            this.product_ico.Text = "Productos";
            this.product_ico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.product_ico.Click += new System.EventHandler(this.product_ico_Click);
            // 
            // sell_ico
            // 
            this.sell_ico.IconChar = FontAwesome.Sharp.IconChar.SackDollar;
            this.sell_ico.IconColor = System.Drawing.Color.Black;
            this.sell_ico.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.sell_ico.IconSize = 50;
            this.sell_ico.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sell_ico.Name = "sell_ico";
            this.sell_ico.Size = new System.Drawing.Size(80, 79);
            this.sell_ico.Text = "Ventas";
            this.sell_ico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // reports_ico
            // 
            this.reports_ico.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            this.reports_ico.IconColor = System.Drawing.Color.Black;
            this.reports_ico.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.reports_ico.IconSize = 50;
            this.reports_ico.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.reports_ico.Name = "reports_ico";
            this.reports_ico.Size = new System.Drawing.Size(98, 79);
            this.reports_ico.Text = "Reportes";
            this.reports_ico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // backup_ico
            // 
            this.backup_ico.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.backup_ico.IconColor = System.Drawing.Color.Black;
            this.backup_ico.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.backup_ico.IconSize = 50;
            this.backup_ico.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.backup_ico.Name = "backup_ico";
            this.backup_ico.Size = new System.Drawing.Size(85, 79);
            this.backup_ico.Text = "Backup";
            this.backup_ico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // ico_logout
            // 
            this.ico_logout.ForeColor = System.Drawing.Color.White;
            this.ico_logout.IconChar = FontAwesome.Sharp.IconChar.ExternalLink;
            this.ico_logout.IconColor = System.Drawing.Color.White;
            this.ico_logout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ico_logout.IconSize = 50;
            this.ico_logout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ico_logout.Name = "ico_logout";
            this.ico_logout.Size = new System.Drawing.Size(85, 106);
            this.ico_logout.Text = "Logout";
            this.ico_logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // Inicio
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1300, 800);
            this.Controls.Add(this.pnl_principal);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.title_menu);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Inicio";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.inicio_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.title_menu.ResumeLayout(false);
            this.title_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip title_menu;
        private FontAwesome.Sharp.IconMenuItem client_ico;
        private FontAwesome.Sharp.IconMenuItem product_ico;
        private FontAwesome.Sharp.IconMenuItem sell_ico;
        private FontAwesome.Sharp.IconMenuItem reports_ico;
        private FontAwesome.Sharp.IconMenuItem backup_ico;
        private FontAwesome.Sharp.IconMenuItem ico_logout;
        private System.Windows.Forms.PictureBox btncerrar;
        private System.Windows.Forms.Panel pnl_principal;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
    }
}