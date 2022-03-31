using System;

namespace catalogo.jogos
{
    class Program
    {
        static JogosRepositorio repositorio = new JogosRepositorio();
        static void Main(string[]args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();
            while (opcaoUsuario.ToUpper() != "X")
			{
				switch (opcaoUsuario)
				{
                    case "1":
						ListarJogos();
						break;
					case "2":
						InserirJogos();
						break;
					case "3":
						AtualizarJogos();
						break;
					case "4":
						ExcluirJogos();
						break;
					case "5":
						VisualizarJogos();
						break;
					case "C":
						Console.Clear();
						break;

					default:
						throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = ObterOpcaoUsuario();
            }
            Console.WriteLine("Obrigado por utilizar nossos serviços, volte sempre :)");
			Console.ReadLine();
        }
         private static void ExcluirJogos()
		{
			Console.Write("Digite o id do jogo: ");
			int indiceJogo = int.Parse(Console.ReadLine());

			repositorio.Exclui(indiceJogo);
		}

        private static void VisualizarJogo()
		{
			Console.Write("Digite o id do jogo: ");
			int indiceJogo = int.Parse(Console.ReadLine());

			var jogo = repositorio.RetornaPorId(indiceJogo);

			Console.WriteLine(jogo);
		}
		private static void AtualizarJogos()
		{
			Console.Write("Digite o Id do Jogo: ");
			int indiceJogo = int.Parse(Console.ReadLine());

			foreach ( int i in Enum.GetValues(typeof(Genero), i));
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
			}

			Console.Write("Digite o gênero entre as opções acima: ");
			int entradaGenero = int.Parse(Console.ReadLine());

			Console.Write("Digite o Nome do jogo: ");
			string entradaNome = Console.ReadLine();

			Console.Write("Digite o Ano de Início do jogo: ");
			int entradaAno = int.Parse(Console.ReadLine());

			Console.Write("Digite a Descrição do jogo: ");
			string entradaDescricao = Console.ReadLine();

			Jogo AtualizarJogos = new Serie(id: indiceJogo,
										genero: (Genero)entradaGenero,
										nome: entradaNome,
										ano: entradaAno,
										descricao: entradaDescricao);

			repositorio.Atualiza(indiceJogo, AtualizarJogos);
		}
		private static void ListarJogos()
		{
			Console.WriteLine("Lista de Jogos");
			var lista = repositorio.Lista();

			if (lista.Count == 0)
			{
				Console.WriteLine("Nenhum jogo Cadastrado");
				return;
			}
			foreach(var jogo in lista)
			{
				var excluido = jogo.retornaExcluido();
				Console.WriteLine("#ID {0}: - {1} {2}", jogo.retornaId(), jogo.retornaNome(), (excluido ? "*Excluído*" : ""));
			}
		}
		private static void InserirJogos()
		{
			Console.WriteLine("Incerir Jogos");
			foreach (int i in Enum.GetValues(typeof(Genero)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
			}
			
			Console.Write("Digite o gênero entre as opções acima: ");
			int entradaGenero = int.Parse(Console.ReadLine());

			Console.Write("Digite o Nome do jogo: ");
			string entradaNome = Console.ReadLine();

			Console.Write("Digite o Ano de Início do jogo: ");
			int entradaAno = int.Parse(Console.ReadLine());

			Console.Write("Digite a Descrição do jogo: ");
			string entradaDescricao = Console.ReadLine();

			Jogo novoJogo = new Serie(id: indiceJogo,
										genero: (Genero)entradaGenero,
										nome: entradaNome,
										ano: entradaAno,
										descricao: entradaDescricao);

			repositorio.Incerir(novoJogo);
		}
		private static string ObterOpcaoUsuario()
		{
			Console.WriteLine();
			Console.WriteLine("DIO Jogos a seu dispor!!!");
			Console.WriteLine("Informe a opção desejada:");

			Console.WriteLine("1- Meus jogos");
			Console.WriteLine("2- Novo jogo");
			Console.WriteLine("3- Atualizar jogo");
			Console.WriteLine("4- Excluir jogo");
			Console.WriteLine("5- Visualizar jogo");
			Console.WriteLine("C- Limpar Tela");
			Console.WriteLine("X- Sair");
			Console.WriteLine();

			string opcaoUsuario = Console.ReadLine().ToUpper();
			Console.WriteLine();
			return opcaoUsuario;
		}
    }
}
