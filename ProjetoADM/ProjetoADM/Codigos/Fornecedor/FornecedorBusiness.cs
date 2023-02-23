using System.Collections.Generic;

namespace ProjetoADM.Codigos.Fornecedor
{
    class FornecedorBusiness
    {
        public int Salvar(FornecedorDTO dto)
        {
            FornecedorDatabase db = new FornecedorDatabase();
   
            return db.Salvar(dto);
        }

        public List<FornecedorDTO> Consultar(string funcionario)
        {
            FornecedorDatabase db = new FornecedorDatabase();
            return db.Consultar(funcionario);
        }

        public void Alterar(FornecedorDTO dto)
        {
            FornecedorDatabase db = new FornecedorDatabase();
            db.Alterar(dto);
        }

        public void Remover(int ID)
        {
            FornecedorDatabase db = new FornecedorDatabase();
            db.Remover(ID);
        }
        public List<FornecedorDTO> Listar()
        {
            FornecedorDatabase db = new FornecedorDatabase();
            return db.Listar();

        }
    }
}
