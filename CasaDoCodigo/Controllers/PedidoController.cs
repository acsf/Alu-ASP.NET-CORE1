using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CasaDoCodigo.Models;
using CasaDoCodigo.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CasaDoCodigo.Controllers
{
    public class PedidoController : Controller
    {
        private readonly IDataService _dataService;
        public PedidoController(IDataService dataService)
        {
            this._dataService = dataService;
        }

        public IActionResult Carrossel()
        {
            List<Produto> produtos = _dataService.GetProdutos();
            return View(produtos);
        }

        public IActionResult Carrinho()
        {
            CarrinhoViewModel carrinho = GetCarrinhoViewModel();

            return View(carrinho);
        }

        private CarrinhoViewModel GetCarrinhoViewModel()
        {
            List<Produto> produtos = this._dataService.GetProdutos();//Não passo mais os intens fixos.

            var itensCarrinho = this._dataService.GetItensPedido();//Os itens vem do banco

            CarrinhoViewModel carrinho = new CarrinhoViewModel(itensCarrinho);
            return carrinho;
        }

        public IActionResult Resumo()
        {
            CarrinhoViewModel carrinho = GetCarrinhoViewModel();
            return View(carrinho);
        }
    }
}