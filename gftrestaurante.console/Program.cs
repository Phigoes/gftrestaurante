using gftrestaurante.gerenciador;
using gftrestaurante.model;
using gftrestaurante.model.Interfaces;
using gftrestaurante.service;
using System;
using System.Collections.Generic;
using System.Linq;
using Unity;

namespace gftrestaurante.console
{
	public class Program
	{
		static void Main(string[] args)
		{
			UnityContainer UC = new UnityContainer();
			UC.RegisterType<PratoService>();
			UC.RegisterType<IPratoService,PratoService>();

			var service = UC.Resolve<PratoService>();

			Console.WriteLine("|-----------------------------|");
			Console.WriteLine("|  Bem vindo ao Restaurante!  |");
			Console.WriteLine("|-----------------------------|");
			Console.WriteLine(Environment.NewLine);
			while (true)
			{
				Console.WriteLine(Environment.NewLine);
				Console.WriteLine("|-----------------------------------|");
				Console.WriteLine("|  Digite 1 para realizar o pedido  |");
				Console.WriteLine("|  Digite 0 para sair               |");
				Console.WriteLine("|-----------------------------------|");
				Console.Write("==> ");
				var comando = Console.ReadLine();
				if (comando == "1")
				{
					Console.WriteLine("Digite o prato:");

					var prato = new Prato();
					string saida = string.Empty;

					var obterPedido = Console.ReadLine();
					var pedido = obterPedido.Split(',');
					pedido = pedido.Where(x => !string.IsNullOrEmpty(x)).ToArray();

					if (pedido[0].ToLower() != GerenciadorDeTiposDePrato.Morning && pedido[0].ToLower() != GerenciadorDeTiposDePrato.Night)
					{
						saida = "error";
					}
					else
					{
						prato.Tipo = pedido[0].ToLower();
						pedido = pedido.Skip(1).ToArray();
						Array.Sort(pedido);

						prato.Comidas = new List<Comida>();

						for (int ordem = 0; ordem < pedido.Length; ordem++)
						{
							var comida = new Comida();
							comida.Numero = pedido[ordem].Trim();
							prato.Comidas.Add(comida);
						}

						if (prato.Tipo == GerenciadorDeTiposDePrato.Morning)
						{
							saida = service.CriarPratoMorning(prato);
						}
						else if (prato.Tipo == GerenciadorDeTiposDePrato.Night)
						{
							saida = service.CriarPratoNight(prato);
						}
						else
						{
							saida = "error";
						}
					}

					Console.WriteLine(saida);
				}
				else if (comando == "0")
				{
					Environment.ExitCode = -1;
					break;
				}
				else
				{
					Console.WriteLine("Comando desconhecido");
				}
			}
		}
	}
}

