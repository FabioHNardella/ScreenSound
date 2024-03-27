public class Album
{
    public Album(string nome)
    {
        Nome = nome;
    }
    private List<Musica> musicas = new List<Musica>();
    public string Nome { get; set; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);

    public void AddMusica(Musica musica)
    {
        musicas.Add(musica);
    }
    public void ExibirMusicasAlbum()
    {
        System.Console.WriteLine($"Lista de músicas do álbum {Nome}:");
        System.Console.WriteLine("--------------------------------");
        foreach (var musica in musicas)
        {
            System.Console.WriteLine($"Música: {musica.Nome}");
        }
        System.Console.WriteLine($"\nDuração total desse álbum: {DuracaoTotal} segundos");
    }
}