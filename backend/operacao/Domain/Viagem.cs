using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
  public class Viagem : DomainBase
  {
    public string Origem { get; set; }
    public string Destino { get; set; }
    public DateTime Inicio { get; set; }
    public DateTime Fim { get; set; }
  }
}
