using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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