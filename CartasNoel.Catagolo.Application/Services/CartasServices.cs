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

        public async Task AdicionarCartas(NovasCartasViewModel carta)
        {
            var novaCarta = _mapper.Map<Cartas>(carta);
            await _cartasRepository.AdicionarCartas(novaCarta);
        }

        public async Task<IEnumerable<CartasViewModel>> ObterTodasCartas()
        {
            var cartas = await _cartasRepository.ObterTodasCartas();
            return _mapper.Map<IEnumerable<CartasViewModel>>(cartas);
        }
    }
}
