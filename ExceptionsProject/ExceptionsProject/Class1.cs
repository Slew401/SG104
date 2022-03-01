using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsProject
{
    public class GradeException : ArgumentOutOfRangeException
    {
        public GradeException(string message) : base(message)
        {

        }
    }
}
