using System;

namespace Domain
{
  public class Usuario : DomainBase
  {
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string[] Roles { get; set; }
  }
}
