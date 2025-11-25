using System.ComponentModel.Design.Serialization;

namespace ENCAPSULAMENTO
{
    public class ContaBancaria
    {
        private float Saldo;
    //Construtores
        public ContaBancaria()
        {
            Saldo = 0;
        }

        public ContaBancaria(float saldoInicial)
        {
            Saldo = saldoInicial;
        }

        public void Depositar(float valor)
        {
            if (valor >= 0)
            {
                Saldo = valor;
                return;
            }

                System.Console.WriteLine($"Valor para depósito inválido");

        }

        public float GetSaldo()
        {
            return Saldo;
        }

        public void aque(float valor)
        {
            if (valor > Saldo)
            {
            System.Console.WriteLine($"Saldo inválido");
            return;
        }
            Saldo -= valor;
        }
    }
}