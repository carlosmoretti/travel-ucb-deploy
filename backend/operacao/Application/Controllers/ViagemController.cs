using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository;

namespace Application.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ViagemController : ControllerBase
  {
    private IViagemRepository _viagemRepository;
    public ViagemController(IViagemRepository viagemRepository)
    {
      _viagemRepository = viagemRepository;
    }

    [HttpGet]
    [Authorize]
    public ActionResult<List<Viagem>> viagens()
    {
      return _viagemRepository.GetAll().ToList();
    }
  }
}
