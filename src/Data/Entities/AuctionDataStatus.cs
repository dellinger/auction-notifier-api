using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Data.Entities
{
    public class AuctionDataStatus
    {
        public virtual List<AuctionDataStatusResult> AuctionDataStatusResult { get; set; }
        public virtual byte[] Version { get; set; }

    }
}