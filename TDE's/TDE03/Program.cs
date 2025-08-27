double saldo = 1000.00;
int opcao;



do
{
    Console.WriteLine("Bem-Vindo ao nosso sistema de caixa moderno");
    Console.WriteLine("Digite a opção desejada");
    Console.WriteLine("1 - Ver saldo");
    Console.WriteLine("2 - Sacar");
    Console.WriteLine("3 - Depositar");
    Console.WriteLine("4 - Sair");
    opcao = Convert.ToInt32(Console.ReadLine());
    switch (opcao)
    {
        case 1:
            Console.WriteLine($"Seu saldo é de: {saldo}");
            break;
        case 2:
            Console.WriteLine("Qual valor do saldo?");
            double valorSaque = Convert.ToDouble(Console.ReadLine());
            if (valorSaque > saldo)
            {
                Console.WriteLine("Saldo Insuficiente para saque");
            }
            else
            {
                saldo -= valorSaque;
                Console.WriteLine($"Você sacou {valorSaque}");
            }
            break;
        case 3:
            Console.WriteLine("Qual valor do depósito");
            double valorDeposito = Convert.ToDouble(Console.ReadLine());
            saldo += valorDeposito;
            break;
        case 4:
            Console.WriteLine("Encerrando Sistema!");
            break;
        default:
            Console.WriteLine("Pressione uma tecla válida tanso!");
            break;

    }

} while (opcao != 4) ;