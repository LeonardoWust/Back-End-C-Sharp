public class PortaMoedas
{
    // 1. O DADO REAL (PRIVADO)
    // O dinheiro real fica "escondido" e protegido aqui.
    // O underline "_" é uma convenção para indiar que uma variável é privada.
    private decimal _dinheiro;

    // 2. A PRORPIEDADE PÚBLICA (O PONTO DE ACESSO)
    // Esta é a "janelinha" e a "ranhura" do nosso porta-moedas.
    public decimal Dinheiro
    {
        // O GET (LEITOR): Simplesmente devolve o valor que está guardado
        get
        {
            return _dinheiro;
        }

        // O SET (GUARDIÃO): Protege nosso dado antes de alterá-lo
        set
        {
            // 'value' é uma palavra-chave especial que contém o valor
            // que estão tentando colocar (ex: 100, ou -50).

            // AQUI ESTÁ A MÁGICA: Nós criamos uma REGRA!
            if (value >= 0)
            {
                _dinheiro = value; // Se a regra for cumprida, atualiza o valor real.
            }
            else
            {
                //Opcional: Podemos avisar que o valor foi ignorado.
                Console.WriteLine("Não é possivel ter dinheiro negativo!");
            }
        }
    }
}



public class Program {
    public static void Main(string[] args)
    {
        PortaMoedas meuPortaMoedas = new PortaMoedas();

        // 1. USANDO O 'SET' para definir valor
        Console.WriteLine("Tentando colocar 50 reais...");
        meuPortaMoedas.Dinheiro = 50; // Isso ativa o 'set'. O valor 50 é valido e é aceito

        // 2. USANDO O 'GET' para ler o valor
        // A linha abaixo ativa o 'get' para nos mostrar o valor guardado.
        Console.WriteLine("Dinheiro atual: R$" + meuPortaMoedas.Dinheiro);
        Console.WriteLine("-------------------------");

        // 3. TENTANDO QUEBRAR A REGRA
        Console.WriteLine("Agora, tentando colocar -25 reais...");
        meuPortaMoedas.Dinheiro = -25;

        // 4 VERIFICANDO O VALOR NOVAMENTE
        // O 'get' vai mostrar que o valor não mudou, pois a regra no 'set' nos protegeu
        Console.WriteLine("Dinheiro atual R$:" + meuPortaMoedas.Dinheiro);
    }
}