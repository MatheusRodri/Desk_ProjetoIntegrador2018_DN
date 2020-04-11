using ProjetoADM.Codigos.Funcionarios;
using ProjetoADM.Telas.Plugin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoADM.Telas
{
    public partial class AlterarFuncuinario : Form
    {
        public AlterarFuncuinario()
        {
            InitializeComponent();
      

        }

       private FuncionariosDTO func;

        
        public void LoadScreen(FuncionariosDTO funci)
            {
            this.func = funci;

            lblId.Text = funci.ID.ToString();
            txtNome.Text = funci.Nome;
            mskCpf.Text = funci.CPF.ToString();
            mskRg.Text = funci.RG.ToString();
            txtEndereco.Text = funci.Endereco.ToString();
            mskCEP.Text= funci.Cep.ToString();
            txtBairro.Text = funci.Bairro.ToString();
            txtCidade.Text = funci.Cidade.ToString();
           
            mskVr.Text = funci.vl_refeicao.ToString();
            txtNumero.Text = funci.Numero_casa.ToString();
            cboEstado.Text = funci.Estado.ToString();
            mskSalario.Text = funci.salario.ToString();
            mskVt.Text = func.vl_transporte.ToString();
           
            txtUsuario.Text = funci.Login.ToString();
            txtSenha.Text = funci.Senha.ToString();
            chkAdm.Checked =Convert.ToBoolean(funci.ADM.ToString());
            chkRh.Checked =Convert.ToBoolean(funci.RH.ToString());
            chkFuncionario.Checked = Convert.ToBoolean(funci.Func.ToString());
            textBox1.Text = funci.email;

            


        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtendereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
           
            func.Nome = txtNome.Text;
            func.Login = txtUsuario.Text;
            func.Senha = txtSenha.Text;
            func.Numero_casa = Convert.ToInt32(txtNumero.Text);
            func.Bairro = txtBairro.Text;
            func.Cep = mskCEP.Text;
            func.CPF = mskCpf.Text;
            func.RG = mskRg.Text;
            func.Endereco = txtEndereco.Text;
            func.Estado = cboEstado.Text;
            func.ADM = Convert.ToBoolean(chkAdm.Checked);
            func.RH = Convert.ToBoolean(chkRh.Checked);
            func.Func = Convert.ToBoolean(chkFuncionario.Checked);
            func.Cidade = txtCidade.Text;
            func.salario =Convert.ToDecimal(mskSalario.Text);
            func.vl_transporte = Convert.ToDecimal(mskVt.Text);
            func.vl_refeicao = Convert.ToDecimal(mskVr.Text);
           
            func.Fucao = txtFuncao.Text;
            func.email = textBox1.Text;

            FuncionariosBusiness business = new FuncionariosBusiness();
            business.Alterar(func);

            MessageBox.Show("Funcionario alterado com sucesso.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tela_principal tela = new tela_principal();
            tela.ShowDialog();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CorreioApi correioApi = new CorreioApi();

            // Lê e formata o CEP do textbox
            string cep = mskCEP.Text.Trim().Replace("-", "");

            // Chama função BuscarAPICorreio
            CorreioResponse correio = correioApi.Buscar(cep);

            // Altera os valores dos textbox com a resposta do correio
            txtEndereco.Text = correio.logradouro + " - " + correio.complemento;
            txtBairro.Text = correio.bairro;
            txtCidade.Text = correio.localidade;
            cboEstado.Text = correio.uf;
        }

        private void AlterarFuncuinario_Load(object sender, EventArgs e)
        {

        }

        private void mskCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mskCEP_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {
            tela_principal tela = new tela_principal();
            tela.Show();
            Hide();
        }
    }
}
