using Dashboard.Comunication;
using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace Dashboard.WFA
{
    public partial class FrmAlterarSenha : FrmModelo
    {
        public FrmAlterarSenha()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var mensagem = Servicos.usuarioServico.AlterarSenha(Global.UsuarioLogin, Security.GetSHA1(txtSenhaAntiga.Text),
                Security.GetSHA1(txtNovaSenha.Text), Security.GetSHA1(txtConfirmacao.Text));
            if (mensagem != "")
            {
                XtraMessageBox.Show(mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                txtSenhaAntiga.Focus();
                txtSenhaAntiga.SelectAll();
                this.DialogResult = DialogResult.None;
            }
            else
                XtraMessageBox.Show("Senha alterada com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        private void FrmAlterarSenha_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = Global.UsuarioLogin;
            txtSenhaAntiga.Focus();
            txtSenhaAntiga.Select();
        }
    }
}
