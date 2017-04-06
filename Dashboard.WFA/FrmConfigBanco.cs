using Dashboard.Comunication;
using DevExpress.XtraEditors;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace Dashboard.WFA
{
    public partial class FrmConfigBanco : FrmModelo
    {
        private bool _aplicativoremoto;

        public FrmConfigBanco()
        {
            InitializeComponent();
            InitializeConfigurations();
            icbTipo_EditValueChanged(null, null);
        }

        private void betBancoDados_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (icbTipo.EditValue.ToString().Equals("C"))
                openFileDialog.Filter = "SQL Server Compact | *.sdf";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
                (sender as ButtonEdit).Text = openFileDialog.FileName;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (icbTipo.Enabled && string.IsNullOrWhiteSpace(icbTipo.Text))
            {
                XtraMessageBox.Show("Tipo não informado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DialogResult = DialogResult.None;
            }
            else if (icbTipo.Enabled && !icbTipo.EditValue.ToString().Equals("C") && string.IsNullOrWhiteSpace(txtServidor.Text))
            {
                XtraMessageBox.Show("Servidor não informado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DialogResult = DialogResult.None;
            }
            else if (icbTipo.Enabled && string.IsNullOrWhiteSpace(betBancoDados.Text))
            {
                XtraMessageBox.Show("Banco de dados não informado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DialogResult = DialogResult.None;
            }
            else if (icbTipo.Enabled && !icbTipo.EditValue.ToString().Equals("C") && string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                XtraMessageBox.Show("Usuário não informado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DialogResult = DialogResult.None;
            }
            else if (string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                XtraMessageBox.Show("Senha não informada!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DialogResult = DialogResult.None;
            }
            else
            {
                if (!PostConfigurations())
                    this.DialogResult = DialogResult.None;
                else
                    XtraMessageBox.Show("Configurações salvas com sucesso!\r\nÉ necessário reiniciar o aplicativo!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private string GetConnectionString(string tipo)
        {
            switch (tipo)
            {
                case "S":
                    {
                        return string.Format("Data Source={0};Initial Catalog={1};User Id={2};Password={3};Integrated Security=False;Persist Security Info=True;Multipleactiveresultsets=True;", txtServidor.Text, betBancoDados.Text, txtUsuario.Text, txtSenha.Text);
                    }
                case "C":
                    {
                        return string.Format("Data Source={0};Password={1}", betBancoDados.Text, txtSenha.Text);
                    }
                case "M":
                    {
                        return string.Format("Server={0};Database={1};Uid={2};Password={3}", txtServidor.Text, betBancoDados.Text, txtUsuario.Text, txtSenha.Text);
                    }
                default:
                    {
                        return string.Empty;
                    }
            }
        }

        private static string GetProviderName(string tipo)
        {
            switch (tipo)
            {
                case "S":
                    {
                        return "System.Data.SqlClient";
                    }
                case "C":
                    {
                        return "System.Data.SqlServerCe.4.0";
                    }
                case "M":
                    {
                        return "MySql.Data.MySqlClient";
                    }
                default:
                    {
                        return string.Empty;
                    }
            }
        }

        private void icbTipo_EditValueChanged(object sender, EventArgs e)
        {
            betBancoDados.Properties.Buttons[0].Visible = icbTipo.EditValue == null ? false : (icbTipo.EditValue.ToString() == "F") || (icbTipo.EditValue.ToString() == "C");
            txtServidor.Enabled = icbTipo.EditValue != null && icbTipo.EditValue.ToString() != "C" && !_aplicativoremoto;
            txtUsuario.Enabled = icbTipo.EditValue != null && icbTipo.EditValue.ToString() != "C" && !_aplicativoremoto;
            if (icbTipo.EditValue != null && (icbTipo.EditValue.ToString() == "C"))
            {
                txtServidor.Text = "";
                txtUsuario.Text = "";
            }
        }

        private void InitializeConfigurations()
        {
            Size = new System.Drawing.Size(525, 298);
            icbTipo.Enabled = true;
            txtServidor.Enabled = true;
            txtUsuario.Enabled = true;
            txtSenha.Enabled = true;
            betBancoDados.Enabled = true;

            if (ConfigurationManager.ConnectionStrings["DashboardConnectionString"] != null)
            {
                var sConnection = ConfigurationManager.ConnectionStrings["DashboardConnectionString"].ConnectionString;
                if (sConnection.ToLower().Contains(".sdf"))
                {
                    icbTipo.EditValue = "C";
                    foreach (string tag in sConnection.Split(';'))
                    {
                        if (tag.ToLower().Contains("data source"))
                            betBancoDados.Text = tag.Split('=')[1];
                        else if (tag.ToLower().Contains("password"))
                            txtSenha.Text = tag.Split('=')[1];
                    }
                }
                else if (sConnection.ToLower().Contains("server"))
                {
                    icbTipo.EditValue = "M";
                    foreach (string tag in sConnection.Split(';'))
                    {
                        if (tag.ToLower().Contains("server"))
                            txtServidor.Text = tag.Split('=')[1];
                        else if (tag.ToLower().Contains("database"))
                            betBancoDados.Text = tag.Split('=')[1];
                        else if (tag.ToLower().Contains("uid"))
                            txtUsuario.Text = tag.Split('=')[1];
                        else if (tag.ToLower().Contains("password"))
                            txtSenha.Text = tag.Split('=')[1];
                    }
                }
                else
                {
                    icbTipo.EditValue = "S";
                    foreach (string tag in sConnection.Split(';'))
                    {
                        if (tag.ToLower().Contains("data source"))
                            txtServidor.Text = tag.Split('=')[1];
                        else if (tag.ToLower().Contains("initial catalog"))
                            betBancoDados.Text = tag.Split('=')[1];
                        else if (tag.ToLower().Contains("user id"))
                            txtUsuario.Text = tag.Split('=')[1];
                        else if (tag.ToLower().Contains("password"))
                            txtSenha.Text = tag.Split('=')[1];
                    }
                }
            }
            _aplicativoremoto = false;
        }

        private bool PostConfigurations()
        {
            string mensagem = ConnectionString.SaveConnectionString(Application.ExecutablePath + ".config", "DashboardConnectionString", 
                GetConnectionString(icbTipo.EditValue.ToString()), GetProviderName(icbTipo.EditValue.ToString()));
            if (mensagem != "")
            {
                XtraMessageBox.Show(mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
                return true;
        }
    }
}
