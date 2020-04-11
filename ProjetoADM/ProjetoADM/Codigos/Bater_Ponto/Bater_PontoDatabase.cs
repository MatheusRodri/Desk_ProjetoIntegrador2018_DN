using MySql.Data.MySqlClient;
using ProjetoADM.Codigos.BASE;
using ProjetoADM.Codigos.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoADM.Codigos.Bater_ponto
{
    class Bater_PontoDatabase
    {
        public int Salvar(Bater_PontoDTO dto)
        {
            string script = @"INSERT INTO tb_bate_ponto(Hora_entrada,Hora_almoco,Hora_volta,Hora_saida,data_entrada,Fk_func)
                                               VALUES(@Hora_entrada,@Hora_almoco,@Hora_volta,@Hora_saida,@data_entrada,@Fk_func)";

                 List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("Hora_entrada", dto.Hora_entrada));
            parms.Add(new MySqlParameter("Hora_almoco", dto.Hora_almoco));
            parms.Add(new MySqlParameter("Hora_volta", dto.Hora_almoco_volta));
            parms.Add(new MySqlParameter("Hora_saida", dto.Hora_Saida));
            parms.Add(new MySqlParameter("data_entrada", dto.Data_entrada));
            parms.Add(new MySqlParameter("Fk_func", dto.id_funcionario));


            Database db = new Database();
           return  db.ExecuteInsertScriptWithPk(script, parms);

        }
        public List<vm_consultar_ponto> Consultar(string funcionario)
        {
            string script = @"SELECT * FROM vm_consultar_ponto";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<vm_consultar_ponto> lista = new List<vm_consultar_ponto>();
            while (reader.Read())
            {
                vm_consultar_ponto dto = new vm_consultar_ponto();
             
                dto.Data = reader.GetDateTime("data_entrada");
                dto.hora_entrada = reader.GetDateTime("Hora_almoco");
                dto.hora_saida = reader.GetDateTime("Hora_volta");
                dto.almoco = reader.GetDateTime("Hora_saida");
                dto.almocovolta = reader.GetDateTime("data_entrada");
                dto.func = reader.GetString("nm_funcio");

                lista.Add(dto);
            }
            reader.Close();

            return lista;
        }

    }
    

}
