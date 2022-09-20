using DesafioPOO.Models;

Console.WriteLine("Smartphone Iphone");
Iphone iphone = new("47123448620", "Iphone14", "123456789", 520);
iphone.Ligar();
iphone.InstalarAplicativo("Dio");

Console.WriteLine("Smartphone Nokia");
Nokia nokia = new("47984569610", "Nokia14", "456789123", 128);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Dio");
