// classe prestito

public class Prestito
{
    public Utente Utente { get; set; }
    public Documento Documento { get; set; }
    public string InizioPrestito { get; set; }
    public string FinePrestito { get; set; }
    public Prestito(Utente utente, Documento documento, string inizioPrestito, string finePrestito)

    {
        Utente = utente ?? throw new ArgumentNullException(nameof(utente));
        Documento = documento ?? throw new ArgumentNullException(nameof(documento));
        InizioPrestito = inizioPrestito ?? throw new ArgumentNullException(nameof(inizioPrestito));
        FinePrestito = finePrestito ?? throw new ArgumentNullException(nameof(finePrestito));

    }

    //public override string ToString()
    //{
    //    return "prestito dal " + InizioPrestito + " al " + FinePrestito + ". Per l'utente " + Utente.Cognome + " " + Utente.Nome + ". Del documento " + Documento.Titolo + ".";
    //}
}