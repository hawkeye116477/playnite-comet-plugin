﻿using Playnite.SDK.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GogOssLibraryNS.Models
{
    public class GogGameMetadata : GameMetadata
    {
        public ProductApiDetail GameDetails { get; set; }
        public StorePageResult.ProductDetails StoreDetails { get; set; }
    }
}
