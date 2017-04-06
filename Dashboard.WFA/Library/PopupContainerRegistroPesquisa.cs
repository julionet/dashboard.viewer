using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.WFA
{
    public class PopupContainerRegistroPesquisa
    {
        private PopupContainerRegistroPesquisa()
        {

        }

        public static List<RegistroPesquisa> RegistroPesquisaCategoria()
        {
            List<RegistroPesquisa> pesquisa = new List<RegistroPesquisa>();
            pesquisa.Add(new RegistroPesquisa() { Id = 1, Descricao = "Descrição", Campo = "Descricao", Padrao = true, Tipo = typeof(string), Tamanho = 100 });
            return pesquisa;
        }
    }
}
