Pessoa p1 = new Pessoa("Leo"); //instancia

p1.nome = "Leo";
p1.SetIdade(23);

int idade = p1.GetIdade();

Console.WriteLine(idade);

p1.falar();

Pessoa p2 = new Pessoa("Luiza");

p2.nome = "Luiza";
p2.SetIdade(43);
Console.WriteLine(p2.GetIdade());

p1.falar();

//Pessoa p3 = new Pessoa();

PessoaFisica pf = new PessoaFisica("Anderson");

pf.SetIdade(30);
pf.nome = "Alterar";

pf.falar();

PessoaJuridica pj = new PessoaJuridica("Loja Master");
pj.SetIdade(5);
pj.falar();