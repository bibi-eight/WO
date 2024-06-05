namespace WomenOpportunities.Domain.ObjectValue;

public class Contato
{
    public string Email { get; private set; }
    public string Telefone { get; private set; }

    protected Contato() { }

    public Contato(string email, string telefone)
    {
        Email = email;
        Telefone = telefone;
    }

    public void AtribuirEmail(string email) => Email = email;
    public void AtribuirTelefone(string telefone) => Telefone = telefone;
}