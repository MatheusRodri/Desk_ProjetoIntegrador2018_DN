using ProjetoADM.Codigos.Tratamento;
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
    public partial class criar_tratamentos : Form
    {
        public criar_tratamentos()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TratamentoDTO dto = new TratamentoDTO();
            dto.Nome = txtnome.Text;
            dto.Valor =Convert.ToDecimal(txtvalor.Text);
            dto.Duracao =Convert.ToInt32(txtduracao.Text);

            TratamentoBusiness business = new TratamentoBusiness();
            business.Salvar(dto);

            MessageBox.Show("Tratemento cadastrado com sucesso");
            tela_principal tela = new tela_principal();
            tela.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void criar_tratamentos_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            tela_principal tela = new tela_principal();
            tela.Show();
            this.Hide();
        }
    }
}
