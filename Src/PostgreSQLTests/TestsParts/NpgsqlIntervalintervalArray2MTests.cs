

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
    Id = 6,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 401),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1357),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2745),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3383),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1692),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1882),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 261),

},
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3924),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 902),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4246),

},
    ModelInner = new NpgsqlIntervalintervalArray2MI
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 271),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3646),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3975),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2152),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1997),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 595),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4933),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 994),

},
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1479),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2758),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2651),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3633),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4781),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3267),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1955),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2116),

},
    ModelInner = new NpgsqlIntervalintervalArray2MI
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2719),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4093),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1123),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1277),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2558),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3730),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1499),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4904),

},
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 983),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4428),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 735),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3542),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2705),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2348),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2625),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3892),

},
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3892),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1764),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4141),

},
    ModelInner = new NpgsqlIntervalintervalArray2MI
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 455),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4793),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4331),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 736),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3222),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2238),

},
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4785),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2935),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1080),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3494),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3768),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4543),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1586),

},
    ModelInner = new NpgsqlIntervalintervalArray2MI
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2646),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 476),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3544),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4867),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4425),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3548),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 675),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4617),

},
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4779),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 423),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3061),

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
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 663),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2253),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1992),

},
    ModelInner = new NpgsqlIntervalintervalArray2MI
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2003),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3118),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4897),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4918),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 625),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 257),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 952),

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
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4678),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1256),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2665),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3934),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 666),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3189),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1173),

},
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1164),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 497),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2568),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1759),

},
    ModelInner = new NpgsqlIntervalintervalArray2MI
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2863),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4784),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4628),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2279),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1697),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1861),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3031),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2006),

},
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3814),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1510),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 174),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4027),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4275),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2882),

},
    ModelInner = new NpgsqlIntervalintervalArray2MI
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 345),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4708),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3125),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3663),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2965),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2921),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2771),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 39),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 408),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1110),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3249),

},
    ModelInner = new NpgsqlIntervalintervalArray2MI
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4918),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1455),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 977),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4823),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2545),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3538),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 476),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1992),

},
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 34),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2839),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 543),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 101,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1521),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1938),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 565),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3900),

},
    ModelInner = new NpgsqlIntervalintervalArray2MI
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1657),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3799),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3438),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1945),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 103,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4599),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2181),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 875),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 104,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1647),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 429),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1122),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4066),

},
    ModelInner = new NpgsqlIntervalintervalArray2MI
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3725),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 189),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1089),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4450),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2213),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3214),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1975),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2639),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2202),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 212),

},
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 111,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2565),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1683),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4330),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4288),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3079),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3367),

},
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 118,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 169),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4723),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1096),

},
    ModelInner = new NpgsqlIntervalintervalArray2MI
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2821),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2345),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2028),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1011),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2055),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1698),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2674),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 797),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4018),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4155),

},
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 122,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2117),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1199),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3053),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3239),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1470),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4947),

},
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 128,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3646),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3831),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2147),

},
    ModelInner = new NpgsqlIntervalintervalArray2MI
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2473),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1722),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 540),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3429),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4756),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1266),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3805),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2082),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1406),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3727),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 939),

},
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 133,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2958),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1109),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1915),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2721),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 138,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4957),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2951),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4338),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1960),

},
    ModelInner = new NpgsqlIntervalintervalArray2MI
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 127),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2145),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 638),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3166),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 140,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3775),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4705),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2479),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3500),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3756),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 125),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3038),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4742),

},
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 145,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3327),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1068),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 999),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3240),

},
    ModelInner = new NpgsqlIntervalintervalArray2MI
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4766),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4185),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3712),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3260),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 151,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2382),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1267),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2755),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3663),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1742),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1095),

},
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 155,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1664),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3409),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2342),

},
    ModelInner = new NpgsqlIntervalintervalArray2MI
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2754),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2021),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1193),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2510),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 205),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3255),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4744),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 471),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3774),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1505),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3628),

},
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 162,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1764),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 193),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3228),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1138),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3554),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2842),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1469),

},
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 164,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1985),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3820),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2097),

},
    ModelInner = new NpgsqlIntervalintervalArray2MI
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2627),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1250),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2867),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 32),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 172,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4561),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3479),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 846),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2231),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 44),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4609),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3071),

},
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 181,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4069),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3299),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3579),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3161),

},
    ModelInner = new NpgsqlIntervalintervalArray2MI
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3977),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3994),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2064),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3664),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4813),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4882),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2527),

},
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 188,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4658),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1042),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1937),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1920),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3731),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4410),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3929),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1635),

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

                id = await ((INpgsqlIntervalListintervalArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlIntervalListintervalArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

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
                models = await ((INpgsqlIntervalListintervalArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlIntervalListintervalArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlIntervalListintervalArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlIntervalListintervalArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlIntervalListintervalArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlIntervalintervalArray2M), typeof(FlatNpgsqlIntervalintervalArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalArray)),
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
FROM public.npgsqlintervalintervalarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlIntervalintervalArray2M>();
                var models2 = new List<FlatNpgsqlIntervalintervalArray2M>();
                await ((INpgsqlIntervalListintervalArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlintervalintervalarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlIntervalintervalArray2M>();
                var models2 = new List<FlatNpgsqlIntervalintervalArray2M>();
                ((INpgsqlIntervalListintervalArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlIntervalintervalArray2M)],
            overrideAliasPrefixs: null,
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
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlIntervalListintervalArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlIntervalListintervalArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
            overrideAliasPrefixs: null,
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                var models = ((INpgsqlIntervalListintervalArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlIntervalintervalArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlIntervalintervalArray2M), typeof(FlatNpgsqlIntervalintervalArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
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
FROM public.npgsqlintervalintervalarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlIntervalintervalArray2M>();
                var models2 = new List<FlatNpgsqlIntervalintervalArray2M>();
                await ((INpgsqlIntervalListintervalArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlintervalintervalarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlIntervalintervalArray2M>();
                var models2 = new List<FlatNpgsqlIntervalintervalArray2M>();
                ((INpgsqlIntervalListintervalArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlIntervalintervalArray2M)],
            overrideAliasPrefixs: null,
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
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlIntervalListintervalArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlIntervalListintervalArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
            overrideAliasPrefixs: null,
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                var models = ((INpgsqlIntervalListintervalArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlIntervalintervalArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlIntervalintervalArray2M), typeof(FlatNpgsqlIntervalintervalArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalArray)),
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
            asPartInterface: typeof(INpgsqlIntervalListintervalArray)),
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
FROM public.npgsqlintervalintervalarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlIntervalintervalArray2M>();
                var models2 = new List<FlatNpgsqlIntervalintervalArray2M>();
                await((INpgsqlIntervalListintervalArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 145;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 41;
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
FROM public.npgsqlintervalintervalarray2m m
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
FROM public.npgsqlintervalintervalarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalArray2M>();
                var firstItems2 = new List<FlatNpgsqlIntervalintervalArray2M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalArray2M>();
                var secondItems2 = new List<FlatNpgsqlIntervalintervalArray2M>();
                await ((INpgsqlIntervalListintervalArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[27],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 19;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 67;
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
FROM public.npgsqlintervalintervalarray2m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalArray2M>();
                var firstItems2 = new List<FlatNpgsqlIntervalintervalArray2M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalArray2M>();
                await ((INpgsqlIntervalListintervalArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[23],_testData[34], false);
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
FROM public.npgsqlintervalintervalarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlIntervalintervalArray2M>();
                var models2 = new List<FlatNpgsqlIntervalintervalArray2M>();
                ((INpgsqlIntervalListintervalArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 118;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 11;
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
FROM public.npgsqlintervalintervalarray2m m
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
FROM public.npgsqlintervalintervalarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalArray2M>();
                var firstItems2 = new List<FlatNpgsqlIntervalintervalArray2M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalArray2M>();
                var secondItems2 = new List<FlatNpgsqlIntervalintervalArray2M>();
                 ((INpgsqlIntervalListintervalArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[32],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 49;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 72;
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
FROM public.npgsqlintervalintervalarray2m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalArray2M>();
                var firstItems2 = new List<FlatNpgsqlIntervalintervalArray2M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalArray2M>();
                 ((INpgsqlIntervalListintervalArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[21],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlIntervalintervalArray2M)],
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
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
        private void DbConnectionSTDynQuerySelectModelDynParBatchConfig()
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
FROM public.npgsqlintervalintervalarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlIntervalListintervalArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 41;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 68;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlintervalintervalarray2m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlIntervalListintervalArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[22],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[23],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[24],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[25],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[26],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[17],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[18],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[19],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[20],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[21],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[22],_testData[34], false);
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
                parametr1.Value = 104;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 72;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlintervalintervalarray2m m
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
FROM public.npgsqlintervalintervalarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalArray2M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalArray2M>();
                var secondItems2 = new List<FlatNpgsqlIntervalintervalArray2M>();
                await ((INpgsqlIntervalListintervalArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[21],_testData[34], false);
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlIntervalListintervalArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 128;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 104;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlintervalintervalarray2m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlIntervalListintervalArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[5],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[6],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[7],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[8],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[9],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[9],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[10],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[11],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[12],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[13],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[14],_testData[34], false);
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
                parametr1.Value = 49;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 19;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlintervalintervalarray2m m
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
FROM public.npgsqlintervalintervalarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalArray2M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalArray2M>();
                var secondItems2 = new List<FlatNpgsqlIntervalintervalArray2M>();
                 ((INpgsqlIntervalListintervalArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[31],_testData[34], false);
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
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTSelectModelDynParBatch",
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
                var models = await((INpgsqlIntervalListintervalArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlIntervalintervalArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 66;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 103;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlIntervalListintervalArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[10], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[1],_testData[11], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[2],_testData[12], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[3],_testData[13], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[4],_testData[14], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[5],_testData[15], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[6],_testData[16], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[7],_testData[17], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[8],_testData[18], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[9],_testData[19], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[10],_testData[20], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[11],_testData[21], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[12],_testData[22], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[13],_testData[23], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[14],_testData[24], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[15],_testData[25], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[16],_testData[26], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[17],_testData[27], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[18],_testData[28], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[19],_testData[29], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[20],_testData[30], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[21],_testData[31], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[22],_testData[32], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[23],_testData[33], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[19], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[1],_testData[20], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[2],_testData[21], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[3],_testData[22], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[4],_testData[23], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[5],_testData[24], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[6],_testData[25], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[7],_testData[26], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[8],_testData[27], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[9],_testData[28], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[10],_testData[29], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[11],_testData[30], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[12],_testData[31], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[13],_testData[32], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[14],_testData[33], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[15],_testData[34], false);
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
                var models = ((INpgsqlIntervalListintervalArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlIntervalintervalArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 80;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 72;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlIntervalListintervalArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[14], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[1],_testData[15], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[2],_testData[16], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[3],_testData[17], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[4],_testData[18], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[5],_testData[19], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[6],_testData[20], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[7],_testData[21], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[8],_testData[22], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[9],_testData[23], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[10],_testData[24], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[11],_testData[25], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[12],_testData[26], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[13],_testData[27], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[14],_testData[28], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[15],_testData[29], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[16],_testData[30], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[17],_testData[31], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[18],_testData[32], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[19],_testData[33], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[13], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[1],_testData[14], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[2],_testData[15], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[3],_testData[16], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[4],_testData[17], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[5],_testData[18], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[6],_testData[19], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[7],_testData[20], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[8],_testData[21], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[9],_testData[22], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[10],_testData[23], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[11],_testData[24], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[12],_testData[25], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[13],_testData[26], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[14],_testData[27], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[15],_testData[28], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[16],_testData[29], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[17],_testData[30], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[18],_testData[31], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[19],_testData[32], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[20],_testData[33], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlIntervalintervalArray2M), typeof(FlatNpgsqlIntervalintervalArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
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
        private void DbConnectionMMDynQuerySelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalArray)),
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
            asPartInterface: typeof(INpgsqlIntervalListintervalArray)),
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
FROM public.npgsqlintervalintervalarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlIntervalintervalArray2M>();
                var models2 = new List<FlatNpgsqlIntervalintervalArray2M>();
                await((INpgsqlIntervalListintervalArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlintervalintervalarray2m m
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
FROM public.npgsqlintervalintervalarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalArray2M>();
                var firstItems2 = new List<FlatNpgsqlIntervalintervalArray2M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalArray2M>();
                var secondItems2 = new List<FlatNpgsqlIntervalintervalArray2M>();
                await ((INpgsqlIntervalListintervalArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 101, query1, 67, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[23],_testData[34], false);
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
FROM public.npgsqlintervalintervalarray2m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalArray2M>();
                var firstItems2 = new List<FlatNpgsqlIntervalintervalArray2M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalArray2M>();
                await ((INpgsqlIntervalListintervalArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 11, query1, 41, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[27],_testData[34], false);
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
FROM public.npgsqlintervalintervalarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlIntervalintervalArray2M>();
                var models2 = new List<FlatNpgsqlIntervalintervalArray2M>();
                ((INpgsqlIntervalListintervalArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlintervalintervalarray2m m
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
FROM public.npgsqlintervalintervalarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalArray2M>();
                var firstItems2 = new List<FlatNpgsqlIntervalintervalArray2M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalArray2M>();
                var secondItems2 = new List<FlatNpgsqlIntervalintervalArray2M>();
                 ((INpgsqlIntervalListintervalArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 68, query1, 118, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[12],_testData[34], false);
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
FROM public.npgsqlintervalintervalarray2m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalArray2M>();
                var firstItems2 = new List<FlatNpgsqlIntervalintervalArray2M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalArray2M>();
                 ((INpgsqlIntervalListintervalArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 122, query1, 67, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[23],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlIntervalintervalArray2M)],
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTDynQuerySelectModelBatch",
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
        private void DbConnectionSTDynQuerySelectModelBatchConfig()
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
FROM public.npgsqlintervalintervalarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlIntervalListintervalArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlintervalintervalarray2m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlIntervalListintervalArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 162, query1, 90, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[1],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[2],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[13],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[14],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[15],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[16],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[17],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[18],_testData[34], false);
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
FROM public.npgsqlintervalintervalarray2m m
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
FROM public.npgsqlintervalintervalarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalArray2M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalArray2M>();
                var secondItems2 = new List<FlatNpgsqlIntervalintervalArray2M>();
                await ((INpgsqlIntervalListintervalArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 164, query1, 151, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[5],_testData[34], false);
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlIntervalListintervalArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlintervalintervalarray2m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlIntervalListintervalArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 140, query1, 133, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[2],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[3],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[4],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[5],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[6],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[4],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[5],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[6],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[7],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[8],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[9],_testData[34], false);
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
FROM public.npgsqlintervalintervalarray2m m
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
FROM public.npgsqlintervalintervalarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalArray2M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalArray2M>();
                var secondItems2 = new List<FlatNpgsqlIntervalintervalArray2M>();
                 ((INpgsqlIntervalListintervalArray)this).DbConnectionDynQuerySelectModelBatch(connection, 151, query1, 68, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[22],_testData[34], false);
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
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTSelectModelBatch",
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
        private void DbConnectionSTSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await((INpgsqlIntervalListintervalArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlIntervalintervalArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlIntervalListintervalArray)this).DbConnectionSTSelectModelBatchAsync(connection, 80, 57))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[14], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[1],_testData[15], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[2],_testData[16], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[3],_testData[17], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[4],_testData[18], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[5],_testData[19], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[6],_testData[20], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[7],_testData[21], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[8],_testData[22], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[9],_testData[23], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[10],_testData[24], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[11],_testData[25], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[12],_testData[26], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[13],_testData[27], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[14],_testData[28], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[15],_testData[29], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[16],_testData[30], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[17],_testData[31], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[18],_testData[32], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[19],_testData[33], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[9], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[1],_testData[10], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[2],_testData[11], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[3],_testData[12], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[4],_testData[13], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[5],_testData[14], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[6],_testData[15], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[7],_testData[16], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[8],_testData[17], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[9],_testData[18], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[10],_testData[19], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[11],_testData[20], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[12],_testData[21], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[13],_testData[22], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[14],_testData[23], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[15],_testData[24], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[16],_testData[25], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[17],_testData[26], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[18],_testData[27], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[19],_testData[28], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[20],_testData[29], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[21],_testData[30], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[22],_testData[31], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[23],_testData[32], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[24],_testData[33], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[25],_testData[34], false);
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
                var models = ((INpgsqlIntervalListintervalArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlIntervalintervalArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlIntervalListintervalArray)this).DbConnectionSTSelectModelBatch(connection, 80, 49))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[14], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[1],_testData[15], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[2],_testData[16], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[3],_testData[17], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[4],_testData[18], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[5],_testData[19], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[6],_testData[20], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[7],_testData[21], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[8],_testData[22], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[9],_testData[23], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[10],_testData[24], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[11],_testData[25], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[12],_testData[26], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[13],_testData[27], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[14],_testData[28], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[15],_testData[29], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[16],_testData[30], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[17],_testData[31], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[18],_testData[32], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[19],_testData[33], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[8], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[1],_testData[9], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[2],_testData[10], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[3],_testData[11], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[4],_testData[12], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[5],_testData[13], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[6],_testData[14], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[7],_testData[15], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[8],_testData[16], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[9],_testData[17], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[10],_testData[18], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[11],_testData[19], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[12],_testData[20], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[13],_testData[21], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[14],_testData[22], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[15],_testData[23], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[16],_testData[24], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[17],_testData[25], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[18],_testData[26], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[19],_testData[27], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[20],_testData[28], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[21],_testData[29], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[22],_testData[30], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[23],_testData[31], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[24],_testData[32], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[25],_testData[33], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[26],_testData[34], false);
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
                ((INpgsqlIntervalListintervalArray)this).SetDbConnectionSelectModelParametrs(cmd, 81);
                var models = await ((INpgsqlIntervalListintervalArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(20));
NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[15], false);NpgsqlIntervalintervalArray2M.AssertModel(models[1],_testData[16], false);NpgsqlIntervalintervalArray2M.AssertModel(models[2],_testData[17], false);NpgsqlIntervalintervalArray2M.AssertModel(models[3],_testData[18], false);NpgsqlIntervalintervalArray2M.AssertModel(models[4],_testData[19], false);NpgsqlIntervalintervalArray2M.AssertModel(models[5],_testData[20], false);NpgsqlIntervalintervalArray2M.AssertModel(models[6],_testData[21], false);NpgsqlIntervalintervalArray2M.AssertModel(models[7],_testData[22], false);NpgsqlIntervalintervalArray2M.AssertModel(models[8],_testData[23], false);NpgsqlIntervalintervalArray2M.AssertModel(models[9],_testData[24], false);NpgsqlIntervalintervalArray2M.AssertModel(models[10],_testData[25], false);NpgsqlIntervalintervalArray2M.AssertModel(models[11],_testData[26], false);NpgsqlIntervalintervalArray2M.AssertModel(models[12],_testData[27], false);NpgsqlIntervalintervalArray2M.AssertModel(models[13],_testData[28], false);NpgsqlIntervalintervalArray2M.AssertModel(models[14],_testData[29], false);NpgsqlIntervalintervalArray2M.AssertModel(models[15],_testData[30], false);NpgsqlIntervalintervalArray2M.AssertModel(models[16],_testData[31], false);NpgsqlIntervalintervalArray2M.AssertModel(models[17],_testData[32], false);NpgsqlIntervalintervalArray2M.AssertModel(models[18],_testData[33], false);NpgsqlIntervalintervalArray2M.AssertModel(models[19],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlIntervalListintervalArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlIntervalListintervalArray)this).SetDbConnectionSelectModelParametrs(cmd, 155);
                var models =  ((INpgsqlIntervalListintervalArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(5));
NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[30], false);NpgsqlIntervalintervalArray2M.AssertModel(models[1],_testData[31], false);NpgsqlIntervalintervalArray2M.AssertModel(models[2],_testData[32], false);NpgsqlIntervalintervalArray2M.AssertModel(models[3],_testData[33], false);NpgsqlIntervalintervalArray2M.AssertModel(models[4],_testData[34], false);
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
FROM public.binary_npgsqlintervalintervalarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlIntervalintervalArray2MIWA),
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
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlIntervalintervalArray2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlIntervalintervalArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlIntervalListintervalArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlintervalintervalarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlIntervalListintervalArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlIntervalintervalArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlIntervalintervalArray2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlIntervalintervalArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlIntervalListintervalArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlintervalintervalarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlIntervalListintervalArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlIntervalintervalArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlintervalintervalarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlIntervalintervalArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlIntervalintervalArray2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlIntervalintervalArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlIntervalListintervalArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlintervalintervalarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlIntervalListintervalArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlIntervalintervalArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlIntervalintervalArray2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlIntervalintervalArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlIntervalListintervalArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlintervalintervalarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlIntervalListintervalArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlIntervalintervalArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlintervalintervalarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

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
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlIntervalintervalArray2MI),
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
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlIntervalintervalArray2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlIntervalListintervalArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlIntervalListintervalArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlIntervalintervalArray2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlIntervalintervalArray2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlIntervalListintervalArray)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlIntervalListintervalArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlIntervalintervalArray2MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlintervalintervalarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlintervalintervalarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlIntervalintervalArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalListintervalArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlIntervalintervalArray2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlIntervalintervalArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlIntervalListintervalArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlIntervalListintervalArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlIntervalintervalArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlIntervalintervalArray2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlIntervalintervalArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlIntervalListintervalArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlIntervalListintervalArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlIntervalintervalArray2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
            queryMapType: typeof(NpgsqlIntervalintervalArray2M),
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

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlIntervalintervalArray2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlIntervalListintervalArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlIntervalListintervalArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlIntervalintervalArray2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlIntervalintervalArray2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlIntervalListintervalArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlIntervalListintervalArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlIntervalintervalArray2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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

        [Test, Order(13)]
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

        [Test, Order(13)]
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
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalArray2MIWA)],
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
        private void DynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task DynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlIntervalListintervalArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlintervalintervalarray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlIntervalintervalArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void DynQueryExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((INpgsqlIntervalListintervalArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlintervalintervalarray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlIntervalintervalArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

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

        [Test, Order(13)]
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

        [Test, Order(13)]
        public  void ExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((INpgsqlIntervalListintervalArray)this).ExportModelInner(connection).ToList();
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

