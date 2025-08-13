using System;
class MaiorMenor
{
    static void Main()
    {
        // Entrada de dados
        int numero1 = LerNumero("Digite o primeiro número:");
        int numero2 = LerNumero("Digite o segundo número:");
        int numero3 = LerNumero("Digite o terceiro número:");
        // Processamento
        int maior = CalcularMaior(numero1, numero2, numero3);
        int menor = CalcularMenor(numero1, numero2, numero3);
        // Saída de dados
        Console.WriteLine($"O maior número é: {maior}");
        Console.WriteLine($"O menor número é: {menor}");
        Console.WriteLine($"A média dos números é: {CalcularMedia(numero1, numero2, numero3)}");
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
    // Função para calcular o maior número
    static int CalcularMaior(int num1, int num2, int num3)
    {
        return Math.Max(num1, Math.Max(num2, num3));
    }

    // Função para calcular o menor número
    static int CalcularMenor(int num1, int num2, int num3)
    {
        return Math.Min(num1, Math.Min(num2, num3));
    }

    //Função que calcula a média
    static double CalcularMedia(int num1, int num2, int num3)
    {
        return (num1 + num2 + num3) / 3.0;

    }
}
