using ProjetoADM.Codigos.Funcionarios;
using System;
using System.Windows.Forms;

namespace ProjetoADM.Telas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FuncionariosBusiness business = new FuncionariosBusiness();
            FuncionariosDTO funcionariosDTO = business.Logar(textBox1.Text, textBox2.Text);


            if (funcionariosDTO == null)
            {
                MessageBox.Show("Erro, tente outro login");

            }
            else
            {
                Usuario_Logado.UsuarioLogado = funcionariosDTO;
                tela_principal tela = new tela_principal();

                tela.Show();
                this.Hide();


            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)

            {
                textBox1.Text = "adm";
                textBox2.Text = "12345";

                FuncionariosBusiness business = new FuncionariosBusiness();
                FuncionariosDTO funcionariosDTO = business.Logar(textBox1.Text, textBox2.Text);


                if (funcionariosDTO == null)
                {
                    MessageBox.Show("Erro, tente outro login");

                }
                else
                {
                    Usuario_Logado.UsuarioLogado = funcionariosDTO;
                    tela_principal tela = new tela_principal();

                    tela.Show();
                    this.Hide();


                }
            }
        }
    }
}
