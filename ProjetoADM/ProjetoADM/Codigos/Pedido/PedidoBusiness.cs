using ProjetoADM.Codigos.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoADM.Codigos.Pedido
{
    class PedidoBusiness
    {
        public int Salvar(PedidoDTO dto)
        {
            PedidoDatabase db = new PedidoDatabase();
         
            return db.Salvar(dto);
        }

        public List<view_pedido> Consultar(string funcionario)
        {
            PedidoDatabase db = new PedidoDatabase();
            return db.Consultar(funcionario);
        }

        public void Alterar(PedidoDTO dto)
        {
            PedidoDatabase db = new PedidoDatabase();
            db.Alterar(dto);
        }

        public void Remover(int ID)
        {
            PedidoDatabase db = new PedidoDatabase();
            db.Remover(ID);
        }
        public List<view_pedido> Listar()
        {
            PedidoDatabase db = new PedidoDatabase();
            return db.Listar();

        }
    }
}
