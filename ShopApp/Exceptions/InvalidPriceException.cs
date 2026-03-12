using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp.Exceptions
{
    public class InvalidPriceException : Exception
    {
        public InvalidPriceException(string message) :base (message) 
        {
        }
    }
}
