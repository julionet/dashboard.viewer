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
using Dashboard.Comunication;
using System.IO;
using System.Configuration;

namespace Dashboard.WFA
{
    public partial class FrmViewer : DevExpress.XtraEditors.XtraForm
    {
        private DevExpress.XtraTab.XtraTabPage _parentPage;
        public DevExpress.XtraTab.XtraTabPage ParentPage
        {
            get { return _parentPage; }
            set { _parentPage = value; }
        }

        private DevExpress.XtraTab.XtraTabControl _parentControl;
        public DevExpress.XtraTab.XtraTabControl ParentControl
        {
            get { return _parentControl; }
            set { _parentControl = value; }
        }

        public FrmViewer(int id)
        {
            InitializeComponent();

            Entity.Dashboard dashboard = Servicos.dashboardServico.Selecionar(id);
            if (dashboard != null && !string.IsNullOrWhiteSpace(dashboard.Xml))
            {
                using (MemoryStream ms = Conversao.StringToStream(dashboard.Xml))
                {
                    dashboardViewer.LoadDashboard(ms);
                }
            }
        }
    }
}