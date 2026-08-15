using System;

class Program
{
    static void Main()
    {
        // Solicita o primeiro número
        Console.WriteLine("Digite o primeiro número:");
        int numero1 = int.Parse(Console.ReadLine());
        
        // Solicita o segundo número
        Console.WriteLine("Digite o segundo número:");
        int numero2 = int.Parse(Console.ReadLine());
        
        // Calcula a soma
        int soma = numero1 + numero2;
        
        // Exibe o resultado no formato esperado
        Console.WriteLine($"A soma é {soma}.");
    }
}
