using System;
using System.Collections.Generic;
using System.Text;

namespace CourseSignupSystemUtilities.Exceptions
{
    public class CSSExceptions: Exception
    {
        public CSSExceptions()
        {

        }
        public CSSExceptions(string message)
            :base(message)
        {

        }
        public CSSExceptions(string message, Exception inner)
            : base(message,inner)
        {

        }
    }
}
