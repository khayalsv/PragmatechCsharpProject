﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class NewsLetter
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public bool EmailStatus { get; set; }
    }
}