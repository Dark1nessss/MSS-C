using System;

class Animal
{
    public string Nome { get; set; }
    public string Raca { get; set; }

    public Animal() {}

    public Animal(string nome, string raca)
    {
        Nome = nome;
        Raca = raca;
    }

    public virtual void Caminha()
    {
        Console.WriteLine($"{Nome} está a caminhar.");
    }
}

class Cachorro : Animal
{
    public Cachorro(string nome, string raca) : base(nome, raca) {}

    public void Latir()
    {
        Console.WriteLine($"{Nome} está a latir: Au au!");
    }
}

class Gato : Animal
{
    public Gato(string nome, string raca) : base(nome, raca) {}

    public void Miar()
    {
        Console.WriteLine($"{Nome} está a miar: Miau!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Cachorro cachorro = new Cachorro("Rex", "Pastor Alemão");
        Gato gato = new Gato("Mimi", "Siamês");

        cachorro.Latir();
        gato.Miar();
        cachorro.Caminha();
        gato.Caminha();
    }
}
