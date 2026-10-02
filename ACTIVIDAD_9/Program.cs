Console.WriteLine("SISTEMA DE MONITOREO DE MOTOR");
Console.WriteLine();

// Crear un objeto de la clase Motor
Motor motor1 = new Motor();

// Capturar la información del objeto
Console.Write("Ingrese el identificador del motor: ");
motor1.Identificador = Console.ReadLine() ?? "Sin ID";

Console.Write("Ingrese la temperatura (°C): ");
motor1.Temperatura = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese la velocidad (RPM): ");
motor1.Velocidad = Convert.ToDouble(Console.ReadLine());

// Mostrar resultados
Console.WriteLine();
Console.WriteLine($"Motor: {motor1.Identificador}");
Console.WriteLine($"Temperatura: {motor1.Temperatura} °C");
Console.WriteLine($"Velocidad: {motor1.Velocidad} RPM");
Console.WriteLine($"Evaluación de temperatura: {motor1.EvaluarTemperatura()}");


// Definición de la clase
class Motor
{
    // Propiedades
    public string Identificador { get; set; } = "";

    public double Temperatura { get; set; }

    public double Velocidad { get; set; }


    // Método para determinar si la temperatura es mayor que 70 °C
    public string EvaluarTemperatura()
    {
        if (Temperatura > 70)
        {
            return "LA TEMPERATURA ES MAYOR A 70 °C";
        }
        else
        {
            return "LA TEMPERATURA ES MENOR QUE 70 °C";
        }
    }
}