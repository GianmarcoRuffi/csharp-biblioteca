public class Dvd : Documento
{
    public int Durata { get; set; }
    public Dvd(string codice, string titolo, int anno, string settore, string scaffale, string autore, int durata) : base(codice, titolo, anno, settore, scaffale, autore)
    {

        Durata= durata;

    }
}
