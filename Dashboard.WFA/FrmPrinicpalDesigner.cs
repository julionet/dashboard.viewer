using DevExpress.XtraEditors;
using DevExpress.XtraTab;
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
    public partial class FrmPrinicpalDesigner : XtraForm
    {
        private bool _forcarsaida = false;

        public FrmPrinicpalDesigner()
        {
            InitializeComponent();
        }

        private void FrmPrinicpal_Load(object sender, EventArgs e)
        {
            this.Width = SystemInformation.WorkingArea.Width;
            this.Height = SystemInformation.WorkingArea.Height;
            this.Location = new Point(0, 0);
        }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            base.OnClosing(e);

            if (_forcarsaida)
                e.Cancel = false;
            else
            {
                DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutAction closeAction = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutAction();
                closeAction.Caption = navButtonTitulo.Caption;
                closeAction.Description = "Deseja realmente finalizar o sistema?";
                closeAction.Commands.Add(DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutCommand.Yes);
                closeAction.Commands.Add(DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutCommand.No);
                if (DevExpress.XtraBars.Docking2010.Customization.FlyoutDialog.Show(this, closeAction) != DialogResult.Yes)
                    e.Cancel = true;
            }
        }

        private void navButtonFechar_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            this.Close();
        }

        private void navButtonMinimizar_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void navButtonAlterarSenha_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            new FrmAlterarSenha().ShowDialog();
        }

        private void tileBarItemUsuarios_ItemClick(object sender, TileItemEventArgs e)
        {
            CreateFormTabPage(xtraTabControl, new FrmUsuario());
        }

        private void tileBarItemCategorias_ItemClick(object sender, TileItemEventArgs e)
        {
            CreateFormTabPage(xtraTabControl, new FrmCategoria());
        }

        private void tileBarItemDashboards_ItemClick(object sender, TileItemEventArgs e)
        {
            CreateFormTabPage(xtraTabControl, new FrmDashboard());
        }

        private void CreateFormTabPage(XtraTabControl paginas, XtraForm form)
        {
            bool bAchou = false;
            XtraTabPage newPag;
            foreach (XtraTabPage pag in paginas.TabPages)
                if (pag.Text == form.Text)
                {
                    newPag = pag;
                    paginas.SelectedTabPage = newPag;
                    bAchou = true;
                }

            if (!bAchou)
            {
                newPag = new XtraTabPage();
                newPag.Text = form.Text;

                form.TopLevel = false;
                form.FormBorderStyle = FormBorderStyle.None;
                form.Size = new Size(paginas.Size.Width, paginas.Size.Height - 24);

                if (form is FrmManutencao)
                {
                    (form as FrmManutencao).ParentControl = paginas;
                    (form as FrmManutencao).ParentPage = newPag;
                }

                newPag.Controls.Add(form);
                form.Show();

                paginas.TabPages.Add(newPag);
                paginas.SelectedTabPage = newPag;
            }
        }
    }
}
