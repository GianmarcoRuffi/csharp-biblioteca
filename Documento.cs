using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// classe documento

public class Documento
{
    public string Codice { get; set; }
    public string Titolo { get; set; }
    public int Anno { get; set; }
    public string Settore { get; set; }
    public string Stato { get; set; }
    public string Scaffale { get; set; }
    public string Autore { get; set; }

    // disponibilità del documento   
    public bool Disponibile { get; set; }

    public Documento(string codice, string titolo, int anno, string settore, string stato, string scaffale, string autore)
    {
        Codice = codice;
        Titolo = titolo;
        Anno = anno;
        Settore = settore;
        Stato = stato;
        Scaffale = scaffale;
        Autore = autore;

    }

    public Documento()
    {
    }

    public override string ToString()
    {
        return "Titolo: " + Titolo + ", Codice: " + Codice;
    }
}

// sottoclasse libro

public class Libro : Documento
{
    public int NumeroPagine { get; set; }
    public Libro() : base()
    {
        Codice = "LB" + new Random().Next(10000, 99999).ToString();
        NumeroPagine = new Random().Next(100, 600);
    }

    public override string ToString()
    {
        return "ISBN: " + Codice + ", Titolo: " + Titolo;
    }
}


//sottoclasse dvd

public class Dvd : Documento
{
    public int Durata { get; set; }
    public Dvd() : base()
    {
        Codice = "DV" + new Random().Next(10000, 99999).ToString();
        Durata = new Random().Next(30, 120);
    }

    public override string ToString()
    {
        return "Numero Seriale: " + Codice + ", Titolo: " + Titolo;
    }
}
