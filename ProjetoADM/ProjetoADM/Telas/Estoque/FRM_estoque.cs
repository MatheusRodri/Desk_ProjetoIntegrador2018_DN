using ProjetoADM.Codigos.Estoque;
using ProjetoADM.Codigos.Produto;
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

namespace ProjetoADM.Telas.Estoque
{
    public partial class FRM_estoque : Form
    {
        BindingList<vm_consultar_estoque> produtosCarrinho = new BindingList<vm_consultar_estoque>();

        public FRM_estoque()
        {
            InitializeComponent();
            ConfigurarGrid();
            CarregarCombos();
        }
        

        void CarregarCombos()
        {
            ProdutoBusiness business = new ProdutoBusiness();
            List<vm_consultar_produto> lista = business.Listar();

            comboBox1.ValueMember = nameof(vm_consultar_produto.ID);
            comboBox1.DisplayMember = nameof(vm_consultar_produto.Nome);
            comboBox1.DataSource = lista;

            
        }

        void ConfigurarGrid()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = produtosCarrinho;
        }





        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EstoqueBusiness business = new EstoqueBusiness();
            List<vm_consultar_estoque> lista = business.Consultar(comboBox1.Text);

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = lista;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            vm_consultar_produto dto1 = comboBox1.SelectedItem as vm_consultar_produto;
            vm_consultar_estoque dto2 = new vm_consultar_estoque();

            EstoqueDTO dto = new EstoqueDTO();





            var combo = comboBox1.SelectedText;
            var data = dataGridView1.Columns[0].Name;
            if (combo == data)
            {
                dto.Quantidade = dto.Quantidade + Convert.ToInt32(textBox1.Text);
            }
            else
            {
                dto.id_produto = dto1.ID;
               
                dto.Quantidade = Convert.ToInt32(textBox1.Text);
            }
          
            EstoqueBusiness business = new EstoqueBusiness();
            business.Salvar(dto);

            MessageBox.Show("Produto adicionado com sucesso no estoque");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            tela_principal tela_ = new tela_principal();
            tela_.ShowDialog();
            this.Hide();       
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
