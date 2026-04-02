using System;
using System.Collections.Generic;
using System.Text;
using ShopApp.Models.Electronics;
using ShopApp.Models.Base;

namespace ShopApp.Factories.Implementations
{
    public class LaptopFactory: IProductFactory
    {
        public string TypeName => "Laptop";
        public string CategoryName => "Электроника";
        public string Icon => "💻";

        public string[] GetUIFields() => new[] { "Бренд", "Гарантия (мес)", "Процессор", "Видеокарта", "Экран" };

        public Product Create(int  id, string name, decimal price, string desc, Dictionary<string, string> values)
        {
            return new Laptop(id, name, price, desc,
                values["Бренд"], 
                int.Parse(values["Гарантия (мес)"]),
                values["Процессор"], 
                values["Видеокарта"], 
                double.Parse(values["Экран"]));
        }
    }
}
