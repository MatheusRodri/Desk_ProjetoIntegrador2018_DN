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

namespace ProjetoADM.Telas.Tela_cliente
{
    public partial class Alterar_cliente : Form
    {
        public Alterar_cliente()
        {
            InitializeComponent();
        }
        void CarregarCombos()
        {

        }
        private ClienteDTO cliente;

        public void LoadScreen(ClienteDTO cli)
        {
            this.cliente = cli;

            label13.Text = cli.ID.ToString();
            txtNome.Text = cli.Nome;
            maskedTextBox7.Text = cli.CPF.ToString();
            maskedTextBox4.Text = cli.RG.ToString();
            maskedTextBox2.Text = cli.Celular.ToString();
            txtender.Text = cli.Endereco.ToString();
            txtBairro.Text = cli.Bairro.ToString();
            txtCidade.Text = cli.Cidade.ToString();
            txtcep.Text = cli.Cep.ToString();
            cboSexo.Text = cli.Sexo.ToString();
            maskedTextBox1.Text = cli.Numero_casa.ToString();
            cboEstado.Text = cli.Estado.ToString();
            txtemail.Text = cli.email.ToString();

        }
            
        private void button1_Click(object sender, EventArgs e)
        {
            cliente.Nome = txtNome.Text;
            cliente.CPF = maskedTextBox7.Text;
            cliente.RG = maskedTextBox4.Text;
            cliente.Celular = maskedTextBox2.Text;
         
            cliente.Endereco = txtender.Text;
            cliente.Bairro = txtBairro.Text;
            cliente.Cidade = txtCidade.Text;
            cliente.Cep = txtcep.Text;
            cliente.Sexo = cboSexo.Text;
            cliente.Numero_casa = Convert.ToInt32(maskedTextBox1.Text);
            cliente.Estado = cboEstado.Text;
            cliente.email = txtemail.Text;


            FuncionarioBussiness business = new FuncionarioBussiness();
            business.Alterar(cliente);

            MessageBox.Show("Cliente  alterado com sucesso.");







        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void Alterar_cliente_Load(object sender, EventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CorreioApi correioApi = new CorreioApi();

            // Lê e formata o CEP do textbox
            string cep = txtcep.Text.Trim().Replace("-", "");

            // Chama função BuscarAPICorreio
            CorreioResponse correio = correioApi.Buscar(cep);

            // Altera os valores dos textbox com a resposta do correio
            txtender.Text = correio.logradouro + " - " + correio.complemento;
            txtBairro.Text = correio.bairro;
            txtCidade.Text = correio.localidade;
            cboEstado.Text = correio.uf;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtCidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBairro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtender_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox5_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox7_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void cboSexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {
            tela_principal tela = new tela_principal();
            tela.Show();
            this.Hide();
        }
    }
}
