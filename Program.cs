using System;

namespace PrimeiroExemploPraticoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            char inputUsuario;
            do
            {
                inputUsuario = showMenu();

                switch (inputUsuario)
                {
                    case '1':

                        break;
                    case '2':

                        break;
                    case '3':

                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

            } while (inputUsuario != '4');
        }

        private static char showMenu()
        {
            char inputUsuario;
            Console.WriteLine("Informe a opção desejada: ");
            Console.WriteLine("1 - Inserir Alunos novos");
            Console.WriteLine("2 - Listar Alunos");
            Console.WriteLine("3 - Calcular média geral");
            Console.WriteLine("4- Sair\n");

            inputUsuario = Console.ReadLine()[0];
            return inputUsuario;
        }
    }
}
