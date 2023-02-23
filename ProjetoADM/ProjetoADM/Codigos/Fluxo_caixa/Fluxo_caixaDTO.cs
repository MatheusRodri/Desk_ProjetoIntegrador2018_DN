using System;

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
