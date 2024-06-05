using WomenOpportunities.Domain.ObjectValue;

namespace WomenOpportunities.Domain.Entities;

public class Instituicao
{
    public string Nome { get; private set; }
    public Contato Contato { get; private set; }
    public Login Login { get; private set; }
    private readonly List<Oportunidade> _Oportunidades = new();
    public IReadOnlyCollection<Oportunidade> Oportunidades => _Oportunidades;
    
    protected Instituicao() {}

    public Instituicao(string nome, Contato contato, Login login)
    {
        Nome = nome;
        Contato = contato;
        Login = login;
    }

    public void AtribuirNome(string nome) => Nome = nome;
    public void AtribuirContato(Contato contato) => Contato = contato;
    public void AtribuirLogin(Login login) => Login = login;
    
}