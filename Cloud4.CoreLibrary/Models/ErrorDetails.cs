﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloud4.CoreLibrary.Models
{
    public class ErrorDetails
    {
        public string ErrorType { get; set; }
        public string FaultyValues { get; set; }
        public string RequestId { get; set; }


    }
}

