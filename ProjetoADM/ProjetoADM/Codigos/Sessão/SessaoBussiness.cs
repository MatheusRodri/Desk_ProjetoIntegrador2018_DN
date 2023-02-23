using ProjetoADM.Codigos.View;
using System.Collections.Generic;

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
