﻿using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Utilities.Constants
{
    public class SystemConstants
    {
        public const string MainConnectionString = "eShopSolutionDb";
        public const string CartSession = "CartSession";

        // Để những cái key chuẩn cần thiết để set string key-value trong session
        public class AppSettings
        {
            public const string DefaultLanguageId = "DefaultLanguageId";
            public const string Token = "Token";
            public const string BaseAddress = "BaseAddress";
        }

        public class ProductSettings
        {
            public const int NumberOfFeturedProducts = 8;
            public const int NumberOfLatestProducts = 4;
        }

        public class ProductConstants
        {
            public const string NA = "N/A";
        }
    }
}