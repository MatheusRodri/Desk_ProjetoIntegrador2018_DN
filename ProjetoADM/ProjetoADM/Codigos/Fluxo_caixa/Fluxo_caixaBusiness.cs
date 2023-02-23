using System;
using System.Collections.Generic;

namespace ProjetoADM.Codigos.Fluxo_caixa
{
    class Fluxo_caixaBusiness
    {
        public List<Fluxo_caixaDTO> Consultar(DateTime inicio, DateTime fim)
        {
            Fluxo_caixaDatabase db = new Fluxo_caixaDatabase();
            return db.Consultar(inicio, fim);

        }
    }
}
