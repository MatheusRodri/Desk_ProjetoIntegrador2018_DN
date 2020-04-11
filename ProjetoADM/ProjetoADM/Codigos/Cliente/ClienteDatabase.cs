using MySql.Data.MySqlClient;
using ProjetoADM.Codigos.BASE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoADM.Codigos.Cliente
{
    class ClienteDatabase
    {
        public int Salvar(ClienteDTO dto)
        {
            string script = @"INSERT INTO tb_cliente(nm_cliente,ds_email,ds_ender,ds_numerocasa,ds_cep,bairro,cidade,estado,ds_tele,ds_cpf,ds_rg,ds_celular,sexo) 
                                            VALUES (@nm_cliente,@ds_email,@ds_ender,@ds_numerocasa,@ds_cep,@bairro,@cidade,@estado,@ds_tele,@ds_cpf,@ds_rg,@ds_celular,@sexo)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_cliente", dto.Nome));
            parms.Add(new MySqlParameter("ds_email", dto.email));
            parms.Add(new MySqlParameter("ds_ender", dto.Endereco));
            parms.Add(new MySqlParameter("ds_numerocasa", dto.Numero_casa));
            parms.Add(new MySqlParameter("ds_cep", dto.Cep));
            parms.Add(new MySqlParameter("bairro", dto.Bairro));
            parms.Add(new MySqlParameter("cidade", dto.Cidade));
            parms.Add(new MySqlParameter("estado", dto.Estado));
            parms.Add(new MySqlParameter("ds_tele", dto.Telefone));
            parms.Add(new MySqlParameter("ds_cpf", dto.CPF));
            parms.Add(new MySqlParameter("ds_rg", dto.RG));
            parms.Add(new MySqlParameter("ds_celular", dto.Celular));
            parms.Add(new MySqlParameter("sexo", dto.Sexo));


            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }
        public List<ClienteDTO> Consultar(string nome)
        {
            string script = @"SELECT * FROM tb_cliente WHERE nm_cliente like @nm_cliente";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_cliente", nome + "%"));
            

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<ClienteDTO> lista = new List<ClienteDTO>();
            while (reader.Read())
            {
                ClienteDTO dto = new ClienteDTO();
                dto.ID = reader.GetInt32("id_cliente");
                dto.Nome = reader.GetString("nm_cliente");
                dto.email = reader.GetString("ds_email");
                dto.Endereco = reader.GetString("ds_ender");
                dto.Numero_casa = reader.GetInt32("ds_numerocasa");
                dto.Cep = reader.GetString("ds_cep");
                dto.Bairro= reader.GetString("bairro");
                dto.Cidade = reader.GetString("cidade");
                dto.Estado= reader.GetString("estado");           
                dto.CPF = reader.GetString("ds_cpf");
                dto.RG= reader.GetString("ds_rg");
                dto.Celular= reader.GetString("ds_celular");
                dto.Sexo= reader.GetString("sexo");


                lista.Add(dto);
            }
            reader.Close();


            return lista;
        }

        public void Alterar(ClienteDTO dto)
        {
            string script =
                            @"UPDATE tb_cliente 
                                                     SET 
                                                        nm_cliente= @nm_cliente,
                                                        ds_email=@ds_email,
                                                        ds_ender= @ds_ender,
                                                        ds_numerocasa =@ds_numerocasa,
                                                        ds_cep = @ds_cep,
                                                        bairro = @bairro,
                                                        cidade = @cidade,
                                                        estado = @estado,     
                                                        ds_cpf = @ds_cpf,
                                                        ds_rg = @ds_rg,
                                                        ds_celular = @ds_celular,
                                                        sexo = @sexo
                                                        WHERE id_cliente = @id_cliente";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            parms.Add(new MySqlParameter("id_cliente", dto.ID));
            parms.Add(new MySqlParameter("nm_cliente", dto.Nome));
            parms.Add(new MySqlParameter("ds_ender", dto.Endereco));
            parms.Add(new MySqlParameter("ds_email", dto.email));
            parms.Add(new MySqlParameter("ds_numerocasa", dto.Numero_casa));
            parms.Add(new MySqlParameter("ds_cep", dto.Cep));
            parms.Add(new MySqlParameter("bairro", dto.Bairro));
            parms.Add(new MySqlParameter("cidade", dto.Cidade));
            parms.Add(new MySqlParameter("estado", dto.Estado));
            parms.Add(new MySqlParameter("ds_cpf", dto.CPF));
            parms.Add(new MySqlParameter("ds_rg", dto.RG));
            parms.Add(new MySqlParameter("ds_celular", dto.Celular));
            parms.Add(new MySqlParameter("sexo", dto.Sexo));


            Database db = new Database();
            db.ExecuteInsertScript(script, parms);


        }
        public void Remover(int ID)
        {
            string script = @"DELETE FROM tb_cliente WHERE id_cliente = @id_cliente";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_cliente", ID));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }
        public List<ClienteDTO> Listar()
        {
            string script = @"SELECT * FROM tb_cliente";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<ClienteDTO> lista = new List<ClienteDTO>();
            while (reader.Read())
            {
                ClienteDTO dto = new ClienteDTO();
                dto.ID = reader.GetInt32("id_cliente");
                dto.Nome = reader.GetString("nm_cliente");
                dto.email = reader.GetString("ds_email");
                dto.Endereco = reader.GetString("ds_ender");
                dto.Numero_casa = reader.GetInt32("ds_numerocasa");
                dto.Cep = reader.GetString("ds_cep");
                dto.Bairro = reader.GetString("bairro");
                dto.Cidade = reader.GetString("cidade");
                dto.Estado = reader.GetString("estado");
                dto.Telefone = reader.GetString("ds_tele");
                dto.CPF = reader.GetString("ds_cpf");
                dto.RG = reader.GetString("ds_rg");
                dto.Celular = reader.GetString("ds_celular");
                dto.Sexo = reader.GetString("sexo");

                lista.Add(dto);
            }
            reader.Close();

            return lista;
        }
    }
}
