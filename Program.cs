using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia (numero: "123456789", Modelo: "Modelo 1", Imei:"2525252525252", Memoria:"64");
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone (numero: "12789", Modelo: "Modelo 2", Imei:"25567825252", Memoria:"128");
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");