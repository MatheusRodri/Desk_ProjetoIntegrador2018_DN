using ProjetoADM.Codigos.Fornecedor;
using ProjetoADM.Codigos.Pedido;
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

namespace ProjetoADM.Telas.Tela_pedido
{
    public partial class Pedir_pedido : Form
    {
        BindingList<vm_consultar_produto> pedidos = new BindingList<vm_consultar_produto>();
        public Pedir_pedido()
        {
            InitializeComponent();
            CarregarCombos();
           
        }
        void CarregarCombos()
        {
            FornecedorBusiness business = new FornecedorBusiness();
            List<FornecedorDTO> lista = business.Listar();


            comboBox1.ValueMember = nameof(FornecedorDTO.ID);
            comboBox1.DisplayMember = nameof(FornecedorDTO.Nome);
            comboBox1.DataSource = lista;


            ProdutoBusiness businessprodut = new ProdutoBusiness();
            List<vm_consultar_produto> listaa = businessprodut.Listar();


            comboBox2.ValueMember = nameof(vm_consultar_produto.ID);
            comboBox2.DisplayMember = nameof(vm_consultar_produto.Nome);
            comboBox2.DataSource = listaa;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Pedir_pedido_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            







        }

        private void button2_Click(object sender, EventArgs e)
        {


            FornecedorDTO dto1 = comboBox1.SelectedItem as FornecedorDTO;
            vm_consultar_produto dto2 = comboBox2.SelectedItem as vm_consultar_produto;

            PedidoDTO dto = new PedidoDTO();
            dto.id_produto = dto2.ID;
            dto.valor = Convert.ToDecimal(textBox1.Text);
            dto.id_fornecor = dto1.ID;

            PedidoBusiness business = new PedidoBusiness();
            business.Salvar(dto);

          


            MessageBox.Show("Pedido realizado com sucesso");
            tela_principal tela = new tela_principal();
            tela.Show();
            this.Hide();
        }
        private void cboNome_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProdutoDTO forn = comboBox2.SelectedItem as ProdutoDTO;
        }

        private void cboFornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            FornecedorDTO forn = comboBox1.SelectedItem as FornecedorDTO;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            tela_principal tela = new tela_principal();
            tela.ShowDialog();
            this.Hide();







        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            tela_principal tela = new tela_principal();
            tela.ShowDialog();
            this.Hide();
        }
    }
}
