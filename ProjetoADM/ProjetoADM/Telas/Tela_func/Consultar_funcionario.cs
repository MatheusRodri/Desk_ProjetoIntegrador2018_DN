using ProjetoADM.Codigos.Funcionarios;
using ProjetoADM.Telas.Tela_fornecedor;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProjetoADM.Telas.Tela_func
{
    public partial class Consultar_funcionario : Form
    {
        public Consultar_funcionario()
        {
            InitializeComponent();
            CarregarGrid();
        }
        public void CarregarGrid()
        {
            try
            {
                FuncionariosBusiness business = new FuncionariosBusiness();
                List<FuncionariosDTO> dto = new List<FuncionariosDTO>();
                dgfunc.AutoGenerateColumns = false;
                dgfunc.DataSource = dto;
            }
            catch (System.Exception)
            {

                throw;
            }
        }
        
       


        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
              FuncionariosDTO funcionarios =  dgfunc.Rows[e.RowIndex].DataBoundItem as FuncionariosDTO;

                AlterarFuncuinario tela = new AlterarFuncuinario();
                tela.LoadScreen(funcionarios);
                tela.ShowDialog();
                this.Hide();
                
            }

            if (e.ColumnIndex == 5)
            {
                FuncionariosDTO Funcionarioss = dgfunc.CurrentRow.DataBoundItem as FuncionariosDTO;

                DialogResult r = MessageBox.Show("Deseja excluir o  funcionario ?", "Realce Sua Beleza",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question);

                if (r == DialogResult.Yes)
                {
                    FuncionariosBusiness business = new FuncionariosBusiness();
                    business.Remover(Funcionarioss.ID);

                    CarregarGrid();
                }
            }
        }

       
        

        private void button1_Click(object sender, System.EventArgs e)
        {

            FuncionariosBusiness business = new FuncionariosBusiness();
            List<FuncionariosDTO> lista = business.Consultar(maskedTextBox1.Text);

            dgfunc.AutoGenerateColumns = false;
            dgfunc.DataSource = lista;
        }

        private void label2_Click(object sender, System.EventArgs e)
        {
            tela_principal tela = new tela_principal();
            tela.Show();
            this.Hide();

        }

        private void label2_Click_1(object sender, System.EventArgs e)
        {
            tela_principal tela = new tela_principal();
            tela.ShowDialog();
            this.Hide();
        }
    }
}
