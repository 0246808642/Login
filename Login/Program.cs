using Login;
using static System.Net.Mime.MediaTypeNames;

Console.WriteLine("* Seja bem vindo a nossa plataforma * ");
Console.WriteLine();


Console.WriteLine("Você já possui ua conta? (S/N)");
char Ver =  char.Parse(Console.ReadLine());



if (Ver == 'S' | Ver == 's')
{
    Console.WriteLine("Entre com seu usário");
    Console.Write("Nome: ");
    string Name = Console.ReadLine();
    Console.WriteLine("Senha: ");
    string Senha = Console.ReadLine();
    if (Senha == "Caique")
    {
        Console.WriteLine("Seja bem vindo " + Name);
    }
    else
    {
        Console.WriteLine("Senha incorreta!!!,Tente novamente");
        Console.WriteLine("Você esqueceu a sua senha? ");
        char Res = char.Parse(Console.ReadLine());
        if (Res == 'S' | Res == 's')
        {
            Console.WriteLine("Mandaremos a sua senha no email registrado (Caique@*******)");
        }
        else if (Res == 'N' | Res == 'n')
        {
            Console.WriteLine("Tente novamente!");
        }
        else
        {
            Console.WriteLine("Por favor digite 'S' para sim, 'N' para não");
        }


    }


}
else if (Ver == 'N' | Ver == 'n')
{
    Console.WriteLine("Crie sua conta");
    Console.WriteLine("Digite seu email: ");
    var Email = Console.ReadLine();
    Console.WriteLine("Digite seu nome: ");
    string Nam = Console.ReadLine();
    Console.WriteLine(" Digite  sua senha: ");
    Console.WriteLine("pelo menos 3 letras e não verificamos numeros nem sinais");
    string Senh = Console.ReadLine();
    Console.WriteLine();

    Console.WriteLine("Entre com seu usário");
    Console.Write("Nome: ");
    string Name = Console.ReadLine();
    Console.WriteLine("Senha: ");
    string Senha = Console.ReadLine();
    if (Senha == "Caique")
    {
        Console.WriteLine("Seja bem vindo " + Name);
    }
    else
    {
        Console.WriteLine("Senha incorreta!!!,Tente novamente");
        Console.WriteLine("Você esqueceu a sua senha? ");
        char Res = char.Parse(Console.ReadLine());
        if (Res == 'S' | Res == 's')
        {
            Console.WriteLine("Mandaremos a sua senha no email registrado (Caique@*******)");
        }
        else if (Res == 'N' | Res == 'n')
        {
            Console.WriteLine("Tente novamente!");
        }
        else
        {
            Console.WriteLine("Por favor digite 'S' para sim, 'N' para não");



        }
    }
}
