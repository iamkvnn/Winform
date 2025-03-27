using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms2.exception
{
    public class ResourceNotFoundException : ApplicationException
    {
        public ResourceNotFoundException(string msg)
            : base(msg)
            { }
    }
}
