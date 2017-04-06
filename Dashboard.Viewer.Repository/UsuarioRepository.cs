using Dashboard.Viewer.Entity;
using Dashboard.Viewer.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Viewer.Repository
{
    public class UsuarioRepository : IDisposable
    {
        private DashboardViewerContext _db = new DashboardViewerContext();
        private IRepository<Usuario> _repository;
        private string _usuario = "";

        public UsuarioRepository(DashboardViewerContext context = null, string usuario = "")
        {
            _repository = new Repository<Usuario>(context == null ? new DashboardViewerContext() : context);
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

        public string Incluir(Usuario entity)
        {
            string mensagem = this.ValidarDados(entity);
            if (mensagem == "")
            {
                mensagem = _repository.JoinEntity<Entity.Dashboard>(entity.Dashboard, entity.ListaDashboard);

                if (mensagem == "")
                    mensagem = _repository.Insert(entity);
            }
            return mensagem;
        }

        public string Alterar(Usuario entity)
        {
            string mensagem = this.ValidarDados(entity);
            if (mensagem == "")
            {
                mensagem = _repository.JoinEntity<Entity.Dashboard>(entity.Dashboard, entity.ListaDashboard);

                if (mensagem == "")
                    mensagem = _repository.Update(entity);
            }
            return mensagem;
        }

        public string Excluir(Usuario entity)
        {
            string mensagem = this.ValidarExclusao(entity);
            if (mensagem == "")
            {
                mensagem = _repository.Delete(entity.Id);
            }
            return mensagem;
        }

        public Usuario Selecionar(int id)
        {
            return _repository.GetById(id);
        }

        public IQueryable<Usuario> SelecionarTodos()
        {
            return _repository.GetAll();
        }

        public IQueryable<Usuario> Filtrar(string condicao)
        {
            return _repository.Filter(condicao);
        }

        public string ValidarDados(Usuario entity)
        {
            if (string.IsNullOrWhiteSpace(entity.Login))
                return "Login não informado!";
            else if (string.IsNullOrWhiteSpace(entity.Senha))
                return "Senha não informada!";
            return "";
        }

        public string ValidarExclusao(Usuario entity)
        {
            return "";
        }

        public Usuario SelecionarPorLogin(string login)
        {
            return this.SelecionarTodos().Where(p => p.Login == login).FirstOrDefault();
        }

        public string ValidarLogin(string login, string senha)
        {
            if (string.IsNullOrWhiteSpace(login))
                return "Usuário não informado!";
            else if (string.IsNullOrWhiteSpace(senha))
                return "Senha não informada!";
            else
            {
                Usuario user = this.SelecionarPorLogin(login);
                if ((user == null) || (user.Senha != senha))
                    return "Usuário ou senha incorretos!";
                else
                    return "";
            }
        }

        public string AlterarSenha(string usuario, string senhaantiga, string novasenha, string confirmacao)
        {
            if (string.IsNullOrWhiteSpace(usuario))
                return "Usuário não informado!";
            else if (string.IsNullOrWhiteSpace(senhaantiga))
                return "Senha antiga não informada!";
            else if (string.IsNullOrWhiteSpace(novasenha))
                return "Nova senha não informada!";
            else if (string.IsNullOrWhiteSpace(confirmacao))
                return "Confirmação não informada!";
            else if (novasenha != confirmacao)
                return "Confirmação não confere com a nova senha!";
            else
            {
                Usuario u = this.SelecionarPorLogin(usuario);
                if (u == null)
                    return "Usuário não cadastrado!";
                else if (u.Senha.ToUpper() != senhaantiga.ToUpper())
                    return "Senha antiga está incorreta!";
                else if (u.Senha.ToUpper() == novasenha.ToUpper())
                    return "Nova senha deve ser diferente da senha antiga!";
                else
                {
                    u.Senha = novasenha;
                    return this.Alterar(u);
                }
            }
        }
    }
}
