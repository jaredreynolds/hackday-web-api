using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrashWebApplication1.Models
{
    public class SomePoco
    {
        public string Status { get; set; } = "blah!";
        public Guid Id { get; } = Guid.NewGuid();
    }
}