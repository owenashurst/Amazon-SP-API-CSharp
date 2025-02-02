﻿using FikaAmazonAPI.Search;
using System;
using System.Collections.Generic;
using System.Text;
using static FikaAmazonAPI.AmazonSpApiSDK.Models.VendorDirectFulfillmentOrders.OrderDetails;
using static FikaAmazonAPI.Utils.Constants;

namespace FikaAmazonAPI.Parameter.VendorDirectFulfillmentOrders
{
    public class ParameterVendorDirectFulfillmentGetOrders : ParameterBased
    {
        public string ShipFromPartyId { get; set; }
        public OrderStatusEnum Status { get; set; }
        public long? Limit { get; set; }
        public DateTime? CreatedAfter { get; set; }
        public DateTime? CreatedBefore { get; set; }
        public SortOrderEnum SortOrder { get; set; }
        public string NextToken { get; set; }
        public bool? IncludeDetails { get; set; }


    }
}
