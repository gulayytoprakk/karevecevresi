internal class Program
{
    private static void Main(string[] args)
    {
        int kenar, karealan, karecevre;
        Console.WriteLine("karenin çevresini ve alanını bulma");
        Console.WriteLine("karenin kenarını giriniz:");
        kenar=Convert.ToInt32(Console.ReadLine());

        karealan = kenar * kenar;
        karecevre = kenar * 4;

        Console.WriteLine("kare alanı=  "+karealan);
        Console.WriteLine("kare cevresi= "+ karecevre);
    }
   
}