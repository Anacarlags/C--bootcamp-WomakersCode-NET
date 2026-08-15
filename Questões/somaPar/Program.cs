using System;


class SomaPares
{
    static void Main()
    {
        //soma de todos os números pares entre 1 e 100
        int soma = 0;
        Console.WriteLine($"\n--- Soma Dos Pares entre 1 e 100 ---");
        for (int i = 1; i <= 100; i++)
        {
            //Verifica se o numero é par
            if (i % 2 == 0)
            {
                 //Acumula o valor de i e soma + 1
                  soma += i; 
            }
           
        }
         Console.WriteLine(soma);

    }
}