using DesafioPOO.Models;

Console.WriteLine("Smatphone Iphone:");
Smartphone iphone = new Iphone(numero:"98787-8282", modelo:"Iphone 12", imei:"123456789", memoria:128);
iphone.Ligar();
iphone.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smatphone Nokia:");
Smartphone nokia = new Nokia(numero: "98826-8826", modelo: "Nokia 3310", imei: "987654321", memoria: 32);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Instagram");