

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
    internal partial interface INpgsqlIntervalArrayintervalArray
    {
    }
    
    internal partial class NpgsqlIntervalArrayintervalArray : INpgsqlIntervalArrayintervalArray
    {


#region TestData

        private readonly NpgsqlIntervalintervalArray1M[] _testData = new NpgsqlIntervalintervalArray1M[]
        {
            new NpgsqlIntervalintervalArray1M
{
    Id = 4,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1979),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1197),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 226),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 13,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4939),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1152),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4909),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 3,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4692),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 230),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3565),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2738),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4451),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 567),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 14,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4765),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4240),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1059),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1031),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 21,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 390),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3530),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 853),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1651),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2251),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3388),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2203),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 22,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 146),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 781),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 486),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 23,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3309),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3470),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 917),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 699),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 15,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 909),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4622),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 195),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2145),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 46),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4956),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 27,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3083),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 321),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 291),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4011),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 31,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3862),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2385),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1039),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 21,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3483),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3429),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 162),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2562),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3220),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3727),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3621),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4889),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 36,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4186),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3575),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 490),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1622),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2240),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2243),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 570),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3854),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2089),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4305),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3274),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 591),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 29,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1209),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2150),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2731),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2626),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1021),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4291),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 902),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2876),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3048),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4836),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1605),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4541),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2597),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1761),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 48,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4216),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 908),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 626),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 83),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 36,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 874),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3211),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4096),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3717),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 365),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3359),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1613),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 57,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3048),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3400),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2468),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 42,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 491),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4305),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4005),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1692),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2932),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4377),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2771),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 212),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4639),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1332),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3077),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 58,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1208),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3748),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3460),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2368),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1877),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 442),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1966),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1821),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 445),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4236),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 44,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4776),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 407),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3643),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 71,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2935),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2951),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 483),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 76,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 871),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2364),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2612),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4843),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 51,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 878),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2953),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4357),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4848),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2073),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 880),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 463),
},
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 81,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4549),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2860),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2278),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2303),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 90,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2891),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2147),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3604),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2245),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 59,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 482),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 335),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1874),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1212),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3069),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4499),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2028),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3772),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3846),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2842),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1616),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 98,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3855),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2232),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 846),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 255),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3420),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3517),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 907),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3385),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 105,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2353),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 347),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2511),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 62,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 513),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1591),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4058),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3382),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 342),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1214),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4569),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4584),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 676),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3634),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1124),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 108,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3831),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1890),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4730),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 117,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2320),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1853),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4269),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1675),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2416),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 197),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3157),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 710),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2212),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1024),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2876),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1651),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1819),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 339),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 717),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 118,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2208),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1146),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3310),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2076),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 125,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1386),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1160),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1851),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2327),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 68,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1263),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3527),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1027),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4502),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 588),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1024),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2536),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 290),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 128,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 96),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3887),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3373),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 135,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3110),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4244),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3254),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3504),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 69,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2201),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3371),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2584),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3100),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3166),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 575),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3003),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3380),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3593),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2979),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 140,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 94),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4016),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3249),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 141,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3370),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4168),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1471),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 75,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4888),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1762),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3742),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1206),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2845),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 863),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1280),
},
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlintervalintervalarray1mi(
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
            asPartInterface: typeof(INpgsqlIntervalArrayintervalArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlInterval[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlInterval[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlintervalintervalarray1mi(
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
            queryMapTypes: [typeof(NpgsqlIntervalintervalArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalArrayintervalArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlInterval[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlInterval[]), 
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

                changedRows =  ((INpgsqlIntervalArrayintervalArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlIntervalArrayintervalArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlIntervalArrayintervalArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlIntervalArrayintervalArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlIntervalArrayintervalArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlIntervalArrayintervalArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlIntervalArrayintervalArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlIntervalArrayintervalArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlIntervalArrayintervalArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlIntervalArrayintervalArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlIntervalArrayintervalArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlIntervalArrayintervalArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlIntervalArrayintervalArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlIntervalArrayintervalArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlIntervalArrayintervalArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlintervalintervalarray1m(
	id,
    value,
    nullablevalue,
    npgsqlintervalintervalarray1mi_id
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
            asPartInterface: typeof(INpgsqlIntervalArrayintervalArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlInterval[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlInterval[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlintervalintervalarray1mi_id", 
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
                changedRows =  ((INpgsqlIntervalArrayintervalArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlIntervalArrayintervalArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlIntervalArrayintervalArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlIntervalArrayintervalArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlintervalintervalarray1m(
	id,
    value,
    nullablevalue,
    npgsqlintervalintervalarray1mi_id
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
    npgsqlintervalintervalarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlIntervalintervalArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalArrayintervalArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlintervalintervalarray1m(
	id,
    value,
    nullablevalue,
    npgsqlintervalintervalarray1mi_id
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
    npgsqlintervalintervalarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlIntervalintervalArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalArrayintervalArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlInterval[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlInterval[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlintervalintervalarray1mi_id", 
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
                List<NpgsqlIntervalintervalArray1M> models = null;

                models =  ((INpgsqlIntervalArrayintervalArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlIntervalArrayintervalArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlIntervalArrayintervalArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlIntervalArrayintervalArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlIntervalintervalArray1M> models = null;

                models = await ((INpgsqlIntervalArrayintervalArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlIntervalArrayintervalArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlIntervalArrayintervalArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlIntervalArrayintervalArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlIntervalArrayintervalArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlIntervalArrayintervalArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlIntervalArrayintervalArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlIntervalArrayintervalArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlIntervalArrayintervalArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlIntervalArrayintervalArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlIntervalArrayintervalArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlIntervalArrayintervalArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlIntervalArrayintervalArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlIntervalArrayintervalArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlIntervalArrayintervalArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlIntervalArrayintervalArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlIntervalArrayintervalArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlIntervalArrayintervalArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlIntervalArrayintervalArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlIntervalArrayintervalArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlIntervalArrayintervalArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlIntervalArrayintervalArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlIntervalintervalArray1M), typeof(FlatNpgsqlIntervalintervalArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalArrayintervalArray)),
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
FROM public.npgsqlintervalintervalarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlIntervalintervalArray1M>();
                var models2 = new List<FlatNpgsqlIntervalintervalArray1M>();
                await ((INpgsqlIntervalArrayintervalArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlIntervalintervalArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlIntervalintervalArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlintervalintervalarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlIntervalintervalArray1M>();
                var models2 = new List<FlatNpgsqlIntervalintervalArray1M>();
                ((INpgsqlIntervalArrayintervalArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlIntervalintervalArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlIntervalintervalArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlIntervalintervalArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalArrayintervalArray)),
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
FROM public.npgsqlintervalintervalarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlIntervalArrayintervalArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlIntervalintervalArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlintervalintervalarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlIntervalArrayintervalArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlIntervalintervalArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlintervalintervalarray1m m
LEFT JOIN public.npgsqlintervalintervalarray1mi mi ON mi.id = m.npgsqlintervalintervalarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlIntervalintervalArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalArrayintervalArray)),
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
                var models = await ((INpgsqlIntervalArrayintervalArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlIntervalintervalArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlIntervalArrayintervalArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlIntervalintervalArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlIntervalintervalArray1M), typeof(FlatNpgsqlIntervalintervalArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalArrayintervalArray)),
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
FROM public.npgsqlintervalintervalarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlIntervalintervalArray1M>();
                var models2 = new List<FlatNpgsqlIntervalintervalArray1M>();
                await ((INpgsqlIntervalArrayintervalArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlIntervalintervalArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlIntervalintervalArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlintervalintervalarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlIntervalintervalArray1M>();
                var models2 = new List<FlatNpgsqlIntervalintervalArray1M>();
                ((INpgsqlIntervalArrayintervalArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlIntervalintervalArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlIntervalintervalArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlIntervalintervalArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalArrayintervalArray)),
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
FROM public.npgsqlintervalintervalarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlIntervalArrayintervalArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlIntervalintervalArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlintervalintervalarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlIntervalArrayintervalArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlIntervalintervalArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlintervalintervalarray1m m
LEFT JOIN public.npgsqlintervalintervalarray1mi mi ON mi.id = m.npgsqlintervalintervalarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlIntervalintervalArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalArrayintervalArray)),
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
                var models = await ((INpgsqlIntervalArrayintervalArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlIntervalintervalArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlIntervalArrayintervalArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlIntervalintervalArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlIntervalintervalArray1M), typeof(FlatNpgsqlIntervalintervalArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalArrayintervalArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalArrayintervalArray)),
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
            asPartInterface: typeof(INpgsqlIntervalArrayintervalArray)),
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
FROM public.npgsqlintervalintervalarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlIntervalintervalArray1M>();
                var models2 = new List<FlatNpgsqlIntervalintervalArray1M>();
                await((INpgsqlIntervalArrayintervalArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlIntervalintervalArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlIntervalintervalArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 14;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 64;
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
FROM public.npgsqlintervalintervalarray1m m
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
FROM public.npgsqlintervalintervalarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalArray1M>();
                var firstItems2 = new List<FlatNpgsqlIntervalintervalArray1M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalArray1M>();
                var secondItems2 = new List<FlatNpgsqlIntervalintervalArray1M>();
                await ((INpgsqlIntervalArrayintervalArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[13],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 81;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 54;
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
FROM public.npgsqlintervalintervalarray1m m
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
FROM public.npgsqlintervalintervalarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalArray1M>();
                var firstItems2 = new List<FlatNpgsqlIntervalintervalArray1M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalArray1M>();
                await ((INpgsqlIntervalArrayintervalArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[10],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[16],_testData[29], false);
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
FROM public.npgsqlintervalintervalarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlIntervalintervalArray1M>();
                var models2 = new List<FlatNpgsqlIntervalintervalArray1M>();
                ((INpgsqlIntervalArrayintervalArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlIntervalintervalArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlIntervalintervalArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 14;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 54;
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
FROM public.npgsqlintervalintervalarray1m m
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
FROM public.npgsqlintervalintervalarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalArray1M>();
                var firstItems2 = new List<FlatNpgsqlIntervalintervalArray1M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalArray1M>();
                var secondItems2 = new List<FlatNpgsqlIntervalintervalArray1M>();
                 ((INpgsqlIntervalArrayintervalArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[16],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 108;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 36;
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
FROM public.npgsqlintervalintervalarray1m m
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
FROM public.npgsqlintervalintervalarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalArray1M>();
                var firstItems2 = new List<FlatNpgsqlIntervalintervalArray1M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalArray1M>();
                 ((INpgsqlIntervalArrayintervalArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[6],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[20],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlIntervalintervalArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalArrayintervalArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalArrayintervalArray)),
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
            asPartInterface: typeof(INpgsqlIntervalArrayintervalArray)),
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
FROM public.npgsqlintervalintervalarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlIntervalArrayintervalArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlIntervalintervalArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 64;
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
FROM public.npgsqlintervalintervalarray1m m
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
FROM public.npgsqlintervalintervalarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlIntervalArrayintervalArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[2],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[3],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[4],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[5],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[6],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[7],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[8],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[9],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[10],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[11],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[12],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[13],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[14],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[15],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[16],_testData[29], false);
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
                parametr1.Value = 47;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 27;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlintervalintervalarray1m m
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
FROM public.npgsqlintervalintervalarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalArray1M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalArray1M>();
                var secondItems2 = new List<FlatNpgsqlIntervalintervalArray1M>();
                await ((INpgsqlIntervalArrayintervalArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[22],_testData[29], false);
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
FROM public.npgsqlintervalintervalarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlIntervalArrayintervalArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlIntervalintervalArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 23;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 13;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlintervalintervalarray1m m
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
FROM public.npgsqlintervalintervalarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlIntervalArrayintervalArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[27],_testData[29], false);
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
                parametr1.Value = 117;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 4;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlintervalintervalarray1m m
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
FROM public.npgsqlintervalintervalarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalArray1M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalArray1M>();
                var secondItems2 = new List<FlatNpgsqlIntervalintervalArray1M>();
                 ((INpgsqlIntervalArrayintervalArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[28],_testData[29], false);
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
FROM public.npgsqlintervalintervalarray1m m
LEFT JOIN public.npgsqlintervalintervalarray1mi mi ON mi.id = m.npgsqlintervalintervalarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlIntervalintervalArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalArrayintervalArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalArrayintervalArray)),
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
                var models = await((INpgsqlIntervalArrayintervalArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlIntervalintervalArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 76;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 57;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlIntervalArrayintervalArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[18], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[19], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[2],_testData[20], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[3],_testData[21], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[4],_testData[22], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[5],_testData[23], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[6],_testData[24], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[7],_testData[25], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[8],_testData[26], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[9],_testData[27], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[10],_testData[28], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        NpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[14], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[15], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[2],_testData[16], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[3],_testData[17], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[4],_testData[18], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[5],_testData[19], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[6],_testData[20], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[7],_testData[21], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[8],_testData[22], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[9],_testData[23], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[10],_testData[24], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[11],_testData[25], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[12],_testData[26], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[13],_testData[27], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[14],_testData[28], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[15],_testData[29], false);
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
                var models = ((INpgsqlIntervalArrayintervalArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlIntervalintervalArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 21;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 36;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlIntervalArrayintervalArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        NpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[4], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[5], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[2],_testData[6], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[3],_testData[7], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[4],_testData[8], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[5],_testData[9], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[6],_testData[10], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[7],_testData[11], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[8],_testData[12], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[9],_testData[13], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[10],_testData[14], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[11],_testData[15], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[12],_testData[16], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[13],_testData[17], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[14],_testData[18], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[15],_testData[19], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[16],_testData[20], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[17],_testData[21], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[18],_testData[22], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[19],_testData[23], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[20],_testData[24], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[21],_testData[25], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[22],_testData[26], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[23],_testData[27], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[24],_testData[28], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[9], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[10], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[2],_testData[11], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[3],_testData[12], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[4],_testData[13], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[5],_testData[14], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[6],_testData[15], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[7],_testData[16], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[8],_testData[17], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[9],_testData[18], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[10],_testData[19], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[11],_testData[20], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[12],_testData[21], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[13],_testData[22], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[14],_testData[23], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[15],_testData[24], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[16],_testData[25], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[17],_testData[26], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[18],_testData[27], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[19],_testData[28], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlIntervalintervalArray1M), typeof(FlatNpgsqlIntervalintervalArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalArrayintervalArray)),
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
            asPartInterface: typeof(INpgsqlIntervalArrayintervalArray)),
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
            asPartInterface: typeof(INpgsqlIntervalArrayintervalArray)),
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
FROM public.npgsqlintervalintervalarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlIntervalintervalArray1M>();
                var models2 = new List<FlatNpgsqlIntervalintervalArray1M>();
                await((INpgsqlIntervalArrayintervalArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlIntervalintervalArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlIntervalintervalArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlintervalintervalarray1m m
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
FROM public.npgsqlintervalintervalarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalArray1M>();
                var firstItems2 = new List<FlatNpgsqlIntervalintervalArray1M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalArray1M>();
                var secondItems2 = new List<FlatNpgsqlIntervalintervalArray1M>();
                await ((INpgsqlIntervalArrayintervalArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 128, query1, 125, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[3],_testData[29], false);
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
FROM public.npgsqlintervalintervalarray1m m
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
FROM public.npgsqlintervalintervalarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalArray1M>();
                var firstItems2 = new List<FlatNpgsqlIntervalintervalArray1M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalArray1M>();
                await ((INpgsqlIntervalArrayintervalArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 54, query1, 4, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[16],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[28],_testData[29], false);
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
FROM public.npgsqlintervalintervalarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlIntervalintervalArray1M>();
                var models2 = new List<FlatNpgsqlIntervalintervalArray1M>();
                ((INpgsqlIntervalArrayintervalArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlIntervalintervalArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlIntervalintervalArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlintervalintervalarray1m m
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
FROM public.npgsqlintervalintervalarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalArray1M>();
                var firstItems2 = new List<FlatNpgsqlIntervalintervalArray1M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalArray1M>();
                var secondItems2 = new List<FlatNpgsqlIntervalintervalArray1M>();
                 ((INpgsqlIntervalArrayintervalArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 4, query1, 4, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[28],_testData[29], false);
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
FROM public.npgsqlintervalintervalarray1m m
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
FROM public.npgsqlintervalintervalarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalArray1M>();
                var firstItems2 = new List<FlatNpgsqlIntervalintervalArray1M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalArray1M>();
                 ((INpgsqlIntervalArrayintervalArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 58, query1, 76, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[11],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlIntervalintervalArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalArrayintervalArray)),
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
            asPartInterface: typeof(INpgsqlIntervalArrayintervalArray)),
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
            asPartInterface: typeof(INpgsqlIntervalArrayintervalArray)),
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
FROM public.npgsqlintervalintervalarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlIntervalArrayintervalArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlIntervalintervalArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlintervalintervalarray1m m
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
FROM public.npgsqlintervalintervalarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlIntervalArrayintervalArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 118, query1, 135, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[29], false);
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
FROM public.npgsqlintervalintervalarray1m m
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
FROM public.npgsqlintervalintervalarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalArray1M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalArray1M>();
                var secondItems2 = new List<FlatNpgsqlIntervalintervalArray1M>();
                await ((INpgsqlIntervalArrayintervalArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 105, query1, 76, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[11],_testData[29], false);
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
FROM public.npgsqlintervalintervalarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlIntervalArrayintervalArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlIntervalintervalArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlintervalintervalarray1m m
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
FROM public.npgsqlintervalintervalarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlIntervalArrayintervalArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 27, query1, 21, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[25],_testData[29], false);
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
FROM public.npgsqlintervalintervalarray1m m
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
FROM public.npgsqlintervalintervalarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalArray1M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalArray1M>();
                var secondItems2 = new List<FlatNpgsqlIntervalintervalArray1M>();
                 ((INpgsqlIntervalArrayintervalArray)this).DbConnectionDynQuerySelectModelBatch(connection, 108, query1, 22, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[6],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[24],_testData[29], false);
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
FROM public.npgsqlintervalintervalarray1m m
LEFT JOIN public.npgsqlintervalintervalarray1mi mi ON mi.id = m.npgsqlintervalintervalarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlIntervalintervalArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalArrayintervalArray)),
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
            asPartInterface: typeof(INpgsqlIntervalArrayintervalArray)),
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
                var models = await((INpgsqlIntervalArrayintervalArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlIntervalintervalArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlIntervalArrayintervalArray)this).DbConnectionSTSelectModelBatchAsync(connection, 48, 135))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[12], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[13], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[2],_testData[14], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[3],_testData[15], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[4],_testData[16], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[5],_testData[17], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[6],_testData[18], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[7],_testData[19], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[8],_testData[20], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[9],_testData[21], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[10],_testData[22], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[11],_testData[23], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[12],_testData[24], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[13],_testData[25], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[14],_testData[26], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[15],_testData[27], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[16],_testData[28], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[28], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[29], false);
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
                var models = ((INpgsqlIntervalArrayintervalArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlIntervalintervalArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlIntervalArrayintervalArray)this).DbConnectionSTSelectModelBatch(connection, 54, 21))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        NpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[13], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[14], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[2],_testData[15], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[3],_testData[16], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[4],_testData[17], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[5],_testData[18], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[6],_testData[19], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[7],_testData[20], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[8],_testData[21], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[9],_testData[22], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[10],_testData[23], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[11],_testData[24], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[12],_testData[25], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[13],_testData[26], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[14],_testData[27], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[15],_testData[28], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        NpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[4], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[5], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[2],_testData[6], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[3],_testData[7], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[4],_testData[8], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[5],_testData[9], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[6],_testData[10], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[7],_testData[11], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[8],_testData[12], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[9],_testData[13], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[10],_testData[14], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[11],_testData[15], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[12],_testData[16], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[13],_testData[17], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[14],_testData[18], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[15],_testData[19], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[16],_testData[20], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[17],_testData[21], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[18],_testData[22], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[19],_testData[23], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[20],_testData[24], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[21],_testData[25], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[22],_testData[26], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[23],_testData[27], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[24],_testData[28], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[25],_testData[29], false);
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
                await using var cmd = await ((INpgsqlIntervalArrayintervalArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlIntervalArrayintervalArray)this).SetDbConnectionSelectModelParametrs(cmd, 117);
                var models = await ((INpgsqlIntervalArrayintervalArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(6));
NpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[24], false);NpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[25], false);NpgsqlIntervalintervalArray1M.AssertModel(models[2],_testData[26], false);NpgsqlIntervalintervalArray1M.AssertModel(models[3],_testData[27], false);NpgsqlIntervalintervalArray1M.AssertModel(models[4],_testData[28], false);NpgsqlIntervalintervalArray1M.AssertModel(models[5],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlIntervalArrayintervalArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlIntervalArrayintervalArray)this).SetDbConnectionSelectModelParametrs(cmd, 48);
                var models =  ((INpgsqlIntervalArrayintervalArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(18));
NpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[12], false);NpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[13], false);NpgsqlIntervalintervalArray1M.AssertModel(models[2],_testData[14], false);NpgsqlIntervalintervalArray1M.AssertModel(models[3],_testData[15], false);NpgsqlIntervalintervalArray1M.AssertModel(models[4],_testData[16], false);NpgsqlIntervalintervalArray1M.AssertModel(models[5],_testData[17], false);NpgsqlIntervalintervalArray1M.AssertModel(models[6],_testData[18], false);NpgsqlIntervalintervalArray1M.AssertModel(models[7],_testData[19], false);NpgsqlIntervalintervalArray1M.AssertModel(models[8],_testData[20], false);NpgsqlIntervalintervalArray1M.AssertModel(models[9],_testData[21], false);NpgsqlIntervalintervalArray1M.AssertModel(models[10],_testData[22], false);NpgsqlIntervalintervalArray1M.AssertModel(models[11],_testData[23], false);NpgsqlIntervalintervalArray1M.AssertModel(models[12],_testData[24], false);NpgsqlIntervalintervalArray1M.AssertModel(models[13],_testData[25], false);NpgsqlIntervalintervalArray1M.AssertModel(models[14],_testData[26], false);NpgsqlIntervalintervalArray1M.AssertModel(models[15],_testData[27], false);NpgsqlIntervalintervalArray1M.AssertModel(models[16],_testData[28], false);NpgsqlIntervalintervalArray1M.AssertModel(models[17],_testData[29], false);
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
FROM public.binary_npgsqlintervalintervalarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalArrayintervalArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlIntervalintervalArray1MI),
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
            asPartInterface: typeof(INpgsqlIntervalArrayintervalArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlIntervalintervalArray1MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlIntervalArrayintervalArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlintervalintervalarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlIntervalArrayintervalArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlIntervalintervalArray1MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlIntervalArrayintervalArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlintervalintervalarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                models = await ((INpgsqlIntervalArrayintervalArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlIntervalintervalArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlintervalintervalarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlIntervalintervalArray1MI),
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
            asPartInterface: typeof(INpgsqlIntervalArrayintervalArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlIntervalintervalArray1MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlIntervalArrayintervalArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlIntervalArrayintervalArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlIntervalintervalArray1MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlIntervalArrayintervalArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlIntervalArrayintervalArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlIntervalintervalArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlintervalintervalarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlintervalintervalarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlIntervalintervalArray1M),
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
            asPartInterface: typeof(INpgsqlIntervalArrayintervalArray))]
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
FROM public.binary_npgsqlintervalintervalarray1m m
LEFT JOIN public.binary_npgsqlintervalintervalarray1mi mi ON mi.id = m.npgsqlintervalintervalarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlIntervalintervalArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalArrayintervalArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlIntervalintervalArray1M>(15);

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
                ((INpgsqlIntervalArrayintervalArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlIntervalArrayintervalArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlIntervalintervalArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlIntervalintervalArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlIntervalintervalArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlIntervalintervalArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlIntervalintervalArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlIntervalintervalArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlIntervalintervalArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlIntervalintervalArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlIntervalintervalArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlIntervalintervalArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlIntervalintervalArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlIntervalintervalArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlIntervalintervalArray1M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlIntervalArrayintervalArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlIntervalArrayintervalArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlIntervalintervalArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlIntervalintervalArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlIntervalintervalArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlIntervalintervalArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlIntervalintervalArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlIntervalintervalArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlIntervalintervalArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlIntervalintervalArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlIntervalintervalArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlIntervalintervalArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlIntervalintervalArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlIntervalintervalArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlIntervalintervalArray1M.AssertModel(models[14],_testData[14], false);
                NpgsqlIntervalintervalArray1M.AssertModel(models[15],_testData[15], false);
                NpgsqlIntervalintervalArray1M.AssertModel(models[16],_testData[16], false);
                NpgsqlIntervalintervalArray1M.AssertModel(models[17],_testData[17], false);
                NpgsqlIntervalintervalArray1M.AssertModel(models[18],_testData[18], false);
                NpgsqlIntervalintervalArray1M.AssertModel(models[19],_testData[19], false);
                NpgsqlIntervalintervalArray1M.AssertModel(models[20],_testData[20], false);
                NpgsqlIntervalintervalArray1M.AssertModel(models[21],_testData[21], false);
                NpgsqlIntervalintervalArray1M.AssertModel(models[22],_testData[22], false);
                NpgsqlIntervalintervalArray1M.AssertModel(models[23],_testData[23], false);
                NpgsqlIntervalintervalArray1M.AssertModel(models[24],_testData[24], false);
                NpgsqlIntervalintervalArray1M.AssertModel(models[25],_testData[25], false);
                NpgsqlIntervalintervalArray1M.AssertModel(models[26],_testData[26], false);
                NpgsqlIntervalintervalArray1M.AssertModel(models[27],_testData[27], false);
                NpgsqlIntervalintervalArray1M.AssertModel(models[28],_testData[28], false);
                NpgsqlIntervalintervalArray1M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlintervalintervalarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlintervalintervalarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlIntervalintervalArray1M)],
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
            asPartInterface: typeof(INpgsqlIntervalArrayintervalArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlIntervalArrayintervalArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlIntervalintervalArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlIntervalArrayintervalArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlIntervalintervalArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlintervalintervalarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalArray1MI)],
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
            asPartInterface: typeof(INpgsqlIntervalArrayintervalArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlIntervalArrayintervalArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlIntervalintervalArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlIntervalArrayintervalArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlIntervalintervalArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

