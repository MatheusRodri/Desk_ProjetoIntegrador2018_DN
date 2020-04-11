using ProjetoADM.Codigos.Gastos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoADM.Telas.Tela_controle
{
    public partial class frm_gastos : Form
    {
        public frm_gastos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GastosDTO dto = new GastosDTO();
            dto.Descricao =txtgastos.Text;
            dto.Data_gastos = dtpdata.Value;
            dto.tipo = cbotipo.Text;
            dto.Valor = Convert.ToDecimal(maskedTextBox1.Text);

            GastosBussiness bussiness = new GastosBussiness();
            bussiness.Salvar(dto);

            MessageBox.Show("Gasto cadastrado com sucesso", "Realce Sua Beleza");

        }

        private void label5_Click(object sender, EventArgs e)
        {
            tela_principal tela = new tela_principal();
            tela.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
