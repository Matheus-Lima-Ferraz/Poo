using System.Xml;
using ExerciciosMetodoConstrutor;

// Carro C1 = new Carro("Toyota", "Corolla", 2022);
// C1.ExibirDados();
// Console.WriteLine();

// Aluno a1 = new Aluno();
// Aluno a2 = new Aluno("Matheus Lima", 10);

// System.Console.WriteLine();

// System.Console.WriteLine(@$"Aluno 1:
// Nome: {a1.Nome}
// Nota: {a1.Nota}");

// System.Console.WriteLine(@$"Aluno 2:
// Nome: {a2.Nome}
// Nota: {a2.Nota}");

MediaAluno a1 = new MediaAluno(6, 7, 2);

a1.Nome = "Matheus";
a1.Media();

MediaAluno a2 = new MediaAluno();

a2.Nome = "Luis";
a2.Media();




//pra que serve Abstração: simplifica o código, reaproveita partes e protege dados.