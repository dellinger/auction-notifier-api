using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Web.Api.Models;
using Web.Common.Routing;

namespace Web.Api.Controllers.V1
{
    [ApiVersion1RoutePrefix("AuctionDataStatus")]
    public class AuctionDataStatusController : ApiController
    {
        public AuctionDataStatus getAuctionDataStatus()
        {
            // Return mock data for now
            AuctionDataStatus auctionDataStatus = new AuctionDataStatus();
            AuctionDataStatusResult auctionDataStatusResult = new AuctionDataStatusResult();

            auctionDataStatusResult.Url = "tempUrl";
            auctionDataStatusResult.LastModified = new DateTime().Date.ToBinary();
            auctionDataStatus.AuctionDataStatusResult = new List<AuctionDataStatusResult>();
            auctionDataStatus.AuctionDataStatusResult.Add(auctionDataStatusResult);
            return auctionDataStatus;
        }
    }
}