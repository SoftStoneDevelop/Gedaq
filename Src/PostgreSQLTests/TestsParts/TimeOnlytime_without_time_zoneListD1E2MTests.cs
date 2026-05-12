

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
    internal partial interface ITimeOnlyListtime_without_time_zoneListD1
    {
    }
    
    internal partial class TimeOnlyListtime_without_time_zoneListD1 : ITimeOnlyListtime_without_time_zoneListD1
    {


#region TestData

        private readonly TimeOnlytime_without_time_zoneListD1E2M[] _testData = new TimeOnlytime_without_time_zoneListD1E2M[]
        {
            new TimeOnlytime_without_time_zoneListD1E2M
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 16, minute: 14, second: 53, millisecond: 13),

new TimeOnly(hour: 9, minute: 41, second: 22, millisecond: 750),

new TimeOnly(hour: 22, minute: 48, second: 0, millisecond: 147),

new TimeOnly(hour: 13, minute: 48, second: 2, millisecond: 805),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 14, minute: 41, second: 30, millisecond: 911),

new TimeOnly(hour: 19, minute: 20, second: 13, millisecond: 985),

new TimeOnly(hour: 11, minute: 1, second: 58, millisecond: 344),

new TimeOnly(hour: 16, minute: 15, second: 39, millisecond: 716),

},
},
            new TimeOnlytime_without_time_zoneListD1E2M
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 9, minute: 28, second: 23, millisecond: 700),

new TimeOnly(hour: 5, minute: 35, second: 0, millisecond: 926),

new TimeOnly(hour: 12, minute: 28, second: 57, millisecond: 43),

new TimeOnly(hour: 4, minute: 19, second: 34, millisecond: 288),

},
    ModelInner = new TimeOnlytime_without_time_zoneListD1E2MI
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 14, minute: 43, second: 27, millisecond: 160),

new TimeOnly(hour: 2, minute: 2, second: 26, millisecond: 874),

new TimeOnly(hour: 0, minute: 49, second: 46, millisecond: 714),

new TimeOnly(hour: 22, minute: 12, second: 40, millisecond: 185),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 1, minute: 45, second: 26, millisecond: 18),

new TimeOnly(hour: 13, minute: 14, second: 10, millisecond: 408),

new TimeOnly(hour: 0, minute: 52, second: 44, millisecond: 26),

new TimeOnly(hour: 13, minute: 30, second: 28, millisecond: 757),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 7, minute: 42, second: 54, millisecond: 368),

new TimeOnly(hour: 6, minute: 32, second: 24, millisecond: 683),

new TimeOnly(hour: 6, minute: 10, second: 10, millisecond: 186),

new TimeOnly(hour: 19, minute: 45, second: 33, millisecond: 553),

},
},
            new TimeOnlytime_without_time_zoneListD1E2M
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 4, minute: 29, second: 41, millisecond: 946),

new TimeOnly(hour: 5, minute: 34, second: 23, millisecond: 56),

new TimeOnly(hour: 3, minute: 48, second: 0, millisecond: 117),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 2, minute: 5, second: 36, millisecond: 189),

new TimeOnly(hour: 18, minute: 50, second: 56, millisecond: 195),

new TimeOnly(hour: 7, minute: 51, second: 56, millisecond: 831),

},
},
            new TimeOnlytime_without_time_zoneListD1E2M
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 0, minute: 7, second: 47, millisecond: 923),

new TimeOnly(hour: 6, minute: 43, second: 19, millisecond: 232),

new TimeOnly(hour: 13, minute: 29, second: 21, millisecond: 634),

},
    ModelInner = new TimeOnlytime_without_time_zoneListD1E2MI
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 22, minute: 6, second: 48, millisecond: 991),

new TimeOnly(hour: 17, minute: 32, second: 51, millisecond: 365),

new TimeOnly(hour: 12, minute: 6, second: 37, millisecond: 992),

new TimeOnly(hour: 14, minute: 55, second: 24, millisecond: 319),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 20, minute: 18, second: 2, millisecond: 836),

new TimeOnly(hour: 18, minute: 4, second: 47, millisecond: 476),

new TimeOnly(hour: 12, minute: 39, second: 35, millisecond: 525),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 2, minute: 0, second: 40, millisecond: 539),

new TimeOnly(hour: 21, minute: 9, second: 37, millisecond: 477),

new TimeOnly(hour: 4, minute: 9, second: 20, millisecond: 308),

new TimeOnly(hour: 20, minute: 20, second: 12, millisecond: 269),

},
},
            new TimeOnlytime_without_time_zoneListD1E2M
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 17, minute: 37, second: 28, millisecond: 164),

new TimeOnly(hour: 1, minute: 34, second: 0, millisecond: 829),

new TimeOnly(hour: 0, minute: 54, second: 1, millisecond: 602),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 7, minute: 49, second: 52, millisecond: 766),

new TimeOnly(hour: 10, minute: 30, second: 58, millisecond: 187),

new TimeOnly(hour: 21, minute: 39, second: 25, millisecond: 354),

},
},
            new TimeOnlytime_without_time_zoneListD1E2M
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 0, minute: 53, second: 13, millisecond: 464),

new TimeOnly(hour: 7, minute: 30, second: 53, millisecond: 331),

new TimeOnly(hour: 15, minute: 27, second: 14, millisecond: 71),

new TimeOnly(hour: 5, minute: 22, second: 20, millisecond: 140),

},
    ModelInner = new TimeOnlytime_without_time_zoneListD1E2MI
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 10, minute: 51, second: 48, millisecond: 22),

new TimeOnly(hour: 12, minute: 44, second: 16, millisecond: 913),

new TimeOnly(hour: 9, minute: 42, second: 34, millisecond: 0),

new TimeOnly(hour: 21, minute: 17, second: 16, millisecond: 778),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 11, minute: 7, second: 7, millisecond: 295),

new TimeOnly(hour: 15, minute: 57, second: 57, millisecond: 667),

new TimeOnly(hour: 2, minute: 5, second: 30, millisecond: 556),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 19, minute: 31, second: 6, millisecond: 821),

new TimeOnly(hour: 9, minute: 5, second: 15, millisecond: 660),

new TimeOnly(hour: 22, minute: 57, second: 54, millisecond: 989),

new TimeOnly(hour: 6, minute: 24, second: 44, millisecond: 244),

},
},
            new TimeOnlytime_without_time_zoneListD1E2M
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 21, minute: 53, second: 15, millisecond: 24),

new TimeOnly(hour: 2, minute: 17, second: 11, millisecond: 809),

new TimeOnly(hour: 18, minute: 15, second: 29, millisecond: 431),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 14, minute: 54, second: 11, millisecond: 916),

new TimeOnly(hour: 2, minute: 41, second: 13, millisecond: 45),

new TimeOnly(hour: 0, minute: 58, second: 5, millisecond: 716),

},
},
            new TimeOnlytime_without_time_zoneListD1E2M
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 15, minute: 56, second: 46, millisecond: 442),

new TimeOnly(hour: 11, minute: 48, second: 33, millisecond: 729),

new TimeOnly(hour: 1, minute: 47, second: 12, millisecond: 466),

},
    ModelInner = new TimeOnlytime_without_time_zoneListD1E2MI
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 16, minute: 2, second: 20, millisecond: 577),

new TimeOnly(hour: 11, minute: 19, second: 44, millisecond: 251),

new TimeOnly(hour: 16, minute: 58, second: 5, millisecond: 760),

new TimeOnly(hour: 20, minute: 32, second: 14, millisecond: 698),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneListD1E2M
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 16, minute: 32, second: 44, millisecond: 5),

