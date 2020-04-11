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
    public partial class Alterar_tratamentos : Form
    {
        public Alterar_tratamentos()
        {
            InitializeComponent();
            CarregarGrid();
        }
        public void CarregarGrid()
        {

            TratamentoBusiness business = new TratamentoBusiness();
            List<TratamentoDTO> dto = new List<TratamentoDTO>();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dto;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                TratamentoDTO tratamento = dataGridView1.Rows[e.RowIndex].DataBoundItem as TratamentoDTO;

                Consultar_Tratamentos tela = new Consultar_Tratamentos();
                tela.LoadScreen(tratamento);
                tela.ShowDialog();
                this.Hide();


            }

            if (e.ColumnIndex == 4)
            {
                TratamentoDTO produtoss = dataGridView1.CurrentRow.DataBoundItem as TratamentoDTO;

                DialogResult r = MessageBox.Show("Deseja excluir o  tratamento ?", "Realce Sua Beleza",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question);

                if (r == DialogResult.Yes)
                {
                    TratamentoBusiness business = new TratamentoBusiness();
                    business.Remover(produtoss.ID);

                    CarregarGrid();
                }
            }


        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Alterar_tratamentos_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TratamentoBusiness business = new TratamentoBusiness();
            List<TratamentoDTO> lista = business.Consultar(textBox1.Text);

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = lista;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            tela_principal tela = new tela_principal();
            tela.Show();
            this.Hide();
        }
    }
}
