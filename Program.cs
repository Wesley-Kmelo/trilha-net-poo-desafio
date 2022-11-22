using DesafioPOO.Models;

Smartphone celular1 = new Nokia("123456789","N95","111222",64);
Smartphone celular2 = new Iphone("987654321","Iphone11","333444",128);

Console.WriteLine("--- Testando celular Nokia ---");
celular1.Ligar();
celular1.ReceberLigacao();
celular1.InstalarAplicativo("Twitter");

Console.Write("\n");

Console.WriteLine("--- Testando celular Iphone ---");
celular2.Ligar();
celular2.ReceberLigacao();
celular2.InstalarAplicativo("Linkedin");