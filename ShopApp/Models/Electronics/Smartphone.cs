using System;
using System.Collections.Generic;
using System.Text;
using ShopApp.Models.Electronics;

namespace ShopApp.Models.Electronics
{
    public class Smartphone : Electronics
    {
        public int Ram { get; set; }
        public int Storage { get; set; }
        public string Os { get; set; }

        public Smartphone(int id, string name, decimal price, string description,
            string brand, int warrantyMonths, int ram, int storage, string os)
            : base(id, name, price, description, brand, warrantyMonths)
        {
            Ram = ram;
            Storage = storage;
            Os = os;
        }

        public override string GetInfo()
        {
            return $"Смартфон: {Name}\nБренд: {Brand}\nОС: {Os}\n" +
                   $"RAM: {Ram}GB\nПамять: {Storage}GB\n" +
                   $"Гарантия: {WarrantyMonths} мес.\nЦена: {Price:C}";
        }

        public override string GetCategory()
        {
            return "Смартфоны";
        }
    }
}