new TimeOnly(hour: 22, minute: 15, second: 51, millisecond: 162),

new TimeOnly(hour: 3, minute: 27, second: 19, millisecond: 914),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 13, minute: 48, second: 8, millisecond: 27),

new TimeOnly(hour: 17, minute: 50, second: 26, millisecond: 550),

new TimeOnly(hour: 10, minute: 2, second: 42, millisecond: 298),

},
},
            new TimeOnlytime_without_time_zoneListD1E2M
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 20, minute: 7, second: 10, millisecond: 327),

new TimeOnly(hour: 2, minute: 31, second: 47, millisecond: 300),

new TimeOnly(hour: 16, minute: 55, second: 1, millisecond: 352),

},
    ModelInner = new TimeOnlytime_without_time_zoneListD1E2MI
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 17, minute: 1, second: 23, millisecond: 534),

new TimeOnly(hour: 2, minute: 48, second: 6, millisecond: 660),

new TimeOnly(hour: 3, minute: 55, second: 33, millisecond: 468),

new TimeOnly(hour: 9, minute: 26, second: 11, millisecond: 359),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 10, minute: 51, second: 10, millisecond: 974),

new TimeOnly(hour: 5, minute: 37, second: 1, millisecond: 330),

new TimeOnly(hour: 16, minute: 16, second: 25, millisecond: 218),

new TimeOnly(hour: 22, minute: 37, second: 3, millisecond: 970),

},
},
            new TimeOnlytime_without_time_zoneListD1E2M
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 6, minute: 36, second: 32, millisecond: 302),

new TimeOnly(hour: 0, minute: 49, second: 20, millisecond: 221),

new TimeOnly(hour: 14, minute: 22, second: 57, millisecond: 125),

new TimeOnly(hour: 5, minute: 33, second: 12, millisecond: 951),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 19, minute: 40, second: 43, millisecond: 65),

new TimeOnly(hour: 20, minute: 7, second: 1, millisecond: 983),

new TimeOnly(hour: 2, minute: 37, second: 45, millisecond: 418),

new TimeOnly(hour: 12, minute: 36, second: 3, millisecond: 650),

},
},
            new TimeOnlytime_without_time_zoneListD1E2M
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 18, minute: 31, second: 24, millisecond: 620),

new TimeOnly(hour: 19, minute: 2, second: 48, millisecond: 514),

new TimeOnly(hour: 0, minute: 25, second: 45, millisecond: 529),

},
    ModelInner = new TimeOnlytime_without_time_zoneListD1E2MI
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 0, minute: 25, second: 42, millisecond: 88),

new TimeOnly(hour: 3, minute: 55, second: 42, millisecond: 329),

new TimeOnly(hour: 8, minute: 43, second: 32, millisecond: 346),

new TimeOnly(hour: 22, minute: 21, second: 15, millisecond: 183),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneListD1E2M
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 9, minute: 12, second: 48, millisecond: 309),

new TimeOnly(hour: 16, minute: 17, second: 49, millisecond: 571),

new TimeOnly(hour: 5, minute: 11, second: 4, millisecond: 926),

new TimeOnly(hour: 18, minute: 32, second: 49, millisecond: 687),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneListD1E2M
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 0, minute: 22, second: 36, millisecond: 943),

new TimeOnly(hour: 20, minute: 8, second: 57, millisecond: 516),

new TimeOnly(hour: 15, minute: 34, second: 50, millisecond: 367),

},
    ModelInner = new TimeOnlytime_without_time_zoneListD1E2MI
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 19, minute: 35, second: 22, millisecond: 471),

new TimeOnly(hour: 8, minute: 27, second: 30, millisecond: 860),

new TimeOnly(hour: 4, minute: 52, second: 43, millisecond: 975),

new TimeOnly(hour: 20, minute: 25, second: 21, millisecond: 427),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneListD1E2M
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 10, minute: 29, second: 26, millisecond: 233),

new TimeOnly(hour: 16, minute: 34, second: 10, millisecond: 299),

new TimeOnly(hour: 10, minute: 43, second: 43, millisecond: 843),

new TimeOnly(hour: 4, minute: 38, second: 48, millisecond: 67),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 22, minute: 18, second: 46, millisecond: 745),

new TimeOnly(hour: 6, minute: 22, second: 14, millisecond: 192),

new TimeOnly(hour: 19, minute: 20, second: 30, millisecond: 546),

new TimeOnly(hour: 2, minute: 55, second: 3, millisecond: 719),

},
},
            new TimeOnlytime_without_time_zoneListD1E2M
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 13, minute: 48, second: 51, millisecond: 385),

new TimeOnly(hour: 21, minute: 9, second: 18, millisecond: 3),

new TimeOnly(hour: 19, minute: 33, second: 39, millisecond: 781),

new TimeOnly(hour: 19, minute: 25, second: 29, millisecond: 460),

},
    ModelInner = new TimeOnlytime_without_time_zoneListD1E2MI
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 6, minute: 18, second: 49, millisecond: 644),

new TimeOnly(hour: 7, minute: 23, second: 11, millisecond: 962),

new TimeOnly(hour: 17, minute: 24, second: 31, millisecond: 440),

new TimeOnly(hour: 16, minute: 42, second: 30, millisecond: 469),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 4, minute: 36, second: 15, millisecond: 841),

new TimeOnly(hour: 15, minute: 46, second: 46, millisecond: 765),

new TimeOnly(hour: 2, minute: 51, second: 20, millisecond: 780),

new TimeOnly(hour: 10, minute: 31, second: 48, millisecond: 243),

},
},
            new TimeOnlytime_without_time_zoneListD1E2M
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 5, minute: 0, second: 16, millisecond: 763),

new TimeOnly(hour: 2, minute: 12, second: 21, millisecond: 670),

new TimeOnly(hour: 11, minute: 0, second: 58, millisecond: 228),

new TimeOnly(hour: 10, minute: 42, second: 36, millisecond: 352),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 14, minute: 5, second: 33, millisecond: 533),

new TimeOnly(hour: 2, minute: 46, second: 11, millisecond: 646),

new TimeOnly(hour: 21, minute: 40, second: 46, millisecond: 10),

new TimeOnly(hour: 2, minute: 19, second: 45, millisecond: 678),

},
},
            new TimeOnlytime_without_time_zoneListD1E2M
{
    Id = 103,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 11, minute: 52, second: 28, millisecond: 943),

new TimeOnly(hour: 4, minute: 48, second: 53, millisecond: 909),

new TimeOnly(hour: 1, minute: 21, second: 13, millisecond: 383),

},
    ModelInner = new TimeOnlytime_without_time_zoneListD1E2MI
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 7, minute: 10, second: 19, millisecond: 201),

new TimeOnly(hour: 22, minute: 0, second: 10, millisecond: 814),

new TimeOnly(hour: 0, minute: 41, second: 30, millisecond: 944),

new TimeOnly(hour: 5, minute: 26, second: 9, millisecond: 172),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneListD1E2M
{
    Id = 112,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 10, minute: 45, second: 29, millisecond: 521),

new TimeOnly(hour: 11, minute: 40, second: 56, millisecond: 963),

new TimeOnly(hour: 17, minute: 9, second: 55, millisecond: 662),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 0, minute: 34, second: 40, millisecond: 916),

new TimeOnly(hour: 22, minute: 5, second: 26, millisecond: 84),

new TimeOnly(hour: 14, minute: 57, second: 42, millisecond: 568),

},
},
            new TimeOnlytime_without_time_zoneListD1E2M
{
    Id = 121,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 2, minute: 41, second: 50, millisecond: 51),

new TimeOnly(hour: 18, minute: 13, second: 2, millisecond: 259),

