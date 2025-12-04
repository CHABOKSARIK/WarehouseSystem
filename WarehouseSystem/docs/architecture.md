# Архитектура WarehouseSystem

## Обзор
Консольное приложение для управления складом с использованием SQLite для хранения данных.

## Модули
- **Product**: Модель продукта (Id, Name, Category, Price).
- **ProductRepository**: Работа с базой данных SQLite (создание таблицы, CRUD-операции).
- **WarehouseService**: Логика управления продуктами (добавление, получение списка).
- **Program**: Консольный интерфейс для взаимодействия с пользователем.

## Взаимодействие
- Пользователь взаимодействует с `Program`, который вызывает методы `WarehouseService`.
- `WarehouseService` использует `ProductRepository` для доступа к данным.
- `ProductRepository` взаимодействует с SQLite через ADO.NET.

## База данных
- SQLite, таблица `Products` (Id, Name, Category, Price).