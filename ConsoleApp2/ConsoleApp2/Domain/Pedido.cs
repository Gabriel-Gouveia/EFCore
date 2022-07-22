using ConsoleApp2.ValueOfObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Domain
{
    class Pedido
    {
        public int Id { get; set; }
        public int ClienteID { get; set; }
        public Cliente Cliete { get; set; }
        public DateTime IniciadoEm { get; set; }
        public DateTime FinalizadoEm { get; set; }
        public TipoFrete TipoFrete { get; set; }
        public StatusPedido Status { get; set; }
        public string Observacao { get; set; }
        public int MyProperty { get; set; }
        public ICollection<PedidoItem> Itens { get; set; }
    }
}
