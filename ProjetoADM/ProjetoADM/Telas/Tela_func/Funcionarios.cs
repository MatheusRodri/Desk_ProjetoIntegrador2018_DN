using ProjetoADM.Codigos.Funcionarios;
using ProjetoADM.Telas.Plugin;
using ProjetoADM.Telas.Tela_func;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoADM.Telas
{
    public partial class Funcionarios : Form
    {
      

        public Funcionarios()
        {
            InitializeComponent();
           
        }

        Email email = new Email();

        private void button1_Click(object sender, EventArgs e)
        {
            FuncionariosDTO dto = new FuncionariosDTO();
            dto.Nome = txtnome.Text;
            dto.email = textBox2.Text;
            dto.Cep =txtCep.Text;
            dto.Endereco = txtendereco.Text;
            dto.Bairro = txtbairro.Text;
            dto.Cidade = txtcidade.Text;
            dto.RG =  rg.Text;
            dto.CPF =maskedTextBox2.Text;
            dto.salario = Convert.ToDecimal(salario.Text);
            dto.vl_transporte = Convert.ToDecimal(vt.Text);
            dto.vl_refeicao = Convert.ToDecimal(vr.Text);
            dto.Numero_casa = Convert.ToInt32(txtnumero.Text);
            dto.Estado = txtestado.Text;          
            dto.Fucao = textBox1.Text;
            dto.Login = textBox5.Text;
            dto.Senha = textBox6.Text;
            dto.ADM = checkBox1.Checked;
            dto.RH = checkBox2.Checked;
            dto.Func = checkBox7.Checked;

            FuncionariosBusiness business = new FuncionariosBusiness();
            business.Salvar(dto);


            MessageBox.Show("Cadastro realizado com sucesso");

            email.Para = textBox2.Text;
            email.Assunto = "Cadastro da Realce sua Beleza";
            email.Mensagem = "Seja bem vindo a empresa Realc,0e sua Beleza,<br> seu login é:   " +  dto.Login  + "<br>  E sua senha é:" + dto.Senha;

            email.Enviar();

            tela_principal tela = new tela_principal();
            tela.Show();


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            tela_principal tela = new tela_principal();
            tela.ShowDialog();
            this.Hide();
        }

        private void txtRG_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox6_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CorreioApi correioApi = new CorreioApi();

            // Lê e formata o CEP do textbox
            string cep = txtCep.Text.Trim().Replace("-", "");

            // Chama função BuscarAPICorreio
            CorreioResponse correio = correioApi.Buscar(cep);

            // Altera os valores dos textbox com a resposta do correio
            txtendereco.Text = correio.logradouro + " - " + correio.complemento;
            txtbairro.Text = correio.bairro;
            txtcidade.Text = correio.localidade;
            txtestado.Text = correio.uf;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Funcionarios_Load(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {
            tela_principal tela = new tela_principal();
            tela.ShowDialog();
            this.Hide();
        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
