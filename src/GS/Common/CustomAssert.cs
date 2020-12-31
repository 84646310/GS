using System;
using System.Collections.Generic;
using System.Text;

namespace GS.Common
{
    public static class CustomAssert
    {
        public static void ArgumentException(string paramName, string message)
            => throw new ArgumentException(message, paramName);

    }
}
