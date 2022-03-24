var password = "2018";

string userInput = Console.ReadLine();

while (userInput != password)
{
    Console.WriteLine("Senha inválida");
    userInput = Console.ReadLine();
}

Console.WriteLine("Acesso permitido");
