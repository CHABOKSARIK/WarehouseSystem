using System.Collections.Generic;
using WarehouseSystem.Models;
using WarehouseSystem.Repositories;

namespace WarehouseSystem.Services
{
    /// <summary>
    /// Предоставляет бизнес-логику для работы со складом.
    /// </summary>
    public class WarehouseService
    {
        private readonly ProductRepository _repository;

        /// <summary>
        /// Инициализирует новый экземпляр класса WarehouseService.
        /// </summary>
        /// <param name="repository">Репозиторий для работы с товарами.</param>
        public WarehouseService(ProductRepository repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// Добавляет новый товар на склад.
        /// </summary>
        /// <param name="name">Название товара.</param>
        /// <param name="category">Категория товара.</param>
        /// <param name="price">Цена товара.</param>
        public void AddProduct(string name, string category, double price)
        {
            var product = new Product(0, name, category, price);
            _repository.AddProduct(product);
        }

        /// <summary>
        /// Получает все товары со склада.
        /// </summary>
        /// <returns>Список всех товаров.</returns>
        public List<Product> GetAllProducts()
        {
            return _repository.GetAllProducts();
        }
    }
}