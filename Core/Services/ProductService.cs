using Core.Interfaces;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Services
{
    public class ProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public List<ProductModel> GetAllWithPrices()
        {
            var productsWithPrice = new List<ProductModel>();

            foreach (var product in _productRepository.GetAll())
            {
                var newProduct = new ProductModel
                {
                    Id = product.Id,
                    Nome = product.Nome,
                    Descricao = product.Descricao,
                    Preco = 10 //regra de negócio
                };
                productsWithPrice.Add(newProduct);
            }

            return productsWithPrice;
        }

        public void CreateWithoutPrice(ProductModel productModel)
        {
            productModel.Preco = -1; //regra de negócio
            _productRepository.Create(productModel);
        }
    }
}
