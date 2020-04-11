using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoADM.Codigos.Cliente
{
    class FuncionarioBussiness
    {

        public int Salvar(ClienteDTO dto)
        {
            ClienteDatabase db = new ClienteDatabase();
    
            return db.Salvar(dto);
        }

        public List<ClienteDTO> Consultar(string nome)
        {
            ClienteDatabase db = new ClienteDatabase();
            return db.Consultar(nome);
        }

        public void Alterar(ClienteDTO dto)
        {
            ClienteDatabase db = new ClienteDatabase();
            db.Alterar(dto);
        }

        public void Remover(int ID)
        {
            ClienteDatabase db = new ClienteDatabase();
            db.Remover(ID);
        }
        public List<ClienteDTO> Listar()
        {
            ClienteDatabase db = new ClienteDatabase();
            return db.Listar();

        }
    }
}
