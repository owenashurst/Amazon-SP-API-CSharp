﻿using FikaAmazonAPI.Search;
using System;
using System.Collections.Generic;
using System.Text;
using static FikaAmazonAPI.Utils.Constants;

namespace FikaAmazonAPI.Parameter.Sales
{
    public class ParameterGetOrderMetrics : ParameterBased
    {
        public IList<string> marketplaceIds { get; set; }
        public string interval { get; set; }
        public string granularityTimeZone { get; set; }
        public GranularityEnum granularity { get; set; }
        public BuyerType? buyerType { get; set; }
        public string fulfillmentNetwork { get; set; }
        public string asin { get; set; }
        public string sku { get; set; }
        public FirstDayOfWeek firstDayOfWeek { get; set; }

    }
}
