using System;

class Imovel
{
    public string Endereco { get; set; }
    public double Preco { get; set; }

    public Imovel(string endereco, double preco)
    {
        Endereco = endereco;
        Preco = preco;
    }

    public virtual void ImprimePreco()
    {
        Console.WriteLine($"Endereço: {Endereco}, Preço: {Preco} reais");
    }
}

class Novo : Imovel
{
    public double Adicional { get; set; }

    public Novo(string endereco, double preco, double adicional) 
        : base(endereco, preco)
    {
        Adicional = adicional;
    }

    public override void ImprimePreco()
    {
        Console.WriteLine($"Endereço: {Endereco}, Preço com adicional: {Preco + Adicional} reais");
    }
}

class Velho : Imovel
{
    public double Desconto { get; set; }

    public Velho(string endereco, double preco, double desconto) 
        : base(endereco, preco)
    {
        Desconto = desconto;
    }

    public override void ImprimePreco()
    {
        Console.WriteLine($"Endereço: {Endereco}, Preço com desconto: {Preco - Desconto} reais");
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        Novo imovelNovo = new Novo("Rua A", 300000, 20000);
        imovelNovo.ImprimePreco();

        Velho imovelVelho = new Velho("Rua B", 250000, 15000);
        imovelVelho.ImprimePreco();
    }
}
