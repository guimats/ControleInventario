using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace InventoryControl.Exceptions.ExceptionsBase
{
    public class RefreshTokenNotFoundException : InventoryControlException
    {
        public RefreshTokenNotFoundException() : base(ResourceMessagesException.NO_TOKEN) { }

        public override IList<string> GetMessages() => [Message];

        public override HttpStatusCode GetStatusCode() => HttpStatusCode.Unauthorized;
    }

}
