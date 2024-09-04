﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LogDTO
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string TableName { get; set; }
        public int TableID { get; set; }
        public string ProcessName { get; set; }
        public DateTime ProcessDate { get; set; }   
    }
}
