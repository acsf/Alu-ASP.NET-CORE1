using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.Models
{
    public class Produto
    {
        /// <summary>
        /// Id do produto
        /// </summary>
        public int Id { get; private set; }

        /// <summary>
        /// Nome do produto
        /// </summary>
        public string Nome { get; private set; }

        /// <summary>
        /// Preço do produto
        /// </summary>
        public decimal Preco { get; private set; }

        public Produto(int id, string nome, decimal preco)
        {
            this.Id = id;
            this.Nome = nome;
            this.Preco = preco;
        }

    }
}
