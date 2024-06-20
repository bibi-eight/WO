using WomenOpportunities.Domain.Entities;
using WomenOpportunities.Domain.ObjectValue;

namespace WomenOpportunities.ViewModels;

public class OportunidadeViewModel
{
    public Guid OportunidadeId { get; set; }
    public string Titulo { get; set; }
    public string Descricao { get; set; }
    public string EmailContato { get; set; }
    public string TelefoneContato { get; set; }
    public int QuantidadeFavoritos { get; set; }
    public bool Publicado { get; set; }
    public Guid InstituicaoId { get; set; }

    public static OportunidadeViewModel Mapear(Oportunidade oportunidade)
    {
        return new OportunidadeViewModel()
        {
            OportunidadeId = oportunidade.Id,
            Titulo = oportunidade.Titulo,
            Descricao = oportunidade.Descricao,
            EmailContato = oportunidade.Contato.Email,
            TelefoneContato = oportunidade.Contato.Telefone,
            QuantidadeFavoritos = oportunidade.QuantidadeFavoritos,
            Publicado = oportunidade.Publicado,
            InstituicaoId = oportunidade.InstituicaoId
        };
    }
}