

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3581),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4361),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1767),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3966),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3890),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 76),

},
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4971),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4725),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 76),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 233),

},
    ModelInner = new NpgsqlIntervalintervalArray2MI
{
    Id = 2,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 352),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3741),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2027),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 636),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2818),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4615),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1370),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3176),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4765),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4663),

},
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4195),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3822),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2235),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4404),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1264),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3425),

},
    ModelInner = new NpgsqlIntervalintervalArray2MI
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3166),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3034),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2074),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1929),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1792),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2653),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3117),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1217),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1365),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4876),

},
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1259),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2263),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1765),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3228),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4069),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1576),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4173),

},
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 964),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 180),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1217),

},
    ModelInner = new NpgsqlIntervalintervalArray2MI
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1391),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4305),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1331),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2023),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1466),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4107),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4923),

},
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1876),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4966),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 256),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 299),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2377),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2499),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3919),

},
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2920),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3348),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 345),

},
    ModelInner = new NpgsqlIntervalintervalArray2MI
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4986),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4763),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4473),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2449),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 478),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2648),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3635),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2610),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1214),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 215),

},
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2254),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1472),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3050),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4950),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4750),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4616),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1476),

},
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 773),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3841),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 6),

},
    ModelInner = new NpgsqlIntervalintervalArray2MI
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1069),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 198),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3518),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4299),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4944),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4301),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2765),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4449),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1167),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1452),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3490),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4718),

},
    ModelInner = new NpgsqlIntervalintervalArray2MI
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3170),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4885),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2726),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3438),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2216),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4573),

},
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3386),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 178),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 698),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3279),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3806),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3195),

},
    ModelInner = new NpgsqlIntervalintervalArray2MI
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 547),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3313),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1507),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1916),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3199),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1087),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2322),

},
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1690),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2353),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2188),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 361),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 660),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2456),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1453),

},
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1861),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2501),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4378),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1767),

},
    ModelInner = new NpgsqlIntervalintervalArray2MI
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4684),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1099),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2222),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4972),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 505),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4884),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 599),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4700),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1644),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4865),

},
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 93,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 463),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3236),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3142),

},
    ModelInner = new NpgsqlIntervalintervalArray2MI
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3723),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3152),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4817),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3100),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 130),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3653),

},
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3268),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 288),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 932),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 498),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1855),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3596),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1047),

},
    ModelInner = new NpgsqlIntervalintervalArray2MI
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3583),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4495),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2641),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1391),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 409),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1769),

},
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 102,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4199),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3608),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4358),

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
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 678),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3440),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3065),

},
    ModelInner = new NpgsqlIntervalintervalArray2MI
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4675),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1503),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1267),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3796),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3345),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4493),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1354),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2027),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4620),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4909),

},
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 109,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4753),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2662),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 195),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3069),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 692),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2984),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1516),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1745),

},
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 117,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3469),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1163),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1629),

},
    ModelInner = new NpgsqlIntervalintervalArray2MI
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 226),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3009),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1243),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 356),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4449),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1105),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4287),

},
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 119,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2630),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1607),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4045),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 996),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 121,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 93),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3269),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3806),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 131),

},
    ModelInner = new NpgsqlIntervalintervalArray2MI
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1733),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4344),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 242),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1167),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3043),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1172),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1604),

},
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 127,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 112),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3601),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3184),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4805),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 128,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1917),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1065),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3116),

},
    ModelInner = new NpgsqlIntervalintervalArray2MI
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3227),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4667),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3834),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2708),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2744),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 191),

},
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 130,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2618),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3983),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1741),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(3)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2274),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 193),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 130),

},
},
            new NpgsqlIntervalintervalArray2M
{
    Id = 137,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2385),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4269),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3221),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4556),

},
    ModelInner = new NpgsqlIntervalintervalArray2MI
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4313),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3109),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3824),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2727),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4039),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 241),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 81),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2951),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval>(4)
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2238),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4765),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4280),

