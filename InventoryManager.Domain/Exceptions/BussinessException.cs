using System;

namespace InventoryManager.Domain.Exceptions
{
    public class BussinessException : Exception
    {
        public BussinessException(){ }

        public BussinessException(string message) : base (message)
        {

        }
    }
}
