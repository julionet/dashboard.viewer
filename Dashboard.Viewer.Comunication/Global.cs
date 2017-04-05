using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Viewer.Comunication
{
    public static class Global
    {
        private static string _usuariologado;
        public static string UsuarioLogado
        {
            get { return _usuariologado; }
            set { _usuariologado = value; }
        }
    }
}
