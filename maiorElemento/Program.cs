using System;

class MaiorElemento
{
    static void Main()
    {
        int[] numeros = new int[10];

        //Recebe os valores e guarda no array
        for(int i =0 ; i <= numeros.Length ; i++)
        {
            Console.WriteLine("Digite Dez Numeros Intreiros");
            numeros[i] = int.Parse(Console.ReadLine());
        }
        
        //falta verificar o maior e posição
    }
}
