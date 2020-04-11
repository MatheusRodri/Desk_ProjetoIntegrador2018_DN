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
    public partial class Altear_pedido : Form
    {
        public Altear_pedido()
        {
            InitializeComponent();
           
            CarregarCombos();
        }
       
        void CarregarCombos()
        {
            FornecedorBusiness business = new FornecedorBusiness();
            List<FornecedorDTO> lista = business.Listar();

           

            cboFornecedor.ValueMember = nameof(FornecedorDTO.ID);
            cboFornecedor.DisplayMember = nameof(FornecedorDTO.Nome);
            cboFornecedor.DataSource = lista;

            ProdutoBusiness businesss = new ProdutoBusiness();
            List<vm_consultar_produto> listaa = businesss.Listar();

           

            cboNome.ValueMember = nameof(ProdutoDTO.ID);
            cboNome.DisplayMember = nameof(ProdutoDTO.Nome);
            cboNome.DataSource = listaa;

        }
        view_pedido pedido ;

       

        public void LoadScreen(view_pedido prod)
        {
            this.pedido = prod;

            lblid.Text = prod.ID.ToString();
            cboNome.Text = prod.Produto;
            cboFornecedor.Text = prod.Fornecedor;
            txtValor.Text =Convert.ToString(prod.Valor);

        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Altear_pedido_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            FornecedorDTO dto1 = cboFornecedor.SelectedItem as FornecedorDTO;
            vm_consultar_produto dto2 = cboNome.SelectedItem as vm_consultar_produto;

            PedidoDTO dto = new PedidoDTO();
            dto.id_produto = dto2.ID;
            dto.valor = Convert.ToDecimal(txtValor.Text);
            dto.id_fornecor = dto1.ID;

            PedidoBusiness business = new PedidoBusiness();
            business.Salvar(dto);


            MessageBox.Show("Pedido alterado com sucesso");
            
        }

        private void cboNome_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProdutoDTO forn = cboNome.SelectedItem as ProdutoDTO;
        }

        private void cboFornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            FornecedorDTO forn = cboFornecedor.SelectedItem as FornecedorDTO;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            tela_principal tela = new tela_principal();
            tela.ShowDialog();
            this.Hide();

            





        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblid_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            tela_principal tela = new tela_principal();
            tela.Show();
            this.Hide();
        }
    }

}

    
