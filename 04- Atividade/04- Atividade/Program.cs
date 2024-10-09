using _04__Atividade;

Carro carro1 = new Carro("BMW", "BMW i8", 500);
Carro carro2 = new Carro("Fiat", "Strada", 165);
Carro carro3 = new Carro("Volkswagen", "T-Cross", 204);

Console.WriteLine($"Marca: {carro1.Marca}, Modelo: {carro1.Modelo}, Velocidade: {carro1.Velocidade}");
Console.WriteLine($"Marca: {carro2.Marca}, Modelo: {carro2.Modelo}, Velocidade: {carro2.Velocidade}");
Console.WriteLine($"Marca: {carro3.Marca}, Modelo: {carro3.Modelo}, Velocidade: {carro3.Velocidade}");


Console.ReadKey();