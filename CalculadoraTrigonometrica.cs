internal class Program
{
    private static void Main(string[] args)
    {
        double angulo, rad;
        int opcion;

        Console.WriteLine("CALCULADORA TRIGONOMETRICA");
        Console.WriteLine("1. Seno");
        Console.WriteLine("2. Coseno");
        Console.WriteLine("3. Tangente");

        Console.Write("Ingrese el angulo en grados: ");
        angulo = Convert.ToDouble(Console.ReadLine());

        rad = angulo * Math.PI / 180;

        Console.Write("Seleccione una opcion: ");
        opcion = Convert.ToInt32(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Console.WriteLine("Seno: " + Math.Sin(rad));
                break;
            case 2:
                Console.WriteLine("Coseno: " + Math.Cos(rad));
                break;
            case 3:
                Console.WriteLine("Tangente: " + Math.Tan(rad));
                break;
            default:
                Console.WriteLine("Opcion invalida");
                break;
        }
    }
}