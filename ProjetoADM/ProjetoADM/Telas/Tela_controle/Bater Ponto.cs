using ProjetoADM.Codigos.Bater_ponto;
using ProjetoADM.Codigos.Cliente;
using ProjetoADM.Codigos.Funcionarios;
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
    public partial class Bater_Ponto : Form
    {
        public Bater_Ponto()
        {
            InitializeComponent();
            
            CarregarCombos();



        }
        void CarregarCombos()
        {
            FuncionariosBusiness business = new FuncionariosBusiness();
            List<FuncionariosDTO> lista = business.Listar();

            comboBox1.ValueMember = nameof(ClienteDTO.ID);
            comboBox1.DisplayMember = nameof(ClienteDTO.Nome);
            comboBox1.DataSource = lista;
        }
       
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
      

        private void button1_Click(object sender, EventArgs e)
        {

             
                Bater_PontoDTO ponto = new Bater_PontoDTO();
                ponto.Data_entrada = dateTimePicker1.Value;
                ponto.Hora_entrada = dtpentrada.Value;
                ponto.Hora_almoco = dtpalmoco.Value;
                ponto.Hora_almoco_volta = dtpvolta.Value;
                ponto.Hora_Saida = dtpsaida.Value;
            ponto.id_funcionario = Usuario_Logado.UsuarioLogado.ID;

                Bater_PontoBusiness business = new Bater_PontoBusiness();
                business.Salvar(ponto);

                MessageBox.Show("Ponto cadastrado com sucesso.");

                
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FuncionariosDTO dto = comboBox1.SelectedItem as FuncionariosDTO;
               
        }

        private void Bater_Ponto_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
            tela_principal tela = new tela_principal();
            tela.Show();
           this.Hide();
        }
    }
}
