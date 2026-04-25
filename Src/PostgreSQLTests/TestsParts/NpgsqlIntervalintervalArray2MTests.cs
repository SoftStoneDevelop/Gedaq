

using Npgsql;
using NpgsqlTypes;
using Gedaq.Common.Enums;
using Gedaq.Npgsql.Attributes;
using Gedaq.Npgsql.Enums;
using System;


using System.Linq;
using NUnit.Framework;
using System.Data.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tests
{
    internal partial interface INpgsqlIntervalListintervalArray
    {
    }
    
    internal partial class NpgsqlIntervalListintervalArray : INpgsqlIntervalListintervalArray
    {


#region TestData

        private readonly NpgsqlIntervalintervalArray2M[] _testData = new NpgsqlIntervalintervalArray2M[]
        {
            new NpgsqlIntervalintervalArray2M
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3234),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4056),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1700),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4966),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2257),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4832),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 718),

},
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1299),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2753),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2682),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 351),

},
    ModelInner = new NpgsqlIntervalintervalArray2MI
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3009),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3320),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4628),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2911),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1994),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1044),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4924),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2994),

},
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3312),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1651),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3645),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3732),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4489),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1793),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 82),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2452),

},
    ModelInner = new NpgsqlIntervalintervalArray2MI
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3741),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2744),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1647),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1677),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4938),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2321),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3561),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 292),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3335),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1874),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4029),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4202),

},
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4177),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3547),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 963),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4178),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4739),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4920),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2442),

},
    ModelInner = new NpgsqlIntervalintervalArray2MI
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3702),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4200),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3366),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 188),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4873),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 319),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 428),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1642),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2112),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3247),

},
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1069),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3741),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2461),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4361),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3480),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2949),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3591),

},
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 963),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3247),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1689),

},
    ModelInner = new NpgsqlIntervalintervalArray2MI
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 581),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1096),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3985),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4936),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1223),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 380),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1481),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3530),

},
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 184),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4938),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2519),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1425),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4111),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1508),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4161),

},
    ModelInner = new NpgsqlIntervalintervalArray2MI
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1671),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2553),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4663),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3835),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3064),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2815),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 504),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 972),

},
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3061),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 799),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4898),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3190),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3415),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1348),

},
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1253),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 711),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2599),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1906),

},
    ModelInner = new NpgsqlIntervalintervalArray2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 376),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 859),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1498),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 795),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1303),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3812),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 800),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3991),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1645),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1244),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 474),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2906),

},
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 804),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 365),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1168),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4022),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3020),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 167),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4075),

},
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1811),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3282),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3019),

},
    ModelInner = new NpgsqlIntervalintervalArray2MI
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3228),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2017),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4477),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 521),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3453),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1601),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 776),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3252),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4494),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1165),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2072),

},
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1821),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4322),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2142),

},
    ModelInner = new NpgsqlIntervalintervalArray2MI
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3932),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4657),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3172),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2387),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4925),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3810),

},
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 786),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3972),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2060),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3031),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2054),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2631),

},
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 100,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1989),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3697),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2158),

},
    ModelInner = new NpgsqlIntervalintervalArray2MI
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4116),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2803),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4730),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1329),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 707),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 287),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1085),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4383),

},
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 106,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4935),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2999),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4149),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 113,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 921),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2345),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 204),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2045),

},
    ModelInner = new NpgsqlIntervalintervalArray2MI
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2903),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 647),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 806),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2797),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 418),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1032),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4320),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3247),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4256),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1355),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 354),

},
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 117,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1469),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4648),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1655),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3419),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2214),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4622),

},
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 118,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 246),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 770),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2603),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 463),

},
    ModelInner = new NpgsqlIntervalintervalArray2MI
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3626),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1451),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2127),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3307),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 120,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1969),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 832),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3746),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4635),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1017),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2816),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 153),

},
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 128,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1313),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2221),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1416),

},
    ModelInner = new NpgsqlIntervalintervalArray2MI
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3108),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3211),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3623),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3542),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3115),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 676),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 888),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 872),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 113),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2787),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4231),

},
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 136,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1303),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 479),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4322),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 499),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2195),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1230),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3921),

},
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 139,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 222),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1214),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3321),

},
    ModelInner = new NpgsqlIntervalintervalArray2MI
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1760),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4970),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3492),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4070),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2250),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3672),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1123),

},
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 146,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4354),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3739),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1658),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1524),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3560),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4892),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4071),

},
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 148,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1502),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3873),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 78),

},
    ModelInner = new NpgsqlIntervalintervalArray2MI
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4439),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4925),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4716),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 42),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4702),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1431),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2534),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 35),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2174),

},
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 150,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3850),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1914),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3019),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3033),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 156,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1112),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3994),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 655),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4201),

},
    ModelInner = new NpgsqlIntervalintervalArray2MI
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2906),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4351),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2284),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1472),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4878),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2109),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4938),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1064),

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlintervalintervalarray2mi(
	id,
    value,
    nullablevalue
)
VALUES (
    $1, 
    $2, 
    $3
);
",
            methodName:"InsertModelInner",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlintervalintervalarray2mi(
	id,
    value,
    nullablevalue
)
VALUES (
    $1, 
    $2, 
    $3
)
RETURNING
    id,
    value,
    nullablevalue
