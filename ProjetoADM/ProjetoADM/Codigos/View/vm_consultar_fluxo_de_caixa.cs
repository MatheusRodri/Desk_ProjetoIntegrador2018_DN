using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoADM.Codigos.View
{
    class vm_consultar_fluxo_de_caixa
    {
        public int ID { get; set; }
        public DateTime Data_de_entrada { get; set; }
        public DateTime Data_de_saida { get; set; }
        public decimal Total_de_entrada { get; set; }
        public decimal Total_de_saida { get; set; }
        public int id_pedido { get; set; }
    }
}
