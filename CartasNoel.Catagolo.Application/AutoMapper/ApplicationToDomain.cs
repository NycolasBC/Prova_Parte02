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
			   .ConstructUsing(q => new Cartas(q.Id, q.Nome, q.EnderecoCarta, q.Idade, q.TextoCarta));

			CreateMap<NovasCartasViewModel, Cartas>()
			   .ConstructUsing(q => new Cartas(0, q.Nome, q.EnderecoCarta, q.Idade, q.TextoCarta));

		}
	}
}
