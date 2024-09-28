using System;

class Program
{
    static void Main(string[] args)
    {
        // a. Assistente administrativo e técnico
        Administrativo admin = new Administrativo("Pedro", 2000, "1234", "noite", 300);
        Tecnico tecnico = new Tecnico("Ana", 2500, "5678", 500);

        Console.WriteLine($"Assistente Administrativo: {admin.Nome}, Matrícula: {admin.NumeroMatricula}");
        Console.WriteLine($"Técnico: {tecnico.Nome}, Matrícula: {tecnico.NumeroMatricula}");

        // b. Cao e Gato
        Cachorro cachorro = new Cachorro("Rex", "Pastor Alemão");
        Gato gato = new Gato("Mimi", "Siamês");

        cachorro.Latir();
        gato.Miar();
        cachorro.Caminhar();
        gato.Caminhar();

        // c. Testando classes Rica, Pobre e Miseravel
        Rica pessoaRica = new Rica("João", 40, 1000000);
        Pobre pessoaPobre = new Pobre("Maria", 30);
        Miseravel pessoaMiseravel = new Miseravel("José", 50);

        pessoaRica.FazCompras();
        pessoaPobre.Trabalha();
        pessoaMiseravel.Mendiga();

        // d. Testando Ingresso
        Console.WriteLine("Digite 1 para Ingresso Normal ou 2 para VIP:");
        int tipoIngresso = Convert.ToInt32(Console.ReadLine());

        if (tipoIngresso == 1)
        {
            Normal ingressoNormal = new Normal(100);
            ingressoNormal.ImprimeValor();
        }
        else if (tipoIngresso == 2)
        {
            Console.WriteLine("Digite 1 para Camarote Superior ou 2 para Camarote Inferior:");
            int tipoCamarote = Convert.ToInt32(Console.ReadLine());

            if (tipoCamarote == 1)
            {
                CamaroteSuperior camaroteSuperior = new CamaroteSuperior(200, 100);
                camaroteSuperior.ImprimeValor();
            }
            else
            {
                CamaroteInferior camaroteInferior = new CamaroteInferior(150, 80, "Setor VIP");
                camaroteInferior.ImprimeValor();
                camaroteInferior.ImprimeLocalizacao();
            }
        }

        // e. Testando Imovel
        Console.WriteLine("Digite 1 para Imóvel Novo ou 2 para Imóvel Velho:");
        int tipoImovel = Convert.ToInt32(Console.ReadLine());

        if (tipoImovel == 1)
        {
            Novo imovelNovo = new Novo("Rua Nova", 300000, 20000);
            imovelNovo.ImprimePreco();
        }
        else
        {
            Velho imovelVelho = new Velho("Rua Velha", 250000, 15000);
            imovelVelho.ImprimePreco();
        }
    }
}