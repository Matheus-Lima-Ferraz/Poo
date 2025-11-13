namespace ClassesEObjetos
{
    public class Pessoa
    {
        public string Nome = "";

        public int idade = 0;


        public void Falar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}");
        }

        //aqui, quem não treina envelhece mais um ano por vez
        public int Envelhecer(int _anos)
        {
          if(_anos <= 0)
            {
                Console.WriteLine($"Idade tem que ser positiva!");
                return idade; //retorna a idade anterior 
            }


            idade += _anos;//atualiza a idade

            return idade;//retorna a idade atualizada
        }
    }//fim da class
}//fim do namespace