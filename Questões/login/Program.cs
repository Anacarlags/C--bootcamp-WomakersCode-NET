using System;

class Login
{ static void Main()
    {// Aqui eu optei por já definir o login e senha
        string usuarioCorreto = "admin";
        string senhaCorreta = "12345678";

        Console.WriteLine("=== TELA DE LOGIN ===");

        // Pede o nome de usuário
        Console.Write("Digite o usuário Cadastrado: ");
        string usuarioDigitado = Console.ReadLine();

        // Pede a senha
        Console.Write("Digite a senha: ");
        string senhaDigitada = Console.ReadLine();

        // Compara os dados digitados com os corretos
        if (usuarioDigitado == usuarioCorreto && senhaDigitada == senhaCorreta)
        {
            Console.WriteLine("\nLogin realizado com sucesso! Bem-vindo.");
        }
        else
        {
            Console.WriteLine("\nUsuário ou senha incorretos. Acesso negado.");
        }

        Console.WriteLine("\nPressione qualquer tecla para sair.");
        Console.ReadKey();

    }
}