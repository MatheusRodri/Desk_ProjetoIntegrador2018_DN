using ProjetoADM.Codigos.Folha_pagamento;
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
    public partial class Folha_de__Pagamento : Form
    {
        public Folha_de__Pagamento()
        {
            InitializeComponent();
            CarregarCombos();
        }
       
        void CarregarCombos()
        {
            FuncionariosBusiness business = new FuncionariosBusiness();
            List<FuncionariosDTO> lista = business.Listar();

            FuncionariosDTO dto = new FuncionariosDTO();

            comboBox1.ValueMember = nameof(FuncionariosDTO.ID);
            comboBox1.DisplayMember = nameof(FuncionariosDTO.Nome);
            comboBox1.DataSource = lista;

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FuncionariosDTO func = comboBox1.SelectedItem as FuncionariosDTO;
            label15.Text = Convert.ToString(func.salario);
            label17.Text = Convert.ToString(func.vl_transporte);
            label18.Text = Convert.ToString(func.vl_refeicao);
      
          
         

        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {

            //Horas Trabalhadas

            decimal SalarioNominal = Convert.ToDecimal(label15.Text);

            int horastrabalhadasdia = 8 * 5;
            int HorasTrabalhadasMes = horastrabalhadasdia * 5;

            decimal ValorHoraTrabalhada = SalarioNominal / HorasTrabalhadasMes;

            

            //Atrasos 
            decimal HorasAtraso = ValorHoraTrabalhada * nudatrasos.Value;
            

            //Faltas

            decimal faltas = SalarioNominal / 30;
            decimal valorfaltas = faltas * nudfaltas.Value;

            //Valor Hora Extra Dia
            decimal PorcentagemHoraExtra = (ValorHoraTrabalhada * 50) / 100;
            decimal ValorHoraExtra = ValorHoraTrabalhada + PorcentagemHoraExtra;
            decimal HorasExtras = ValorHoraExtra * nudhoraextra.Value;

            if (HorasExtras >= 1)
            {
                decimal horasextrasdia = HorasExtras;

            }
            else
            {
                label30.Text = "0,00";
            }


            //Horas extras no feriado

            decimal PorcentagemHoraExtraferiado = (ValorHoraTrabalhada * 100) / 100;
            decimal ValorHoraExtraferiado = ValorHoraTrabalhada + PorcentagemHoraExtraferiado;
            decimal HorasExtrasFeriado = ValorHoraExtraferiado * nudfaltas.Value;


            if (HorasExtrasFeriado >= 1)
            {
                decimal horasextrasdomingo = HorasExtrasFeriado;

            }
            else
            {
                label30.Text = "0,00";
            }



            decimal resultado = HorasExtras + HorasExtrasFeriado;
            resultado = Math.Round(resultado, 2);
            label30.Text = Convert.ToString(resultado);


            //Salario Base do INSS
            decimal SalarioBruto = SalarioNominal + HorasExtras - HorasAtraso - valorfaltas;
            decimal SalarioBaseINSS = SalarioBruto;

            if (SalarioBaseINSS <= 1659.38m)
            {
                decimal salario = (SalarioBaseINSS * 8) / 100;
                salario = Math.Round(salario, 2);
                label20.Text = Convert.ToString(salario);
            }
            else if (SalarioBaseINSS >= 1659.39m && SalarioBaseINSS <= 2765.66m)
            {
                decimal salario = (SalarioBaseINSS * 9) / 100;
                salario = Math.Round(salario, 2);
                label20.Text = Convert.ToString(salario);

            }
            else if (SalarioBaseINSS >= 2765.67m)
            {
                decimal salario = (SalarioBaseINSS * 11) / 100;
                salario = Math.Round(salario, 2);
                label20.Text = Convert.ToString(salario);
            }

            //Imposto de Renda 
            decimal BaseCalculoIR = SalarioBaseINSS - Convert.ToDecimal(label20.Text);

            if (BaseCalculoIR <= 1903.98m)
            {
                label21.Text = "0,00";

            }
            else if (BaseCalculoIR >= 1903.99m && BaseCalculoIR <= 2826.65m)
            {
                decimal imposto = (BaseCalculoIR * 7.5m) / 100;
                decimal reduzir = 142.80m;
                reduzir = Math.Round(reduzir, 2);
                label21.Text = Convert.ToString(reduzir);

            }
            else if (BaseCalculoIR >= 2826.66m && BaseCalculoIR <= 3751.05m)
            {
                decimal imposto = (BaseCalculoIR * 15) / 100;
                decimal reduzir = 354.80m;
                reduzir = Math.Round(reduzir, 2);
                label21.Text = Convert.ToString(reduzir);

            }
            else if (BaseCalculoIR >= 3751.06m && BaseCalculoIR <= 4664.68m)
            {
                decimal imposto = (BaseCalculoIR * 22.5m) / 100;
                decimal reduzir = 636.13m;
                reduzir = Math.Round(reduzir, 2);
                label21.Text = Convert.ToString(reduzir);
            }
            else if (BaseCalculoIR >= 4664.88m)
            {
                decimal imposto = (BaseCalculoIR * 27.5m) / 100;
                decimal reduzir = 869.36m;
                reduzir = Math.Round(reduzir, 2);
                label21.Text = Convert.ToString(reduzir);
            }

            //FGTS
            decimal fgts = (SalarioBaseINSS * 8) / 100;
            fgts = Math.Round(fgts, 2);
            label19.Text = Convert.ToString(fgts);


            //Salario Liquido
            decimal salarioliquido = SalarioNominal - HorasAtraso - valorfaltas - Convert.ToDecimal(label20.Text) - Convert.ToDecimal(label19.Text) -Convert.ToDecimal(label17.Text) - Convert.ToDecimal(label18.Text) + Convert.ToDecimal(label30.Text);
            salarioliquido = Math.Round(salarioliquido, 2);
            label33.Text = Convert.ToString(salarioliquido);

        }

        private void label35_Click(object sender, EventArgs e)
        {
            tela_principal tela = new tela_principal();
            tela.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            FuncionariosDTO dto1 = comboBox1.SelectedItem as FuncionariosDTO;

            Folha_pagamentoDTO dto = new Folha_pagamentoDTO();
            dto.id_funcionario = dto1.ID;
            dto.Salario_bruto =Convert.ToDecimal(label15.Text);
            dto.Hora_Extra =Convert.ToDecimal(label30.Text);
            dto.V_trans =Convert.ToDecimal(label17.Text);
            dto.Vale_refeicao = Convert.ToDecimal(label18.Text);
            
            dto.FGTS = Convert.ToDecimal(label19.Text);
            dto.INSS = Convert.ToDecimal(label20.Text);
            dto.I_Renda = Convert.ToDecimal(label21.Text);
            dto.Salario_liquido = Convert.ToDecimal(label33.Text);
            dto.Faltas =Convert.ToInt32(nudfaltas.Value);

            Folha_pagamentoBusiness business = new Folha_pagamentoBusiness();
            business.Salvar(dto);

            MessageBox.Show("Folha de pagamento salva com sucesso");
        }

        private void label36_Click(object sender, EventArgs e)
        {
            tela_principal tela = new tela_principal();
            tela.ShowDialog();
            this.Hide();
        }
    }
}
