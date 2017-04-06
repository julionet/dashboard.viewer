using Dashboard.Viewer.Entity;
using Dashboard.Viewer.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Viewer.Repository
{
    public class CategoriaRepository : IDisposable
    {
        private DashboardViewerContext _db = new DashboardViewerContext();
        private IRepository<Categoria> _repository;
        private string _usuario = "";

        public CategoriaRepository(DashboardViewerContext context = null, string usuario = "")
        {
            _repository = new Repository<Categoria>(context == null ? new DashboardViewerContext() : context);
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

        public string Incluir(Categoria entity)
        {
            string mensagem = this.ValidarDados(entity);
            if (mensagem == "")
            {
                mensagem = _repository.Insert(entity);
            }
            return mensagem;
        }

        public string Alterar(Categoria entity)
        {
            string mensagem = this.ValidarDados(entity);
            if (mensagem == "")
            {
                mensagem = _repository.Update(entity);
            }
            return mensagem;
        }

        public string Excluir(Categoria entity)
        {
            string mensagem = this.ValidarExclusao(entity);
            if (mensagem == "")
            {
                mensagem = _repository.Delete(entity.Id);
            }
            return mensagem;
        }

        public Categoria Selecionar(int id)
        {
            return _repository.GetById(id);
        }

        public IQueryable<Categoria> SelecionarTodos()
        {
            return _repository.GetAll();
        }

        public IQueryable<Categoria> Filtrar(string condicao)
        {
            return _repository.Filter(condicao);
        }

        public string ValidarDados(Categoria entity)
        {
            if (string.IsNullOrWhiteSpace(entity.Descricao))
                return "Descrição não informada!";
            else
                return "";
        }

        public string ValidarExclusao(Categoria entity)
        {
            if ((from q in _db.Dashboards where q.CategoriaId == entity.Id select q).Count() != 0)
                return "Não é permitido excluir uma categoria associada a um ou mais dashboards!"
            else
                return "";
        }

        public IQueryable<Categoria> SelecionarAtivos()
        {
            return this.SelecionarTodos().Where(p => p.Ativo);
        }
    }
}
