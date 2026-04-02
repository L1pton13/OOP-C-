using System;
using System.Collections.Generic;
using System.Text;
using ShopApp.Models.Base;
using ShopApp.Models.Food;

namespace ShopApp.Factories.Implementations
{
    public class YogurtFactory : IProductFactory
    {
        public string TypeName => "Yogurt";
        public string CategoryName => "Еда";
        public string Icon => "🥛";

        public string[] GetUIFields() => new[] { "Дней до истечения", "Калории", "Органик (да/нет)", "Вкус", "Жирность (%)" };

        public Product Create(int id, string name, decimal price, string desc, Dictionary<string, string> values)
        {
            // Логика для даты: берем текущее время и прибавляем введенные дни
            DateTime expiry = DateTime.Now.AddDays(int.Parse(values["Дней до истечения"]));
            bool isOrganic = values["Органик (да/нет)"].ToLower() == "да" || values["Органик (да/нет)"].ToLower() == "yes";

            return new Yogurt(id, name, price, desc,
                expiry,
                int.Parse(values["Калории"]),
                isOrganic,
                values["Вкус"],
                double.Parse(values["Жирность (%)"]));
        }
    }
}
