public class Utente

{
    public string Nome { get; set; }
    public string Cognome { get; }
    public string Email { get; }
    public string Password { get; }
    public string Telefono { get; }
    public Utente(string nome, string cognome, string email, string password, string telefono)
    {
        Nome = nome;
        Cognome = cognome;
        Email = email;
        Password = password;
        Telefono = telefono;
    }

}