using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Domain
{
    class PedidoItem
    {
        public int Id { get; set; }
        public int PedidoID { get; set; }
        public Pedido Pedido { get; set; }
        public int ProdutoID { get; set; }
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public decimal Valor { get; set; }
        public decimal Desconto { get; set; }
    }
}
