Banda fiveSOS = new Banda("5 Seconds Of Summer");
Album album5SecondsOfSummer = new Album("YoungBlood");

Musica musica1FSOS = new Musica(fiveSOS, "YoungBlood")
{
    Duracao = 203,
    Disponivel = true,
};

Musica musica2FSOS = new Musica(fiveSOS, "Want You Back")
{
    Duracao = 173,
    Disponivel = true,
};
Musica musica3FSOS = new Musica(fiveSOS, "Ghost Of You")
{
    Duracao = 197,
    Disponivel = false,
};

Musica musica4FSOS = new Musica(fiveSOS, "Valentine")
{
    Duracao = 196,
    Disponivel = false,
};

album5SecondsOfSummer.AddMusica(musica1FSOS);
album5SecondsOfSummer.AddMusica(musica2FSOS);
album5SecondsOfSummer.AddMusica(musica3FSOS);
album5SecondsOfSummer.AddMusica(musica4FSOS);
fiveSOS.AdicionarAlbum(album5SecondsOfSummer);

musica1FSOS.ExibirFicha();
musica2FSOS.ExibirFicha();
musica3FSOS.ExibirFicha();
musica4FSOS.ExibirFicha();
album5SecondsOfSummer.ExibirMusicasAlbum();
System.Console.WriteLine("");
fiveSOS.ExibirDiscografia();



