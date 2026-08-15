using System;

class Calcualdora
{
    static void Main()
    {
        
        double num1;
        double num2;

            Console.WriteLine("Digite o Primeiro Numero");
             num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Segundo Numero");
             num2 = double.Parse(Console.ReadLine());

            double soma = num1 + num2;
            double subtrai = num1 - num2;
            double multiplica = num1 * num2;
            double divide = num1 / num2 ;


            Console.WriteLine($"A Soma dos Numeros Eh: {soma}");
            Console.WriteLine($"A Subtração dos Numeros Eh: {subtrai:F2}");
            Console.WriteLine($"A Multiplicação dos Numeros Eh: {multiplica}");
            Console.WriteLine($"A Divisão dos Numeros Eh: {divide}");
            Console.WriteLine("---------------------------------------");

            

    }

}
