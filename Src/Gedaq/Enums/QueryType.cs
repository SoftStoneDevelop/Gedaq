using System;

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