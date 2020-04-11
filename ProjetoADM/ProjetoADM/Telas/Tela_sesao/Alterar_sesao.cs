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

namespace ProjetoADM.Telas.Tela_sesao
{
    public partial class Alterar_sesao : Form
    {
        public Alterar_sesao()
        {
            InitializeComponent();
            CarregarCombos();
        }
        Email email = new Email();
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
        private View_sessao sessao;
       

        public void LoadScreen(View_sessao ses)
        {
          
            this.sessao = ses;

            cbonomedocliente.Text = ses.cliente.ToString();
            cbofuncionario.Text = ses.funcionario.ToString();
            cbotipodetratamento.Text = ses.tratamento.ToString();
            cboformadepagamento.Text = ses.form_pgto.ToString();
            txtvalor.Text = ses.valor.ToString();
            dtphorario.Value = Convert.ToDateTime(ses.data);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TratamentoDTO dto = cbotipodetratamento.SelectedItem as TratamentoDTO;
            ClienteDTO dto1 = cbonomedocliente.SelectedItem as ClienteDTO;
            FuncionariosDTO dto2 = cbofuncionario.SelectedItem as FuncionariosDTO;

            SessaoDTO dto3 = new SessaoDTO();
            dto3.Id_cliente = dto1.ID;
            dto3.Valor = Convert.ToDecimal(txtvalor.Text);
            dto3.Id_func = dto2.ID;
            dto3.ID_tratamento = dto.ID;
            dto3.Forma_pgto = cboformadepagamento.Text;
            dto3.Data = dtphorario.Value;


            SessaoBussiness business = new SessaoBussiness();
            business.Salvar(dto3);


            MessageBox.Show("Sessão alterada com sucesso");

            email.Para = dto1.email;
            email.Assunto = "Sesão marcada Realce sua Beleza";
            email.Mensagem = dto1.Nome + ", você acabou de marcar um(a)" + dto.Nome + " as " + dto3.Data + " no valor de: " + dto.Valor;

            email.Enviar();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            tela_principal tela = new tela_principal();
            tela.Show();
            this.Hide();
        }
    }
}
                       