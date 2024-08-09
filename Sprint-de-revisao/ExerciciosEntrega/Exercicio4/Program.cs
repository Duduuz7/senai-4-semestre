// See https://aka.ms/new-console-template for more information

// 4 - Crie uma função que recebe um número como parâmetro e retorna a tabuada desse
// número até o número 10. Utilize um laço for para gerar os múltiplos do número.


static void Multiplicar(int numero)
{
    for (int x = 1; x < 11; x++)
    {
        Console.WriteLine($"{numero}  x  {x}  = {numero * x}");
        Console.WriteLine("");
    }
}

Console.WriteLine("Insira o número que quer saber a tabuada:");
int numero = int.Parse(Console.ReadLine()!);

Console.WriteLine("");

Multiplicar(numero);