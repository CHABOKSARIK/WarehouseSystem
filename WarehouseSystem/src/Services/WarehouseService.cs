using System.Collections.Generic;
using WarehouseSystem.Models;
using WarehouseSystem.Repositories;

namespace WarehouseSystem.Services
{
    public class WarehouseService
    {
        private readonly ProductRepository _repository;

        public WarehouseService(ProductRepository repository)
        {
            _repository = repository;
        }

        public void AddProduct(string name, string category, double price)
        {
            var product = new Product(0, name, category, price);
            _repository.AddProduct(product);
        }

        public List<Product> GetAllProducts()
        {
            return _repository.GetAllProducts();
        }
    }
}