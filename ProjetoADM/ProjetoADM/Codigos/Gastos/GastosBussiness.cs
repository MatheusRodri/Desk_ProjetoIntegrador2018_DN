using System.Collections.Generic;

namespace ProjetoADM.Codigos.Gastos
{
    class GastosBussiness
    {
        public int Salvar(GastosDTO dto)
        {
            GastosDatabase db = new GastosDatabase();

            return db.Salvar(dto);
        }

        public List<GastosDTO> Consultar(string funcionario)
        {
            GastosDatabase db = new GastosDatabase();
            return db.Consultar(funcionario);
        }

        public void Alterar(GastosDTO dto)
        {
            GastosDatabase db = new GastosDatabase();
            db.Alterar(dto);
        }

        public void Remover(int ID)
        {
            GastosDatabase db = new GastosDatabase();
            db.Remover(ID);
        }
        public List<GastosDTO> Listar()
        {
            GastosDatabase db = new GastosDatabase();
            return db.Listar();

        }
    }
}
