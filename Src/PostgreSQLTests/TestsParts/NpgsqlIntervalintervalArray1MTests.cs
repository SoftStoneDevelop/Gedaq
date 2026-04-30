

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
    Id = 8,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1343),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1867),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1033),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3388),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4304),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2912),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 20),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 16,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2944),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2627),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3797),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4656),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 1,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 146),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3060),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2324),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2641),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 100),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1517),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1005),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2579),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 21,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 634),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 205),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4913),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4501),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 28,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 413),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4437),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2370),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3092),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 3,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4696),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 174),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3492),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2716),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 384),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3876),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3656),
},
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 36,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4215),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1020),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4337),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1416),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 44,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3689),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2913),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 81),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4808),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 7,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 212),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4273),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4286),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 314),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1257),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3716),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4741),
},
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1710),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 920),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4118),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 56,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2525),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1115),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1699),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3312),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3293),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2819),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3609),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 58,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1731),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 520),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1378),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4970),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3386),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4129),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 67,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2755),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2669),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3936),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 11,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4714),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1107),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4706),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3137),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 996),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1343),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1488),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4411),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4601),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 70,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1969),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 659),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4929),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1576),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1499),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 59),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1837),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 78,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2899),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2522),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4799),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 752),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4055),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2938),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4642),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3614),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 336),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 405),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2739),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4480),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2001),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3612),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2217),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 83,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 364),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3161),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2750),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2189),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 87,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3805),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 46),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4460),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1810),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 19,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2915),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1383),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3287),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4758),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 413),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4052),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2815),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3265),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1436),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4062),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 88,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1947),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3533),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 537),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 96,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 39),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2872),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1370),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2000),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 27,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1195),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1535),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 773),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1049),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3723),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 152),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4536),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 100,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3107),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3021),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3481),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 108,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3302),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1608),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1293),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 32,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 776),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3440),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1597),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 113,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 811),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3780),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1762),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 117,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1103),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4107),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3986),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3861),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4328),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1275),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1380),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 662),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3945),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1119),
},
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 118,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4327),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1986),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3553),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 126,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4643),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 846),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1363),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 50,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2002),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 725),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1452),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4208),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 680),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4040),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2554),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1262),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 133,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3634),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2797),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1708),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1078),
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
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4875),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4374),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4191),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 57,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 597),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4881),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 12),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 147,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2645),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1130),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1598),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2210),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 152,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3369),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3904),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4601),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 65,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1922),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3662),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1965),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1189),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1846),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2609),
},
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 157,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2578),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3560),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2507),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 160,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2852),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 860),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3064),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 67,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2435),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2076),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3039),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4679),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2677),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3118),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 146),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 36),
},
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 166,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1028),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 838),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3216),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2194),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 137),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1151),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4865),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 169,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4735),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1838),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4303),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3290),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 70,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1700),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3015),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3786),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1704),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 177,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1512),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 525),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 494),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1642),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3360),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4033),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 825),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2774),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 179,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2183),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2899),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1344),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 75,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4058),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1793),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1027),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4147),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3296),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4414),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 187,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4794),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1810),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3505),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3685),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 351),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3958),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 410),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 190,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2467),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 770),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 563),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2738),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 79,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 190),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3729),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2432),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4458),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2574),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 420),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2509),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 195,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 955),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4513),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 349),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 395),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1608),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2987),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2692),
},
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

                id = await ((INpgsqlIntervalArrayintervalArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlIntervalArrayintervalArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

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
                models = await ((INpgsqlIntervalArrayintervalArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlIntervalArrayintervalArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlIntervalArrayintervalArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlIntervalArrayintervalArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlIntervalArrayintervalArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[34], true);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 147;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 16;
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
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[32],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 126;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 187;
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
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[1],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 187;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 47;
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
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
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
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[27],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 126;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 8;
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
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
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
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[33],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 36;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 166;
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
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[24],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[25],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[26],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[27],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[28],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[2],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[3],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[4],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[5],_testData[34], false);
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
                parametr1.Value = 160;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 83;
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
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
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
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[21],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 108;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 16;
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
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[11],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[12],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[13],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[14],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[15],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

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
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[28],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[29],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[30],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[31],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[32],_testData[34], false);
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
                parametr1.Value = 96;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 83;
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
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
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
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[21],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 118;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 157;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlIntervalArrayintervalArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[21], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[22], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[2],_testData[23], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[3],_testData[24], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[4],_testData[25], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[5],_testData[26], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[6],_testData[27], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[7],_testData[28], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[8],_testData[29], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[9],_testData[30], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[10],_testData[31], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[11],_testData[32], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[12],_testData[33], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[27], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[28], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[2],_testData[29], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[3],_testData[30], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[4],_testData[31], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[5],_testData[32], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[6],_testData[33], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[7],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 108;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 21;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlIntervalArrayintervalArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

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
                        NpgsqlIntervalintervalArray1M.AssertModel(models[12],_testData[30], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[13],_testData[31], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[14],_testData[32], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[15],_testData[33], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        NpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[3], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[4], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[2],_testData[5], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[3],_testData[6], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[4],_testData[7], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[5],_testData[8], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[6],_testData[9], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[7],_testData[10], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[8],_testData[11], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[9],_testData[12], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[10],_testData[13], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[11],_testData[14], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[12],_testData[15], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[13],_testData[16], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[14],_testData[17], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[15],_testData[18], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[16],_testData[19], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[17],_testData[20], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[18],_testData[21], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[19],_testData[22], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[20],_testData[23], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[21],_testData[24], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[22],_testData[25], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[23],_testData[26], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[24],_testData[27], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[25],_testData[28], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[26],_testData[29], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[27],_testData[30], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[28],_testData[31], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[29],_testData[32], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[30],_testData[33], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[31],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                await ((INpgsqlIntervalArrayintervalArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 44, query1, 118, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[13],_testData[34], false);
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
                await ((INpgsqlIntervalArrayintervalArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 179, query1, 187, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[1],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                 ((INpgsqlIntervalArrayintervalArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 147, query1, 147, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[9],_testData[34], false);
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
                 ((INpgsqlIntervalArrayintervalArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 78, query1, 56, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[26],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((INpgsqlIntervalArrayintervalArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 44, query1, 169, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

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
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[24],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[25],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[26],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[27],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[2],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[3],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[4],_testData[34], false);
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
                await ((INpgsqlIntervalArrayintervalArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 21, query1, 83, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
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
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[21],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((INpgsqlIntervalArrayintervalArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 100, query1, 47, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[12],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[13],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[14],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[15],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[16],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

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
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[23],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[24],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[25],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[26],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[27],_testData[34], false);
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
                 ((INpgsqlIntervalArrayintervalArray)this).DbConnectionDynQuerySelectModelBatch(connection, 133, query1, 152, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[8],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((INpgsqlIntervalArrayintervalArray)this).DbConnectionSTSelectModelBatchAsync(connection, 47, 133))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[7], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[8], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[2],_testData[9], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[3],_testData[10], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[4],_testData[11], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[5],_testData[12], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[6],_testData[13], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[7],_testData[14], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[8],_testData[15], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[9],_testData[16], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[10],_testData[17], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[11],_testData[18], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[12],_testData[19], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[13],_testData[20], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[14],_testData[21], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[15],_testData[22], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[16],_testData[23], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[17],_testData[24], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[18],_testData[25], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[19],_testData[26], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[20],_testData[27], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[21],_testData[28], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[22],_testData[29], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[23],_testData[30], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[24],_testData[31], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[25],_testData[32], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[26],_testData[33], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[23], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[24], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[2],_testData[25], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[3],_testData[26], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[4],_testData[27], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[5],_testData[28], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[6],_testData[29], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[7],_testData[30], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[8],_testData[31], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[9],_testData[32], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[10],_testData[33], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[11],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((INpgsqlIntervalArrayintervalArray)this).DbConnectionSTSelectModelBatch(connection, 141, 28))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[24], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[25], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[2],_testData[26], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[3],_testData[27], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[4],_testData[28], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[5],_testData[29], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[6],_testData[30], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[7],_testData[31], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[8],_testData[32], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[9],_testData[33], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

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
                        NpgsqlIntervalintervalArray1M.AssertModel(models[26],_testData[30], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[27],_testData[31], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[28],_testData[32], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[29],_testData[33], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[30],_testData[34], false);
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
                ((INpgsqlIntervalArrayintervalArray)this).SetDbConnectionSelectModelParametrs(cmd, 126);
                var models = await ((INpgsqlIntervalArrayintervalArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(13));
NpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[22], false);NpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[23], false);NpgsqlIntervalintervalArray1M.AssertModel(models[2],_testData[24], false);NpgsqlIntervalintervalArray1M.AssertModel(models[3],_testData[25], false);NpgsqlIntervalintervalArray1M.AssertModel(models[4],_testData[26], false);NpgsqlIntervalintervalArray1M.AssertModel(models[5],_testData[27], false);NpgsqlIntervalintervalArray1M.AssertModel(models[6],_testData[28], false);NpgsqlIntervalintervalArray1M.AssertModel(models[7],_testData[29], false);NpgsqlIntervalintervalArray1M.AssertModel(models[8],_testData[30], false);NpgsqlIntervalintervalArray1M.AssertModel(models[9],_testData[31], false);NpgsqlIntervalintervalArray1M.AssertModel(models[10],_testData[32], false);NpgsqlIntervalintervalArray1M.AssertModel(models[11],_testData[33], false);NpgsqlIntervalintervalArray1M.AssertModel(models[12],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlIntervalArrayintervalArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlIntervalArrayintervalArray)this).SetDbConnectionSelectModelParametrs(cmd, 67);
                var models =  ((INpgsqlIntervalArrayintervalArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(25));
NpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[10], false);NpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[11], false);NpgsqlIntervalintervalArray1M.AssertModel(models[2],_testData[12], false);NpgsqlIntervalintervalArray1M.AssertModel(models[3],_testData[13], false);NpgsqlIntervalintervalArray1M.AssertModel(models[4],_testData[14], false);NpgsqlIntervalintervalArray1M.AssertModel(models[5],_testData[15], false);NpgsqlIntervalintervalArray1M.AssertModel(models[6],_testData[16], false);NpgsqlIntervalintervalArray1M.AssertModel(models[7],_testData[17], false);NpgsqlIntervalintervalArray1M.AssertModel(models[8],_testData[18], false);NpgsqlIntervalintervalArray1M.AssertModel(models[9],_testData[19], false);NpgsqlIntervalintervalArray1M.AssertModel(models[10],_testData[20], false);NpgsqlIntervalintervalArray1M.AssertModel(models[11],_testData[21], false);NpgsqlIntervalintervalArray1M.AssertModel(models[12],_testData[22], false);NpgsqlIntervalintervalArray1M.AssertModel(models[13],_testData[23], false);NpgsqlIntervalintervalArray1M.AssertModel(models[14],_testData[24], false);NpgsqlIntervalintervalArray1M.AssertModel(models[15],_testData[25], false);NpgsqlIntervalintervalArray1M.AssertModel(models[16],_testData[26], false);NpgsqlIntervalintervalArray1M.AssertModel(models[17],_testData[27], false);NpgsqlIntervalintervalArray1M.AssertModel(models[18],_testData[28], false);NpgsqlIntervalintervalArray1M.AssertModel(models[19],_testData[29], false);NpgsqlIntervalintervalArray1M.AssertModel(models[20],_testData[30], false);NpgsqlIntervalintervalArray1M.AssertModel(models[21],_testData[31], false);NpgsqlIntervalintervalArray1M.AssertModel(models[22],_testData[32], false);NpgsqlIntervalintervalArray1M.AssertModel(models[23],_testData[33], false);NpgsqlIntervalintervalArray1M.AssertModel(models[24],_testData[34], false);
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
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalArrayintervalArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlIntervalintervalArray1MIWA),
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
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlIntervalintervalArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlIntervalintervalArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlIntervalArrayintervalArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlintervalintervalarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlIntervalArrayintervalArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlIntervalintervalArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlIntervalintervalArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlIntervalintervalArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlIntervalArrayintervalArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlintervalintervalarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlIntervalArrayintervalArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlIntervalintervalArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlintervalintervalarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalArrayintervalArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlIntervalintervalArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalArrayintervalArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlIntervalintervalArray1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlIntervalintervalArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlIntervalArrayintervalArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlintervalintervalarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlIntervalArrayintervalArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlIntervalintervalArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlIntervalintervalArray1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlIntervalintervalArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlIntervalArrayintervalArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlintervalintervalarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlIntervalArrayintervalArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlIntervalintervalArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlintervalintervalarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalArrayintervalArray))]
        private void WASelectImportModelInnerConfig()
        {
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
            methodName:"WAImportModelInner",
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
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlIntervalintervalArray1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlIntervalArrayintervalArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlIntervalArrayintervalArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlIntervalintervalArray1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlIntervalintervalArray1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlIntervalArrayintervalArray)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlIntervalArrayintervalArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlIntervalintervalArray1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlintervalintervalarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalArrayintervalArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlintervalintervalarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlIntervalintervalArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalArrayintervalArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlIntervalintervalArray1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlIntervalintervalArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlIntervalArrayintervalArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlIntervalArrayintervalArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlIntervalintervalArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlIntervalintervalArray1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlIntervalintervalArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlIntervalArrayintervalArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlIntervalArrayintervalArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlIntervalintervalArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlIntervalintervalArray1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlIntervalArrayintervalArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlIntervalArrayintervalArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlIntervalintervalArray1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlIntervalintervalArray1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlIntervalArrayintervalArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlIntervalArrayintervalArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlIntervalintervalArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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

        [Test, Order(13)]
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

        [Test, Order(13)]
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
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalArray1MIWA)],
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
        private void DynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task DynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlIntervalArrayintervalArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlintervalintervalarray1mi
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
                    NpgsqlIntervalintervalArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void DynQueryExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((INpgsqlIntervalArrayintervalArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlintervalintervalarray1mi
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
                    NpgsqlIntervalintervalArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

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

        [Test, Order(13)]
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

        [Test, Order(13)]
        public  void ExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((INpgsqlIntervalArrayintervalArray)this).ExportModelInner(connection).ToList();
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

