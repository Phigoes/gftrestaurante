using gftrestaurante.gerenciador;
using gftrestaurante.model;
using gftrestaurante.model.Interfaces;
using gftrestaurante.service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Unity;

namespace gftrestaurante.test
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var UC = new UnityContainer();
			UC.RegisterType<PratoService>();
			UC.RegisterType<IPratoService, PratoService>();

			var service = UC.Resolve<PratoService>();

			Prato prato = new Prato();
			prato.Comidas = new List<Comida>();

			prato.Tipo = GerenciadorDeTiposDePrato.Morning;
			prato.Comidas.Add(new Comida { Numero = GerenciadorDeTiposDeEntrada.Eggs });
			prato.Comidas.Add(new Comida { Numero = GerenciadorDeTiposDeAcompanhamento.Toast });
			prato.Comidas.Add(new Comida { Numero = GerenciadorDeTiposDeBebida.Coffee });

			var saida = service.CriarPratoMorning(prato);

			Console.WriteLine(saida);
		}

		[TestMethod]
		public void TestMethod2()
		{
			var UC = new UnityContainer();
			UC.RegisterType<PratoService>();
			UC.RegisterType<IPratoService, PratoService>();

			var service = UC.Resolve<PratoService>();

			Prato prato = new Prato();
			prato.Comidas = new List<Comida>();

			prato.Tipo = GerenciadorDeTiposDePrato.Morning;
			prato.Comidas.Add(new Comida { Numero = GerenciadorDeTiposDeAcompanhamento.Toast });
			prato.Comidas.Add(new Comida { Numero = GerenciadorDeTiposDeEntrada.Eggs });
			prato.Comidas.Add(new Comida { Numero = GerenciadorDeTiposDeBebida.Coffee });

			var saida = service.CriarPratoMorning(prato);

			Console.WriteLine(saida);
		}

		[TestMethod]
		public void TestMethod3()
		{
			var UC = new UnityContainer();
			UC.RegisterType<PratoService>();
			UC.RegisterType<IPratoService, PratoService>();

			var service = UC.Resolve<PratoService>();

			Prato prato = new Prato();
			prato.Comidas = new List<Comida>();

			prato.Tipo = GerenciadorDeTiposDePrato.Morning;
			prato.Comidas.Add(new Comida { Numero = GerenciadorDeTiposDeEntrada.Eggs });
			prato.Comidas.Add(new Comida { Numero = GerenciadorDeTiposDeAcompanhamento.Toast });
			prato.Comidas.Add(new Comida { Numero = GerenciadorDeTiposDeBebida.Coffee });
			prato.Comidas.Add(new Comida { Numero = "4" });

			var saida = service.CriarPratoMorning(prato);

			Console.WriteLine(saida);
		}

		[TestMethod]
		public void TestMethod4()
		{
			var UC = new UnityContainer();
			UC.RegisterType<PratoService>();
			UC.RegisterType<IPratoService, PratoService>();

			var service = UC.Resolve<PratoService>();

			Prato prato = new Prato();
			prato.Comidas = new List<Comida>();

			prato.Tipo = GerenciadorDeTiposDePrato.Morning;
			prato.Comidas.Add(new Comida { Numero = GerenciadorDeTiposDeEntrada.Eggs });
			prato.Comidas.Add(new Comida { Numero = GerenciadorDeTiposDeAcompanhamento.Toast });
			prato.Comidas.Add(new Comida { Numero = GerenciadorDeTiposDeBebida.Coffee });
			prato.Comidas.Add(new Comida { Numero = GerenciadorDeTiposDeBebida.Coffee });
			prato.Comidas.Add(new Comida { Numero = GerenciadorDeTiposDeBebida.Coffee });

			var saida = service.CriarPratoMorning(prato);

			Console.WriteLine(saida);
		}

		[TestMethod]
		public void TestMethod5()
		{
			Prato prato = new Prato();
			prato.Comidas = new List<Comida>();

			prato.Tipo = GerenciadorDeTiposDePrato.Night;
			prato.Comidas.Add(new Comida { Numero = GerenciadorDeTiposDeEntrada.Steak });
			prato.Comidas.Add(new Comida { Numero = GerenciadorDeTiposDeAcompanhamento.Potato});
			prato.Comidas.Add(new Comida { Numero = GerenciadorDeTiposDeBebida.Wine });
			prato.Comidas.Add(new Comida { Numero = GerenciadorDeTiposDeSobremesa.Bolo });

			var service = new PratoService();
			var saida = service.CriarPratoNight(prato);

			Console.WriteLine(saida);
		}

		[TestMethod]
		public void TestMethod6()
		{
			var UC = new UnityContainer();
			UC.RegisterType<PratoService>();
			UC.RegisterType<IPratoService, PratoService>();

			var service = UC.Resolve<PratoService>();

			Prato prato = new Prato();
			prato.Comidas = new List<Comida>();

			prato.Tipo = GerenciadorDeTiposDePrato.Night;
			prato.Comidas.Add(new Comida { Numero = GerenciadorDeTiposDeEntrada.Steak });
			prato.Comidas.Add(new Comida { Numero = GerenciadorDeTiposDeAcompanhamento.Potato });
			prato.Comidas.Add(new Comida { Numero = GerenciadorDeTiposDeAcompanhamento.Potato });
			prato.Comidas.Add(new Comida { Numero = GerenciadorDeTiposDeSobremesa.Bolo });

			var saida = service.CriarPratoNight(prato);

			Console.WriteLine(saida);
		}

		[TestMethod]
		public void TestMethod7()
		{
			var UC = new UnityContainer();
			UC.RegisterType<PratoService>();
			UC.RegisterType<IPratoService, PratoService>();

			var service = UC.Resolve<PratoService>();

			Prato prato = new Prato();
			prato.Comidas = new List<Comida>();

			prato.Tipo = GerenciadorDeTiposDePrato.Night;
			prato.Comidas.Add(new Comida { Numero = GerenciadorDeTiposDeEntrada.Steak });
			prato.Comidas.Add(new Comida { Numero = GerenciadorDeTiposDeAcompanhamento.Potato });
			prato.Comidas.Add(new Comida { Numero = GerenciadorDeTiposDeBebida.Wine });
			prato.Comidas.Add(new Comida { Numero = "5" });

			var saida = service.CriarPratoNight(prato);

			Console.WriteLine(saida);
		}

		[TestMethod]
		public void TestMethod8()
		{
			var UC = new UnityContainer();
			UC.RegisterType<PratoService>();
			UC.RegisterType<IPratoService, PratoService>();

			var service = UC.Resolve<PratoService>();

			Prato prato = new Prato();
			prato.Comidas = new List<Comida>();

			prato.Tipo = GerenciadorDeTiposDePrato.Night;
			prato.Comidas.Add(new Comida { Numero = GerenciadorDeTiposDeEntrada.Steak });
			prato.Comidas.Add(new Comida { Numero = GerenciadorDeTiposDeEntrada.Steak });
			prato.Comidas.Add(new Comida { Numero = GerenciadorDeTiposDeAcompanhamento.Potato });
			prato.Comidas.Add(new Comida { Numero = GerenciadorDeTiposDeBebida.Wine });
			prato.Comidas.Add(new Comida { Numero = "5" });

			var saida = service.CriarPratoNight(prato);

			Console.WriteLine(saida);
		}
	}
}
