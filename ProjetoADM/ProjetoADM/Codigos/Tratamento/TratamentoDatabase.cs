using MySql.Data.MySqlClient;
using ProjetoADM.Codigos.BASE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoADM.Codigos.Tratamento
{
    class TratamentoDatabase
    {
       
        public int Salvar(TratamentoDTO dto)
        {
            string script = @"INSERT INTO tratamentos(nm_tratamento,ds_valor,duracao,tratamentoscol) 
                               VALUES (@nm_tratamento,@ds_valor,@duracao,@tratamentoscol)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_tratamento", dto.Nome));
            parms.Add(new MySqlParameter("ds_valor", dto.Valor));
            parms.Add(new MySqlParameter("duracao", dto.Duracao));
            parms.Add(new MySqlParameter("tratamentoscol", dto.descricao));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }
        public List<TratamentoDTO> Consultar(string Tratamento)
        {
            string script = @"SELECT * FROM tratamentos WHERE nm_tratamento like @nm_tratamento";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_tratamento", Tratamento + "%"));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<TratamentoDTO> lista = new List<TratamentoDTO>();
            while (reader.Read())
            {
                TratamentoDTO dto = new TratamentoDTO();
                dto.ID = reader.GetInt32("id_tratamentos");
                dto.Nome = reader.GetString("nm_tratamento");
                dto.Valor= reader.GetDecimal("ds_valor");
                dto.Duracao = reader.GetInt32("duracao");
                dto.descricao= reader.GetString("tratamentoscol");




                lista.Add(dto);
            }
            reader.Close();


            return lista; 
        }

        public void Alterar(TratamentoDTO dto)
        {
            string script =
                            @"UPDATE tratamentos 
                                                     SET 
                                                       nm_tratamento = @nm_tratamento,
                                                       ds_valor =@ds_valor,
                                                       duracao = @duracao  
                                                       WHERE id_tratamentos = @id_tratamentos";


                                                        
                    
            List<MySqlParameter> parms = new List<MySqlParameter>();
     
            parms.Add(new MySqlParameter("id_tratamentos", dto.ID));
            parms.Add(new MySqlParameter("nm_tratamento", dto.Nome));
            parms.Add(new MySqlParameter("ds_valor", dto.Valor));
            parms.Add(new MySqlParameter("duracao", dto.Duracao));
         




            Database db = new Database();
            db.ExecuteInsertScript(script, parms);


        }
        public void Remover(int ID)
        {
            string script = @"DELETE FROM tratamentos WHERE id_tratamento = @id_tratamento";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_tratamento", ID));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }
        public List<TratamentoDTO> Listar()
        {
            string script = @"SELECT * FROM tratamentos";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<TratamentoDTO> lista = new List<TratamentoDTO>();
            while (reader.Read())
            {
                TratamentoDTO dto = new TratamentoDTO();
                dto.ID = reader.GetInt32("id_tratamentos");
                dto.Nome = reader.GetString("nm_tratamento");
                dto.Valor = reader.GetDecimal("ds_valor");
                dto.Duracao = reader.GetInt32("duracao");
                dto.descricao = reader.GetString("tratamentoscol");



                lista.Add(dto);
            }
            reader.Close();

            return lista;
        }
    }
}

    

