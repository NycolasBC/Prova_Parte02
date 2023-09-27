using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartasNoel.Catalogo.Domain.Entities
{
    public class Cartas
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public Endereco EnderecoCarta { get; private set; }
        public int Idade { get; private set; }
        public string TextoCarta { get; private set; }

        #region Construtores

        public Cartas(int id, string nome, Endereco enderecoCarta, int idade, string textoCarta)
        {
            Id = id;
            Nome = nome;
            EnderecoCarta = enderecoCarta;
            Idade = idade;
            TextoCarta = textoCarta;
        }

        #endregion
    }
}
