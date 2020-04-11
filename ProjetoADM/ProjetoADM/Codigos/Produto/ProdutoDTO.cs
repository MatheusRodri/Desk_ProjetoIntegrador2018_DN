using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoADM.Codigos.Produto
{
   public  class ProdutoDTO
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public DateTime Data_vencimento { get; set; }
        public int Id_fornecedor { get; set; }
    }
}
