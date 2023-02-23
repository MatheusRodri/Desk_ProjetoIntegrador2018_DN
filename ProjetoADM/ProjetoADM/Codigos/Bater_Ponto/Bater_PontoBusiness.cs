using ProjetoADM.Codigos.View;
using System;
using System.Collections.Generic;


namespace ProjetoADM.Codigos.Bater_ponto
{
    class Bater_PontoBusiness
    {
        public int Salvar(Bater_PontoDTO dto)
        {
            Bater_PontoDatabase db = new Bater_PontoDatabase();
            return db.Salvar(dto);
        }
        public List<vm_consultar_ponto> Consultar(string funcionario)    
        {
            Bater_PontoDatabase db = new Bater_PontoDatabase();
            return db.Consultar(funcionario);
        }
    }
}
