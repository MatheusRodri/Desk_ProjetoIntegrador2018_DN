using ProjetoADM.Codigos.View;
using System.Collections.Generic;


namespace ProjetoADM.Codigos.Estoque
{
    class EstoqueBusiness
    {
        public int Salvar(EstoqueDTO dto)
        {
            EstoqueDatabase db = new EstoqueDatabase();
           
            return db.Salvar(dto);
        }

        public List<vm_consultar_estoque> Consultar(string funcionario)
        {
            EstoqueDatabase db = new EstoqueDatabase();
            return db.Consultar(funcionario);
        }

        public void Alterar(EstoqueDTO dto)
        {
            EstoqueDatabase db = new EstoqueDatabase();
            db.Alterar(dto);
        }

        public void Remover(int ID)
        {
            EstoqueDatabase db = new EstoqueDatabase();
            db.Remover(ID);
        }
        public List<vm_consultar_estoque> Listar()
        {
            EstoqueDatabase db = new EstoqueDatabase();
            return db.Listar();

        }
    }
}
