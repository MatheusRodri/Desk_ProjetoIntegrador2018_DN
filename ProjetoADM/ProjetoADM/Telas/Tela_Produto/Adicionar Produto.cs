using ProjetoADM.Codigos.Fornecedor;
using ProjetoADM.Codigos.Produto;
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
    public partial class Adicionar_Produto : Form
    {
        public Adicionar_Produto()
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

        private void button1_Click(object sender, EventArgs e)
        {
            FornecedorDTO dto3 = comboBox1.SelectedItem as FornecedorDTO;
           

            ProdutoDTO dto = new ProdutoDTO();
            dto.Nome = txtnome.Text;
            dto.Data_vencimento = dateTimePicker1.Value;
            dto.Id_fornecedor = dto3.ID;

            ProdutoBusiness business = new ProdutoBusiness();
            business.Salvar(dto);

            MessageBox.Show("Produto salvo com sucesso");


           


        }

        private void Adicionar_Produto_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FornecedorDTO forn = comboBox1.SelectedItem as FornecedorDTO;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tela_principal tela = new tela_principal();
            tela.ShowDialog();
            this.Hide();
        }

       

        private void label5_Click(object sender, EventArgs e)
        {
            tela_principal tela = new tela_principal();
            tela.ShowDialog();
            this.Hide();
        }
    }
}
