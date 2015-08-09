using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Api.Models
{
    public class AuctionDataStatusResult
    {
        public virtual string Url { get; set; }
        public virtual long LastModified { get; set; }
    }
}