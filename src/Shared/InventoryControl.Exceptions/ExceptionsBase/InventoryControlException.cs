using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryControl.Exceptions.ExceptionsBase
{
    public class InventoryControlException : SystemException
    {
        public InventoryControlException(string message) : base(message) { }
    }
}
