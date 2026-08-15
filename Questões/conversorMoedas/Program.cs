// Leia um valor em reais e a cotação do dólar.

using System;

    class Conversor
    {
        static void Main()
    {
        //Ler Valor da Cotação Hoje
        Console.WriteLine("Digite a Cotação do Dolar Hoje");
        double dolar = double.Parse(Console.ReadLine());

        //Ler Valor Em Reais
        Console.WriteLine("Digite Valor em Reais");
        double real = double.Parse(Console.ReadLine());

        double valorRealEmDolar = dolar*real;

        Console.WriteLine($"O Valor {real} em Dolar é {valorRealEmDolar}");
    }
}

