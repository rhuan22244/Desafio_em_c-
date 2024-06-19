public class Livro
{
    public string Titulo;

    public Autor Autor;

    public double Preco;

    public Livro(string Titulo,Autor Autor)
    {
        this.Titulo = Titulo;
        this.Autor = Autor;
    }

    public Livro(string Titulo,Autor Autor,double Preco)
    {
        this.Titulo = Titulo;
        this.Autor = Autor;
        this.Preco = Preco;
    }
    public void MostrarInfo()
    {
        Console.WriteLine("Autor " + Autor.Nome);
        Console.WriteLine("Titulo " + Titulo);
        Console.WriteLine("Preço " + Preco);
        
    }

    public void AplicarDesconto(double porcentagem)
    {
        Preco -= Preco * (porcentagem / 100);
    }

    public void AplicarDesconto(int valor)
    {
        Preco -= valor;
    }
}