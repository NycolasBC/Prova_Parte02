using AutoMapper;
using CartasNoel.Catalogo.Application.Interfaces;
using CartasNoel.Catalogo.Domain.Entities;
using CartasNoel.Catalogo.Domain.Interfaces;
using Prova_Parte01.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartasNoel.Catalogo.Application.Services
{
    public class CartasServices : ICartasServices
    {
        #region - Construtores

        private readonly ICartasRepository _cartasRepository;
        private IMapper _mapper;

        public CartasServices(ICartasRepository produtoRepository, IMapper mapper)
        {
            _cartasRepository = produtoRepository;
            _mapper = mapper;
        }

        #endregion

        public void AdicionarCartas(NovasCartasViewModel carta)
        {
            var novaCarta = _mapper.Map<Cartas>(carta);
            _cartasRepository.AdicionarCartas(novaCarta);
        }

        public IEnumerable<CartasViewModel> ObterTodasCartas()
        {
            return _mapper.Map<IEnumerable<CartasViewModel>>(_cartasRepository.ObterTodasCartas());
        }
    }
}
