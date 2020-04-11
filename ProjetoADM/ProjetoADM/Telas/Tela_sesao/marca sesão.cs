using ProjetoADM.Codigos.Cliente;
using ProjetoADM.Codigos.Funcionarios;
using ProjetoADM.Codigos.Sessão;
using ProjetoADM.Codigos.Tratamento;
using ProjetoADM.Codigos.View;
using ProjetoADM.Telas.Tela_func;
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
    public partial class marca_sesão : Form
    {
        public marca_sesão()
        {
            InitializeComponent();
            CarregarCombos();
        }
        Email email = new Email();
        private void marca_sesão_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            ClienteDTO dto1 = cbonomedocliente.SelectedItem as ClienteDTO;
            FuncionariosDTO dto2 = cbofuncionario.SelectedItem as FuncionariosDTO;
            TratamentoDTO dto3 = cbotipodetratamento.SelectedItem as TratamentoDTO;
                                         
            SessaoDTO dto = new SessaoDTO();
            dto.Forma_pgto = cboformadepagamento.Text;
            dto.Valor = Convert.ToDecimal(txtvalor.Text);
            dto.Data = Convert.ToDateTime (dtp.Text);
            dto.ID_tratamento = dto3.ID;
            dto.Id_cliente = dto1.ID;
            dto.Id_func = dto2.ID;
                                           
            SessaoBussiness business = new SessaoBussiness();
            business.Salvar(dto);

            MessageBox.Show("Sessão marcada com sucesso","Realce sua Beleza",MessageBoxButtons.OK);

            email.Para = dto1.email;
            email.Assunto = "Sesão marcada Realce sua Beleza";
            email.Mensagem = dto1.Nome + ", você acabou de marcar um(a)" + dto3.Nome + " as " + dto.Data + " no valor de: " + dto.Valor ;

            email.Enviar();

            tela_principal tela = new tela_principal();
            tela.Show();

        }

        private void label6_Click(object sender, EventArgs e)
        {
            tela_principal tela = new tela_principal();
            tela.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        void CarregarCombos()
        {
           FuncionarioBussiness business = new FuncionarioBussiness();
            List<ClienteDTO> lista = business.Listar();
         
            cbonomedocliente.ValueMember = nameof(ClienteDTO.ID);
            cbonomedocliente.DisplayMember = nameof(ClienteDTO.Nome);
            cbonomedocliente.DataSource = lista;

            FuncionariosBusiness businesss = new FuncionariosBusiness();
            List<FuncionariosDTO> listaa = businesss.Listar();

            cbofuncionario.ValueMember = nameof(FuncionariosDTO.ID);
            cbofuncionario.DisplayMember = nameof(FuncionariosDTO.Nome);
            cbofuncionario.DataSource = listaa;


            TratamentoBusiness businessss = new TratamentoBusiness();
            List<TratamentoDTO> listaaa = businessss.Listar();

            cbotipodetratamento.ValueMember = nameof(TratamentoDTO.ID);
            cbotipodetratamento.DisplayMember = nameof(TratamentoDTO.Nome);
            cbotipodetratamento.DataSource = listaaa;


        }

        private void aaaa_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

    
    
}
