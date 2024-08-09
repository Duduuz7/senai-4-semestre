// 3- Crie um programa que calcule a soma dos números pares de um vetor de 10 elementos.
// Utilize um laço for para percorrer o vetor e uma estrutura condicional if para identificar
// os números pares.

int[] listaNumeros = [10, 6, 5, 3, 7, 8, 4, 1, 66, 2];
int somaPares = 0;

for (int i = 0; i < listaNumeros.Length; i++)
{
    if (listaNumeros[i] % 2 == 0){
        somaPares += listaNumeros[i];
    }
}

Console.WriteLine($"");
Console.WriteLine($"A soma de todos os números pares é igual a: {somaPares}");
Console.WriteLine($"");
