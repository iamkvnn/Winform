using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms2.exception
{
    public class AlreadyExistException : ApplicationException
    {
        public AlreadyExistException(string msg) : base(msg){ }
    }
}
