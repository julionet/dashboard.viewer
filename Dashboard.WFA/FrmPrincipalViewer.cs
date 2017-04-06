using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraNavBar;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraTab;
using Dashboard.Entity;
using Dashboard.Comunication;
using DevExpress.XtraTab.ViewInfo;

namespace Dashboard.WFA
{
    public partial class FrmPrincipalViewer : XtraForm
    {
        private bool _forcarsaida = false;

        private void CreateGroups()
        {
            NavBarGroup primeiroGrupo = null;

            foreach (Categoria categoria in Servicos.categoriaServico.SelecionarAtivos().OrderBy(p => p.Descricao))
            {
                TileBarGroup tileBarGroup = new TileBarGroup();

                foreach (Entity.Dashboard dashboard in Servicos.dashboardServico.SelecionarPorCategoriaUsuario(categoria.Id, Global.UsuarioLogin))
                {
                    TileBarItem tileBarItem = new TileBarItem();
                    tileBarItem.ItemSize = TileBarItemSize.Wide;
                    tileBarItem.Tag = dashboard.Id;
                    tileBarItem.Elements.Add(new TileItemElement
                    {
                        Text = dashboard.Descricao,
                        TextAlignment = TileItemContentAlignment.MiddleCenter
                    });
                    tileBarItem.ItemClick += (sender, e) =>
                    {
                        bool bAchou = false;
                        XtraTabPage newPage;
                        foreach (XtraTabPage pagina in xtraTabControl.TabPages)
                            if ((int)pagina.Tag == dashboard.Id)
                            {
                                newPage = pagina;
                                xtraTabControl.SelectedTabPage = newPage;
                                bAchou = true;
                            }

                        if (!bAchou)
                        {
                            newPage = new XtraTabPage();
                            newPage.Text = dashboard.Descricao;
                            newPage.Tag = dashboard.Id;

                            FrmViewer formViewer = new FrmViewer(dashboard.Id);
                            formViewer.TopLevel = false;
                            formViewer.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                            formViewer.Size = new Size(xtraTabControl.Size.Width, xtraTabControl.Size.Height - 24);
                            formViewer.ParentControl = xtraTabControl;
                            formViewer.ParentPage = newPage;
                            newPage.Controls.Add(formViewer);
                            formViewer.Show();

                            xtraTabControl.TabPages.Add(newPage);
                            xtraTabControl.SelectedTabPage = newPage;
                        }
                        navBarControl.OptionsNavPane.NavPaneState = NavPaneState.Collapsed;
                        navBarControl.HideNavPaneForm();
                    };
                    tileBarGroup.Items.Add(tileBarItem);
                }

                TileBar tileBar = new TileBar();
                tileBar.AllowDrag = false;
                tileBar.Dock = DockStyle.Fill;
                tileBar.ScrollMode = TileControlScrollMode.ScrollButtons;
                tileBar.Orientation = Orientation.Vertical;
                tileBar.DropDownOptions.BeakColor = Color.Empty;
                tileBar.WideTileWidth = 160;
                tileBar.Groups.Add(tileBarGroup);

                NavBarGroupControlContainer container = new NavBarGroupControlContainer();
                container.Controls.Add(tileBar);

                NavBarGroup navBarGroup = new NavBarGroup(categoria.Descricao);
                navBarGroup.GroupClientHeight = 80;
                navBarGroup.GroupStyle = NavBarGroupStyle.ControlContainer;
                navBarGroup.ControlContainer = container;
                navBarGroup.Expanded = true;
                navBarControl.Controls.Add(container);
                navBarControl.Groups.Add(navBarGroup);

                if (primeiroGrupo == null)
                    primeiroGrupo = navBarGroup;
            }

            if (primeiroGrupo != null)
                navBarControl.ActiveGroup = primeiroGrupo;
            navBarControl.OptionsNavPane.NavPaneState = NavPaneState.Expanded;
        }

        public FrmPrincipalViewer()
        {
            InitializeComponent();

            CreateGroups();
        }

        private void navButtonFechar_ElementClick(object sender, NavElementEventArgs e)
        {
            this.Close();
        }

        private void navButtonMinimizar_ElementClick(object sender, NavElementEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void navButtonAlterarSenha_ElementClick(object sender, NavElementEventArgs e)
        {
            new FrmAlterarSenha().ShowDialog();
        }

        private void navButtonTrocarUsuario_ElementClick(object sender, NavElementEventArgs e)
        {
            _forcarsaida = true;
            if (new FrmLogin().ShowDialog() == DialogResult.OK)
            {
                navBarControl.Groups.Clear();
                xtraTabControl.TabPages.Clear();
                this.CreateGroups();
                _forcarsaida = false;
            }
            else
                this.Close();
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

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.Width = SystemInformation.WorkingArea.Width;
            this.Height = SystemInformation.WorkingArea.Height;
            this.Location = new Point(0, 0);
        }

        private void xtraTabControl_CloseButtonClick(object sender, EventArgs e)
        {
            (sender as XtraTabControl).TabPages.Remove(((e as ClosePageButtonEventArgs).Page as XtraTabPage));
        }
    }
}