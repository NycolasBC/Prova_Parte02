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
	public class DomainToApplication : Profile
	{
		public DomainToApplication()
		{
			CreateMap<Cartas, CartasViewModel>();
		}
	}
}
