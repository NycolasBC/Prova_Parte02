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
        public void AdicionarCartas(Cartas cartas);
        public IEnumerable<Cartas> ObterTodasCartas();
    }
}
