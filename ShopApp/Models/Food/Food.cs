using System;
using System.Collections.Generic;
using System.Text;
using ShopApp.Models.Base;

namespace ShopApp.Models.Food
{
    public abstract class Food : Product 
    {
        public DateTime ExpiryDate { get; set; }
        public int Calories { get; set; }
        public bool IsOrganic { get; set; }

        public Food(int id, string name, decimal price, string description, DateTime expiryDate, int calories, bool isOrganic)
            : base(id, name, price, description)
        {
            ExpiryDate = expiryDate;
            Calories = calories;
            IsOrganic = isOrganic;
        }

        public override string GetInfo()
        {
            return $"Еда: {Name}\nКалории: {Calories} ккал\nОрганик: {(IsOrganic ? "Да" : "Нет")}\nГоден до: {ExpiryDate:dd.MM.yyyy}\nЦена: {Price:C}";
        }

        public override string GetCategory()
        {
            return "Еда";
        }

        public override decimal GetDiscount()
        {
            return IsOrganic ? 0.03m : 0;
        }
    }
}
