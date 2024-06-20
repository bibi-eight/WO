using System.ComponentModel.DataAnnotations;

namespace WomenOpportunities.Models;

public class UsuarioModel
{
    public Guid Id { get;  set; }
    
    [Required(ErrorMessage = "Campo {0} é obrigatório")]
    public string Nome { get;  set; }
    
    public ContatoModel Contato { get;  set; }
    public LoginModel Login { get;  set; }
}