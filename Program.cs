using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        // Testando a classe Nokia
        Nokia nokia = new Nokia("123456789", "Nokia 3310", "111111111", 64);
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        Console.WriteLine();

        // Testando a classe Iphone
        Iphone iphone = new Iphone("987654321", "iPhone 12", "222222222", 128);
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}