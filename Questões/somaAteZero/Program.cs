using System;

class SomaAteZero
{
    static void Main()
    {
        int soma = 0;
        
        while (true)
        {
            Console.Write("Digite um número Inteiro ou - 0 para sair): ");
            int numero = int.Parse(Console.ReadLine());
            
            //caso digite zero encerra o programa
            if (numero == 0) break;
             soma += numero;
        }
    
        Console.WriteLine($"Soma: {soma}");
        
    }
}