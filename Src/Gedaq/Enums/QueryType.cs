using System;
using System.Collections.Generic;
using System.Text;

namespace Gedaq.Enums
{
    [Flags]
    internal enum QueryType
    {
        Read = 1,
        NonQuery = 2,
        Scalar = 4
    }
}