using AutoMapper;
using CartasNoel.Catalogo.Domain.Entities;
using Prova_Parte01.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1Store.Catalogo.Application.AutoMapper
{
	public class ApplicationToDomain : Profile
	{
		public ApplicationToDomain()
		{

            CreateMap<CartasViewModel, Cartas>()
			   .ConstructUsing(c => new Cartas(
					c.Id, 
					c.Nome, 
					c.Rua, 
					c.Numero,
					c.Bairro,
					c.Cidade,
					c.UF,
					c.Idade,
					c.TextoCarta
				));

			CreateMap<NovasCartasViewModel, Cartas>()
			   .ConstructUsing(c => new Cartas(
					c.Nome,
					c.Rua,
					c.Numero,
					c.Bairro,
					c.Cidade,
					c.UF,
					c.Idade,
					c.TextoCarta
                ));
		}
	}
}
