using MySql.Data.MySqlClient;
using ProjetoADM.Codigos.BASE;
using System.Collections.Generic;


namespace ProjetoADM.Codigos.Funcionarios
{
    class FuncionariosDatabase
    {
        public FuncionariosDTO Logar(string login, string senha)
        {
            string script = @"SELECT * FROM tb_funcionario WHERE nm_login = @nm_login AND ds_senha = @ds_senha";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_login", login));
            parms.Add(new MySqlParameter("ds_senha", senha));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            FuncionariosDTO dto = null;
            if (reader.Read())
            {
                dto = new FuncionariosDTO();
                dto.ID = reader.GetInt32("id_funcionario");
                dto.Nome = reader.GetString("nm_funcio");
                dto.email = reader.GetString("ds_email");
                dto.Endereco = reader.GetString("ds_ender");
                dto.Numero_casa = reader.GetInt32("ds_numerocasa");
                dto.Cep = reader.GetString("ds_cep");
                dto.Bairro = reader.GetString("bairro");
                dto.Cidade = reader.GetString("cidade");
                dto.Estado = reader.GetString("estado");
                dto.Telefone = reader.GetInt32("ds_tele");
                dto.CPF = reader.GetString("ds_cpf");
                dto.RG = reader.GetString("ds_rg");
                dto.Fucao = reader.GetString("funcao");
                dto.salario = reader.GetDecimal("sala_liqui");     
                dto.vl_refeicao = reader.GetDecimal("vale_refeicao");
                dto.vl_transporte = reader.GetDecimal("V_transporte");
                dto.Login = reader.GetString("nm_login");
                dto.Senha = reader.GetString("ds_senha");
                dto.ADM = reader.GetBoolean("bt_permissao_adm");
                dto.RH = reader.GetBoolean("bt_permissao_rh");
                dto.Func = reader.GetBoolean("bt_permissao_func");
            }

            reader.Close();
            return dto;
        }
        public int Salvar(FuncionariosDTO dto)
        {
            string script = @"INSERT INTO tb_funcionario(nm_funcio,ds_email,ds_ender,ds_numerocasa,ds_cep,bairro,cidade,estado,ds_tele,ds_cpf,ds_rg,funcao,sala_liqui,V_transporte,vale_refeicao,nm_login,ds_senha,bt_permissao_adm,bt_permissao_rh,bt_permissao_func) 
                                                 VALUES (@nm_funcio,@ds_email,@ds_ender,@ds_numerocasa,@ds_cep,@bairro,@cidade,@estado,@ds_tele,@ds_cpf,@ds_rg,@funcao,@sala_liqui,@V_transporte,@vale_refeicao,@nm_login,@ds_senha,@bt_permissao_adm,@bt_permissao_rh,@bt_permissao_func)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_funcio", dto.Nome));
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
            parms.Add(new MySqlParameter("funcao", dto.Fucao));
            parms.Add(new MySqlParameter("V_transporte", dto.vl_transporte));
            parms.Add(new MySqlParameter("sala_liqui", dto.salario));
            parms.Add(new MySqlParameter("vale_refeicao", dto.vl_refeicao));
            parms.Add(new MySqlParameter("nm_login", dto.Login));
            parms.Add(new MySqlParameter("ds_senha", dto.Senha));
            parms.Add(new MySqlParameter("bt_permissao_adm", dto.ADM));
            parms.Add(new MySqlParameter("bt_permissao_rh", dto.RH));
            parms.Add(new MySqlParameter("bt_permissao_func", dto.Func));


            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }
        public List<FuncionariosDTO> Consultar(string funcionario)
        {
            string script = @"SELECT * FROM tb_funcionario WHERE nm_funcio like @nm_funcio";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_funcio", funcionario + "%"));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<FuncionariosDTO> lista = new List<FuncionariosDTO>();
            while (reader.Read())
            {
                FuncionariosDTO dto = new FuncionariosDTO();
                dto.ID = reader.GetInt32("id_funcionario");
                dto.Nome = reader.GetString("nm_funcio");
                dto.email = reader.GetString("ds_email");
                dto.Endereco = reader.GetString("ds_ender");
                dto.Numero_casa = reader.GetInt32("ds_numerocasa");
                dto.Cep = reader.GetString("ds_cep");
                dto.Bairro = reader.GetString("bairro");
                dto.Cidade = reader.GetString("cidade");
                dto.Estado = reader.GetString("estado");
                dto.Telefone = reader.GetInt32("ds_tele");
                dto.CPF = reader.GetString("ds_cpf");
                dto.RG = reader.GetString("ds_rg");
                dto.Fucao = reader.GetString("funcao");
                dto.salario = reader.GetDecimal("sala_liqui");
               
                dto.vl_refeicao = reader.GetDecimal("vale_refeicao");
                dto.vl_transporte = reader.GetDecimal("V_transporte");
                dto.Login = reader.GetString("nm_login");
                dto.Senha = reader.GetString("ds_senha");
                dto.ADM = reader.GetBoolean("bt_permissao_adm");
                dto.RH = reader.GetBoolean("bt_permissao_rh");
                dto.Func = reader.GetBoolean("bt_permissao_func");


                lista.Add(dto);
            }
            reader.Close();


            return lista; 
        }

