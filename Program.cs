using System;

namespace DIO_Cadastro_Series_dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        private static string ObterOpcaoUsuario() {
            Console.WriteLine();
            Console.WriteLine("Will Séries a seu dispor!");
            Console.WriteLine("Informe a opção desejada:");

            Console.WriteLine("1 - Listar séries.");
            Console.WriteLine("2 - Inserir nova série.");
            Console.WriteLine("3 - Atualizar série.");
            Console.WriteLine("4 - Excluir série.");
            Console.WriteLine("5 - Visualizar série.");
            Console.WriteLine("C - Limpar tela.");
            Console.WriteLine("X - Sair.");

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            
            return opcaoUsuario;
        }
    }
}
