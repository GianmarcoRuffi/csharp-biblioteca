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

// definizione oggetto biblioteca

Biblioteca Biblioteca = new Biblioteca();

//classe biblioteca
public class Biblioteca
{

    //liste
    public List<Utente> utenti = new List<Utente>();
    public List<Documento> documenti = new List<Documento>();
    public List<Prestito> prestiti = new List<Prestito>();

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

