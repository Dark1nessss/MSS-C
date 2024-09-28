using System;

class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
}

class Rica : Pessoa
{
    public double Dinheiro { get; set; }

    public Rica(string nome, int idade, double dinheiro) : base(nome, idade)
    {
        Dinheiro = dinheiro;
    }

    public void FazCompras()
    {
        Console.WriteLine($"{Nome}, que tem {Dinheiro} euros, está a fazer compras.");
    }
}

class Pobre : Pessoa
{
    public Pobre(string nome, int idade) : base(nome, idade) {}

    public void Trabalha()
    {
        Console.WriteLine($"{Nome} está a trabalhar.");
    }
}

class Miseravel : Pessoa
{
    public Miseravel(string nome, int idade) : base(nome, idade) {}

    public void Mendiga()
    {
        Console.WriteLine($"{Nome} está a mendigar.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Rica pessoaRica = new Rica("João", 40, 1000000);
        Pobre pessoaPobre = new Pobre("Maria", 30);
        Miseravel pessoaMiseravel = new Miseravel("José", 50);

        pessoaRica.FazCompras();
        pessoaPobre.Trabalha();
        pessoaMiseravel.Mendiga();
    }
}
