using ProjetoADM.Codigos.View;
using System.Collections.Generic;

namespace ProjetoADM.Codigos.Produto
{
    class ProdutoBusiness
    {
        public int Salvar(ProdutoDTO dto)
        {
            ProdutoDatabase db = new ProdutoDatabase();
           
            return db.Salvar(dto);
        }

        public List<vm_consultar_produto> Consultar(string funcionario)
        {
            ProdutoDatabase db = new ProdutoDatabase();
            return db.Consultar(funcionario);
        }

        public void Alterar(ProdutoDTO dto)
        {
            ProdutoDatabase db = new ProdutoDatabase();
            db.Alterar(dto);
        }

        public void Remover(int ID)
        {
            ProdutoDatabase db = new ProdutoDatabase();
            db.Remover(ID);
        }
        public List<vm_consultar_produto> Listar()
        {
            ProdutoDatabase db = new ProdutoDatabase();
            return db.Listar();

        }
    }
}
