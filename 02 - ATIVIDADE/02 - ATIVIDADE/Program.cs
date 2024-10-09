using _02___ATIVIDADE;

Aluno aluno1 = new Aluno(2008, "Matias", (new DateTime (2015,3,02)), "@ma03@gmail.com");
Aluno aluno2 = new Aluno(4012, "Liz", (new DateTime(2014,5,15)), "@liz02@gmail.com");
Aluno aluno3 = new Aluno(3026, "Luisa", (new DateTime(2016,11,02)), "@lu@gmail.com");


Console.WriteLine("Meu RM é " + aluno1.RM + " me chamo " + aluno1.Nome + " nasci em " + aluno1.Nascimento + " meu email é " + aluno1.Email);
Console.WriteLine("Meu RM é " + aluno2.RM + " me chamo " + aluno2.Nome + " nasci em " + aluno2.Nascimento + " meu email é " + aluno2.Email);
Console.WriteLine("Meu RM é " + aluno3.RM + " me chamo " + aluno3.Nome + " nasci em " + aluno3.Nascimento + " meu email é " + aluno3.Email);

Console.ReadKey();