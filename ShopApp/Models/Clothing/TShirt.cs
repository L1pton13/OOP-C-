using System;
using System.Collections.Generic;
using System.Text;
using ShopApp.Models.Clothing;

namespace ShopApp.Models.Clothing
{
    public class TShirt : Clothing
    {
        public string PrintDesign { get; set; }
        public string SleeveType { get; set; }

        public TShirt(int id, string name, decimal price, string description,
            string size, string material, string gender, string printDesign, string sleeveType)
            : base(id, name, price, description, size, material, gender)
        {
            PrintDesign = printDesign;
            SleeveType = sleeveType;
        }

        public override string GetInfo()
        {
            return $"Футболка: {Name}\nРазмер: {Size}\nМатериал: {Material}\n" +
                   $"Пол: {Gender}\nПринт: {PrintDesign}\n" +
                   $"Рукав: {SleeveType}\nЦена: {Price:C}";
        }

        public override string GetCategory()
        {
            return "Футболки";
        }
    }
}
