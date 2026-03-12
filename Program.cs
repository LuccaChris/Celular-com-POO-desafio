using DesafioPOO.Models;



internal class Program
{
    private static void Main(string[] args)
    {
        Nokia nokia = new Nokia
        (
            "1165753589",
            "Nokia X",
            "12244466666",
            64
        );

        Iphone iphone = new Iphone
        (
            "11999999999",
            "iPhone X",
            "23344477777",
            128
        );
        Console.WriteLine("Nokia:");
        nokia.Ligar();
        nokia.InstalarAplicativo("WhatsApp");

        Console.WriteLine("/n");

        Console.WriteLine("iPhone:");
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}