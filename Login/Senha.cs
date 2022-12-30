

using System.Runtime.CompilerServices;

namespace Login
{
    internal class Senha
    {
        public char Escolha { get; set; }
        public bool SenhaSec { get; set; }

        public Senha(char escolha)
        {
            Escolha = escolha;
        }



        public static void Verificação(char escolha)
        {
            if (escolha == 'S' | escolha == 's')
            {

                Console.WriteLine("Entre com o seu usário e senha:");
            }
            else if (escolha == 'N' | escolha == 'n')
            {
                Console.WriteLine(escolha.ToString());
                Console.WriteLine(" * Vamos cria sua conta * ");

            }
            else
            {
                Console.WriteLine("Por favor digite 'S' para sim e 'N' para não");
            }







        }

    }
}
