using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Viewer.Comunication
{
    public static class Global
    {
        private static string _usuariologin;
        public static string UsuarioLogin
        {
            get { return _usuariologin; }
            set { _usuariologin = value; }
        }
    }
}
