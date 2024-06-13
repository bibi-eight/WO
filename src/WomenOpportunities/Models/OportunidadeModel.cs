namespace WomenOpportunities.Models;

public class OportunidadeModel
{
    public Guid Id { get; set; }
    public string Titulo { get; set; }
    public string Descricao { get; set; }
    public ContatoModel Contato { get; set; }
    public int QuantidadeFavoritos { get; set; }
    public bool Publicado { get; set; }
    public Guid InstituicaoId { get; set; }
}