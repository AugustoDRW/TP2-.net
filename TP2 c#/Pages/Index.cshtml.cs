using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TP2_c_.Models;

namespace TP2_c_.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
        public static string mensagem()
        {
            Random numAleatorio = new Random();

            int valorInteiro = numAleatorio.Next(1, 8);

            if (valorInteiro == 1) { return "Os problemas são oportunidades para se mostrar o que sabe"; }

            if (valorInteiro == 2) { return "Vender é construir uma ponte entre você e seu cliente e fazê-lo atravessar para o seu lado"; }

            if (valorInteiro == 3) { return "Na prosperidade, nossos amigos nos conhecem; na adversidade, nós é que conhecemos nossos amigos"; }

            if (valorInteiro == 4) { return "A felicidade não está em fazer o que a gente quer, e sim querer o que a gente faz"; }

            if (valorInteiro == 5) { return "Nada acontece a menos que sonhemos antes"; }

            if (valorInteiro == 6) { return "É sempre divertido fazer o impossível"; }

            if (valorInteiro == 7) { return "A coisa mais cara é transformar um cliente insatisfeito em satisfeito"; }

            if (valorInteiro == 8) { return "Experiência é o nome que cada um dá a seus erros"; } else { return "Prefiro os erros do entusiasmo à indiferença da sabedoria"; }
        }


    }
}