using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoADM.Codigos.Bater_ponto
{
    class Bater_PontoDTO
    {
        public int ID { get; set; }
        public DateTime Data_entrada { get; set; }
        public DateTime Hora_entrada  { get; set; }
        public DateTime Hora_almoco { get; set; }
        public DateTime Hora_almoco_volta { get; set; }
        public DateTime Hora_Saida { get; set; }
        public int id_funcionario { get; set; }

    }
}
