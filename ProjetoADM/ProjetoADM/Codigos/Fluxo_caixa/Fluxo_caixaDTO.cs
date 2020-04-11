    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoADM.Codigos.Fluxo_caixa
{
    class Fluxo_caixaDTO
    {
        public DateTime DataReferencia { get; set; }
        public decimal ValorGanhos { get; set; }
        public decimal ValorDespesas { get; set; }
        public decimal ValorLucros { get; set; }
    }
}
