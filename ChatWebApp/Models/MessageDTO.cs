﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChatWebApp.Models
{
    public class MessageDTO
    {
        public int ID { get; set; }
        public string Message { get; set; }
        public string Class { get; set; }
    }
}