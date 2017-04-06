namespace Dashboard.Viewer.WFA
{
    partial class FrmUsuario
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
            this.gclPrincipal = new DevExpress.XtraGrid.GridControl();
            this.gvwPrincipal = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repSistema = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.repCategoria = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.checkEditMaster = new DevExpress.XtraEditors.CheckEdit();
            this.textEditLogin = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButtonGerarSenha = new DevExpress.XtraEditors.SimpleButton();
            this.checkEdit2 = new DevExpress.XtraEditors.CheckEdit();
            this.groupControlDashboard = new DevExpress.XtraEditors.GroupControl();
            this.checkedListBoxControlDashboard = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.labelControlSenha = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pclAcesso)).BeginInit();
            this.pclAcesso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pclAcessoBottom)).BeginInit();
            this.xtpManutencao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pclManutencao)).BeginInit();
            this.pclManutencao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPesquisa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.principalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtcPaginas)).BeginInit();
            this.xtcPaginas.SuspendLayout();
            this.xtpAcesso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pclBotoesManutencao)).BeginInit();
            this.pclBotoesManutencao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pclPesquisar)).BeginInit();
            this.pclPesquisar.SuspendLayout();
            this.xscManutencao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pclSeparadorAcesso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pclBotoesAcesso)).BeginInit();
            this.pclBotoesAcesso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gclPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSistema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditMaster.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditLogin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlDashboard)).BeginInit();
            this.groupControlDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkedListBoxControlDashboard)).BeginInit();
            this.SuspendLayout();
            // 
            // pclAcesso
            // 
            this.pclAcesso.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.pclAcesso.Appearance.Options.UseBackColor = true;
            this.pclAcesso.Controls.Add(this.gclPrincipal);
            // 
            // xtpManutencao
            // 
            this.xtpManutencao.Size = new System.Drawing.Size(547, 509);
            // 
            // pclManutencao
            // 
            this.pclManutencao.Size = new System.Drawing.Size(547, 473);
            // 
            // txtPesquisa
            // 
            // 
            // principalBindingSource
            // 
            this.principalBindingSource.DataSource = typeof(Dashboard.Viewer.Entity.Usuario);
            // 
            // xtcPaginas
            // 
            this.xtcPaginas.SelectedTabPage = this.xtpManutencao;
            this.xtcPaginas.Size = new System.Drawing.Size(547, 509);
            // 
            // pclBotoesManutencao
            // 
            this.pclBotoesManutencao.Location = new System.Drawing.Point(0, 477);
            // 
            // xscManutencao
            // 
            this.xscManutencao.Controls.Add(this.labelControlSenha);
            this.xscManutencao.Controls.Add(this.groupControlDashboard);
            this.xscManutencao.Controls.Add(this.checkEdit2);
            this.xscManutencao.Controls.Add(this.simpleButtonGerarSenha);
            this.xscManutencao.Controls.Add(this.checkEditMaster);
            this.xscManutencao.Controls.Add(this.textEditLogin);
            this.xscManutencao.Controls.Add(this.labelControl1);
            this.xscManutencao.Size = new System.Drawing.Size(543, 469);
            // 
            // pclSeparadorAcesso
            // 
            this.pclSeparadorAcesso.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.pclSeparadorAcesso.Appearance.Options.UseBackColor = true;
            // 
            // gclPrincipal
            // 
            this.gclPrincipal.Cursor = System.Windows.Forms.Cursors.Default;
            this.gclPrincipal.DataSource = this.principalBindingSource;
            this.gclPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gclPrincipal.Location = new System.Drawing.Point(0, 3);
            this.gclPrincipal.MainView = this.gvwPrincipal;
            this.gclPrincipal.Name = "gclPrincipal";
            this.gclPrincipal.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repSistema,
            this.repCategoria});
            this.gclPrincipal.Size = new System.Drawing.Size(547, 208);
            this.gclPrincipal.TabIndex = 3;
            this.gclPrincipal.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvwPrincipal});
            // 
            // gvwPrincipal
            // 
            this.gvwPrincipal.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gvwPrincipal.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvwPrincipal.GridControl = this.gclPrincipal;
            this.gvwPrincipal.Name = "gvwPrincipal";
            this.gvwPrincipal.OptionsBehavior.AllowIncrementalSearch = true;
            this.gvwPrincipal.OptionsBehavior.Editable = false;
            this.gvwPrincipal.OptionsCustomization.AllowColumnMoving = false;
            this.gvwPrincipal.OptionsCustomization.AllowColumnResizing = false;
            this.gvwPrincipal.OptionsCustomization.AllowFilter = false;
            this.gvwPrincipal.OptionsCustomization.AllowGroup = false;
            this.gvwPrincipal.OptionsMenu.EnableColumnMenu = false;
            this.gvwPrincipal.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvwPrincipal.OptionsView.ColumnAutoWidth = false;
            this.gvwPrincipal.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gvwPrincipal.OptionsView.ShowGroupPanel = false;
            this.gvwPrincipal.OptionsView.ShowIndicator = false;
            this.gvwPrincipal.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn2, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvwPrincipal.DoubleClick += new System.EventHandler(this.gvwAcesso_DoubleClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Identificação";
            this.gridColumn1.FieldName = "Id";
            this.gridColumn1.MaxWidth = 100;
            this.gridColumn1.MinWidth = 100;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Width = 100;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Login";
            this.gridColumn2.FieldName = "Login";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 250;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.Caption = "Master?";
            this.gridColumn3.FieldName = "Master";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 70;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.Caption = "Bloqueado?";
            this.gridColumn4.FieldName = "Bloqueado";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            // 
            // repSistema
            // 
            this.repSistema.AutoHeight = false;
            this.repSistema.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repSistema.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Ambos", "A", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Financeiro", "F", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Imóveis", "I", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Notas", "N", -1)});
            this.repSistema.Name = "repSistema";
            // 
            // repCategoria
            // 
            this.repCategoria.AutoHeight = false;
            this.repCategoria.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repCategoria.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Urgente", "U", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Informativo", "I", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Dúvida", "D", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Outras", "O", -1)});
            this.repCategoria.Name = "repCategoria";
            // 
            // checkEditMaster
            // 
            this.checkEditMaster.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.principalBindingSource, "Master", true));
            this.checkEditMaster.Location = new System.Drawing.Point(84, 55);
            this.checkEditMaster.Name = "checkEditMaster";
            this.checkEditMaster.Properties.Caption = "Master?";
            this.checkEditMaster.Size = new System.Drawing.Size(75, 19);
            this.checkEditMaster.TabIndex = 1;
            this.checkEditMaster.CheckedChanged += new System.EventHandler(this.checkEditMaster_CheckedChanged);
            // 
            // textEditLogin
            // 
            this.textEditLogin.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.principalBindingSource, "Login", true));
            this.textEditLogin.Location = new System.Drawing.Point(84, 29);
            this.textEditLogin.Name = "textEditLogin";
            this.textEditLogin.Properties.MaxLength = 50;
            this.textEditLogin.Size = new System.Drawing.Size(253, 20);
            this.textEditLogin.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(53, 32);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(25, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Login";
            // 
            // simpleButtonGerarSenha
            // 
            this.simpleButtonGerarSenha.Location = new System.Drawing.Point(84, 105);
            this.simpleButtonGerarSenha.Name = "simpleButtonGerarSenha";
            this.simpleButtonGerarSenha.Size = new System.Drawing.Size(83, 23);
            this.simpleButtonGerarSenha.TabIndex = 3;
            this.simpleButtonGerarSenha.TabStop = false;
            this.simpleButtonGerarSenha.Text = "Gerar Senha";
            this.simpleButtonGerarSenha.Click += new System.EventHandler(this.simpleButtonGerarSenha_Click);
            // 
            // checkEdit2
            // 
            this.checkEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.principalBindingSource, "Bloqueado", true));
            this.checkEdit2.Location = new System.Drawing.Point(84, 80);
            this.checkEdit2.Name = "checkEdit2";
            this.checkEdit2.Properties.Caption = "Bloqueado?";
            this.checkEdit2.Size = new System.Drawing.Size(75, 19);
            this.checkEdit2.TabIndex = 2;
            // 
            // groupControlDashboard
            // 
            this.groupControlDashboard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControlDashboard.Controls.Add(this.checkedListBoxControlDashboard);
            this.groupControlDashboard.Location = new System.Drawing.Point(84, 134);
            this.groupControlDashboard.Name = "groupControlDashboard";
            this.groupControlDashboard.Size = new System.Drawing.Size(392, 290);
            this.groupControlDashboard.TabIndex = 4;
            this.groupControlDashboard.Text = "Selecione os dashboards liberados para o usuário";
            // 
            // checkedListBoxControlDashboard
            // 
            this.checkedListBoxControlDashboard.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.checkedListBoxControlDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBoxControlDashboard.Location = new System.Drawing.Point(2, 20);
            this.checkedListBoxControlDashboard.Name = "checkedListBoxControlDashboard";
            this.checkedListBoxControlDashboard.Size = new System.Drawing.Size(388, 268);
            this.checkedListBoxControlDashboard.TabIndex = 0;
            // 
            // labelControlSenha
            // 
            this.labelControlSenha.Location = new System.Drawing.Point(177, 110);
            this.labelControlSenha.Name = "labelControlSenha";
            this.labelControlSenha.Size = new System.Drawing.Size(0, 13);
            this.labelControlSenha.TabIndex = 5;
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 521);
            this.FirstControl = this.textEditLogin;
            this.Name = "FrmUsuario";
            this.Text = "Usuários";
            ((System.ComponentModel.ISupportInitialize)(this.pclAcesso)).EndInit();
            this.pclAcesso.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pclAcessoBottom)).EndInit();
            this.xtpManutencao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pclManutencao)).EndInit();
            this.pclManutencao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtPesquisa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.principalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtcPaginas)).EndInit();
            this.xtcPaginas.ResumeLayout(false);
            this.xtpAcesso.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pclBotoesManutencao)).EndInit();
            this.pclBotoesManutencao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pclPesquisar)).EndInit();
            this.pclPesquisar.ResumeLayout(false);
            this.pclPesquisar.PerformLayout();
            this.xscManutencao.ResumeLayout(false);
            this.xscManutencao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pclSeparadorAcesso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pclBotoesAcesso)).EndInit();
            this.pclBotoesAcesso.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gclPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSistema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditMaster.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditLogin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlDashboard)).EndInit();
            this.groupControlDashboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkedListBoxControlDashboard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gclPrincipal;
        private DevExpress.XtraGrid.Views.Grid.GridView gvwPrincipal;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repSistema;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repCategoria;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.CheckEdit checkEditMaster;
        private DevExpress.XtraEditors.TextEdit textEditLogin;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.CheckEdit checkEdit2;
        private DevExpress.XtraEditors.SimpleButton simpleButtonGerarSenha;
        private DevExpress.XtraEditors.GroupControl groupControlDashboard;
        private DevExpress.XtraEditors.CheckedListBoxControl checkedListBoxControlDashboard;
        private DevExpress.XtraEditors.LabelControl labelControlSenha;
    }
}