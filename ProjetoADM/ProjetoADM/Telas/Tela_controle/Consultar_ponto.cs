using ProjetoADM.Codigos.Bater_ponto;
using ProjetoADM.Codigos.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoADM.Telas.Tela_controle
{
    public partial class Consultar_ponto : Form
    {
        public Consultar_ponto()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Nome_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            tela_principal tela = new tela_principal();
            tela.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bater_PontoBusiness business = new Bater_PontoBusiness();
            List<vm_consultar_ponto> lista = business.Consultar(textBox1.Text);

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = lista;
        }
    }
}
