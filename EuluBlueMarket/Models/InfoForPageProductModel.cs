﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EuluBlueMarket.Models
{
    public class InfoForPageProductModel
    {
        public  IList<MarketItem> ProductModels { get; set; }
        public IList<MarketItem> ProductModelsReversed { get; set; }
        public NavigationModel NavigationModel_ { get; set; }

        public string ThisCategory { get; set; }
    }
}