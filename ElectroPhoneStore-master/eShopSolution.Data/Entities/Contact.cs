﻿using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gmail { get; set; }
        public string SDT{ get; set; }
        public string Image { get; set; }
        public string Tille { get; set; }
        public bool Status { get; set; }
    }
}