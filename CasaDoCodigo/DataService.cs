using CasaDoCodigo.Models;
using System.Collections.Generic;
using System.Linq;

namespace CasaDoCodigo
{
    public class DataService : IDataService
    {
        private readonly Contexto contexto;

        public DataService(Contexto contexto)
        {
            this.contexto = contexto;
        }

        public List<ItemPedido> GetItensPedido()
        {
            return this.contexto.ItensPedido.ToList();
        }

        public List<Produto> GetProdutos()
        {
            return this.contexto.Produtos.ToList();
        }

        public void InicializaDB()
        {
            this.contexto.Database.EnsureCreated();
            if (this.contexto.Produtos.Count() == 0)
            {
                List<Produto> produtos = new List<Produto>
                {
                    new Produto ("Sleep not found", 59.90m),
                    new Produto("May the code be with you", 59.90m),
                    new Produto("Rollback", 59.90m),
                    new Produto("REST", 69.90m),
                    new Produto("Design Patterns com Java", 69.90m),
                    new Produto("Vire o jogo com Spring Framework", 69.90m),
                    new Produto("Test-Driven Development", 69.90m),
                    new Produto("iOS: Programe para iPhone e iPad", 69.90m),
                    new Produto("Desenvolvimento de Jogos para Android", 69.90m)
                };

                foreach (Produto produto in produtos)
                {
                    //Adiciona a tabela Produtos
                    this.contexto.Produtos
                        .Add(produto);

                    //Adiciona os produtos ao carrinho, tabela ItensPedido
                    //O Id dos produtos eu tenho no momento da adicação ao carrinho
                    //Então preciso de outro construtor, sem Id
                    this.contexto.ItensPedido
                        .Add(new ItemPedido(produto, 1));
                }

                this.contexto.SaveChanges();
            }

        }
    }
}
