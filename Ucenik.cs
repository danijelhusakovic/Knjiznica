public class Ucenik
{
    public string OIB { get; set; }
    public string Ime { get; set; }
    public string Prezime { get; set; }
    public int Razred { get; set; }


    public Ucenik(string oib, string ime, string prezime, int razred)
    {
        this.OIB = oib;
        this.Ime = ime;
        this.Prezime = prezime;
        this.Razred = razred;
    }

    public override string ToString()
    {
        return $"{this.Prezime}, {this.Ime}: {this.Razred}";
    }
}