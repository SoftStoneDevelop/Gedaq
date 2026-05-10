

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
    Id = 2,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1506),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 899),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2877),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 10,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 42),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1058),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3537),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1749),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4282),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4337),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1945),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2222),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1624),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2883),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 212),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 744),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4933),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3957),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 12,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2444),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 932),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2762),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 13,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3629),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 732),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3778),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4716),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 12,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4831),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1988),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 992),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3638),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4381),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3971),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3536),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2226),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3119),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3581),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1472),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4359),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 19,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 692),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2375),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4045),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1625),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3487),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3864),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 80),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4515),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 28,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2234),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 495),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3175),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 767),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1477),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1137),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2529),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 393),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4109),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3923),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2628),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 35,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2743),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2910),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2356),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4327),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3258),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1280),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 36,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 76),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 230),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1379),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 24,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1737),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4915),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1844),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4668),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2750),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2854),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 39,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4664),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1749),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3350),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4349),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3930),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2894),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 885),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3971),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4938),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2113),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 27,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 827),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3829),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2630),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 49,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2542),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4052),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 355),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 50,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3390),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4053),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4373),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1529),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 36,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1770),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2143),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 763),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4477),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1625),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1191),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2405),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3561),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 468),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4734),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4751),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3539),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 440),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2488),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 61,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2327),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3317),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3545),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2269),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2213),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3049),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1176),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2835),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3683),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1608),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 62,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2023),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3682),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2893),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 841),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2465),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2648),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 71,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2371),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2700),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3491),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2191),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 897),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4605),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1557),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2791),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4021),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 72,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1991),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3814),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2727),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2340),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 630),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2019),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2884),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2284),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 80,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2095),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 909),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2047),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 49,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3653),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1955),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4743),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1580),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 86,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 402),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2333),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2451),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3332),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4970),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4190),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 93,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1001),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 973),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 721),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 53,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 898),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 292),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4223),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1615),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2885),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1614),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4746),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1864),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 100,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1919),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 529),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4406),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3871),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2455),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 227),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 103,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2336),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 652),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 436),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 57,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4736),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4584),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 69),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4365),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1725),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3365),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3358),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2996),
},
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 109,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2282),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1785),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4005),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 116,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3185),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1587),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4918),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 60,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 202),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1407),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1359),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4979),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1053),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2654),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2376),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3539),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 125,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4814),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3650),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3436),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 130,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4566),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2971),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2908),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2608),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 65,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4911),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 493),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1044),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 849),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3935),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2016),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 131,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 224),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3211),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1308),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 133,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3170),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 949),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 788),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 73,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3797),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3658),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3364),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 141,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3404),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2841),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2561),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 142,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4305),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1432),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2396),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4325),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 82,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 886),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 726),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1043),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4094),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2815),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2304),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1144),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2640),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4106),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1466),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1115),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 149,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 707),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1457),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4809),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 150,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1502),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3314),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1260),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 89,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 776),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1459),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4724),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1707),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3817),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1389),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1310),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 3586),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 149),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 157,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2782),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4465),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 493),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2342),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2051),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2313),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4380),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 187),
},
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 158,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 410),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4336),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4806),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1866),
},
    ModelInner = new NpgsqlIntervalintervalArray1MI
{
    Id = 92,
    Value = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1407),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1448),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2888),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlInterval[3]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 4917),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 2191),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 808),
},
},
    NullableValue = null,
},
            new NpgsqlIntervalintervalArray1M
{
    Id = 167,
    Value = 
new NpgsqlTypes.NpgsqlInterval[4]
{
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1208),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1054),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 554),
new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: 1578),
},
    ModelInner = null,
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalArray1M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 47;
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
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
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
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[17],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 36;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 149;
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
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
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
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[3],_testData[34], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalArray1M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 130;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 100;
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
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[8],_testData[34], false);
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 133;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 157;
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
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[1],_testData[34], false);
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
                parametr1.Value = 80;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 157;
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
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[34], false);
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
                parametr2.Value = 86;
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
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
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
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[15],_testData[34], false);
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
                parametr1.Value = 86;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 62;
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
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[10],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[11],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[12],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[13],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[14],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[14],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[15],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[16],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[17],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[18],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[19],_testData[34], false);
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
                parametr1.Value = 142;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 150;
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
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[2],_testData[34], false);
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
                parametr1.Value = 130;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 13;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlIntervalArrayintervalArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[26], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[27], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[2],_testData[28], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[3],_testData[29], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[4],_testData[30], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[5],_testData[31], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[6],_testData[32], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[7],_testData[33], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[8],_testData[34], false);
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
                parametr1.Value = 36;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 116;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlIntervalArrayintervalArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[8], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[9], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[2],_testData[10], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[3],_testData[11], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[4],_testData[12], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[5],_testData[13], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[6],_testData[14], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[7],_testData[15], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[8],_testData[16], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[9],_testData[17], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[10],_testData[18], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[11],_testData[19], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[12],_testData[20], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[13],_testData[21], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[14],_testData[22], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[15],_testData[23], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[16],_testData[24], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[17],_testData[25], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[18],_testData[26], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[19],_testData[27], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[20],_testData[28], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[21],_testData[29], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[22],_testData[30], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[23],_testData[31], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[24],_testData[32], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[25],_testData[33], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalArray1M.AssertModel(models1[i],_testData[i], false);
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
                await ((INpgsqlIntervalArrayintervalArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 47, query1, 62, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
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
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[19],_testData[34], false);
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
                await ((INpgsqlIntervalArrayintervalArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 109, query1, 10, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
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
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[32],_testData[34], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlIntervalintervalArray1M.AssertModel(models1[i],_testData[i], false);
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
                 ((INpgsqlIntervalArrayintervalArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 49, query1, 36, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[26],_testData[34], false);
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
                 ((INpgsqlIntervalArrayintervalArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 149, query1, 12, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[31],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlIntervalArrayintervalArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 130, query1, 72, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[3],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[4],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[5],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[6],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[7],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                await ((INpgsqlIntervalArrayintervalArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 54, query1, 28, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[28],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlIntervalArrayintervalArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 19, query1, 28, query2))
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
                 ((INpgsqlIntervalArrayintervalArray)this).DbConnectionDynQuerySelectModelBatch(connection, 125, query1, 50, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(firstItems1[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatNpgsqlIntervalintervalArray1M.AssertModel(secondItems2[22],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlIntervalArrayintervalArray)this).DbConnectionSTSelectModelBatchAsync(connection, 141, 142))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[29], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[30], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[2],_testData[31], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[3],_testData[32], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[4],_testData[33], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[30], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[31], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[2],_testData[32], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[3],_testData[33], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[4],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlIntervalArrayintervalArray)this).DbConnectionSTSelectModelBatch(connection, 103, 28))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[22], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[23], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[2],_testData[24], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[3],_testData[25], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[4],_testData[26], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[5],_testData[27], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[6],_testData[28], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[7],_testData[29], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[8],_testData[30], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[9],_testData[31], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[10],_testData[32], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[11],_testData[33], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[6], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[7], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[2],_testData[8], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[3],_testData[9], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[4],_testData[10], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[5],_testData[11], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[6],_testData[12], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[7],_testData[13], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[8],_testData[14], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[9],_testData[15], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[10],_testData[16], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[11],_testData[17], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[12],_testData[18], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[13],_testData[19], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[14],_testData[20], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[15],_testData[21], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[16],_testData[22], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[17],_testData[23], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[18],_testData[24], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[19],_testData[25], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[20],_testData[26], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[21],_testData[27], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[22],_testData[28], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[23],_testData[29], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[24],_testData[30], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[25],_testData[31], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[26],_testData[32], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[27],_testData[33], false);
                        NpgsqlIntervalintervalArray1M.AssertModel(models[28],_testData[34], false);
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
                ((INpgsqlIntervalArrayintervalArray)this).SetDbConnectionSelectModelParametrs(cmd, 133);
                var models = await ((INpgsqlIntervalArrayintervalArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(7));

                NpgsqlIntervalintervalArray1M.AssertModel(models[0],_testData[28], false);
                NpgsqlIntervalintervalArray1M.AssertModel(models[1],_testData[29], false);
                NpgsqlIntervalintervalArray1M.AssertModel(models[2],_testData[30], false);
                NpgsqlIntervalintervalArray1M.AssertModel(models[3],_testData[31], false);
                NpgsqlIntervalintervalArray1M.AssertModel(models[4],_testData[32], false);
                NpgsqlIntervalintervalArray1M.AssertModel(models[5],_testData[33], false);
                NpgsqlIntervalintervalArray1M.AssertModel(models[6],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlIntervalArrayintervalArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlIntervalArrayintervalArray)this).SetDbConnectionSelectModelParametrs(cmd, 62);
                var models =  ((INpgsqlIntervalArrayintervalArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(20));

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
                NpgsqlIntervalintervalArray1M.AssertModel(models[15],_testData[30], false);
                NpgsqlIntervalintervalArray1M.AssertModel(models[16],_testData[31], false);
                NpgsqlIntervalintervalArray1M.AssertModel(models[17],_testData[32], false);
                NpgsqlIntervalintervalArray1M.AssertModel(models[18],_testData[33], false);
                NpgsqlIntervalintervalArray1M.AssertModel(models[19],_testData[34], false);
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
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalArrayintervalArray)),
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
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalArray1MIWA), typeof(NpgsqlIntervalintervalArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalArrayintervalArray)),
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
                var models1 = new List<NpgsqlIntervalintervalArray1MIWA>();
                var models2 = new List<NpgsqlIntervalintervalArray1MIWA>();
                await ((INpgsqlIntervalArrayintervalArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlintervalintervalarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlIntervalintervalArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlIntervalintervalArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlIntervalintervalArray1MIWA>();
                var models2 = new List<NpgsqlIntervalintervalArray1MIWA>();
                ((INpgsqlIntervalArrayintervalArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlintervalintervalarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlIntervalintervalArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlIntervalintervalArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalArrayintervalArray)),
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
                var models = await ((INpgsqlIntervalArrayintervalArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlintervalintervalarray1mi
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
                    NpgsqlIntervalintervalArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlIntervalArrayintervalArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlintervalintervalarray1mi
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
                    NpgsqlIntervalintervalArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalArray1MIWA), typeof(NpgsqlIntervalintervalArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalArrayintervalArray))]
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
                var models1 = new List<NpgsqlIntervalintervalArray1MIWA>();
                var models2 = new List<NpgsqlIntervalintervalArray1MIWA>();
                await ((INpgsqlIntervalArrayintervalArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlintervalintervalarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlIntervalintervalArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlIntervalintervalArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlIntervalintervalArray1MIWA>();
                var models2 = new List<NpgsqlIntervalintervalArray1MIWA>();
                ((INpgsqlIntervalArrayintervalArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlintervalintervalarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlIntervalintervalArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlIntervalintervalArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalArray1MIWA)],
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
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((INpgsqlIntervalArrayintervalArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlintervalintervalarray1mi
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
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((INpgsqlIntervalArrayintervalArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlintervalintervalarray1mi
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
                    NpgsqlIntervalintervalArray1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlintervalintervalarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalArray1MI), typeof(NpgsqlIntervalintervalArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalArrayintervalArray)),
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
                var models1 = new List<NpgsqlIntervalintervalArray1MI>();
                var models2 = new List<NpgsqlIntervalintervalArray1MI>();
                await ((INpgsqlIntervalArrayintervalArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlIntervalintervalArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlIntervalintervalArray1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlIntervalintervalArray1MI>();
                var models2 = new List<NpgsqlIntervalintervalArray1MI>();
                ((INpgsqlIntervalArrayintervalArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlIntervalintervalArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlIntervalintervalArray1MI.AssertModel(model2, expectedModel, false);
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
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalArrayintervalArray)),
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
                var models = await ((INpgsqlIntervalArrayintervalArray)this).WAExportModelInnerAsync(connection).ToListAsync();
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
        public  void WAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((INpgsqlIntervalArrayintervalArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlIntervalintervalArray1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlintervalintervalarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalArray1MIWA), typeof(NpgsqlIntervalintervalArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlIntervalArrayintervalArray))]
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
                var models1 = new List<NpgsqlIntervalintervalArray1MIWA>();
                var models2 = new List<NpgsqlIntervalintervalArray1MIWA>();
                await ((INpgsqlIntervalArrayintervalArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlIntervalintervalArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlIntervalintervalArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlIntervalintervalArray1MIWA>();
                var models2 = new List<NpgsqlIntervalintervalArray1MIWA>();
                ((INpgsqlIntervalArrayintervalArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlIntervalintervalArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlIntervalintervalArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlintervalintervalarray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlIntervalintervalArray1MIWA)],
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
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((INpgsqlIntervalArrayintervalArray)this).ExportModelInnerAsync(connection).ToListAsync();
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
        public  void ExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((INpgsqlIntervalArrayintervalArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlIntervalintervalArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

