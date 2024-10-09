using _01__Atividade;

Livro livro1 = new Livro("Jogos de Herança", "Jennifer Lynn Barnes", "Alt", 2021);
Livro livro2 = new Livro("É assim que acaba", "Colleen Hoover", "Galera", 2016);
Livro livro3 = new Livro("Principe Cruel", "Holly Black", "Grupo Editorial", 2018);


Console.WriteLine("O nome do livro é: " + livro1.Titulo + " a autora é: " + livro1.Autor + " a editora é: " +livro1.Editora " seu ano de lançamento foi " + livro1.AnoLancamento);

Console.WriteLine("O nome do livro é: " + livro2.Titulo + " a autora é: " + livro2.Autor + " a editora é: " + livro2.Editora " seu ano de lançamento foi " + livro2.AnoLancamento);

Console.WriteLine("O nome do livro é: " + livro3.Titulo + " a autora é: " + livro3.Autor + " a editora é: " + livro3.Editora " seu ano de lançamento foi " + livro3.AnoLancamento);

Console.ReadKey();