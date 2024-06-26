using WomenOpportunities.Domain.ObjectValue;

namespace WomenOpportunities.Domain.Entities;

public class Instituicao
{
    public const int Max = 250;
    public Guid Id { get; private set; }
    public string Nome { get; private set; }
    public Contato Contato { get; private set; }
    public Login Login { get; private set; }
    public int QuantidadeDeOportunidades { get; set; }
    
    private readonly List<Oportunidade> _Oportunidades = new();
    public IReadOnlyCollection<Oportunidade> Oportunidades => _Oportunidades;
    
    protected Instituicao() {}

    public Instituicao(Guid id, string nome, Contato contato, Login login)
    {
        Id = id;
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