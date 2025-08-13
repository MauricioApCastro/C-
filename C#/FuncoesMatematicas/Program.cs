using System;
class FuncoesMatematicas
{
    static void Main()
    {
        // Entrada de dados
        int numero1 = LerNumero("Digite o primeiro número:");
        int numero2 = LerNumero("Digite o segundo número:");



    }
}        // Processamento
int soma = Somar(numero1, numero2);
int subtracao = Subtrair(numero1, numero2);
int multiplicacao = Multiplicar(numero1, numero2);
double divisao = Dividir(numero1, numero2);
// Saída de dados
Console.WriteLine($"A soma é: {soma}");
Console.WriteLine($"A subtração é: {subtracao}");
Console.WriteLine($"A multiplicação é: {multiplicacao}");
if (numero2 != 0)
    Console.WriteLine($"A divisão é: {divisao}");
else
    Console.WriteLine("Divisão por zero não é permitida.");
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
// Função para somar dois números
static int Somar(int num1, int num2)
{
    return num1 + num2;
}
// Função para subtrair dois números
static int Subtrair(int num1, int num2)
{
    return num1 - num2;
}
// Função para multiplicar dois números
static int Multiplicar(int num1, int num2)
{
    return num1 * num2;
}
// Função para dividir dois números
static double Dividir(int num1, int num2)
{
    if (num2 == 0)
        throw new DivideByZeroException("Divisão por zero não é permitida.");
    return (double)num1 / num2;
}