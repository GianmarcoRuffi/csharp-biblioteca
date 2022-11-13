public class Libro : Documento
{

    public int Pagine { get; set; }


    public Libro(string codice, string titolo, int anno, string settore, string scaffale, string autore, int pagine) : base(codice, titolo, anno, settore, scaffale, autore)
    {
        Pagine = pagine;
 

    }
}
