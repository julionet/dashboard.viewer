using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTreeList;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Dashboard.WFA
{
    public partial class FrmManutencao : DevExpress.XtraEditors.XtraForm
    {
        protected int iKey = 0;
        protected bool bInsertOrEdit = false;
        protected bool bInsert = false;
        protected bool bEdit = false;
        protected string sCondicao = "";
        protected string sCondicaoPersonalizada = "";
        public DevExpress.XtraTab.XtraTabPage ParentPage;
        public DevExpress.XtraTab.XtraTabControl ParentControl;
        public bool PermiteIncluir = true;
        public bool PermiteAlterar = true;
        public bool PermiteExcluir = true;
        public string Mensagem = "";

        private SplashScreen splash;

        public bool ExibirTodosRegistros
        {
            get { return Properties.Settings.Default.ExibirTodosRegistros; }
        }

        private Control _firstcontrol = null;
        public Control FirstControl
        {
            get { return _firstcontrol; }
            set { _firstcontrol = value; }
        }

        private int _funcao;
        public int FuncaoId
        {
            get { return _funcao; }
            set { _funcao = value; }
        }

        private string _entidade;
        public string Entidade
        {
            get { return _entidade; }
            set { _entidade = value; }
        }

        private bool _administrador;
        public bool Administrador
        {
            get { return _administrador; }
            set { _administrador = value; }
        }

        public bool InsertOrEdit
        {
            get { return bInsertOrEdit; }
        }

        public FrmManutencao()
        {
            InitializeComponent();
        }

        protected virtual void IncluirRegistro()
        {
        }

        protected virtual void AlterarRegistro()
        {
        }

        protected virtual bool BloquearRegistro()
        {
            return true;
        }

        protected virtual bool ExisteRegistro()
        {
            return true;
        }

        protected virtual void AtualizarDados()
        {
            PreencherCheckListBox();
        }

        protected virtual void ObterDetalhes()
        {
        }

        protected virtual void ObterDadosPrincipal()
        {
        }

        protected virtual void PreencherCheckListBox()
        {
        }

        protected virtual void AtualizarCheckListBox()
        {
        }
        
        protected virtual void GravarCheckListBox()
        {
        }

        protected virtual bool ValidarRegistro()
        {
            foreach (Control control in xscManutencao.Controls)
                if (control is DevExpress.XtraTab.XtraTabControl)
                {
                    int posicao = (control as DevExpress.XtraTab.XtraTabControl).SelectedTabPageIndex;
                    foreach (DevExpress.XtraTab.XtraTabPage page in (control as DevExpress.XtraTab.XtraTabControl).TabPages)
                        (control as DevExpress.XtraTab.XtraTabControl).SelectedTabPage = page;
                    (control as DevExpress.XtraTab.XtraTabControl).SelectedTabPageIndex = posicao;
                }
            return true;
        }

        protected virtual bool ExecutarAntesGravar()
        {
            return true;
        }

        protected virtual bool GravarRegistro()
        {
            return true;
        }

        protected virtual bool CancelarRegistro()
        {
            bInsert = bEdit = bInsertOrEdit = false;
            splash = new SplashScreen("Buscando informações...");
            ObterDadosPrincipal();
            splash.FinalizarSplashScreen();

            xtcPaginas.SelectedTabPageIndex = 0;
            txtPesquisa.Focus();
            txtPesquisa.Text = "";

            return true;
        }

        protected virtual bool ExcluirRegistro()
        {
            return true;
        }

        protected virtual void CreateGridButtons(GridViewWithButtons gridView)
        {
            if (gridView.ButtonsPanel.Buttons.Count != 0)
            {
                GridColumn gridColumnButtons2 = new GridColumn();
                gridColumnButtons2.Visible = true;
                gridColumnButtons2.VisibleIndex = gridView.Columns.Count - 1;
                gridColumnButtons2.MaxWidth = 120;
                gridColumnButtons2.MinWidth = 120;
                gridColumnButtons2.Width = 120;
                gridView.Columns.Add(gridColumnButtons2);

                gridView.ButtonsColumn = gridColumnButtons2;
                gridView.ShowButtons = true;
            }
        }

        private string GerarCondicaoFiltro()
        {
            string condicao = "";
            foreach (GridColumn coluna in ((GridView)((GridControl)this.Controls.Find("gclPrincipal", true)[0]).Views[0]).Columns)
            {
                if (coluna.Visible && (coluna.ColumnType != typeof(bool)))
                {
                    if (coluna.ColumnType == typeof(string))
                    {
                        if (string.IsNullOrWhiteSpace(condicao))
                            condicao += Funcoes.ConfigureStringCondition(txtPesquisa.Text, coluna.FieldName);
                        else
                            condicao += " or " + Funcoes.ConfigureStringCondition(txtPesquisa.Text, coluna.FieldName);
                    }
                    else if ((coluna.ColumnType == typeof(double)) || (coluna.ColumnType == typeof(double?)))
                    {
                        if (Funcoes.IsDouble(txtPesquisa.Text))
                        {
                            if (string.IsNullOrWhiteSpace(condicao))
                                condicao += string.Format("({0} == {1})", coluna.FieldName, Funcoes.ComaToPoint(txtPesquisa.Text));
                            else
                                condicao += " or " + string.Format("({0} == {1})", coluna.FieldName, Funcoes.ComaToPoint(txtPesquisa.Text));
                        }
                    }
                    else if (coluna.ColumnType == typeof(DateTime))
                    {
                        if (Funcoes.IsDateTime(txtPesquisa.Text))
                        {
                            if (string.IsNullOrWhiteSpace(condicao))
                                condicao += Funcoes.ConfigureDateCondition(txtPesquisa.Text, coluna.FieldName);
                            else
                                condicao += " or " + Funcoes.ConfigureDateCondition(txtPesquisa.Text, coluna.FieldName);
                        }
                    }
                    else if (coluna.ColumnType == typeof(DateTime?))
                    {
                        if (Funcoes.IsDateTime(txtPesquisa.Text))
                        {
                            if (string.IsNullOrWhiteSpace(condicao))
                                condicao += Funcoes.ConfigureDateCondition(txtPesquisa.Text, coluna.FieldName + ".Value");
                            else
                                condicao += " or " + Funcoes.ConfigureDateCondition(txtPesquisa.Text, coluna.FieldName + ".Value");
                        }
                    }
                    else if (coluna.ColumnType == typeof(TimeSpan))
                    {
                        if (Funcoes.IsTimeSpan(txtPesquisa.Text))
                        {
                            if (string.IsNullOrWhiteSpace(condicao))
                                condicao += Funcoes.ConfigureTimeCondition(txtPesquisa.Text, coluna.FieldName);
                            else
                                condicao += " or " + Funcoes.ConfigureDateCondition(txtPesquisa.Text, coluna.FieldName);
                        }
                    }
                    else if (coluna.ColumnType == typeof(TimeSpan?))
                    {
                        if (Funcoes.IsTimeSpan(txtPesquisa.Text))
                        {
                            if (string.IsNullOrWhiteSpace(condicao))
                                condicao += Funcoes.ConfigureTimeCondition(txtPesquisa.Text, coluna.FieldName + ".Value");
                            else
                                condicao += " or " + Funcoes.ConfigureDateCondition(txtPesquisa.Text, coluna.FieldName + ".Value");
                        }
                    }
                    else if ((coluna.ColumnType == typeof(int)) || (coluna.ColumnType == typeof(int?)))
                    {
                        if (Funcoes.IsNumberInt32(txtPesquisa.Text))
                        {
                            if (string.IsNullOrWhiteSpace(condicao))
                                condicao += string.Format("({0} == {1})", coluna.FieldName, Funcoes.ComaToPoint(txtPesquisa.Text));
                            else
                                condicao += " or " + string.Format("({0} == {1})", coluna.FieldName, Funcoes.ComaToPoint(txtPesquisa.Text));
                        }
                    }
                }
            }
            
            if (condicao != "")
                condicao = "(" + condicao + ")";

            return condicao;
        }

        private void FrmManutencao_Load(object sender, EventArgs e)
        {
            xtcPaginas.SelectedTabPageIndex = 0;

            pclSeparadorAcesso.Appearance.BackColor = pclBotoesAcesso.BackColor;
            pclSeparadorManutencao.Appearance.BackColor = pclBotoesAcesso.BackColor;
            pclAcesso.Appearance.BackColor = pclBotoesAcesso.BackColor;

            btnIncluir.Enabled = PermiteIncluir;
            btnEditar.Enabled = PermiteAlterar;

            Interface.SetPropertyDefault(pclManutencao);
            Interface.SetPropertyDefault(xtpAcesso);

            if (Properties.Settings.Default.EnterMudaCampo) 
                Interface.EnterMoveNextControl(xscManutencao);

            if (this.Controls.Find("gclPrincipal", true).Count() != 0)
            {
                ((GridView)((GridControl)this.Controls.Find("gclPrincipal", true)[0]).Views[0]).StartSorting += new System.EventHandler(this.gvwAcesso_StartSorting);
                gvwAcesso_StartSorting(null, null);
            }

            if (Properties.Settings.Default.ExibirTodosRegistros)
            {
                splash = new SplashScreen("Buscando informações...");
                ObterDadosPrincipal();
                splash.FinalizarSplashScreen();
            }

            txtPesquisa.Focus();
            txtPesquisa.Select();
        }

        private void FrmManutencao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if ((ActiveControl is GridControl) && ((ActiveControl as GridControl).Name == "gclPrincipal"))
                    btnEditar_Click(btnEditar, null);
                else if ((ActiveControl is TreeList) && ((ActiveControl as TreeList).Name == "xtlAcesso"))
                    btnEditar_Click(btnEditar, null);
            }
            else if (e.KeyCode == Keys.Delete)
            {
                if (sender is Form)
                {
                    if ((sender as Form).ActiveControl is LookUpEdit)
                        ((LookUpEdit)(sender as Form).ActiveControl).EditValue = null;
                    else if ((sender as Form).ActiveControl is ImageComboBoxEdit)
                        ((ImageComboBoxEdit)(sender as Form).ActiveControl).EditValue = null;
                    else if ((sender as Form).ActiveControl is ComboBoxEdit)
                        ((ComboBoxEdit)(sender as Form).ActiveControl).EditValue = null;
                }
            }
        }
        
        public virtual void btnFiltrar_Click(object sender, EventArgs e)
        {
            GridView _grade = ((GridView)((GridControl)this.Controls.Find("gclPrincipal", true)[0]).Views[0]);
            if (!string.IsNullOrWhiteSpace(txtPesquisa.Text))
                sCondicao = GerarCondicaoFiltro();
            else
                sCondicao = "";

            if (sCondicao.Equals("#ERRO#"))
                XtraMessageBox.Show("Infomação inválida para filtro!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (!string.IsNullOrWhiteSpace(sCondicaoPersonalizada))
                    sCondicao = sCondicao.Insert(0, sCondicaoPersonalizada + (string.IsNullOrWhiteSpace(sCondicao) ? "" : " and "));

                if (sCondicao == "")
                {
                    XtraMessageBox.Show("Para realizar a busca é necessário informar algum filtro!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPesquisa.Focus();
                    txtPesquisa.Select();
                }
                else
                {
                    splash = new SplashScreen("Buscando informações...");
                    ObterDadosPrincipal();
                    splash.FinalizarSplashScreen();

                    if (principalBindingSource.Count != 0)
                    {
                        _grade.Focus();
                        txtPesquisa.Text = "";
                    }
                    else
                    {
                        if (string.IsNullOrWhiteSpace(Mensagem))
                            Mensagem = "Nenhum registro encontrado com o critério de busca!";
                        XtraMessageBox.Show(Mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtPesquisa.Focus();
                        txtPesquisa.Select();
                    }
                }
            }
        }

        public virtual void btnIncluir_Click(object sender, EventArgs e)
        {
            btnExcluir.Enabled = false;
            btnGravar.Enabled = true;
            
            bInsert = bInsertOrEdit = true;
            bEdit = false;
            
            Interface.ChangeEnableControl(PermiteIncluir, pclManutencao);

            principalBindingSource.AddNew();
            IncluirRegistro();

            PreencherCheckListBox();

            xtcPaginas.SelectedTabPageIndex = 1;
            if (_firstcontrol != null) _firstcontrol.Focus();
        }

        public virtual void btnEditar_Click(object sender, EventArgs e)
        {
            if (principalBindingSource.Count == 0)
            {
                XtraMessageBox.Show("Nenhum registro selecionado para ser alterado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ExisteRegistro())
            {
                XtraMessageBox.Show("Registro excluído por outro usuário!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (BloquearRegistro())
            {
                btnExcluir.Enabled = PermiteExcluir;
                btnGravar.Enabled = PermiteAlterar;

                Interface.ChangeEnableControl(PermiteAlterar, pclManutencao);

                AlterarRegistro();

                bEdit = bInsertOrEdit = true;
                bInsert = false;

                PreencherCheckListBox();
                AtualizarCheckListBox();

                xtcPaginas.SelectedTabPageIndex = 1;
                if (_firstcontrol != null) _firstcontrol.Focus();
            }
        }

        public void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (xtcPaginas.SelectedTabPage == xtpAcesso)
            {
                splash = new SplashScreen("Buscando informações...");
                ObterDadosPrincipal();
                splash.FinalizarSplashScreen();
            }
            AtualizarDados();
        }

        public void btnGravar_Click(object sender, EventArgs e)
        {
            if (ValidarRegistro())
            {
                ExecutarAntesGravar();
                GravarCheckListBox();
                if (GravarRegistro())
                {
                    bInsert = bEdit = bInsertOrEdit = false;
                    splash = new SplashScreen("Buscando informações...");
                    ObterDadosPrincipal();
                    splash.FinalizarSplashScreen();

                    xtcPaginas.SelectedTabPageIndex = 0;
                    txtPesquisa.Focus();
                    txtPesquisa.Text = "";
                }
            }
        }

        public void btnCancelar_Click(object sender, EventArgs e)
        {
            //if (XtraMessageBox.Show("Esta operação irá cancelar todas as alterações feitas no registro.\r\nConfirma essa operação?",
            //    "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                CancelarRegistro();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (DevExpress.XtraEditors.XtraMessageBox.Show("Deseja realmente excluir o registro selecionado?", "Confirmação", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (ExcluirRegistro())
                {
                    bInsert = bEdit = bInsertOrEdit = false;
                    splash = new SplashScreen("Buscando informações...");
                    ObterDadosPrincipal();
                    splash.FinalizarSplashScreen();

                    xtcPaginas.SelectedTabPageIndex = 0;
                    txtPesquisa.Focus();
                    txtPesquisa.Text = "";
                }
            }
        }

        private void gvwAcesso_StartSorting(object sender, EventArgs e)
        {
            txtPesquisa.Focus();
            txtPesquisa.Select();

            ((GridView)((GridControl)this.Controls.Find("gclPrincipal", true)[0]).Views[0]).FocusedColumn =
                ((GridView)((GridControl)this.Controls.Find("gclPrincipal", true)[0]).Views[0]).SortedColumns[0];
        }

        private void txtPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) 
                btnFiltrar_Click(btnFiltrar, null);
        }

        private void tabPaginas_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            bInsertOrEdit = xtcPaginas.SelectedTabPageIndex == 1;
        }
    }
}