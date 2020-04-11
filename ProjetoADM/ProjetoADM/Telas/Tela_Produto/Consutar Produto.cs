using ProjetoADM.Codigos.Fornecedor;
using ProjetoADM.Codigos.Produto;
using ProjetoADM.Codigos.View;
using ProjetoADM.Telas.Tela_Produto;
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
    public partial class Consutar_Produto : Form
    {
        public Consutar_Produto()
        {
            InitializeComponent();
            CarregarGrid();

        }
        public void CarregarGrid()
        {
            try
            {
                ProdutoBusiness business = new ProdutoBusiness();
                List<ProdutoDTO> dto = new List<ProdutoDTO>();
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
                vm_consultar_produto funcionarios = dataGridView1.Rows[e.RowIndex].DataBoundItem as vm_consultar_produto;


                Alterar_produto  tela = new Alterar_produto();
                tela.LoadScreen(funcionarios);
                tela.ShowDialog();
                this.Hide();

            }

            if (e.ColumnIndex == 5)
            {
                vm_consultar_produto produtoss = dataGridView1.CurrentRow.DataBoundItem as vm_consultar_produto;

                DialogResult r = MessageBox.Show("Deseja excluir o  produto ?", "Realce Sua Beleza",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question);

                if (r == DialogResult.Yes)
                {
                    ProdutoBusiness business = new ProdutoBusiness();
                    business.Remover(produtoss.ID);

                    CarregarGrid();
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            ProdutoBusiness business = new ProdutoBusiness();
            List<vm_consultar_produto> lista = business.Consultar(textBox1.Text);

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = lista;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tela_principal tela = new tela_principal();
            tela.ShowDialog();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            tela_principal tela = new tela_principal();
            tela.Show();
            this.Hide();
        }
    }
}
