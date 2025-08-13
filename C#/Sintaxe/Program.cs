using System;

class NomeIdade
{
    static void Main()
    {
        // Entrada de dados
        string nome = LerTexto("Qual o seu nome?");
        int idade = LerNumero("Qual a sua idade?");
        string cidade = LerTexto("Qual a sua cidade?");

        // Processamento
        int anoNascimento = CalcularAnoNascimento(idade);
        string maioridade = VerificarMaioridade(idade);

        // Saída de dados
        Console.WriteLine($"Olá, {nome} de {cidade}! Você tem {idade} anos, nasceu em {anoNascimento} e {maioridade}.");
    }

    // Função para ler texto
    static string LerTexto(string mensagem)
    {
        Console.WriteLine(mensagem);
        return Console.ReadLine()!;
    }

    // Função para ler número com validação
    static int LerNumero(string mensagem)
    {
        int numero;
        Console.WriteLine(mensagem);
        while (!int.TryParse(Console.ReadLine(), out numero))
        {
            Console.WriteLine("Por favor, digite um número válido:");
        }
        return numero;
    }

    // Função para calcular ano de nascimento
    static int CalcularAnoNascimento(int idade)
    {
        return DateTime.Now.Year - idade;
    }

    // Função para verificar maioridade
    static string VerificarMaioridade(int idade)
    {
        return idade >= 18 ? "é maior de idade" : "é menor de idade";
    }
}
