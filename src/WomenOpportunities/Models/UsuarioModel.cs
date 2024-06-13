namespace WomenOpportunities.Models;

public class UsuarioModel
{
    public Guid Id { get;  set; }
    public string Nome { get;  set; }
    public ContatoModel Contato { get;  set; }
    public LoginModel Login { get;  set; }
}