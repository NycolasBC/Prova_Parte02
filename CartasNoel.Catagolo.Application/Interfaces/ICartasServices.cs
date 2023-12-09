using Prova_Parte01.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartasNoel.Catalogo.Application.Interfaces
{
    public interface ICartasServices
    {
        public Task AdicionarCartas(NovasCartasViewModel carta);
        public Task<IEnumerable<CartasViewModel>> ObterTodasCartas();
    }
}
