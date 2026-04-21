internal class Program
{
    private static void Main(string[] args)
    {
        int cantidad, forma;
        double precio = 650 * 1.12;
        double total, descuento = 0, totalFinal;

        Console.Write("Cantidad de impresoras: ");
        cantidad = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("1. Efectivo (10%)");
        Console.WriteLine("2. Tarjeta (5%)");
        Console.WriteLine("3. Vale (15%)");

        Console.Write("Forma de pago: ");
        forma = Convert.ToInt32(Console.ReadLine());

        total = precio * cantidad;

        switch (forma)
        {
            case 1: descuento = total * 0.10; break;
            case 2: descuento = total * 0.05; break;
            case 3: descuento = total * 0.15; break;
        }

        totalFinal = total - descuento;

        Console.WriteLine("Precio con IVA: " + precio);
        Console.WriteLine("Total sin descuento: " + total);
        Console.WriteLine("Descuento: " + descuento);
        Console.WriteLine("Total a pagar: " + totalFinal);

    }
}