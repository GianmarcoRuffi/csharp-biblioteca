//Si vuole progettare un sistema per la gestione di una biblioteca dove il bibliotecario può verificare i dati dei clienti registrati
//cognome,
//nome,
//email,
//recapito telefonico,
//Il bibliotecario può effettuare dei prestiti ai suoi clienti registrati, attraverso il sistema, sui documenti che sono di vario tipo (libri, DVD). I documenti sono caratterizzati da:
//un codice identificativo di tipo stringa (ISBN per i libri, numero seriale per i DVD),
//titolo,
//anno,
//settore(storia, matematica, economia, …),
//stato(In Prestito, Disponibile),
//uno scaffale in cui è posizionato,
//un autore (Nome, Cognome).
//Per i libri si ha in aggiunta il numero di pagine, mentre per i dvd la durata.
//Il bibliotecario deve poter eseguire delle ricerche per codice o per titolo e, eventualmente, effettuare dei prestiti registrando il periodo (Dal/Al) del prestito e il documento.
//Deve essere possibile effettuare la ricerca dei prestiti dato nome e cognome di un cliente.




// Definisco classi

//classe biblioteca
public class Biblioteca
{
    
    //liste
    public List<Documento> documenti;
    public List<Utente> utenti;

    public Biblioteca()
    {
        string[] utentiRegistrati = { "Filippo", "Ezio", "Ignazio", "Alessandro", "Davide" };
        documenti = new List<Documento>();
        utenti = new List<Utente>();
        for (int i = 0; i < 10; i++)
        {
            documenti.Add(new Libro());
            documenti.Add(new Dvd());
        }
        for (int i = 0; i < utentiRegistrati.Length; i++)
        {
            utenti.Add(new Utente(utentiRegistrati[i]));
        }
    }
}


//classe utente
public class Utente
{
    private string v;

    public string Nome { get; private set; }
    public string Cognome { get; private set; }

    public string Email { get; set; }
    public int Telefono { get; set; }

    public Utente(string nome, string cognome, string email, int telefono)
    {
        Nome = nome;
        Cognome = cognome;
        Email = email;
        Telefono = telefono;
    }

    public Utente(string v)
    {
        this.v = v;
    }
}


// classe documento

    public class Documento
    {
        public string Codice { get; set; }
        public string Titolo { get; set; }
        public int Anno { get; set; }
        public string Settore { get; set; }
        public string Stato { get; set; }
        public bool Disponibile { get; set; }
        public string Scaffale { get; set; }
        public string Autore { get; set; }

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

    