// 2- Crie um programa que permita que o usuário cadastre 5 nomes em um vetor. Após o
// cadastro, o programa deve imprimir na tela os nomes cadastrados em ordem alfabética.
// Utilize um laço for para o cadastro e um método de ordenação de sua preferência (por
// exemplo, bubble sort) para ordenar os nomes.

string[] nomes = new string[5];

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Digite o {i + 1} nome: ");
    nomes[i] = Console.ReadLine()!;

}

Array.Sort(nomes);
foreach (var n in nomes)
{
    Console.WriteLine($"Aqui está a lista de nomes em ordem alfabética");
    Console.WriteLine($"");
    Console.WriteLine($"{n}");
}