// See https://aka.ms/new-console-template for more information
using Atividade_1;

Pessoa pessoa1 = new Pessoa();
pessoa1.Nome = "Micael";
pessoa1.Endereco = "Brotas";
pessoa1.Idade = 19;

List<Pessoa> pessoas = new List<Pessoa>();

for (int i = 0; i <= 1; i++)
{
    pessoas.Add(pessoa1);
}

Evento evento = new Evento();
evento.Nome = "BALADINHA BACANA";
evento.Pessoas = pessoas;
evento.Gratuito = false;
evento.AvaliarGratuidade(60);

int j = 1;

foreach (var pessoa in evento.Pessoas)
{
    Console.WriteLine("Pessoa " + j);
    Console.WriteLine("nome: " + pessoa.Nome);
    Console.WriteLine("idade: " + pessoa.Idade);
    Console.WriteLine("Endereço: " + pessoa.Endereco);
    j++;
    System.Console.WriteLine();
}
System.Console.WriteLine("Valor " + evento.Valor);