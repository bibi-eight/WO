using WomenOpportunities.Domain.ObjectValue;

namespace WomenOpportunities.Domain.Entities;

public class Oportunidade
{
    public const int Max = 250;
    public Guid Id { get; private set; }
    public string Titulo { get; private set; }
    public string Descricao { get; private set; }
    public Contato Contato { get; private set; }
    public int QuantidadeFavoritos { get; private set; }
    public bool Publicado { get; private set; }
    public virtual Instituicao Instituicao { get; private set; }

    protected Oportunidade() { }

    public Oportunidade(Guid id, string titulo, string descricao, Contato contato, int quantidadeFavoritos, bool publicado)
    {
        Id = id;
        Titulo = titulo;
        Descricao = descricao;
        Contato = contato;
        QuantidadeFavoritos = quantidadeFavoritos;
        Publicado = publicado;
    }

    public void AtribuirTitulo(string titulo) => Titulo = titulo;
    public void AtribuirDescricao(string descricao) => Descricao = descricao;
    public void AtribuirContato(Contato contato) => Contato = contato;
    public void AtribuirInstituicao(Instituicao value) => Instituicao = value;


    public void Publicar() => Publicado = true;
    public void Ocultar() => Publicado = false;
}