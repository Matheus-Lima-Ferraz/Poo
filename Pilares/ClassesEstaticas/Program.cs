// // See https://aka.ms/new-console-template for more information
// using ClassesEstaticas;
Console.Clear;
 System.Console.WriteLine("Bem Vindo ao programa");
// System.Console.WriteLine();

// System.Console.WriteLine($"Digite um número: ");
// float a = float.Parse(Console.ReadLine());
// System.Console.WriteLine($"Digite outro número: ");
// float b = float.Parse(Console.ReadLine());

// float r = CalculosMatematicos.Somar(a, b);
// System.Console.WriteLine($"Soma: {r}");

// r = CalculosMatematicos.Subtrair(a, b):
// System.Console.WriteLine($"Subtração: {r}");

// r = CalculosMatematicos.Multiplicar(a, b);
// System.Console.WriteLine($"Multiplicação: {r}");

// r = CalculosMatematicos.Dividir(a, b);
// System.Console.WriteLine($"Divisão: {r}");


// System.Console.WriteLine($"Valor do PI é: {Math.PI}");
// System.Console.WriteLine($"Potência de 3 elevado a 2 é: {Math.Pow(3, 2)}");

/*solicitar ao usuario 2 numeros reais e informar qual
e o maior e qual e o menor dos numeros. Para isso voce deve
utilizar a classe Math, utilitaria do C#*/
Console.WriteLine($"Digite o primeiro numero: ");
float n1 = float.Parse(Console.ReadLine());
Console.WriteLine($"Digite o segundo numero: ");
float n2 = float.Parse(Console.ReadLine());

if (n1== n2)
{
    System.Console.WriteLine($" Os dois numeros sao iguais");
}
else
{
   System.Console.WriteLine($@" O maior numero e: {Math.Max(n1, n2)}
                             o numero menor e: {Math.Min(n1, n2)}");
}