new TimeOnly(hour: 13, minute: 5, second: 30, millisecond: 827),

},
    ModelInner = new TimeOnlytime_without_time_zoneListD1E2MI
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 14, minute: 50, second: 55, millisecond: 423),

new TimeOnly(hour: 8, minute: 8, second: 2, millisecond: 796),

new TimeOnly(hour: 22, minute: 15, second: 9, millisecond: 559),

new TimeOnly(hour: 9, minute: 5, second: 50, millisecond: 761),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 19, minute: 54, second: 22, millisecond: 491),

new TimeOnly(hour: 11, minute: 37, second: 7, millisecond: 340),

new TimeOnly(hour: 8, minute: 21, second: 52, millisecond: 98),

},
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneListD1E2M
{
    Id = 125,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 3, minute: 50, second: 16, millisecond: 789),

new TimeOnly(hour: 21, minute: 27, second: 13, millisecond: 225),

new TimeOnly(hour: 17, minute: 38, second: 41, millisecond: 177),

new TimeOnly(hour: 16, minute: 2, second: 20, millisecond: 723),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneListD1E2M
{
    Id = 129,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 20, minute: 36, second: 15, millisecond: 229),

new TimeOnly(hour: 9, minute: 55, second: 36, millisecond: 814),

new TimeOnly(hour: 10, minute: 19, second: 20, millisecond: 44),

},
    ModelInner = new TimeOnlytime_without_time_zoneListD1E2MI
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 13, minute: 54, second: 6, millisecond: 188),

new TimeOnly(hour: 13, minute: 52, second: 8, millisecond: 323),

new TimeOnly(hour: 14, minute: 42, second: 10, millisecond: 727),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 14, minute: 31, second: 14, millisecond: 648),

new TimeOnly(hour: 22, minute: 50, second: 52, millisecond: 727),

new TimeOnly(hour: 13, minute: 11, second: 39, millisecond: 59),

},
},
            new TimeOnlytime_without_time_zoneListD1E2M
{
    Id = 131,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 8, minute: 55, second: 6, millisecond: 674),

new TimeOnly(hour: 13, minute: 53, second: 33, millisecond: 691),

new TimeOnly(hour: 10, minute: 18, second: 34, millisecond: 368),

new TimeOnly(hour: 18, minute: 23, second: 12, millisecond: 325),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 14, minute: 42, second: 16, millisecond: 880),

new TimeOnly(hour: 0, minute: 7, second: 56, millisecond: 283),

new TimeOnly(hour: 13, minute: 2, second: 8, millisecond: 792),

},
},
            new TimeOnlytime_without_time_zoneListD1E2M
{
    Id = 139,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 16, minute: 18, second: 20, millisecond: 409),

new TimeOnly(hour: 22, minute: 55, second: 58, millisecond: 299),

new TimeOnly(hour: 0, minute: 15, second: 30, millisecond: 884),

new TimeOnly(hour: 11, minute: 29, second: 4, millisecond: 815),

},
    ModelInner = new TimeOnlytime_without_time_zoneListD1E2MI
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 12, minute: 40, second: 10, millisecond: 824),

new TimeOnly(hour: 22, minute: 36, second: 46, millisecond: 959),

new TimeOnly(hour: 17, minute: 33, second: 10, millisecond: 704),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneListD1E2M
{
    Id = 146,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 13, minute: 12, second: 39, millisecond: 372),

new TimeOnly(hour: 9, minute: 0, second: 22, millisecond: 437),

new TimeOnly(hour: 11, minute: 4, second: 11, millisecond: 385),

new TimeOnly(hour: 14, minute: 51, second: 28, millisecond: 562),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneListD1E2M
{
    Id = 152,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 11, minute: 21, second: 28, millisecond: 323),

new TimeOnly(hour: 21, minute: 53, second: 56, millisecond: 526),

new TimeOnly(hour: 2, minute: 45, second: 34, millisecond: 534),

},
    ModelInner = new TimeOnlytime_without_time_zoneListD1E2MI
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 10, minute: 44, second: 2, millisecond: 713),

new TimeOnly(hour: 10, minute: 52, second: 45, millisecond: 736),

new TimeOnly(hour: 2, minute: 44, second: 46, millisecond: 365),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneListD1E2M
{
    Id = 159,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 22, minute: 19, second: 55, millisecond: 934),

new TimeOnly(hour: 9, minute: 15, second: 47, millisecond: 207),

new TimeOnly(hour: 22, minute: 46, second: 9, millisecond: 279),

new TimeOnly(hour: 18, minute: 53, second: 24, millisecond: 311),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneListD1E2M
{
    Id = 166,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 8, minute: 57, second: 47, millisecond: 342),

new TimeOnly(hour: 13, minute: 28, second: 40, millisecond: 240),

new TimeOnly(hour: 15, minute: 17, second: 12, millisecond: 997),

},
    ModelInner = new TimeOnlytime_without_time_zoneListD1E2MI
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 19, minute: 4, second: 46, millisecond: 98),

new TimeOnly(hour: 8, minute: 54, second: 6, millisecond: 147),

new TimeOnly(hour: 16, minute: 4, second: 49, millisecond: 89),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 10, minute: 56, second: 3, millisecond: 928),

new TimeOnly(hour: 14, minute: 49, second: 12, millisecond: 659),

new TimeOnly(hour: 12, minute: 27, second: 24, millisecond: 369),

new TimeOnly(hour: 17, minute: 24, second: 31, millisecond: 525),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 5, minute: 4, second: 31, millisecond: 513),

new TimeOnly(hour: 13, minute: 0, second: 25, millisecond: 693),

new TimeOnly(hour: 11, minute: 5, second: 56, millisecond: 377),

new TimeOnly(hour: 19, minute: 1, second: 28, millisecond: 415),

},
},
            new TimeOnlytime_without_time_zoneListD1E2M
{
    Id = 169,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 10, minute: 34, second: 53, millisecond: 387),

new TimeOnly(hour: 15, minute: 20, second: 36, millisecond: 206),

new TimeOnly(hour: 17, minute: 41, second: 17, millisecond: 945),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 6, minute: 36, second: 52, millisecond: 240),

new TimeOnly(hour: 0, minute: 54, second: 55, millisecond: 276),

new TimeOnly(hour: 10, minute: 22, second: 10, millisecond: 59),

},
},
            new TimeOnlytime_without_time_zoneListD1E2M
{
    Id = 173,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 17, minute: 39, second: 31, millisecond: 404),

new TimeOnly(hour: 15, minute: 49, second: 14, millisecond: 722),

new TimeOnly(hour: 9, minute: 50, second: 11, millisecond: 399),

},
    ModelInner = new TimeOnlytime_without_time_zoneListD1E2MI
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 16, minute: 25, second: 16, millisecond: 811),

new TimeOnly(hour: 7, minute: 51, second: 23, millisecond: 115),

new TimeOnly(hour: 7, minute: 49, second: 23, millisecond: 302),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 6, minute: 12, second: 23, millisecond: 444),

new TimeOnly(hour: 4, minute: 10, second: 24, millisecond: 434),

new TimeOnly(hour: 14, minute: 10, second: 29, millisecond: 215),

new TimeOnly(hour: 10, minute: 38, second: 44, millisecond: 99),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 13, minute: 37, second: 46, millisecond: 789),

new TimeOnly(hour: 4, minute: 3, second: 5, millisecond: 55),

new TimeOnly(hour: 16, minute: 7, second: 55, millisecond: 113),

new TimeOnly(hour: 4, minute: 2, second: 30, millisecond: 675),

},
},
            new TimeOnlytime_without_time_zoneListD1E2M
{
    Id = 177,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 11, minute: 11, second: 35, millisecond: 677),