;
",
            methodName:"InsertModelInnerReturning",
            queryMapTypes: [typeof(NpgsqlIntervalintervalArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618))]
        public void InsertModelInnerReturningConfig()
        {
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows =  ((INpgsqlIntervalListintervalArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlIntervalListintervalArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows = await ((INpgsqlIntervalListintervalArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlIntervalListintervalArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id =  ((INpgsqlIntervalListintervalArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlIntervalListintervalArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[11].ModelInner.Id));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id = await ((INpgsqlIntervalListintervalArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlIntervalListintervalArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlIntervalListintervalArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlIntervalListintervalArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlIntervalListintervalArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlIntervalListintervalArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlIntervalListintervalArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlIntervalListintervalArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlIntervalListintervalArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlintervalintervalarray2m(
	id,
    value,
    nullablevalue,
    npgsqlintervalintervalarray2mi_id
)
VALUES (
    $1, 
    $2, 
    $3,
    $4
);
",
            methodName:"InsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlintervalintervalarray2mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;
                changedRows =  ((INpgsqlIntervalListintervalArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlIntervalListintervalArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;
                changedRows = await ((INpgsqlIntervalListintervalArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlIntervalListintervalArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlintervalintervalarray2m(
	id,
    value,
    nullablevalue,
    npgsqlintervalintervalarray2mi_id
)
VALUES (
    $1, 
    $2, 
    $3,
    $4
)
RETURNING
    nullablevalue,
    value,
~StartInner::ModelInner:Id~
~Reinterpret::Id~
    npgsqlintervalintervalarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlIntervalintervalArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlintervalintervalarray2m(
	id,
    value,
    nullablevalue,
    npgsqlintervalintervalarray2mi_id
)
VALUES (
    $1, 
    $2, 
    $3,
    $4
)
RETURNING
    nullablevalue,
    value,
~StartInner::ModelInner:Id~
~Reinterpret::Id~
    npgsqlintervalintervalarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlIntervalintervalArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlintervalintervalarray2mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlIntervalintervalArray2M> models = null;

                models =  ((INpgsqlIntervalListintervalArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlIntervalListintervalArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlIntervalListintervalArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlIntervalListintervalArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlIntervalintervalArray2M> models = null;

                models = await ((INpgsqlIntervalListintervalArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlIntervalListintervalArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlIntervalListintervalArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlIntervalListintervalArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlIntervalListintervalArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlIntervalListintervalArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlIntervalListintervalArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlIntervalListintervalArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlIntervalListintervalArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlIntervalListintervalArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlIntervalListintervalArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlIntervalListintervalArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlIntervalListintervalArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlIntervalListintervalArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlIntervalListintervalArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlIntervalListintervalArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlIntervalListintervalArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlIntervalListintervalArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlIntervalListintervalArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlIntervalListintervalArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlIntervalListintervalArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlIntervalListintervalArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlIntervalintervalArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalArray)),
Gedaq.Npgsql.Attributes.DynamicParametr()]
        private void DynQuerySelectModelDynParConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQuerySelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlintervalintervalarray2m m
LEFT JOIN public.npgsqlintervalintervalarray2mi mi ON mi.id = m.npgsqlintervalintervalarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models = await ((INpgsqlIntervalListintervalArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlIntervalintervalArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DynQuerySelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlintervalintervalarray2m m
LEFT JOIN public.npgsqlintervalintervalarray2mi mi ON mi.id = m.npgsqlintervalintervalarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models =  ((INpgsqlIntervalListintervalArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlIntervalintervalArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: 
@"
SELECT
    m.id,
    m.value,
~StartInner::ModelInner:Id~
    mi.id,
    mi.value,
    mi.nullablevalue,
~EndInner::ModelInner~
    m.nullablevalue
FROM public.npgsqlintervalintervalarray2m m
LEFT JOIN public.npgsqlintervalintervalarray2mi mi ON mi.id = m.npgsqlintervalintervalarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlIntervalintervalArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalArray)),
Gedaq.Npgsql.Attributes.DynamicParametr()]
        private void SelectModelDynParConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models = await ((INpgsqlIntervalListintervalArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlIntervalintervalArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models =  ((INpgsqlIntervalListintervalArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlIntervalintervalArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlIntervalintervalArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalArray)),
Gedaq.Npgsql.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            position: 1,
            methodParametrName: "id",
            dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        private void DynQuerySelectModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQuerySelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlintervalintervalarray2m m
LEFT JOIN public.npgsqlintervalintervalarray2mi mi ON mi.id = m.npgsqlintervalintervalarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlIntervalListintervalArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlIntervalintervalArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DynQuerySelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlintervalintervalarray2m m
LEFT JOIN public.npgsqlintervalintervalarray2mi mi ON mi.id = m.npgsqlintervalintervalarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models =  ((INpgsqlIntervalListintervalArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlIntervalintervalArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: 
@"
SELECT
    m.id,
    m.value,
~StartInner::ModelInner:Id~
    mi.id,
    mi.value,
    mi.nullablevalue,
~EndInner::ModelInner~
    m.nullablevalue
FROM public.npgsqlintervalintervalarray2m m
LEFT JOIN public.npgsqlintervalintervalarray2mi mi ON mi.id = m.npgsqlintervalintervalarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlIntervalintervalArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalArray)),
Gedaq.Npgsql.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            position: 1,
            methodParametrName: "id",
            dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        private void SelectModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlIntervalListintervalArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlIntervalintervalArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlIntervalListintervalArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlIntervalintervalArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlIntervalintervalArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
            position: 2)]
        private void DbConnectionDynQuerySelectModelDynParBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlintervalintervalarray2m m
LEFT JOIN public.npgsqlintervalintervalarray2mi mi ON mi.id = m.npgsqlintervalintervalarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models = await ((INpgsqlIntervalListintervalArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlIntervalintervalArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 27;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 100;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlintervalintervalarray2m m
LEFT JOIN public.npgsqlintervalintervalarray2mi mi ON mi.id = m.npgsqlintervalintervalarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlintervalintervalarray2m m
LEFT JOIN public.npgsqlintervalintervalarray2mi mi ON mi.id = m.npgsqlintervalintervalarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlIntervalListintervalArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));
FlatNpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[5], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[1],_testData[6], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[2],_testData[7], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[3],_testData[8], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[4],_testData[9], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[5],_testData[10], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[6],_testData[11], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[7],_testData[12], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[8],_testData[13], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[9],_testData[14], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[10],_testData[15], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[11],_testData[16], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[12],_testData[17], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[13],_testData[18], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[14],_testData[19], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[15],_testData[20], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[16],_testData[21], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[17],_testData[22], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[18],_testData[23], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[19],_testData[24], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[20],_testData[25], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[21],_testData[26], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[22],_testData[27], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[23],_testData[28], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));
FlatNpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[18], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[1],_testData[19], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[2],_testData[20], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[3],_testData[21], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[4],_testData[22], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[5],_testData[23], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[6],_testData[24], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[7],_testData[25], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[8],_testData[26], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[9],_testData[27], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[10],_testData[28], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlintervalintervalarray2m m
LEFT JOIN public.npgsqlintervalintervalarray2mi mi ON mi.id = m.npgsqlintervalintervalarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models =  ((INpgsqlIntervalListintervalArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlIntervalintervalArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 34;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 146;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlintervalintervalarray2m m
LEFT JOIN public.npgsqlintervalintervalarray2mi mi ON mi.id = m.npgsqlintervalintervalarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlintervalintervalarray2m m
LEFT JOIN public.npgsqlintervalintervalarray2mi mi ON mi.id = m.npgsqlintervalintervalarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlIntervalListintervalArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
FlatNpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[6], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[1],_testData[7], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[2],_testData[8], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[3],_testData[9], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[4],_testData[10], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[5],_testData[11], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[6],_testData[12], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[7],_testData[13], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[8],_testData[14], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[9],_testData[15], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[10],_testData[16], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[11],_testData[17], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[12],_testData[18], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[13],_testData[19], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[14],_testData[20], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[15],_testData[21], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[16],_testData[22], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[17],_testData[23], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[18],_testData[24], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[19],_testData[25], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[20],_testData[26], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[21],_testData[27], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[22],_testData[28], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));
FlatNpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[27], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[1],_testData[28], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 

@"
SELECT
    m.id,
    m.value,
~StartInner::ModelInner:Id~
    mi.id,
    mi.value,
    mi.nullablevalue,
~EndInner::ModelInner~
    m.nullablevalue
FROM public.npgsqlintervalintervalarray2m m
LEFT JOIN public.npgsqlintervalintervalarray2mi mi ON mi.id = m.npgsqlintervalintervalarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlIntervalintervalArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModelDynPar",
            position: 2)]
        private void DbConnectionSelectModelDynParBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models = await ((INpgsqlIntervalListintervalArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlIntervalintervalArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 146;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 113;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlIntervalListintervalArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));
NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[27], false);NpgsqlIntervalintervalArray2M.AssertModel(models[1],_testData[28], false);NpgsqlIntervalintervalArray2M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));
NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[20], false);NpgsqlIntervalintervalArray2M.AssertModel(models[1],_testData[21], false);NpgsqlIntervalintervalArray2M.AssertModel(models[2],_testData[22], false);NpgsqlIntervalintervalArray2M.AssertModel(models[3],_testData[23], false);NpgsqlIntervalintervalArray2M.AssertModel(models[4],_testData[24], false);NpgsqlIntervalintervalArray2M.AssertModel(models[5],_testData[25], false);NpgsqlIntervalintervalArray2M.AssertModel(models[6],_testData[26], false);NpgsqlIntervalintervalArray2M.AssertModel(models[7],_testData[27], false);NpgsqlIntervalintervalArray2M.AssertModel(models[8],_testData[28], false);NpgsqlIntervalintervalArray2M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models =  ((INpgsqlIntervalListintervalArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlIntervalintervalArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 18;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 100;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlIntervalListintervalArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[3], false);NpgsqlIntervalintervalArray2M.AssertModel(models[1],_testData[4], false);NpgsqlIntervalintervalArray2M.AssertModel(models[2],_testData[5], false);NpgsqlIntervalintervalArray2M.AssertModel(models[3],_testData[6], false);NpgsqlIntervalintervalArray2M.AssertModel(models[4],_testData[7], false);NpgsqlIntervalintervalArray2M.AssertModel(models[5],_testData[8], false);NpgsqlIntervalintervalArray2M.AssertModel(models[6],_testData[9], false);NpgsqlIntervalintervalArray2M.AssertModel(models[7],_testData[10], false);NpgsqlIntervalintervalArray2M.AssertModel(models[8],_testData[11], false);NpgsqlIntervalintervalArray2M.AssertModel(models[9],_testData[12], false);NpgsqlIntervalintervalArray2M.AssertModel(models[10],_testData[13], false);NpgsqlIntervalintervalArray2M.AssertModel(models[11],_testData[14], false);NpgsqlIntervalintervalArray2M.AssertModel(models[12],_testData[15], false);NpgsqlIntervalintervalArray2M.AssertModel(models[13],_testData[16], false);NpgsqlIntervalintervalArray2M.AssertModel(models[14],_testData[17], false);NpgsqlIntervalintervalArray2M.AssertModel(models[15],_testData[18], false);NpgsqlIntervalintervalArray2M.AssertModel(models[16],_testData[19], false);NpgsqlIntervalintervalArray2M.AssertModel(models[17],_testData[20], false);NpgsqlIntervalintervalArray2M.AssertModel(models[18],_testData[21], false);NpgsqlIntervalintervalArray2M.AssertModel(models[19],_testData[22], false);NpgsqlIntervalintervalArray2M.AssertModel(models[20],_testData[23], false);NpgsqlIntervalintervalArray2M.AssertModel(models[21],_testData[24], false);NpgsqlIntervalintervalArray2M.AssertModel(models[22],_testData[25], false);NpgsqlIntervalintervalArray2M.AssertModel(models[23],_testData[26], false);NpgsqlIntervalintervalArray2M.AssertModel(models[24],_testData[27], false);NpgsqlIntervalintervalArray2M.AssertModel(models[25],_testData[28], false);NpgsqlIntervalintervalArray2M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));
NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[18], false);NpgsqlIntervalintervalArray2M.AssertModel(models[1],_testData[19], false);NpgsqlIntervalintervalArray2M.AssertModel(models[2],_testData[20], false);NpgsqlIntervalintervalArray2M.AssertModel(models[3],_testData[21], false);NpgsqlIntervalintervalArray2M.AssertModel(models[4],_testData[22], false);NpgsqlIntervalintervalArray2M.AssertModel(models[5],_testData[23], false);NpgsqlIntervalintervalArray2M.AssertModel(models[6],_testData[24], false);NpgsqlIntervalintervalArray2M.AssertModel(models[7],_testData[25], false);NpgsqlIntervalintervalArray2M.AssertModel(models[8],_testData[26], false);NpgsqlIntervalintervalArray2M.AssertModel(models[9],_testData[27], false);NpgsqlIntervalintervalArray2M.AssertModel(models[10],_testData[28], false);NpgsqlIntervalintervalArray2M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlIntervalintervalArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalArray)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionDynQuerySelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
            position: 2)]
        private void DbConnectionDynQuerySelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlintervalintervalarray2m m
