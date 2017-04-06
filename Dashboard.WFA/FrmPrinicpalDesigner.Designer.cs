namespace Dashboard.WFA
{
    partial class FrmPrinicpalDesigner
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
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            this.tileNavPane = new DevExpress.XtraBars.Navigation.TileNavPane();
            this.navButtonTitulo = new DevExpress.XtraBars.Navigation.NavButton();
            this.navButtonAlterarSenha = new DevExpress.XtraBars.Navigation.NavButton();
            this.navButtonMinimizar = new DevExpress.XtraBars.Navigation.NavButton();
            this.navButtonFechar = new DevExpress.XtraBars.Navigation.NavButton();
            this.tileBar1 = new DevExpress.XtraBars.Navigation.TileBar();
            this.tileBarGroup2 = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.tileBarItemUsuarios = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tileBarItemCategorias = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tileBarItemDesigner = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.xtraTabControl = new DevExpress.XtraTab.XtraTabControl();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).BeginInit();
            this.SuspendLayout();
            // 
            // tileNavPane
            // 
            this.tileNavPane.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileNavPane.Appearance.Options.UseFont = true;
            this.tileNavPane.AppearanceHovered.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileNavPane.AppearanceHovered.Options.UseFont = true;
            this.tileNavPane.AppearanceSelected.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileNavPane.AppearanceSelected.Options.UseFont = true;
            this.tileNavPane.ButtonPadding = new System.Windows.Forms.Padding(8);
            this.tileNavPane.Buttons.Add(this.navButtonTitulo);
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
            this.tileNavPane.Size = new System.Drawing.Size(815, 40);
            this.tileNavPane.TabIndex = 1;
            this.tileNavPane.Text = "tileNavPane1";
            // 
            // navButtonTitulo
            // 
            this.navButtonTitulo.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Left;
            this.navButtonTitulo.Appearance.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navButtonTitulo.Appearance.Options.UseFont = true;
            this.navButtonTitulo.Caption = "Dashboard Designer";
            this.navButtonTitulo.Enabled = false;
            this.navButtonTitulo.Glyph = global::Dashboard.WFA.Properties.Resources.dashboard_icon;
            this.navButtonTitulo.Name = "navButtonTitulo";
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
            // tileBar1
            // 
            this.tileBar1.AllowDrag = false;
            this.tileBar1.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileBar1.AppearanceItem.Normal.Options.UseFont = true;
            this.tileBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tileBar1.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileBar1.Groups.Add(this.tileBarGroup2);
            this.tileBar1.ItemSize = 56;
            this.tileBar1.Location = new System.Drawing.Point(0, 40);
            this.tileBar1.MaxId = 3;
            this.tileBar1.Name = "tileBar1";
            this.tileBar1.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons;
            this.tileBar1.Size = new System.Drawing.Size(815, 98);
            this.tileBar1.TabIndex = 2;
            this.tileBar1.Text = "tileBar1";
            this.tileBar1.WideTileWidth = 150;
            // 
            // tileBarGroup2
            // 
            this.tileBarGroup2.Items.Add(this.tileBarItemUsuarios);
            this.tileBarGroup2.Items.Add(this.tileBarItemCategorias);
            this.tileBarGroup2.Items.Add(this.tileBarItemDesigner);
            this.tileBarGroup2.Name = "tileBarGroup2";
            // 
            // tileBarItemUsuarios
            // 
            this.tileBarItemUsuarios.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement1.Text = "Usuários";
            this.tileBarItemUsuarios.Elements.Add(tileItemElement1);
            this.tileBarItemUsuarios.Id = 0;
            this.tileBarItemUsuarios.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tileBarItemUsuarios.Name = "tileBarItemUsuarios";
            this.tileBarItemUsuarios.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileBarItemUsuarios_ItemClick);
            // 
            // tileBarItemCategorias
            // 
            this.tileBarItemCategorias.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement2.Text = "Categorias";
            this.tileBarItemCategorias.Elements.Add(tileItemElement2);
            this.tileBarItemCategorias.Id = 1;
            this.tileBarItemCategorias.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tileBarItemCategorias.Name = "tileBarItemCategorias";
            this.tileBarItemCategorias.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileBarItemCategorias_ItemClick);
            // 
            // tileBarItemDesigner
            // 
            this.tileBarItemDesigner.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement3.Text = "Dashboards";
            this.tileBarItemDesigner.Elements.Add(tileItemElement3);
            this.tileBarItemDesigner.Id = 2;
            this.tileBarItemDesigner.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tileBarItemDesigner.Name = "tileBarItemDesigner";
            this.tileBarItemDesigner.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileBarItemDesigner_ItemClick);
            // 
            // xtraTabControl
            // 
            this.xtraTabControl.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageHeaderAndOnMouseHover;
            this.xtraTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl.HeaderButtons = ((DevExpress.XtraTab.TabButtons)((((DevExpress.XtraTab.TabButtons.Prev | DevExpress.XtraTab.TabButtons.Next) 
            | DevExpress.XtraTab.TabButtons.Close) 
            | DevExpress.XtraTab.TabButtons.Default)));
            this.xtraTabControl.HeaderButtonsShowMode = DevExpress.XtraTab.TabButtonShowMode.WhenNeeded;
            this.xtraTabControl.Location = new System.Drawing.Point(0, 138);
            this.xtraTabControl.Name = "xtraTabControl";
            this.xtraTabControl.Size = new System.Drawing.Size(815, 392);
            this.xtraTabControl.TabIndex = 4;
            // 
            // FrmPrinicpalDesigner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 530);
            this.Controls.Add(this.xtraTabControl);
            this.Controls.Add(this.tileBar1);
            this.Controls.Add(this.tileNavPane);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPrinicpalDesigner";
            this.Text = "Dashboard Designer";
            this.Load += new System.EventHandler(this.FrmPrinicpal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TileNavPane tileNavPane;
        private DevExpress.XtraBars.Navigation.NavButton navButtonTitulo;
        private DevExpress.XtraBars.Navigation.NavButton navButtonAlterarSenha;
        private DevExpress.XtraBars.Navigation.NavButton navButtonMinimizar;
        private DevExpress.XtraBars.Navigation.NavButton navButtonFechar;
        private DevExpress.XtraBars.Navigation.TileBar tileBar1;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroup2;
        private DevExpress.XtraBars.Navigation.TileBarItem tileBarItemUsuarios;
        private DevExpress.XtraBars.Navigation.TileBarItem tileBarItemCategorias;
        private DevExpress.XtraBars.Navigation.TileBarItem tileBarItemDesigner;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl;
    }
}