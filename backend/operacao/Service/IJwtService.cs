using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
  public interface IJwtService
  {
    string CreateToken(Usuario usu);
  }
}
