using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// classe prestito

public class Prestito
{
    public string InizioPrestito { get; }
    public string FinePrestito { get; }
    public Utente Utente { get; set; }

    public Documento Documento { get; set; }
    public Prestito(string InizioPrestito, string FinePrestito, Documento documento, Utente utente)
    {
        this.InizioPrestito = InizioPrestito;
        this.FinePrestito = FinePrestito;
        this.Documento = documento;
        this.Utente = utente;

    }
    public override string ToString()
    {
        return "prestito dal " + InizioPrestito + " al " + FinePrestito + ". Per l'utente " + Utente.Cognome + " " + Utente.Nome + ". Del documento " + Documento.Titolo + ".";
    }
}