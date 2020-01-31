using Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Interfaces
{
    public interface IProductRepository
    {
        List<ProductModel> GetAll();
        void Create(ProductModel productModel);
    }
}
