using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Impl
{
  public class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
  {
    public override IEnumerable<Usuario> GetAll()
    {
      List<Usuario> usuario = new List<Usuario>()
      {
        new Usuario() { Id = 0, Password = "alexandre2", Username = "carlosmoretti", Roles = new string[] { "admin", "user" }},
        new Usuario() { Id = 0, Password = "alexandre2", Username = "carlosmoretti1", Roles = new string[] { "admin", "user" } },
        new Usuario() { Id = 0, Password = "alexandre2", Username = "carlosmoretti2", Roles = new string[] { "admin", "user" } },
        new Usuario() { Id = 0, Password = "alexandre2", Username = "carlosmoretti3", Roles = new string[] { "admin", "user" } },
        new Usuario() { Id = 0, Password = "alexandre2", Username = "carlosmoretti4", Roles = new string[] { "admin", "user" } },
        new Usuario() { Id = 0, Password = "piche", Username = "andre", Roles = new string[] { "admin", "user" }, Nome = "André", Sobrenome = "Pichê" },
        new Usuario() { Id = 0, Password = "alexandre2", Username = "cmoretti", Roles = new string[] { "admin", "user" }, Nome = "Carlos", Sobrenome = "Moretti" }
      };

      return usuario;
    }
  }
}
