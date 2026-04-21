internal class Program
{
    private static void Main(string[] args)
    {
        double valor;
        int opcion;

        Console.Write("Ingrese valor en metros: ");
        valor = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("1. Metros");
        Console.WriteLine("2. Pies");
        Console.WriteLine("3. Centimetros");
        Console.WriteLine("4. Pulgadas");

        Console.Write("Seleccione opcion: ");
        opcion = Convert.ToInt32(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Console.WriteLine("Metros: " + valor);
                break;
            case 2:
                Console.WriteLine("Pies: " + valor * 3.28084);
                break;
            case 3:
                Console.WriteLine("Centimetros: " + valor * 100);
                break;
            case 4:
                Console.WriteLine("Pulgadas: " + valor * 39.3701);
                break;
        }
    }
}