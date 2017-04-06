using Dashboard.Comunication;
using Dashboard.Dto;
using Dashboard.Entity;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dashboard.WFA
{
    public partial class FrmDashboard : FrmManutencao
    {
        private ucPesquisa ucCategoria;

        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void InicializarCampos()
        {
            iKey = 0;
            (principalBindingSource.Current as DashboardDto).Ativo = true;
            principalBindingSource.ResetCurrentItem();
        }

        protected override void IncluirRegistro()
        {
            base.IncluirRegistro();
            InicializarCampos();
        }

        protected override void AlterarRegistro()
        {
            base.AlterarRegistro();
            iKey = (principalBindingSource.Current as DashboardDto).Id;
        }

        protected override void ObterDadosPrincipal()
        {
            principalBindingSource.Clear();
            if (!string.IsNullOrWhiteSpace(sCondicao))
                principalBindingSource.DataSource = Servicos.dashboardServico.Filtrar(sCondicao);
            else if (this.ExibirTodosRegistros)
                principalBindingSource.DataSource = Servicos.dashboardServico.SelecionarTodos();
        }

        protected override bool ExcluirRegistro()
        {
            string sMensagem = Servicos.dashboardServico.Excluir(Classe.CloneClass<Entity.Dashboard>(principalBindingSource.Current as DashboardDto));
            if (sMensagem == "")
                return true;
            else
            {
                XtraMessageBox.Show(sMensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        protected override bool GravarRegistro()
        {
            string sMensagem = Servicos.dashboardServico.Salvar(Classe.CloneClass<Entity.Dashboard>(principalBindingSource.Current as DashboardDto));
            if (sMensagem == "")
                return true;
            else
            {
                XtraMessageBox.Show(sMensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        private void gvwAcesso_DoubleClick(object sender, EventArgs e)
        {
            btnEditar_Click(null, null);
        }

        private void popupContainerEditCategoria_QueryPopUp(object sender, CancelEventArgs e)
        {
            string condicaoinicial = string.Format("(Ativo == true)");
            ucCategoria = new ucPesquisa(sender as PopupContainerEdit, PopupContainerRegistroPesquisa.RegistroPesquisaCategoria(), Servicos.categoriaServico, condicaoinicial);
            ucCategoria.Dock = DockStyle.Fill;

            PopupContainerControl control = new PopupContainerControl();
            control.Controls.Add(ucCategoria);

            (sender as PopupContainerEdit).Properties.PopupFormSize = new System.Drawing.Size((sender as PopupContainerEdit).Width, 200);
            (sender as PopupContainerEdit).Properties.PopupControl = control;
        }

        private void popupContainerEditCategoria_QueryResultValue(object sender, DevExpress.XtraEditors.Controls.QueryResultValueEventArgs e)
        {
            if (ucCategoria.bConfirmado)
            {
                (principalBindingSource.Current as DashboardDto).CategoriaId = (ucCategoria.oSelecao as Categoria).Id;
                (principalBindingSource.Current as DashboardDto).CategoriaDescricao = (ucCategoria.oSelecao as Categoria).Descricao;
                e.Value = (ucCategoria.oSelecao as Categoria).Descricao;
            }
        }

        private void popupContainerEditCategoria_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                (principalBindingSource.Current as DashboardDto).CategoriaId = 0;
                (principalBindingSource.Current as DashboardDto).CategoriaDescricao = null;
                principalBindingSource.ResetCurrentItem();
            }
            else
            {
                string key = Conversao.KeyCodeToString(e.KeyCode, e.Shift);
                if (key != "")
                {
                    (sender as PopupContainerEdit).Properties.Tag = key;
                    (sender as PopupContainerEdit).ShowPopup();
                }
            }
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            memoEditXml.Height = this.Height - 215;
            simpleButtonDesigner.Top = memoEditXml.Top + memoEditXml.Height + 8;
        }

        private void simpleButtonDesigner_Click(object sender, EventArgs e)
        {
            using (FrmDesigner form = new FrmDesigner((principalBindingSource.Current as DashboardDto).Xml))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    (principalBindingSource.Current as DashboardDto).Xml = form.Dashboard;
                    principalBindingSource.ResetCurrentItem();
                }
            }
        }
    }
}
