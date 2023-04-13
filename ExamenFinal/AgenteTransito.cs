using System;
namespace ExamenFinal
{
	public class AgenteTransito
	{
		public int Codigo { get; set; }
		public string NombreAgente { get; set; }
		public string DireccionAgente { get; set; }
		public string FechaIngreso { get; set; }
		public Infraccion infraccion { get; set; }
	}
}

