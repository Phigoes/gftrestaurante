using gftrestaurante.gerenciador;
using gftrestaurante.helper;
using gftrestaurante.model;
using gftrestaurante.model.Interfaces;
using System;
using System.Linq;

namespace gftrestaurante.service
{
	public class PratoService : IPratoService
	{
		public string CriarPratoMorning(Prato prato)
		{
			var saida = string.Empty;
			int quantidadeEggs = prato.Comidas.Where(c => c.Numero == GerenciadorDeTiposDeEntrada.Eggs).Count();
			int quantidadeToast = prato.Comidas.Where(c => c.Numero == GerenciadorDeTiposDeAcompanhamento.Toast).Count();
			int quantidadeCoffee = prato.Comidas.Where(c => c.Numero == GerenciadorDeTiposDeBebida.Coffee).Count();

			foreach (var comida in prato.Comidas.DistinctBy(c => c.Numero).OrderBy(c => c.Numero))
			{
				if (comida.Numero == GerenciadorDeTiposDeEntrada.Eggs)
				{
					saida = "eggs, ";
					if (quantidadeEggs > 1)
					{
						saida += "error";
						break;
					}
				}
				else if (comida.Numero == GerenciadorDeTiposDeAcompanhamento.Toast)
				{
					saida += "toast, ";
					if (quantidadeToast > 1)
					{
						saida += "error";
						break;
					}
				}
				else if (comida.Numero == GerenciadorDeTiposDeBebida.Coffee)
				{
					saida += string.Format("coffee{0}", quantidadeCoffee > 1 ? "(" + quantidadeCoffee.ToString() + "x)" : "");
				}
				else if (Convert.ToInt32(comida.Numero) > 3)
				{
					saida += ", error";
				}
				else
				{
					saida += "error";
				}
			}

			return saida;
		}

		public string CriarPratoNight(Prato prato)
		{
			var saida = string.Empty;
			int quantidadeSteak = prato.Comidas.Where(c => c.Numero == GerenciadorDeTiposDeEntrada.Steak).Count();
			int quantidadePotato = prato.Comidas.Where(c => c.Numero == GerenciadorDeTiposDeAcompanhamento.Potato).Count();
			int quantidadeWine = prato.Comidas.Where(c => c.Numero == GerenciadorDeTiposDeBebida.Wine).Count();
			int quantidadeBolo = prato.Comidas.Where(c => c.Numero == GerenciadorDeTiposDeSobremesa.Bolo).Count();

			foreach (var comida in prato.Comidas.DistinctBy(c => c.Numero))
			{
				if (comida.Numero == GerenciadorDeTiposDeEntrada.Steak)
				{
					saida = "steak, ";
					if (quantidadeSteak > 1)
					{
						saida += "error";
						break;
					}
				}
				else if (comida.Numero == GerenciadorDeTiposDeAcompanhamento.Potato)
				{
					saida += string.Format("potato{0}", quantidadePotato > 1 ? "(" + quantidadePotato.ToString() + "x), " : ", ");
				}
				else if (comida.Numero == GerenciadorDeTiposDeBebida.Wine)
				{
					saida += "wine";
					if (quantidadeWine > 1)
					{
						saida += "error";
						break;
					}
					else if (quantidadeBolo > 0)
					{
						saida += ", ";
					}
				}
				else if (comida.Numero == GerenciadorDeTiposDeSobremesa.Bolo)
				{
					saida += "cake";
					if (quantidadeBolo > 1)
					{
						saida += "error";
						break;
					}
				}
				else if (Convert.ToInt32(comida.Numero) > 4)
				{
					saida += ", error";
				}
				else
				{
					saida += "error";
				}
			}

			return saida;
		}
	}
}
