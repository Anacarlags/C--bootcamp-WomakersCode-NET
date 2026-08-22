using System;

class ContaCaracteres
{
     static void Main()
    {
        

        Console.Write("Digite um nome: ");
        string nome = Console.ReadLine();

        //verifica primeiro se não é nulo ou espaço vazio digitado
        if (!string.IsNullOrWhiteSpace(nome))
        {
        //  .Length retorna a quantidade total de caracteres
        Console.WriteLine($"O nome \"{nome}\" possui {nome.Length} caracteres.");
        }
   }


}

