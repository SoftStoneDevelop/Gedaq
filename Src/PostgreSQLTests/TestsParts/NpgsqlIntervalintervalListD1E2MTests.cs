

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
    internal partial interface INpgsqlIntervalListintervalListD1
    {
    }
    
    internal partial class NpgsqlIntervalListintervalListD1 : INpgsqlIntervalListintervalListD1
    {


#region TestData

        private readonly NpgsqlIntervalintervalListD1E2M[] _testData = new NpgsqlIntervalintervalListD1E2M[]
        {
            new NpgsqlIntervalintervalListD1E2M
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1484),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1676),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4098),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1735),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalListD1E2M
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2910),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3091),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1921),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3337),

},
    ModelInner = new NpgsqlIntervalintervalListD1E2MI
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 608),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 100),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1548),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1917),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4059),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3567),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3443),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1130),

},
},
            new NpgsqlIntervalintervalListD1E2M
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 810),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2491),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4870),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2114),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1550),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3960),

},
},
            new NpgsqlIntervalintervalListD1E2M
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2185),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4683),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 779),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2896),

},
    ModelInner = new NpgsqlIntervalintervalListD1E2MI
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2280),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2543),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2348),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4656),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4769),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4598),

},
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalListD1E2M
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2114),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4239),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4140),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3999),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2671),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4505),

},
},
            new NpgsqlIntervalintervalListD1E2M
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2763),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2361),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 456),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1631),

},
    ModelInner = new NpgsqlIntervalintervalListD1E2MI
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3583),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4402),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1839),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3728),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalListD1E2M
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3679),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2648),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1227),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1482),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1225),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2869),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4688),

},
},
            new NpgsqlIntervalintervalListD1E2M
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2906),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2991),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 641),

},
    ModelInner = new NpgsqlIntervalintervalListD1E2MI
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4988),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2492),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3525),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1800),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4384),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3797),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2339),

},
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalListD1E2M
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3326),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2188),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4956),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1094),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4541),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4010),

},
},
            new NpgsqlIntervalintervalListD1E2M
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1889),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 872),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 128),

},
    ModelInner = new NpgsqlIntervalintervalListD1E2MI
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3604),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4555),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1135),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalListD1E2M
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4741),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3459),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3671),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3349),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2766),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3696),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1379),

},
},
            new NpgsqlIntervalintervalListD1E2M
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3034),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2509),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3541),

},
    ModelInner = new NpgsqlIntervalintervalListD1E2MI
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 287),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2634),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1584),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3641),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3369),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2554),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1459),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2327),

},
},
            new NpgsqlIntervalintervalListD1E2M
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 736),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1361),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2084),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 879),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1025),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 845),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2124),

},
},
            new NpgsqlIntervalintervalListD1E2M
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4390),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4927),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3536),

},
    ModelInner = new NpgsqlIntervalintervalListD1E2MI
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2266),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3754),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2762),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1556),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3003),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3624),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2948),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4638),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1027),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2108),

},
},
            new NpgsqlIntervalintervalListD1E2M
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3396),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1430),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3109),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 509),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 544),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 300),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2887),

},
},
            new NpgsqlIntervalintervalListD1E2M
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4830),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3560),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1422),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1535),

},
    ModelInner = new NpgsqlIntervalintervalListD1E2MI
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4529),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1368),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1813),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4863),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2905),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2264),

},
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalListD1E2M
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4030),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1238),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1561),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 965),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalListD1E2M
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1788),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 793),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1264),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 333),

},
    ModelInner = new NpgsqlIntervalintervalListD1E2MI
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2507),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4957),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 325),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3985),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1722),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4160),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1585),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4031),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1255),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4274),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4037),

},
},
            new NpgsqlIntervalintervalListD1E2M
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 922),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1800),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2026),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 173),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalListD1E2M
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 756),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4776),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1129),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2321),

},
    ModelInner = new NpgsqlIntervalintervalListD1E2MI
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3151),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3659),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1289),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 81),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3985),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 372),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3069),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2401),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4013),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4312),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4253),

},
},
            new NpgsqlIntervalintervalListD1E2M
{
    Id = 103,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 396),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4838),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1389),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalListD1E2M
{
    Id = 106,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3101),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2764),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4111),

},
    ModelInner = new NpgsqlIntervalintervalListD1E2MI
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3052),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 922),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 459),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 811),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1664),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 597),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2568),

},
},
            new NpgsqlIntervalintervalListD1E2M
{
    Id = 110,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4697),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3151),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 598),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2516),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4761),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 264),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3217),

},
},
            new NpgsqlIntervalintervalListD1E2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4243),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1738),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4923),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2341),

},
    ModelInner = new NpgsqlIntervalintervalListD1E2MI
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 301),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 824),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3714),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 499),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1608),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 153),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 951),

},
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalListD1E2M
{
    Id = 124,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2218),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3244),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 815),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2631),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalListD1E2M
{
    Id = 131,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3937),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1677),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 164),

},
    ModelInner = new NpgsqlIntervalintervalListD1E2MI
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 544),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3057),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2795),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalListD1E2M
{
    Id = 135,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4316),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4191),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2328),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4627),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalListD1E2M
{
    Id = 137,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 379),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3460),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2592),

},
    ModelInner = new NpgsqlIntervalintervalListD1E2MI
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4286),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4805),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1946),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4837),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalListD1E2M
{
    Id = 140,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1695),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3287),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2309),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalListD1E2M
{
    Id = 144,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3684),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1450),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 435),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4525),

},
    ModelInner = new NpgsqlIntervalintervalListD1E2MI
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 746),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3899),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2698),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2922),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4431),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4074),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1381),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4738),

},
},
            new NpgsqlIntervalintervalListD1E2M
{
    Id = 147,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4439),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1257),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4662),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2399),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1796),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4901),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3435),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3784),

},
},
            new NpgsqlIntervalintervalListD1E2M
{
    Id = 154,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 926),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3606),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2373),

},
    ModelInner = new NpgsqlIntervalintervalListD1E2MI
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3628),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4231),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3768),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 648),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2447),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 410),

},
},
            new NpgsqlIntervalintervalListD1E2M
{
    Id = 157,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4523),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 729),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4634),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2412),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 228),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4039),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2430),

},
},
            new NpgsqlIntervalintervalListD1E2M
{
    Id = 164,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3822),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2444),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 409),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3495),

},
    ModelInner = new NpgsqlIntervalintervalListD1E2MI
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 292),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 484),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 900),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4181),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 235),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1476),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3184),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2008),

},
},
            new NpgsqlIntervalintervalListD1E2M
{
    Id = 168,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4465),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 97),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3812),

},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlintervalintervallistd1e2mi(
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
            asPartInterface: typeof(INpgsqlIntervalListintervalListD1)),
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
INSERT INTO public.npgsqlintervalintervallistd1e2mi(
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
            queryMapTypes: [typeof(NpgsqlIntervalintervalListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalListD1)),
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

                changedRows =  ((INpgsqlIntervalListintervalListD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlIntervalListintervalListD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlIntervalListintervalListD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlIntervalListintervalListD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlIntervalListintervalListD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlIntervalListintervalListD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlIntervalListintervalListD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlIntervalListintervalListD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlIntervalListintervalListD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlIntervalListintervalListD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlIntervalListintervalListD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlIntervalListintervalListD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlIntervalListintervalListD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlIntervalListintervalListD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlIntervalListintervalListD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlIntervalListintervalListD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlIntervalListintervalListD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlintervalintervallistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqlintervalintervallistd1e2mi_id
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
            asPartInterface: typeof(INpgsqlIntervalListintervalListD1)), 
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
                methodParametrName: "npgsqlintervalintervallistd1e2mi_id", 
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
                changedRows =  ((INpgsqlIntervalListintervalListD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlIntervalListintervalListD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlIntervalListintervalListD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlIntervalListintervalListD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlintervalintervallistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqlintervalintervallistd1e2mi_id
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
    npgsqlintervalintervallistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlIntervalintervalListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalListD1)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlintervalintervallistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqlintervalintervallistd1e2mi_id
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
    npgsqlintervalintervallistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlIntervalintervalListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalListD1)),
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
                methodParametrName: "npgsqlintervalintervallistd1e2mi_id", 
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
                List<NpgsqlIntervalintervalListD1E2M> models = null;

                models =  ((INpgsqlIntervalListintervalListD1)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalListD1E2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlIntervalListintervalListD1)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalListD1E2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlIntervalListintervalListD1)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalListD1E2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlIntervalListintervalListD1)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalListD1E2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlIntervalintervalListD1E2M> models = null;

                models = await ((INpgsqlIntervalListintervalListD1)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalListD1E2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlIntervalListintervalListD1)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalListD1E2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlIntervalListintervalListD1)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalListD1E2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlIntervalListintervalListD1)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalListD1E2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlIntervalListintervalListD1)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalListD1E2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlIntervalListintervalListD1)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalListD1E2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlIntervalListintervalListD1)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalListD1E2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlIntervalListintervalListD1)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalListD1E2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlIntervalListintervalListD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalListD1E2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlIntervalListintervalListD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalListD1E2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlIntervalListintervalListD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalListD1E2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlIntervalListintervalListD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalListD1E2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlIntervalListintervalListD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalListD1E2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlIntervalListintervalListD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalListD1E2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlIntervalListintervalListD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalListD1E2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlIntervalListintervalListD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalListD1E2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlIntervalListintervalListD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalListD1E2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlIntervalListintervalListD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalListD1E2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlIntervalListintervalListD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalListD1E2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlIntervalListintervalListD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalListD1E2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlIntervalListintervalListD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalListD1E2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlIntervalListintervalListD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalListD1E2M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlIntervalListintervalListD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalListD1E2M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlIntervalListintervalListD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalListD1E2M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlIntervalListintervalListD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalListD1E2M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlIntervalListintervalListD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalListD1E2M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlIntervalListintervalListD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalListD1E2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlIntervalintervalListD1E2M), typeof(FlatNpgsqlIntervalintervalListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalListD1)),
