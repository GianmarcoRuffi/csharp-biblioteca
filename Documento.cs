public class Documento
{
    public string Codice { get; }
    public string Titolo { get;  }
    public int Anno { get;}
    public string Settore { get; }
    public string Scaffale { get; }
    public string Autore { get; }
    //Disponibilità documento
    public bool Disponibile { get; set; }


    //costruttore
    public Documento(string codice, string titolo, int anno, string settore, string scaffale, string autore)
    {
        Codice = codice;
        Titolo = titolo;
        Anno = anno;
        Settore = settore;
        Scaffale = scaffale;
        Autore = autore;
        Disponibile = true;

    }

    public override string ToString()
    {
        return "Titolo: " + Titolo + ", Codice: " + Codice;
    }
}
