using MySql.Data.MySqlClient;
using ProjetoADM.Codigos.BASE;
using ProjetoADM.Codigos.View;
using System.Collections.Generic;

namespace ProjetoADM.Codigos.Folha_pagamento
{
    class Folha_pagamentoDatabase
    {
        public int Salvar(Folha_pagamentoDTO Dto)
        {
            string script = @"INSERT INTO folha_pagamento(hora_extra,atrasos,faltas,INSS,i_renda,FGTS,V_transporte,sala_liqui,sala_bruto,vale_refeicao,vl_convenio,dt_pagamento,id_funcionario) VALUES(@hora_extra,@atrasos,@faltas,@INSS,@i_renda,@FGTS,@V_transporte,@sala_liqui,@sala_bruto,@vale_refeicao,@vl_convenio,@dt_pagamento,@id_funcionario) ";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("hora_extra", Dto.Hora_Extra));
            parms.Add(new MySqlParameter("atrasos", Dto.Atrasos));
            parms.Add(new MySqlParameter("faltas", Dto.Faltas));
            parms.Add(new MySqlParameter("INSS", Dto.INSS));
            parms.Add(new MySqlParameter("i_renda", Dto.I_Renda));
            parms.Add(new MySqlParameter("FGTS", Dto.FGTS));
            parms.Add(new MySqlParameter("V_transporte", Dto.V_trans));
            parms.Add(new MySqlParameter("sala_liqui", Dto.Salario_liquido));
            parms.Add(new MySqlParameter("sala_bruto", Dto.Salario_bruto));
            parms.Add(new MySqlParameter("vale_refeicao", Dto.Vale_refeicao));
            parms.Add(new MySqlParameter("vl_convenio", Dto.Convenio_medico));
            parms.Add(new MySqlParameter("id_funcionario", Dto.id_funcionario));
            parms.Add(new MySqlParameter("dt_pagamento", Dto.data));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);



        }
        public List<vm_folha_pagamento> Consultar(string funcionario)
        {
            string script = @"SELECT * FROM vm_folha_pagamento";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<vm_folha_pagamento> lista = new List<vm_folha_pagamento>();
            while (reader.Read())
            {

                vm_folha_pagamento dto = new vm_folha_pagamento();
          
                dto.Sala_bruto = reader.GetDecimal("sala_bruto");
                dto.salaliquido = reader.GetDecimal("sala_liqui");
                dto.Nome = reader.GetString("nm_funcio");

                lista.Add(dto);
            }
            reader.Close();

            return lista;

        }

        
        }
    }

