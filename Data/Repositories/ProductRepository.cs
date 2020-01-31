using Core.Interfaces;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private static List<ProductModel> _products { get; set; } = new List<ProductModel>
        {
            new ProductModel
            {
                Id = 1,
                Nome = "product1",
                Descricao = "descricao1",
                Preco = 0
            },
            new ProductModel
            {
                Id = 2,
                Nome = "product2",
                Descricao = "descricao2",
                Preco = 0
            }
        };

        public List<ProductModel> GetAll()
        {
            return _products;
        }

        public void Create(ProductModel productModel)
        {
            _products.Add(productModel);
        }
    }
}