LEFT JOIN public.npgsqlintervalintervalarray2mi mi ON mi.id = m.npgsqlintervalintervalarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlIntervalListintervalArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlIntervalintervalArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlintervalintervalarray2m m
LEFT JOIN public.npgsqlintervalintervalarray2mi mi ON mi.id = m.npgsqlintervalintervalarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlintervalintervalarray2m m
LEFT JOIN public.npgsqlintervalintervalarray2mi mi ON mi.id = m.npgsqlintervalintervalarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlIntervalListintervalArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 136, query1, 48, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));
FlatNpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[25], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[1],_testData[26], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[2],_testData[27], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[3],_testData[28], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));
FlatNpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[8], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[1],_testData[9], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[2],_testData[10], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[3],_testData[11], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[4],_testData[12], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[5],_testData[13], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[6],_testData[14], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[7],_testData[15], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[8],_testData[16], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[9],_testData[17], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[10],_testData[18], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[11],_testData[19], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[12],_testData[20], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[13],_testData[21], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[14],_testData[22], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[15],_testData[23], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[16],_testData[24], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[17],_testData[25], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[18],_testData[26], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[19],_testData[27], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[20],_testData[28], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlintervalintervalarray2m m
LEFT JOIN public.npgsqlintervalintervalarray2mi mi ON mi.id = m.npgsqlintervalintervalarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((INpgsqlIntervalListintervalArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlIntervalintervalArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlintervalintervalarray2m m
LEFT JOIN public.npgsqlintervalintervalarray2mi mi ON mi.id = m.npgsqlintervalintervalarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlintervalintervalarray2m m
LEFT JOIN public.npgsqlintervalintervalarray2mi mi ON mi.id = m.npgsqlintervalintervalarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlIntervalListintervalArray)this).DbConnectionDynQuerySelectModelBatch(connection, 18, query1, 92, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
FlatNpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[3], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[1],_testData[4], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[2],_testData[5], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[3],_testData[6], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[4],_testData[7], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[5],_testData[8], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[6],_testData[9], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[7],_testData[10], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[8],_testData[11], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[9],_testData[12], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[10],_testData[13], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[11],_testData[14], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[12],_testData[15], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[13],_testData[16], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[14],_testData[17], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[15],_testData[18], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[16],_testData[19], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[17],_testData[20], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[18],_testData[21], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[19],_testData[22], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[20],_testData[23], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[21],_testData[24], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[22],_testData[25], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[23],_testData[26], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[24],_testData[27], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[25],_testData[28], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
FlatNpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[16], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[1],_testData[17], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[2],_testData[18], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[3],_testData[19], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[4],_testData[20], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[5],_testData[21], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[6],_testData[22], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[7],_testData[23], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[8],_testData[24], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[9],_testData[25], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[10],_testData[26], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[11],_testData[27], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[12],_testData[28], false);FlatNpgsqlIntervalintervalArray2M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 

