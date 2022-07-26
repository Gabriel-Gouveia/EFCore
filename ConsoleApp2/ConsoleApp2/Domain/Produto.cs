﻿using ConsoleApp2.ValueOfObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Domain
{
    class Produto
    {
        public int Id { get; set; }
        public string CodigoBarras { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public TipoProduto TipoProduto { get; set; }
        public bool Ativo { get; set; }
    }
}
