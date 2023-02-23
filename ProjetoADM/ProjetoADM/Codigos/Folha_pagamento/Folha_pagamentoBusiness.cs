using ProjetoADM.Codigos.View;
using System.Collections.Generic;

namespace ProjetoADM.Codigos.Folha_pagamento
{
    class Folha_pagamentoBusiness
    {
        public int Salvar(Folha_pagamentoDTO Dto)
        {
            Folha_pagamentoDatabase db = new Folha_pagamentoDatabase();
            return db.Salvar(Dto);
        }
        public List<vm_folha_pagamento> Consultar(string funcionario)
        {
            Folha_pagamentoDatabase db = new Folha_pagamentoDatabase();
            return db.Consultar(funcionario);
        }
    }
}
