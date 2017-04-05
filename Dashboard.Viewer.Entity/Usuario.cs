using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Viewer.Entity
{
    public class Usuario
    {
        public int Id { get; set; }

        public string Login { get; set; }

        public string Senha { get; set; }

        public bool Master { get; set; }

        public bool Bloqueado { get; set; }

        public virtual ICollection<Dashboard> Dashboard { get; set; }

        public Usuario()
        {
            this.Dashboard = new HashSet<Dashboard>();
        }
    }
}
