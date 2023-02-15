using System;
using System.Collections.Generic;
using System.Text;

namespace Gedaq.Enums
{
    [Flags]
    internal enum MethodType
    {
        Sync = 1,
        Async = 2
    }
}