Gedaq.Npgsql.Attributes.DynamicParametr()]
        private void MMDynQuerySelectModelDynParConfig()
        {
        }

        [Test, Order(2)]
        public async Task MMDynQuerySelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqlintervalintervallistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlIntervalintervalListD1E2M>();
                var models2 = new List<FlatNpgsqlIntervalintervalListD1E2M>();
                await ((INpgsqlIntervalListintervalListD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task MMDynQuerySelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqlintervalintervallistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlIntervalintervalListD1E2M>();
                var models2 = new List<FlatNpgsqlIntervalintervalListD1E2M>();
                ((INpgsqlIntervalListintervalListD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlIntervalintervalListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalListD1)),
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
FROM public.npgsqlintervalintervallistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlIntervalListintervalListD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlintervalintervallistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlIntervalListintervalListD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlintervalintervallistd1e2m m
LEFT JOIN public.npgsqlintervalintervallistd1e2mi mi ON mi.id = m.npgsqlintervalintervallistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlIntervalintervalListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalListD1)),
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
                var models = await ((INpgsqlIntervalListintervalListD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlIntervalintervalListD1E2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlIntervalListintervalListD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlIntervalintervalListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlIntervalintervalListD1E2M), typeof(FlatNpgsqlIntervalintervalListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalListD1)),
