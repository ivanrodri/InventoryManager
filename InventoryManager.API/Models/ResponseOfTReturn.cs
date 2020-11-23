using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InventoryManager.API.Models
{
    public sealed class Response<TReturn> : Response
    {
        public TReturn Object { get; set; }
    }
}