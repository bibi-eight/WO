using WomenOpportunities.Domain.ObjectValue;

namespace WomenOpportunities.Domain.Entities;

public class Usuario
{
    public Guid Id { get; private set; }
    public string Nome { get; private set; }
    public Contato Contato { get; private set; }
    public Login Login { get; private set; }
    private readonly List<Favoritos> _favoritos = new();
    public IReadOnlyCollection<Favoritos> Favoritos => _favoritos;

    protected Usuario() {}

    public Usuario(Guid id, string nome, Contato contato, Login login)
    {
        Id = id;
        Nome = nome;
        Contato = contato;
        Login = login;
    }

    public void AtribuirNome(string nome) => Nome = nome;
    public void AtribuirContato(Contato contato) => Contato = contato;
    public void AtribuirLogin(Login login) => Login = login;
    
}