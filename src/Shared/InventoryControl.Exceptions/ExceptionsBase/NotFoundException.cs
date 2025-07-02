using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryControl.Exceptions.ExceptionsBase
{
    public class NotFoundException : InventoryControlException
    {
        public NotFoundException(string message) : base(message) { }
    }
}
