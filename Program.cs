public class Programa
{
    public static void Main(String[] args)
    {
        Autor autor = new Autor("J.R.R Tolkien", "Inglaterra");
        Livro livro = new Livro("Hobbit",autor,50.0);
        livro.MostrarInfo();
        livro.AplicarDesconto(10);
        livro.MostrarInfo();
        livro.AplicarDesconto(5.0);
        livro.MostrarInfo();
    }
}