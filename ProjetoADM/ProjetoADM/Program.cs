using ProjetoADM.Telas;
using ProjetoADM.Telas.Estoque;
using ProjetoADM.Telas.Tela_controle;
using ProjetoADM.Telas.Tela_Produto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoADM
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmSplash());
        }
    }
}
