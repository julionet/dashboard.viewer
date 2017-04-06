using DevExpress.XtraBars.Ribbon;
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
    public partial class FrmDesigner : RibbonForm
    {
        private string _dashboard = "";
        public string Dashboard
        {
            get { return _dashboard; }
        }

        public FrmDesigner(string xml = "")
        {
            InitializeComponent();

            if (!string.IsNullOrWhiteSpace(xml))
            {
                using (MemoryStream ms = Conversao.StringToStream(xml))
                {
                    dashboardDesigner.LoadDashboard(ms);
                }
            }
        }

        private void barButtonItemSalvar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string nomearquivo = Path.Combine(Path.GetTempPath(), Path.GetTempFileName());
            dashboardDesigner.Dashboard.SaveToXml(nomearquivo);
            _dashboard = File.ReadAllText(nomearquivo);
            File.Delete(nomearquivo);

            this.DialogResult = DialogResult.OK;
        }

        private void barButtonItemCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
