using Dashboard.Viewer.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Viewer.Comunication
{
    public static class Servicos
    {
        public static CategoriaController categoriaServico = new CategoriaController();
        public static DashboardController dashboardServico = new DashboardController();
        public static UsuarioController usuarioServico = new UsuarioController();
    }
}
