using System;

class Ingresso
{
    public double Valor { get; set; }

    public Ingresso(double valor)
    {
        Valor = valor;
    }

    public virtual void ImprimeValor()
    {
        Console.WriteLine($"Valor do ingresso: {Valor} euros");
    }
}

class VIP : Ingresso
{
    public double ValorAdicional { get; set; }

    public VIP(double valor, double valorAdicional) : base(valor)
    {
        ValorAdicional = valorAdicional;
    }

    public double ValorVIP()
    {
        return Valor + ValorAdicional;
    }

    public override void ImprimeValor()
    {
        Console.WriteLine($"Valor do ingresso VIP: {ValorVIP()} euros");
    }
}

class Normal : Ingresso
{
    public Normal(double valor) : base(valor) {}

    public override void ImprimeValor()
    {
        Console.WriteLine("Ingresso Normal");
        base.ImprimeValor();
    }
}

class CamaroteInferior : VIP
{
    public string Localizacao { get; set; }

    public CamaroteInferior(double valor, double valorAdicional, string localizacao) 
        : base(valor, valorAdicional)
    {
        Localizacao = localizacao;
    }

    public void ImprimeLocalizacao()
    {
        Console.WriteLine($"Localização: {Localizacao}");
    }
}

class CamaroteSuperior : VIP
{
    public CamaroteSuperior(double valor, double valorAdicional) 
        : base(valor, valorAdicional) {}

    public override void ImprimeValor()
    {
        Console.WriteLine($"Valor do ingresso Camarote Superior: {ValorVIP()} euros");
    }
}

class Program
{
    static void Main(string[] args)
    {

        Normal ingressoNormal = new Normal(100);
        ingressoNormal.ImprimeValor();

        VIP ingressoVIP = new VIP(150, 50);
        ingressoVIP.ImprimeValor();

        CamaroteInferior camaroteInferior = new CamaroteInferior(200, 80, "Setor A");
        camaroteInferior.ImprimeValor();
        camaroteInferior.ImprimeLocalizacao();

        CamaroteSuperior camaroteSuperior = new CamaroteSuperior(250, 100);
        camaroteSuperior.ImprimeValor();
    }
}
