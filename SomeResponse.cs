using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrashWebApplication1
{
    public class SomeResponse : HttpResponseBase
    {
        public bool IsSomething { get; set; }
    }
}