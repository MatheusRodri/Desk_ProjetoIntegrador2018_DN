using System.Collections.Generic;

namespace ProjetoADM.Codigos.Tratamento
{
    class TratamentoBusiness
    {
        public int Salvar(TratamentoDTO dto)
        {
            TratamentoDatabase db = new TratamentoDatabase();
           
            return db.Salvar(dto);
        }

        public List<TratamentoDTO> Consultar(string tratamento)
        {
            TratamentoDatabase db = new TratamentoDatabase();
            return db.Consultar(tratamento);
        }

        public void Alterar(TratamentoDTO dto)
        {
            TratamentoDatabase db = new TratamentoDatabase();
            db.Alterar(dto);
        }

        public void Remover(int ID)
        {
            TratamentoDatabase db = new TratamentoDatabase();
            db.Remover(ID);
        }
        public List<TratamentoDTO> Listar()
        {
            TratamentoDatabase db = new TratamentoDatabase();
            return db.Listar();
        }
    }
}
