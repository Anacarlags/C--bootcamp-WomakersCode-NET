using System;

class ContaSenha
{
     static void Main()
    {
        

        Console.Write("Digite uma Senha: ");
        string senha = Console.ReadLine();

        //verifica primeiro se não é nulo ou espaço vazio digitado
        if (!string.IsNullOrWhiteSpace(senha)&& senha.Length >= 8)
        {
        
         Console.WriteLine($"Senha válida! Possui {senha.Length} caracteres.");
        }else
        {
         Console.WriteLine("Senha inválida! A senha precisa ter pelo menos 8 caracteres.");
        }
   }


}

