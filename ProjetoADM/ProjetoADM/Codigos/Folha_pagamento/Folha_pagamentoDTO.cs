using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoADM.Codigos.Folha_pagamento
{
    class Folha_pagamentoDTO
    {
        public int ID { get; set; }
        public decimal Hora_Extra { get; set; }
        public int Atrasos { get; set; }
        public int Faltas { get; set; }
        public decimal INSS { get; set; }
        public decimal I_Renda { get; set; }
        public decimal FGTS { get; set; }
        public decimal V_trans { get; set; }
        public decimal Vale_refeicao { get; set; }
        public decimal Convenio_medico { get; set; }
        public decimal Salario_liquido { get; set; }
        public decimal Salario_bruto { get; set; }
        public int id_funcionario { get; set; }
        public DateTime data { get; set; }

    }
}
