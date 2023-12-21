using DesafioPOO.Models;

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "0909", modelo: "Modelo 7", imei: "098765432", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Uber");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "8976", modelo: "Modelo 11", imei: "762098165", memoria: 64);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Skype");
