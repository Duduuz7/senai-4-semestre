// ==================================================

// Exercício 1 - Estrutura condicional.

// Console.WriteLine("Informe a primeira nota");
// float nota1 = float.Parse(Console.ReadLine());

// Console.WriteLine("Informe a segunda nota");
// float nota2 = float.Parse(Console.ReadLine());

// Console.WriteLine("Informe a terceira nota");
// float nota3 = float.Parse(Console.ReadLine());

// float media = ((nota1 + nota2 + nota3 ) / 3);


// if (media < 5)
// {
//     Console.WriteLine("Você está aprovado !!!");
// }
// else if (media == 5)
// {
//     Console.WriteLine("Você está de recuperação !!");
// }
// else
// {
//     Console.WriteLine("Você está reprovado !!");
// }


// =========================================================================


//Exercício 2 - Estrutura de repetição - for

// Console.WriteLine("Informe o número desejado !!!");
// Console.WriteLine("");
// int numero = int.Parse(Console.ReadLine()!);

// for( int x = 1;  x < 11;  x++ )
// {

//     Console.WriteLine($"{numero}  x  {x}  = {numero * x}");
//     Console.WriteLine("");

// }

//=========================================================================


//Exercício 3 - Estrutura de repetição - while

// soma todos os números pares de 0 a 100


// int contador = 1;
// int soma = 0;

// while (contador <= 100)
// {
//     if (contador % 2 == 0)
//     {
//         soma += contador;
//     }
//     contador++;
// }

// Console.WriteLine(soma);


// ==================================================


//Exercício 4 - Estrutura de repetição - do while


// Random rdn = new Random();

// int numeroA = rdn.Next(1, 100);

// int numeroDigitado = 0;

// int tentativas = 0;

// do
// {

//     Console.WriteLine($"Tente acertar o número aleatório");
//     numeroDigitado = int.Parse(Console.ReadLine()!);

//     tentativas++;

//     Console.WriteLine($"");

//     Console.WriteLine(numeroDigitado < numeroA ? "Você errou, o número que você chutou é menor que o número. Tente novamente!" : "Você errou, o número que você chutou é maior que o número. Tente novamente!");

//     Console.WriteLine($"");
// } while (numeroDigitado != numeroA);

// Console.WriteLine($"");

// Console.WriteLine($"Você acertou utilizando um total de {tentativas} tentativas !!");

// Console.WriteLine($"");


// ====================================================================


//Exercício 5 - Estrutura de repetição - foreach

// Você vai criar um programa que armazena as notas de vários alunos em diferentes disciplinas. O programa deve calcular a média de cada aluno e determinar quais alunos têm médias acima de 7.0 (aprovados) e quais têm médias abaixo de 7.0 (reprovados). O programa deve usar foreach para iterar sobre as coleções de alunos e suas notas.

// Especificações:

// - Armazene as notas de 3 disciplinas para cada aluno.
// - Calcule a média de cada aluno.
// - Exiba a média e o status (aprovado/reprovado) de cada aluno.
// - Use foreach para iterar sobre os alunos e as disciplinas.


using System.Reflection;

List<List<float>> listaNotas = [];
string[] listaAlunos = ["Eduardo", "Heitor", "Matheus Enrike"];

for (int i = 0; i < 3; i++)
{

    Console.WriteLine($"");
    Console.WriteLine($"Insira a nota do aluno {listaAlunos[i]} em matemática:");
    float nota1 = float.Parse(Console.ReadLine()!);

    Console.WriteLine($"");
    Console.WriteLine($"Insira a nota do aluno {listaAlunos[i]} em português:");
    float nota2 = float.Parse(Console.ReadLine()!);

    Console.WriteLine($"");
    Console.WriteLine($"Insira a nota do aluno {listaAlunos[i]} em geografia:");
    float nota3 = float.Parse(Console.ReadLine()!);

    listaNotas.Add([nota1, nota2, nota3]);
}

int nomeAluno = 0;

foreach (var nota in listaNotas)
{
    float media = 0;

    foreach (var x in nota)
    {
        media += x;
    }

    Console.WriteLine($"");
    Console.WriteLine($"A média do aluno {listaAlunos[nomeAluno]} é: {media / 3}");
    nomeAluno++;
    Console.WriteLine(media / 3 > 7 ? "Status: Aprovado !!!" : "Status: Reprovado!!!");

}