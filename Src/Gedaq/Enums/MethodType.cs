using System;

namespace Gedaq.Enums
{
    [Flags]
    internal enum MethodType
    {
        Sync = 1,
        Async = 2
    }
}