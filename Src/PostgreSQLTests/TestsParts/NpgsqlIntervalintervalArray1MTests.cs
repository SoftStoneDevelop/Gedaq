

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
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4830),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4823),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 946),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 680),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1513),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1159),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 631),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3229),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 12,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2499),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 425),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1135),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3249),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 1,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3347),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3289),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1360),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4466),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 20,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3585),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3367),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4398),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4322),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4038),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2964),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 28,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2186),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3863),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1768),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1753),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 5,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 674),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4086),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 500),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3138),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4669),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4242),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2567),
},
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 34,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2164),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2061),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3278),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 685),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4377),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1213),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 7,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2440),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4970),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2072),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4378),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3384),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 795),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1055),
},
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 43,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 387),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2976),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4510),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2724),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2140),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4305),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2207),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 46,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 153),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4700),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2315),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2053),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 12,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 270),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3170),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2036),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1789),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3255),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 679),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4150),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 51,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 814),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3845),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2279),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1453),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2715),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1399),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1441),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 55,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4266),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1631),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 697),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3609),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 17,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3294),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3307),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3866),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 58,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 111),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 657),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 793),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1419),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 65,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1411),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2616),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4177),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 22,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4972),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 602),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2981),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3455),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1857),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3942),
},
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 66,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3119),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1572),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3820),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4040),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4946),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1254),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 68,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4801),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1966),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4621),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 24,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2975),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 284),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4288),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2931),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2827),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4504),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2668),
},
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 73,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 300),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4579),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 967),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 625),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3397),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 880),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1372),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 82,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4467),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2780),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4642),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 496),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 31,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 812),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 229),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2625),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3420),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 84,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2923),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2816),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4192),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 862),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2827),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1418),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3726),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 90,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 492),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4463),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 600),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1142),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 947),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2999),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2442),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2844),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 112),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 914),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3412),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1495),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2546),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1948),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 91,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4826),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 940),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3764),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3168),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3138),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3482),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 705),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 94,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1324),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 352),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4955),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1292),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1516),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 662),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2357),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2847),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 944),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1352),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 95,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2245),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4604),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2090),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3739),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 98,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3006),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1678),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 288),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1553),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 49,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2166),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2825),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 503),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3222),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3615),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1698),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4710),
},
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 100,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 571),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2311),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4214),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1165),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3568),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2467),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 104,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1291),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 174),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2833),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2450),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 55,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4203),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1946),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2796),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 111,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2480),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 359),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2900),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2687),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 756),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 952),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2144),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 119,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 655),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4727),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1985),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 62,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2637),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 293),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1132),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4674),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3731),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4027),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3893),
},
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 125,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 347),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1921),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2615),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2958),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 132,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4169),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4664),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1499),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 69,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4749),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4308),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4421),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3679),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4794),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 863),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4440),
},
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 134,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2507),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2748),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2002),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 139,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 391),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 756),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4635),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 71,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2759),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2761),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2170),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1891),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1996),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1702),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2767),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1564),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4273),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4580),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1717),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 425),
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
                parametr1.Value = 55;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 91;
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
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[10],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 55;
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
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[4],_testData[29], false);
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
                parametr1.Value = 73;
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
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 98;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 68;
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
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
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
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[15],_testData[29], false);
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
                parametr1.Value = 111;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 43;
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
                parametr1.Value = 98;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 55;
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
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[19],_testData[29], false);
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
                parametr1.Value = 100;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 95;
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
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[8],_testData[29], false);
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
                parametr1.Value = 58;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 125;
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
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[2],_testData[29], false);
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
                parametr1.Value = 94;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 73;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlIntervalArrayintervalArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[20], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[21], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[2],_testData[22], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[3],_testData[23], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[4],_testData[24], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[5],_testData[25], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[6],_testData[26], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[7],_testData[27], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[8],_testData[28], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[15], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[16], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[2],_testData[17], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[3],_testData[18], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[4],_testData[19], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[5],_testData[20], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[6],_testData[21], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[7],_testData[22], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[8],_testData[23], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[9],_testData[24], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[10],_testData[25], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[11],_testData[26], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[12],_testData[27], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[13],_testData[28], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[14],_testData[29], false);
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
                parametr1.Value = 43;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 43;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlIntervalArrayintervalArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

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
                await ((INpgsqlIntervalArrayintervalArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 98, query1, 125, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
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
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[2],_testData[29], false);
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
                await ((INpgsqlIntervalArrayintervalArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 90, query1, 34, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[11],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[24],_testData[29], false);
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
                 ((INpgsqlIntervalArrayintervalArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 46, query1, 82, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[21],_testData[29], false);
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
                 ((INpgsqlIntervalArrayintervalArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 84, query1, 84, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[12],_testData[29], false);
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
                foreach(var batchResult in await ((INpgsqlIntervalArrayintervalArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 90, query1, 111, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                await ((INpgsqlIntervalArrayintervalArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 55, query1, 28, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[25],_testData[29], false);
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
                foreach(var batchResult in  ((INpgsqlIntervalArrayintervalArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 104, query1, 55, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[10], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[2],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[3],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[4],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[5],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[6],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[7],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[8],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[9],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[10],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[11],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[12],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[13],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[14],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[15],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[16],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[17],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[18],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[19],_testData[29], false);
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
                 ((INpgsqlIntervalArrayintervalArray)this).DbConnectionDynQuerySelectModelBatch(connection, 51, query1, 66, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[20],_testData[29], false);
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
                foreach(var batchResult in await ((INpgsqlIntervalArrayintervalArray)this).DbConnectionSTSelectModelBatchAsync(connection, 3, 65))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[1], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[2], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[2],_testData[3], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[3],_testData[4], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[4],_testData[5], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[5],_testData[6], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[6],_testData[7], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[7],_testData[8], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[8],_testData[9], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[9],_testData[10], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[10],_testData[11], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[11],_testData[12], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[12],_testData[13], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[13],_testData[14], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[14],_testData[15], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[15],_testData[16], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[16],_testData[17], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[17],_testData[18], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[18],_testData[19], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[19],_testData[20], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[20],_testData[21], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[21],_testData[22], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[22],_testData[23], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[23],_testData[24], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[24],_testData[25], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[25],_testData[26], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[26],_testData[27], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[27],_testData[28], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                foreach(var batchResult in  ((INpgsqlIntervalArrayintervalArray)this).DbConnectionSTSelectModelBatch(connection, 119, 132))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[26], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[27], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[2],_testData[28], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[3],_testData[29], false);
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
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((INpgsqlIntervalArrayintervalArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlIntervalArrayintervalArray)this).SetDbConnectionSelectModelParametrs(cmd, 90);
                var models = await ((INpgsqlIntervalArrayintervalArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(12));
NpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[18], false);NpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[19], false);NpgsqlIntervalintervalArray1M.AssertModel(models[2],_testData[20], false);NpgsqlIntervalintervalArray1M.AssertModel(models[3],_testData[21], false);NpgsqlIntervalintervalArray1M.AssertModel(models[4],_testData[22], false);NpgsqlIntervalintervalArray1M.AssertModel(models[5],_testData[23], false);NpgsqlIntervalintervalArray1M.AssertModel(models[6],_testData[24], false);NpgsqlIntervalintervalArray1M.AssertModel(models[7],_testData[25], false);NpgsqlIntervalintervalArray1M.AssertModel(models[8],_testData[26], false);NpgsqlIntervalintervalArray1M.AssertModel(models[9],_testData[27], false);NpgsqlIntervalintervalArray1M.AssertModel(models[10],_testData[28], false);NpgsqlIntervalintervalArray1M.AssertModel(models[11],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlIntervalArrayintervalArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlIntervalArrayintervalArray)this).SetDbConnectionSelectModelParametrs(cmd, 132);
                var models =  ((INpgsqlIntervalArrayintervalArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(2));
NpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[28], false);NpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[29], false);
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
        public async Task DynQueryImportModelInnerAsyncTest()
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
        public  void DynQueryImportModelInnerTest()
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

        [Test, Order(2)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlIntervalintervalArray1MI>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlIntervalArrayintervalArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlIntervalArrayintervalArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
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

        [Test, Order(3)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlIntervalintervalArray1MI>(2);
                for (int i = 12; i < 30; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlIntervalArrayintervalArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlIntervalArrayintervalArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(15));
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

        [Test, Order(5)]
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

        [Test, Order(6)]
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

        [Test, Order(6)]
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

        [Test, Order(6)]
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

        [Test, Order(6)]
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

