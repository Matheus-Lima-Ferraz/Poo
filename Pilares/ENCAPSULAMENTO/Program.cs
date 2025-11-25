// using ENCAPSULAMENTO;

// float dinheiro = -200;

// ContaBancaria contaEdu = new ContaBancaria();
// ContaBancaria contaMatheus = new ContaBancaria(dinheiro);

// contaEdu.Depositar(dinheiro);

// System.Console.WriteLine($"Novo saldo do Edu: R${contaEdu.GetSaldo()}");

// System.Console.WriteLine($"Novo saldo do Matheus: R${contaMatheus.GetSaldo()}");

// contaEdu.Saque(100);
// System.Console.WriteLine($"Saldo apos saque do Edu: R${contaEdu.GetSaldo()}");

using Encapsulamento;

// float dinheiro = 200;

// ContaBancaria contaLuis = new ContaBancaria();
// ContaBancaria contaBea = new ContaBancaria(dinheiro);

// contaLuis.Depositar(dinheiro);
// contaBea.Depositar(dinheiro);

// Console.WriteLine($"Saldo de Luis: R${contaLuis.GetSaldo()}");
// Console.WriteLine($"Saldo de Bea: R${contaBea.GetSaldo()}");

// contaLuis.Sacar(107);
// contaBea.Sacar(43);

// Console.WriteLine($"Novo saldo de Luis: R${contaLuis.GetSaldo()}");
// Console.WriteLine($"Novo saldo de Bea: R${contaBea.GetSaldo()}");


// -- Exercício Carro --
Carro c = new Carro();

c.DefinirMarca("mazda");
c.DefinirModelo("RX-7");

c.Acelerar(250);
c.Frear(20);
c.Acelerar(50);
c.Frear(67);

Console.WriteLine(@$"Características do Carro:
    Marca: {c.ObterMarca()}
    Modelo: {c.ObterModelo()}
    Velocidade Atual: {c.ObterVelocidade()} km/h
    ");