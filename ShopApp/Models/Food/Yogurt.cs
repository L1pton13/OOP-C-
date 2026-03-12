using System;
using System.Collections.Generic;
using System.Text;
using ShopApp.Models.Food;

namespace ShopApp.Models.Food
{
    public class Yogurt : Food
    {
        public string Flavor { get; set; }
        public double FatPercentage { get; set; }

        public Yogurt(int id, string name, decimal price, string description,
            DateTime expiryDate, int calories, bool isOrganic, string flavor, double fatPercentage)
            : base(id, name, price, description, expiryDate, calories, isOrganic)
        {
            Flavor = flavor;
            FatPercentage = fatPercentage;
        }

        public override string GetInfo()
        {
            return $"Йогурт: {Name}\nВкус: {Flavor}\nЖирность: {FatPercentage}%\n" +
                   $"Калории: {Calories} ккал\nОрганик: {(IsOrganic ? "Да" : "Нет")}\n" +
                   $"Годен до: {ExpiryDate:dd.MM.yyyy}\nЦена: {Price:C}";
        }

        public override string GetCategory()
        {
            return "Йогурты";
        }
    }
}
