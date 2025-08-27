Console.WriteLine("Digite o primeiro número: ");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o segundo número: ");
double num2 = Convert.ToDouble(Console.ReadLine());

double soma = num1 + num2;
double subtracao = num1 - num2;
double multiplicacao = num1 * num2;
double divisao = num1 / num2;

Console.WriteLine("a soma de " + num1 + " e " + num2 + " é " + soma);
Console.WriteLine($"a subtração de {num1} e {num2} é de {subtracao}");
Console.WriteLine("A multiplicação de {0} e {1} é de {2}", num1, num2, multiplicacao);
Console.WriteLine("A divisão de {0} e {1} é de {2}", num1, num2, divisao);