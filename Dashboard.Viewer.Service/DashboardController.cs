using Dashboard.Viewer.Dto;
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

        public List<DashboardDto> SelecionarTodos()
        {
            return new DashboardRepository().SelecionarTodosDTO().ToList();
        }

        public List<DashboardDto> Filtrar(string condicao)
        {
            return new DashboardRepository().FiltrarDTO(condicao).ToList();
        }

        public List<Entity.Dashboard> SelecionarPorCategoriaUsuario(int categoria, string usuario)
        {
            return new DashboardRepository().SelecionarPorCategoriaUsuario(categoria, usuario).ToList();
        }

        public List<Entity.Dashboard> SelecionarAtivos()
        {
            return new DashboardRepository().SelecionarAtivos().ToList();
        }

        public List<Entity.Dashboard> SelecionarPorUsuario(int usuario)
        {
            return new DashboardRepository().SelecionarPorUsuario(usuario).ToList();
        }
    }
}
