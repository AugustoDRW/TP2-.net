using Microsoft.AspNetCore.Mvc.RazorPages;
using TP2_c_.Models;
using System.Collections.Generic;

namespace TP2_c_.Pages
{
    public class PessoasModel : PageModel
    {
        public List<Pessoa> PessoaList { get; set; }

        public PessoasModel()
        {
            PessoaList = new List<Pessoa>
            {
                new Pessoa("Augusto", 18, "010.576.544-87"),
                new Pessoa("Icaro", 22, "031.176.187-98"),
                new Pessoa("Vitor", 19, "970.123.768-23"),


            };
        }

        public void OnGet()
        {

        }
    }
}