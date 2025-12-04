using System;

namespace WarehouseSystem.Models
{
    /// <summary>
    /// Представляет товар в системе управления складом.
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Уникальный идентификатор товара.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Название товара.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Категория товара.
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// Цена товара.
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Инициализирует новый экземпляр класса Product.
        /// </summary>
        /// <param name="id">Идентификатор товара.</param>
        /// <param name="name">Название товара.</param>
        /// <param name="category">Категория товара.</param>
        /// <param name="price">Цена товара.</param>
        public Product(int id, string name, string category, double price)
        {
            Id = id;
            Name = name;
            Category = category;
            Price = price;
        }
    }
}