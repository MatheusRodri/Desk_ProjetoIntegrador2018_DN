using ProjetoADM.Codigos.Funcionarios;
using ProjetoADM.Telas.Estoque;
using ProjetoADM.Telas.IBM;
using ProjetoADM.Telas.Tela_controle;
using ProjetoADM.Telas.Tela_fornecedor;
using ProjetoADM.Telas.Tela_func;
using ProjetoADM.Telas.Tela_pedido;
using ProjetoADM.Telas.Tela_tratamentos;
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
    public partial class tela_principal : Form
    {
        public tela_principal()
        {
            InitializeComponent();
            Verificarpermi();

          
        }
        IbmVoiceApi ibmApi = new IbmVoiceApi();
        public void Bloaqueados()
        {
           
        }


        void Verificarpermi()
        {
            if(Usuario_Logado.UsuarioLogado.ADM == false)
            {
                
                if(Usuario_Logado.UsuarioLogado.RH == false)
                {
                    
                }
                if (Usuario_Logado.UsuarioLogado.Func == true)
                {
                   
                }
            }

        }
       

        


        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarFuncionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tratamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarFuncionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Funcionarios tela = new Funcionarios();
            tela.Show();
            this.Hide();
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultarFuncionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultar_funcionario tela = new Consultar_funcionario();
            tela.Show();
            this.Hide();
        }

        private void folhaDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void cadastrarFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adicionarFornecor tela = new adicionarFornecor();
            tela.Show();
            this.Hide();
        }

        private void consultarFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fornecedor tela = new Fornecedor();
            tela.ShowDialog();
            this.Hide();
        }

        private void adicionarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Adicionar_Produto tela = new Adicionar_Produto();
            tela.Show();
            this.Hide();
        }

        private void consultarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consutar_Produto tela = new Consutar_Produto();
            tela.ShowDialog();
            this.Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pedir_pedido tela = new Pedir_pedido();
            tela.ShowDialog();
            this.Hide();
        }

        private void consultarPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consutar_Pedido tela = new Consutar_Pedido();
            tela.ShowDialog();
            this.Hide();
        }

        private void cadastrarSessãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            marca_sesão tela = new marca_sesão();
            tela.Show();
            this.Hide();

        }

        private void cadastrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro_do_Cliente tela = new Cadastro_do_Cliente();
            tela.ShowDialog();
            this.Hide();
        }

        private void consultarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultar_Cliente tela = new Consultar_Cliente();
            tela.ShowDialog();
            this.Hide();
        }

        private void cadastrarTratamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            criar_tratamentos tela = new criar_tratamentos();
            tela.Show();
            this.Hide();
        }

        private void consultarTratamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alterar_tratamentos tela = new Alterar_tratamentos();
            tela.Show();
            this.Hide();
        }

        private void consultarSessãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultar_sessao tela = new Consultar_sessao();
            tela.ShowDialog();
            this.Hide();
        }

        private void tela_principal_Load(object sender, EventArgs e)
        {

        }

        private void baterPontoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bater_Ponto Tela = new Bater_Ponto();
            Tela.ShowDialog();
            this.Hide(); 


        }

        private void fluxoDeCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fluxo_Caixa tela = new Fluxo_Caixa();
            tela.Show();
            this.Hide();
        }

        private void adicionarGastosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_gastos tela = new frm_gastos();
            tela.Show();
            this.Hide();
        }

        private void adicionarProdutoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void consultarEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_estoque tela = new FRM_estoque();
            tela.Show();
            this.Hide();
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            ibmApi.IniciarOuvir();
            string texto = ibmApi.PararOuvir();

            if (texto == "Abrir fluxo de caixa")
            {
                Funcionarios tela = new Funcionarios();
                tela.ShowDialog();
            }
        
        }

       

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbldata.Text =Convert.ToString(DateTime.Now);
        }

        private void lbldata_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Folha_de__Pagamento tela = new Folha_de__Pagamento();
            tela.Show();
            this.Hide();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultar_folha_de_pagamento tela = new consultar_folha_de_pagamento();
            tela.ShowDialog();
            Hide();
        }

       
    }
}
