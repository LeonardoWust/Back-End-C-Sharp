public class Pessoa
{
    public string? nome;

    private int idade;


    public Pessoa(string novoNome)
    {
        nome = novoNome;

    }

    // public Pessoa()
    // {
        
    // }

    public void falar()
    {
        Console.WriteLine($"Meu nome é: {nome}, e tenho {idade}");
    }

    public int GetIdade()
    {
        return idade;
    }

    public void SetIdade(int novaIdade)
    {
        if (idade >= 0)
        {
            idade = novaIdade;
        }
        else
        {
            Console.WriteLine("Valor inválido");
        }
    }

}

