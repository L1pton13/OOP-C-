using System;
using System.Collections.Generic;
using System.Text;
using ShopApp.Models.Base;

namespace ShopApp.Factories
{
    public interface IProductFactory
    {
        string TypeName { get; }
        string CategoryName { get; }
        string Icon {  get; }
        

        string[] GetUIFields();

        Product Create(int id, string name, decimal price, string desc, Dictionary<string, string> values);
    }
}
