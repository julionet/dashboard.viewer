using Dashboard.Viewer.Comunication;
using Dashboard.Viewer.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard.Viewer.WFA
{
    public partial class FrmCategoria : FrmManutencao
    {
        public FrmCategoria()
        {
            InitializeComponent();
        }

        private void InicializarCampos()
        {
            iKey = 0;
            (principalBindingSource.Current as Categoria).Ativo = true;
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
            iKey = (principalBindingSource.Current as Categoria).Id;
        }

        protected override void ObterDadosPrincipal()
        {
            principalBindingSource.Clear();
            if (!string.IsNullOrWhiteSpace(sCondicao))
                principalBindingSource.DataSource = Servicos.categoriaServico.Filtrar(sCondicao);
            else if (this.ExibirTodosRegistros)
                principalBindingSource.DataSource = Servicos.categoriaServico.SelecionarTodos();
        }

        protected override bool ExcluirRegistro()
        {
            string sMensagem = Servicos.categoriaServico.Excluir(principalBindingSource.Current as Categoria);
            if (sMensagem == "")
                return true;
            else
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(sMensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        protected override bool GravarRegistro()
        {
            string sMensagem = Servicos.categoriaServico.Salvar(principalBindingSource.Current as Categoria);
            if (sMensagem == "")
                return true;
            else
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(sMensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        private void gvwAcesso_DoubleClick(object sender, EventArgs e)
        {
            btnEditar_Click(null, null);
        }
    }
}
