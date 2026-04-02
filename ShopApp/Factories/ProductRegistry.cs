using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp.Factories
{
    public static class ProductRegistry
    {
        private static readonly Dictionary<string, IProductFactory> _factories = new Dictionary<string, IProductFactory>();

        public static void Register(IProductFactory factory)
        {
            _factories[factory.TypeName] = factory;
        }
        public static IEnumerable<string> GetAvailableTypes() => _factories.Keys;

        public static IProductFactory GetFactory(string typeName) => _factories[typeName];

        public static IEnumerable<IProductFactory> GetAll() => _factories.Values;
    }
}
