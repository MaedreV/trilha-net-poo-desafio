using DesafioPOO.Models;



Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "8888", modelo: "V1", imei: "1245", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("Subway Surfer");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "1920", modelo: "V2", imei: "4512", memoria: 64);
iphone.Ligar();
iphone.InstalarAplicativo("Facebook");