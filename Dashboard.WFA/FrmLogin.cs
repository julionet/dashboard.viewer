﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Dashboard.Comunication;
using DevExpress.LookAndFeel;
using System.Configuration;

namespace Dashboard.WFA
{
    public partial class FrmLogin : DevExpress.XtraEditors.XtraForm
    {
        public string Modulo
        {
            get { return radioGroupModulo.EditValue.ToString(); }
        }

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            this.Width = SystemInformation.WorkingArea.Width;
            this.Height = SystemInformation.WorkingArea.Height;
            this.Location = new Point(0, 0);
            this.BackColor = Conversao.SkinNameToColor(UserLookAndFeel.Default.SkinName);

            Interface.EnterMoveNextControl(panelContrologin);

            bool exibeModulo = Convert.ToBoolean(ConfigurationManager.AppSettings["selecionaModulo"]);
            labelControlModulo.Visible = exibeModulo;
            radioGroupModulo.Visible = exibeModulo;
            radioGroupModulo.EditValue = "V";

            panelContrologin.Location = new Point((this.Width / 2) - (panelContrologin.Width / 2), (this.Height / 2) - (panelContrologin.Height / 2));
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string mensagem = Servicos.usuarioServico.ValidarLogin(txtUsuario.Text, string.IsNullOrWhiteSpace(txtSenha.Text) ? "" : Security.GetSHA1(txtSenha.Text));
            if (mensagem != "")
                XtraMessageBox.Show(mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                Global.UsuarioLogin = txtUsuario.Text;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void pcbFechar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}