new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3199),

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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 8;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 95;
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
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[9],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 54;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 85;
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
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[18],_testData[29], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 40;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 95;
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
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[9],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 109;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 25;
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
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 104;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 5;
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
                parametr1.Value = 72;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 40;
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
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 17;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 54;
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
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[1],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[2],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[3],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[4],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[5],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[6],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[7],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[8],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[9],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[10],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[11],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[12],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[13],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[14],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[15],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[16],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[17],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[18],_testData[29], false);
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
                parametr1.Value = 8;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 42;
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
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[20],_testData[29], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 95;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 128;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlIntervalListintervalArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[20], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[1],_testData[21], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[2],_testData[22], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[3],_testData[23], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[4],_testData[24], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[5],_testData[25], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[6],_testData[26], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[7],_testData[27], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[8],_testData[28], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[28], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[1],_testData[29], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 25;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 94;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlIntervalListintervalArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[5], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[1],_testData[6], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[2],_testData[7], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[3],_testData[8], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[4],_testData[9], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[5],_testData[10], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[6],_testData[11], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[7],_testData[12], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[8],_testData[13], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[9],_testData[14], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[10],_testData[15], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[11],_testData[16], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[12],_testData[17], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[13],_testData[18], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[14],_testData[19], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[15],_testData[20], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[16],_testData[21], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[17],_testData[22], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[18],_testData[23], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[19],_testData[24], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[20],_testData[25], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[21],_testData[26], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[22],_testData[27], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[23],_testData[28], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                await ((INpgsqlIntervalListintervalArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 54, query1, 17, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
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
                await ((INpgsqlIntervalListintervalArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 117, query1, 109, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[6],_testData[29], false);
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
                 ((INpgsqlIntervalListintervalArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 54, query1, 104, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems2[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
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
                 ((INpgsqlIntervalListintervalArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 8, query1, 5, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[28],_testData[29], false);
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
                foreach(var batchResult in await ((INpgsqlIntervalListintervalArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 64, query1, 117, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[1],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[2],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[3],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[4],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[5],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[6],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[7],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[8],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[9],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[10],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[11],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[12],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[13],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[14],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[15],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[16],_testData[29], false);
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
                await ((INpgsqlIntervalListintervalArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 94, query1, 42, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[10],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[20],_testData[29], false);
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
                foreach(var batchResult in  ((INpgsqlIntervalListintervalArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 64, query1, 82, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[1],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[2],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[3],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[4],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[5],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[6],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[7],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[8],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[9],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[10],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[11],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[12],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[13],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[14],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[15],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                 ((INpgsqlIntervalListintervalArray)this).DbConnectionDynQuerySelectModelBatch(connection, 121, query1, 93, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(firstItems1[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray2M.AssertModel(secondItems2[11],_testData[29], false);
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
                foreach(var batchResult in await ((INpgsqlIntervalListintervalArray)this).DbConnectionSTSelectModelBatchAsync(connection, 128, 109))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[28], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[23], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[1],_testData[24], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[2],_testData[25], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[3],_testData[26], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[4],_testData[27], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[5],_testData[28], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[6],_testData[29], false);
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
                foreach(var batchResult in  ((INpgsqlIntervalListintervalArray)this).DbConnectionSTSelectModelBatch(connection, 57, 34))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[12], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[1],_testData[13], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[2],_testData[14], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[3],_testData[15], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[4],_testData[16], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[5],_testData[17], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[6],_testData[18], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[7],_testData[19], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[8],_testData[20], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[9],_testData[21], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[10],_testData[22], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[11],_testData[23], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[12],_testData[24], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[13],_testData[25], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[14],_testData[26], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[15],_testData[27], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[16],_testData[28], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[6], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[1],_testData[7], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[2],_testData[8], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[3],_testData[9], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[4],_testData[10], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[5],_testData[11], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[6],_testData[12], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[7],_testData[13], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[8],_testData[14], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[9],_testData[15], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[10],_testData[16], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[11],_testData[17], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[12],_testData[18], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[13],_testData[19], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[14],_testData[20], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[15],_testData[21], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[16],_testData[22], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[17],_testData[23], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[18],_testData[24], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[19],_testData[25], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[20],_testData[26], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[21],_testData[27], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[22],_testData[28], false);
                        NpgsqlIntervalintervalArray2M.AssertModel(models[23],_testData[29], false);
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
                ((INpgsqlIntervalListintervalArray)this).SetDbConnectionSelectModelParametrs(cmd, 75);
                var models = await ((INpgsqlIntervalListintervalArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(15));
NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[15], false);NpgsqlIntervalintervalArray2M.AssertModel(models[1],_testData[16], false);NpgsqlIntervalintervalArray2M.AssertModel(models[2],_testData[17], false);NpgsqlIntervalintervalArray2M.AssertModel(models[3],_testData[18], false);NpgsqlIntervalintervalArray2M.AssertModel(models[4],_testData[19], false);NpgsqlIntervalintervalArray2M.AssertModel(models[5],_testData[20], false);NpgsqlIntervalintervalArray2M.AssertModel(models[6],_testData[21], false);NpgsqlIntervalintervalArray2M.AssertModel(models[7],_testData[22], false);NpgsqlIntervalintervalArray2M.AssertModel(models[8],_testData[23], false);NpgsqlIntervalintervalArray2M.AssertModel(models[9],_testData[24], false);NpgsqlIntervalintervalArray2M.AssertModel(models[10],_testData[25], false);NpgsqlIntervalintervalArray2M.AssertModel(models[11],_testData[26], false);NpgsqlIntervalintervalArray2M.AssertModel(models[12],_testData[27], false);NpgsqlIntervalintervalArray2M.AssertModel(models[13],_testData[28], false);NpgsqlIntervalintervalArray2M.AssertModel(models[14],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlIntervalListintervalArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlIntervalListintervalArray)this).SetDbConnectionSelectModelParametrs(cmd, 25);
                var models =  ((INpgsqlIntervalListintervalArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(25));
NpgsqlIntervalintervalArray2M.AssertModel(models[0],_testData[5], false);NpgsqlIntervalintervalArray2M.AssertModel(models[1],_testData[6], false);NpgsqlIntervalintervalArray2M.AssertModel(models[2],_testData[7], false);NpgsqlIntervalintervalArray2M.AssertModel(models[3],_testData[8], false);NpgsqlIntervalintervalArray2M.AssertModel(models[4],_testData[9], false);NpgsqlIntervalintervalArray2M.AssertModel(models[5],_testData[10], false);NpgsqlIntervalintervalArray2M.AssertModel(models[6],_testData[11], false);NpgsqlIntervalintervalArray2M.AssertModel(models[7],_testData[12], false);NpgsqlIntervalintervalArray2M.AssertModel(models[8],_testData[13], false);NpgsqlIntervalintervalArray2M.AssertModel(models[9],_testData[14], false);NpgsqlIntervalintervalArray2M.AssertModel(models[10],_testData[15], false);NpgsqlIntervalintervalArray2M.AssertModel(models[11],_testData[16], false);NpgsqlIntervalintervalArray2M.AssertModel(models[12],_testData[17], false);NpgsqlIntervalintervalArray2M.AssertModel(models[13],_testData[18], false);NpgsqlIntervalintervalArray2M.AssertModel(models[14],_testData[19], false);NpgsqlIntervalintervalArray2M.AssertModel(models[15],_testData[20], false);NpgsqlIntervalintervalArray2M.AssertModel(models[16],_testData[21], false);NpgsqlIntervalintervalArray2M.AssertModel(models[17],_testData[22], false);NpgsqlIntervalintervalArray2M.AssertModel(models[18],_testData[23], false);NpgsqlIntervalintervalArray2M.AssertModel(models[19],_testData[24], false);NpgsqlIntervalintervalArray2M.AssertModel(models[20],_testData[25], false);NpgsqlIntervalintervalArray2M.AssertModel(models[21],_testData[26], false);NpgsqlIntervalintervalArray2M.AssertModel(models[22],_testData[27], false);NpgsqlIntervalintervalArray2M.AssertModel(models[23],_testData[28], false);NpgsqlIntervalintervalArray2M.AssertModel(models[24],_testData[29], false);
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

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
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
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerTest()
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
                ((INpgsqlIntervalListintervalArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlintervalintervalarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
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
                await ((INpgsqlIntervalListintervalArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlintervalintervalarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
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
        private void ImportModelInnerConfig()
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

