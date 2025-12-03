using System;
using WarehouseSystem.Repositories;
using WarehouseSystem.Services;

namespace WarehouseSystem
{
    class Program
    {
        static void Main()
        {
            var repository = new ProductRepository();
            var service = new WarehouseService(repository);

            while (true)
            {
                Console.WriteLine("\n1. Добавить продукт\n2. Показать продукты\n3. Выход");
                Console.Write("Выберите действие: ");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Название: ");
                        var name = Console.ReadLine();
                        Console.Write("Категория: ");
                        var category = Console.ReadLine();
                        Console.Write("Цена: ");
                        if (double.TryParse(Console.ReadLine(), out double price))
                            service.AddProduct(name, category, price);
                        else
                            Console.WriteLine("Некорректная цена.");
                        break;
                    case "2":
                        foreach (var product in service.GetAllProducts())
                            Console.WriteLine($"ID: {product.Id}, Название: {product.Name}, Категория: {product.Category}, Цена: {product.Price}");
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Неверный выбор.");
                        break;
                }
            }
        }
    }
}
