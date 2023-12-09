using CartasNoel.Catalogo.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace Prova_Parte01.Model.Request
{
    public class CartasViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public int Idade { get; set; }
        public string TextoCarta { get; set; }
    }
}
