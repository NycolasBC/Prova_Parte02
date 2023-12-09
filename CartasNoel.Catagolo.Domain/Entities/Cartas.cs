using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartasNoel.Catalogo.Domain.Entities
{
    public class Cartas
    {
        #region Construtores

        public Cartas(int id, string nome, string rua, int numero, string bairro, string cidade, string uF, int idade, string textoCarta)
        {
            Id = id;
            Nome = nome;
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            UF = uF;
            Idade = idade;
            TextoCarta = textoCarta;
        }

        public Cartas(string nome, string rua, int numero, string bairro, string cidade, string uF, int idade, string textoCarta)
        {
            Nome = nome;
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            UF = uF;
            Idade = idade;
            TextoCarta = textoCarta;
        }

        #endregion


        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Rua { get; private set; }
        public int Numero { get; private set; }
        public string Bairro { get; private set; }
        public string Cidade { get; private set; }
        public string UF { get; private set; }
        public int Idade { get; private set; }
        public string TextoCarta { get; private set; }
    }
}