@"
SELECT
    m.id,
    m.value,
~StartInner::ModelInner:Id~
    mi.id,
    mi.value,
    mi.nullablevalue,
~EndInner::ModelInner~
    m.nullablevalue
FROM public.npgsqlintervalintervalarray2m m
LEFT JOIN public.npgsqlintervalintervalarray2mi mi ON mi.id = m.npgsqlintervalintervalarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlIntervalintervalArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalArray)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionSelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 2)]
        private void DbConnectionSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlIntervalListintervalArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlIntervalintervalArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlIntervalListintervalArray)this).DbConnectionSelectModelBatchAsync(connection, 84, 18))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[15], false);NpgsqlIntervalintervalArray2M.AssertModel(models[1],_testData[16], false);NpgsqlIntervalintervalArray2M.AssertModel(models[2],_testData[17], false);NpgsqlIntervalintervalArray2M.AssertModel(models[3],_testData[18], false);NpgsqlIntervalintervalArray2M.AssertModel(models[4],_testData[19], false);NpgsqlIntervalintervalArray2M.AssertModel(models[5],_testData[20], false);NpgsqlIntervalintervalArray2M.AssertModel(models[6],_testData[21], false);NpgsqlIntervalintervalArray2M.AssertModel(models[7],_testData[22], false);NpgsqlIntervalintervalArray2M.AssertModel(models[8],_testData[23], false);NpgsqlIntervalintervalArray2M.AssertModel(models[9],_testData[24], false);NpgsqlIntervalintervalArray2M.AssertModel(models[10],_testData[25], false);NpgsqlIntervalintervalArray2M.AssertModel(models[11],_testData[26], false);NpgsqlIntervalintervalArray2M.AssertModel(models[12],_testData[27], false);NpgsqlIntervalintervalArray2M.AssertModel(models[13],_testData[28], false);NpgsqlIntervalintervalArray2M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[3], false);NpgsqlIntervalintervalArray2M.AssertModel(models[1],_testData[4], false);NpgsqlIntervalintervalArray2M.AssertModel(models[2],_testData[5], false);NpgsqlIntervalintervalArray2M.AssertModel(models[3],_testData[6], false);NpgsqlIntervalintervalArray2M.AssertModel(models[4],_testData[7], false);NpgsqlIntervalintervalArray2M.AssertModel(models[5],_testData[8], false);NpgsqlIntervalintervalArray2M.AssertModel(models[6],_testData[9], false);NpgsqlIntervalintervalArray2M.AssertModel(models[7],_testData[10], false);NpgsqlIntervalintervalArray2M.AssertModel(models[8],_testData[11], false);NpgsqlIntervalintervalArray2M.AssertModel(models[9],_testData[12], false);NpgsqlIntervalintervalArray2M.AssertModel(models[10],_testData[13], false);NpgsqlIntervalintervalArray2M.AssertModel(models[11],_testData[14], false);NpgsqlIntervalintervalArray2M.AssertModel(models[12],_testData[15], false);NpgsqlIntervalintervalArray2M.AssertModel(models[13],_testData[16], false);NpgsqlIntervalintervalArray2M.AssertModel(models[14],_testData[17], false);NpgsqlIntervalintervalArray2M.AssertModel(models[15],_testData[18], false);NpgsqlIntervalintervalArray2M.AssertModel(models[16],_testData[19], false);NpgsqlIntervalintervalArray2M.AssertModel(models[17],_testData[20], false);NpgsqlIntervalintervalArray2M.AssertModel(models[18],_testData[21], false);NpgsqlIntervalintervalArray2M.AssertModel(models[19],_testData[22], false);NpgsqlIntervalintervalArray2M.AssertModel(models[20],_testData[23], false);NpgsqlIntervalintervalArray2M.AssertModel(models[21],_testData[24], false);NpgsqlIntervalintervalArray2M.AssertModel(models[22],_testData[25], false);NpgsqlIntervalintervalArray2M.AssertModel(models[23],_testData[26], false);NpgsqlIntervalintervalArray2M.AssertModel(models[24],_testData[27], false);NpgsqlIntervalintervalArray2M.AssertModel(models[25],_testData[28], false);NpgsqlIntervalintervalArray2M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlIntervalListintervalArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlIntervalintervalArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlIntervalListintervalArray)this).DbConnectionSelectModelBatch(connection, 11, 117))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));
NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[2], false);NpgsqlIntervalintervalArray2M.AssertModel(models[1],_testData[3], false);NpgsqlIntervalintervalArray2M.AssertModel(models[2],_testData[4], false);NpgsqlIntervalintervalArray2M.AssertModel(models[3],_testData[5], false);NpgsqlIntervalintervalArray2M.AssertModel(models[4],_testData[6], false);NpgsqlIntervalintervalArray2M.AssertModel(models[5],_testData[7], false);NpgsqlIntervalintervalArray2M.AssertModel(models[6],_testData[8], false);NpgsqlIntervalintervalArray2M.AssertModel(models[7],_testData[9], false);NpgsqlIntervalintervalArray2M.AssertModel(models[8],_testData[10], false);NpgsqlIntervalintervalArray2M.AssertModel(models[9],_testData[11], false);NpgsqlIntervalintervalArray2M.AssertModel(models[10],_testData[12], false);NpgsqlIntervalintervalArray2M.AssertModel(models[11],_testData[13], false);NpgsqlIntervalintervalArray2M.AssertModel(models[12],_testData[14], false);NpgsqlIntervalintervalArray2M.AssertModel(models[13],_testData[15], false);NpgsqlIntervalintervalArray2M.AssertModel(models[14],_testData[16], false);NpgsqlIntervalintervalArray2M.AssertModel(models[15],_testData[17], false);NpgsqlIntervalintervalArray2M.AssertModel(models[16],_testData[18], false);NpgsqlIntervalintervalArray2M.AssertModel(models[17],_testData[19], false);NpgsqlIntervalintervalArray2M.AssertModel(models[18],_testData[20], false);NpgsqlIntervalintervalArray2M.AssertModel(models[19],_testData[21], false);NpgsqlIntervalintervalArray2M.AssertModel(models[20],_testData[22], false);NpgsqlIntervalintervalArray2M.AssertModel(models[21],_testData[23], false);NpgsqlIntervalintervalArray2M.AssertModel(models[22],_testData[24], false);NpgsqlIntervalintervalArray2M.AssertModel(models[23],_testData[25], false);NpgsqlIntervalintervalArray2M.AssertModel(models[24],_testData[26], false);NpgsqlIntervalintervalArray2M.AssertModel(models[25],_testData[27], false);NpgsqlIntervalintervalArray2M.AssertModel(models[26],_testData[28], false);NpgsqlIntervalintervalArray2M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));
NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[21], false);NpgsqlIntervalintervalArray2M.AssertModel(models[1],_testData[22], false);NpgsqlIntervalintervalArray2M.AssertModel(models[2],_testData[23], false);NpgsqlIntervalintervalArray2M.AssertModel(models[3],_testData[24], false);NpgsqlIntervalintervalArray2M.AssertModel(models[4],_testData[25], false);NpgsqlIntervalintervalArray2M.AssertModel(models[5],_testData[26], false);NpgsqlIntervalintervalArray2M.AssertModel(models[6],_testData[27], false);NpgsqlIntervalintervalArray2M.AssertModel(models[7],_testData[28], false);NpgsqlIntervalintervalArray2M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((INpgsqlIntervalListintervalArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlIntervalListintervalArray)this).SetDbConnectionSelectModelParametrs(cmd, 67);
                var models = await ((INpgsqlIntervalListintervalArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(19));
NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[11], false);NpgsqlIntervalintervalArray2M.AssertModel(models[1],_testData[12], false);NpgsqlIntervalintervalArray2M.AssertModel(models[2],_testData[13], false);NpgsqlIntervalintervalArray2M.AssertModel(models[3],_testData[14], false);NpgsqlIntervalintervalArray2M.AssertModel(models[4],_testData[15], false);NpgsqlIntervalintervalArray2M.AssertModel(models[5],_testData[16], false);NpgsqlIntervalintervalArray2M.AssertModel(models[6],_testData[17], false);NpgsqlIntervalintervalArray2M.AssertModel(models[7],_testData[18], false);NpgsqlIntervalintervalArray2M.AssertModel(models[8],_testData[19], false);NpgsqlIntervalintervalArray2M.AssertModel(models[9],_testData[20], false);NpgsqlIntervalintervalArray2M.AssertModel(models[10],_testData[21], false);NpgsqlIntervalintervalArray2M.AssertModel(models[11],_testData[22], false);NpgsqlIntervalintervalArray2M.AssertModel(models[12],_testData[23], false);NpgsqlIntervalintervalArray2M.AssertModel(models[13],_testData[24], false);NpgsqlIntervalintervalArray2M.AssertModel(models[14],_testData[25], false);NpgsqlIntervalintervalArray2M.AssertModel(models[15],_testData[26], false);NpgsqlIntervalintervalArray2M.AssertModel(models[16],_testData[27], false);NpgsqlIntervalintervalArray2M.AssertModel(models[17],_testData[28], false);NpgsqlIntervalintervalArray2M.AssertModel(models[18],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlIntervalListintervalArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlIntervalListintervalArray)this).SetDbConnectionSelectModelParametrs(cmd, 69);
                var models =  ((INpgsqlIntervalListintervalArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(18));
NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[12], false);NpgsqlIntervalintervalArray2M.AssertModel(models[1],_testData[13], false);NpgsqlIntervalintervalArray2M.AssertModel(models[2],_testData[14], false);NpgsqlIntervalintervalArray2M.AssertModel(models[3],_testData[15], false);NpgsqlIntervalintervalArray2M.AssertModel(models[4],_testData[16], false);NpgsqlIntervalintervalArray2M.AssertModel(models[5],_testData[17], false);NpgsqlIntervalintervalArray2M.AssertModel(models[6],_testData[18], false);NpgsqlIntervalintervalArray2M.AssertModel(models[7],_testData[19], false);NpgsqlIntervalintervalArray2M.AssertModel(models[8],_testData[20], false);NpgsqlIntervalintervalArray2M.AssertModel(models[9],_testData[21], false);NpgsqlIntervalintervalArray2M.AssertModel(models[10],_testData[22], false);NpgsqlIntervalintervalArray2M.AssertModel(models[11],_testData[23], false);NpgsqlIntervalintervalArray2M.AssertModel(models[12],_testData[24], false);NpgsqlIntervalintervalArray2M.AssertModel(models[13],_testData[25], false);NpgsqlIntervalintervalArray2M.AssertModel(models[14],_testData[26], false);NpgsqlIntervalintervalArray2M.AssertModel(models[15],_testData[27], false);NpgsqlIntervalintervalArray2M.AssertModel(models[16],_testData[28], false);NpgsqlIntervalintervalArray2M.AssertModel(models[17],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlintervalintervalarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalArray2MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483618),
                (NpgsqlTypes.NpgsqlDbType)(-2147483618)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalArray))]
        private void ImportModelInnerConfig()
        {
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    mi.nullablevalue,
    mi.id,
    mi.value
FROM public.binary_npgsqlintervalintervalarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlIntervalintervalArray2MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlIntervalListintervalArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlIntervalListintervalArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlIntervalintervalArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
                importCollection.Clear();

                importCollection.Add(_testData[15].ModelInner);
                importCollection.Add(_testData[17].ModelInner);
                importCollection.Add(_testData[19].ModelInner);
                importCollection.Add(_testData[21].ModelInner);
                importCollection.Add(_testData[23].ModelInner);
                importCollection.Add(_testData[25].ModelInner);
                importCollection.Add(_testData[27].ModelInner);
                importCollection.Add(_testData[29].ModelInner);
                await ((INpgsqlIntervalListintervalArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlIntervalListintervalArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlIntervalintervalArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlintervalintervalarray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlintervalintervalarray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(NpgsqlIntervalintervalArray2M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483618),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483618)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalArray))]
        private void ImportModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    m.id,
    m.value,
