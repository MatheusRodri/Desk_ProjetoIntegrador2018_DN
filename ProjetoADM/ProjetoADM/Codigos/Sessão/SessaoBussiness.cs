using ProjetoADM.Codigos.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoADM.Codigos.Sessão
{
    class SessaoBussiness
    {

        public int Salvar(SessaoDTO dto)
        {
            SessaoDatabase db = new SessaoDatabase();
            
            return db.Salvar(dto);
        }

        public List<View_sessao> Consultar(string secao)
        {
            SessaoDatabase db = new SessaoDatabase();
            return db.Consultar(secao);
        }

        public void Alterar(SessaoDTO dto)
        {
            SessaoDatabase db = new SessaoDatabase();
            db.Alterar(dto);
        }

        public void Remover(int ID)
        {
            SessaoDatabase db = new SessaoDatabase();
            db.Remover(ID);
        }
        public List<View_sessao> Listar()
        {
            SessaoDatabase db = new SessaoDatabase();
            return db.Listar();

        }
    }
}
