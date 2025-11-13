namespace POO.Pilares.Herança.Exercicio01
{
    public class Veiculo
    {
        public class Veiculo
        {
            public string Marca;
            public string Modelo;
            public int Ano;

            public virtual void Acelerar()
            {
                System.Console.WriteLine($"Acelerando o Veiculo");
            }
        }
    }
}