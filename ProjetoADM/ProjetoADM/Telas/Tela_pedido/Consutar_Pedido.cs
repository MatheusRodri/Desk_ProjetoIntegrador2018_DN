using ProjetoADM.Codigos.Pedido;
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

namespace ProjetoADM.Telas.Tela_pedido
{
    public partial class Consutar_Pedido : Form
    {
        public Consutar_Pedido()
        {
            InitializeComponent();
            CarregarGrid();
            
        }

        public void CarregarGrid()
        {

            PedidoBusiness business = new PedidoBusiness();
            List<view_pedido> dto = new List<view_pedido>();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dto;






        }




        private void button1_Click(object sender, EventArgs e)
        {
            PedidoBusiness business = new PedidoBusiness();
            List<view_pedido> lista = business.Consultar(textBox1.Text);

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = lista;
            
        }
            
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                view_pedido pedido = dataGridView1.Rows[e.RowIndex].DataBoundItem as view_pedido;

                Altear_pedido tela = new Altear_pedido();
                tela.LoadScreen(pedido);
                tela.ShowDialog();
                this.Hide();

              
            }

            if (e.ColumnIndex == 4)
            {
                view_pedido produtoss = dataGridView1.CurrentRow.DataBoundItem as view_pedido;

                DialogResult r = MessageBox.Show("Deseja excluir o  pedido ?", "Realce Sua Beleza",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question);

                if (r == DialogResult.Yes)
                {
                    PedidoBusiness business = new PedidoBusiness();
                    business.Remover(produtoss.ID);

                    CarregarGrid();
                }
            }


        }

        private void label3_Click(object sender, EventArgs e)
        {
            tela_principal tela = new tela_principal();
            tela.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}



    
   

