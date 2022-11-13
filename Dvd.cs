public class Dvd : Documento
{
    public int Durata { get; set; }
    public Dvd(string codice, string titolo, int anno, string settore, string scaffale, string autore, int durata) : base(codice, titolo, anno, settore, scaffale, autore)
    {

        Durata= durata;

    }
}

//Codice = "DV" + new Random().Next(10000, 99999).ToString();
//Durata = new Random().Next(30, 120);

//public override string ToString()
//{
//    return "Numero Seriale: " + Codice + ", Titolo: " + Titolo;
//}
