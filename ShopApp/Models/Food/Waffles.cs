using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp.Models.Food
{
    public class Waffles : Food
    {
        public string Filling { get; set; }
        public int Weight { get; set; }

        public Waffles(int id, string name, decimal price, string description,
            DateTime expiryDate, int calories, bool isOrganic, string filling, int weight)
            : base(id, name, price, description, expiryDate, calories, isOrganic)
        {
            Filling = filling;
            Weight = weight;
        }

        public override string GetInfo()
        {
            return $"Вафли: {Name}\nНачинка: {Filling}\nМасса: {Weight} г\n" +
                   $"Калории: {Calories} ккал\nОрганик: {(IsOrganic ? "Да" : "Нет")}\n" +
                   $"Годен до: {ExpiryDate:dd.MM.yyyy}\nЦена: {Price:C}";
        }

        public override string GetCategory()
        {
            return "Вафли";
        }
    }
}
