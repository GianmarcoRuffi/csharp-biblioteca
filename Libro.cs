public class Libro : Documento
{

    public int Pagine { get; set; }


    public Libro(string codice, string titolo, int anno, string settore, string scaffale, string autore, int pagine) : base(codice, titolo, anno, settore, scaffale, autore)
    {
        Pagine = pagine;
        //Pagine = new Random().Next(100, 600);
        //codice = "BK" + new Random().Next(10000, 99999).ToString();
    }
}
