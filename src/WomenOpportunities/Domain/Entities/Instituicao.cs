using EstartandoDevsCore.DomainObjects;
using WomenOpportunities.Domain.ObjectValue;

namespace WomenOpportunities.Domain.Entities;

public class Instituicao : Entity, IAggregateRoot
{
    public const int Max = 250;
    public string Nome { get; private set; }
    public Contato Contato { get; private set; }
    public Login Login { get; private set; }
    public int QuantidadeDeOportunidades { get; set; }
    
    private readonly List<Oportunidade> _Oportunidades = new();
    public IReadOnlyCollection<Oportunidade> Oportunidades => _Oportunidades;
    
    protected Instituicao() {}

    public Instituicao(string nome, Contato contato, Login login)
    {
        Nome = nome;
        Contato = contato;
        Login = login;
    }

    public void AdicionarOportunidade(Oportunidade oportunidade)
    {
        QuantidadeDeOportunidades++;
        _Oportunidades.Add(oportunidade);
    }
    
    public void AtribuirNome(string nome) => Nome = nome;
    public void AtribuirContato(Contato contato) => Contato = contato;
    public void AtribuirLogin(Login login) => Login = login;
    
}