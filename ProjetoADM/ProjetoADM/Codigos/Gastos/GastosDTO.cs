using System;

namespace ProjetoADM.Codigos.Gastos
{
    class GastosDTO
    {
        public int ID { get; set; }
        public DateTime Data_gastos { get; set; }
        public decimal Valor { get; set; }
        public string Descricao { get; set; }
        public string tipo { get; set; }
    }
}
