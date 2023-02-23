using MySql.Data.MySqlClient;
using ProjetoADM.Codigos.BASE;
using System.Collections.Generic;

namespace ProjetoADM.Codigos.Gastos
{
    class GastosDatabase
    {
        public int Salvar(GastosDTO dto)
        {
            string script = @"INSERT INTO tb_gastos(dt_gastos,ds_valor,ds_descricao,ds_tipo) 
                                            VALUES (@dt_gastos,@ds_valor,@ds_descricao,@ds_tipo)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("dt_gastos", dto.Data_gastos));
            parms.Add(new MySqlParameter("ds_valor", dto.Valor));
            parms.Add(new MySqlParameter("ds_descricao", dto.Descricao));
            parms.Add(new MySqlParameter("ds_tipo", dto.tipo));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }
        public List<GastosDTO> Consultar(string gastos)
        {
            string script = @"SELECT * FROM tb_gastos WHERE dt_gastos like @dt_gastos";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("dt_gastos", gastos + "%"));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<GastosDTO> lista = new List<GastosDTO>();
            while (reader.Read())
            {
                GastosDTO dto = new GastosDTO();
                dto.ID = reader.GetInt32("id_gastos");
                dto.Data_gastos = reader.GetDateTime("dt_gastos");
                dto.Valor = reader.GetInt32("ds_valor");
                dto.Descricao = reader.GetString("ds_descricao");
                dto.tipo = reader.GetString("ds_tipo");


                lista.Add(dto);
            }
            reader.Close();


            return lista;
        }

        public void Alterar(GastosDTO dto)
        {
            string script =
                            @"UPDATE tb_gastos
                                                     SET 
                                                        dt_gastos= @nm_produto,
                                                        ds_valor = @dt_venci,
                                                        ds_descricao =@ds_descricao,
                                                        ds_tipo = @ds_tipo
                                                        WHERE id_gastos = @id_gastos";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_gastos", dto.ID));
            parms.Add(new MySqlParameter("dt_gastos", dto.Data_gastos));
            parms.Add(new MySqlParameter("ds_valor", dto.Valor));
            parms.Add(new MySqlParameter("ds_descricao", dto.Descricao));
            parms.Add(new MySqlParameter("ds_tipo", dto.tipo));

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
        public List<GastosDTO> Listar()
        {
            string script = @"SELECT * FROM vm_consultar_produto";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<GastosDTO> lista = new List<GastosDTO>();
            while (reader.Read())
            {
                GastosDTO dto = new GastosDTO();
                dto.ID = reader.GetInt32("id_gastos");
                dto.Data_gastos = reader.GetDateTime("dt_gastos");
                dto.Valor = reader.GetInt32("ds_valor");
                dto.Descricao = reader.GetString("ds_descricao");
                dto.tipo = reader.GetString("ds_tipo");


                lista.Add(dto);
            }
            reader.Close();

            return lista;
        }

    }
}
