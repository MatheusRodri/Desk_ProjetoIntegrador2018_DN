using ProjetoADM.Codigos.Fornecedor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoADM.Telas.Tela_fornecedor
{
    public partial class Alterar_forenecedor : Form
    {
        public Alterar_forenecedor()
        {
            InitializeComponent();
        }

        private FornecedorDTO forn;

        public void LoadScreen(FornecedorDTO forne)
        {
            this.forn = forne;

            label7.Text = forne.ID.ToString();
            txtnome.Text = forne.Nome;
            txtCNPJ.Text = forne.CNPJ.ToString();
            txtender.Text = forne.Endereco.ToString();
            txtN.Text = forne.numero.ToString();
            maskedTextBox1.Text = forne.Telefone.ToString();

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            forn.Nome = txtnome.Text;
            forn.CNPJ = txtCNPJ.Text;
            forn.Endereco = txtender.Text;
            forn.numero =Convert.ToInt32(txtN.Text);
            forn.Telefone = maskedTextBox1.Text; 

            FornecedorBusiness business = new FornecedorBusiness();
            business.Alterar(forn);

            MessageBox.Show("Fornecedor alterado com sucesso");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tela_principal tela = new tela_principal();
            tela.ShowDialog();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
                    }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtender_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            tela_principal tela = new tela_principal();
            tela.Show();
            this.Hide();
        }
    }
}
