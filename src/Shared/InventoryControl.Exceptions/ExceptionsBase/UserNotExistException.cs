using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace InventoryControl.Exceptions.ExceptionsBase
{
    public class UserNotExistException : InventoryControlException
    {
        public UserNotExistException() : base(ResourceMessagesException.USER_WITHOUT_PERMISSION_ACCESS_RESOURCE) { }

        public override IList<string> GetMessages() => [Message];

        public override HttpStatusCode GetStatusCode() => HttpStatusCode.Unauthorized;
    }
}
