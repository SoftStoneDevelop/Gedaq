

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
    internal partial interface INpgsqlIntervalMArrayintervalMArrayD1
    {
    }
    
    internal partial class NpgsqlIntervalMArrayintervalMArrayD1 : INpgsqlIntervalMArrayintervalMArrayD1
    {


#region TestData

        private readonly NpgsqlIntervalintervalMArrayD1E1M[] _testData = new NpgsqlIntervalintervalMArrayD1E1M[]
        {
            new NpgsqlIntervalintervalMArrayD1E1M
{
    Id = 7,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 526),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 889),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1821),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1204),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4627),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2796),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4004),
},
},
            new NpgsqlIntervalintervalMArrayD1E1M
{
    Id = 8,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3073),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2348),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2323),
},
    ModelInner = new NpgsqlIntervalintervalMArrayD11MI
{
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1222),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4847),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1015),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2056),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2716),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1589),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1050),
},
},
            new NpgsqlIntervalintervalMArrayD1E1M
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 373),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 934),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3189),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1706),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4180),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1456),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2200),
},
},
            new NpgsqlIntervalintervalMArrayD1E1M
{
    Id = 11,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3989),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4581),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2744),
},
    ModelInner = new NpgsqlIntervalintervalMArrayD11MI
{
    Id = 12,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1950),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1765),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3904),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3706),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3990),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4790),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3911),
},
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalMArrayD1E1M
{
    Id = 16,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4735),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3742),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3090),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalMArrayD1E1M
{
    Id = 21,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1677),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4902),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3905),
},
    ModelInner = new NpgsqlIntervalintervalMArrayD11MI
{
    Id = 15,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1212),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3467),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4503),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalMArrayD1E1M
{
    Id = 22,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2139),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2469),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4890),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 592),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1409),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2016),
},
},
            new NpgsqlIntervalintervalMArrayD1E1M
{
    Id = 25,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1669),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1559),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4323),
},
    ModelInner = new NpgsqlIntervalintervalMArrayD11MI
{
    Id = 16,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2860),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3392),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2918),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4804),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalMArrayD1E1M
{
    Id = 31,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2274),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2411),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2687),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 470),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4589),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4884),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1933),
},
},
            new NpgsqlIntervalintervalMArrayD1E1M
{
    Id = 39,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1043),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2537),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 413),
},
    ModelInner = new NpgsqlIntervalintervalMArrayD11MI
{
    Id = 20,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3197),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 240),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4083),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2169),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1031),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 961),
},
},
            new NpgsqlIntervalintervalMArrayD1E1M
{
    Id = 44,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4510),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 45),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3606),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalMArrayD1E1M
{
    Id = 48,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1619),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 376),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2697),
},
    ModelInner = new NpgsqlIntervalintervalMArrayD11MI
{
    Id = 24,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3822),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3317),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1000),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 97),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4383),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1862),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3441),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3830),
},
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalMArrayD1E1M
{
    Id = 52,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4071),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4131),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4073),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1816),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1823),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3246),
},
},
            new NpgsqlIntervalintervalMArrayD1E1M
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3340),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 756),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3370),
},
    ModelInner = new NpgsqlIntervalintervalMArrayD11MI
{
    Id = 30,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3001),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3580),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4027),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 917),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1417),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 431),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2446),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2414),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4381),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4971),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4910),
},
},
            new NpgsqlIntervalintervalMArrayD1E1M
{
    Id = 55,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3270),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1561),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 607),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalMArrayD1E1M
{
    Id = 63,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2120),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1857),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3202),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4049),
},
    ModelInner = new NpgsqlIntervalintervalMArrayD11MI
{
    Id = 39,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2047),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3269),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 773),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4949),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3067),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1274),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1605),
},
},
            new NpgsqlIntervalintervalMArrayD1E1M
{
    Id = 68,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 542),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4087),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1502),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4715),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4836),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 987),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4214),
},
},
            new NpgsqlIntervalintervalMArrayD1E1M
{
    Id = 76,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1822),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1482),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 934),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3528),
},
    ModelInner = new NpgsqlIntervalintervalMArrayD11MI
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1120),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3901),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3885),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2599),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2318),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3350),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2043),
},
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalMArrayD1E1M
{
    Id = 80,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3757),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3064),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3975),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalMArrayD1E1M
{
    Id = 84,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3380),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1281),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2073),
},
    ModelInner = new NpgsqlIntervalintervalMArrayD11MI
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2566),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4393),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2589),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1162),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3855),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4026),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3723),
},
},
            new NpgsqlIntervalintervalMArrayD1E1M
{
    Id = 92,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1469),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1630),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1658),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2643),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4730),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 803),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1653),
},
},
            new NpgsqlIntervalintervalMArrayD1E1M
{
    Id = 93,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4463),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2566),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3142),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4549),
},
    ModelInner = new NpgsqlIntervalintervalMArrayD11MI
{
    Id = 60,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 729),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 284),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3987),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2693),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1989),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1471),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2099),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 411),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1278),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1193),
},
},
            new NpgsqlIntervalintervalMArrayD1E1M
{
    Id = 102,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3368),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1021),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2082),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 655),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4947),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3335),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4981),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1570),
},
},
            new NpgsqlIntervalintervalMArrayD1E1M
{
    Id = 111,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 948),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4038),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 149),
},
    ModelInner = new NpgsqlIntervalintervalMArrayD11MI
{
    Id = 69,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1860),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3263),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1085),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2046),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2266),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 338),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 770),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 807),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 270),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1517),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2268),
},
},
            new NpgsqlIntervalintervalMArrayD1E1M
{
    Id = 115,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1808),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3072),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1973),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2713),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2814),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4764),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1689),
},
},
            new NpgsqlIntervalintervalMArrayD1E1M
{
    Id = 124,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4867),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3328),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2020),
},
    ModelInner = new NpgsqlIntervalintervalMArrayD11MI
{
    Id = 78,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1130),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 704),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1600),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4140),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2393),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4649),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3784),
},
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalMArrayD1E1M
{
    Id = 128,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4154),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4304),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4415),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1041),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalMArrayD1E1M
{
    Id = 130,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3238),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2815),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1729),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4770),
},
    ModelInner = new NpgsqlIntervalintervalMArrayD11MI
{
    Id = 87,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 105),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4704),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2848),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1095),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2286),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1150),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1330),
},
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalMArrayD1E1M
{
    Id = 138,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1796),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3126),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3817),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 709),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 592),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 219),
},
},
            new NpgsqlIntervalintervalMArrayD1E1M
{
    Id = 140,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1232),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 178),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3728),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1366),
},
    ModelInner = new NpgsqlIntervalintervalMArrayD11MI
{
    Id = 89,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 27),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2263),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 497),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 599),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 416),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3486),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4792),
},
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalMArrayD1E1M
{
    Id = 141,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4577),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 99),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2513),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2846),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 858),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3018),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 997),
},
},
            new NpgsqlIntervalintervalMArrayD1E1M
{
    Id = 149,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1652),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1588),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3597),
},
    ModelInner = new NpgsqlIntervalintervalMArrayD11MI
{
    Id = 91,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2138),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 372),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1949),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2757),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4756),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1857),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3555),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 899),
},
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalMArrayD1E1M
{
    Id = 151,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1652),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3098),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3818),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4039),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1385),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 98),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3878),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2896),
},
},
            new NpgsqlIntervalintervalMArrayD1E1M
{
    Id = 154,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 950),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1799),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 507),
},
    ModelInner = new NpgsqlIntervalintervalMArrayD11MI
{
    Id = 98,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3263),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3411),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2273),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4610),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1326),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 303),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4159),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4708),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4080),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3983),
},
},
            new NpgsqlIntervalintervalMArrayD1E1M
{
    Id = 160,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3899),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4821),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 582),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2054),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1294),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 783),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3545),
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlintervalintervalmarrayd11mi(
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
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD1)),
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
INSERT INTO public.npgsqlintervalintervalmarrayd11mi(
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
            queryMapTypes: [typeof(NpgsqlIntervalintervalMArrayD11MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD1)),
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

                changedRows =  ((INpgsqlIntervalMArrayintervalMArrayD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlIntervalMArrayintervalMArrayD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlIntervalMArrayintervalMArrayD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlIntervalMArrayintervalMArrayD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlIntervalMArrayintervalMArrayD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlIntervalMArrayintervalMArrayD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlIntervalMArrayintervalMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlIntervalMArrayintervalMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlIntervalMArrayintervalMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlIntervalMArrayintervalMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlIntervalMArrayintervalMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlIntervalMArrayintervalMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlIntervalMArrayintervalMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlIntervalMArrayintervalMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlIntervalMArrayintervalMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlIntervalMArrayintervalMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlIntervalMArrayintervalMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlintervalintervalmarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqlintervalintervalmarrayd11mi_id
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
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD1)), 
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
                methodParametrName: "npgsqlintervalintervalmarrayd11mi_id", 
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
                changedRows =  ((INpgsqlIntervalMArrayintervalMArrayD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlIntervalMArrayintervalMArrayD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlIntervalMArrayintervalMArrayD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlIntervalMArrayintervalMArrayD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlintervalintervalmarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqlintervalintervalmarrayd11mi_id
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
    npgsqlintervalintervalmarrayd11mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD1)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlintervalintervalmarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqlintervalintervalmarrayd11mi_id
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
    npgsqlintervalintervalmarrayd11mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD1)),
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
                methodParametrName: "npgsqlintervalintervalmarrayd11mi_id", 
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
                List<NpgsqlIntervalintervalMArrayD1E1M> models = null;

                models =  ((INpgsqlIntervalMArrayintervalMArrayD1)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlIntervalMArrayintervalMArrayD1)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlIntervalMArrayintervalMArrayD1)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlIntervalMArrayintervalMArrayD1)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlIntervalintervalMArrayD1E1M> models = null;

                models = await ((INpgsqlIntervalMArrayintervalMArrayD1)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlIntervalMArrayintervalMArrayD1)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlIntervalMArrayintervalMArrayD1)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlIntervalMArrayintervalMArrayD1)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlIntervalMArrayintervalMArrayD1)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlIntervalMArrayintervalMArrayD1)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlIntervalMArrayintervalMArrayD1)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlIntervalMArrayintervalMArrayD1)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlIntervalMArrayintervalMArrayD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlIntervalMArrayintervalMArrayD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlIntervalMArrayintervalMArrayD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlIntervalMArrayintervalMArrayD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlIntervalMArrayintervalMArrayD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlIntervalMArrayintervalMArrayD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlIntervalMArrayintervalMArrayD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlIntervalMArrayintervalMArrayD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlIntervalMArrayintervalMArrayD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlIntervalMArrayintervalMArrayD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlIntervalMArrayintervalMArrayD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlIntervalMArrayintervalMArrayD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlIntervalMArrayintervalMArrayD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlIntervalMArrayintervalMArrayD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlIntervalMArrayintervalMArrayD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlIntervalMArrayintervalMArrayD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlIntervalMArrayintervalMArrayD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlIntervalMArrayintervalMArrayD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlIntervalMArrayintervalMArrayD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlIntervalintervalMArrayD1E1M), typeof(FlatNpgsqlIntervalintervalMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD1)),
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
FROM public.npgsqlintervalintervalmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlIntervalintervalMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlIntervalintervalMArrayD1E1M>();
                await ((INpgsqlIntervalMArrayintervalMArrayD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlintervalintervalmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlIntervalintervalMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlIntervalintervalMArrayD1E1M>();
                ((INpgsqlIntervalMArrayintervalMArrayD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlIntervalintervalMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD1)),
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
FROM public.npgsqlintervalintervalmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlIntervalMArrayintervalMArrayD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlintervalintervalmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlIntervalMArrayintervalMArrayD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlintervalintervalmarrayd1e1m m
LEFT JOIN public.npgsqlintervalintervalmarrayd11mi mi ON mi.id = m.npgsqlintervalintervalmarrayd11mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD1)),
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
                var models = await ((INpgsqlIntervalMArrayintervalMArrayD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlIntervalMArrayintervalMArrayD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlIntervalintervalMArrayD1E1M), typeof(FlatNpgsqlIntervalintervalMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD1)),
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
FROM public.npgsqlintervalintervalmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlIntervalintervalMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlIntervalintervalMArrayD1E1M>();
                await ((INpgsqlIntervalMArrayintervalMArrayD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlintervalintervalmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlIntervalintervalMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlIntervalintervalMArrayD1E1M>();
                ((INpgsqlIntervalMArrayintervalMArrayD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlIntervalintervalMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD1)),
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
FROM public.npgsqlintervalintervalmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlIntervalMArrayintervalMArrayD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlintervalintervalmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlIntervalMArrayintervalMArrayD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlintervalintervalmarrayd1e1m m
LEFT JOIN public.npgsqlintervalintervalmarrayd11mi mi ON mi.id = m.npgsqlintervalintervalmarrayd11mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD1)),
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
                var models = await ((INpgsqlIntervalMArrayintervalMArrayD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlIntervalMArrayintervalMArrayD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlIntervalintervalMArrayD1E1M), typeof(FlatNpgsqlIntervalintervalMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD1)),
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
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD1)),
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
FROM public.npgsqlintervalintervalmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlIntervalintervalMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlIntervalintervalMArrayD1E1M>();
                await((INpgsqlIntervalMArrayintervalMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 115;
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
FROM public.npgsqlintervalintervalmarrayd1e1m m
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
FROM public.npgsqlintervalintervalmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlIntervalintervalMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlIntervalintervalMArrayD1E1M>();
                await ((INpgsqlIntervalMArrayintervalMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[10],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 84;
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
FROM public.npgsqlintervalintervalmarrayd1e1m m
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
FROM public.npgsqlintervalintervalmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlIntervalintervalMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalMArrayD1E1M>();
                await ((INpgsqlIntervalMArrayintervalMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[32],_testData[34], false);
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
FROM public.npgsqlintervalintervalmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlIntervalintervalMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlIntervalintervalMArrayD1E1M>();
                ((INpgsqlIntervalMArrayintervalMArrayD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 54;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 52;
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
FROM public.npgsqlintervalintervalmarrayd1e1m m
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
FROM public.npgsqlintervalintervalmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlIntervalintervalMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlIntervalintervalMArrayD1E1M>();
                 ((INpgsqlIntervalMArrayintervalMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[21],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 54;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 48;
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
FROM public.npgsqlintervalintervalmarrayd1e1m m
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
FROM public.npgsqlintervalintervalmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlIntervalintervalMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalMArrayD1E1M>();
                 ((INpgsqlIntervalMArrayintervalMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[22],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlIntervalintervalMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD1)),
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
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD1)),
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
FROM public.npgsqlintervalintervalmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlIntervalMArrayintervalMArrayD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 84;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 8;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlintervalintervalmarrayd1e1m m
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
FROM public.npgsqlintervalintervalmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlIntervalMArrayintervalMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[9],_testData[29], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[10],_testData[30], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[11],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[12],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[13],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[27],_testData[29], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[28],_testData[30], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[29],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[30],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[31],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[32],_testData[34], false);
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
                parametr1.Value = 102;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 7;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlintervalintervalmarrayd1e1m m
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
FROM public.npgsqlintervalintervalmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlIntervalintervalMArrayD1E1M>();
                await ((INpgsqlIntervalMArrayintervalMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[33],_testData[34], false);
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
FROM public.npgsqlintervalintervalmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlIntervalMArrayintervalMArrayD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 76;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 102;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlintervalintervalmarrayd1e1m m
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
FROM public.npgsqlintervalintervalmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlIntervalMArrayintervalMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[11],_testData[29], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[12],_testData[30], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[13],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[14],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[15],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[11],_testData[34], false);
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
                parametr1.Value = 7;
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
FROM public.npgsqlintervalintervalmarrayd1e1m m
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
FROM public.npgsqlintervalintervalmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlIntervalintervalMArrayD1E1M>();
                 ((INpgsqlIntervalMArrayintervalMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM public.npgsqlintervalintervalmarrayd1e1m m
LEFT JOIN public.npgsqlintervalintervalmarrayd11mi mi ON mi.id = m.npgsqlintervalintervalmarrayd11mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD1)),
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
                var models = await((INpgsqlIntervalMArrayintervalMArrayD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 44;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 130;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlIntervalMArrayintervalMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[0],_testData[11], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[1],_testData[12], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[2],_testData[13], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[3],_testData[14], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[4],_testData[15], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[5],_testData[16], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[6],_testData[17], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[7],_testData[18], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[8],_testData[19], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[9],_testData[20], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[10],_testData[21], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[11],_testData[22], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[12],_testData[23], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[13],_testData[24], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[14],_testData[25], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[15],_testData[26], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[16],_testData[27], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[17],_testData[28], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[18],_testData[29], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[19],_testData[30], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[20],_testData[31], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[21],_testData[32], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[22],_testData[33], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[0],_testData[28], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[1],_testData[29], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[2],_testData[30], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[3],_testData[31], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[4],_testData[32], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[5],_testData[33], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[6],_testData[34], false);
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
                var models = ((INpgsqlIntervalMArrayintervalMArrayD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 8;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 93;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlIntervalMArrayintervalMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[0],_testData[2], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[1],_testData[3], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[2],_testData[4], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[3],_testData[5], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[4],_testData[6], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[5],_testData[7], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[6],_testData[8], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[7],_testData[9], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[8],_testData[10], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[9],_testData[11], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[10],_testData[12], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[11],_testData[13], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[12],_testData[14], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[13],_testData[15], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[14],_testData[16], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[15],_testData[17], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[16],_testData[18], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[17],_testData[19], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[18],_testData[20], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[19],_testData[21], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[20],_testData[22], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[21],_testData[23], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[22],_testData[24], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[23],_testData[25], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[24],_testData[26], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[25],_testData[27], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[26],_testData[28], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[27],_testData[29], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[28],_testData[30], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[29],_testData[31], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[30],_testData[32], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[31],_testData[33], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[0],_testData[22], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[1],_testData[23], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[2],_testData[24], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[3],_testData[25], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[4],_testData[26], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[5],_testData[27], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[6],_testData[28], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[7],_testData[29], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[8],_testData[30], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[9],_testData[31], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[10],_testData[32], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[11],_testData[33], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlIntervalintervalMArrayD1E1M), typeof(FlatNpgsqlIntervalintervalMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD1)),
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
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD1)),
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
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD1)),
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
FROM public.npgsqlintervalintervalmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlIntervalintervalMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlIntervalintervalMArrayD1E1M>();
                await((INpgsqlIntervalMArrayintervalMArrayD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlintervalintervalmarrayd1e1m m
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
FROM public.npgsqlintervalintervalmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlIntervalintervalMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlIntervalintervalMArrayD1E1M>();
                await ((INpgsqlIntervalMArrayintervalMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 128, query1, 11, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.npgsqlintervalintervalmarrayd1e1m m
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
FROM public.npgsqlintervalintervalmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlIntervalintervalMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalMArrayD1E1M>();
                await ((INpgsqlIntervalMArrayintervalMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 11, query1, 84, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[14],_testData[34], false);
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
FROM public.npgsqlintervalintervalmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlIntervalintervalMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlIntervalintervalMArrayD1E1M>();
                ((INpgsqlIntervalMArrayintervalMArrayD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlintervalintervalmarrayd1e1m m
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
FROM public.npgsqlintervalintervalmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlIntervalintervalMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlIntervalintervalMArrayD1E1M>();
                 ((INpgsqlIntervalMArrayintervalMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 92, query1, 115, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[9],_testData[34], false);
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
FROM public.npgsqlintervalintervalmarrayd1e1m m
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
FROM public.npgsqlintervalintervalmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlIntervalintervalMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalMArrayD1E1M>();
                 ((INpgsqlIntervalMArrayintervalMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 84, query1, 128, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[7],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlIntervalintervalMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD1)),
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
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD1)),
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
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD1)),
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
FROM public.npgsqlintervalintervalmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlIntervalMArrayintervalMArrayD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlintervalintervalmarrayd1e1m m
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
FROM public.npgsqlintervalintervalmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlIntervalMArrayintervalMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 9, query1, 25, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[26],_testData[29], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[27],_testData[30], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[28],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[29],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[30],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[21],_testData[29], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[22],_testData[30], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[23],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[24],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[25],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[26],_testData[34], false);
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
FROM public.npgsqlintervalintervalmarrayd1e1m m
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
FROM public.npgsqlintervalintervalmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlIntervalintervalMArrayD1E1M>();
                await ((INpgsqlIntervalMArrayintervalMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 76, query1, 55, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[19],_testData[34], false);
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
FROM public.npgsqlintervalintervalmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlIntervalMArrayintervalMArrayD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlintervalintervalmarrayd1e1m m
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
FROM public.npgsqlintervalintervalmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlIntervalMArrayintervalMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 7, query1, 22, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[0],_testData[1], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[1],_testData[2], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[2],_testData[3], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[3],_testData[4], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[4],_testData[5], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[5],_testData[6], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[6],_testData[7], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[7],_testData[8], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[8],_testData[9], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[9],_testData[10], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[10],_testData[11], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[11],_testData[12], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[12],_testData[13], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[13],_testData[14], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[14],_testData[15], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[15],_testData[16], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[16],_testData[17], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[17],_testData[18], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[18],_testData[19], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[19],_testData[20], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[20],_testData[21], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[21],_testData[22], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[22],_testData[23], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[23],_testData[24], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[24],_testData[25], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[25],_testData[26], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[26],_testData[27], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[27],_testData[28], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[28],_testData[29], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[29],_testData[30], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[30],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[31],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[32],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[22],_testData[29], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[23],_testData[30], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[24],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[25],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[26],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[27],_testData[34], false);
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
FROM public.npgsqlintervalintervalmarrayd1e1m m
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
FROM public.npgsqlintervalintervalmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlIntervalintervalMArrayD1E1M>();
                 ((INpgsqlIntervalMArrayintervalMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 8, query1, 11, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatNpgsqlIntervalintervalMArrayD1E1M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.npgsqlintervalintervalmarrayd1e1m m
LEFT JOIN public.npgsqlintervalintervalmarrayd11mi mi ON mi.id = m.npgsqlintervalintervalmarrayd11mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD1)),
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
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD1)),
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
                var models = await((INpgsqlIntervalMArrayintervalMArrayD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlIntervalMArrayintervalMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 128, 138))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[0],_testData[27], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[1],_testData[28], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[2],_testData[29], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[3],_testData[30], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[4],_testData[31], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[5],_testData[32], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[6],_testData[33], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[0],_testData[29], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[1],_testData[30], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[2],_testData[31], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[3],_testData[32], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[4],_testData[33], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[5],_testData[34], false);
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
                var models = ((INpgsqlIntervalMArrayintervalMArrayD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlIntervalMArrayintervalMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 55, 11))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[0],_testData[15], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[1],_testData[16], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[2],_testData[17], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[3],_testData[18], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[4],_testData[19], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[5],_testData[20], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[6],_testData[21], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[7],_testData[22], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[8],_testData[23], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[9],_testData[24], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[10],_testData[25], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[11],_testData[26], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[12],_testData[27], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[13],_testData[28], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[14],_testData[29], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[15],_testData[30], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[16],_testData[31], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[17],_testData[32], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[18],_testData[33], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[0],_testData[4], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[1],_testData[5], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[2],_testData[6], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[3],_testData[7], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[4],_testData[8], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[5],_testData[9], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[6],_testData[10], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[7],_testData[11], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[8],_testData[12], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[9],_testData[13], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[10],_testData[14], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[11],_testData[15], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[12],_testData[16], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[13],_testData[17], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[14],_testData[18], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[15],_testData[19], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[16],_testData[20], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[17],_testData[21], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[18],_testData[22], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[19],_testData[23], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[20],_testData[24], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[21],_testData[25], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[22],_testData[26], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[23],_testData[27], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[24],_testData[28], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[25],_testData[29], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[26],_testData[30], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[27],_testData[31], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[28],_testData[32], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[29],_testData[33], false);
                        NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[30],_testData[34], false);
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
                await using var cmd = await ((INpgsqlIntervalMArrayintervalMArrayD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlIntervalMArrayintervalMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 130);
                var models = await ((INpgsqlIntervalMArrayintervalMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(7));

                NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[0],_testData[28], false);
                NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[1],_testData[29], false);
                NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[2],_testData[30], false);
                NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[3],_testData[31], false);
                NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[4],_testData[32], false);
                NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[5],_testData[33], false);
                NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[6],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlIntervalMArrayintervalMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlIntervalMArrayintervalMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 25);
                var models =  ((INpgsqlIntervalMArrayintervalMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(27));

                NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[0],_testData[8], false);
                NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[1],_testData[9], false);
                NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[2],_testData[10], false);
                NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[3],_testData[11], false);
                NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[4],_testData[12], false);
                NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[5],_testData[13], false);
                NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[6],_testData[14], false);
                NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[7],_testData[15], false);
                NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[8],_testData[16], false);
                NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[9],_testData[17], false);
                NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[10],_testData[18], false);
                NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[11],_testData[19], false);
                NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[12],_testData[20], false);
                NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[13],_testData[21], false);
                NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[14],_testData[22], false);
                NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[15],_testData[23], false);
                NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[16],_testData[24], false);
                NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[17],_testData[25], false);
                NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[18],_testData[26], false);
                NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[19],_testData[27], false);
                NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[20],_testData[28], false);
                NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[21],_testData[29], false);
                NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[22],_testData[30], false);
                NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[23],_testData[31], false);
                NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[24],_testData[32], false);
                NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[25],_testData[33], false);
                NpgsqlIntervalintervalMArrayD1E1M.AssertModel(models[26],_testData[34], false);
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
FROM public.binary_npgsqlintervalintervalmarrayd11mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlIntervalintervalMArrayD11MIWA),
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
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlIntervalintervalMArrayD11MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlIntervalintervalMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlIntervalMArrayintervalMArrayD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlintervalintervalmarrayd11mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlIntervalMArrayintervalMArrayD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlIntervalintervalMArrayD11MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlIntervalintervalMArrayD11MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlIntervalintervalMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlIntervalMArrayintervalMArrayD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlintervalintervalmarrayd11mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlIntervalMArrayintervalMArrayD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlIntervalintervalMArrayD11MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlintervalintervalmarrayd11mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlIntervalintervalMArrayD11MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlIntervalintervalMArrayD11MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlIntervalintervalMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlIntervalMArrayintervalMArrayD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlintervalintervalmarrayd11mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlIntervalMArrayintervalMArrayD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlIntervalintervalMArrayD11MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlIntervalintervalMArrayD11MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlIntervalintervalMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlIntervalMArrayintervalMArrayD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlintervalintervalmarrayd11mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlIntervalMArrayintervalMArrayD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlIntervalintervalMArrayD11MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlintervalintervalmarrayd11mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMArrayD11MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlintervalintervalmarrayd11mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlIntervalintervalMArrayD11MI),
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
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlIntervalintervalMArrayD11MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlIntervalMArrayintervalMArrayD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlIntervalMArrayintervalMArrayD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlIntervalintervalMArrayD11MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlIntervalintervalMArrayD11MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlIntervalMArrayintervalMArrayD1)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlIntervalMArrayintervalMArrayD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlIntervalintervalMArrayD11MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlintervalintervalmarrayd11mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlintervalintervalmarrayd11mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlIntervalintervalMArrayD11MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlIntervalintervalMArrayD11MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlIntervalintervalMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlIntervalMArrayintervalMArrayD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlIntervalMArrayintervalMArrayD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlIntervalintervalMArrayD11MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlIntervalintervalMArrayD11MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlIntervalintervalMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlIntervalMArrayintervalMArrayD1)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlIntervalMArrayintervalMArrayD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlIntervalintervalMArrayD11MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlintervalintervalmarrayd1e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlintervalintervalmarrayd11mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlIntervalintervalMArrayD1E1M),
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
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD1))]
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
FROM public.binary_npgsqlintervalintervalmarrayd1e1m m
LEFT JOIN public.binary_npgsqlintervalintervalmarrayd11mi mi ON mi.id = m.npgsqlintervalintervalmarrayd11mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlIntervalintervalMArrayD1E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlIntervalMArrayintervalMArrayD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlIntervalMArrayintervalMArrayD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlIntervalintervalMArrayD1E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlIntervalintervalMArrayD1E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlIntervalMArrayintervalMArrayD1)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlIntervalMArrayintervalMArrayD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlIntervalintervalMArrayD1E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlintervalintervalmarrayd1e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlintervalintervalmarrayd11mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD1)),
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
                var models =  ((INpgsqlIntervalMArrayintervalMArrayD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlIntervalintervalMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlIntervalMArrayintervalMArrayD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlIntervalintervalMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMArrayD11MIWA), typeof(NpgsqlIntervalintervalMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD1)),
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
                var models1 = new List<NpgsqlIntervalintervalMArrayD11MIWA>();
                var models2 = new List<NpgsqlIntervalintervalMArrayD11MIWA>();
                await ((INpgsqlIntervalMArrayintervalMArrayD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlintervalintervalmarrayd11mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlIntervalintervalMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlIntervalintervalMArrayD11MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlIntervalintervalMArrayD11MIWA>();
                var models2 = new List<NpgsqlIntervalintervalMArrayD11MIWA>();
                ((INpgsqlIntervalMArrayintervalMArrayD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlintervalintervalmarrayd11mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlIntervalintervalMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlIntervalintervalMArrayD11MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD1)),
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
                var models = await ((INpgsqlIntervalMArrayintervalMArrayD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlintervalintervalmarrayd11mi
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
                    NpgsqlIntervalintervalMArrayD11MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlIntervalMArrayintervalMArrayD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlintervalintervalmarrayd11mi
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
                    NpgsqlIntervalintervalMArrayD11MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMArrayD11MIWA), typeof(NpgsqlIntervalintervalMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD1))]
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
                var models1 = new List<NpgsqlIntervalintervalMArrayD11MIWA>();
                var models2 = new List<NpgsqlIntervalintervalMArrayD11MIWA>();
                await ((INpgsqlIntervalMArrayintervalMArrayD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlintervalintervalmarrayd11mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlIntervalintervalMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlIntervalintervalMArrayD11MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlIntervalintervalMArrayD11MIWA>();
                var models2 = new List<NpgsqlIntervalintervalMArrayD11MIWA>();
                ((INpgsqlIntervalMArrayintervalMArrayD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlintervalintervalmarrayd11mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlIntervalintervalMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlIntervalintervalMArrayD11MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD1))]
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
                var models = await ((INpgsqlIntervalMArrayintervalMArrayD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlintervalintervalmarrayd11mi
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
                    NpgsqlIntervalintervalMArrayD11MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlIntervalMArrayintervalMArrayD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlintervalintervalmarrayd11mi
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
                    NpgsqlIntervalintervalMArrayD11MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlintervalintervalmarrayd11mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMArrayD11MI), typeof(NpgsqlIntervalintervalMArrayD11MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD1)),
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
                var models1 = new List<NpgsqlIntervalintervalMArrayD11MI>();
                var models2 = new List<NpgsqlIntervalintervalMArrayD11MI>();
                await ((INpgsqlIntervalMArrayintervalMArrayD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlIntervalintervalMArrayD11MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlIntervalintervalMArrayD11MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlIntervalintervalMArrayD11MI>();
                var models2 = new List<NpgsqlIntervalintervalMArrayD11MI>();
                ((INpgsqlIntervalMArrayintervalMArrayD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlIntervalintervalMArrayD11MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlIntervalintervalMArrayD11MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlintervalintervalmarrayd11mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMArrayD11MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD1)),
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
                var models = await ((INpgsqlIntervalMArrayintervalMArrayD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlIntervalintervalMArrayD11MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlIntervalMArrayintervalMArrayD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlIntervalintervalMArrayD11MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlintervalintervalmarrayd11mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMArrayD11MIWA), typeof(NpgsqlIntervalintervalMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD1))]
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
                var models1 = new List<NpgsqlIntervalintervalMArrayD11MIWA>();
                var models2 = new List<NpgsqlIntervalintervalMArrayD11MIWA>();
                await ((INpgsqlIntervalMArrayintervalMArrayD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlIntervalintervalMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlIntervalintervalMArrayD11MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlIntervalintervalMArrayD11MIWA>();
                var models2 = new List<NpgsqlIntervalintervalMArrayD11MIWA>();
                ((INpgsqlIntervalMArrayintervalMArrayD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlIntervalintervalMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlIntervalintervalMArrayD11MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlintervalintervalmarrayd11mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMArrayD1))]
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
                var models = await ((INpgsqlIntervalMArrayintervalMArrayD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlIntervalintervalMArrayD11MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlIntervalMArrayintervalMArrayD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlIntervalintervalMArrayD11MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

