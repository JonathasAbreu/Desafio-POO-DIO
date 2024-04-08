using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "111111111", memoria: "64GB");
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "654321", modelo: "Modelo 2", imei: "22222222", memoria:"32GB");
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");