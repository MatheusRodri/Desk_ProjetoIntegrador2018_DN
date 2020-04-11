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
    public partial class adicionarFornecor : Form
    {
        public adicionarFornecor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FornecedorDTO dto = new FornecedorDTO();
            dto.Nome = maskedTextBox1.Text;
            dto.Endereco = maskedTextBox6.Text;
            dto.numero = Convert.ToInt32(maskedTextBox3.Text);
            dto.Telefone = maskedTextBox2.Text;
            dto.CNPJ = maskedTextBox4.Text;

            FornecedorBusiness business = new FornecedorBusiness();
            business.Salvar(dto);

            MessageBox.Show("Fornecedor salvo com sucesso");

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tela_principal tela = new tela_principal();
            tela.ShowDialog();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            tela_principal tela = new tela_principal();
            tela.Show();
            this.Hide();
        }
    }
}
