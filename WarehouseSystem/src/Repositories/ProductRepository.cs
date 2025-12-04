using System.Collections.Generic;
using System.Data.SQLite;
using WarehouseSystem.Models;

namespace WarehouseSystem.Repositories
{
    /// <summary>
    /// Предоставляет методы для работы с данными товаров в базе данных SQLite.
    /// </summary>
    public class ProductRepository
    {
        private readonly string _connectionString = "Data Source=warehouse.db;Version=3;";

        /// <summary>
        /// Инициализирует новый экземпляр класса ProductRepository и базу данных.
        /// </summary>
        public ProductRepository()
        {
            InitializeDatabase();
        }

        /// <summary>
        /// Инициализирует базу данных, создавая таблицу Products, если она не существует.
        /// </summary>
        private void InitializeDatabase()
        {
            var connection = new SQLiteConnection(_connectionString);
            connection.Open();
            var command = new SQLiteCommand(
                "CREATE TABLE IF NOT EXISTS Products (Id INTEGER PRIMARY KEY AUTOINCREMENT, Name TEXT NOT NULL, Category TEXT NOT NULL, Price REAL NOT NULL)",
                connection);
            command.ExecuteNonQuery();
        }

        /// <summary>
        /// Добавляет новый товар в базу данных.
        /// </summary>
        /// <param name="product">Товар для добавления.</param>
        public void AddProduct(Product product)
        {
            var connection = new SQLiteConnection(_connectionString);
            connection.Open();
            var command = new SQLiteCommand(
                "INSERT INTO Products (Name, Category, Price) VALUES (@name, @category, @price)",
                connection);
            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@category", product.Category);
            command.Parameters.AddWithValue("@price", product.Price);
            command.ExecuteNonQuery();
        }

        /// <summary>
        /// Получает все товары из базы данных.
        /// </summary>
        /// <returns>Список всех товаров.</returns>
        public List<Product> GetAllProducts()
        {
            var products = new List<Product>();
            var connection = new SQLiteConnection(_connectionString);
            connection.Open();
            var command = new SQLiteCommand("SELECT * FROM Products", connection);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                products.Add(new Product(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetDouble(3)
                ));
            }
            return products;
        }
    }
}