using System;
using System.Collections.Generic;
using System.Text;
using ShopApp.Models.Base;
using ShopApp.Models.Clothing;

namespace ShopApp.Factories.Implementations
{
    public class TShirtFactory : IProductFactory
    {
        public string TypeName => "TShirt";
        public string CategoryName => "Одежда";
        public string Icon => "👕";

        public string[] GetUIFields() => new[] { "Размер", "Материал", "Пол", "Принт", "Рукав" };

        public Product Create(int id, string name, decimal price, string desc, Dictionary<string, string> values)
        {
            return new TShirt(id, name, price, desc,
                values["Размер"],
                values["Материал"],
                values["Пол"],
                values["Принт"],
                values["Рукав"]);
        }
    }
}
