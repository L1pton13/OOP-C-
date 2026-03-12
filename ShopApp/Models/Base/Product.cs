using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using ShopApp.Exceptions;

namespace ShopApp.Models.Base
{
    // [Serializable] — это АТРИБУТ. Позволяет сохранять объект в файл или передавать по сети.
    [Serializable]
    public abstract class Product
    {
        // Приватные поля (инкапсуляция)
        private static int _totalCount = 0;
        private string _name;
        private decimal _price;

        // Статическое поле - счетчик для всех созданных продуктов
        public static int TotalCount => _totalCount;

        // Свойства
        public int Id { get; set; }
        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Название не может быть пустым");
                _name = value;
            }
        }

        public decimal Price
        {
            get => _price;
            set
            {
                if (value < 0)
                    throw new InvalidPriceException("Цена не может быть отрицательной");
                _price = value;
            }
        }

        public string Description { get; set; }
        public string ImagePath { get; set; }

        // ИНДЕКСАТОР — позволяет обращаться к объекту как к массиву
        public string this[int index]
        {
            get
            {
                return index switch
                {
                    0 => Name,
                    1 => Description,
                    2 => GetCategory(),
                    _ => throw new IndexOutOfRangeException("Неверный индекс характеристики товара")
                };
            }
        }

        // Конструктор
        public Product(int id, string name, decimal price, string description)
        {
            Id = id;
            Name = name;
            Price = price;
            Description = description;
            ImagePath = "/Assets/default.png";
            _totalCount++;
        }

        // Абстрактный метод - каждый наследник реализует по-своему (полиморфизм)
        public abstract string GetInfo();

        // Виртуальный метод - можно переопределить в наследнике
        public virtual decimal GetDiscount()
        {
            return 0;
        }

        public virtual string GetCategory()
        {
            return "Товар";
        }

        // Переопределение ToString
        public override string ToString()
        {
            return $"{Name} - {Price:C}";
        }

        // ДЕСТРУКТОР (Финализатор)
        ~Product()
        {
            System.Diagnostics.Debug.WriteLine($"Объект {Name} (ID: {Id}) был окончательно удален из кучи.");
        }
    }
}