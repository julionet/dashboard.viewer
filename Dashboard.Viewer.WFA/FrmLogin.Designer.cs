namespace Dashboard.Viewer.WFA
{
    partial class FrmLogin
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.lblFechar = new DevExpress.XtraEditors.LabelControl();
            this.pcbFechar = new System.Windows.Forms.PictureBox();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.pclLogin = new DevExpress.XtraEditors.PanelControl();
            this.lblConfiguracao = new DevExpress.XtraEditors.LabelControl();
            this.btnIniciar = new DevExpress.XtraEditors.SimpleButton();
            this.pbxLogotipo = new System.Windows.Forms.PictureBox();
            this.txtUsuario = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtSenha = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pclLogin)).BeginInit();
            this.pclLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogotipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenha.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(4, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(762, 57);
            this.panelControl1.TabIndex = 13;
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.lblFechar);
            this.panelControl2.Controls.Add(this.pcbFechar);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl2.Location = new System.Drawing.Point(719, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(43, 57);
            this.panelControl2.TabIndex = 0;
            // 
            // lblFechar
            // 
            this.lblFechar.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechar.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblFechar.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblFechar.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFechar.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFechar.Location = new System.Drawing.Point(0, 42);
            this.lblFechar.Name = "lblFechar";
            this.lblFechar.Size = new System.Drawing.Size(43, 13);
            this.lblFechar.TabIndex = 1;
            this.lblFechar.Text = "Fechar";
            // 
            // pcbFechar
            // 
            this.pcbFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbFechar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pcbFechar.Image = global::Dashboard.Viewer.WFA.Properties.Resources.Sair_Metro;
            this.pcbFechar.Location = new System.Drawing.Point(0, 0);
            this.pcbFechar.Name = "pcbFechar";
            this.pcbFechar.Size = new System.Drawing.Size(43, 42);
            this.pcbFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcbFechar.TabIndex = 0;
            this.pcbFechar.TabStop = false;
            this.pcbFechar.Click += new System.EventHandler(this.pcbFechar_Click);
            // 
            // lblCopyright
            // 
            this.lblCopyright.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblCopyright.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyright.ForeColor = System.Drawing.Color.White;
            this.lblCopyright.Location = new System.Drawing.Point(4, 542);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(762, 40);
            this.lblCopyright.TabIndex = 14;
            this.lblCopyright.Text = "Copyright © CartSys Software";
            this.lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pclLogin
            // 
            this.pclLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pclLogin.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pclLogin.Appearance.Options.UseBackColor = true;
            this.pclLogin.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pclLogin.Controls.Add(this.labelControl3);
            this.pclLogin.Controls.Add(this.lblConfiguracao);
            this.pclLogin.Controls.Add(this.btnIniciar);
            this.pclLogin.Controls.Add(this.pbxLogotipo);
            this.pclLogin.Controls.Add(this.txtUsuario);
            this.pclLogin.Controls.Add(this.labelControl1);
            this.pclLogin.Controls.Add(this.labelControl2);
            this.pclLogin.Controls.Add(this.txtSenha);
            this.pclLogin.Location = new System.Drawing.Point(215, 102);
            this.pclLogin.Name = "pclLogin";
            this.pclLogin.Size = new System.Drawing.Size(345, 387);
            this.pclLogin.TabIndex = 15;
            // 
            // lblConfiguracao
            // 
            this.lblConfiguracao.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfiguracao.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblConfiguracao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblConfiguracao.Location = new System.Drawing.Point(9, 359);
            this.lblConfiguracao.Name = "lblConfiguracao";
            this.lblConfiguracao.Size = new System.Drawing.Size(174, 13);
            this.lblConfiguracao.TabIndex = 13;
            this.lblConfiguracao.Text = "Configuração do Banco de Dados";
            this.lblConfiguracao.Visible = false;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Appearance.Options.UseFont = true;
            this.btnIniciar.Location = new System.Drawing.Point(260, 348);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(78, 24);
            this.btnIniciar.TabIndex = 3;
            this.btnIniciar.Text = "&Iniciar";
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // pbxLogotipo
            // 
            this.pbxLogotipo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbxLogotipo.ErrorImage = null;
            this.pbxLogotipo.Image = global::Dashboard.Viewer.WFA.Properties.Resources.dashboard_viewer;
            this.pbxLogotipo.InitialImage = null;
            this.pbxLogotipo.Location = new System.Drawing.Point(0, 0);
            this.pbxLogotipo.Name = "pbxLogotipo";
            this.pbxLogotipo.Size = new System.Drawing.Size(345, 175);
            this.pbxLogotipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxLogotipo.TabIndex = 6;
            this.pbxLogotipo.TabStop = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(9, 260);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Properties.Appearance.Options.UseFont = true;
            this.txtUsuario.Properties.MaxLength = 20;
            this.txtUsuario.Size = new System.Drawing.Size(329, 20);
            this.txtUsuario.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Location = new System.Drawing.Point(9, 241);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Usuário";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Location = new System.Drawing.Point(9, 286);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(32, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Senha";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(9, 305);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Properties.Appearance.Options.UseFont = true;
            this.txtSenha.Properties.MaxLength = 10;
            this.txtSenha.Properties.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(329, 20);
            this.txtSenha.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(9, 181);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(329, 22);
            this.labelControl3.TabIndex = 14;
            this.labelControl3.Text = "Dashboard Viewer";
            // 
            // FrmLogin
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 586);
            this.Controls.Add(this.pclLogin);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Text = "FrmLogin";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pclLogin)).EndInit();
            this.pclLogin.ResumeLayout(false);
            this.pclLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogotipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenha.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl lblFechar;
        private System.Windows.Forms.PictureBox pcbFechar;
        private System.Windows.Forms.Label lblCopyright;
        private DevExpress.XtraEditors.PanelControl pclLogin;
        private DevExpress.XtraEditors.LabelControl lblConfiguracao;
        private DevExpress.XtraEditors.SimpleButton btnIniciar;
        private System.Windows.Forms.PictureBox pbxLogotipo;
        private DevExpress.XtraEditors.TextEdit txtUsuario;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtSenha;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}