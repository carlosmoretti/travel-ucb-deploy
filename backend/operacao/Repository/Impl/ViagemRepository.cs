using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Impl
{
  public class ViagemRepository : Repository<Viagem>, IViagemRepository
  {
    public override IEnumerable<Viagem> GetAll()
    {
      return new List<Viagem>
      {
        new Viagem { Origem = "Niteroi, Rio de Janeiro - RJ", Destino = "Niteroi, Rio de Janeiro - RJ", Inicio = DateTime.Now, Fim = DateTime.Now },
        new Viagem { Origem = "Niteroi, Rio de Janeiro - RJ", Destino = "Niteroi, Rio de Janeiro - RJ", Inicio = DateTime.Now, Fim = DateTime.Now },
        new Viagem { Origem = "Niteroi, Rio de Janeiro - RJ", Destino = "Niteroi, Rio de Janeiro - RJ", Inicio = DateTime.Now, Fim = DateTime.Now },
        new Viagem { Origem = "Niteroi, Rio de Janeiro - RJ", Destino = "Niteroi, Rio de Janeiro - RJ", Inicio = DateTime.Now, Fim = DateTime.Now }
      };
    }
  }
}
