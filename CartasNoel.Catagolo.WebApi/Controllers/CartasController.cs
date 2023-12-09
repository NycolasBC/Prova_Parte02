using CartasNoel.Catalogo.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Prova_Parte01.Model.Request;

namespace H1Store.Catalogo.API.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class CartasController : ControllerBase
	{
		private readonly ICartasServices _cartasServices;

		public CartasController(ICartasServices cartasServices)
		{
            _cartasServices = cartasServices;
		}

		[HttpPost(Name = "AdicionarCartas")]
		public async Task<IActionResult> Post(NovasCartasViewModel novaCartaViewModel)
		{
            await _cartasServices.AdicionarCartas(novaCartaViewModel);

			return Ok("Cartas adicionadas com sucesso");
		}


		[HttpGet(Name = "ObterTodas")]
		public async Task<IActionResult> Get()
		{
			var cartas = await _cartasServices.ObterTodasCartas();

            return Ok(cartas);
		}
	}
}
