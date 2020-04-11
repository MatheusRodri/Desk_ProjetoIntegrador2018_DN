using ProjetoADM.Codigos.Cliente;
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
    public partial class Cadastro_do_Cliente : Form
    {
        public Cadastro_do_Cliente()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Cadastro_do_Cliente_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        private void label9_Click(object sender, EventArgs e)
        {
            Cadastro_do_Cliente tela = new Cadastro_do_Cliente();
            tela.Close();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtcep_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            ClienteDTO dto = new ClienteDTO();
            dto.Nome = txtnome.Text;
            dto.CPF = maskedTextBox1.Text;
            dto.RG = maskedTextBox2.Text;
            dto.Celular = maskedTextBox3.Text;
            dto.Telefone = maskedTextBox2.Text;
            dto.Cep = txtcep.Text;
            dto.Endereco = txtender.Text;
            dto.Bairro = txtbairro.Text;
            dto.Cidade = txtcity.Text;
            dto.Sexo = comboBox1.Text;
            dto.Numero_casa = Convert.ToInt32(maskedTextBox5.Text);
            dto.Estado = cboestado.Text;
            dto.email = txtemail.Text;
            
            FuncionarioBussiness business = new FuncionarioBussiness();
            business.Salvar(dto);


            MessageBox.Show("Cadastro realizado com sucesso");
            tela_principal tela = new tela_principal();
            tela.Show();
         

            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            tela_principal tela = new tela_principal();
            tela.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CorreioApi correioApi = new CorreioApi();

            // Lê e formata o CEP do textbox
            string cep = txtcep.Text.Trim().Replace("-", "");

            // Chama função BuscarAPICorreio
            CorreioResponse correio = correioApi.Buscar(cep);

            // Altera os valores dos textbox com a resposta do correio
            txtender.Text = correio.logradouro + " - " + correio.complemento;
            txtbairro.Text = correio.bairro;
            txtcity.Text = correio.localidade;
            cboestado.Text = correio.uf;


        }

        private void label14_Click(object sender, EventArgs e)
        {
            tela_principal tela = new tela_principal();
            tela.Show();
            this.Hide();
        }
    }
}