new TimeOnly(hour: 21, minute: 26, second: 41, millisecond: 270),

new TimeOnly(hour: 3, minute: 51, second: 34, millisecond: 817),

new TimeOnly(hour: 15, minute: 19, second: 10, millisecond: 706),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneListD1E2M
{
    Id = 180,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 6, minute: 28, second: 49, millisecond: 917),

new TimeOnly(hour: 15, minute: 0, second: 41, millisecond: 734),

new TimeOnly(hour: 19, minute: 27, second: 0, millisecond: 265),

new TimeOnly(hour: 15, minute: 18, second: 4, millisecond: 655),

},
    ModelInner = new TimeOnlytime_without_time_zoneListD1E2MI
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 10, minute: 15, second: 38, millisecond: 25),

new TimeOnly(hour: 14, minute: 32, second: 51, millisecond: 815),

new TimeOnly(hour: 21, minute: 34, second: 3, millisecond: 852),

new TimeOnly(hour: 10, minute: 0, second: 3, millisecond: 816),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 0, minute: 8, second: 28, millisecond: 727),

new TimeOnly(hour: 12, minute: 2, second: 15, millisecond: 365),

new TimeOnly(hour: 3, minute: 22, second: 40, millisecond: 444),

new TimeOnly(hour: 11, minute: 18, second: 40, millisecond: 740),

},
},
            new TimeOnlytime_without_time_zoneListD1E2M
{
    Id = 183,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 13, minute: 27, second: 2, millisecond: 33),

new TimeOnly(hour: 22, minute: 58, second: 55, millisecond: 642),

new TimeOnly(hour: 14, minute: 7, second: 52, millisecond: 839),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneListD1E2M
{
    Id = 186,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 22, minute: 20, second: 51, millisecond: 165),

new TimeOnly(hour: 5, minute: 47, second: 3, millisecond: 883),

new TimeOnly(hour: 4, minute: 38, second: 10, millisecond: 243),

},
    ModelInner = new TimeOnlytime_without_time_zoneListD1E2MI
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 9, minute: 16, second: 17, millisecond: 511),

new TimeOnly(hour: 14, minute: 19, second: 31, millisecond: 230),

new TimeOnly(hour: 0, minute: 55, second: 20, millisecond: 875),

new TimeOnly(hour: 20, minute: 4, second: 30, millisecond: 69),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 14, minute: 57, second: 10, millisecond: 662),

new TimeOnly(hour: 15, minute: 44, second: 24, millisecond: 417),

new TimeOnly(hour: 21, minute: 5, second: 6, millisecond: 278),

new TimeOnly(hour: 9, minute: 47, second: 18, millisecond: 499),

},
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneListD1E2M
{
    Id = 195,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 7, minute: 45, second: 17, millisecond: 745),

new TimeOnly(hour: 12, minute: 40, second: 41, millisecond: 937),

new TimeOnly(hour: 11, minute: 9, second: 17, millisecond: 784),

new TimeOnly(hour: 22, minute: 2, second: 52, millisecond: 667),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 22, minute: 54, second: 54, millisecond: 288),

new TimeOnly(hour: 18, minute: 33, second: 8, millisecond: 543),

