// public class Veiculo
// {
//     public int Velocidade { get; set; } // atributo que foi herdado
//     public void Mover() // método que foi herdado 
//     {
//         Console.WriteLine("O veículo está se movendo"); //o que o método vai executar
//     }
    
// }

// public class Carro : Veiculo  // carro herdando de veiculo
// {
//     public string Modelo { get; set; } //carro herdou de veiculo e adicionou mais um atributo
// }

// class Program
// {
//     static void Main(string[] args) //o codigo sera rodadod aqui
//     {
//     Carro meuCarro = new Carro(); // criação do objeto para a definição dos atributos herdados
//     meuCarro.Velocidade = 120; // definição do atributo
//     meuCarro.Modelo = "Sedan"; // definição do atributo
//     meuCarro.Mover(); // método 
//     Console.WriteLine(meuCarro.Modelo);
//     }
// }