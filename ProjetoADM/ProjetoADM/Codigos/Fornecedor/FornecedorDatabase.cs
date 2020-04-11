using MySql.Data.MySqlClient;
using ProjetoADM.Codigos.BASE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoADM.Codigos.Fornecedor
{
    class FornecedorDatabase
    {
        public int Salvar(FornecedorDTO dto)
        {
            string script = @"INSERT INTO Fornecedor(nome,CNPJ,endereco,numero,telefone)
                                          values(@nome,@CNPJ,@endereco,@numero,@telefone)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nome", dto.Nome));
            parms.Add(new MySqlParameter("CNPJ", dto.CNPJ));
            parms.Add(new MySqlParameter("endereco", dto.Endereco));
            parms.Add(new MySqlParameter("numero", dto.numero));
            parms.Add(new MySqlParameter("telefone", dto.Telefone));


            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);


        }

        public List<FornecedorDTO> Consultar(string forn)
        {
            string script = @"SELECT * FROM Fornecedor WHERE Id_fornecedor like @Id_fornecedor";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("Id_fornecedor", forn + "%"));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<FornecedorDTO> lista = new List<FornecedorDTO>();
            while (reader.Read())
            {
                FornecedorDTO dto = new FornecedorDTO();
                dto.ID = reader.GetInt32("Id_fornecedor");
                dto.Nome = reader.GetString("nome");
                dto.CNPJ = reader.GetString("CNPJ");
                dto.Endereco = reader.GetString("endereco");
                dto.numero = reader.GetInt32("numero");
                dto.Telefone = reader.GetString("telefone");




                lista.Add(dto);
            }
            reader.Close();


            return lista;
        }

        public void Alterar(FornecedorDTO dto)
        {
            string script =
                            @"UPDATE Fornecedor 
                                                     SET 
                                                        nome= @nome,
                                                        CNPJ = @CNPJ,
                                                        endereco =@endereco, 
                                                        numero =@numero, 
                                                        telefone =@telefone
                                                        WHERE Id_fornecedor = @Id_fornecedor";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            parms.Add(new MySqlParameter("Id_fornecedor", dto.ID));
            parms.Add(new MySqlParameter("nome", dto.Nome));
            parms.Add(new MySqlParameter("CNPJ", dto.CNPJ));
            parms.Add(new MySqlParameter("endereco", dto.Endereco));
            parms.Add(new MySqlParameter("numero", dto.numero));
            parms.Add(new MySqlParameter("telefone", dto.Telefone));



            Database db = new Database();
            db.ExecuteInsertScript(script, parms);


        }
        public void Remover(int ID)
        {
            string script = @"DELETE FROM Fornecedor WHERE Id_fornecedor = @Id_fornecedor";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("Id_fornecedor", ID));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }
        public List<FornecedorDTO> Listar()
        {
            string script = @"SELECT * FROM Fornecedor";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<FornecedorDTO> lista = new List<FornecedorDTO>();
            while (reader.Read())
            {
                FornecedorDTO dto = new FornecedorDTO();
               
                dto.ID = reader.GetInt32("Id_fornecedor");
                dto.Nome = reader.GetString("nome");
                dto.CNPJ = reader.GetString("CNPJ");
                dto.Endereco = reader.GetString("endereco");
                dto.numero = reader.GetInt32("numero");
                dto.Telefone = reader.GetString("telefone");


                lista.Add(dto);
            }
            reader.Close();

            return lista;
        }
    }
}