new TimeOnly(hour: 19, minute: 19, second: 14, millisecond: 248),

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timeonlytime_without_time_zonelistd1e2mi(
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
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.TimeOnly>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483628)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.TimeOnly>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483628))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timeonlytime_without_time_zonelistd1e2mi(
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
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.TimeOnly>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483628)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.TimeOnly>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483628))]
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

                changedRows =  ((ITimeOnlyListtime_without_time_zoneListD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ITimeOnlyListtime_without_time_zoneListD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((ITimeOnlyListtime_without_time_zoneListD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeOnlyListtime_without_time_zoneListD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((ITimeOnlyListtime_without_time_zoneListD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((ITimeOnlyListtime_without_time_zoneListD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((ITimeOnlyListtime_without_time_zoneListD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((ITimeOnlyListtime_without_time_zoneListD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((ITimeOnlyListtime_without_time_zoneListD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((ITimeOnlyListtime_without_time_zoneListD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((ITimeOnlyListtime_without_time_zoneListD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((ITimeOnlyListtime_without_time_zoneListD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((ITimeOnlyListtime_without_time_zoneListD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((ITimeOnlyListtime_without_time_zoneListD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((ITimeOnlyListtime_without_time_zoneListD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((ITimeOnlyListtime_without_time_zoneListD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((ITimeOnlyListtime_without_time_zoneListD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timeonlytime_without_time_zonelistd1e2m(
	id,
    value,
    nullablevalue,
    timeonlytime_without_time_zonelistd1e2mi_id
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
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneListD1)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.TimeOnly>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483628)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.TimeOnly>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483628)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "timeonlytime_without_time_zonelistd1e2mi_id", 
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
                changedRows =  ((ITimeOnlyListtime_without_time_zoneListD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((ITimeOnlyListtime_without_time_zoneListD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((ITimeOnlyListtime_without_time_zoneListD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((ITimeOnlyListtime_without_time_zoneListD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timeonlytime_without_time_zonelistd1e2m(
	id,
    value,
    nullablevalue,
    timeonlytime_without_time_zonelistd1e2mi_id
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
    timeonlytime_without_time_zonelistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneListD1)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timeonlytime_without_time_zonelistd1e2m(
	id,
    value,
    nullablevalue,
    timeonlytime_without_time_zonelistd1e2mi_id
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
    timeonlytime_without_time_zonelistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.TimeOnly>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483628)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.TimeOnly>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483628)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "timeonlytime_without_time_zonelistd1e2mi_id", 
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
                List<TimeOnlytime_without_time_zoneListD1E2M> models = null;

                models =  ((ITimeOnlyListtime_without_time_zoneListD1)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[0],_testData[4], true);
                models =  ((ITimeOnlyListtime_without_time_zoneListD1)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[0],_testData[5], true);
                models =  ((ITimeOnlyListtime_without_time_zoneListD1)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[0],_testData[6], true);
                models =  ((ITimeOnlyListtime_without_time_zoneListD1)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<TimeOnlytime_without_time_zoneListD1E2M> models = null;

                models = await ((ITimeOnlyListtime_without_time_zoneListD1)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[0],_testData[8], true);
                models = await ((ITimeOnlyListtime_without_time_zoneListD1)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[0],_testData[9], true);
                models = await ((ITimeOnlyListtime_without_time_zoneListD1)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[0],_testData[10], true);
                models = await ((ITimeOnlyListtime_without_time_zoneListD1)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[0],_testData[11], true);
                models = await ((ITimeOnlyListtime_without_time_zoneListD1)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[0],_testData[12], true);
                models = await ((ITimeOnlyListtime_without_time_zoneListD1)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[0],_testData[13], true);
                models = await ((ITimeOnlyListtime_without_time_zoneListD1)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[0],_testData[14], true);
                models = await ((ITimeOnlyListtime_without_time_zoneListD1)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[0],_testData[15], true);
                models = await ((ITimeOnlyListtime_without_time_zoneListD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[0],_testData[16], true);
                models = await ((ITimeOnlyListtime_without_time_zoneListD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[0],_testData[17], true);
                models = await ((ITimeOnlyListtime_without_time_zoneListD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[0],_testData[18], true);
                models = await ((ITimeOnlyListtime_without_time_zoneListD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[0],_testData[19], true);
                models = await ((ITimeOnlyListtime_without_time_zoneListD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[0],_testData[20], true);
                models = await ((ITimeOnlyListtime_without_time_zoneListD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[0],_testData[21], true);
                models = await ((ITimeOnlyListtime_without_time_zoneListD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[0],_testData[22], true);
                models = await ((ITimeOnlyListtime_without_time_zoneListD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[0],_testData[23], true);
                models = await ((ITimeOnlyListtime_without_time_zoneListD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[0],_testData[24], true);
                models = await ((ITimeOnlyListtime_without_time_zoneListD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[0],_testData[25], true);
                models = await ((ITimeOnlyListtime_without_time_zoneListD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[0],_testData[26], true);
                models = await ((ITimeOnlyListtime_without_time_zoneListD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[0],_testData[27], true);
                models = await ((ITimeOnlyListtime_without_time_zoneListD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[0],_testData[28], true);
                models = await ((ITimeOnlyListtime_without_time_zoneListD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[0],_testData[29], true);
                models = await ((ITimeOnlyListtime_without_time_zoneListD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[0],_testData[30], true);
                models = await ((ITimeOnlyListtime_without_time_zoneListD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[0],_testData[31], true);
                models = await ((ITimeOnlyListtime_without_time_zoneListD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[0],_testData[32], true);
                models = await ((ITimeOnlyListtime_without_time_zoneListD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[0],_testData[33], true);
                models = await ((ITimeOnlyListtime_without_time_zoneListD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeOnlytime_without_time_zoneListD1E2M), typeof(FlatTimeOnlytime_without_time_zoneListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneListD1)),
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
FROM public.timeonlytime_without_time_zonelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatTimeOnlytime_without_time_zoneListD1E2M>();
                var models2 = new List<FlatTimeOnlytime_without_time_zoneListD1E2M>();
                await ((ITimeOnlyListtime_without_time_zoneListD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.timeonlytime_without_time_zonelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatTimeOnlytime_without_time_zoneListD1E2M>();
                var models2 = new List<FlatTimeOnlytime_without_time_zoneListD1E2M>();
                ((ITimeOnlyListtime_without_time_zoneListD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeOnlytime_without_time_zoneListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneListD1)),
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
FROM public.timeonlytime_without_time_zonelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((ITimeOnlyListtime_without_time_zoneListD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.timeonlytime_without_time_zonelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((ITimeOnlyListtime_without_time_zoneListD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.timeonlytime_without_time_zonelistd1e2m m
LEFT JOIN public.timeonlytime_without_time_zonelistd1e2mi mi ON mi.id = m.timeonlytime_without_time_zonelistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneListD1)),
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
                var models = await ((ITimeOnlyListtime_without_time_zoneListD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((ITimeOnlyListtime_without_time_zoneListD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeOnlytime_without_time_zoneListD1E2M), typeof(FlatTimeOnlytime_without_time_zoneListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneListD1)),
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
FROM public.timeonlytime_without_time_zonelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatTimeOnlytime_without_time_zoneListD1E2M>();
                var models2 = new List<FlatTimeOnlytime_without_time_zoneListD1E2M>();
                await ((ITimeOnlyListtime_without_time_zoneListD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.timeonlytime_without_time_zonelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatTimeOnlytime_without_time_zoneListD1E2M>();
                var models2 = new List<FlatTimeOnlytime_without_time_zoneListD1E2M>();
                ((ITimeOnlyListtime_without_time_zoneListD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeOnlytime_without_time_zoneListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneListD1)),
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
FROM public.timeonlytime_without_time_zonelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((ITimeOnlyListtime_without_time_zoneListD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.timeonlytime_without_time_zonelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((ITimeOnlyListtime_without_time_zoneListD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.timeonlytime_without_time_zonelistd1e2m m
LEFT JOIN public.timeonlytime_without_time_zonelistd1e2mi mi ON mi.id = m.timeonlytime_without_time_zonelistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneListD1)),
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
                var models = await ((ITimeOnlyListtime_without_time_zoneListD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((ITimeOnlyListtime_without_time_zoneListD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeOnlytime_without_time_zoneListD1E2M), typeof(FlatTimeOnlytime_without_time_zoneListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneListD1)),
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
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneListD1)),
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
FROM public.timeonlytime_without_time_zonelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatTimeOnlytime_without_time_zoneListD1E2M>();
                var models2 = new List<FlatTimeOnlytime_without_time_zoneListD1E2M>();
                await((ITimeOnlyListtime_without_time_zoneListD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 169;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 177;
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
FROM public.timeonlytime_without_time_zonelistd1e2m m
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
FROM public.timeonlytime_without_time_zonelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeOnlytime_without_time_zoneListD1E2M>();
                var firstItems2 = new List<FlatTimeOnlytime_without_time_zoneListD1E2M>();
                var secondItems1 = new List<FlatTimeOnlytime_without_time_zoneListD1E2M>();
                var secondItems2 = new List<FlatTimeOnlytime_without_time_zoneListD1E2M>();
                await ((ITimeOnlyListtime_without_time_zoneListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems2[3],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 18;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 31;
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
FROM public.timeonlytime_without_time_zonelistd1e2m m
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
FROM public.timeonlytime_without_time_zonelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeOnlytime_without_time_zoneListD1E2M>();
                var firstItems2 = new List<FlatTimeOnlytime_without_time_zoneListD1E2M>();
                var secondItems1 = new List<FlatTimeOnlytime_without_time_zoneListD1E2M>();
                await ((ITimeOnlyListtime_without_time_zoneListD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[29],_testData[34], false);
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
FROM public.timeonlytime_without_time_zonelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatTimeOnlytime_without_time_zoneListD1E2M>();
                var models2 = new List<FlatTimeOnlytime_without_time_zoneListD1E2M>();
                ((ITimeOnlyListtime_without_time_zoneListD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 49;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 166;
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
FROM public.timeonlytime_without_time_zonelistd1e2m m
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
FROM public.timeonlytime_without_time_zonelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeOnlytime_without_time_zoneListD1E2M>();
                var firstItems2 = new List<FlatTimeOnlytime_without_time_zoneListD1E2M>();
                var secondItems1 = new List<FlatTimeOnlytime_without_time_zoneListD1E2M>();
                var secondItems2 = new List<FlatTimeOnlytime_without_time_zoneListD1E2M>();
                 ((ITimeOnlyListtime_without_time_zoneListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems2[6],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 49;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 152;
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
FROM public.timeonlytime_without_time_zonelistd1e2m m
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
FROM public.timeonlytime_without_time_zonelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeOnlytime_without_time_zoneListD1E2M>();
                var firstItems2 = new List<FlatTimeOnlytime_without_time_zoneListD1E2M>();
                var secondItems1 = new List<FlatTimeOnlytime_without_time_zoneListD1E2M>();
                 ((ITimeOnlyListtime_without_time_zoneListD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[8],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeOnlytime_without_time_zoneListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneListD1)),
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
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneListD1)),
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
FROM public.timeonlytime_without_time_zonelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((ITimeOnlyListtime_without_time_zoneListD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 129;
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
FROM public.timeonlytime_without_time_zonelistd1e2m m
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
FROM public.timeonlytime_without_time_zonelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((ITimeOnlyListtime_without_time_zoneListD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[0],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[1],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[2],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[3],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[4],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[5],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[6],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[7],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[8],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[9],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[10],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[11],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[0],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[1],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[2],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[3],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[4],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[5],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[6],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[7],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[8],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[9],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[10],_testData[34], false);
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
                parametr1.Value = 83;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 159;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.timeonlytime_without_time_zonelistd1e2m m
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
FROM public.timeonlytime_without_time_zonelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeOnlytime_without_time_zoneListD1E2M>();
                var secondItems1 = new List<FlatTimeOnlytime_without_time_zoneListD1E2M>();
                var secondItems2 = new List<FlatTimeOnlytime_without_time_zoneListD1E2M>();
                await ((ITimeOnlyListtime_without_time_zoneListD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems2[7],_testData[34], false);
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
FROM public.timeonlytime_without_time_zonelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((ITimeOnlyListtime_without_time_zoneListD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 36;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 9;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.timeonlytime_without_time_zonelistd1e2m m
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
FROM public.timeonlytime_without_time_zonelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((ITimeOnlyListtime_without_time_zoneListD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[0],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[1],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[2],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[3],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[4],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[5],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[6],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[7],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[8],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[9],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[10],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[11],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[12],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[13],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[14],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[15],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[16],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[17],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[18],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[19],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[20],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[21],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[22],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[23],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[24],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[25],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[26],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[27],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[0],_testData[2], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[1],_testData[3], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[2],_testData[4], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[3],_testData[5], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[4],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[5],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[6],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[7],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[8],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[9],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[10],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[11],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[12],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[13],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[14],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[15],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[16],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[17],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[18],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[19],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[20],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[21],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[22],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[23],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[24],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[25],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[26],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[27],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[28],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[29],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[30],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[31],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[32],_testData[34], false);
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
                parametr1.Value = 66;
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
FROM public.timeonlytime_without_time_zonelistd1e2m m
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
FROM public.timeonlytime_without_time_zonelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeOnlytime_without_time_zoneListD1E2M>();
                var secondItems1 = new List<FlatTimeOnlytime_without_time_zoneListD1E2M>();
                var secondItems2 = new List<FlatTimeOnlytime_without_time_zoneListD1E2M>();
                 ((ITimeOnlyListtime_without_time_zoneListD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems2[6],_testData[34], false);
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
FROM public.timeonlytime_without_time_zonelistd1e2m m
LEFT JOIN public.timeonlytime_without_time_zonelistd1e2mi mi ON mi.id = m.timeonlytime_without_time_zonelistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneListD1)),
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
                var models = await((ITimeOnlyListtime_without_time_zoneListD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 173;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 51;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((ITimeOnlyListtime_without_time_zoneListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[0],_testData[30], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[1],_testData[31], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[2],_testData[32], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[3],_testData[33], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[0],_testData[10], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[1],_testData[11], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[2],_testData[12], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[3],_testData[13], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[4],_testData[14], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[5],_testData[15], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[6],_testData[16], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[7],_testData[17], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[8],_testData[18], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[9],_testData[19], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[10],_testData[20], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[11],_testData[21], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[12],_testData[22], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[13],_testData[23], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[14],_testData[24], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[15],_testData[25], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[16],_testData[26], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[17],_testData[27], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[18],_testData[28], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[19],_testData[29], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[20],_testData[30], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[21],_testData[31], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[22],_testData[32], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[23],_testData[33], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[24],_testData[34], false);
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
                var models = ((ITimeOnlyListtime_without_time_zoneListD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 121;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 37;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((ITimeOnlyListtime_without_time_zoneListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[0],_testData[20], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[1],_testData[21], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[2],_testData[22], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[3],_testData[23], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[4],_testData[24], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[5],_testData[25], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[6],_testData[26], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[7],_testData[27], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[8],_testData[28], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[9],_testData[29], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[10],_testData[30], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[11],_testData[31], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[12],_testData[32], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[13],_testData[33], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[0],_testData[7], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[1],_testData[8], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[2],_testData[9], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[3],_testData[10], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[4],_testData[11], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[5],_testData[12], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[6],_testData[13], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[7],_testData[14], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[8],_testData[15], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[9],_testData[16], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[10],_testData[17], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[11],_testData[18], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[12],_testData[19], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[13],_testData[20], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[14],_testData[21], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[15],_testData[22], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[16],_testData[23], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[17],_testData[24], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[18],_testData[25], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[19],_testData[26], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[20],_testData[27], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[21],_testData[28], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[22],_testData[29], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[23],_testData[30], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[24],_testData[31], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[25],_testData[32], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[26],_testData[33], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeOnlytime_without_time_zoneListD1E2M), typeof(FlatTimeOnlytime_without_time_zoneListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneListD1)),
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
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneListD1)),
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
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneListD1)),
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
FROM public.timeonlytime_without_time_zonelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatTimeOnlytime_without_time_zoneListD1E2M>();
                var models2 = new List<FlatTimeOnlytime_without_time_zoneListD1E2M>();
                await((ITimeOnlyListtime_without_time_zoneListD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.timeonlytime_without_time_zonelistd1e2m m
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
FROM public.timeonlytime_without_time_zonelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeOnlytime_without_time_zoneListD1E2M>();
                var firstItems2 = new List<FlatTimeOnlytime_without_time_zoneListD1E2M>();
                var secondItems1 = new List<FlatTimeOnlytime_without_time_zoneListD1E2M>();
                var secondItems2 = new List<FlatTimeOnlytime_without_time_zoneListD1E2M>();
                await ((ITimeOnlyListtime_without_time_zoneListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 51, query1, 152, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM public.timeonlytime_without_time_zonelistd1e2m m
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
FROM public.timeonlytime_without_time_zonelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeOnlytime_without_time_zoneListD1E2M>();
                var firstItems2 = new List<FlatTimeOnlytime_without_time_zoneListD1E2M>();
                var secondItems1 = new List<FlatTimeOnlytime_without_time_zoneListD1E2M>();
                await ((ITimeOnlyListtime_without_time_zoneListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 7, query1, 166, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[6],_testData[34], false);
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
FROM public.timeonlytime_without_time_zonelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatTimeOnlytime_without_time_zoneListD1E2M>();
                var models2 = new List<FlatTimeOnlytime_without_time_zoneListD1E2M>();
                ((ITimeOnlyListtime_without_time_zoneListD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.timeonlytime_without_time_zonelistd1e2m m
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
FROM public.timeonlytime_without_time_zonelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeOnlytime_without_time_zoneListD1E2M>();
                var firstItems2 = new List<FlatTimeOnlytime_without_time_zoneListD1E2M>();
                var secondItems1 = new List<FlatTimeOnlytime_without_time_zoneListD1E2M>();
                var secondItems2 = new List<FlatTimeOnlytime_without_time_zoneListD1E2M>();
                 ((ITimeOnlyListtime_without_time_zoneListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 103, query1, 131, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems2[11],_testData[34], false);
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
FROM public.timeonlytime_without_time_zonelistd1e2m m
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
FROM public.timeonlytime_without_time_zonelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeOnlytime_without_time_zoneListD1E2M>();
                var firstItems2 = new List<FlatTimeOnlytime_without_time_zoneListD1E2M>();
                var secondItems1 = new List<FlatTimeOnlytime_without_time_zoneListD1E2M>();
                 ((ITimeOnlyListtime_without_time_zoneListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 139, query1, 31, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[29],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeOnlytime_without_time_zoneListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneListD1)),
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
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneListD1)),
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
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneListD1)),
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
FROM public.timeonlytime_without_time_zonelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((ITimeOnlyListtime_without_time_zoneListD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.timeonlytime_without_time_zonelistd1e2m m
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
FROM public.timeonlytime_without_time_zonelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((ITimeOnlyListtime_without_time_zoneListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 75, query1, 180, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[0],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[1],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[2],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[3],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[4],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[5],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[6],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[7],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[8],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[9],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[10],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[11],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[12],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[13],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[14],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[15],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[16],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[17],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[18],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[19],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[0],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[1],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[2],_testData[34], false);
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
FROM public.timeonlytime_without_time_zonelistd1e2m m
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
FROM public.timeonlytime_without_time_zonelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeOnlytime_without_time_zoneListD1E2M>();
                var secondItems1 = new List<FlatTimeOnlytime_without_time_zoneListD1E2M>();
                var secondItems2 = new List<FlatTimeOnlytime_without_time_zoneListD1E2M>();
                await ((ITimeOnlyListtime_without_time_zoneListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 180, query1, 169, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems2[5],_testData[34], false);
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
FROM public.timeonlytime_without_time_zonelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((ITimeOnlyListtime_without_time_zoneListD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.timeonlytime_without_time_zonelistd1e2m m
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
FROM public.timeonlytime_without_time_zonelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((ITimeOnlyListtime_without_time_zoneListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 166, query1, 51, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[0],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[1],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[2],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[3],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[4],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[5],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[0],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[1],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[2],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[3],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[4],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[5],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[6],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[7],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[8],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[9],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[10],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[11],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[12],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[13],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[14],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[15],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[16],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[17],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[18],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[19],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[20],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[21],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[22],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[23],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[24],_testData[34], false);
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
FROM public.timeonlytime_without_time_zonelistd1e2m m
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
FROM public.timeonlytime_without_time_zonelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeOnlytime_without_time_zoneListD1E2M>();
                var secondItems1 = new List<FlatTimeOnlytime_without_time_zoneListD1E2M>();
                var secondItems2 = new List<FlatTimeOnlytime_without_time_zoneListD1E2M>();
                 ((ITimeOnlyListtime_without_time_zoneListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 66, query1, 36, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(firstItems1[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneListD1E2M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM public.timeonlytime_without_time_zonelistd1e2m m
LEFT JOIN public.timeonlytime_without_time_zonelistd1e2mi mi ON mi.id = m.timeonlytime_without_time_zonelistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneListD1)),
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
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneListD1)),
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
                var models = await((ITimeOnlyListtime_without_time_zoneListD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((ITimeOnlyListtime_without_time_zoneListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 71, 129))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[0],_testData[13], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[1],_testData[14], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[2],_testData[15], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[3],_testData[16], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[4],_testData[17], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[5],_testData[18], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[6],_testData[19], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[7],_testData[20], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[8],_testData[21], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[9],_testData[22], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[10],_testData[23], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[11],_testData[24], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[12],_testData[25], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[13],_testData[26], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[14],_testData[27], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[15],_testData[28], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[16],_testData[29], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[17],_testData[30], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[18],_testData[31], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[19],_testData[32], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[20],_testData[33], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[0],_testData[22], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[1],_testData[23], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[2],_testData[24], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[3],_testData[25], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[4],_testData[26], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[5],_testData[27], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[6],_testData[28], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[7],_testData[29], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[8],_testData[30], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[9],_testData[31], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[10],_testData[32], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[11],_testData[33], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[12],_testData[34], false);
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
                var models = ((ITimeOnlyListtime_without_time_zoneListD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((ITimeOnlyListtime_without_time_zoneListD1)this).DbConnectionSTSelectModelBatch(connection, 112, 22))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[0],_testData[19], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[1],_testData[20], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[2],_testData[21], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[3],_testData[22], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[4],_testData[23], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[5],_testData[24], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[6],_testData[25], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[7],_testData[26], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[8],_testData[27], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[9],_testData[28], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[10],_testData[29], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[11],_testData[30], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[12],_testData[31], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[13],_testData[32], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[14],_testData[33], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[0],_testData[4], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[1],_testData[5], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[2],_testData[6], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[3],_testData[7], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[4],_testData[8], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[5],_testData[9], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[6],_testData[10], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[7],_testData[11], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[8],_testData[12], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[9],_testData[13], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[10],_testData[14], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[11],_testData[15], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[12],_testData[16], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[13],_testData[17], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[14],_testData[18], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[15],_testData[19], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[16],_testData[20], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[17],_testData[21], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[18],_testData[22], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[19],_testData[23], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[20],_testData[24], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[21],_testData[25], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[22],_testData[26], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[23],_testData[27], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[24],_testData[28], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[25],_testData[29], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[26],_testData[30], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[27],_testData[31], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[28],_testData[32], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[29],_testData[33], false);
                        TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[30],_testData[34], false);
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
                await using var cmd = await ((ITimeOnlyListtime_without_time_zoneListD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((ITimeOnlyListtime_without_time_zoneListD1)this).SetDbConnectionSelectModelParametrs(cmd, 166);
                var models = await ((ITimeOnlyListtime_without_time_zoneListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(7));

                TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[0],_testData[28], false);
                TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[1],_testData[29], false);
                TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[2],_testData[30], false);
                TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[3],_testData[31], false);
                TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[4],_testData[32], false);
                TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[5],_testData[33], false);
                TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[6],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ITimeOnlyListtime_without_time_zoneListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((ITimeOnlyListtime_without_time_zoneListD1)this).SetDbConnectionSelectModelParametrs(cmd, 66);
                var models =  ((ITimeOnlyListtime_without_time_zoneListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(23));

                TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[0],_testData[12], false);
                TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[1],_testData[13], false);
                TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[2],_testData[14], false);
                TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[3],_testData[15], false);
                TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[4],_testData[16], false);
                TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[5],_testData[17], false);
                TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[6],_testData[18], false);
                TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[7],_testData[19], false);
                TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[8],_testData[20], false);
                TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[9],_testData[21], false);
                TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[10],_testData[22], false);
                TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[11],_testData[23], false);
                TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[12],_testData[24], false);
                TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[13],_testData[25], false);
                TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[14],_testData[26], false);
                TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[15],_testData[27], false);
                TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[16],_testData[28], false);
                TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[17],_testData[29], false);
                TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[18],_testData[30], false);
                TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[19],_testData[31], false);
                TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[20],_testData[32], false);
                TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[21],_testData[33], false);
                TimeOnlytime_without_time_zoneListD1E2M.AssertModel(models[22],_testData[34], false);
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
FROM public.binary_timeonlytime_without_time_zonelistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneListD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(TimeOnlytime_without_time_zoneListD1E2MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483628),
                (NpgsqlTypes.NpgsqlDbType)(-2147483628)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneListD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<TimeOnlytime_without_time_zoneListD1E2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeOnlytime_without_time_zoneListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ITimeOnlyListtime_without_time_zoneListD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_timeonlytime_without_time_zonelistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((ITimeOnlyListtime_without_time_zoneListD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeOnlytime_without_time_zoneListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<TimeOnlytime_without_time_zoneListD1E2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeOnlytime_without_time_zoneListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ITimeOnlyListtime_without_time_zoneListD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_timeonlytime_without_time_zonelistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((ITimeOnlyListtime_without_time_zoneListD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeOnlytime_without_time_zoneListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_timeonlytime_without_time_zonelistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneListD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(TimeOnlytime_without_time_zoneListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneListD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<TimeOnlytime_without_time_zoneListD1E2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeOnlytime_without_time_zoneListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ITimeOnlyListtime_without_time_zoneListD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_timeonlytime_without_time_zonelistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((ITimeOnlyListtime_without_time_zoneListD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeOnlytime_without_time_zoneListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<TimeOnlytime_without_time_zoneListD1E2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeOnlytime_without_time_zoneListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ITimeOnlyListtime_without_time_zoneListD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_timeonlytime_without_time_zonelistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((ITimeOnlyListtime_without_time_zoneListD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeOnlytime_without_time_zoneListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_timeonlytime_without_time_zonelistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneListD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_timeonlytime_without_time_zonelistd1e2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(TimeOnlytime_without_time_zoneListD1E2MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483628),
                (NpgsqlTypes.NpgsqlDbType)(-2147483628)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneListD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<TimeOnlytime_without_time_zoneListD1E2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((ITimeOnlyListtime_without_time_zoneListD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((ITimeOnlyListtime_without_time_zoneListD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeOnlytime_without_time_zoneListD1E2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<TimeOnlytime_without_time_zoneListD1E2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((ITimeOnlyListtime_without_time_zoneListD1)this).WAImportModelInner(connection, importCollection);
                var models = ((ITimeOnlyListtime_without_time_zoneListD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeOnlytime_without_time_zoneListD1E2MI.AssertModel(actual, expect, false);
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
FROM public.binary_timeonlytime_without_time_zonelistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneListD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_timeonlytime_without_time_zonelistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(TimeOnlytime_without_time_zoneListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneListD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<TimeOnlytime_without_time_zoneListD1E2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeOnlytime_without_time_zoneListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ITimeOnlyListtime_without_time_zoneListD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((ITimeOnlyListtime_without_time_zoneListD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeOnlytime_without_time_zoneListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<TimeOnlytime_without_time_zoneListD1E2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeOnlytime_without_time_zoneListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ITimeOnlyListtime_without_time_zoneListD1)this).ImportModelInner(connection, importCollection);
                var models = ((ITimeOnlyListtime_without_time_zoneListD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeOnlytime_without_time_zoneListD1E2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_timeonlytime_without_time_zonelistd1e2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
timeonlytime_without_time_zonelistd1e2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(TimeOnlytime_without_time_zoneListD1E2M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483628),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483628)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneListD1))]
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
FROM public.binary_timeonlytime_without_time_zonelistd1e2m m
LEFT JOIN public.binary_timeonlytime_without_time_zonelistd1e2mi mi ON mi.id = m.timeonlytime_without_time_zonelistd1e2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneListD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<TimeOnlytime_without_time_zoneListD1E2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((ITimeOnlyListtime_without_time_zoneListD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((ITimeOnlyListtime_without_time_zoneListD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    TimeOnlytime_without_time_zoneListD1E2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<TimeOnlytime_without_time_zoneListD1E2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((ITimeOnlyListtime_without_time_zoneListD1)this).ImportModel(connection, importCollection);
                var models = ((ITimeOnlyListtime_without_time_zoneListD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    TimeOnlytime_without_time_zoneListD1E2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_timeonlytime_without_time_zonelistd1e2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    timeonlytime_without_time_zonelistd1e2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483628),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483628)
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
                var models =  ((ITimeOnlyListtime_without_time_zoneListD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    TimeOnlytime_without_time_zoneListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((ITimeOnlyListtime_without_time_zoneListD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    TimeOnlytime_without_time_zoneListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneListD1E2MIWA), typeof(TimeOnlytime_without_time_zoneListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483628),
                (NpgsqlTypes.NpgsqlDbType)(-2147483628)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483628),
                (NpgsqlTypes.NpgsqlDbType)(-2147483628)
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
                var models1 = new List<TimeOnlytime_without_time_zoneListD1E2MIWA>();
                var models2 = new List<TimeOnlytime_without_time_zoneListD1E2MIWA>();
                await ((ITimeOnlyListtime_without_time_zoneListD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_timeonlytime_without_time_zonelistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeOnlytime_without_time_zoneListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeOnlytime_without_time_zoneListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<TimeOnlytime_without_time_zoneListD1E2MIWA>();
                var models2 = new List<TimeOnlytime_without_time_zoneListD1E2MIWA>();
                ((ITimeOnlyListtime_without_time_zoneListD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_timeonlytime_without_time_zonelistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeOnlytime_without_time_zoneListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeOnlytime_without_time_zoneListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483628),
                (NpgsqlTypes.NpgsqlDbType)(-2147483628)
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
                var models = await ((ITimeOnlyListtime_without_time_zoneListD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_timeonlytime_without_time_zonelistd1e2mi
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
                    TimeOnlytime_without_time_zoneListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((ITimeOnlyListtime_without_time_zoneListD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_timeonlytime_without_time_zonelistd1e2mi
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
                    TimeOnlytime_without_time_zoneListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneListD1E2MIWA), typeof(TimeOnlytime_without_time_zoneListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneListD1))]
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
                var models1 = new List<TimeOnlytime_without_time_zoneListD1E2MIWA>();
                var models2 = new List<TimeOnlytime_without_time_zoneListD1E2MIWA>();
                await ((ITimeOnlyListtime_without_time_zoneListD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_timeonlytime_without_time_zonelistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeOnlytime_without_time_zoneListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeOnlytime_without_time_zoneListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<TimeOnlytime_without_time_zoneListD1E2MIWA>();
                var models2 = new List<TimeOnlytime_without_time_zoneListD1E2MIWA>();
                ((ITimeOnlyListtime_without_time_zoneListD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_timeonlytime_without_time_zonelistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeOnlytime_without_time_zoneListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeOnlytime_without_time_zoneListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneListD1))]
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
                var models = await ((ITimeOnlyListtime_without_time_zoneListD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_timeonlytime_without_time_zonelistd1e2mi
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
                    TimeOnlytime_without_time_zoneListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((ITimeOnlyListtime_without_time_zoneListD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_timeonlytime_without_time_zonelistd1e2mi
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
                    TimeOnlytime_without_time_zoneListD1E2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_timeonlytime_without_time_zonelistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneListD1E2MI), typeof(TimeOnlytime_without_time_zoneListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483628),
                (NpgsqlTypes.NpgsqlDbType)(-2147483628)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483628),
                (NpgsqlTypes.NpgsqlDbType)(-2147483628)
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
                var models1 = new List<TimeOnlytime_without_time_zoneListD1E2MI>();
                var models2 = new List<TimeOnlytime_without_time_zoneListD1E2MI>();
                await ((ITimeOnlyListtime_without_time_zoneListD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeOnlytime_without_time_zoneListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeOnlytime_without_time_zoneListD1E2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<TimeOnlytime_without_time_zoneListD1E2MI>();
                var models2 = new List<TimeOnlytime_without_time_zoneListD1E2MI>();
                ((ITimeOnlyListtime_without_time_zoneListD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeOnlytime_without_time_zoneListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeOnlytime_without_time_zoneListD1E2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_timeonlytime_without_time_zonelistd1e2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483628),
                (NpgsqlTypes.NpgsqlDbType)(-2147483628)
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
                var models = await ((ITimeOnlyListtime_without_time_zoneListD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    TimeOnlytime_without_time_zoneListD1E2MI.AssertModel(model, expectedModel, false);
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
                var models = ((ITimeOnlyListtime_without_time_zoneListD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    TimeOnlytime_without_time_zoneListD1E2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_timeonlytime_without_time_zonelistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneListD1E2MIWA), typeof(TimeOnlytime_without_time_zoneListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneListD1))]
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
                var models1 = new List<TimeOnlytime_without_time_zoneListD1E2MIWA>();
                var models2 = new List<TimeOnlytime_without_time_zoneListD1E2MIWA>();
                await ((ITimeOnlyListtime_without_time_zoneListD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeOnlytime_without_time_zoneListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeOnlytime_without_time_zoneListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<TimeOnlytime_without_time_zoneListD1E2MIWA>();
                var models2 = new List<TimeOnlytime_without_time_zoneListD1E2MIWA>();
                ((ITimeOnlyListtime_without_time_zoneListD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeOnlytime_without_time_zoneListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeOnlytime_without_time_zoneListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_timeonlytime_without_time_zonelistd1e2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneListD1))]
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
                var models = await ((ITimeOnlyListtime_without_time_zoneListD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    TimeOnlytime_without_time_zoneListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((ITimeOnlyListtime_without_time_zoneListD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    TimeOnlytime_without_time_zoneListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

