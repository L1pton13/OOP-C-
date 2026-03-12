using System;
using System.Collections.Generic;
using System.Text;
using ShopApp.Models.Base;

namespace ShopApp.Models.Clothing
{
    public abstract class Clothing : Product
    {
        public string Size { get; set; }
        public string Material { get; set; }
        public string Gender { get; set; }

        public Clothing(int id, string name, decimal price, string description, string size, string material, string gender)
            : base(id, name, price, description)
        {
            Size = size;
            Material = material;
            Gender = gender;
        }

        public override string GetInfo()
        {
            return $"Одежда: {Name}\nРазмер: {Size}\nМатериал: {Material}\nПол: {Gender}\nЦена: {Price:C}";
        }

        public override string GetCategory()
        {
            return "Одежда";
        }

        public override decimal GetDiscount()
        {
            return 0.1m;
        }

    }
}