~StartInner::ModelInner:Id~
    mi.id,
    mi.value,
    mi.nullablevalue,
~EndInner::ModelInner~
    m.nullablevalue
FROM public.binary_npgsqlintervalintervalarray2m m
LEFT JOIN public.binary_npgsqlintervalintervalarray2mi mi ON mi.id = m.npgsqlintervalintervalarray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlIntervalintervalArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlIntervalintervalArray2M>(15);

                    importCollection.Add(_testData[0]);
                    importCollection.Add(_testData[1]);
                    importCollection.Add(_testData[2]);
                    importCollection.Add(_testData[3]);
                    importCollection.Add(_testData[4]);
                    importCollection.Add(_testData[5]);
                    importCollection.Add(_testData[6]);
                    importCollection.Add(_testData[7]);
                    importCollection.Add(_testData[8]);
                    importCollection.Add(_testData[9]);
                    importCollection.Add(_testData[10]);
                    importCollection.Add(_testData[11]);
                    importCollection.Add(_testData[12]);
                    importCollection.Add(_testData[13]);
                    importCollection.Add(_testData[14]);
                ((INpgsqlIntervalListintervalArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlIntervalListintervalArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[0], false);
                NpgsqlIntervalintervalArray2M.AssertModel(models[1],_testData[1], false);
                NpgsqlIntervalintervalArray2M.AssertModel(models[2],_testData[2], false);
                NpgsqlIntervalintervalArray2M.AssertModel(models[3],_testData[3], false);
                NpgsqlIntervalintervalArray2M.AssertModel(models[4],_testData[4], false);
                NpgsqlIntervalintervalArray2M.AssertModel(models[5],_testData[5], false);
                NpgsqlIntervalintervalArray2M.AssertModel(models[6],_testData[6], false);
                NpgsqlIntervalintervalArray2M.AssertModel(models[7],_testData[7], false);
                NpgsqlIntervalintervalArray2M.AssertModel(models[8],_testData[8], false);
                NpgsqlIntervalintervalArray2M.AssertModel(models[9],_testData[9], false);
                NpgsqlIntervalintervalArray2M.AssertModel(models[10],_testData[10], false);
                NpgsqlIntervalintervalArray2M.AssertModel(models[11],_testData[11], false);
                NpgsqlIntervalintervalArray2M.AssertModel(models[12],_testData[12], false);
                NpgsqlIntervalintervalArray2M.AssertModel(models[13],_testData[13], false);
                NpgsqlIntervalintervalArray2M.AssertModel(models[14],_testData[14], false);
                importCollection.Clear();

                    importCollection.Add(_testData[15]);
                    importCollection.Add(_testData[16]);
                    importCollection.Add(_testData[17]);
                    importCollection.Add(_testData[18]);
                    importCollection.Add(_testData[19]);
                    importCollection.Add(_testData[20]);
                    importCollection.Add(_testData[21]);
                    importCollection.Add(_testData[22]);
                    importCollection.Add(_testData[23]);
                    importCollection.Add(_testData[24]);
                    importCollection.Add(_testData[25]);
                    importCollection.Add(_testData[26]);
                    importCollection.Add(_testData[27]);
                    importCollection.Add(_testData[28]);
                    importCollection.Add(_testData[29]);
                await ((INpgsqlIntervalListintervalArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlIntervalListintervalArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[0], false);
                NpgsqlIntervalintervalArray2M.AssertModel(models[1],_testData[1], false);
                NpgsqlIntervalintervalArray2M.AssertModel(models[2],_testData[2], false);
                NpgsqlIntervalintervalArray2M.AssertModel(models[3],_testData[3], false);
                NpgsqlIntervalintervalArray2M.AssertModel(models[4],_testData[4], false);
                NpgsqlIntervalintervalArray2M.AssertModel(models[5],_testData[5], false);
                NpgsqlIntervalintervalArray2M.AssertModel(models[6],_testData[6], false);
                NpgsqlIntervalintervalArray2M.AssertModel(models[7],_testData[7], false);
                NpgsqlIntervalintervalArray2M.AssertModel(models[8],_testData[8], false);
                NpgsqlIntervalintervalArray2M.AssertModel(models[9],_testData[9], false);
                NpgsqlIntervalintervalArray2M.AssertModel(models[10],_testData[10], false);
                NpgsqlIntervalintervalArray2M.AssertModel(models[11],_testData[11], false);
                NpgsqlIntervalintervalArray2M.AssertModel(models[12],_testData[12], false);
                NpgsqlIntervalintervalArray2M.AssertModel(models[13],_testData[13], false);
                NpgsqlIntervalintervalArray2M.AssertModel(models[14],_testData[14], false);
                NpgsqlIntervalintervalArray2M.AssertModel(models[15],_testData[15], false);
                NpgsqlIntervalintervalArray2M.AssertModel(models[16],_testData[16], false);
                NpgsqlIntervalintervalArray2M.AssertModel(models[17],_testData[17], false);
                NpgsqlIntervalintervalArray2M.AssertModel(models[18],_testData[18], false);
                NpgsqlIntervalintervalArray2M.AssertModel(models[19],_testData[19], false);
                NpgsqlIntervalintervalArray2M.AssertModel(models[20],_testData[20], false);
                NpgsqlIntervalintervalArray2M.AssertModel(models[21],_testData[21], false);
                NpgsqlIntervalintervalArray2M.AssertModel(models[22],_testData[22], false);
                NpgsqlIntervalintervalArray2M.AssertModel(models[23],_testData[23], false);
                NpgsqlIntervalintervalArray2M.AssertModel(models[24],_testData[24], false);
                NpgsqlIntervalintervalArray2M.AssertModel(models[25],_testData[25], false);
                NpgsqlIntervalintervalArray2M.AssertModel(models[26],_testData[26], false);
                NpgsqlIntervalintervalArray2M.AssertModel(models[27],_testData[27], false);
                NpgsqlIntervalintervalArray2M.AssertModel(models[28],_testData[28], false);
                NpgsqlIntervalintervalArray2M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlintervalintervalarray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlintervalintervalarray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlIntervalintervalArray2M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483618),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483618)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlIntervalListintervalArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlIntervalintervalArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlIntervalListintervalArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlIntervalintervalArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlintervalintervalarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalArray2MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483618),
                (NpgsqlTypes.NpgsqlDbType)(-2147483618)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlIntervalListintervalArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlIntervalintervalArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlIntervalListintervalArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlIntervalintervalArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

