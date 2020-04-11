using ProjetoADM.Codigos.Cliente;
using ProjetoADM.Telas.Tela_cliente;
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
    public partial class Consultar_Cliente : Form
    {
        public Consultar_Cliente()
        {
            InitializeComponent();
          
            CarregarGrid();
        }
      
        public void CarregarGrid()
        {
            string nome = txtnome.Text;
           

            FuncionarioBussiness business = new FuncionarioBussiness();
            List<ClienteDTO> lista = business.Consultar(nome);

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = lista;
        }

       
        

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FuncionarioBussiness business = new FuncionarioBussiness();
            List<ClienteDTO> lista = business.Consultar(txtnome.Text);

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = lista;
        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            tela_principal tela = new tela_principal();
            tela.ShowDialog();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                ClienteDTO funcionarios = dataGridView1.Rows[e.RowIndex].DataBoundItem as ClienteDTO;

                Alterar_cliente tela = new Alterar_cliente();
                tela.LoadScreen(funcionarios);
                tela.ShowDialog();
                this.Hide();

            }

            if (e.ColumnIndex == 4)
            {
                ClienteDTO Funcionarioss = dataGridView1.CurrentRow.DataBoundItem as ClienteDTO;

                DialogResult r = MessageBox.Show("Deseja excluir o  funcionario ?", "Realce Sua Beleza",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question);

                if (r == DialogResult.Yes)
                {
                    FuncionarioBussiness business = new FuncionarioBussiness();
                    business.Remover(Funcionarioss.ID);

                    CarregarGrid();
                }
            }
        }
    }
    
}
