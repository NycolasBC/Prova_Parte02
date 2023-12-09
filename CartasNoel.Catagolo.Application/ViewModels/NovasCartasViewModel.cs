using CartasNoel.Catalogo.Domain.Entities;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Prova_Parte01.Model.Request
{
    public class NovasCartasViewModel
    {
        [Required(ErrorMessage = "É necessário ter um nome.")]
        [MinLength(3, ErrorMessage = "É necessário ter no minimo 3 caracteres."), MaxLength(255, ErrorMessage = "Limite máximo de 255 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "É necessário ter um rua.")]
        [MinLength(3, ErrorMessage = "É necessário ter no minimo 3 caracteres."), MaxLength(50, ErrorMessage = "Limite máximo de 50 caracteres.")]
        public string Rua { get; set; }

        [Required(ErrorMessage = "É necessário ter um número.")]
        [Range(0, int.MaxValue, ErrorMessage = "Informe um número")]
        public int Numero { get; set; }

        [Required(ErrorMessage = "É necessário ter um bairro.")]
        [MinLength(3, ErrorMessage = "É necessário ter no minimo 3 caracteres."), MaxLength(50, ErrorMessage = "Limite máximo de 50 caracteres.")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "É necessário ter um cidade.")]
        [MinLength(3, ErrorMessage = "É necessário ter no minimo 3 caracteres."), MaxLength(50, ErrorMessage = "Limite máximo de 50 caracteres.")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "É necessário ter um UF.")]
        [MinLength(1, ErrorMessage = "É necessário ter no minimo 1 caracteres."), MaxLength(2, ErrorMessage = "Limite máximo de 2 caracteres.")]
        public string UF { get; set; }

        [Required(ErrorMessage = "É necessário escrever uma carta.")]
        [Range(1, 14, ErrorMessage = "Informe uma idade de 1 c 14 anos.")]
        public int Idade { get; set; }

        [Required(ErrorMessage = "É necessário escrever uma carta.")]
        [MaxLength(500, ErrorMessage = "Limite máximo de 500 caracteres.")]
        public string TextoCarta { get; set; }
    }
}
