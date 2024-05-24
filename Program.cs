using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("123456", "modelo 1", "111111111", 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone("456123", "modelo 2", "222222222", 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");

