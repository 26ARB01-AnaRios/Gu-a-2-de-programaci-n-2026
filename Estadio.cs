internal class Program
{
    private static void Main(string[] args)
    {
        int sector, cantidad;
        double precio = 0, total;

        Console.WriteLine("1. Palco Q300");
        Console.WriteLine("2. Tribuna Q125");
        Console.WriteLine("3. Preferencia Q75");
        Console.WriteLine("4. Generales Q50");

        Console.Write("Seleccione sector: ");
        sector = Convert.ToInt32(Console.ReadLine());

        switch (sector)
        {
            case 1: precio = 300; break;
            case 2: precio = 125; break;
            case 3: precio = 75; break;
            case 4: precio = 50; break;
            default:
                Console.WriteLine("Opcion invalida");
                return;
        }

        Console.Write("Cantidad de entradas: ");
        cantidad = Convert.ToInt32(Console.ReadLine());

        total = precio * cantidad;

        Console.WriteLine("Total a pagar: Q" + total);
    }
}