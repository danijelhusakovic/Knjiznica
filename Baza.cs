using System.Collections.Generic;

public static class Baza
{
    public static List<Ucenik> Ucenici;
    public static List<Knjiga> Knjige;
    public static List<Posudba> Posudbe;

    public static void Initialize()
    {
        Ucenici = new List<Ucenik>();
        Knjige = new List<Knjiga>();
        Posudbe = new List<Posudba>();
    }
}