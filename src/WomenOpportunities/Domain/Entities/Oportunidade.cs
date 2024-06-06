using WomenOpportunities.Domain.ObjectValue;

namespace WomenOpportunities.Domain.Entities;

public class Oportunidade
{
    public Guid Id { get; private set; }
    public string Titulo { get; private set; }
    public string Descricao { get; private set; }
    public Contato Contato { get; private set; }
    public int QuantidadeFavoritos { get; private set; }
    public bool Publicado { get; private set; }
    public Guid InstituicaoId { get; private set; }
    public virtual Instituicao Instituicao { get; private set; }

    protected Oportunidade() { }

    public Oportunidade(Guid id, string titulo, string descricao, Contato contato, int quantidadeFavoritos, bool publicado, Guid instituicaoId, Instituicao instituicao)
    {
        Id = id;
        Titulo = titulo;
        Descricao = descricao;
        Contato = contato;
        QuantidadeFavoritos = quantidadeFavoritos;
        Publicado = publicado;
        InstituicaoId = instituicaoId;
        Instituicao = instituicao;
    }

    public void AtribuirTitulo(string titulo) => Titulo = titulo;
    public void AtribuirDescricao(string descricao) => Descricao = descricao;
    public void AtribuirContato(Contato contato) => Contato = contato;

    public void Publicar() => Publicado = true;
    public void Ocultar() => Publicado = false;
}