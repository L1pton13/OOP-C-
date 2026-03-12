using System;
using System.Collections.Generic;
using System.Text;
using ShopApp.Models.Base;

namespace ShopApp.Models.Electronics
{
    public abstract class Electronics : Product
    {
        public string Brand {  get; set; }
        public int WarrantyMonths { get; set; }

        public Electronics (int id, string name, decimal price, string description, string brand, int  warrantyMonths) 
            : base(id, name, price, description)
        {
            Brand = brand;
            WarrantyMonths = warrantyMonths;
        }

        public override string GetInfo()
        {
            return $"Электроника: {Name}\nБренд: {Brand}\nГарантия: {WarrantyMonths} мес.\nЦена: {Price:C}";
        }

        public override string GetCategory()
        {
            return "Электроника";
        }

        public override decimal GetDiscount()
        {
            return WarrantyMonths >= 24 ? 0.05m : 0;
        }
    }
}
