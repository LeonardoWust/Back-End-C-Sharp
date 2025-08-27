//Estruturas de Controle
//IF e Else

// int idade = 19;

// if (idade >= 18)
// {
//     Console.WriteLine("Você é mairo de idade!");
// }
// else
// {
//     Console.WriteLine("Você é menor de idade!");
// }

// //if-else

// double nota = 8.5;

// if (nota >= 9)
// {
//     Console.WriteLine("Tu é o bixão memo heim!");
// }
// else if (nota >= 6)
// {
//     Console.WriteLine("Tá bom!");
// }
// else
// {
//     Console.WriteLine("Vacilão!");
// }

// //switch-case

// string cor = "vermelho";

// switch (cor)
// {
//     case "vermelho":
//         Console.WriteLine("A cor é vermelho");
//         break;
//     case "verde":
//         Console.WriteLine("A cor é verde!");
//         break;
//     case "azul":
//         Console.WriteLine("A cor é azul");
//         break;
//     default:
//         Console.WriteLine("Cor não reconhecida");
//         break;
// }

// //for
// for (int i = 0; i < 5; i++)
// {
//     Console.WriteLine($"Contador {i}");
// }

// //while
// int contador = 0;

// while (contador < 5) ;
// {
//     Console.WriteLine($"Contador {contador}");
//     contador++;
// }

//do=while
// int contagem = 0;

// do
// {
//     Console.WriteLine($"Contagem {contagem}");
//     contagem++;

// } while (contagem < 3);

//break

for (int i = 0; i < 10; i++)
{
    if (!(i % 2 == 0))
    {
        continue;
    }
    Console.WriteLine(i);
}