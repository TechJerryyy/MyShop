﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Core.ViewModels
{
    public class BasketItemViewModel
    {
        public string id { get; set; }
        public int Quantity { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public string Image { get; set; }


    }
}
