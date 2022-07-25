using System;
//using System.Collections.Generic;

namespace FunctionalProgramming
{
    internal static class ArgumentNullValidator
    {
        public static void NotNull(string name,
        [ValidatedNotNull] object value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(name);
            }
        }

       

    }


}


