using System.Collections.Generic;

namespace ProjetoADM.Codigos.Funcionarios
{
    class FuncionariosBusiness
    {
        public FuncionariosDTO Logar(string login, string senha)
        {
            FuncionariosDatabase db = new FuncionariosDatabase();
            FuncionariosDTO funcionariosDTO = db.Logar(login, senha);

            return funcionariosDTO;
        }

        public int Salvar(FuncionariosDTO dto)
        {
            FuncionariosDatabase db = new FuncionariosDatabase();
           
            return db.Salvar(dto);
        }

        public List<FuncionariosDTO> Consultar(string funcionario)
        {
            FuncionariosDatabase db = new FuncionariosDatabase();
           return db.Consultar(funcionario);
        }

        public void Alterar(FuncionariosDTO dto)
        {
            FuncionariosDatabase db = new FuncionariosDatabase();
            db.Alterar(dto);
        }

        public void Remover(int ID)
        {
            FuncionariosDatabase db = new FuncionariosDatabase();
            db.Remover(ID);
        }
        public List<FuncionariosDTO> Listar()
        {
            FuncionariosDatabase db = new FuncionariosDatabase();
           return db.Listar();
            
        }
    }
}
