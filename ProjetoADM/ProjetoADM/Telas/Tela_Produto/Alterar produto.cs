using ProjetoADM.Codigos.Fornecedor;
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

namespace ProjetoADM.Telas.Tela_Produto
{
    public partial class Alterar_produto : Form
    {
        public Alterar_produto()
        {
            InitializeComponent();
            CarregarCombos();
        }

        void CarregarCombos()
        {
            FornecedorBusiness business = new FornecedorBusiness();
            List<FornecedorDTO> lista = business.Listar();

            FornecedorDTO dto = new FornecedorDTO();

            comboBox1.ValueMember = nameof(FornecedorDTO.ID);
            comboBox1.DisplayMember = nameof(FornecedorDTO.Nome);
            comboBox1.DataSource = lista;

        }

        vm_consultar_produto produto;


        public void LoadScreen(vm_consultar_produto dto)
        {
            this.produto = dto;

            lblid.Text = Convert.ToString(dto.ID);
            txtnome.Text = dto.Nome;
            comboBox1.Text = dto.nome_forn;
            dateTimePicker1.Value = dto.Data_vencimento;



        }


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            FornecedorDTO fornecedor = comboBox1.SelectedItem as FornecedorDTO;
            ProdutoDTO produto2 = new ProdutoDTO();

            produto2.ID = Convert.ToInt32(lblid.Text);
            produto2.Nome = txtnome.Text;
            produto2.Id_fornecedor = fornecedor.ID;

            ProdutoBusiness business = new ProdutoBusiness();
            business.Alterar(produto2);

            MessageBox.Show("Produto alterado com sucesso.");

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FornecedorDTO forn = comboBox1.SelectedItem as FornecedorDTO;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            tela_principal tela = new tela_principal();
            tela.ShowDialog();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
