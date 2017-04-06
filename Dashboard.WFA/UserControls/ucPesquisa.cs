using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;

namespace Dashboard.WFA
{
    public partial class ucPesquisa : UserControl
    {
        private List<RegistroPesquisa> _listaPesquisa;
        private dynamic _servico;
        private string _condicaoinicial = string.Empty;
        private string _campoordenacao = string.Empty;
        private PopupContainerEdit _popup;
        private string mensagem = null;
        private int _i;
        private bool _carregarnacarga = true;
        private bool _filtroespecial = false;

        public object oSelecao;
        public bool bConfirmado = false;

        public ucPesquisa()
        {
            InitializeComponent();

            txtPesquisa.Focus();
            txtPesquisa.Select();
        }

        public ucPesquisa(DevExpress.XtraEditors.PopupContainerEdit popup, List<RegistroPesquisa> lista, dynamic servico, bool filtroespecial = false, bool carregarnacarga = true) 
        {
            InitializeComponent();

            _popup = popup;
            _listaPesquisa = lista;
            _servico = servico;
            _carregarnacarga = carregarnacarga;
            _filtroespecial = filtroespecial;

            int i = 0;
            gvwPrincipal.Columns.Clear();
            foreach (RegistroPesquisa modelo in _listaPesquisa)
            {
                gvwPrincipal.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn()
                { 
                    Visible = true, 
                    VisibleIndex = modelo.Id, 
                    Caption = modelo.Descricao, 
                    FieldName = modelo.Campo,
                    UnboundType = ConversionDX.TypeToColumnType(modelo.Tipo),
                    Width = modelo.Tamanho,
                    SortOrder = modelo.Padrao ? DevExpress.Data.ColumnSortOrder.Ascending : DevExpress.Data.ColumnSortOrder.None
                });

                if (modelo.Tipo == typeof(double))
                {
                    gvwPrincipal.Columns[i].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
                    gvwPrincipal.Columns[i].DisplayFormat.FormatString = "n2";
                }

                if (modelo.Padrao) _campoordenacao = modelo.Campo;
                i++;
            }
            txtPesquisa.Text = "";
        }

        public ucPesquisa(DevExpress.XtraEditors.PopupContainerEdit popup, List<RegistroPesquisa> lista, dynamic servico, string condicaoinicial, bool filtroespecial = false, bool carregarnacarga = true)
            :this(popup, lista, (object) servico, filtroespecial, carregarnacarga)
        {
            _condicaoinicial = condicaoinicial;
        }

        public ucPesquisa(DevExpress.XtraEditors.PopupContainerEdit popup, List<RegistroPesquisa> lista, dynamic servico, bool filtroespecial, bool carregarnacarga, string condicaoinicial, int i)
            : this(popup, lista, (object)servico, condicaoinicial, filtroespecial, carregarnacarga)
        {
            _i = i;
        }

        private void txtPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                mensagem = null;
                string condicao = null;

                if (!txtPesquisa.Text.Equals(""))
                    condicao = Funcoes.ParseObject(_condicaoinicial, _campoordenacao, txtPesquisa.Text,
                        _listaPesquisa.Where(p => p.Campo == _campoordenacao).FirstOrDefault().Tipo);

                if (!string.IsNullOrEmpty(condicao))
                {
                    if (_i != 0)
                        principalBindingSource.DataSource = _servico.FiltrarInt(_i, condicao);
                    else
                    {
                        if (_filtroespecial)
                            principalBindingSource.DataSource = _servico.Filtrar(condicao).Dados;
                        else
                            principalBindingSource.DataSource = _servico.Filtrar(condicao);
                    }
                }
                else
                    principalBindingSource.DataSource = null;

                if (principalBindingSource.Count != 0)
                    gclPrincipal.Focus();
                else
                {
                    if (string.IsNullOrWhiteSpace(mensagem))
                        mensagem = "Nenhum registro foi encontrado com o critério informado!";
                    DevExpress.XtraEditors.XtraMessageBox.Show(mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPesquisa.Focus();
                }
            }
        }

        private void gvwPrincipal_StartSorting(object sender, EventArgs e)
        {
            _campoordenacao = gvwPrincipal.SortedColumns[0].FieldName;
            txtPesquisa.Focus();
        }

        private void gvwPrincipal_DoubleClick(object sender, EventArgs e)
        {
            if (pnlInferior.Visible) SelectRow();
        }

        private void gvwPrincipal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) SelectRow();
        }

        private void gvwPrincipal_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (!pnlInferior.Visible) SelectRow();
        }

        private void SelectRow()
        {
            if (principalBindingSource.Count == 0)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Nenhum registro selecionado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                oSelecao = principalBindingSource.Current;
                bConfirmado = true;
                this._popup.ClosePopup();
            }
        }

        private void ucPesquisa_Load(object sender, EventArgs e)
        {
            if (_carregarnacarga)
            {
                if (_i != 0)
                    principalBindingSource.DataSource = _servico.FiltrarInt(_i, _condicaoinicial);
                else
                {
                    if (_filtroespecial)
                        principalBindingSource.DataSource = _servico.Filtrar(_condicaoinicial).Dados;
                    else
                        principalBindingSource.DataSource = _servico.Filtrar(_condicaoinicial);
                }
                
                gclPrincipal.Focus();
                gclPrincipal.Select();
            }

            if (_popup != null && _popup.Properties.Tag != null)
            {
                txtPesquisa.Text = _popup.Properties.Tag.ToString();
                _popup.Properties.Tag = null;
                txtPesquisa.Select(txtPesquisa.Text.Length + 1, 0);
            }
        }
    }
}
