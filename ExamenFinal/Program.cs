namespace ExamenFinal;
class Program
{
    static void Main(string[] args)
    {
        //Agente
        AgenteTransito agente = new AgenteTransito();
        Console.WriteLine("Por favor, introduzca su código de empleado antes de registrar la infracción:");
        agente.Codigo = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Introduzca su nombre: ");
        agente.NombreAgente = Console.ReadLine();

        Console.WriteLine($"Bienvenido Agente {agente.NombreAgente}, por favor introduzca la dirección donde ocurrió la infracción: ");
        agente.DireccionAgente = Console.ReadLine();

        Console.WriteLine("Ingrese la fecha de la infracción (en el formato DD/MM/YYYY): ");
        agente.FechaIngreso = Console.ReadLine();

        Console.Clear();

        //Conductor
        Conductor conductor = new Conductor();
        Console.WriteLine($"Bien, Agente {agente.NombreAgente}, continuaremos con los datos del conductor. Por favor introduzca su nombre: ");
        conductor.NombreCompleto = Console.ReadLine();

        Console.WriteLine("Introduzca la cedula del conductor: ");
        conductor.Cedula = Console.ReadLine();

        Console.WriteLine("Introduzca la direccion del conductor: ");
        conductor.Direccion = Console.ReadLine();


        Console.WriteLine("Introduzca el tipo de licencia del conductor (A, B, o C): ");
        conductor.tipoLicencia = Console.ReadLine();

        Console.WriteLine("Introduzca la fecha de nacimiento del conductor(formato DD/MM/YYYY): ");
        conductor.FechaNacimiento = Console.ReadLine();

        Console.Clear();

        //Vehiculo
        Vehiculo vehiculo = new Vehiculo();

        Console.WriteLine($"Muchas gracias por la informacion Agente {agente.NombreAgente}. Continuaremos con los datos del vehiculo del conductor. Introduzca la placa: ");
        vehiculo.Placa = Console.ReadLine();

        Console.WriteLine("Introduzca la marca del vehículo: ");
        vehiculo.Marca = Console.ReadLine();

        Console.WriteLine("Introduzca el modelo del vehículo: ");
        vehiculo.Modelo = Console.ReadLine();

        Console.WriteLine("Introduzca el color del vehículo: ");
        vehiculo.Color = Console.ReadLine();

        Console.WriteLine("Introduzca el año del vehículo: ");
        vehiculo.Año = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Introduzca el número de chasis del vehículo: ");
        vehiculo.NumChasis = Convert.ToInt32(Console.ReadLine());

        conductor.vehiculo = vehiculo;

        Console.Clear();

        //Infracciones
        Console.WriteLine("Introduzca cuantas infracciones va a registrar: ");
        int input = Convert.ToInt32(Console.ReadLine());
        Infraccion infraccion = new Infraccion(0);

        for (int i = 0; i < input; i++)
        {
            Console.WriteLine("Indique la Infracción cometida: ");
            Console.WriteLine("1) Obstrucción de Transito");
            Console.WriteLine("2) Luz Roja");
            Console.WriteLine("3) Hablar por telefono");
            Console.WriteLine("4) Licencia Vencida");
            Console.WriteLine("5) No cinturón");
            int inp = Convert.ToInt32(Console.ReadLine());
            if (inp == 1)
            {
                infraccion.Obstruccion();
            }
            if (inp == 2)
            {
                infraccion.Rojo();
            }
            if (inp == 3)
            {
                infraccion.Telefono();
            }
            if (inp == 4)
            {
                infraccion.Vencida();
            }
            if (inp == 5)
            {
                infraccion.NoCinturon();
            }

        }
        infraccion.Total();
        Console.ReadKey();

        agente.infraccion = infraccion;
    }
}