using ProjetoADM.Codigos.Folha_pagamento;
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

namespace ProjetoADM.Telas.Tela_controle
{
    public partial class consultar_folha_de_pagamento : Form
    {
        public consultar_folha_de_pagamento()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            tela_principal tela = new tela_principal();
            tela.ShowDialog();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Folha_pagamentoBusiness business = new Folha_pagamentoBusiness();
            List<vm_folha_pagamento> lista = business.Consultar(textBox1.Text);

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = lista;
        }
    }
}
