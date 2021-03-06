﻿using Dashboard.Entity;
using Dashboard.Infrastructure;
using Dashboard.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Service
{
    public class CategoriaController
    {
        private string _mensagem = "";

        public string Salvar(Categoria entity)
        {
            DashboardContext _db = new DashboardContext();
            using (DbContextTransaction transacao = DashboardTransaction.CreateDbContextTransaction(_db))
            {
                if (entity.Id == 0)
                    _mensagem = new CategoriaRepository(_db).Incluir(entity);
                else
                    _mensagem = new CategoriaRepository(_db).Alterar(entity);

                if (_mensagem == "")
                    transacao.Commit();
                else
                    transacao.Rollback();
            }
            return _mensagem;
        }

        public string Excluir(Categoria entity)
        {
            DashboardContext _db = new DashboardContext();
            using (DbContextTransaction transacao = DashboardTransaction.CreateDbContextTransaction(_db))
            {
                _mensagem = new CategoriaRepository(_db).Excluir(entity);
                if (_mensagem == "")
                    transacao.Commit();
                else
                    transacao.Rollback();
            }
            return _mensagem;
        }

        public Categoria Selecionar(int id)
        {
            return new CategoriaRepository().Selecionar(id);
        }

        public List<Categoria> SelecionarTodos()
        {
            return new CategoriaRepository().SelecionarTodos().ToList();
        }

        public List<Categoria> Filtrar(string condicao)
        {
            return new CategoriaRepository().Filtrar(condicao).ToList();
        }

        public List<Categoria> SelecionarAtivos()
        {
            return new CategoriaRepository().SelecionarAtivos().ToList();
        }
    }
}
