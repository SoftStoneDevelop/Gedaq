

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
    internal partial interface INpgsqlIntervalMArrayintervalMMArrayD1
    {
    }
    
    internal partial class NpgsqlIntervalMArrayintervalMMArrayD1 : INpgsqlIntervalMArrayintervalMMArrayD1
    {


#region TestData

        private readonly NpgsqlIntervalintervalMMArrayD1E1M[] _testData = new NpgsqlIntervalintervalMMArrayD1E1M[]
        {
            new NpgsqlIntervalintervalMMArrayD1E1M
{
    Id = 4,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1347),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1961),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2444),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3359),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3796),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3736),
},
},
            new NpgsqlIntervalintervalMMArrayD1E1M
{
    Id = 13,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4472),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3383),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 545),
},
    ModelInner = new NpgsqlIntervalintervalMMArrayD1E1MI
{
    Id = 5,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 855),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1345),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1805),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3496),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3972),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1642),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 478),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 781),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2089),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2831),
},
},
            new NpgsqlIntervalintervalMMArrayD1E1M
{
    Id = 15,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1447),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 856),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2230),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1449),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4530),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1124),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 75),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1105),
},
},
            new NpgsqlIntervalintervalMMArrayD1E1M
{
    Id = 17,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 5),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1388),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4060),
},
    ModelInner = new NpgsqlIntervalintervalMMArrayD1E1MI
{
    Id = 14,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 685),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 543),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3120),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 427),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4221),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 575),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4027),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2707),
},
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalMMArrayD1E1M
{
    Id = 22,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3464),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4758),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1370),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4254),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalMMArrayD1E1M
{
    Id = 26,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4197),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 727),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1223),
},
    ModelInner = new NpgsqlIntervalintervalMMArrayD1E1MI
{
    Id = 19,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4257),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4519),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3782),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2366),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2731),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1176),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1591),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3222),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4978),
},
},
            new NpgsqlIntervalintervalMMArrayD1E1M
{
    Id = 29,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1819),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 504),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 80),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2527),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 423),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2803),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4030),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 562),
},
},
            new NpgsqlIntervalintervalMMArrayD1E1M
{
    Id = 32,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3277),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 434),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2375),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 509),
},
    ModelInner = new NpgsqlIntervalintervalMMArrayD1E1MI
{
    Id = 24,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1475),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2039),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1703),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4153),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalMMArrayD1E1M
{
    Id = 39,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1783),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 671),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2557),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2608),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalMMArrayD1E1M
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3279),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3480),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2850),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2010),
},
    ModelInner = new NpgsqlIntervalintervalMMArrayD1E1MI
{
    Id = 25,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3420),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1603),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4288),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalMMArrayD1E1M
{
    Id = 46,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2241),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 139),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4814),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 107),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 506),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 80),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3550),
},
},
            new NpgsqlIntervalintervalMMArrayD1E1M
{
    Id = 55,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2271),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1465),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2026),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 421),
},
    ModelInner = new NpgsqlIntervalintervalMMArrayD1E1MI
{
    Id = 33,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2446),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 698),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4255),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3846),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 238),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4662),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1085),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3978),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3151),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3419),
},
},
            new NpgsqlIntervalintervalMMArrayD1E1M
{
    Id = 56,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3860),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 105),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3609),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4532),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3560),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4971),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1303),
},
},
            new NpgsqlIntervalintervalMMArrayD1E1M
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2306),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3674),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4614),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3919),
},
    ModelInner = new NpgsqlIntervalintervalMMArrayD1E1MI
{
    Id = 34,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2018),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4746),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3525),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1883),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1531),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1605),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1775),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2785),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3887),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4495),
},
},
            new NpgsqlIntervalintervalMMArrayD1E1M
{
    Id = 68,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1543),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4939),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3541),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2757),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalMMArrayD1E1M
{
    Id = 75,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1748),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3616),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1309),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 350),
},
    ModelInner = new NpgsqlIntervalintervalMMArrayD1E1MI
{
    Id = 38,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3671),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2059),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3965),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2613),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3507),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2933),
},
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalMMArrayD1E1M
{
    Id = 84,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2279),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3882),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4372),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1954),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 744),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4788),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2181),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1725),
},
},
            new NpgsqlIntervalintervalMMArrayD1E1M
{
    Id = 87,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 963),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4602),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3460),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4120),
},
    ModelInner = new NpgsqlIntervalintervalMMArrayD1E1MI
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1925),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1342),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 472),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1003),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 731),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 441),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1748),
},
},
            new NpgsqlIntervalintervalMMArrayD1E1M
{
    Id = 88,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3734),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1840),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4953),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4398),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1625),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1151),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2979),
},
},
            new NpgsqlIntervalintervalMMArrayD1E1M
{
    Id = 95,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3756),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4200),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1159),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2168),
},
    ModelInner = new NpgsqlIntervalintervalMMArrayD1E1MI
{
    Id = 44,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2419),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2803),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1832),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3349),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2341),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4947),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2888),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2879),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 679),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1725),
},
},
            new NpgsqlIntervalintervalMMArrayD1E1M
{
    Id = 99,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 85),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 936),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2284),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4386),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2130),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1011),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3388),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3712),
},
},
            new NpgsqlIntervalintervalMMArrayD1E1M
{
    Id = 102,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1257),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3963),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2087),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4220),
},
    ModelInner = new NpgsqlIntervalintervalMMArrayD1E1MI
{
    Id = 45,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1145),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4278),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1218),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4529),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalMMArrayD1E1M
{
    Id = 110,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 217),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 294),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3257),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4534),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2346),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1566),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 440),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1945),
},
},
            new NpgsqlIntervalintervalMMArrayD1E1M
{
    Id = 117,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1715),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3330),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 849),
},
    ModelInner = new NpgsqlIntervalintervalMMArrayD1E1MI
{
    Id = 53,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1006),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 467),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4919),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalMMArrayD1E1M
{
    Id = 118,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4797),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2269),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 268),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3314),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalMMArrayD1E1M
{
    Id = 125,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3339),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 464),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4816),
},
    ModelInner = new NpgsqlIntervalintervalMMArrayD1E1MI
{
    Id = 58,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1574),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 906),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 814),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4907),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1283),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3980),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4508),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1148),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2783),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2210),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3298),
},
},
            new NpgsqlIntervalintervalMMArrayD1E1M
{
    Id = 128,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4059),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1555),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1953),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1623),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 82),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 844),
},
},
            new NpgsqlIntervalintervalMMArrayD1E1M
{
    Id = 131,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1064),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2103),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3993),
},
    ModelInner = new NpgsqlIntervalintervalMMArrayD1E1MI
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1615),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 888),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1446),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2578),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4694),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4314),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3718),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2004),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3889),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2438),
},
},
            new NpgsqlIntervalintervalMMArrayD1E1M
{
    Id = 138,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2583),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4733),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2178),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1403),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2579),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1349),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1814),
},
},
            new NpgsqlIntervalintervalMMArrayD1E1M
{
    Id = 139,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1526),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1259),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4112),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3473),
},
    ModelInner = new NpgsqlIntervalintervalMMArrayD1E1MI
{
    Id = 70,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1057),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1219),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4503),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4955),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3605),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 123),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2907),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1668),
},
},
            new NpgsqlIntervalintervalMMArrayD1E1M
{
    Id = 145,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 54),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1082),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 695),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalMMArrayD1E1M
{
    Id = 154,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 787),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 109),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3669),
},
    ModelInner = new NpgsqlIntervalintervalMMArrayD1E1MI
{
    Id = 71,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 662),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1109),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 356),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1188),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1664),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2617),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2407),
},
},
            new NpgsqlIntervalintervalMMArrayD1E1M
{
    Id = 159,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3659),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4127),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 105),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalMMArrayD1E1M
{
    Id = 161,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4388),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3048),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1381),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1474),
},
    ModelInner = new NpgsqlIntervalintervalMMArrayD1E1MI
{
    Id = 77,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4499),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 241),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1209),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3320),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 733),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 562),
},
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalMMArrayD1E1M
{
    Id = 170,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1318),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3625),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2336),
},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlintervalintervalmmarrayd1e1mi(
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
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD1)),
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
INSERT INTO public.npgsqlintervalintervalmmarrayd1e1mi(
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
            queryMapTypes: [typeof(NpgsqlIntervalintervalMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD1)),
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

                changedRows =  ((INpgsqlIntervalMArrayintervalMMArrayD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlIntervalMArrayintervalMMArrayD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlIntervalMArrayintervalMMArrayD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlIntervalMArrayintervalMMArrayD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlIntervalMArrayintervalMMArrayD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlIntervalMArrayintervalMMArrayD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlIntervalMArrayintervalMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlIntervalMArrayintervalMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlIntervalMArrayintervalMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlIntervalMArrayintervalMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlIntervalMArrayintervalMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlIntervalMArrayintervalMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlIntervalMArrayintervalMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlIntervalMArrayintervalMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlIntervalMArrayintervalMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlIntervalMArrayintervalMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlIntervalMArrayintervalMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlintervalintervalmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqlintervalintervalmmarrayd1e1mi_id
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
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD1)), 
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
                methodParametrName: "npgsqlintervalintervalmmarrayd1e1mi_id", 
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
                changedRows =  ((INpgsqlIntervalMArrayintervalMMArrayD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlIntervalMArrayintervalMMArrayD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlIntervalMArrayintervalMMArrayD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlIntervalMArrayintervalMMArrayD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlintervalintervalmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqlintervalintervalmmarrayd1e1mi_id
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
    npgsqlintervalintervalmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD1)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlintervalintervalmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqlintervalintervalmmarrayd1e1mi_id
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
    npgsqlintervalintervalmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD1)),
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
                methodParametrName: "npgsqlintervalintervalmmarrayd1e1mi_id", 
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
                List<NpgsqlIntervalintervalMMArrayD1E1M> models = null;

                models =  ((INpgsqlIntervalMArrayintervalMMArrayD1)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlIntervalMArrayintervalMMArrayD1)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlIntervalMArrayintervalMMArrayD1)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlIntervalMArrayintervalMMArrayD1)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlIntervalintervalMMArrayD1E1M> models = null;

                models = await ((INpgsqlIntervalMArrayintervalMMArrayD1)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlIntervalMArrayintervalMMArrayD1)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlIntervalMArrayintervalMMArrayD1)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlIntervalMArrayintervalMMArrayD1)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlIntervalMArrayintervalMMArrayD1)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlIntervalMArrayintervalMMArrayD1)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlIntervalMArrayintervalMMArrayD1)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlIntervalMArrayintervalMMArrayD1)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlIntervalMArrayintervalMMArrayD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlIntervalMArrayintervalMMArrayD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlIntervalMArrayintervalMMArrayD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlIntervalMArrayintervalMMArrayD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlIntervalMArrayintervalMMArrayD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlIntervalMArrayintervalMMArrayD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlIntervalMArrayintervalMMArrayD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlIntervalMArrayintervalMMArrayD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlIntervalMArrayintervalMMArrayD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlIntervalMArrayintervalMMArrayD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlIntervalMArrayintervalMMArrayD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlIntervalMArrayintervalMMArrayD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlIntervalMArrayintervalMMArrayD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlIntervalMArrayintervalMMArrayD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlIntervalMArrayintervalMMArrayD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlIntervalMArrayintervalMMArrayD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlIntervalMArrayintervalMMArrayD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlIntervalMArrayintervalMMArrayD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlIntervalMArrayintervalMMArrayD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlIntervalintervalMMArrayD1E1M), typeof(FlatNpgsqlIntervalintervalMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD1)),
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
FROM public.npgsqlintervalintervalmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlIntervalintervalMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlIntervalintervalMMArrayD1E1M>();
                await ((INpgsqlIntervalMArrayintervalMMArrayD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlintervalintervalmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlIntervalintervalMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlIntervalintervalMMArrayD1E1M>();
                ((INpgsqlIntervalMArrayintervalMMArrayD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlIntervalintervalMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD1)),
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
FROM public.npgsqlintervalintervalmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlIntervalMArrayintervalMMArrayD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlintervalintervalmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlIntervalMArrayintervalMMArrayD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlintervalintervalmmarrayd1e1m m
LEFT JOIN public.npgsqlintervalintervalmmarrayd1e1mi mi ON mi.id = m.npgsqlintervalintervalmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD1)),
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
                var models = await ((INpgsqlIntervalMArrayintervalMMArrayD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlIntervalMArrayintervalMMArrayD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlIntervalintervalMMArrayD1E1M), typeof(FlatNpgsqlIntervalintervalMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD1)),
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
FROM public.npgsqlintervalintervalmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlIntervalintervalMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlIntervalintervalMMArrayD1E1M>();
                await ((INpgsqlIntervalMArrayintervalMMArrayD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlintervalintervalmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlIntervalintervalMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlIntervalintervalMMArrayD1E1M>();
                ((INpgsqlIntervalMArrayintervalMMArrayD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlIntervalintervalMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD1)),
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
FROM public.npgsqlintervalintervalmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlIntervalMArrayintervalMMArrayD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlintervalintervalmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlIntervalMArrayintervalMMArrayD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlintervalintervalmmarrayd1e1m m
LEFT JOIN public.npgsqlintervalintervalmmarrayd1e1mi mi ON mi.id = m.npgsqlintervalintervalmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD1)),
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
                var models = await ((INpgsqlIntervalMArrayintervalMMArrayD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlIntervalMArrayintervalMMArrayD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlIntervalintervalMMArrayD1E1M), typeof(FlatNpgsqlIntervalintervalMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD1)),
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
FROM public.npgsqlintervalintervalmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlIntervalintervalMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlIntervalintervalMMArrayD1E1M>();
                await((INpgsqlIntervalMArrayintervalMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 68;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 117;
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
FROM public.npgsqlintervalintervalmmarrayd1e1m m
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
FROM public.npgsqlintervalintervalmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlIntervalintervalMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlIntervalintervalMMArrayD1E1M>();
                await ((INpgsqlIntervalMArrayintervalMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[10],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 68;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 46;
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
FROM public.npgsqlintervalintervalmmarrayd1e1m m
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
FROM public.npgsqlintervalintervalmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlIntervalintervalMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalMMArrayD1E1M>();
                await ((INpgsqlIntervalMArrayintervalMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[23],_testData[34], false);
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
FROM public.npgsqlintervalintervalmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlIntervalintervalMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlIntervalintervalMMArrayD1E1M>();
                ((INpgsqlIntervalMArrayintervalMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 26;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 139;
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
FROM public.npgsqlintervalintervalmmarrayd1e1m m
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
FROM public.npgsqlintervalintervalmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlIntervalintervalMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlIntervalintervalMMArrayD1E1M>();
                 ((INpgsqlIntervalMArrayintervalMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[4],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 41;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 13;
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
FROM public.npgsqlintervalintervalmmarrayd1e1m m
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
FROM public.npgsqlintervalintervalmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlIntervalintervalMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalMMArrayD1E1M>();
                 ((INpgsqlIntervalMArrayintervalMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[32],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlIntervalintervalMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD1)),
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
FROM public.npgsqlintervalintervalmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlIntervalMArrayintervalMMArrayD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 68;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 75;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlintervalintervalmmarrayd1e1m m
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
FROM public.npgsqlintervalintervalmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlIntervalMArrayintervalMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[14],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[15],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[16],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[17],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[18],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[13],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[14],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[15],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[16],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[17],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[18],_testData[34], false);
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
                parametr1.Value = 154;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 128;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlintervalintervalmmarrayd1e1m m
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
FROM public.npgsqlintervalintervalmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlIntervalintervalMMArrayD1E1M>();
                await ((INpgsqlIntervalMArrayintervalMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[7],_testData[34], false);
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
FROM public.npgsqlintervalintervalmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlIntervalMArrayintervalMMArrayD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 55;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 17;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlintervalintervalmmarrayd1e1m m
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
FROM public.npgsqlintervalintervalmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlIntervalMArrayintervalMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[17],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[18],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[19],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[20],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[21],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[25],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[26],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[27],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[28],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[29],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[30],_testData[34], false);
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
                parametr1.Value = 41;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 22;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlintervalintervalmmarrayd1e1m m
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
FROM public.npgsqlintervalintervalmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlIntervalintervalMMArrayD1E1M>();
                 ((INpgsqlIntervalMArrayintervalMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM public.npgsqlintervalintervalmmarrayd1e1m m
LEFT JOIN public.npgsqlintervalintervalmmarrayd1e1mi mi ON mi.id = m.npgsqlintervalintervalmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD1)),
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
                var models = await((INpgsqlIntervalMArrayintervalMMArrayD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 15;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 4;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlIntervalMArrayintervalMMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[0],_testData[3], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[1],_testData[4], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[2],_testData[5], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[3],_testData[6], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[4],_testData[7], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[5],_testData[8], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[6],_testData[9], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[7],_testData[10], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[8],_testData[11], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[9],_testData[12], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[10],_testData[13], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[11],_testData[14], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[12],_testData[15], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[13],_testData[16], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[14],_testData[17], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[15],_testData[18], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[16],_testData[19], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[17],_testData[20], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[18],_testData[21], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[19],_testData[22], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[20],_testData[23], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[21],_testData[24], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[22],_testData[25], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[23],_testData[26], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[24],_testData[27], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[25],_testData[28], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[26],_testData[29], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[27],_testData[30], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[28],_testData[31], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[29],_testData[32], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[30],_testData[33], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[0],_testData[1], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[1],_testData[2], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[2],_testData[3], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[3],_testData[4], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[4],_testData[5], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[5],_testData[6], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[6],_testData[7], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[7],_testData[8], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[8],_testData[9], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[9],_testData[10], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[10],_testData[11], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[11],_testData[12], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[12],_testData[13], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[13],_testData[14], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[14],_testData[15], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[15],_testData[16], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[16],_testData[17], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[17],_testData[18], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[18],_testData[19], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[19],_testData[20], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[20],_testData[21], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[21],_testData[22], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[22],_testData[23], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[23],_testData[24], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[24],_testData[25], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[25],_testData[26], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[26],_testData[27], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[27],_testData[28], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[28],_testData[29], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[29],_testData[30], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[30],_testData[31], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[31],_testData[32], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[32],_testData[33], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[33],_testData[34], false);
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
                var models = ((INpgsqlIntervalMArrayintervalMMArrayD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 131;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 88;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlIntervalMArrayintervalMMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[0],_testData[28], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[1],_testData[29], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[2],_testData[30], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[3],_testData[31], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[4],_testData[32], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[5],_testData[33], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[0],_testData[19], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[1],_testData[20], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[2],_testData[21], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[3],_testData[22], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[4],_testData[23], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[5],_testData[24], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[6],_testData[25], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[7],_testData[26], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[8],_testData[27], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[9],_testData[28], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[10],_testData[29], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[11],_testData[30], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[12],_testData[31], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[13],_testData[32], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[14],_testData[33], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlIntervalintervalMMArrayD1E1M), typeof(FlatNpgsqlIntervalintervalMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD1)),
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
FROM public.npgsqlintervalintervalmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlIntervalintervalMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlIntervalintervalMMArrayD1E1M>();
                await((INpgsqlIntervalMArrayintervalMMArrayD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlintervalintervalmmarrayd1e1m m
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
FROM public.npgsqlintervalintervalmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlIntervalintervalMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlIntervalintervalMMArrayD1E1M>();
                await ((INpgsqlIntervalMArrayintervalMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 84, query1, 55, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[22],_testData[34], false);
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
FROM public.npgsqlintervalintervalmmarrayd1e1m m
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
FROM public.npgsqlintervalintervalmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlIntervalintervalMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalMMArrayD1E1M>();
                await ((INpgsqlIntervalMArrayintervalMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 110, query1, 15, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[31],_testData[34], false);
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
FROM public.npgsqlintervalintervalmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlIntervalintervalMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlIntervalintervalMMArrayD1E1M>();
                ((INpgsqlIntervalMArrayintervalMMArrayD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlintervalintervalmmarrayd1e1m m
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
FROM public.npgsqlintervalintervalmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlIntervalintervalMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlIntervalintervalMMArrayD1E1M>();
                 ((INpgsqlIntervalMArrayintervalMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 39, query1, 55, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[22],_testData[34], false);
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
FROM public.npgsqlintervalintervalmmarrayd1e1m m
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
FROM public.npgsqlintervalintervalmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlIntervalintervalMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalMMArrayD1E1M>();
                 ((INpgsqlIntervalMArrayintervalMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 46, query1, 145, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[3],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlIntervalintervalMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD1)),
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
FROM public.npgsqlintervalintervalmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlIntervalMArrayintervalMMArrayD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlintervalintervalmmarrayd1e1m m
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
FROM public.npgsqlintervalintervalmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlIntervalMArrayintervalMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 118, query1, 46, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[4],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[5],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[6],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[7],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[8],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[0],_testData[11], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[1],_testData[12], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[2],_testData[13], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[3],_testData[14], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[4],_testData[15], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[5],_testData[16], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[6],_testData[17], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[7],_testData[18], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[8],_testData[19], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[9],_testData[20], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[10],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[11],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[12],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[13],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[14],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[15],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[16],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[17],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[18],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[19],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[20],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[21],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[22],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[23],_testData[34], false);
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
FROM public.npgsqlintervalintervalmmarrayd1e1m m
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
FROM public.npgsqlintervalintervalmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlIntervalintervalMMArrayD1E1M>();
                await ((INpgsqlIntervalMArrayintervalMMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 117, query1, 41, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[24],_testData[34], false);
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
FROM public.npgsqlintervalintervalmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlIntervalMArrayintervalMMArrayD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlintervalintervalmmarrayd1e1m m
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
FROM public.npgsqlintervalintervalmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlIntervalMArrayintervalMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 39, query1, 75, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[0],_testData[9], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[1],_testData[10], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[2],_testData[11], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[3],_testData[12], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[4],_testData[13], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[5],_testData[14], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[6],_testData[15], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[7],_testData[16], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[8],_testData[17], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[9],_testData[18], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[10],_testData[19], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[11],_testData[20], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[12],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[13],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[14],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[15],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[16],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[17],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[18],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[19],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[20],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[21],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[22],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[23],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[24],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[13],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[14],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[15],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[16],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[17],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[18],_testData[34], false);
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
FROM public.npgsqlintervalintervalmmarrayd1e1m m
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
FROM public.npgsqlintervalintervalmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlIntervalintervalMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlIntervalintervalMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlIntervalintervalMMArrayD1E1M>();
                 ((INpgsqlIntervalMArrayintervalMMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 29, query1, 117, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatNpgsqlIntervalintervalMMArrayD1E1M.AssertModel(secondItems2[10],_testData[34], false);
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
FROM public.npgsqlintervalintervalmmarrayd1e1m m
LEFT JOIN public.npgsqlintervalintervalmmarrayd1e1mi mi ON mi.id = m.npgsqlintervalintervalmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD1)),
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
                var models = await((INpgsqlIntervalMArrayintervalMMArrayD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlIntervalMArrayintervalMMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 17, 159))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[0],_testData[4], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[1],_testData[5], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[2],_testData[6], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[3],_testData[7], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[4],_testData[8], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[5],_testData[9], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[6],_testData[10], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[7],_testData[11], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[8],_testData[12], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[9],_testData[13], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[10],_testData[14], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[11],_testData[15], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[12],_testData[16], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[13],_testData[17], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[14],_testData[18], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[15],_testData[19], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[16],_testData[20], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[17],_testData[21], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[18],_testData[22], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[19],_testData[23], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[20],_testData[24], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[21],_testData[25], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[22],_testData[26], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[23],_testData[27], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[24],_testData[28], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[25],_testData[29], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[26],_testData[30], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[27],_testData[31], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[28],_testData[32], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[29],_testData[33], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[0],_testData[33], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[1],_testData[34], false);
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
                var models = ((INpgsqlIntervalMArrayintervalMMArrayD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlIntervalMArrayintervalMMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 84, 4))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[0],_testData[17], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[1],_testData[18], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[2],_testData[19], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[3],_testData[20], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[4],_testData[21], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[5],_testData[22], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[6],_testData[23], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[7],_testData[24], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[8],_testData[25], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[9],_testData[26], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[10],_testData[27], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[11],_testData[28], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[12],_testData[29], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[13],_testData[30], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[14],_testData[31], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[15],_testData[32], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[16],_testData[33], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[0],_testData[1], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[1],_testData[2], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[2],_testData[3], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[3],_testData[4], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[4],_testData[5], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[5],_testData[6], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[6],_testData[7], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[7],_testData[8], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[8],_testData[9], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[9],_testData[10], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[10],_testData[11], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[11],_testData[12], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[12],_testData[13], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[13],_testData[14], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[14],_testData[15], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[15],_testData[16], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[16],_testData[17], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[17],_testData[18], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[18],_testData[19], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[19],_testData[20], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[20],_testData[21], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[21],_testData[22], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[22],_testData[23], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[23],_testData[24], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[24],_testData[25], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[25],_testData[26], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[26],_testData[27], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[27],_testData[28], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[28],_testData[29], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[29],_testData[30], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[30],_testData[31], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[31],_testData[32], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[32],_testData[33], false);
                        NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[33],_testData[34], false);
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
                await using var cmd = await ((INpgsqlIntervalMArrayintervalMMArrayD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlIntervalMArrayintervalMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 29);
                var models = await ((INpgsqlIntervalMArrayintervalMMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(28));

                NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[0],_testData[7], false);
                NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[1],_testData[8], false);
                NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[2],_testData[9], false);
                NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[3],_testData[10], false);
                NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[4],_testData[11], false);
                NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[5],_testData[12], false);
                NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[6],_testData[13], false);
                NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[7],_testData[14], false);
                NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[8],_testData[15], false);
                NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[9],_testData[16], false);
                NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[10],_testData[17], false);
                NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[11],_testData[18], false);
                NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[12],_testData[19], false);
                NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[13],_testData[20], false);
                NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[14],_testData[21], false);
                NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[15],_testData[22], false);
                NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[16],_testData[23], false);
                NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[17],_testData[24], false);
                NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[18],_testData[25], false);
                NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[19],_testData[26], false);
                NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[20],_testData[27], false);
                NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[21],_testData[28], false);
                NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[22],_testData[29], false);
                NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[23],_testData[30], false);
                NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[24],_testData[31], false);
                NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[25],_testData[32], false);
                NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[26],_testData[33], false);
                NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[27],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlIntervalMArrayintervalMMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlIntervalMArrayintervalMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 159);
                var models =  ((INpgsqlIntervalMArrayintervalMMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(2));

                NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[0],_testData[33], false);
                NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(models[1],_testData[34], false);
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
FROM public.binary_npgsqlintervalintervalmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlIntervalintervalMMArrayD1E1MIWA),
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
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlIntervalintervalMMArrayD1E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlIntervalintervalMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlIntervalMArrayintervalMMArrayD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlintervalintervalmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlIntervalMArrayintervalMMArrayD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlIntervalintervalMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlIntervalintervalMMArrayD1E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlIntervalintervalMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlIntervalMArrayintervalMMArrayD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlintervalintervalmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlIntervalMArrayintervalMMArrayD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlIntervalintervalMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlintervalintervalmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlIntervalintervalMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlIntervalintervalMMArrayD1E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlIntervalintervalMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlIntervalMArrayintervalMMArrayD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlintervalintervalmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlIntervalMArrayintervalMMArrayD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlIntervalintervalMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlIntervalintervalMMArrayD1E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlIntervalintervalMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlIntervalMArrayintervalMMArrayD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlintervalintervalmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlIntervalMArrayintervalMMArrayD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlIntervalintervalMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlintervalintervalmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlintervalintervalmmarrayd1e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlIntervalintervalMMArrayD1E1MI),
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
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlIntervalintervalMMArrayD1E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlIntervalMArrayintervalMMArrayD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlIntervalMArrayintervalMMArrayD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlIntervalintervalMMArrayD1E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlIntervalintervalMMArrayD1E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlIntervalMArrayintervalMMArrayD1)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlIntervalMArrayintervalMMArrayD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlIntervalintervalMMArrayD1E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlintervalintervalmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlintervalintervalmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlIntervalintervalMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlIntervalintervalMMArrayD1E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlIntervalintervalMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlIntervalMArrayintervalMMArrayD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlIntervalMArrayintervalMMArrayD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlIntervalintervalMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlIntervalintervalMMArrayD1E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlIntervalintervalMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlIntervalMArrayintervalMMArrayD1)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlIntervalMArrayintervalMMArrayD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlIntervalintervalMMArrayD1E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlintervalintervalmmarrayd1e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlintervalintervalmmarrayd1e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlIntervalintervalMMArrayD1E1M),
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
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD1))]
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
FROM public.binary_npgsqlintervalintervalmmarrayd1e1m m
LEFT JOIN public.binary_npgsqlintervalintervalmmarrayd1e1mi mi ON mi.id = m.npgsqlintervalintervalmmarrayd1e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlIntervalintervalMMArrayD1E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlIntervalMArrayintervalMMArrayD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlIntervalMArrayintervalMMArrayD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlIntervalintervalMMArrayD1E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlIntervalMArrayintervalMMArrayD1)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlIntervalMArrayintervalMMArrayD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlintervalintervalmmarrayd1e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlintervalintervalmmarrayd1e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD1)),
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
                var models =  ((INpgsqlIntervalMArrayintervalMMArrayD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlIntervalMArrayintervalMMArrayD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlIntervalintervalMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMMArrayD1E1MIWA), typeof(NpgsqlIntervalintervalMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD1)),
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
                var models1 = new List<NpgsqlIntervalintervalMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlIntervalintervalMMArrayD1E1MIWA>();
                await ((INpgsqlIntervalMArrayintervalMMArrayD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlintervalintervalmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlIntervalintervalMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlIntervalintervalMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlIntervalintervalMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlIntervalintervalMMArrayD1E1MIWA>();
                ((INpgsqlIntervalMArrayintervalMMArrayD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlintervalintervalmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlIntervalintervalMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlIntervalintervalMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD1)),
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
                var models = await ((INpgsqlIntervalMArrayintervalMMArrayD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlintervalintervalmmarrayd1e1mi
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
                    NpgsqlIntervalintervalMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlIntervalMArrayintervalMMArrayD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlintervalintervalmmarrayd1e1mi
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
                    NpgsqlIntervalintervalMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMMArrayD1E1MIWA), typeof(NpgsqlIntervalintervalMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD1))]
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
                var models1 = new List<NpgsqlIntervalintervalMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlIntervalintervalMMArrayD1E1MIWA>();
                await ((INpgsqlIntervalMArrayintervalMMArrayD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlintervalintervalmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlIntervalintervalMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlIntervalintervalMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlIntervalintervalMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlIntervalintervalMMArrayD1E1MIWA>();
                ((INpgsqlIntervalMArrayintervalMMArrayD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlintervalintervalmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlIntervalintervalMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlIntervalintervalMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD1))]
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
                var models = await ((INpgsqlIntervalMArrayintervalMMArrayD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlintervalintervalmmarrayd1e1mi
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
                    NpgsqlIntervalintervalMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlIntervalMArrayintervalMMArrayD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlintervalintervalmmarrayd1e1mi
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
                    NpgsqlIntervalintervalMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlintervalintervalmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMMArrayD1E1MI), typeof(NpgsqlIntervalintervalMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD1)),
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
                var models1 = new List<NpgsqlIntervalintervalMMArrayD1E1MI>();
                var models2 = new List<NpgsqlIntervalintervalMMArrayD1E1MI>();
                await ((INpgsqlIntervalMArrayintervalMMArrayD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlIntervalintervalMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlIntervalintervalMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlIntervalintervalMMArrayD1E1MI>();
                var models2 = new List<NpgsqlIntervalintervalMMArrayD1E1MI>();
                ((INpgsqlIntervalMArrayintervalMMArrayD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlIntervalintervalMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlIntervalintervalMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlintervalintervalmmarrayd1e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD1)),
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
                var models = await ((INpgsqlIntervalMArrayintervalMMArrayD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlIntervalintervalMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlIntervalMArrayintervalMMArrayD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlIntervalintervalMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlintervalintervalmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMMArrayD1E1MIWA), typeof(NpgsqlIntervalintervalMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD1))]
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
                var models1 = new List<NpgsqlIntervalintervalMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlIntervalintervalMMArrayD1E1MIWA>();
                await ((INpgsqlIntervalMArrayintervalMMArrayD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlIntervalintervalMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlIntervalintervalMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlIntervalintervalMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlIntervalintervalMMArrayD1E1MIWA>();
                ((INpgsqlIntervalMArrayintervalMMArrayD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlIntervalintervalMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlIntervalintervalMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlintervalintervalmmarrayd1e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalMArrayintervalMMArrayD1))]
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
                var models = await ((INpgsqlIntervalMArrayintervalMMArrayD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlIntervalintervalMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlIntervalMArrayintervalMMArrayD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlIntervalintervalMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

