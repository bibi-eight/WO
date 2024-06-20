using System.ComponentModel.DataAnnotations;

namespace WomenOpportunities.Models;

public class OportunidadeModel
{
    public Guid OportunidadeId { get; set; }
    
    [Required(ErrorMessage = "Campo {0} é obrigatório")]
    public string Titulo { get; set; }
    
    [Required(ErrorMessage = "Campo {0} é obrigatório")]
    public string Descricao { get; set; }
    
    public ContatoModel Contato { get; set; }
    public int QuantidadeFavoritos { get; set; }
    public bool Publicado { get; set; }
    
    [Required(ErrorMessage = "Campo {0} é obrigatório")]
    public Guid InstituicaoId { get; set; }
}