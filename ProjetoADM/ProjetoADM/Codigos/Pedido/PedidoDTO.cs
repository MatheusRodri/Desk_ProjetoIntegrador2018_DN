using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoADM.Codigos.Pedido
{
   public  class PedidoDTO
    {
        public int ID { get; set; }
        public int id_fornecor { get; set; }
        public int id_produto { get; set; }
        public decimal valor { get; set; }
    }
}
