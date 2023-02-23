using MySql.Data.MySqlClient;
using ProjetoADM.Codigos.BASE;
using ProjetoADM.Codigos.View;
using System.Collections.Generic;

namespace ProjetoADM.Codigos.Pedido
{
    class PedidoDatabase
    {
        public int Salvar(PedidoDTO dto)
        {
            string script = @"INSERT INTO tb_pedido(id_fornecedor,id_produto,ds_valor)
                                          values(@id_fornecedor,@id_produto,@ds_valor)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_fornecedor", dto.id_fornecor));
            parms.Add(new MySqlParameter("id_produto", dto.id_produto));
            parms.Add(new MySqlParameter("ds_valor", dto.valor));


            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);


        }

        public List<view_pedido> Consultar(string secao)
        {
            string script = @"SELECT * FROM vm_consultar_pedido WHERE id_pedido like @id_pedido";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_pedido", secao + "%"));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<view_pedido> lista = new List<view_pedido>();
            while (reader.Read())
            {
                view_pedido dto = new view_pedido();
                dto.ID = reader.GetInt32("id_pedido");
                dto.Fornecedor = reader.GetString("nome");
                dto.Produto = reader.GetString("nm_produto");
                dto.Valor = reader.GetDecimal("ds_valor");
              



                lista.Add(dto);
            }
            reader.Close();


            return lista;
        }

        public void Alterar(PedidoDTO dto)
        {
            string script =
                            @"UPDATE tb_pedido 
                                                     SET 
                                                        id_fornecedor= @id_fornecedor,
                                                        id_produto = @id_produto,
                                                        ds_valor =@ds_valor                                                                             
                                                        WHERE id_pedido = @id_pedido";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            parms.Add(new MySqlParameter("id_pedido", dto.ID));
            parms.Add(new MySqlParameter("ds_valor", dto.valor));
            parms.Add(new MySqlParameter("id_produto", dto.id_produto));
            parms.Add(new MySqlParameter("id_fornecedor", dto.id_fornecor));
           


            Database db = new Database();
            db.ExecuteInsertScript(script, parms);


        }
        public void Remover(int ID)
        {
            string script = @"DELETE FROM tb_pedido WHERE id_pedido = @id_pedido";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_pedido", ID));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }
        public List<view_pedido> Listar()
        {
            string script = @"SELECT * FROM vm_consultar_pedido";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<view_pedido> lista = new List<view_pedido>();
            while (reader.Read())
            {
                view_pedido dto = new view_pedido();
                dto.ID = reader.GetInt32("id_pedido");
                dto.Fornecedor = reader.GetString("nome");
                dto.Produto = reader.GetString("id_produto");
                dto.Valor = reader.GetDecimal("ds_valor");



                lista.Add(dto);
            }
            reader.Close();

            return lista;
        }
    }
}
