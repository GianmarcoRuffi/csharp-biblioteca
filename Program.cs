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

Biblioteca Biblioteca = new Biblioteca();

//classe biblioteca
public class Biblioteca
{
    string[] nomi = { "Andrea", "Vincenzo", "Giorgio", "Mattia" };
    string[] cognomi = { "Ferlin", "Aspromonte", "Floris", "Congiu" };
    string[] email = { "ferlin@outlook.it", "vinjinzo@outlook.it", "flowers@outlook.it", "maty@outlook.it" };
    int[] telefono = { 330176382, 3298728, 260109149, 32089028 };
    string[] codice = { "45346634643", "6346346436", "255235135325", "25325252532" };
    string[] codiceISBN = { "3463463463463", "2346366363463", "64663642464256", "3463462462624" };
    string[] titoloDVD = { "Riddick", "Troy", "National Geographic", "Le religioni del mondo" };
    string[] titoloLibri = { "2001: Odissea nello spazio", "Giallo", "Storia", "Geografia" };
    int[] anno = { 1968, 1990, 2000, 2010 };
    string[] settore = { "Fantascienza", "Mistero", "Scolastico", "Scolastico" };
    bool[] stato = { true, false, false, true};
    string[] scaffale = { "1A", "22", "CC", "Y6" };
    string[] autore = { "Arthur C. Clarke", "Autore1", "Autore2", "Autore3" };
    int[] durata = { 100, 200, 300, 400 };
    int[] pagine = { 400, 400, 200, 100 };

    //liste
    public List<Utente> utenti = new List<Utente>();
    public List<Documento> documenti = new List<Documento>();
    public List<Prestito> prestiti = new List<Prestito>();



    

}

