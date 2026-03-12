using System;
using System.Collections.Generic;
using System.Text;
using ShopApp.Models.Electronics;

namespace ShopApp.Models.Electronics
{
    public class Laptop : Electronics
    {
        // КОМПОЗИЦИЯ
        // Внутренний класс Processor
        public class Processor
        {
            public string Model { get; set; }
            public Processor(string model) => Model = model;
        }

        // Объект процессора создается прямо в конструкторе Laptop.
        public Processor CpuDetails { get; private set; }


        public string Cpu { get; set; }
        public string Gpu { get; set; }
        public double ScreenSize { get; set; }

        public Laptop(int id, string name, decimal price, string description,
            string brand, int warrantyMonths, string cpu, string gpu, double screenSize)
            : base(id, name, price, description, brand, warrantyMonths)
        {
            Cpu = cpu;
            Gpu = gpu;
            ScreenSize = screenSize;

            // Реализация композиции
            CpuDetails = new Processor(cpu);
        }

        public override string GetInfo()
        {
            return $"Ноутбук: {Name}\nБренд: {Brand}\nПроцессор: {CpuDetails.Model}\n" +
                   $"Видеокарта: {Gpu}\nЭкран: {ScreenSize}\"\n" +
                   $"Гарантия: {WarrantyMonths} мес.\nЦена: {Price:C}";
        }

        public override string GetCategory()
        {
            return "Ноутбуки";
        }
    }
}