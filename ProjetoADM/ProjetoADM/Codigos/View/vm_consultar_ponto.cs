using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoADM.Codigos.View
{
    class vm_consultar_ponto
    {
        public DateTime Data { get; set; }
        public DateTime hora_entrada { get; set; }
        public DateTime hora_saida { get; set; }
        public DateTime almoco { get; set; }
        public DateTime almocovolta { get; set; }
        public DateTime saida { get; set; }
        public string func { get; set; }

    }
}
