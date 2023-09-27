using CartasNoel.Catalogo.Domain.Entities;
using CartasNoel.Catalogo.Domain.Interfaces;
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

        private readonly string _cartasCaminhoArquivo;

        public CartasRepository()
        {
            _cartasCaminhoArquivo = Path.Combine(Directory.GetCurrentDirectory(), "FileJsonData", "cartas.json");
        }

        #endregion

        #region - Funções de repositorio

        public void AdicionarCartas(Cartas produto)
        {
            List<Cartas> cartas = new List<Cartas>();
            int proximoCodigo = ObterProximoCodigoDisponivel();
            cartas.Add(produto);
            EscreverCartasNoArquivo(cartas);
        }

        public IEnumerable<Cartas> ObterTodasCartas()
        {
            IEnumerable<Cartas> obter = LerCartasDoArquivo();
            IEnumerable<Cartas> enumerar = obter;
            return enumerar;
        }

        #endregion

        #region - Funções do arquivo
        private IEnumerable<Cartas> LerCartasDoArquivo()
        {
            if (!System.IO.File.Exists(_cartasCaminhoArquivo))
            {
                return new List<Cartas>();
            }

            string json = System.IO.File.ReadAllText(_cartasCaminhoArquivo);
            return JsonConvert.DeserializeObject<IEnumerable<Cartas>>(json);
        }

        private int ObterProximoCodigoDisponivel()
        {
            IEnumerable<Cartas> cartas = LerCartasDoArquivo();
            if (cartas.Any())
            {
                return cartas.Max(c => c.Id) + 1;
            }
            else
            {
                return 1;
            }
        }

        private void EscreverCartasNoArquivo(List<Cartas> cartas)
        {
            string json = JsonConvert.SerializeObject(cartas);
            System.IO.File.WriteAllText(_cartasCaminhoArquivo, json);
        }

        #endregion
    }
}
