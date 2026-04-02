using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp.Models.Food
{
    public class Seaweed : Food
    {
        public string ProcessingType { get; set; }
        public double IodineContent { get; set; }

        public Seaweed(int id, string name, decimal price, string description,
            DateTime expiryDate, int calories, bool isOrganic, string processingType, double iodineContent)
            : base(id, name, price, description, expiryDate, calories, isOrganic)
        {
            ProcessingType = processingType;
            IodineContent = iodineContent;
        }

        public override string GetInfo()
        {
            return $"Морская капуста: {Name}\nВид: {ProcessingType}\nЙод: {IodineContent} мг\n" +
                   $"Калории: {Calories} ккал\nОрганик: {(IsOrganic ? "Да" : "Нет")}\n" +
                   $"Годен до: {ExpiryDate:dd.MM.yyyy}\nЦена: {Price:C}";
        }

        public override string GetCategory()
        {
            return "Морепродукты";
        }
    }
}
