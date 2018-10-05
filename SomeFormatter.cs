using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Text;
using System.Web;
using TrashWebApplication1.Models;

namespace TrashWebApplication1
{
    public class SomeFormatter : System.Net.Http.Formatting.JsonMediaTypeFormatter
    {
        public override bool CanReadType(Type type)
        {
            return false;
        }

        public override bool CanWriteType(Type type)
        {
            return type == typeof(SomePoco);
        }

        public override void WriteToStream(Type type, object value, Stream writeStream, Encoding effectiveEncoding)
        {
            var v = (SomePoco)value;
            var d = new Dictionary<string, object>
            {
                { "InterpretedStatus", $"Interpreted: {v.Status}" },
                { "MyId", v.Id }
            };
            base.WriteToStream(type, d, writeStream, effectiveEncoding);
        }
    }
}