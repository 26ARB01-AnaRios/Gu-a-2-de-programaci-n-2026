internal class Program
{
    private static void Main(string[] args)
    {
        char c;

        Console.Write("Ingrese un caracter: ");
        c = Convert.ToChar(Console.ReadLine());

        if (char.IsDigit(c))
        {
            Console.WriteLine("Es un digito");
        }
        else if ("aeiouAEIOU".Contains(c))
        {
            Console.WriteLine("Es una vocal");
        }
        else
        {
            Console.WriteLine("No es vocal ni digito");
        }
    }
}