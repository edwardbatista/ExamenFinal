using System;
namespace ExamenFinal
{
	public class Infraccion
	{
		public int Penalidad { get; set; }
		private List<string> infracciones; 
		public Infraccion(int penalidad)
		{
			Penalidad = 0;
            infracciones = new List<string>();
		}

		public void Obstruccion()
		{
			Penalidad += 1800;
			infracciones.Add("Debido a su obstruccion de transito, se le han penalizado RD$ 1800.00");
		}

		public void Rojo()
		{
			Penalidad += 5950;
			infracciones.Add("Debido a que no se detuvo en el semaforo en rojo, se le han penalizado RD$ 5950.00");
		}

		public void Telefono()
		{
			Penalidad += 3750;
			infracciones.Add("Debido a que estaba usando el telefono cuando conducia, se le han penalizado RD$ 3750.00");
		}

		public void NoCinturon()
		{
			Penalidad += 2560;
			infracciones.Add("Debido a que conducia sin cinturon, se le han penalizado RD$ 2560.");
		}

		public void Vencida()
		{
			Penalidad += 3890;
			infracciones.Add("Debido a que su licencia esta vencida, se le han penalizado RD$ 3890.00");
		}

		public void Total()
		{
			foreach (string infracciones in infracciones)
			{
				Console.WriteLine(infracciones);
			}
			Console.WriteLine($"El total de sus infracciones es RD${Penalidad}.");
		}
	}
}

