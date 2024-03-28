public class Podcast
{
    public Podcast(string host, string nome)
    {
        Host = host;
        Nome = nome;
    }
    public string Host { get; }
    public string Nome { get; }
    private List<Episodio> episodios = new List<Episodio>();
    public int TotalEpisodios => episodios.Count();
    public void AddEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        System.Console.WriteLine($"Podcast {Nome} apresentado por {Host}\n");
        System.Console.WriteLine("Lista de episódios:");
        foreach (Episodio episodio in episodios.OrderBy(e => e.Ordem))
        {
            System.Console.WriteLine($"{episodio.Resumo}\n");
        }
        System.Console.WriteLine($"Total de episódios do podcast: {TotalEpisodios}");
    }
}
