using System.Collections.Generic;

namespace gftrestaurante.model
{
	public class Prato
	{
		public string Tipo { get; set; }
		public List<Comida> Comidas { get; set; }
	}
}
