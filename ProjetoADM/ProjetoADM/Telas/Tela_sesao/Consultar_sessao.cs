using ProjetoADM.Codigos.Sessão;
using ProjetoADM.Codigos.View;
using ProjetoADM.Telas.Tela_sesao;
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
    public partial class Consultar_sessao : Form
    {
        public Consultar_sessao()
        {
            InitializeComponent();
            CarregarGrid();
        }

        public void CarregarGrid()
        {
            try
            {
                SessaoBussiness business = new SessaoBussiness();
                List<SessaoDTO> dto = new List<SessaoDTO>();
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = dto;
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                View_sessao funcionarios = dataGridView1.Rows[e.RowIndex].DataBoundItem as View_sessao;


                Alterar_sesao tela = new Alterar_sesao();
                tela.LoadScreen(funcionarios);
                tela.ShowDialog();
                this.Hide();

            }

            if (e.ColumnIndex == 5)
            {
                View_sessao produtoss = dataGridView1.CurrentRow.DataBoundItem as View_sessao;

                DialogResult r = MessageBox.Show("Deseja excluir a sessão ?", "Realce Sua Beleza",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question);

                if (r == DialogResult.Yes)
                {
                    SessaoBussiness business = new SessaoBussiness();
                    business.Remover(produtoss.ID);

                    CarregarGrid();
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SessaoBussiness business = new SessaoBussiness();
            List<View_sessao> lista = business.Consultar(textBox1.Text);

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = lista;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            tela_principal tela = new tela_principal();
            tela.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

   

}

     