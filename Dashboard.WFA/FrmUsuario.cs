using Dashboard.Comunication;
using Dashboard.Entity;
using DevExpress.XtraEditors.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard.WFA
{
    public partial class FrmUsuario : FrmManutencao
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void InicializarCampos()
        {
            iKey = 0;
            (principalBindingSource.Current as Usuario).Master = false;
            (principalBindingSource.Current as Usuario).Bloqueado = false;
            principalBindingSource.ResetCurrentItem();
        }

        protected override void PreencherCheckListBox()
        {
            base.PreencherCheckListBox();

            Entity.Dashboard[] dashboards = Servicos.dashboardServico.SelecionarPorUsuario(iKey).ToArray();
            checkedListBoxControlDashboard.Items.Clear();
            foreach (Entity.Dashboard item in Servicos.dashboardServico.SelecionarAtivos())
            {
                if (dashboards.Where(p => p.Id == item.Id).Count() == 0)
                    checkedListBoxControlDashboard.Items.Add(item.Id, item.Descricao, CheckState.Unchecked, true);
                else
                    checkedListBoxControlDashboard.Items.Add(item.Id, item.Descricao, CheckState.Checked, true);
            }
        }

        protected override void GravarCheckListBox()
        {
            base.GravarCheckListBox();

            (principalBindingSource.Current as Usuario).ListaDashboard = "";
            foreach (CheckedListBoxItem item in checkedListBoxControlDashboard.CheckedItems)
                (principalBindingSource.Current as Usuario).ListaDashboard += (principalBindingSource.Current as Usuario).ListaDashboard == "" ? item.Value.ToString() : "|" + item.Value.ToString();
        }

        protected override void IncluirRegistro()
        {
            base.IncluirRegistro();
            labelControlSenha.Text = "";
            InicializarCampos();
        }

        protected override void AlterarRegistro()
        {
            base.AlterarRegistro();
            labelControlSenha.Text = "";
            iKey = (principalBindingSource.Current as Usuario).Id;
        }

        protected override void ObterDadosPrincipal()
        {
            principalBindingSource.Clear();
            if (!string.IsNullOrWhiteSpace(sCondicao))
                principalBindingSource.DataSource = Servicos.usuarioServico.Filtrar(sCondicao);
            else if (this.ExibirTodosRegistros)
                principalBindingSource.DataSource = Servicos.usuarioServico.SelecionarTodos();
        }

        protected override bool ExcluirRegistro()
        {
            string sMensagem = Servicos.usuarioServico.Excluir(principalBindingSource.Current as Usuario);
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
            string sMensagem = Servicos.usuarioServico.Salvar(principalBindingSource.Current as Usuario);
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

        private void simpleButtonGerarSenha_Click(object sender, EventArgs e)
        {
            labelControlSenha.Text = GerarSenha();
            (principalBindingSource.Current as Usuario).Senha = Security.GetSHA1(labelControlSenha.Text);
        }

        private string GerarSenha()
        {
            int asc = 0;
            StringBuilder sSenha = new StringBuilder();

            Random random = new Random();
            char ch;

            for (int i = 0; i < 6; i++)
            {
                asc = Convert.ToInt32(Convert.ToInt32(Math.Floor(58 * random.NextDouble() + 65)));
                while ((asc >= 91) && (asc <= 96))
                    asc = Convert.ToInt32(Convert.ToInt32(Math.Floor(58 * random.NextDouble() + 65)));

                ch = Convert.ToChar(asc);
                sSenha.Append(ch);
            }
            return (sSenha.ToString() + (Math.Floor(9 * random.NextDouble())).ToString() + "@");
        }

        private void checkEditMaster_CheckedChanged(object sender, EventArgs e)
        {
            groupControlDashboard.Enabled = !checkEditMaster.Checked;
        }
    }
}
