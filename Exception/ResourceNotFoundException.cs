﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms2.Exception
{
    public class ResourceNotFoundException : ApplicationException
    {
        public ResourceNotFoundException(string msg)
            : base(msg)
            { }
    }
}
