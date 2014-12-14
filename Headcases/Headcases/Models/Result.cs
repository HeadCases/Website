using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Headcases.Models
{
    public class Result
    {
        public bool Survived { get; set; }
        public decimal Probability { get; set; }
        public bool Error { get; set; }
        public string Message { get; set; }
    }
}