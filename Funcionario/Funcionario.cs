using System;

class Funcionario
{
    public string Nome { get; set; }
    public double Salario { get; protected set; }

    public Funcionario(string nome, double salario)
    {
        Nome = nome;
        Salario = salario;
    }

    public void AddAumento(double valor)
    {
        Salario += valor;
    }

    public virtual double GanhoAnual()
    {
        return Salario * 12;
    }

    public virtual void ExibeDados()
    {
        Console.WriteLine($"Nome: {Nome}, Salário: {Salario}");
    }
}

class Assistente : Funcionario
{
    public string NumeroMatricula { get; set; }

    public Assistente(string nome, double salario, string numeroMatricula)
        : base(nome, salario)
    {
        NumeroMatricula = numeroMatricula;
    }

    public override void ExibeDados()
    {
        Console.WriteLine($"Nome: {Nome}, Salário: {Salario}, Matrícula: {NumeroMatricula}");
    }
}

class Tecnico : Assistente
{
    public double BonusSalarial { get; set; }

    public Tecnico(string nome, double salario, string numeroMatricula, double bonusSalarial)
        : base(nome, salario, numeroMatricula)
    {
        BonusSalarial = bonusSalarial;
    }

    public override double GanhoAnual()
    {
        return (Salario + BonusSalarial) * 12;
    }
}

class Administrativo : Assistente
{
    public string Turno { get; set; }
    public double AdicionalNoturno { get; set; }

    public Administrativo(string nome, double salario, string numeroMatricula, string turno, double adicionalNoturno)
        : base(nome, salario, numeroMatricula)
    {
        Turno = turno;
        AdicionalNoturno = adicionalNoturno;
    }

    public override double GanhoAnual()
    {
        return Turno == "noite" ? (Salario + AdicionalNoturno) * 12 : base.GanhoAnual();
    }
}

class Program
{
    static void Main(string[] args)
    {

        Tecnico tecnico = new Tecnico("João", 2500, "12345", 500);
        tecnico.ExibeDados();
        Console.WriteLine($"Ganho Anual: {tecnico.GanhoAnual()}");


        Administrativo admin = new Administrativo("Maria", 2000, "67890", "noite", 300);
        admin.ExibeDados();
        Console.WriteLine($"Ganho Anual: {admin.GanhoAnual()}");
    }
}
