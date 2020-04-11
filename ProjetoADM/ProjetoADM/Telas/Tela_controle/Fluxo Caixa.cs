using ProjetoADM.Codigos.Fluxo_caixa;
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
    public partial class Fluxo_Caixa : Form
    {
        public Fluxo_Caixa()
        {
            InitializeComponent();
        }
        void CarregarGrid()
        {
            Fluxo_caixaBusiness business = new Fluxo_caixaBusiness();
            List<Fluxo_caixaDTO> lista = business.Consultar(dateTimePicker1.Value, dateTimePicker2.Value);

            dgvFluxo.AutoGenerateColumns = false;
            dgvFluxo.DataSource = lista;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fluxo_caixaBusiness business = new Fluxo_caixaBusiness();
            List<Fluxo_caixaDTO> lista = business.Consultar(dateTimePicker1.Value, dateTimePicker2.Value);

            dgvFluxo.AutoGenerateColumns = false;
            dgvFluxo.DataSource = lista;


            decimal despesas = 0;
            decimal ganhos = 0;

            foreach (DataGridViewRow item in dgvFluxo.Rows)
            {
               
                despesas = despesas + Convert.ToDecimal(item.Cells[1].Value);
                ganhos = ganhos + Convert.ToDecimal(item.Cells[2].Value);

                label6.Text = Convert.ToString(despesas);
                label5.Text = Convert.ToString(ganhos);
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {
            tela_principal tela = new tela_principal();
            tela.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
