namespace TP2_c_.Models
{
    public class Pessoa
    {

        private string _nome;
        private int _idade;
        private string _cpf;

        public string Nome { get { return _nome; } set { _nome = value; } }
        public int Idade { get { return _idade; } set { _idade = value; } }
        public string CPF { get { return _cpf; } set { _cpf = value; } }

        public Pessoa(string nome, int idade, string cpf)
        {
            _nome = nome;
            _idade = idade;
            _cpf = cpf;
        }




    }
}
