using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository;
using Service;

namespace Application.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class AutenticarController : ControllerBase
  {
    private readonly IJwtService _jwtService;
    private readonly IUsuarioRepository _usuarioRepository;
    public AutenticarController(IJwtService jwtService, IUsuarioRepository usuarioRepository)
    {
      _jwtService = jwtService;
      _usuarioRepository = usuarioRepository;
    }

    [HttpGet]
    public ActionResult<String> hello()
    {
      return "Hello World";
    }

    [HttpPost]
    [Route("login")]
    public ActionResult<dynamic> Autenticar([FromBody] Usuario model)
    {
      var user = _usuarioRepository.GetAll().FirstOrDefault(d => d.Username == model.Username && d.Password == model.Password);

      if (user == null)
        return NotFound();

      var token = _jwtService.CreateToken(user);
      user.Password = "";

      return new
      {
        user = user,
        token = token
      };
    }
  }
}
