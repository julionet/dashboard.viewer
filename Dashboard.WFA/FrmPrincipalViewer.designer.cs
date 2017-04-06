namespace Dashboard.WFA
{
    partial class FrmPrincipalViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipalViewer));
            this.tileNavPane = new DevExpress.XtraBars.Navigation.TileNavPane();
            this.navButtonTitulo = new DevExpress.XtraBars.Navigation.NavButton();
            this.navButtonTrocarUsuario = new DevExpress.XtraBars.Navigation.NavButton();
            this.navButtonAlterarSenha = new DevExpress.XtraBars.Navigation.NavButton();
            this.navButtonMinimizar = new DevExpress.XtraBars.Navigation.NavButton();
            this.navButtonFechar = new DevExpress.XtraBars.Navigation.NavButton();
            this.panelControlBackground = new DevExpress.XtraEditors.PanelControl();
            this.xtraTabControl = new DevExpress.XtraTab.XtraTabControl();
            this.navBarControl = new DevExpress.XtraNavBar.NavBarControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlBackground)).BeginInit();
            this.panelControlBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl)).BeginInit();
            this.SuspendLayout();
            // 
            // tileNavPane
            // 
            this.tileNavPane.ButtonPadding = new System.Windows.Forms.Padding(8);
            this.tileNavPane.Buttons.Add(this.navButtonTitulo);
            this.tileNavPane.Buttons.Add(this.navButtonTrocarUsuario);
            this.tileNavPane.Buttons.Add(this.navButtonAlterarSenha);
            this.tileNavPane.Buttons.Add(this.navButtonMinimizar);
            this.tileNavPane.Buttons.Add(this.navButtonFechar);
            // 
            // tileNavCategory1
            // 
            this.tileNavPane.DefaultCategory.Name = "tileNavCategory1";
            this.tileNavPane.DefaultCategory.OptionsDropDown.BackColor = System.Drawing.Color.Empty;
            this.tileNavPane.DefaultCategory.OwnerCollection = null;
            // 
            // 
            // 
            this.tileNavPane.DefaultCategory.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileNavPane.DefaultCategory.Tile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Default;
            this.tileNavPane.Dock = System.Windows.Forms.DockStyle.Top;
            this.tileNavPane.Location = new System.Drawing.Point(0, 0);
            this.tileNavPane.Name = "tileNavPane";
            this.tileNavPane.OptionsPrimaryDropDown.BackColor = System.Drawing.Color.Empty;
            this.tileNavPane.OptionsSecondaryDropDown.BackColor = System.Drawing.Color.Empty;
            this.tileNavPane.Size = new System.Drawing.Size(938, 40);
            this.tileNavPane.TabIndex = 0;
            this.tileNavPane.Text = "tileNavPane1";
            // 
            // navButtonTitulo
            // 
            this.navButtonTitulo.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Left;
            this.navButtonTitulo.Appearance.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navButtonTitulo.Appearance.Options.UseFont = true;
            this.navButtonTitulo.Caption = "Dashboard Viewer";
            this.navButtonTitulo.Enabled = false;
            this.navButtonTitulo.Glyph = global::Dashboard.WFA.Properties.Resources.dashboard_icon;
            this.navButtonTitulo.Name = "navButtonTitulo";
            // 
            // navButtonTrocarUsuario
            // 
            this.navButtonTrocarUsuario.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right;
            this.navButtonTrocarUsuario.Caption = "Trocar Usuário";
            this.navButtonTrocarUsuario.Glyph = global::Dashboard.WFA.Properties.Resources.TrocarUsuario_Metro_32;
            this.navButtonTrocarUsuario.Name = "navButtonTrocarUsuario";
            this.navButtonTrocarUsuario.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.navButtonTrocarUsuario_ElementClick);
            // 
            // navButtonAlterarSenha
            // 
            this.navButtonAlterarSenha.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right;
            this.navButtonAlterarSenha.Caption = "Alterar Senha";
            this.navButtonAlterarSenha.Glyph = global::Dashboard.WFA.Properties.Resources.TrocarSenha_Metro_32;
            this.navButtonAlterarSenha.Name = "navButtonAlterarSenha";
            this.navButtonAlterarSenha.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.navButtonAlterarSenha_ElementClick);
            // 
            // navButtonMinimizar
            // 
            this.navButtonMinimizar.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right;
            this.navButtonMinimizar.Caption = "";
            this.navButtonMinimizar.Glyph = global::Dashboard.WFA.Properties.Resources.minimizar_metro_32;
            this.navButtonMinimizar.Name = "navButtonMinimizar";
            this.navButtonMinimizar.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.navButtonMinimizar_ElementClick);
            // 
            // navButtonFechar
            // 
            this.navButtonFechar.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right;
            this.navButtonFechar.Caption = "";
            this.navButtonFechar.Glyph = global::Dashboard.WFA.Properties.Resources.Sair_Metro_32;
            this.navButtonFechar.Name = "navButtonFechar";
            this.navButtonFechar.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.navButtonFechar_ElementClick);
            // 
            // panelControlBackground
            // 
            this.panelControlBackground.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControlBackground.Controls.Add(this.xtraTabControl);
            this.panelControlBackground.Controls.Add(this.navBarControl);
            this.panelControlBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControlBackground.Location = new System.Drawing.Point(0, 40);
            this.panelControlBackground.Name = "panelControlBackground";
            this.panelControlBackground.Size = new System.Drawing.Size(938, 512);
            this.panelControlBackground.TabIndex = 1;
            // 
            // xtraTabControl
            // 
            this.xtraTabControl.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageHeaderAndOnMouseHover;
            this.xtraTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl.HeaderButtons = ((DevExpress.XtraTab.TabButtons)((((DevExpress.XtraTab.TabButtons.Prev | DevExpress.XtraTab.TabButtons.Next) 
            | DevExpress.XtraTab.TabButtons.Close) 
            | DevExpress.XtraTab.TabButtons.Default)));
            this.xtraTabControl.HeaderButtonsShowMode = DevExpress.XtraTab.TabButtonShowMode.WhenNeeded;
            this.xtraTabControl.Location = new System.Drawing.Point(204, 0);
            this.xtraTabControl.Name = "xtraTabControl";
            this.xtraTabControl.Size = new System.Drawing.Size(734, 512);
            this.xtraTabControl.TabIndex = 2;
            this.xtraTabControl.CloseButtonClick += new System.EventHandler(this.xtraTabControl_CloseButtonClick);
            // 
            // navBarControl
            // 
            this.navBarControl.ActiveGroup = null;
            this.navBarControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControl.DragDropFlags = DevExpress.XtraNavBar.NavBarDragDrop.None;
            this.navBarControl.Location = new System.Drawing.Point(0, 0);
            this.navBarControl.Name = "navBarControl";
            this.navBarControl.NavigationPaneOverflowPanelUseSmallImages = false;
            this.navBarControl.OptionsNavPane.ExpandedWidth = 204;
            this.navBarControl.OptionsNavPane.ShowOverflowButton = false;
            this.navBarControl.OptionsNavPane.ShowOverflowPanel = false;
            this.navBarControl.OptionsNavPane.ShowSplitter = false;
            this.navBarControl.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.navBarControl.Size = new System.Drawing.Size(204, 512);
            this.navBarControl.TabIndex = 1;
            // 
            // FrmPrincipalViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 552);
            this.Controls.Add(this.panelControlBackground);
            this.Controls.Add(this.tileNavPane);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipalViewer";
            this.Text = "Dashboard Viewer";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlBackground)).EndInit();
            this.panelControlBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TileNavPane tileNavPane;
        private DevExpress.XtraBars.Navigation.NavButton navButtonTitulo;
        private DevExpress.XtraBars.Navigation.NavButton navButtonTrocarUsuario;
        private DevExpress.XtraBars.Navigation.NavButton navButtonMinimizar;
        private DevExpress.XtraBars.Navigation.NavButton navButtonFechar;
        private DevExpress.XtraBars.Navigation.NavButton navButtonAlterarSenha;
        private DevExpress.XtraEditors.PanelControl panelControlBackground;
        private DevExpress.XtraNavBar.NavBarControl navBarControl;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl;
    }
}