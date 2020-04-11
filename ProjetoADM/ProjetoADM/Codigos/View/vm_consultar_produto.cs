using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoADM.Codigos.View
{
   public class vm_consultar_produto
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public DateTime Data_vencimento { get; set; }
        public string nome_forn { get; set; }
    }
}