        public void Alterar(FuncionariosDTO dto)
        {
            string script =
                            @"UPDATE tb_funcionario 
                                                     SET 
                                                        nm_funcio= @nm_funcio,
                                                        ds_ender = @ds_ender,
                                                        ds_numerocasa =@ds_numerocasa,
                                                        ds_cep = @ds_cep,
                                                        bairro = @bairro,
                                                        cidade = @cidade,
                                                        estado = @estado,
                                                        ds_tele= @ds_tele,
                                                        ds_cpf = @ds_cpf,
                                                        ds_rg =  @ds_rg,
                                                        funcao =  @funcao,
                                                        sala_liqui =  @sala_liqui,
                                                        V_transporte=  @V_transporte,
                                                        vale_refeicao=  @vale_refeicao,
                                                        nm_login =  @nm_login,
                                                        ds_senha = @ds_senha,
                                                        bt_permissao_adm =  @bt_permissao_adm,
                                                        bt_permissao_rh = @bt_permissao_rh,
                                                        bt_permissao_func =  @bt_permissao_func
                                                        WHERE id_funcionario = @id_funcionario";
                    
            List<MySqlParameter> parms = new List<MySqlParameter>();
     
            parms.Add(new MySqlParameter("id_funcionario", dto.ID));
            parms.Add(new MySqlParameter("nm_funcio", dto.Nome));
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
            parms.Add(new MySqlParameter("funcao", dto.Fucao));
            parms.Add(new MySqlParameter("V_transporte", dto.vl_transporte));
            parms.Add(new MySqlParameter("sala_liqui", dto.salario));
            parms.Add(new MySqlParameter("vale_refeicao", dto.vl_refeicao));         
            parms.Add(new MySqlParameter("nm_login", dto.Login));
            parms.Add(new MySqlParameter("ds_senha", dto.Senha));
            parms.Add(new MySqlParameter("bt_permissao_adm", dto.ADM));
            parms.Add(new MySqlParameter("bt_permissao_rh", dto.RH));
            parms.Add(new MySqlParameter("bt_permissao_func", dto.Func));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);


        }
        public void Remover(int ID)
        {
            string script = @"DELETE FROM tb_funcionario WHERE id_funcionario = @id_funcionario";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_funcionario", ID));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }
        public List<FuncionariosDTO> Listar()
        {
            string script = @"SELECT * FROM tb_funcionario";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<FuncionariosDTO> lista = new List<FuncionariosDTO>();
            while (reader.Read())
            {
                FuncionariosDTO dto = new FuncionariosDTO();
                dto.ID = reader.GetInt32("id_funcionario");
                dto.Nome = reader.GetString("nm_funcio");
                dto.email = reader.GetString("ds_email");
                dto.Endereco = reader.GetString("ds_ender");
                dto.Numero_casa = reader.GetInt32("ds_numerocasa");
                dto.Cep = reader.GetString("ds_cep");
                dto.Bairro = reader.GetString("bairro");
                dto.Cidade = reader.GetString("cidade");
                dto.Estado = reader.GetString("estado");
                dto.Telefone = reader.GetInt32("ds_tele");
                dto.CPF = reader.GetString("ds_cpf");
                dto.RG = reader.GetString("ds_rg");
                dto.Fucao = reader.GetString("funcao");
                dto.salario = reader.GetDecimal("sala_liqui");
                dto.vl_refeicao = reader.GetDecimal("vale_refeicao");
                dto.vl_transporte = reader.GetDecimal("V_transporte");
                dto.Login = reader.GetString("nm_login");
                dto.Senha = reader.GetString("ds_senha");
                dto.ADM = reader.GetBoolean("bt_permissao_adm");
                dto.RH = reader.GetBoolean("bt_permissao_rh");
                dto.Func = reader.GetBoolean("bt_permissao_func");

                lista.Add(dto);
            }
            reader.Close();

            return lista;
        }
    }
}
