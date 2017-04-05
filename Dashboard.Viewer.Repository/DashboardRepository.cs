using Dashboard.Viewer.Entity;
using Dashboard.Viewer.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Viewer.Repository
{
    public class DashboardRepository : IDisposable
    {
        private DashboardViewerContext _db = new DashboardViewerContext();
        private IRepository<Entity.Dashboard> _repository;
        private string _usuario = "";

        public DashboardRepository(DashboardViewerContext context = null, string usuario = "")
        {
            _repository = new Repository<Entity.Dashboard>(context == null ? new DashboardViewerContext() : context);
            _usuario = usuario;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _db.Dispose();
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public string Incluir(Entity.Dashboard entity)
        {
            string mensagem = this.ValidarDados(entity);
            if (mensagem == "")
            {
                mensagem = _repository.Insert(entity);
            }
            return mensagem;
        }

        public string Alterar(Entity.Dashboard entity)
        {
            string mensagem = this.ValidarDados(entity);
            if (mensagem == "")
            {
                mensagem = _repository.Update(entity);
            }
            return mensagem;
        }

        public string Excluir(Entity.Dashboard entity)
        {
            string mensagem = this.ValidarExclusao(entity);
            if (mensagem == "")
            {
                mensagem = _repository.Delete(entity.Id);
            }
            return mensagem;
        }

        public Entity.Dashboard Selecionar(int id)
        {
            return _repository.GetById(id);
        }

        public IQueryable<Entity.Dashboard> SelecionarTodos()
        {
            return _repository.GetAll();
        }

        public IQueryable<Entity.Dashboard> Filtrar(string condicao)
        {
            return _repository.Filter(condicao);
        }

        public string ValidarDados(Entity.Dashboard entity)
        {
            return "";
        }

        public string ValidarExclusao(Entity.Dashboard entity)
        {
            return "";
        }

        public IQueryable<Entity.Dashboard> SelecionarPorCategoriaUsuario(int categoria, string usuario)
        {
            Usuario user = new UsuarioRepository().SelecionarPorLogin(usuario);
            if (user.Master)
                return this.SelecionarTodos().Where(p => p.CategoriaId == categoria && p.Ativo);
            else
                return (from d in _db.Dashboards
                        from u in d.Usuario
                        where u.Id == user.Id && d.CategoriaId == categoria && d.Ativo
                        select d);
        }
    }
}