Gedaq.Npgsql.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            position: 1,
            methodParametrName: "id",
            dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        private void MMDynQuerySelectModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task MMDynQuerySelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqlintervalintervallistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlIntervalintervalListD1E2M>();
                var models2 = new List<FlatNpgsqlIntervalintervalListD1E2M>();
                await ((INpgsqlIntervalListintervalListD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task MMDynQuerySelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqlintervalintervallistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlIntervalintervalListD1E2M>();
                var models2 = new List<FlatNpgsqlIntervalintervalListD1E2M>();
                ((INpgsqlIntervalListintervalListD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlIntervalintervalListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalListD1)),
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
FROM public.npgsqlintervalintervallistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlIntervalListintervalListD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlintervalintervallistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlIntervalListintervalListD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlintervalintervallistd1e2m m
LEFT JOIN public.npgsqlintervalintervallistd1e2mi mi ON mi.id = m.npgsqlintervalintervallistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlIntervalintervalListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalListD1)),
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
                var models = await ((INpgsqlIntervalListintervalListD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlIntervalintervalListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlIntervalListintervalListD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlIntervalintervalListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlIntervalintervalListD1E2M), typeof(FlatNpgsqlIntervalintervalListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalListD1)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModelDynPar",
            position: 2)]
        private void DbConnectionSTMMDynQuerySelectModelDynParBatchConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalListD1)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
            position: 2)]
        private void DbConnectionMMDynQuerySelectModelDynParBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqlintervalintervallistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlIntervalintervalListD1E2M>();
                var models2 = new List<FlatNpgsqlIntervalintervalListD1E2M>();
                await((INpgsqlIntervalListintervalListD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 27;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 103;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqlintervalintervallistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqlintervalintervallistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlIntervalintervalListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlIntervalintervalListD1E2M>();
                await ((INpgsqlIntervalListintervalListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[13],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 48;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 3;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqlintervalintervallistd1e2m m
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
FROM public.npgsqlintervalintervallistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlIntervalintervalListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalListD1E2M>();
                await ((INpgsqlIntervalListintervalListD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[33],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqlintervalintervallistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlIntervalintervalListD1E2M>();
                var models2 = new List<FlatNpgsqlIntervalintervalListD1E2M>();
                ((INpgsqlIntervalListintervalListD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 65;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 131;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqlintervalintervallistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqlintervalintervallistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlIntervalintervalListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlIntervalintervalListD1E2M>();
                 ((INpgsqlIntervalListintervalListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[8],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 131;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 131;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqlintervalintervallistd1e2m m
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
FROM public.npgsqlintervalintervallistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlIntervalintervalListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalListD1E2M>();
                 ((INpgsqlIntervalListintervalListD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[8],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlIntervalintervalListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalListD1)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
            position: 2)]
        private void DbConnectionSTDynQuerySelectModelDynParBatchConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalListD1)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModelDynPar",
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
FROM public.npgsqlintervalintervallistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlIntervalListintervalListD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 92;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 99;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlintervalintervallistd1e2m m
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
FROM public.npgsqlintervalintervallistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlIntervalListintervalListD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[10],_testData[29], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[11],_testData[30], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[12],_testData[31], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[13],_testData[32], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[14],_testData[33], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[9],_testData[29], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[10],_testData[30], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[11],_testData[31], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[12],_testData[32], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[13],_testData[33], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 65;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 140;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlintervalintervallistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqlintervalintervallistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlIntervalintervalListD1E2M>();
                await ((INpgsqlIntervalListintervalListD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[5],_testData[34], false);
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
FROM public.npgsqlintervalintervallistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlIntervalListintervalListD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 11;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 135;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlintervalintervallistd1e2m m
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
FROM public.npgsqlintervalintervallistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlIntervalListintervalListD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[27],_testData[29], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[28],_testData[30], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[29],_testData[31], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[30],_testData[32], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[31],_testData[33], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[2],_testData[29], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[3],_testData[30], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[4],_testData[31], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[5],_testData[32], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[6],_testData[33], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 27;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 28;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlintervalintervallistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqlintervalintervallistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlIntervalintervalListD1E2M>();
                 ((INpgsqlIntervalListintervalListD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM public.npgsqlintervalintervallistd1e2m m
LEFT JOIN public.npgsqlintervalintervallistd1e2mi mi ON mi.id = m.npgsqlintervalintervallistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlIntervalintervalListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalListD1)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModelDynPar",
            position: 2)]
        private void DbConnectionSTSelectModelDynParBatchConfig()
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
                var models = await((INpgsqlIntervalListintervalListD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlIntervalintervalListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 144;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 68;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlIntervalListintervalListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[0],_testData[30], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[1],_testData[31], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[2],_testData[32], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[3],_testData[33], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[0],_testData[15], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[1],_testData[16], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[2],_testData[17], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[3],_testData[18], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[4],_testData[19], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[5],_testData[20], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[6],_testData[21], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[7],_testData[22], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[8],_testData[23], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[9],_testData[24], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[10],_testData[25], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[11],_testData[26], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[12],_testData[27], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[13],_testData[28], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[14],_testData[29], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[15],_testData[30], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[16],_testData[31], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[17],_testData[32], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[18],_testData[33], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[19],_testData[34], false);
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
                var models = ((INpgsqlIntervalListintervalListD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlIntervalintervalListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 135;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 28;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlIntervalListintervalListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[0],_testData[27], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[1],_testData[28], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[2],_testData[29], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[3],_testData[30], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[4],_testData[31], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[5],_testData[32], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[6],_testData[33], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[0],_testData[6], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[1],_testData[7], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[2],_testData[8], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[3],_testData[9], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[4],_testData[10], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[5],_testData[11], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[6],_testData[12], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[7],_testData[13], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[8],_testData[14], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[9],_testData[15], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[10],_testData[16], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[11],_testData[17], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[12],_testData[18], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[13],_testData[19], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[14],_testData[20], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[15],_testData[21], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[16],_testData[22], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[17],_testData[23], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[18],_testData[24], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[19],_testData[25], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[20],_testData[26], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[21],_testData[27], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[22],_testData[28], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[23],_testData[29], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[24],_testData[30], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[25],_testData[31], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[26],_testData[32], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[27],_testData[33], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlIntervalintervalListD1E2M), typeof(FlatNpgsqlIntervalintervalListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalListD1)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionMMDynQuerySelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalListD1)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModel",
            position: 2)]
        private void DbConnectionSTMMDynQuerySelectModelBatchConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionMMDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalListD1)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
            position: 2)]
        private void DbConnectionMMDynQuerySelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqlintervalintervallistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlIntervalintervalListD1E2M>();
                var models2 = new List<FlatNpgsqlIntervalintervalListD1E2M>();
                await((INpgsqlIntervalListintervalListD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqlintervalintervallistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqlintervalintervallistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlIntervalintervalListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlIntervalintervalListD1E2M>();
                await ((INpgsqlIntervalListintervalListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 28, query1, 154, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[2],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqlintervalintervallistd1e2m m
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
FROM public.npgsqlintervalintervallistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlIntervalintervalListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalListD1E2M>();
                await ((INpgsqlIntervalListintervalListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 27, query1, 68, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[19],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqlintervalintervallistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlIntervalintervalListD1E2M>();
                var models2 = new List<FlatNpgsqlIntervalintervalListD1E2M>();
                ((INpgsqlIntervalListintervalListD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqlintervalintervallistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqlintervalintervallistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlIntervalintervalListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlIntervalintervalListD1E2M>();
                 ((INpgsqlIntervalListintervalListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 68, query1, 77, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[18],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqlintervalintervallistd1e2m m
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
FROM public.npgsqlintervalintervallistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlIntervalintervalListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalListD1E2M>();
                 ((INpgsqlIntervalListintervalListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 28, query1, 140, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[5],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlIntervalintervalListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalListD1)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionDynQuerySelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalListD1)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
            position: 2)]
        private void DbConnectionSTDynQuerySelectModelBatchConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalListD1)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModel",
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
FROM public.npgsqlintervalintervallistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlIntervalListintervalListD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlintervalintervallistd1e2m m
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
FROM public.npgsqlintervalintervallistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlIntervalListintervalListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 66, query1, 68, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[15],_testData[29], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[16],_testData[30], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[17],_testData[31], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[18],_testData[32], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[19],_testData[33], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[14],_testData[29], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[15],_testData[30], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[16],_testData[31], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[17],_testData[32], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[18],_testData[33], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlintervalintervallistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqlintervalintervallistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlIntervalintervalListD1E2M>();
                await ((INpgsqlIntervalListintervalListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 27, query1, 110, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[11],_testData[34], false);
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
FROM public.npgsqlintervalintervallistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlIntervalListintervalListD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlintervalintervallistd1e2m m
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
FROM public.npgsqlintervalintervallistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlIntervalListintervalListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 147, query1, 47, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[0],_testData[31], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[1],_testData[32], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[2],_testData[33], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[0],_testData[9], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[1],_testData[10], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[2],_testData[11], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[3],_testData[12], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[4],_testData[13], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[5],_testData[14], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[6],_testData[15], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[7],_testData[16], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[8],_testData[17], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[9],_testData[18], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[10],_testData[19], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[11],_testData[20], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[12],_testData[21], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[13],_testData[22], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[14],_testData[23], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[15],_testData[24], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[16],_testData[25], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[17],_testData[26], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[18],_testData[27], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[19],_testData[28], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[20],_testData[29], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[21],_testData[30], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[22],_testData[31], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[23],_testData[32], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[24],_testData[33], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlintervalintervallistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqlintervalintervallistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlIntervalintervalListD1E2M>();
                 ((INpgsqlIntervalListintervalListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 11, query1, 65, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatNpgsqlIntervalintervalListD1E2M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM public.npgsqlintervalintervallistd1e2m m
LEFT JOIN public.npgsqlintervalintervallistd1e2mi mi ON mi.id = m.npgsqlintervalintervallistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlIntervalintervalListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalListD1)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionSelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalListD1)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 2)]
        private void DbConnectionSTSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await((INpgsqlIntervalListintervalListD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlIntervalintervalListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlIntervalListintervalListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 157, 11))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[0],_testData[33], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[0],_testData[2], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[1],_testData[3], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[2],_testData[4], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[3],_testData[5], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[4],_testData[6], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[5],_testData[7], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[6],_testData[8], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[7],_testData[9], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[8],_testData[10], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[9],_testData[11], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[10],_testData[12], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[11],_testData[13], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[12],_testData[14], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[13],_testData[15], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[14],_testData[16], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[15],_testData[17], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[16],_testData[18], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[17],_testData[19], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[18],_testData[20], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[19],_testData[21], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[20],_testData[22], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[21],_testData[23], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[22],_testData[24], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[23],_testData[25], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[24],_testData[26], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[25],_testData[27], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[26],_testData[28], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[27],_testData[29], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[28],_testData[30], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[29],_testData[31], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[30],_testData[32], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[31],_testData[33], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[32],_testData[34], false);
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
                var models = ((INpgsqlIntervalListintervalListD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlIntervalintervalListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlIntervalListintervalListD1)this).DbConnectionSTSelectModelBatch(connection, 65, 92))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[0],_testData[13], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[1],_testData[14], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[2],_testData[15], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[3],_testData[16], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[4],_testData[17], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[5],_testData[18], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[6],_testData[19], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[7],_testData[20], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[8],_testData[21], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[9],_testData[22], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[10],_testData[23], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[11],_testData[24], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[12],_testData[25], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[13],_testData[26], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[14],_testData[27], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[15],_testData[28], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[16],_testData[29], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[17],_testData[30], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[18],_testData[31], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[19],_testData[32], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[20],_testData[33], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[0],_testData[19], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[1],_testData[20], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[2],_testData[21], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[3],_testData[22], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[4],_testData[23], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[5],_testData[24], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[6],_testData[25], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[7],_testData[26], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[8],_testData[27], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[9],_testData[28], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[10],_testData[29], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[11],_testData[30], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[12],_testData[31], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[13],_testData[32], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[14],_testData[33], false);
                        NpgsqlIntervalintervalListD1E2M.AssertModel(models[15],_testData[34], false);
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
                await using var cmd = await ((INpgsqlIntervalListintervalListD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlIntervalListintervalListD1)this).SetDbConnectionSelectModelParametrs(cmd, 99);
                var models = await ((INpgsqlIntervalListintervalListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlIntervalintervalListD1E2M.AssertModel(models[0],_testData[20], false);
                NpgsqlIntervalintervalListD1E2M.AssertModel(models[1],_testData[21], false);
                NpgsqlIntervalintervalListD1E2M.AssertModel(models[2],_testData[22], false);
                NpgsqlIntervalintervalListD1E2M.AssertModel(models[3],_testData[23], false);
                NpgsqlIntervalintervalListD1E2M.AssertModel(models[4],_testData[24], false);
                NpgsqlIntervalintervalListD1E2M.AssertModel(models[5],_testData[25], false);
                NpgsqlIntervalintervalListD1E2M.AssertModel(models[6],_testData[26], false);
                NpgsqlIntervalintervalListD1E2M.AssertModel(models[7],_testData[27], false);
                NpgsqlIntervalintervalListD1E2M.AssertModel(models[8],_testData[28], false);
                NpgsqlIntervalintervalListD1E2M.AssertModel(models[9],_testData[29], false);
                NpgsqlIntervalintervalListD1E2M.AssertModel(models[10],_testData[30], false);
                NpgsqlIntervalintervalListD1E2M.AssertModel(models[11],_testData[31], false);
                NpgsqlIntervalintervalListD1E2M.AssertModel(models[12],_testData[32], false);
                NpgsqlIntervalintervalListD1E2M.AssertModel(models[13],_testData[33], false);
                NpgsqlIntervalintervalListD1E2M.AssertModel(models[14],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlIntervalListintervalListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlIntervalListintervalListD1)this).SetDbConnectionSelectModelParametrs(cmd, 26);
                var models =  ((INpgsqlIntervalListintervalListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(31));

                NpgsqlIntervalintervalListD1E2M.AssertModel(models[0],_testData[4], false);
                NpgsqlIntervalintervalListD1E2M.AssertModel(models[1],_testData[5], false);
                NpgsqlIntervalintervalListD1E2M.AssertModel(models[2],_testData[6], false);
                NpgsqlIntervalintervalListD1E2M.AssertModel(models[3],_testData[7], false);
                NpgsqlIntervalintervalListD1E2M.AssertModel(models[4],_testData[8], false);
                NpgsqlIntervalintervalListD1E2M.AssertModel(models[5],_testData[9], false);
                NpgsqlIntervalintervalListD1E2M.AssertModel(models[6],_testData[10], false);
                NpgsqlIntervalintervalListD1E2M.AssertModel(models[7],_testData[11], false);
                NpgsqlIntervalintervalListD1E2M.AssertModel(models[8],_testData[12], false);
                NpgsqlIntervalintervalListD1E2M.AssertModel(models[9],_testData[13], false);
                NpgsqlIntervalintervalListD1E2M.AssertModel(models[10],_testData[14], false);
                NpgsqlIntervalintervalListD1E2M.AssertModel(models[11],_testData[15], false);
                NpgsqlIntervalintervalListD1E2M.AssertModel(models[12],_testData[16], false);
                NpgsqlIntervalintervalListD1E2M.AssertModel(models[13],_testData[17], false);
                NpgsqlIntervalintervalListD1E2M.AssertModel(models[14],_testData[18], false);
                NpgsqlIntervalintervalListD1E2M.AssertModel(models[15],_testData[19], false);
                NpgsqlIntervalintervalListD1E2M.AssertModel(models[16],_testData[20], false);
                NpgsqlIntervalintervalListD1E2M.AssertModel(models[17],_testData[21], false);
                NpgsqlIntervalintervalListD1E2M.AssertModel(models[18],_testData[22], false);
                NpgsqlIntervalintervalListD1E2M.AssertModel(models[19],_testData[23], false);
                NpgsqlIntervalintervalListD1E2M.AssertModel(models[20],_testData[24], false);
                NpgsqlIntervalintervalListD1E2M.AssertModel(models[21],_testData[25], false);
                NpgsqlIntervalintervalListD1E2M.AssertModel(models[22],_testData[26], false);
                NpgsqlIntervalintervalListD1E2M.AssertModel(models[23],_testData[27], false);
                NpgsqlIntervalintervalListD1E2M.AssertModel(models[24],_testData[28], false);
                NpgsqlIntervalintervalListD1E2M.AssertModel(models[25],_testData[29], false);
                NpgsqlIntervalintervalListD1E2M.AssertModel(models[26],_testData[30], false);
                NpgsqlIntervalintervalListD1E2M.AssertModel(models[27],_testData[31], false);
                NpgsqlIntervalintervalListD1E2M.AssertModel(models[28],_testData[32], false);
                NpgsqlIntervalintervalListD1E2M.AssertModel(models[29],_testData[33], false);
                NpgsqlIntervalintervalListD1E2M.AssertModel(models[30],_testData[34], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    mi.nullablevalue,
    mi.id,
    mi.value
FROM public.binary_npgsqlintervalintervallistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalListD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlIntervalintervalListD1E2MIWA),
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
            asPartInterface: typeof(INpgsqlIntervalListintervalListD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlIntervalintervalListD1E2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlIntervalintervalListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlIntervalListintervalListD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlintervalintervallistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlIntervalListintervalListD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlIntervalintervalListD1E2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(1)]
        public  void DynQueryWAImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlIntervalintervalListD1E2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlIntervalintervalListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlIntervalListintervalListD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlintervalintervallistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlIntervalListintervalListD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlIntervalintervalListD1E2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    mi.nullablevalue,
    mi.id,
    mi.value
FROM public.binary_npgsqlintervalintervallistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalListD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlIntervalintervalListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalListD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlIntervalintervalListD1E2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlIntervalintervalListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlIntervalListintervalListD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlintervalintervallistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlIntervalListintervalListD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlIntervalintervalListD1E2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(3)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlIntervalintervalListD1E2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlIntervalintervalListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlIntervalListintervalListD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlintervalintervallistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlIntervalListintervalListD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlIntervalintervalListD1E2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    mi.nullablevalue,
    mi.id,
    mi.value
FROM public.binary_npgsqlintervalintervallistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalListD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlintervalintervallistd1e2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlIntervalintervalListD1E2MI),
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
            asPartInterface: typeof(INpgsqlIntervalListintervalListD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlIntervalintervalListD1E2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlIntervalListintervalListD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlIntervalListintervalListD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlIntervalintervalListD1E2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(5)]
        public  void WAImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlIntervalintervalListD1E2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlIntervalListintervalListD1)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlIntervalListintervalListD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlIntervalintervalListD1E2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    mi.nullablevalue,
    mi.id,
    mi.value
FROM public.binary_npgsqlintervalintervallistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalListD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlintervalintervallistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlIntervalintervalListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalListD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlIntervalintervalListD1E2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlIntervalintervalListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlIntervalListintervalListD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlIntervalListintervalListD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlIntervalintervalListD1E2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(7)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlIntervalintervalListD1E2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlIntervalintervalListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlIntervalListintervalListD1)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlIntervalListintervalListD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlIntervalintervalListD1E2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlintervalintervallistd1e2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlintervalintervallistd1e2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlIntervalintervalListD1E2M),
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
            asPartInterface: typeof(INpgsqlIntervalListintervalListD1))]
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
FROM public.binary_npgsqlintervalintervallistd1e2m m
LEFT JOIN public.binary_npgsqlintervalintervallistd1e2mi mi ON mi.id = m.npgsqlintervalintervallistd1e2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlIntervalintervalListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalListD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlIntervalintervalListD1E2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlIntervalListintervalListD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlIntervalListintervalListD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlIntervalintervalListD1E2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(10)]
        public  void ImportModelTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlIntervalintervalListD1E2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlIntervalListintervalListD1)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlIntervalListintervalListD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlIntervalintervalListD1E2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlintervalintervallistd1e2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlintervalintervallistd1e2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlIntervalintervalListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483618),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483618)
            })]
        private void ExportModelConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlIntervalListintervalListD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlIntervalintervalListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlIntervalListintervalListD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlIntervalintervalListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalListD1E2MIWA), typeof(NpgsqlIntervalintervalListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483618),
                (NpgsqlTypes.NpgsqlDbType)(-2147483618)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483618),
                (NpgsqlTypes.NpgsqlDbType)(-2147483618)
            })]
        private void MMDynQueryWAExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task MMDynQueryWAExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<NpgsqlIntervalintervalListD1E2MIWA>();
                var models2 = new List<NpgsqlIntervalintervalListD1E2MIWA>();
                await ((INpgsqlIntervalListintervalListD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlintervalintervallistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlIntervalintervalListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlIntervalintervalListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void MMDynQueryWAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<NpgsqlIntervalintervalListD1E2MIWA>();
                var models2 = new List<NpgsqlIntervalintervalListD1E2MIWA>();
                ((INpgsqlIntervalListintervalListD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlintervalintervallistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlIntervalintervalListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlIntervalintervalListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483618),
                (NpgsqlTypes.NpgsqlDbType)(-2147483618)
            })]
        private void DynQueryWAExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task DynQueryWAExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((INpgsqlIntervalListintervalListD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlintervalintervallistd1e2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlIntervalintervalListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void DynQueryWAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((INpgsqlIntervalListintervalListD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlintervalintervallistd1e2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlIntervalintervalListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalListD1E2MIWA), typeof(NpgsqlIntervalintervalListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalListD1))]
        private void MMDynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task MMDynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<NpgsqlIntervalintervalListD1E2MIWA>();
                var models2 = new List<NpgsqlIntervalintervalListD1E2MIWA>();
                await ((INpgsqlIntervalListintervalListD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlintervalintervallistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlIntervalintervalListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlIntervalintervalListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void MMDynQueryExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<NpgsqlIntervalintervalListD1E2MIWA>();
                var models2 = new List<NpgsqlIntervalintervalListD1E2MIWA>();
                ((INpgsqlIntervalListintervalListD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlintervalintervallistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlIntervalintervalListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlIntervalintervalListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalListD1))]
        private void DynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task DynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((INpgsqlIntervalListintervalListD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlintervalintervallistd1e2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlIntervalintervalListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void DynQueryExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((INpgsqlIntervalListintervalListD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlintervalintervallistd1e2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlIntervalintervalListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlintervalintervallistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalListD1E2MI), typeof(NpgsqlIntervalintervalListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483618),
                (NpgsqlTypes.NpgsqlDbType)(-2147483618)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483618),
                (NpgsqlTypes.NpgsqlDbType)(-2147483618)
            })]
        private void MMWAExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task MMWAExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<NpgsqlIntervalintervalListD1E2MI>();
                var models2 = new List<NpgsqlIntervalintervalListD1E2MI>();
                await ((INpgsqlIntervalListintervalListD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlIntervalintervalListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlIntervalintervalListD1E2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void MMWAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<NpgsqlIntervalintervalListD1E2MI>();
                var models2 = new List<NpgsqlIntervalintervalListD1E2MI>();
                ((INpgsqlIntervalListintervalListD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlIntervalintervalListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlIntervalintervalListD1E2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlintervalintervallistd1e2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483618),
                (NpgsqlTypes.NpgsqlDbType)(-2147483618)
            })]
        private void WAExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task WAExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((INpgsqlIntervalListintervalListD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlIntervalintervalListD1E2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void WAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((INpgsqlIntervalListintervalListD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlIntervalintervalListD1E2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlintervalintervallistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalListD1E2MIWA), typeof(NpgsqlIntervalintervalListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalListD1))]
        private void MMExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task MMExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<NpgsqlIntervalintervalListD1E2MIWA>();
                var models2 = new List<NpgsqlIntervalintervalListD1E2MIWA>();
                await ((INpgsqlIntervalListintervalListD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlIntervalintervalListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlIntervalintervalListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void MMExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<NpgsqlIntervalintervalListD1E2MIWA>();
                var models2 = new List<NpgsqlIntervalintervalListD1E2MIWA>();
                ((INpgsqlIntervalListintervalListD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlIntervalintervalListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlIntervalintervalListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlintervalintervallistd1e2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalListD1))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((INpgsqlIntervalListintervalListD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlIntervalintervalListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void ExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((INpgsqlIntervalListintervalListD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlIntervalintervalListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

