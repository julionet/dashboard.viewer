using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Viewer.Entity
{
    public class Categoria
    {
        public int Id { get; set; }

        public string Descricao { get; set; }

        public bool Ativo { get; set; }

        public ICollection<Dashboard> Dashboard { get; set; }

        public Categoria()
        {
            this.Dashboard = new HashSet<Dashboard>();
        }
    }
}
