

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
    Id = 7,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 788),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2784),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 53),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3575),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1228),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1806),

},
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3620),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3626),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 341),

},
    ModelInner = new NpgsqlIntervalintervalArray2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 149),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3214),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 357),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2445),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2293),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 977),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4619),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2576),

},
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1104),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2220),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 48),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3864),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1673),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1360),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2555),

},
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1154),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3613),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2717),

},
    ModelInner = new NpgsqlIntervalintervalArray2MI
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1257),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1913),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4337),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1752),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 596),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3429),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2541),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3690),

},
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3280),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 530),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1719),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2938),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4271),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4546),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 251),

},
    ModelInner = new NpgsqlIntervalintervalArray2MI
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1808),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 145),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1964),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 583),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2073),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1504),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 559),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4185),

},
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2683),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4452),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4999),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2567),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3471),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1081),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 5),

},
    ModelInner = new NpgsqlIntervalintervalArray2MI
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 180),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4262),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 497),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1852),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2178),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2416),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3248),

},
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4757),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 141),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4170),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4661),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1281),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3745),

},
    ModelInner = new NpgsqlIntervalintervalArray2MI
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1470),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 576),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 668),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2102),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3874),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4117),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3046),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3036),

},
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2511),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1700),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4949),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 414),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 498),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1136),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2753),

},
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3179),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3456),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3373),

},
    ModelInner = new NpgsqlIntervalintervalArray2MI
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3791),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 217),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4986),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 72),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4506),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1239),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 267),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2070),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4889),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 277),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3104),

},
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3091),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 499),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1046),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2820),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 140),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1407),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1815),

},
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4615),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4997),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 443),

},
    ModelInner = new NpgsqlIntervalintervalArray2MI
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2386),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 80),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1395),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2954),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3701),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1190),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3575),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1598),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4392),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3090),

},
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1624),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 419),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3133),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 529),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3604),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 360),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1595),

},
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 142),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1056),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4614),

},
    ModelInner = new NpgsqlIntervalintervalArray2MI
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3429),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 980),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2329),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1976),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4645),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1895),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1709),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2171),

},
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3085),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4369),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4910),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 189),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 300),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 662),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1746),

},
    ModelInner = new NpgsqlIntervalintervalArray2MI
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2458),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2910),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2571),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1971),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2778),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3996),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2378),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4913),

},
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4364),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4365),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2037),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 104,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 922),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 220),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1196),

},
    ModelInner = new NpgsqlIntervalintervalArray2MI
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2673),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2129),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 932),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3567),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 105,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2725),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1262),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3393),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1360),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 106,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3082),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 225),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2531),

},
    ModelInner = new NpgsqlIntervalintervalArray2MI
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1812),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2821),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4649),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2257),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1565),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2357),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4267),

},
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 111,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3581),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 593),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3333),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1924),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1427),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1059),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3339),

},
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 112,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3355),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2834),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 359),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2349),

},
    ModelInner = new NpgsqlIntervalintervalArray2MI
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3042),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3490),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4794),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4166),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3873),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2148),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 174),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3273),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3764),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1680),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3705),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 465),

},
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 114,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1263),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2982),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 80),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1469),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 117,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1129),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4781),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1326),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4790),

},
    ModelInner = new NpgsqlIntervalintervalArray2MI
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2396),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2890),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 0),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2423),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 122,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1164),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3914),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4643),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 131,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 620),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2779),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4623),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3791),

},
    ModelInner = new NpgsqlIntervalintervalArray2MI
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4835),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2537),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3031),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 134,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4125),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3102),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3736),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 140,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4248),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1033),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2126),

},
    ModelInner = new NpgsqlIntervalintervalArray2MI
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2855),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4811),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3811),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1135),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4537),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1863),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4437),

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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlIntervalintervalArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlIntervalintervalArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlIntervalListintervalArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
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
                var models = ((INpgsqlIntervalListintervalArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlIntervalintervalArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlIntervalintervalArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlIntervalListintervalArray)this).DynQuerySelectModel(connection,  query, 0);
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
                var models = ((INpgsqlIntervalListintervalArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlIntervalintervalArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 114;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 89;
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
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[4],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[12],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 24;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 24;
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
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[25],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlIntervalintervalArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 72;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 111;
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
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[6],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 16;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 89;
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
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
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
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[12],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 42;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 106;
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
                foreach(var batchResult in await ((INpgsqlIntervalListintervalArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[7],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 105;
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
                await ((INpgsqlIntervalListintervalArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[26],_testData[30], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 7;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 112;
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
                foreach(var batchResult in  ((INpgsqlIntervalListintervalArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[1], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[1],_testData[2], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[2],_testData[3], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[3],_testData[4], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[4],_testData[5], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[5],_testData[6], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[6],_testData[7], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[7],_testData[8], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[8],_testData[9], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[9],_testData[10], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[10],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[11],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[12],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[13],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[14],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[15],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[16],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[17],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[18],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[19],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[20],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[21],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[22],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[23],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[24],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[25],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[26],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[27],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[5],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 19;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 59;
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
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[18],_testData[30], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 98;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 114;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlIntervalListintervalArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[25], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[1],_testData[26], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[2],_testData[27], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[3],_testData[28], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[4],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 122;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 94;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlIntervalListintervalArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[27], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[1],_testData[28], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[18], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[1],_testData[19], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[2],_testData[20], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[3],_testData[21], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[4],_testData[22], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[5],_testData[23], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[6],_testData[24], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[7],_testData[25], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[8],_testData[26], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[9],_testData[27], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[10],_testData[28], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[11],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlIntervalintervalArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
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
                await ((INpgsqlIntervalListintervalArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 19, query1, 24, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
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
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[25],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
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
                await ((INpgsqlIntervalListintervalArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 48, query1, 30, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[24],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlIntervalintervalArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
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
                 ((INpgsqlIntervalListintervalArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 114, query1, 37, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[4],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[22],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
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
                 ((INpgsqlIntervalListintervalArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 7, query1, 94, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[11],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
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
                foreach(var batchResult in await ((INpgsqlIntervalListintervalArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 83, query1, 106, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[7],_testData[29], false);
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
                int resultIndex = 0;
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
                await ((INpgsqlIntervalListintervalArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 94, query1, 16, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[11],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[27],_testData[30], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
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
                foreach(var batchResult in  ((INpgsqlIntervalListintervalArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 106, query1, 105, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[8],_testData[29], false);
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
                int resultIndex = 0;
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
                 ((INpgsqlIntervalListintervalArray)this).DbConnectionDynQuerySelectModelBatch(connection, 59, query1, 112, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[5],_testData[30], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in await ((INpgsqlIntervalListintervalArray)this).DbConnectionSTSelectModelBatchAsync(connection, 57, 89))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[17], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[1],_testData[18], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[2],_testData[19], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[3],_testData[20], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[4],_testData[21], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[5],_testData[22], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[6],_testData[23], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[7],_testData[24], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[8],_testData[25], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[9],_testData[26], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[10],_testData[27], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[11],_testData[28], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[12],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in  ((INpgsqlIntervalListintervalArray)this).DbConnectionSTSelectModelBatch(connection, 80, 122))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[15], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[1],_testData[16], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[2],_testData[17], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[3],_testData[18], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[4],_testData[19], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[5],_testData[20], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[6],_testData[21], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[7],_testData[22], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[8],_testData[23], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[9],_testData[24], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[10],_testData[25], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[11],_testData[26], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[12],_testData[27], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[13],_testData[28], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[27], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[1],_testData[28], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[2],_testData[29], false);
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
                ((INpgsqlIntervalListintervalArray)this).SetDbConnectionSelectModelParametrs(cmd, 7);
                var models = await ((INpgsqlIntervalListintervalArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(29));
NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[1], false);NpgsqlIntervalintervalArray2M.AssertModel(models[1],_testData[2], false);NpgsqlIntervalintervalArray2M.AssertModel(models[2],_testData[3], false);NpgsqlIntervalintervalArray2M.AssertModel(models[3],_testData[4], false);NpgsqlIntervalintervalArray2M.AssertModel(models[4],_testData[5], false);NpgsqlIntervalintervalArray2M.AssertModel(models[5],_testData[6], false);NpgsqlIntervalintervalArray2M.AssertModel(models[6],_testData[7], false);NpgsqlIntervalintervalArray2M.AssertModel(models[7],_testData[8], false);NpgsqlIntervalintervalArray2M.AssertModel(models[8],_testData[9], false);NpgsqlIntervalintervalArray2M.AssertModel(models[9],_testData[10], false);NpgsqlIntervalintervalArray2M.AssertModel(models[10],_testData[11], false);NpgsqlIntervalintervalArray2M.AssertModel(models[11],_testData[12], false);NpgsqlIntervalintervalArray2M.AssertModel(models[12],_testData[13], false);NpgsqlIntervalintervalArray2M.AssertModel(models[13],_testData[14], false);NpgsqlIntervalintervalArray2M.AssertModel(models[14],_testData[15], false);NpgsqlIntervalintervalArray2M.AssertModel(models[15],_testData[16], false);NpgsqlIntervalintervalArray2M.AssertModel(models[16],_testData[17], false);NpgsqlIntervalintervalArray2M.AssertModel(models[17],_testData[18], false);NpgsqlIntervalintervalArray2M.AssertModel(models[18],_testData[19], false);NpgsqlIntervalintervalArray2M.AssertModel(models[19],_testData[20], false);NpgsqlIntervalintervalArray2M.AssertModel(models[20],_testData[21], false);NpgsqlIntervalintervalArray2M.AssertModel(models[21],_testData[22], false);NpgsqlIntervalintervalArray2M.AssertModel(models[22],_testData[23], false);NpgsqlIntervalintervalArray2M.AssertModel(models[23],_testData[24], false);NpgsqlIntervalintervalArray2M.AssertModel(models[24],_testData[25], false);NpgsqlIntervalintervalArray2M.AssertModel(models[25],_testData[26], false);NpgsqlIntervalintervalArray2M.AssertModel(models[26],_testData[27], false);NpgsqlIntervalintervalArray2M.AssertModel(models[27],_testData[28], false);NpgsqlIntervalintervalArray2M.AssertModel(models[28],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlIntervalListintervalArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlIntervalListintervalArray)this).SetDbConnectionSelectModelParametrs(cmd, 106);
                var models =  ((INpgsqlIntervalListintervalArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(8));
NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[22], false);NpgsqlIntervalintervalArray2M.AssertModel(models[1],_testData[23], false);NpgsqlIntervalintervalArray2M.AssertModel(models[2],_testData[24], false);NpgsqlIntervalintervalArray2M.AssertModel(models[3],_testData[25], false);NpgsqlIntervalintervalArray2M.AssertModel(models[4],_testData[26], false);NpgsqlIntervalintervalArray2M.AssertModel(models[5],_testData[27], false);NpgsqlIntervalintervalArray2M.AssertModel(models[6],_testData[28], false);NpgsqlIntervalintervalArray2M.AssertModel(models[7],_testData[29], false);
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

