using Dashboard.Dto;
using Dashboard.Entity;
using Dashboard.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Repository
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
            if (string.IsNullOrWhiteSpace(entity.Descricao))
                return "Descrição não informada!";
            else if (entity.CategoriaId == 0)
                return "Categoria não informada!";
            else if (string.IsNullOrWhiteSpace(entity.Xml))
                return "Xml não informado!";
            return "";
        }

        public string ValidarExclusao(Entity.Dashboard entity)
        {
            return "";
        }

        public IQueryable<DashboardDto> SelecionarTodosDTO()
        {
            return (from q in _db.Dashboards
                    select new DashboardDto
                    {
                        Ativo = q.Ativo,
                        CategoriaDescricao = q.Categoria.Descricao,
                        CategoriaId = q.CategoriaId,
                        Descricao = q.Descricao,
                        Id = q.Id,
                        Xml = q.Xml
                    });
        }

        public IQueryable<DashboardDto> FiltrarDTO(string condicao)
        {
            return this.SelecionarTodosDTO();
        }

        public IQueryable<Entity.Dashboard> SelecionarAtivos()
        {
            return this.SelecionarTodos().Where(p => p.Ativo);
        }

        public IQueryable<Entity.Dashboard> SelecionarPorUsuario(int usuario)
        {
            return (from d in _db.Dashboards from u in d.Usuario where u.Id == usuario select d);
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
