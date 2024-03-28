public class Episodio
{
    public Episodio(int ordem, string titulo, int duracao)
    {
        Ordem = ordem;
        Titulo = titulo;
        Duracao = duracao;
    }
    private List<string> convidados = new();
    public int Duracao { get; }
    public int Ordem { get; }
    public string Resumo => $"Episódio {Ordem}. {Titulo} // Duração: {Duracao} minutos - {string.Join(", ", convidados)}";
    public string Titulo { get; }
    public void AdicionarConvidados(string convidado)
    {
        convidados.Add(convidado);
    }
}
