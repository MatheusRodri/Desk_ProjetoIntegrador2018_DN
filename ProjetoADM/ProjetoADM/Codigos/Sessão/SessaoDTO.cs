using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoADM.Codigos.Sessão
{
    class SessaoDTO
    {
        public int ID { get; set; }
        public string Forma_pgto { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }
        public int ID_tratamento { get; set; }
        public int Id_cliente { get; set; }
        public int Id_func { get; set; }

    }
}
