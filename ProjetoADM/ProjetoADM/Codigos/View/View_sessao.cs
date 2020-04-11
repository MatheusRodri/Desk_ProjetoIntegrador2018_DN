using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoADM.Codigos.View
{
    public class View_sessao
    {
        public int ID { get; set; }
        public string cliente { get; set; }
        public string funcionario { get; set; }
        public DateTime data { get; set; }
        public string tratamento { get; set; }
        public string form_pgto { get; set; }
        public decimal valor { get; set; }
    }
}
