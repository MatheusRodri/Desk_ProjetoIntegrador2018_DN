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

namespace ProjetoADM.Telas.Tela_tratamentos
{
    public partial class Consultar_Tratamentos : Form
    {
        public Consultar_Tratamentos()
        {
            InitializeComponent();
        }
        private TratamentoDTO trate;

        public void LoadScreen(TratamentoDTO tratamento)
        {
            this.trate = tratamento;

            lblid.Text = tratamento.ID.ToString();
            txtnome.Text = tratamento.Nome.ToString();
            txtduração.Text = tratamento.Duracao.ToString();       
            txtvalor.Text = tratamento.Valor.ToString();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Consultar_Tratamentos_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtnome_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtnome.Text = trate.Nome.ToString();
            txtduração.Text = trate.Duracao.ToString();
            txtvalor.Text = trate.Valor.ToString();

            TratamentoBusiness business = new TratamentoBusiness();
            business.Alterar(trate);

            MessageBox.Show("Tratamento alterado com sucesso");

            tela_principal tela = new tela_principal();
            tela.ShowDialog();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        

        private void label5_Click_2(object sender, EventArgs e)
        {
            tela_principal tela = new tela_principal();
            tela.Show();
            this.Hide();
        }
    }
}
