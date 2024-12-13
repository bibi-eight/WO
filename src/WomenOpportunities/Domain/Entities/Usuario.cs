using EstartandoDevsCore.DomainObjects;
using WomenOpportunities.Domain.ObjectValue;

namespace WomenOpportunities.Domain.Entities;

public class Usuario : Entity
{
    public const int Max = 250;
    public string Nome { get; private set; }
    public Contato Contato { get; private set; }
    public Login Login { get; private set; }
    public int QuantidadeDeFavoritos { get; private set; }
    private readonly List<Favoritos> _favoritos = new();
    public IReadOnlyCollection<Favoritos> Favoritos => _favoritos;

    protected Usuario() {}

    public Usuario(string nome, Contato contato, Login login)
    {
        Nome = nome;
        Contato = contato;
        Login = login;
    }

    public void AdiicionarFavorito(Favoritos favoritos)
    {
        QuantidadeDeFavoritos++;
        _favoritos.Add(favoritos);
    }
    public void AtribuirNome(string nome) => Nome = nome;
    public void AtribuirContato(Contato contato) => Contato = contato;
    public void AtribuirLogin(Login login) => Login = login;
    
}