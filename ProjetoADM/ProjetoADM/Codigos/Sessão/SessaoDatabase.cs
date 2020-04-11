using MySql.Data.MySqlClient;
using ProjetoADM.Codigos.BASE;
using ProjetoADM.Codigos.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoADM.Codigos.Sessão
{
    class SessaoDatabase
    {
        public int Salvar(SessaoDTO dto)
        {
            string script = @"INSERT INTO marca_horario(forma_de_pgto,ds_valor,data_marcada,fk_nomecli,fk_funcionario,fk_tratamento)
                                          values(@forma_de_pgto,@ds_valor,@data_marcada,@fk_nomecli,@fk_funcionario,@fk_tratamento)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("forma_de_pgto", dto.Forma_pgto));
            parms.Add(new MySqlParameter("ds_valor", dto.Valor));
            parms.Add(new MySqlParameter("data_marcada", dto.Data));
            parms.Add(new MySqlParameter("fk_nomecli", dto.Id_cliente));
            parms.Add(new MySqlParameter("fk_funcionario", dto.Id_func));
            parms.Add(new MySqlParameter("fk_tratamento", dto.ID_tratamento));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);


        }

        public List<View_sessao> Consultar(string secao)
        {
            string script = @"SELECT * FROM vm_sesao_cliente_func WHERE nm_cliente like @nm_cliente";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_cliente", secao + "%"));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<View_sessao> lista = new List<View_sessao>();
            while (reader.Read())
            {
                View_sessao dto = new View_sessao();
                dto.ID = reader.GetInt32("idmarca_horario");
                dto.cliente = reader.GetString("nm_cliente");
                dto.tratamento = reader.GetString("nm_tratamento");
                dto.data = reader.GetDateTime("data_marcada");
                dto.funcionario = reader.GetString("nm_funcio");
                dto.form_pgto = reader.GetString("forma_de_pgto");
                dto.valor = reader.GetDecimal("ds_valor");




                lista.Add(dto);
            }
            reader.Close();


            return lista;
        }

        public void Alterar(SessaoDTO dto)
        {
            string script =
                            @"UPDATE marca_horario 
                                                     SET 
                                                        forma_de_pgto= @forma_de_pgto,
                                                        ds_valor = @ds_valor,
                                                        data_marcada =@data_marcada,
                                                        fk_nomecli = @fk_nomecli,
                                                        fk_funcionario = @fk_funcionario,
                                                        fk_tratamento = @fk_tratamento                          
                                                        WHERE idmarca_horario = @idmarca_horario";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            parms.Add(new MySqlParameter("idmarca_horario", dto.ID));
            parms.Add(new MySqlParameter("forma_de_pgto", dto.Forma_pgto));
            parms.Add(new MySqlParameter("data_marcada", dto.Data));
            parms.Add(new MySqlParameter("ds_valor", dto.Valor));
            parms.Add(new MySqlParameter("fk_nomecli", dto.Id_cliente));
            parms.Add(new MySqlParameter("fk_funcionario", dto.Id_func));
            parms.Add(new MySqlParameter("fk_tratamento", dto.ID_tratamento));
            

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);


        }
        public void Remover(int ID)
        {
            string script = @"DELETE FROM marca_horario WHERE idmarca_horario = @idmarca_horario";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("idmarca_horario", ID));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }
        public List<View_sessao> Listar()
        {
            string script = @"SELECT * FROM vm_sesao_cliente_func";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<View_sessao> lista = new List<View_sessao>();
            while (reader.Read())
            {
                View_sessao dto = new View_sessao();
                dto.ID = reader.GetInt32("idmarca_horario");
                dto.cliente = reader.GetString("nm_cliente");
                dto.tratamento = reader.GetString("nm_tratamento");
                dto.data = reader.GetDateTime("data_marcada");
                dto.funcionario = reader.GetString("nm_funcio");
                dto.form_pgto = reader.GetString("forma_de_pgto");
                dto.valor = reader.GetDecimal("ds_valor");




                lista.Add(dto);
            }
            reader.Close();

            return lista;
        }
    }
}
