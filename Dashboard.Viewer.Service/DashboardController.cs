using Dashboard.Viewer.Infrastructure;
using Dashboard.Viewer.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Viewer.Service
{
    public class DashboardController
    {
        private string _mensagem = "";

        public string Salvar(Entity.Dashboard entity)
        {
            DashboardViewerContext _db = new DashboardViewerContext();
            using (DbContextTransaction transacao = DashboardViewerTransaction.CreateDbContextTransaction(_db))
            {
                if (entity.Id == 0)
                    _mensagem = new DashboardRepository(_db).Incluir(entity);
                else
                    _mensagem = new DashboardRepository(_db).Alterar(entity);

                if (_mensagem == "")
                    transacao.Commit();
                else
                    transacao.Rollback();
            }
            return _mensagem;
        }

        public string Excluir(Entity.Dashboard entity)
        {
            DashboardViewerContext _db = new DashboardViewerContext();
            using (DbContextTransaction transacao = DashboardViewerTransaction.CreateDbContextTransaction(_db))
            {
                _mensagem = new DashboardRepository(_db).Excluir(entity);
                if (_mensagem == "")
                    transacao.Commit();
                else
                    transacao.Rollback();
            }
            return _mensagem;
        }

        public Entity.Dashboard Selecionar(int id)
        {
            return new DashboardRepository().Selecionar(id);
        }

        public List<Entity.Dashboard> SelecionarTodos()
        {
            return new DashboardRepository().SelecionarTodos().ToList();
        }

        public List<Entity.Dashboard> Filtrar(string condicao)
        {
            return new DashboardRepository().Filtrar(condicao).ToList();
        }

        public List<Entity.Dashboard> SelecionarPorCategoriaUsuario(int categoria, string usuario)
        {
            return new DashboardRepository().SelecionarPorCategoriaUsuario(categoria, usuario).ToList();
        }
    }
}
