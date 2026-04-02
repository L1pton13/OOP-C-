using System;
using System.Collections.Generic;
using System.Text;
using ShopApp.Models.Base;
using ShopApp.Models.Electronics;

namespace ShopApp.Factories.Implementations
{
    public class SmartphoneFactory : IProductFactory
    {
        public string TypeName => "Smartphone";
        public string CategoryName => "Электроника";
        public string Icon => "📱";

        public string[] GetUIFields() => new[] { "Бренд", "Гарантия (мес.)", "RAM (GB)", "Память (GB)", "ОС" };

        public Product Create(int id, string name, decimal price, string desc, Dictionary<string, string> values)
        {
            return new Smartphone(id, name, price, desc,
                values["Бренд"],
                int.Parse(values["Гарантия (мес.)"]),
                int.Parse(values["RAM (GB)"]),
                int.Parse(values["Память (GB)"]),
                values["ОС"]);
        }
    }
}
