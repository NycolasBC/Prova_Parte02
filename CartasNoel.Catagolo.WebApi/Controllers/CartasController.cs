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
		public IActionResult Post(NovasCartasViewModel novaCartaViewModel)
		{
            _cartasServices.AdicionarCartas(novaCartaViewModel);

			return Ok();
		}


		[HttpGet(Name = "ObterTodas")]
		public IActionResult Get()
		{
			return Ok(_cartasServices.ObterTodasCartas());
		}
	}
}
