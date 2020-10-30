using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.Models.ViewModels
{
    public class CarrinhoViewModel
    {
        /// <summary>
        /// Itens do pedido
        /// </summary>
        public List<ItemPedido> Itens { get; private set; }

        /// <summary>
        /// Valor total da compra
        /// </summary>
        public decimal Total
        {
            get
            {
                return Itens.Sum(i => i.Subtotal);
            }
        }

        public CarrinhoViewModel(List<ItemPedido> Itens)
        {
            this.Itens = Itens;
        }

    }
}
