using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Dashboard.WFA
{
    public partial class FrmModelo : DevExpress.XtraEditors.XtraForm
    {
        protected bool bInsertOrEdit = false;

        public int iKey = 0;
        public DevExpress.XtraTab.XtraTabPage ParentPage;
        public DevExpress.XtraTab.XtraTabControl ParentControl;

        public FrmModelo()
        {
            InitializeComponent();
            bInsertOrEdit = true;
        }

        public FrmModelo(BindingSource detalhe) 
            : this()
        {
            detalheBindingSource = detalhe;
        }

        private void FrmModelo_Load(object sender, EventArgs e)
        {
            //Interface.SetPropertyDefault(panBackground);
        }

        private void FrmModelo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (sender is Form)
                {
                    if ((sender as Form).ActiveControl is LookUpEdit)
                        ((sender as Form).ActiveControl as LookUpEdit).EditValue = null;
                    else if (((Form)sender).ActiveControl is ImageComboBoxEdit)
                        ((sender as Form).ActiveControl as ImageComboBoxEdit).EditValue = null;
                    else if (((Form)sender).ActiveControl is ComboBoxEdit)
                        ((sender as Form).ActiveControl as ComboBoxEdit).EditValue = null;
                }
            }
        }

        public void btnCancelar_Click(object sender, EventArgs e)
        {
            bInsertOrEdit = false;           
        }
    }
}
