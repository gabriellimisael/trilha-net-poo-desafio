using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

List<Smartphone> smartphones = new List<Smartphone>();
Console.WriteLine("Criando lista de smartphones...");

Nokia nokiaC12GB2 = new Nokia("11996969889", "Nokia C12", "123456789", "2 GB");
Nokia nokiaC12Gb64 = new Nokia("11996969841", "Nokia C12", "541456789", "64 GB");
Nokia nokiaG605G = new Nokia("11958129889", "Nokia G60 5G", "123967789", "128 GB");
Iphone iphone14pro  = new Iphone("11912349889", "Iphone 14 Pro", "987654321", "128 GB");
Iphone iphone13  = new Iphone("11965893244", "Iphone 13", "123454321", "256 GB");

smartphones.Add(nokiaC12GB2);
smartphones.Add(nokiaC12Gb64);
smartphones.Add(nokiaG605G);
smartphones.Add(iphone14pro);
smartphones.Add(iphone13);

Console.WriteLine("Testando smartphones:");

foreach(var celular in smartphones)
{
    Console.WriteLine("Inicio teste ........");    
    Console.WriteLine($"Smartphone Número {celular.Numero}");    
    celular.Ligar();    
    celular.InstalarAplicativo("Whatsapp");
    celular.InstalarAplicativo("Telegram");
    celular.ReceberLigacao();
    Console.WriteLine("Fim teste............"); 
}