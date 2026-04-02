using System;
using System.Collections.Generic;
using System.Text;
using ShopApp.Models.Base;
using ShopApp.Models.Food;

namespace ShopApp.Factories.Implementations
{
    public class WafflesFactory : IProductFactory
    {
        public string TypeName => "Waffles";
        public string CategoryName => "Еда";
        public string Icon => "🧇";

        public string[] GetUIFields() => new[] { "Начинка", "Масса", "Дней до истечения", "Калории", "Органик (да/нет)" };

        public Product Create(int id, string name, decimal price, string desc, Dictionary<string, string> values)
        {
            return new Waffles(id, name, price, desc,
                DateTime.Now.AddDays(int.Parse(values["Дней до истечения"])),
                int.Parse(values["Калории"]),
                values["Органик (да/нет)"].ToLower() == "да",
                values["Начинка"],
                int.Parse(values["Масса"]));
        }
    }
}
