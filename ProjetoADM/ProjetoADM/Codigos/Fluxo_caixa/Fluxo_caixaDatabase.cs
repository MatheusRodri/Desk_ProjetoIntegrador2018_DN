using MySql.Data.MySqlClient;
using ProjetoADM.Codigos.BASE;
using System;
using System.Collections.Generic;

namespace ProjetoADM.Codigos.Fluxo_caixa
{
    class Fluxo_caixaDatabase
    {
        public List<Fluxo_caixaDTO> Consultar(DateTime inicio, DateTime fim)
        {
            string script = @"SELECT * FROM vw_consultar_fluxodecaixa 
                 Where dt_referencia >= @inicio and dt_referencia <= @fim";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("inicio", inicio));
            parms.Add(new MySqlParameter("fim", fim));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<Fluxo_caixaDTO> lista = new List<Fluxo_caixaDTO>();
            while (reader.Read())
            {
                Fluxo_caixaDTO dto = new Fluxo_caixaDTO();
                dto.DataReferencia = reader.GetDateTime("dt_referencia");
                dto.ValorGanhos = reader.GetDecimal("vl_total_ganhos");
                dto.ValorDespesas = reader.GetDecimal("vl_total_despesas");
                dto.ValorLucros = reader.GetDecimal("vl_saldo");

                lista.Add(dto);

            }
            reader.Close();

            return lista;
        }
    }
}
