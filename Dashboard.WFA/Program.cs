using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using System.Configuration;

namespace Dashboard.WFA
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SetSkinStyle(ConfigurationManager.AppSettings["skinName"].ToString());

            using (FrmLogin form = new FrmLogin())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    if (form.Modulo.Equals("V"))
                        Application.Run(new FrmPrincipalViewer());
                    else
                        Application.Run(new FrmPrinicpalDesigner());
                }
                else
                {
                    Application.Exit();
                }
            }
        }
    }
}
