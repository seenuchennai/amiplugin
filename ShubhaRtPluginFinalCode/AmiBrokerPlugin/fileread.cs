﻿using System;
using System.Collections.Generic;
using System.Text;
using FileHelpers;

namespace AmiBrokerPlugin
{
    [DelimitedRecord(",")]
    public class fileread
    {
        public string index;
        public string name;
        public string time;
        public string ltp;
        public string volume;
        
    }

    
}
