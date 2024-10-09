using _03__Atividade;

Produto produto1 = new Produto(001, "Gibis", 8.50, 500);
Produto produto2 = new Produto(002, "Revistas", 10.00, 600);
Produto produto3 = new Produto(003, "Livros", 25.00, 700);

Console.WriteLine("Código: " + produto1.Codigo + " Nome: " + produto1.Nome + " Preço: " + produto1.Preco + " Estoque: " + produto1.Estoque);
Console.WriteLine($"Código: " + produto2.Codigo +" Nome: " + produto2.Nome + " Preço: " + produto2.Preco + " Estoque: " + produto2.Estoque);
Console.WriteLine("Código: " + produto3.Codigo + "Nome: " + produto3.Nome + "Preço: " + produto3.Preco + "Estoque: " + produto3.Estoque);
Console.ReadKey();