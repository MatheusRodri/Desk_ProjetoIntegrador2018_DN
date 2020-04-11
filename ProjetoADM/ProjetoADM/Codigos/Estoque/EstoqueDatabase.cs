using MySql.Data.MySqlClient;
using ProjetoADM.Codigos.BASE;
using ProjetoADM.Codigos.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoADM.Codigos.Estoque
{
    class EstoqueDatabase
    {
        public int Salvar(EstoqueDTO dto)
        {
            string script = @"INSERT INTO tb_estoque(ds_quant,id_produto)
                                          values(@ds_quant,@id_produto)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("ds_quant", dto.Quantidade));         
            parms.Add(new MySqlParameter("id_produto", dto.id_produto));


            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);


        }

        public List<vm_consultar_estoque> Consultar(string prod)
        {
            string script = @"SELECT * FROM  vm_consultar_estoque WHERE nm_produto like @nm_produto";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_produto", prod + "%"));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<vm_consultar_estoque> lista = new List<vm_consultar_estoque>();
            while (reader.Read())
            {
                vm_consultar_estoque dto = new vm_consultar_estoque();
                dto.ID = reader.GetInt32("id_estoque");
                dto.nm_produto = reader.GetString("nm_produto");
                dto.Quantidade = reader.GetInt32("ds_quant");
              

                lista.Add(dto);
            }
            reader.Close();


            return lista;
        }

        public void Alterar(EstoqueDTO dto)
        {
            string script =
                            @"UPDATE tb_estoque 
                                                     SET 
                                                        ds_quant= @id_fornecedor,
                                                        id_produto = @id_produto                                                                            
                                                        WHERE id_estoque = @id_estoque";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            parms.Add(new MySqlParameter("id_estoque", dto.ID));
            parms.Add(new MySqlParameter("ds_quant", dto.Quantidade));
            parms.Add(new MySqlParameter("id_produto", dto.id_produto));


            Database db = new Database();
            db.ExecuteInsertScript(script, parms);


        }
        public void Remover(int ID)
        {
            string script = @"DELETE FROM tb_estoque WHERE id_estoque = @id_estoque";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_estoque", ID));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }
        public List<vm_consultar_estoque> Listar()
        {
            string script = @"SELECT * FROM vm_consultar_estoque";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<vm_consultar_estoque> lista = new List<vm_consultar_estoque>();
            while (reader.Read())
            {
                vm_consultar_estoque dto = new vm_consultar_estoque();
                dto.ID = reader.GetInt32("id_estoque");
                dto.nm_produto = reader.GetString("nome");
                dto.Quantidade = reader.GetInt32("id_produto");



                lista.Add(dto);
            }
            reader.Close();

            return lista;
        }
    }
}
