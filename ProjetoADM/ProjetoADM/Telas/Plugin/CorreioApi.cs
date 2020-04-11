using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoADM.Telas.Plugin
{
    class CorreioApi
    {
        public CorreioResponse Buscar(string cep)
        {
            // Cria objeto responsável por conversar com uma API
            WebClient rest = new WebClient();
            rest.Encoding = Encoding.UTF8;

            // Chama API do correio, concatenando o cep
            string resposta = rest.DownloadString("https://viacep.com.br/ws/" + cep + "/json");

            // Transforma a resposta do correio em DTO
            CorreioResponse correio = JsonConvert.DeserializeObject<CorreioResponse>(resposta);
            return correio;
        }
    }
}
