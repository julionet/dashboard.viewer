using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Viewer.Entity
{
    public class Dashboard
    {
        public int Id { get; set; }

        public string Descricao { get; set; }

        public string Xml { get; set; }

        public bool Ativo { get; set; }

        public int CategoriaId { get; set; }

        public virtual Categoria Categoria { get; set; }

        public virtual ICollection<Usuario> Usuario { get; set; }

        public Dashboard()
        {
            this.Usuario = new HashSet<Usuario>();
        }
    }
}
