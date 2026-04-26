

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
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2414),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4849),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3376),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3553),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 11,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2424),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2759),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4902),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 182),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3413),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3293),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3422),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3458),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1580),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 559),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4635),
},
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 14,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2532),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1456),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 956),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3804),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2128),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3331),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3197),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2015),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 15,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2425),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1906),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3674),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 17,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3564),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4259),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2414),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1455),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3764),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 262),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 22,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1012),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3652),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 755),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3842),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 30,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2635),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 151),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 743),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 23,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3785),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1607),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2535),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 777),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2353),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2898),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 981),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 34,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 976),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2618),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4694),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 36,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4174),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1931),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1425),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3757),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 28,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4588),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1811),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2259),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2549),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4244),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4449),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 337),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 609),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2326),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2259),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 480),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3182),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 44,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4648),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 389),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2532),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 51,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 267),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3253),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3297),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4119),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 32,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1697),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1478),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3587),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3956),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4067),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3371),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3730),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1131),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 490),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 945),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4844),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 53,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2061),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4065),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 787),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 58,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4154),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3168),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3110),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3034),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 543),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4384),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 66,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 484),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2952),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1650),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4994),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 584),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3739),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 670),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4757),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 72,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2504),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3178),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1058),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4109),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1715),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2561),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 49),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2047),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2924),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1665),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4789),
},
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 76,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2826),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1048),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1614),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2875),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1432),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2415),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 604),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 77,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3316),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4528),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 728),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4409),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 51,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4948),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1615),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1293),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 383),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1638),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1827),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1913),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 83,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3421),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1995),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1366),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1615),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3418),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4100),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1592),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 91,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2829),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4133),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3057),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 57,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 342),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3018),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3872),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3930),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1730),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4712),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3628),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 137),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3650),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2971),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 93,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4066),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4288),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2063),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 992),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 96,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4048),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3465),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1772),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1395),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4752),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 274),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1296),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1888),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1989),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2401),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1792),
},
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 104,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1969),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3061),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1289),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 582),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4407),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4332),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4569),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 446),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 107,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4418),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1260),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1194),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2151),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 68,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4197),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 697),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2488),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 265),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3172),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3059),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3974),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 109,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 681),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1644),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1064),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3925),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2348),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3940),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 117,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2065),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2518),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 149),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3303),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 76,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 359),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3105),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2261),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2310),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4051),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2482),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1272),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3712),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 123,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2108),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4088),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3155),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2939),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1295),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4166),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3746),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 132,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2204),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1376),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3254),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4184),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 80,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3331),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2267),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2289),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 7),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4791),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1549),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1465),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4928),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 139,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1382),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 587),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4777),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1203),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4899),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2971),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 141,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1968),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3240),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2197),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 89,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3523),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4526),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1903),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2986),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4998),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1502),
},
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 144,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1943),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4103),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3765),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 153,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2048),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4812),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1068),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 97,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3636),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4899),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4687),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2499),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 948),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4677),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2453),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4658),
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
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlIntervalintervalArray1M)],
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
LEFT JOIN public.npgsqlintervalintervalarray1mi mi ON mi.id = m.npgsqlintervalintervalarray1mi_id
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
LEFT JOIN public.npgsqlintervalintervalarray1mi mi ON mi.id = m.npgsqlintervalintervalarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models =  ((INpgsqlIntervalArrayintervalArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
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

                var models =  ((INpgsqlIntervalArrayintervalArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlIntervalintervalArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlIntervalintervalArray1M)],
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
LEFT JOIN public.npgsqlintervalintervalarray1mi mi ON mi.id = m.npgsqlintervalintervalarray1mi_id
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
LEFT JOIN public.npgsqlintervalintervalarray1mi mi ON mi.id = m.npgsqlintervalintervalarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models =  ((INpgsqlIntervalArrayintervalArray)this).DynQuerySelectModel(connection,  query, 0);
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
                var models =  ((INpgsqlIntervalArrayintervalArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlIntervalintervalArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlIntervalintervalArray1M)],
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
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
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
LEFT JOIN public.npgsqlintervalintervalarray1mi mi ON mi.id = m.npgsqlintervalintervalarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models = await ((INpgsqlIntervalArrayintervalArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlIntervalintervalArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 34;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 139;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlintervalintervalarray1m m
LEFT JOIN public.npgsqlintervalintervalarray1mi mi ON mi.id = m.npgsqlintervalintervalarray1mi_id
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
LEFT JOIN public.npgsqlintervalintervalarray1mi mi ON mi.id = m.npgsqlintervalintervalarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlIntervalArrayintervalArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
FlatNpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[7], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[8], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[2],_testData[9], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[3],_testData[10], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[4],_testData[11], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[5],_testData[12], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[6],_testData[13], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[7],_testData[14], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[8],_testData[15], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[9],_testData[16], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[10],_testData[17], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[11],_testData[18], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[12],_testData[19], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[13],_testData[20], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[14],_testData[21], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[15],_testData[22], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[16],_testData[23], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[17],_testData[24], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[18],_testData[25], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[19],_testData[26], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[20],_testData[27], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[21],_testData[28], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));
FlatNpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[27], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[28], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[2],_testData[29], false);
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
FROM public.npgsqlintervalintervalarray1m m
LEFT JOIN public.npgsqlintervalintervalarray1mi mi ON mi.id = m.npgsqlintervalintervalarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models =  ((INpgsqlIntervalArrayintervalArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlIntervalintervalArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 123;
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
LEFT JOIN public.npgsqlintervalintervalarray1mi mi ON mi.id = m.npgsqlintervalintervalarray1mi_id
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
LEFT JOIN public.npgsqlintervalintervalarray1mi mi ON mi.id = m.npgsqlintervalintervalarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlIntervalArrayintervalArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));
FlatNpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[25], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[26], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[2],_testData[27], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[3],_testData[28], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));
FlatNpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[1], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[2], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[2],_testData[3], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[3],_testData[4], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[4],_testData[5], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[5],_testData[6], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[6],_testData[7], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[7],_testData[8], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[8],_testData[9], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[9],_testData[10], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[10],_testData[11], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[11],_testData[12], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[12],_testData[13], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[13],_testData[14], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[14],_testData[15], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[15],_testData[16], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[16],_testData[17], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[17],_testData[18], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[18],_testData[19], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[19],_testData[20], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[20],_testData[21], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[21],_testData[22], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[22],_testData[23], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[23],_testData[24], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[24],_testData[25], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[25],_testData[26], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[26],_testData[27], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[27],_testData[28], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[28],_testData[29], false);
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
            batchName: "DbConnectionSelectModelDynParBatch",
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

                var models = await ((INpgsqlIntervalArrayintervalArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlIntervalintervalArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 76;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 51;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlIntervalArrayintervalArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
NpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[15], false);NpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[16], false);NpgsqlIntervalintervalArray1M.AssertModel(models[2],_testData[17], false);NpgsqlIntervalintervalArray1M.AssertModel(models[3],_testData[18], false);NpgsqlIntervalintervalArray1M.AssertModel(models[4],_testData[19], false);NpgsqlIntervalintervalArray1M.AssertModel(models[5],_testData[20], false);NpgsqlIntervalintervalArray1M.AssertModel(models[6],_testData[21], false);NpgsqlIntervalintervalArray1M.AssertModel(models[7],_testData[22], false);NpgsqlIntervalintervalArray1M.AssertModel(models[8],_testData[23], false);NpgsqlIntervalintervalArray1M.AssertModel(models[9],_testData[24], false);NpgsqlIntervalintervalArray1M.AssertModel(models[10],_testData[25], false);NpgsqlIntervalintervalArray1M.AssertModel(models[11],_testData[26], false);NpgsqlIntervalintervalArray1M.AssertModel(models[12],_testData[27], false);NpgsqlIntervalintervalArray1M.AssertModel(models[13],_testData[28], false);NpgsqlIntervalintervalArray1M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));
NpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[10], false);NpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[11], false);NpgsqlIntervalintervalArray1M.AssertModel(models[2],_testData[12], false);NpgsqlIntervalintervalArray1M.AssertModel(models[3],_testData[13], false);NpgsqlIntervalintervalArray1M.AssertModel(models[4],_testData[14], false);NpgsqlIntervalintervalArray1M.AssertModel(models[5],_testData[15], false);NpgsqlIntervalintervalArray1M.AssertModel(models[6],_testData[16], false);NpgsqlIntervalintervalArray1M.AssertModel(models[7],_testData[17], false);NpgsqlIntervalintervalArray1M.AssertModel(models[8],_testData[18], false);NpgsqlIntervalintervalArray1M.AssertModel(models[9],_testData[19], false);NpgsqlIntervalintervalArray1M.AssertModel(models[10],_testData[20], false);NpgsqlIntervalintervalArray1M.AssertModel(models[11],_testData[21], false);NpgsqlIntervalintervalArray1M.AssertModel(models[12],_testData[22], false);NpgsqlIntervalintervalArray1M.AssertModel(models[13],_testData[23], false);NpgsqlIntervalintervalArray1M.AssertModel(models[14],_testData[24], false);NpgsqlIntervalintervalArray1M.AssertModel(models[15],_testData[25], false);NpgsqlIntervalintervalArray1M.AssertModel(models[16],_testData[26], false);NpgsqlIntervalintervalArray1M.AssertModel(models[17],_testData[27], false);NpgsqlIntervalintervalArray1M.AssertModel(models[18],_testData[28], false);NpgsqlIntervalintervalArray1M.AssertModel(models[19],_testData[29], false);
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

                var models =  ((INpgsqlIntervalArrayintervalArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlIntervalintervalArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 51;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 141;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlIntervalArrayintervalArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));
NpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[10], false);NpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[11], false);NpgsqlIntervalintervalArray1M.AssertModel(models[2],_testData[12], false);NpgsqlIntervalintervalArray1M.AssertModel(models[3],_testData[13], false);NpgsqlIntervalintervalArray1M.AssertModel(models[4],_testData[14], false);NpgsqlIntervalintervalArray1M.AssertModel(models[5],_testData[15], false);NpgsqlIntervalintervalArray1M.AssertModel(models[6],_testData[16], false);NpgsqlIntervalintervalArray1M.AssertModel(models[7],_testData[17], false);NpgsqlIntervalintervalArray1M.AssertModel(models[8],_testData[18], false);NpgsqlIntervalintervalArray1M.AssertModel(models[9],_testData[19], false);NpgsqlIntervalintervalArray1M.AssertModel(models[10],_testData[20], false);NpgsqlIntervalintervalArray1M.AssertModel(models[11],_testData[21], false);NpgsqlIntervalintervalArray1M.AssertModel(models[12],_testData[22], false);NpgsqlIntervalintervalArray1M.AssertModel(models[13],_testData[23], false);NpgsqlIntervalintervalArray1M.AssertModel(models[14],_testData[24], false);NpgsqlIntervalintervalArray1M.AssertModel(models[15],_testData[25], false);NpgsqlIntervalintervalArray1M.AssertModel(models[16],_testData[26], false);NpgsqlIntervalintervalArray1M.AssertModel(models[17],_testData[27], false);NpgsqlIntervalintervalArray1M.AssertModel(models[18],_testData[28], false);NpgsqlIntervalintervalArray1M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
NpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[28], false);NpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlIntervalintervalArray1M)],
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
            batchName: "DbConnectionDynQuerySelectModelBatch",
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
LEFT JOIN public.npgsqlintervalintervalarray1mi mi ON mi.id = m.npgsqlintervalintervalarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlIntervalArrayintervalArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlIntervalintervalArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlintervalintervalarray1m m
LEFT JOIN public.npgsqlintervalintervalarray1mi mi ON mi.id = m.npgsqlintervalintervalarray1mi_id
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
LEFT JOIN public.npgsqlintervalintervalarray1mi mi ON mi.id = m.npgsqlintervalintervalarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlIntervalArrayintervalArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 141, query1, 51, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
FlatNpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[28], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));
FlatNpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[10], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[11], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[2],_testData[12], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[3],_testData[13], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[4],_testData[14], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[5],_testData[15], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[6],_testData[16], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[7],_testData[17], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[8],_testData[18], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[9],_testData[19], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[10],_testData[20], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[11],_testData[21], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[12],_testData[22], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[13],_testData[23], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[14],_testData[24], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[15],_testData[25], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[16],_testData[26], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[17],_testData[27], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[18],_testData[28], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[19],_testData[29], false);
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
FROM public.npgsqlintervalintervalarray1m m
LEFT JOIN public.npgsqlintervalintervalarray1mi mi ON mi.id = m.npgsqlintervalintervalarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((INpgsqlIntervalArrayintervalArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlIntervalintervalArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlintervalintervalarray1m m
LEFT JOIN public.npgsqlintervalintervalarray1mi mi ON mi.id = m.npgsqlintervalintervalarray1mi_id
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
LEFT JOIN public.npgsqlintervalintervalarray1mi mi ON mi.id = m.npgsqlintervalintervalarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlIntervalArrayintervalArray)this).DbConnectionDynQuerySelectModelBatch(connection, 51, query1, 104, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));
FlatNpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[10], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[11], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[2],_testData[12], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[3],_testData[13], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[4],_testData[14], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[5],_testData[15], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[6],_testData[16], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[7],_testData[17], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[8],_testData[18], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[9],_testData[19], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[10],_testData[20], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[11],_testData[21], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[12],_testData[22], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[13],_testData[23], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[14],_testData[24], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[15],_testData[25], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[16],_testData[26], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[17],_testData[27], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[18],_testData[28], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));
FlatNpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[21], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[22], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[2],_testData[23], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[3],_testData[24], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[4],_testData[25], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[5],_testData[26], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[6],_testData[27], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[7],_testData[28], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[8],_testData[29], false);
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
            batchName: "DbConnectionSelectModelBatch",
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
        private void DbConnectionSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlIntervalArrayintervalArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlIntervalintervalArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlIntervalArrayintervalArray)this).DbConnectionSelectModelBatchAsync(connection, 76, 22))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
NpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[15], false);NpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[16], false);NpgsqlIntervalintervalArray1M.AssertModel(models[2],_testData[17], false);NpgsqlIntervalintervalArray1M.AssertModel(models[3],_testData[18], false);NpgsqlIntervalintervalArray1M.AssertModel(models[4],_testData[19], false);NpgsqlIntervalintervalArray1M.AssertModel(models[5],_testData[20], false);NpgsqlIntervalintervalArray1M.AssertModel(models[6],_testData[21], false);NpgsqlIntervalintervalArray1M.AssertModel(models[7],_testData[22], false);NpgsqlIntervalintervalArray1M.AssertModel(models[8],_testData[23], false);NpgsqlIntervalintervalArray1M.AssertModel(models[9],_testData[24], false);NpgsqlIntervalintervalArray1M.AssertModel(models[10],_testData[25], false);NpgsqlIntervalintervalArray1M.AssertModel(models[11],_testData[26], false);NpgsqlIntervalintervalArray1M.AssertModel(models[12],_testData[27], false);NpgsqlIntervalintervalArray1M.AssertModel(models[13],_testData[28], false);NpgsqlIntervalintervalArray1M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));
NpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[5], false);NpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[6], false);NpgsqlIntervalintervalArray1M.AssertModel(models[2],_testData[7], false);NpgsqlIntervalintervalArray1M.AssertModel(models[3],_testData[8], false);NpgsqlIntervalintervalArray1M.AssertModel(models[4],_testData[9], false);NpgsqlIntervalintervalArray1M.AssertModel(models[5],_testData[10], false);NpgsqlIntervalintervalArray1M.AssertModel(models[6],_testData[11], false);NpgsqlIntervalintervalArray1M.AssertModel(models[7],_testData[12], false);NpgsqlIntervalintervalArray1M.AssertModel(models[8],_testData[13], false);NpgsqlIntervalintervalArray1M.AssertModel(models[9],_testData[14], false);NpgsqlIntervalintervalArray1M.AssertModel(models[10],_testData[15], false);NpgsqlIntervalintervalArray1M.AssertModel(models[11],_testData[16], false);NpgsqlIntervalintervalArray1M.AssertModel(models[12],_testData[17], false);NpgsqlIntervalintervalArray1M.AssertModel(models[13],_testData[18], false);NpgsqlIntervalintervalArray1M.AssertModel(models[14],_testData[19], false);NpgsqlIntervalintervalArray1M.AssertModel(models[15],_testData[20], false);NpgsqlIntervalintervalArray1M.AssertModel(models[16],_testData[21], false);NpgsqlIntervalintervalArray1M.AssertModel(models[17],_testData[22], false);NpgsqlIntervalintervalArray1M.AssertModel(models[18],_testData[23], false);NpgsqlIntervalintervalArray1M.AssertModel(models[19],_testData[24], false);NpgsqlIntervalintervalArray1M.AssertModel(models[20],_testData[25], false);NpgsqlIntervalintervalArray1M.AssertModel(models[21],_testData[26], false);NpgsqlIntervalintervalArray1M.AssertModel(models[22],_testData[27], false);NpgsqlIntervalintervalArray1M.AssertModel(models[23],_testData[28], false);NpgsqlIntervalintervalArray1M.AssertModel(models[24],_testData[29], false);
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
                var models =  ((INpgsqlIntervalArrayintervalArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlIntervalintervalArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlIntervalArrayintervalArray)this).DbConnectionSelectModelBatch(connection, 58, 34))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
NpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[12], false);NpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[13], false);NpgsqlIntervalintervalArray1M.AssertModel(models[2],_testData[14], false);NpgsqlIntervalintervalArray1M.AssertModel(models[3],_testData[15], false);NpgsqlIntervalintervalArray1M.AssertModel(models[4],_testData[16], false);NpgsqlIntervalintervalArray1M.AssertModel(models[5],_testData[17], false);NpgsqlIntervalintervalArray1M.AssertModel(models[6],_testData[18], false);NpgsqlIntervalintervalArray1M.AssertModel(models[7],_testData[19], false);NpgsqlIntervalintervalArray1M.AssertModel(models[8],_testData[20], false);NpgsqlIntervalintervalArray1M.AssertModel(models[9],_testData[21], false);NpgsqlIntervalintervalArray1M.AssertModel(models[10],_testData[22], false);NpgsqlIntervalintervalArray1M.AssertModel(models[11],_testData[23], false);NpgsqlIntervalintervalArray1M.AssertModel(models[12],_testData[24], false);NpgsqlIntervalintervalArray1M.AssertModel(models[13],_testData[25], false);NpgsqlIntervalintervalArray1M.AssertModel(models[14],_testData[26], false);NpgsqlIntervalintervalArray1M.AssertModel(models[15],_testData[27], false);NpgsqlIntervalintervalArray1M.AssertModel(models[16],_testData[28], false);NpgsqlIntervalintervalArray1M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
NpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[7], false);NpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[8], false);NpgsqlIntervalintervalArray1M.AssertModel(models[2],_testData[9], false);NpgsqlIntervalintervalArray1M.AssertModel(models[3],_testData[10], false);NpgsqlIntervalintervalArray1M.AssertModel(models[4],_testData[11], false);NpgsqlIntervalintervalArray1M.AssertModel(models[5],_testData[12], false);NpgsqlIntervalintervalArray1M.AssertModel(models[6],_testData[13], false);NpgsqlIntervalintervalArray1M.AssertModel(models[7],_testData[14], false);NpgsqlIntervalintervalArray1M.AssertModel(models[8],_testData[15], false);NpgsqlIntervalintervalArray1M.AssertModel(models[9],_testData[16], false);NpgsqlIntervalintervalArray1M.AssertModel(models[10],_testData[17], false);NpgsqlIntervalintervalArray1M.AssertModel(models[11],_testData[18], false);NpgsqlIntervalintervalArray1M.AssertModel(models[12],_testData[19], false);NpgsqlIntervalintervalArray1M.AssertModel(models[13],_testData[20], false);NpgsqlIntervalintervalArray1M.AssertModel(models[14],_testData[21], false);NpgsqlIntervalintervalArray1M.AssertModel(models[15],_testData[22], false);NpgsqlIntervalintervalArray1M.AssertModel(models[16],_testData[23], false);NpgsqlIntervalintervalArray1M.AssertModel(models[17],_testData[24], false);NpgsqlIntervalintervalArray1M.AssertModel(models[18],_testData[25], false);NpgsqlIntervalintervalArray1M.AssertModel(models[19],_testData[26], false);NpgsqlIntervalintervalArray1M.AssertModel(models[20],_testData[27], false);NpgsqlIntervalintervalArray1M.AssertModel(models[21],_testData[28], false);NpgsqlIntervalintervalArray1M.AssertModel(models[22],_testData[29], false);
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
                ((INpgsqlIntervalArrayintervalArray)this).SetDbConnectionSelectModelParametrs(cmd, 22);
                var models = await ((INpgsqlIntervalArrayintervalArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(25));
NpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[5], false);NpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[6], false);NpgsqlIntervalintervalArray1M.AssertModel(models[2],_testData[7], false);NpgsqlIntervalintervalArray1M.AssertModel(models[3],_testData[8], false);NpgsqlIntervalintervalArray1M.AssertModel(models[4],_testData[9], false);NpgsqlIntervalintervalArray1M.AssertModel(models[5],_testData[10], false);NpgsqlIntervalintervalArray1M.AssertModel(models[6],_testData[11], false);NpgsqlIntervalintervalArray1M.AssertModel(models[7],_testData[12], false);NpgsqlIntervalintervalArray1M.AssertModel(models[8],_testData[13], false);NpgsqlIntervalintervalArray1M.AssertModel(models[9],_testData[14], false);NpgsqlIntervalintervalArray1M.AssertModel(models[10],_testData[15], false);NpgsqlIntervalintervalArray1M.AssertModel(models[11],_testData[16], false);NpgsqlIntervalintervalArray1M.AssertModel(models[12],_testData[17], false);NpgsqlIntervalintervalArray1M.AssertModel(models[13],_testData[18], false);NpgsqlIntervalintervalArray1M.AssertModel(models[14],_testData[19], false);NpgsqlIntervalintervalArray1M.AssertModel(models[15],_testData[20], false);NpgsqlIntervalintervalArray1M.AssertModel(models[16],_testData[21], false);NpgsqlIntervalintervalArray1M.AssertModel(models[17],_testData[22], false);NpgsqlIntervalintervalArray1M.AssertModel(models[18],_testData[23], false);NpgsqlIntervalintervalArray1M.AssertModel(models[19],_testData[24], false);NpgsqlIntervalintervalArray1M.AssertModel(models[20],_testData[25], false);NpgsqlIntervalintervalArray1M.AssertModel(models[21],_testData[26], false);NpgsqlIntervalintervalArray1M.AssertModel(models[22],_testData[27], false);NpgsqlIntervalintervalArray1M.AssertModel(models[23],_testData[28], false);NpgsqlIntervalintervalArray1M.AssertModel(models[24],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlIntervalArrayintervalArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlIntervalArrayintervalArray)this).SetDbConnectionSelectModelParametrs(cmd, 109);
                var models =  ((INpgsqlIntervalArrayintervalArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(7));
NpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[23], false);NpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[24], false);NpgsqlIntervalintervalArray1M.AssertModel(models[2],_testData[25], false);NpgsqlIntervalintervalArray1M.AssertModel(models[3],_testData[26], false);NpgsqlIntervalintervalArray1M.AssertModel(models[4],_testData[27], false);NpgsqlIntervalintervalArray1M.AssertModel(models[5],_testData[28], false);NpgsqlIntervalintervalArray1M.AssertModel(models[6],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

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

