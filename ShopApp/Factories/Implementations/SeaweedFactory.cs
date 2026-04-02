using System;
using System.Collections.Generic;
using System.Text;
using ShopApp.Models.Base;
using ShopApp.Models.Food;

namespace ShopApp.Factories.Implementations
{
    public class SeaweedFactory : IProductFactory
    {
        public string TypeName => "Seaweed";
        public string CategoryName => "Еда";
        public string Icon => "🌿";

        public string[] GetUIFields() => new[] { "Вид приготовления", "Йод (мг)", "Дней до истечения", "Калории", "Органик (да/нет)" };

        public Product Create(int id, string name, decimal price, string desc, Dictionary<string, string> values)
        {
            return new Seaweed(id, name, price, desc,
                DateTime.Now.AddDays(int.Parse(values["Дней до истечения"])),
                int.Parse(values["Калории"]),
                values["Органик (да/нет)"].ToLower() == "да",
                values["Вид приготовления"],
                double.Parse(values["Йод (мг)"]));
        }
    }
}
