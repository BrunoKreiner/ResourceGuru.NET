﻿using System.Collections.Generic;

namespace PodioAPI.Models
{
    public class APIResponse
    {
        public dynamic Body { get; set; }
        public int Status { get; set; }
        public Dictionary<string,string> Headers { get; set; }
        public string RequestUri { get; set; }
    }
}
