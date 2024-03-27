public class Banda
{
    public Banda(string nome)
    {
        Nome = nome;
    }
    private List<Album> albums = new List<Album>();
    public string Nome { get; }
    public void AdicionarAlbum(Album album)
    {
        albums.Add(album);
    }
    public void ExibirDiscografia()
    {
        System.Console.WriteLine($"Discografia da banda {Nome}");
        foreach (Album album in albums)
        {
            System.Console.WriteLine($"Album: {album.Nome}");
        }
        System.Console.WriteLine("\n");
    }

}
