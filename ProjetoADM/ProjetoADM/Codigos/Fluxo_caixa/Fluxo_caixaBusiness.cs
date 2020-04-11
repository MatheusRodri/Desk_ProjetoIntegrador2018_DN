using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
