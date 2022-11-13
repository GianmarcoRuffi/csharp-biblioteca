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


bool continua = true;


do

{

    Console.WriteLine("Premi 1 - Ricerca documenti per titolo");
    Console.WriteLine("Premi 2 - Ricerca documenti per codice");


    int sceltaUtente = Convert.ToInt32(Console.ReadLine());

    switch (sceltaUtente)

    {
        case 1:

            Console.WriteLine("");
            Console.WriteLine("Inserisci il titolo del documento da ricercare");
            string titolodocumento = Console.ReadLine();
            Documento titolodocumento = programma.CercaDocumentoTitolo(string titolo)
            List<Documenti> documenti = programma.CercaDocumentoTitolo(titolodocumento);
  

            break;

        case 2:
            break;
    }


} while (continua);
 