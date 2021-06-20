using System;

namespace DIO_Cadastro_Series_dotnet
{
    class Program
    {
        static SeriesRepositorio repositorio = new SeriesRepositorio();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X") {
                switch (opcaoUsuario) {
                    case "1" :
                        ListarSeries();
                        break;
                    case "2" :
                        InserirSerie();
                        break;
                    case "3" :
                        AtualizarSerie();
                        break;
                    case "4" :
                        ExcluirSerie();
                        break;
                    case "5" :
                        VisualizarSerie();
                        break;
                    case "C" :
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = ObterOpcaoUsuario();       
            }
        }

        private static void VisualizarSerie()
        {
            Console.WriteLine("Digite o id da série: ");
            int idEntrada = int.Parse(Console.ReadLine());

            var serie = repositorio.RetornaPorId(idEntrada);

            Console.WriteLine(serie);
        }

        private static void ExcluirSerie()
        {
            Console.WriteLine("Digite o id da série: ");
            int idEntrada = int.Parse(Console.ReadLine());

            repositorio.Exclui(idEntrada);
        }

        private static void AtualizarSerie()
        {
            Console.WriteLine("Digite o id da série: ");
            int idEntrada = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Genero))) {
                Console.WriteLine($"{i} - {Enum.GetName(typeof(Genero), i)}");
            }
            Console.WriteLine("Digite o gênero entre as opçãoes acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Título da série: ");
            string entradaTitulo = Console.ReadLine();

            Console.WriteLine("Digite o ano de início da série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a descrição da série: ");
            string entradaDescricao = Console.ReadLine();

            Serie atualizaSerie = new Serie(id: idEntrada,
                                        genero: (Genero) entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao);
            
            repositorio.Atualiza(idEntrada , atualizaSerie);
        }

        private static void InserirSerie()
        {
            foreach (int i in Enum.GetValues(typeof(Genero))) {
                Console.WriteLine($"{i} - {Enum.GetName(typeof(Genero), i)}");
            }
            Console.WriteLine("Digite o gênero entre as opçãoes acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Título da série: ");
            string entradaTitulo = Console.ReadLine();

            Console.WriteLine("Digite o ano de início da série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a descrição da série: ");
            string entradaDescricao = Console.ReadLine();

            Serie novaSerie = new Serie(id: repositorio.ProximoId(),
                                        genero: (Genero) entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao);
            
            repositorio.Insere(novaSerie);
        }

        private static void ListarSeries()
        {
            var lista = repositorio.Lista();

            if (lista.Count == 0) {
                Console.WriteLine("Nenhuma série cadastrada.");
            } else {
                foreach (var serie in lista) {
                    Console.WriteLine($"Id: {serie.retornaId()} - {serie.retornaTitulo()}");
                }
            }
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
