using CartasNoel.Catagolo.Persistance.EntityFramework;
using CartasNoel.Catalogo.Domain.Entities;
using CartasNoel.Catalogo.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartasNoel.Catalogo.Data.Repository
{
    public class CartasRepository : ICartasRepository
    {
        #region - Atributos e Construtor

        private readonly Contexto _contexto;

        public CartasRepository(Contexto contexto)
        {
            _contexto = contexto;
        }

        #endregion


        #region - Funções de repositorio

        public async Task AdicionarCartas(Cartas cartas)
        {
            try
            {
                await _contexto.Cartas.AddAsync(cartas);
                await _contexto.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao inserir a carta: {ex.Message}");
            }
        }

        public async Task<IEnumerable<Cartas>> ObterTodasCartas()
        {
            try
            {
                return await _contexto.Cartas.ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao buscar as cartas: {ex.Message}");
            }
        }

        #endregion


        //#region - Funções do arquivo

        //private IEnumerable<Cartas> LerCartasDoArquivo()
        //{
        //    if (!System.IO.File.Exists(_cartasCaminhoArquivo))
        //    {
        //        return new List<Cartas>();
        //    }

        //    string json = System.IO.File.ReadAllText(_cartasCaminhoArquivo);
        //    return JsonConvert.DeserializeObject<IEnumerable<Cartas>>(json);
        //}

        //private int ObterProximoCodigoDisponivel()
        //{
        //    IEnumerable<Cartas> cartas = LerCartasDoArquivo();
        //    if (cartas.Any())
        //    {
        //        return cartas.Max(c => c.Id) + 1;
        //    }
        //    else
        //    {
        //        return 1;
        //    }
        //}

        //private void EscreverCartasNoArquivo(List<Cartas> cartas)
        //{
        //    string json = JsonConvert.SerializeObject(cartas);
        //    System.IO.File.WriteAllText(_cartasCaminhoArquivo, json);
        //}

        //#endregion
    }
}
