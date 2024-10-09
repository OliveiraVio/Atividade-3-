namespace _01__Atividade
{
    public class Livro
    {
        public string Titulo {  get; set; }

        public string Autor {  get; set; }

        public string Editora { get; set; }

        public int AnoLancamento { get; set; }

        public Livro(string titulo, string autor, string editora, int anolancamento)
        {
            Titulo = titulo;
            Autor = autor;
            Editora = editora;
            AnoLancamento = anolancamento;
        }
    }
}
