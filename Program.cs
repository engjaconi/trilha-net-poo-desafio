using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Nokia:");
Nokia celular1 = new Nokia("(88)99999-4444", "Moto G7", "abc1234", 64);
celular1.Ligar();
celular1.InstalarAplicativo("WhatsApp");

Console.WriteLine("\nIphone:");
Iphone celular2 = new Iphone("(88)99999-4444", "Iphone 14", "abc4321", 128);
celular2.ReceberLigacao();
celular2.InstalarAplicativo("Instagram");