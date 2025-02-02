﻿using FikaAmazonAPI.Search;
using System;
using System.Collections.Generic;
using System.Text;
using static FikaAmazonAPI.Utils.Constants;

namespace FikaAmazonAPI.Parameter.ProductPricing
{
    public class ParameterGetItemOffers : ParameterBased
    {
        public string MarketplaceId { get; set; }
        public string Asin { get; set; }
        public CustomerType? CustomerType { get; set; }
        public ItemCondition ItemCondition { get; set; }
    }
}
