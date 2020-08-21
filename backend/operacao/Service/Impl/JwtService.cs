using Domain;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using System.IdentityModel;
using System.IdentityModel.Tokens.Jwt;
using Cross_Cutting;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.Linq;

namespace Service.Impl
{
  public class JwtService : IJwtService
  {
    public string CreateToken(Usuario usu)
    {
      var tokenHandler = new JwtSecurityTokenHandler();
      var key = Encoding.ASCII.GetBytes(JwtSecret.secret);
      var tokenDescriptor = new SecurityTokenDescriptor
      {
        Subject = new ClaimsIdentity(new Claim[]
        {
          new Claim(ClaimTypes.Name, usu.Username.ToString()),
          new Claim(ClaimTypes.Role, String.Join(",", usu.Roles))
        }),
        Expires = DateTime.UtcNow.AddHours(2),
        SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
      };

      var token = tokenHandler.CreateToken(tokenDescriptor);
      return tokenHandler.WriteToken(token);
    }
  }
}
