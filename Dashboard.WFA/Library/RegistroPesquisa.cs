﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dashboard.WFA
{
    public class RegistroPesquisa
    {
        public int Id { get; set; }
        public string Campo { get; set; }
        public string Descricao { get; set; }
        public int Tamanho { get; set; }
        public Type Tipo { get; set; }
        public bool Padrao { get; set; }
    }
}
