// using ClassesEObjetos;
// Console.Clear();
// Pessoa matheus = new Pessoa();

// matheus.Nome = "Matheus Lima";
// Console.WriteLine($"{matheus.Nome} tem {matheus.idade} anos");

// int novaIdade = matheus.Envelhecer(16);//atualiza e devolve a idade
// Console.WriteLine($"{matheus.Nome} tem {matheus.idade} anos");

// matheus.Envelhecer(-50);//devolva a idade antiga: 17
// Console.WriteLine($"{matheus.Nome} tem {matheus.idade} anos");

using ClassesEObjetos;

Console.WriteLine($"-- Agência Bancária --");
Console.WriteLine($"Digite o nome do titular da conta:");
string nomeT = Console.ReadLine($"");

AgenciaBancaria conta = new AgenciaBancaria(nomeT);

Console.WriteLine();
Console.WriteLine($"Bem vindo, {conta.Titular}");
Console.WriteLine($"Saldo inicial: R${conta.Saldo:F2}");
Console.WriteLine();

int opcao = 0;
do
{
    Console.WriteLine($"\n Menu");
    Console.WriteLine($"1- Depositar");
    Console.WriteLine($"2- Sacar");
    Console.WriteLine($"0- Sair");
    Console.WriteLine($"0- Sair");
    Console.WriteLine($"Escolha uma opção:");
    Console.ReadLine();
    opcao = int.Parse(Console.ReadLine());

    Console.WriteLine();

    switch (opcao)
    {
        case 1:
            Console.WriteLine($"Digite o valor do depósito: R$");
            double deposito = Convert.ToDouble(Console.ReadLine());
            conta.Depositar(deposito);
            break;

        case 2:
            Console.WriteLine($"Digite o valor de saque: R$");
            double saque = Convert.ToDouble(Console.ReadLine());
            conta.Sacar(saque);
            break;

        case 0:
            Console.WriteLine($"Saindo.");

        default:
            Console.WriteLine($"Opção inválida, escolhe uma das opções acima.");

            break;
    }
} while (opcao != 0);