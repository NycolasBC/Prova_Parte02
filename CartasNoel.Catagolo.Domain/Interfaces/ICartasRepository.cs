using CartasNoel.Catalogo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartasNoel.Catalogo.Domain.Interfaces
{
    public interface ICartasRepository
    {
        public Task AdicionarCartas(Cartas cartas);
        public Task<IEnumerable<Cartas>> ObterTodasCartas();
    }
}
