using MySql.Data.MySqlClient;
using ProjetoADM.Codigos.BASE;
using ProjetoADM.Codigos.View;
using System;
using System.Collections.Generic;


namespace ProjetoADM.Codigos.Produto
{
    class ProdutoDatabase
    {
        public int Salvar(ProdutoDTO dto)
        {
            string script = @"INSERT INTO tb_produto(nm_produto,dt_venci,id_fornecedor) 
                                            VALUES (@nm_produto,@dt_venci,@id_fornecedor)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_produto", dto.Nome));
            parms.Add(new MySqlParameter("dt_venci", dto.Data_vencimento));
            parms.Add(new MySqlParameter("id_fornecedor", dto.Id_fornecedor));
            
            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }
        public List<vm_consultar_produto> Consultar(string produto)
        {
            string script = @"SELECT * FROM vm_consultar_produto WHERE nm_produto like @nm_produto";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_produto", produto + "%"));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<vm_consultar_produto> lista = new List<vm_consultar_produto>();
            while (reader.Read())
            {
                vm_consultar_produto dto = new vm_consultar_produto();
                dto.ID = reader.GetInt32("id_produto");
                dto.Nome = reader.GetString("nm_produto");
                dto.Data_vencimento = reader.GetDateTime("dt_venci");
                dto.nome_forn = reader.GetString("nome");
              


                lista.Add(dto);
            }
            reader.Close();


            return lista;
        }

        public void Alterar(ProdutoDTO dto)
        {
            string script =
                            @"UPDATE tb_produto
                                                     SET 
                                                        nm_produto= @nm_produto,
                                                        dt_venci = @dt_venci,
                                                        Id_fornecedor =@Id_fornecedor
                                                        WHERE id_produto = @id_produto";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            parms.Add(new MySqlParameter("nm_produto", dto.Nome));
            parms.Add(new MySqlParameter("dt_venci", dto.Data_vencimento));
            parms.Add(new MySqlParameter("Id_fornecedor", dto.Id_fornecedor));


            Database db = new Database();
            db.ExecuteInsertScript(script, parms);


        }
        public void Remover(int ID)
        {
            string script = @"DELETE FROM tb_produto WHERE id_produto = @id_produto";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_produto", ID));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }
        public List<vm_consultar_produto> Listar()
        {
            string script = @"SELECT * FROM vm_consultar_produto";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<vm_consultar_produto> lista = new List<vm_consultar_produto>();
            while (reader.Read())
            {
                vm_consultar_produto dto = new vm_consultar_produto();
                dto.ID = reader.GetInt32("id_produto");
                dto.Nome = reader.GetString("nm_produto");
                dto.Data_vencimento = reader.GetDateTime("dt_venci");
                dto.nome_forn = reader.GetString("nome");

                lista.Add(dto);
            }
            reader.Close();

            return lista;
        }
    }
}
