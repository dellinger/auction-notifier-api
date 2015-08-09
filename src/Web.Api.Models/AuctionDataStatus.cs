using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Api.Models
{
    public class AuctionDataStatus
    {
        public virtual List<AuctionDataStatusResult> AuctionDataStatusResult { get; set; }
    }
}