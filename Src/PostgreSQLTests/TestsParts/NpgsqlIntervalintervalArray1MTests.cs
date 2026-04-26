

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
    Id = 3,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4884),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 855),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1921),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 146),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3331),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 28),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4410),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 4,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3032),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1021),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3899),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3235),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3890),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 498),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 745),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1418),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 110),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3125),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2829),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 794),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3192),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2226),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 8,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 797),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2008),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2603),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3625),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 860),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 452),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 11,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2905),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1282),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2918),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 13,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2547),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1827),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2908),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 645),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1390),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3555),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1637),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2223),
},
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 20,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1750),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3218),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2902),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4796),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2210),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2591),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 28,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2289),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1458),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1589),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4798),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3533),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1179),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3194),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 947),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 35,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2644),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2817),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2369),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4771),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4700),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3960),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4190),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1450),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 44,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 945),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4574),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2100),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 24,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2411),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3120),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1375),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3751),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4967),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2488),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4868),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2148),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1184),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2942),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 46,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4432),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2884),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3921),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3914),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 55,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2626),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2404),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1093),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 29,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1502),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3365),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4003),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1396),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3540),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3767),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 329),
},
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 58,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3179),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 357),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2052),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1906),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 789),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3925),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2881),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1628),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1849),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1299),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3418),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 38,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 151),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1160),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 336),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1273),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4657),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1666),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2175),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 69,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3012),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 193),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3571),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3295),
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
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2448),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4226),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2823),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1311),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 43,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2527),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4912),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3828),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3567),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 302),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2090),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3585),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2737),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3727),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2433),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 77,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 525),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2792),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4995),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4279),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 78,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 580),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2240),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 808),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 51,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1195),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4998),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3845),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 84,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2556),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3796),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2710),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4345),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 89,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3751),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2279),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4407),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 56,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 528),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4857),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4903),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 882),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3457),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4089),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1224),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 690),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2611),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 51),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3843),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3237),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 97,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3670),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 611),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3182),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 104,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2760),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1190),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3213),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4480),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 63,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2412),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4814),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4449),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3818),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 107),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3810),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3148),
},
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 105,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4289),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3358),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2274),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1768),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 113,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2168),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1591),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4703),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1470),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 72,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1050),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3408),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3770),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4648),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4315),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1642),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4266),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4869),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1119),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3628),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1960),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 119,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3766),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1972),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3630),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3396),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 939),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4776),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 178),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 124,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4453),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 302),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3648),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 77,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2288),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3970),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4472),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3410),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 131,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1821),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2070),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3525),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 296),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 136,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 310),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4360),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 853),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1154),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 78,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 470),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4725),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1439),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1045),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 775),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 293),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2571),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2389),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 8),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1114),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 137,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4046),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3852),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 470),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 142,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4852),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3871),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2832),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 86,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4374),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3159),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1880),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4930),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 591),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1688),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 149,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4885),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3233),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2290),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3132),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 154,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3550),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 192),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2533),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3906),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 94,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2713),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1713),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1991),
},
    NullableValue = null,
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
                parametr1.Value = 113;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 84;
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
                        Assert.That(models, Has.Count.EqualTo(8));
FlatNpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[22], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[23], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[2],_testData[24], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[3],_testData[25], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[4],_testData[26], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[5],_testData[27], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[6],_testData[28], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));
FlatNpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[17], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[18], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[2],_testData[19], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[3],_testData[20], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[4],_testData[21], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[5],_testData[22], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[6],_testData[23], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[7],_testData[24], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[8],_testData[25], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[9],_testData[26], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[10],_testData[27], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[11],_testData[28], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[12],_testData[29], false);
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
                parametr1.Value = 69;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 58;
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
                        Assert.That(models, Has.Count.EqualTo(17));
FlatNpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[13], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[14], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[2],_testData[15], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[3],_testData[16], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[4],_testData[17], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[5],_testData[18], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[6],_testData[19], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[7],_testData[20], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[8],_testData[21], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[9],_testData[22], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[10],_testData[23], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[11],_testData[24], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[12],_testData[25], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[13],_testData[26], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[14],_testData[27], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[15],_testData[28], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));
FlatNpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[11], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[12], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[2],_testData[13], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[3],_testData[14], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[4],_testData[15], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[5],_testData[16], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[6],_testData[17], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[7],_testData[18], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[8],_testData[19], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[9],_testData[20], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[10],_testData[21], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[11],_testData[22], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[12],_testData[23], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[13],_testData[24], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[14],_testData[25], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[15],_testData[26], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[16],_testData[27], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[17],_testData[28], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[18],_testData[29], false);
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
                parametr1.Value = 119;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 3;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlIntervalArrayintervalArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));
NpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[23], false);NpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[24], false);NpgsqlIntervalintervalArray1M.AssertModel(models[2],_testData[25], false);NpgsqlIntervalintervalArray1M.AssertModel(models[3],_testData[26], false);NpgsqlIntervalintervalArray1M.AssertModel(models[4],_testData[27], false);NpgsqlIntervalintervalArray1M.AssertModel(models[5],_testData[28], false);NpgsqlIntervalintervalArray1M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));
NpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[1], false);NpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[2], false);NpgsqlIntervalintervalArray1M.AssertModel(models[2],_testData[3], false);NpgsqlIntervalintervalArray1M.AssertModel(models[3],_testData[4], false);NpgsqlIntervalintervalArray1M.AssertModel(models[4],_testData[5], false);NpgsqlIntervalintervalArray1M.AssertModel(models[5],_testData[6], false);NpgsqlIntervalintervalArray1M.AssertModel(models[6],_testData[7], false);NpgsqlIntervalintervalArray1M.AssertModel(models[7],_testData[8], false);NpgsqlIntervalintervalArray1M.AssertModel(models[8],_testData[9], false);NpgsqlIntervalintervalArray1M.AssertModel(models[9],_testData[10], false);NpgsqlIntervalintervalArray1M.AssertModel(models[10],_testData[11], false);NpgsqlIntervalintervalArray1M.AssertModel(models[11],_testData[12], false);NpgsqlIntervalintervalArray1M.AssertModel(models[12],_testData[13], false);NpgsqlIntervalintervalArray1M.AssertModel(models[13],_testData[14], false);NpgsqlIntervalintervalArray1M.AssertModel(models[14],_testData[15], false);NpgsqlIntervalintervalArray1M.AssertModel(models[15],_testData[16], false);NpgsqlIntervalintervalArray1M.AssertModel(models[16],_testData[17], false);NpgsqlIntervalintervalArray1M.AssertModel(models[17],_testData[18], false);NpgsqlIntervalintervalArray1M.AssertModel(models[18],_testData[19], false);NpgsqlIntervalintervalArray1M.AssertModel(models[19],_testData[20], false);NpgsqlIntervalintervalArray1M.AssertModel(models[20],_testData[21], false);NpgsqlIntervalintervalArray1M.AssertModel(models[21],_testData[22], false);NpgsqlIntervalintervalArray1M.AssertModel(models[22],_testData[23], false);NpgsqlIntervalintervalArray1M.AssertModel(models[23],_testData[24], false);NpgsqlIntervalintervalArray1M.AssertModel(models[24],_testData[25], false);NpgsqlIntervalintervalArray1M.AssertModel(models[25],_testData[26], false);NpgsqlIntervalintervalArray1M.AssertModel(models[26],_testData[27], false);NpgsqlIntervalintervalArray1M.AssertModel(models[27],_testData[28], false);NpgsqlIntervalintervalArray1M.AssertModel(models[28],_testData[29], false);
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
                parametr1.Value = 105;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 84;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlIntervalArrayintervalArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));
NpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[21], false);NpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[22], false);NpgsqlIntervalintervalArray1M.AssertModel(models[2],_testData[23], false);NpgsqlIntervalintervalArray1M.AssertModel(models[3],_testData[24], false);NpgsqlIntervalintervalArray1M.AssertModel(models[4],_testData[25], false);NpgsqlIntervalintervalArray1M.AssertModel(models[5],_testData[26], false);NpgsqlIntervalintervalArray1M.AssertModel(models[6],_testData[27], false);NpgsqlIntervalintervalArray1M.AssertModel(models[7],_testData[28], false);NpgsqlIntervalintervalArray1M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));
NpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[17], false);NpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[18], false);NpgsqlIntervalintervalArray1M.AssertModel(models[2],_testData[19], false);NpgsqlIntervalintervalArray1M.AssertModel(models[3],_testData[20], false);NpgsqlIntervalintervalArray1M.AssertModel(models[4],_testData[21], false);NpgsqlIntervalintervalArray1M.AssertModel(models[5],_testData[22], false);NpgsqlIntervalintervalArray1M.AssertModel(models[6],_testData[23], false);NpgsqlIntervalintervalArray1M.AssertModel(models[7],_testData[24], false);NpgsqlIntervalintervalArray1M.AssertModel(models[8],_testData[25], false);NpgsqlIntervalintervalArray1M.AssertModel(models[9],_testData[26], false);NpgsqlIntervalintervalArray1M.AssertModel(models[10],_testData[27], false);NpgsqlIntervalintervalArray1M.AssertModel(models[11],_testData[28], false);NpgsqlIntervalintervalArray1M.AssertModel(models[12],_testData[29], false);
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
                foreach(var batchResult in await ((INpgsqlIntervalArrayintervalArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 77, query1, 20, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
FlatNpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[15], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[16], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[2],_testData[17], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[3],_testData[18], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[4],_testData[19], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[5],_testData[20], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[6],_testData[21], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[7],_testData[22], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[8],_testData[23], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[9],_testData[24], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[10],_testData[25], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[11],_testData[26], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[12],_testData[27], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[13],_testData[28], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));
FlatNpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[5], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[6], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[2],_testData[7], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[3],_testData[8], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[4],_testData[9], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[5],_testData[10], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[6],_testData[11], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[7],_testData[12], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[8],_testData[13], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[9],_testData[14], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[10],_testData[15], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[11],_testData[16], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[12],_testData[17], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[13],_testData[18], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[14],_testData[19], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[15],_testData[20], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[16],_testData[21], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[17],_testData[22], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[18],_testData[23], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[19],_testData[24], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[20],_testData[25], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[21],_testData[26], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[22],_testData[27], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[23],_testData[28], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[24],_testData[29], false);
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
                foreach(var batchResult in  ((INpgsqlIntervalArrayintervalArray)this).DbConnectionDynQuerySelectModelBatch(connection, 113, query1, 76, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));
FlatNpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[22], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[23], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[2],_testData[24], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[3],_testData[25], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[4],_testData[26], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[5],_testData[27], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[6],_testData[28], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
FlatNpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[14], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[15], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[2],_testData[16], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[3],_testData[17], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[4],_testData[18], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[5],_testData[19], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[6],_testData[20], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[7],_testData[21], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[8],_testData[22], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[9],_testData[23], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[10],_testData[24], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[11],_testData[25], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[12],_testData[26], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[13],_testData[27], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[14],_testData[28], false);FlatNpgsqlIntervalintervalArray1M.AssertModel(models[15],_testData[29], false);
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
                foreach(var batchResult in await ((INpgsqlIntervalArrayintervalArray)this).DbConnectionSelectModelBatchAsync(connection, 55, 35))
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
                        Assert.That(models, Has.Count.EqualTo(23));
NpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[7], false);NpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[8], false);NpgsqlIntervalintervalArray1M.AssertModel(models[2],_testData[9], false);NpgsqlIntervalintervalArray1M.AssertModel(models[3],_testData[10], false);NpgsqlIntervalintervalArray1M.AssertModel(models[4],_testData[11], false);NpgsqlIntervalintervalArray1M.AssertModel(models[5],_testData[12], false);NpgsqlIntervalintervalArray1M.AssertModel(models[6],_testData[13], false);NpgsqlIntervalintervalArray1M.AssertModel(models[7],_testData[14], false);NpgsqlIntervalintervalArray1M.AssertModel(models[8],_testData[15], false);NpgsqlIntervalintervalArray1M.AssertModel(models[9],_testData[16], false);NpgsqlIntervalintervalArray1M.AssertModel(models[10],_testData[17], false);NpgsqlIntervalintervalArray1M.AssertModel(models[11],_testData[18], false);NpgsqlIntervalintervalArray1M.AssertModel(models[12],_testData[19], false);NpgsqlIntervalintervalArray1M.AssertModel(models[13],_testData[20], false);NpgsqlIntervalintervalArray1M.AssertModel(models[14],_testData[21], false);NpgsqlIntervalintervalArray1M.AssertModel(models[15],_testData[22], false);NpgsqlIntervalintervalArray1M.AssertModel(models[16],_testData[23], false);NpgsqlIntervalintervalArray1M.AssertModel(models[17],_testData[24], false);NpgsqlIntervalintervalArray1M.AssertModel(models[18],_testData[25], false);NpgsqlIntervalintervalArray1M.AssertModel(models[19],_testData[26], false);NpgsqlIntervalintervalArray1M.AssertModel(models[20],_testData[27], false);NpgsqlIntervalintervalArray1M.AssertModel(models[21],_testData[28], false);NpgsqlIntervalintervalArray1M.AssertModel(models[22],_testData[29], false);
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
                foreach(var batchResult in  ((INpgsqlIntervalArrayintervalArray)this).DbConnectionSelectModelBatch(connection, 44, 142))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));
NpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[8], false);NpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[9], false);NpgsqlIntervalintervalArray1M.AssertModel(models[2],_testData[10], false);NpgsqlIntervalintervalArray1M.AssertModel(models[3],_testData[11], false);NpgsqlIntervalintervalArray1M.AssertModel(models[4],_testData[12], false);NpgsqlIntervalintervalArray1M.AssertModel(models[5],_testData[13], false);NpgsqlIntervalintervalArray1M.AssertModel(models[6],_testData[14], false);NpgsqlIntervalintervalArray1M.AssertModel(models[7],_testData[15], false);NpgsqlIntervalintervalArray1M.AssertModel(models[8],_testData[16], false);NpgsqlIntervalintervalArray1M.AssertModel(models[9],_testData[17], false);NpgsqlIntervalintervalArray1M.AssertModel(models[10],_testData[18], false);NpgsqlIntervalintervalArray1M.AssertModel(models[11],_testData[19], false);NpgsqlIntervalintervalArray1M.AssertModel(models[12],_testData[20], false);NpgsqlIntervalintervalArray1M.AssertModel(models[13],_testData[21], false);NpgsqlIntervalintervalArray1M.AssertModel(models[14],_testData[22], false);NpgsqlIntervalintervalArray1M.AssertModel(models[15],_testData[23], false);NpgsqlIntervalintervalArray1M.AssertModel(models[16],_testData[24], false);NpgsqlIntervalintervalArray1M.AssertModel(models[17],_testData[25], false);NpgsqlIntervalintervalArray1M.AssertModel(models[18],_testData[26], false);NpgsqlIntervalintervalArray1M.AssertModel(models[19],_testData[27], false);NpgsqlIntervalintervalArray1M.AssertModel(models[20],_testData[28], false);NpgsqlIntervalintervalArray1M.AssertModel(models[21],_testData[29], false);
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

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((INpgsqlIntervalArrayintervalArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlIntervalArrayintervalArray)this).SetDbConnectionSelectModelParametrs(cmd, 124);
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
                ((INpgsqlIntervalArrayintervalArray)this).SetDbConnectionSelectModelParametrs(cmd, 105);
                var models =  ((INpgsqlIntervalArrayintervalArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(9));
NpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[21], false);NpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[22], false);NpgsqlIntervalintervalArray1M.AssertModel(models[2],_testData[23], false);NpgsqlIntervalintervalArray1M.AssertModel(models[3],_testData[24], false);NpgsqlIntervalintervalArray1M.AssertModel(models[4],_testData[25], false);NpgsqlIntervalintervalArray1M.AssertModel(models[5],_testData[26], false);NpgsqlIntervalintervalArray1M.AssertModel(models[6],_testData[27], false);NpgsqlIntervalintervalArray1M.AssertModel(models[7],_testData[28], false);NpgsqlIntervalintervalArray1M.AssertModel(models[8],_testData[29], false);
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

