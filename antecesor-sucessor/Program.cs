using System;

class Program
{
    
    static void Main()
    {
        Console.WriteLine("Digite Um Número:");
        double numero = double.Parse(Console.ReadLine());

        double antecessor = numero-1;
        double sucesor = numero +1;

         Console.WriteLine($"O Antecessor  é {antecessor}");
         Console.WriteLine($"O Seu Numero é  {numero}.");
         Console.WriteLine($"O Sucessor  é {sucesor}.");
    }
}
