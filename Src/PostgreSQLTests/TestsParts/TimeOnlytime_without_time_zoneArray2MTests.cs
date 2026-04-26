

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
    internal partial interface ITimeOnlyListtime_without_time_zoneArray
    {
    }
    
    internal partial class TimeOnlyListtime_without_time_zoneArray : ITimeOnlyListtime_without_time_zoneArray
    {


#region TestData

        private readonly TimeOnlytime_without_time_zoneArray2M[] _testData = new TimeOnlytime_without_time_zoneArray2M[]
        {
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 4, minute: 34, second: 11, millisecond: 836),

new TimeOnly(hour: 19, minute: 53, second: 30, millisecond: 227),

new TimeOnly(hour: 19, minute: 44, second: 2, millisecond: 1),

new TimeOnly(hour: 18, minute: 52, second: 13, millisecond: 476),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 10, minute: 16, second: 26, millisecond: 606),

new TimeOnly(hour: 9, minute: 6, second: 20, millisecond: 971),

new TimeOnly(hour: 8, minute: 6, second: 22, millisecond: 760),

new TimeOnly(hour: 17, minute: 29, second: 19, millisecond: 290),

},
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 8, minute: 50, second: 27, millisecond: 122),

new TimeOnly(hour: 0, minute: 47, second: 29, millisecond: 309),

new TimeOnly(hour: 8, minute: 32, second: 9, millisecond: 719),

new TimeOnly(hour: 20, minute: 0, second: 52, millisecond: 744),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 18, minute: 54, second: 38, millisecond: 359),

new TimeOnly(hour: 22, minute: 26, second: 46, millisecond: 245),

new TimeOnly(hour: 4, minute: 44, second: 20, millisecond: 64),

new TimeOnly(hour: 14, minute: 51, second: 39, millisecond: 642),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 6, minute: 48, second: 57, millisecond: 13),

new TimeOnly(hour: 7, minute: 17, second: 52, millisecond: 414),

new TimeOnly(hour: 9, minute: 27, second: 25, millisecond: 38),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 0, minute: 54, second: 27, millisecond: 995),

new TimeOnly(hour: 3, minute: 42, second: 21, millisecond: 353),

new TimeOnly(hour: 21, minute: 35, second: 28, millisecond: 439),

new TimeOnly(hour: 6, minute: 48, second: 46, millisecond: 73),

},
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 3, minute: 14, second: 49, millisecond: 33),

new TimeOnly(hour: 22, minute: 27, second: 41, millisecond: 641),

new TimeOnly(hour: 1, minute: 50, second: 47, millisecond: 886),

new TimeOnly(hour: 3, minute: 11, second: 26, millisecond: 988),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 18, minute: 56, second: 7, millisecond: 816),

new TimeOnly(hour: 16, minute: 46, second: 32, millisecond: 819),

new TimeOnly(hour: 11, minute: 58, second: 56, millisecond: 976),

},
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 17, minute: 16, second: 32, millisecond: 533),

new TimeOnly(hour: 16, minute: 0, second: 26, millisecond: 776),

new TimeOnly(hour: 18, minute: 53, second: 52, millisecond: 929),

new TimeOnly(hour: 13, minute: 58, second: 7, millisecond: 134),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 0, minute: 29, second: 23, millisecond: 466),

new TimeOnly(hour: 20, minute: 11, second: 6, millisecond: 723),

new TimeOnly(hour: 18, minute: 30, second: 51, millisecond: 787),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 16, minute: 56, second: 25, millisecond: 524),

new TimeOnly(hour: 4, minute: 13, second: 41, millisecond: 485),

new TimeOnly(hour: 20, minute: 30, second: 5, millisecond: 998),

new TimeOnly(hour: 21, minute: 57, second: 7, millisecond: 840),

},
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 10, minute: 18, second: 16, millisecond: 132),

new TimeOnly(hour: 5, minute: 46, second: 12, millisecond: 280),

new TimeOnly(hour: 4, minute: 46, second: 23, millisecond: 296),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 19, minute: 36, second: 26, millisecond: 299),

new TimeOnly(hour: 16, minute: 34, second: 11, millisecond: 382),

new TimeOnly(hour: 6, minute: 41, second: 49, millisecond: 700),

},
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 21, minute: 11, second: 28, millisecond: 854),

new TimeOnly(hour: 3, minute: 10, second: 0, millisecond: 596),

new TimeOnly(hour: 19, minute: 21, second: 54, millisecond: 763),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 12, minute: 8, second: 43, millisecond: 187),

new TimeOnly(hour: 2, minute: 21, second: 12, millisecond: 462),

new TimeOnly(hour: 10, minute: 7, second: 36, millisecond: 644),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 8, minute: 33, second: 38, millisecond: 839),

new TimeOnly(hour: 8, minute: 24, second: 48, millisecond: 776),

new TimeOnly(hour: 18, minute: 31, second: 58, millisecond: 461),

new TimeOnly(hour: 5, minute: 1, second: 51, millisecond: 538),

},
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 12, minute: 37, second: 4, millisecond: 486),

new TimeOnly(hour: 3, minute: 51, second: 8, millisecond: 59),

new TimeOnly(hour: 8, minute: 8, second: 6, millisecond: 872),

new TimeOnly(hour: 13, minute: 55, second: 38, millisecond: 262),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 6, minute: 32, second: 14, millisecond: 456),

new TimeOnly(hour: 2, minute: 29, second: 23, millisecond: 772),

new TimeOnly(hour: 22, minute: 6, second: 47, millisecond: 987),

new TimeOnly(hour: 13, minute: 56, second: 29, millisecond: 531),

},
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 9, minute: 25, second: 35, millisecond: 714),

new TimeOnly(hour: 21, minute: 51, second: 26, millisecond: 379),

new TimeOnly(hour: 0, minute: 35, second: 2, millisecond: 842),

new TimeOnly(hour: 12, minute: 31, second: 22, millisecond: 572),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 15, minute: 14, second: 5, millisecond: 756),

new TimeOnly(hour: 1, minute: 3, second: 41, millisecond: 735),

new TimeOnly(hour: 7, minute: 23, second: 42, millisecond: 851),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 16, minute: 40, second: 25, millisecond: 468),

new TimeOnly(hour: 2, minute: 50, second: 24, millisecond: 782),

new TimeOnly(hour: 19, minute: 44, second: 9, millisecond: 220),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 20, minute: 6, second: 41, millisecond: 693),

new TimeOnly(hour: 8, minute: 11, second: 5, millisecond: 441),

new TimeOnly(hour: 19, minute: 13, second: 33, millisecond: 986),

},
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 19, minute: 7, second: 47, millisecond: 106),

new TimeOnly(hour: 18, minute: 21, second: 14, millisecond: 516),

new TimeOnly(hour: 4, minute: 2, second: 8, millisecond: 137),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 6, minute: 13, second: 31, millisecond: 19),

new TimeOnly(hour: 9, minute: 11, second: 31, millisecond: 487),

new TimeOnly(hour: 18, minute: 51, second: 28, millisecond: 349),

new TimeOnly(hour: 13, minute: 31, second: 23, millisecond: 950),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 21, minute: 56, second: 36, millisecond: 51),

new TimeOnly(hour: 14, minute: 4, second: 23, millisecond: 376),

new TimeOnly(hour: 16, minute: 27, second: 58, millisecond: 434),

new TimeOnly(hour: 0, minute: 28, second: 21, millisecond: 405),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 11, minute: 5, second: 38, millisecond: 861),

new TimeOnly(hour: 15, minute: 30, second: 19, millisecond: 896),

new TimeOnly(hour: 12, minute: 49, second: 55, millisecond: 429),

new TimeOnly(hour: 11, minute: 12, second: 44, millisecond: 272),

},
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 11, minute: 46, second: 3, millisecond: 803),

new TimeOnly(hour: 13, minute: 27, second: 58, millisecond: 141),

new TimeOnly(hour: 12, minute: 30, second: 56, millisecond: 685),

new TimeOnly(hour: 5, minute: 29, second: 57, millisecond: 745),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 9, minute: 3, second: 25, millisecond: 719),

new TimeOnly(hour: 5, minute: 50, second: 28, millisecond: 738),

new TimeOnly(hour: 8, minute: 45, second: 4, millisecond: 802),

new TimeOnly(hour: 18, minute: 52, second: 23, millisecond: 775),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 9, minute: 0, second: 1, millisecond: 997),

new TimeOnly(hour: 8, minute: 8, second: 54, millisecond: 14),

new TimeOnly(hour: 2, minute: 18, second: 5, millisecond: 346),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 10, minute: 49, second: 57, millisecond: 515),

new TimeOnly(hour: 15, minute: 26, second: 13, millisecond: 142),

new TimeOnly(hour: 17, minute: 12, second: 22, millisecond: 596),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 17, minute: 35, second: 16, millisecond: 551),

new TimeOnly(hour: 3, minute: 0, second: 32, millisecond: 400),

new TimeOnly(hour: 2, minute: 30, second: 13, millisecond: 12),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 1, minute: 35, second: 49, millisecond: 376),

new TimeOnly(hour: 22, minute: 47, second: 31, millisecond: 229),

new TimeOnly(hour: 5, minute: 36, second: 36, millisecond: 577),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 11, minute: 53, second: 58, millisecond: 843),

new TimeOnly(hour: 4, minute: 37, second: 56, millisecond: 3),

new TimeOnly(hour: 10, minute: 47, second: 33, millisecond: 894),

new TimeOnly(hour: 9, minute: 5, second: 14, millisecond: 333),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 6, minute: 35, second: 58, millisecond: 344),

new TimeOnly(hour: 22, minute: 16, second: 11, millisecond: 627),

new TimeOnly(hour: 6, minute: 26, second: 34, millisecond: 427),

},
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 13, minute: 34, second: 21, millisecond: 309),

new TimeOnly(hour: 4, minute: 56, second: 5, millisecond: 281),

new TimeOnly(hour: 11, minute: 58, second: 1, millisecond: 811),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 6, minute: 36, second: 35, millisecond: 46),

new TimeOnly(hour: 13, minute: 50, second: 27, millisecond: 564),

new TimeOnly(hour: 1, minute: 14, second: 53, millisecond: 790),

new TimeOnly(hour: 13, minute: 34, second: 0, millisecond: 376),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 22, minute: 23, second: 57, millisecond: 267),

new TimeOnly(hour: 18, minute: 56, second: 14, millisecond: 524),

new TimeOnly(hour: 10, minute: 37, second: 52, millisecond: 771),

new TimeOnly(hour: 1, minute: 38, second: 35, millisecond: 720),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 0, minute: 8, second: 41, millisecond: 812),

new TimeOnly(hour: 16, minute: 2, second: 38, millisecond: 376),

new TimeOnly(hour: 8, minute: 25, second: 32, millisecond: 285),

},
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 19, minute: 38, second: 29, millisecond: 414),

new TimeOnly(hour: 0, minute: 18, second: 29, millisecond: 304),

new TimeOnly(hour: 16, minute: 50, second: 3, millisecond: 734),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 5, minute: 5, second: 37, millisecond: 784),

new TimeOnly(hour: 7, minute: 12, second: 35, millisecond: 938),

new TimeOnly(hour: 4, minute: 11, second: 24, millisecond: 703),

new TimeOnly(hour: 22, minute: 56, second: 3, millisecond: 623),

},
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 103,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 4, minute: 33, second: 23, millisecond: 365),

new TimeOnly(hour: 14, minute: 52, second: 38, millisecond: 799),

new TimeOnly(hour: 0, minute: 21, second: 58, millisecond: 653),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 12, minute: 6, second: 42, millisecond: 320),

new TimeOnly(hour: 8, minute: 55, second: 37, millisecond: 194),

new TimeOnly(hour: 3, minute: 45, second: 21, millisecond: 650),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 111,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 22, minute: 6, second: 16, millisecond: 249),

new TimeOnly(hour: 19, minute: 4, second: 28, millisecond: 141),

new TimeOnly(hour: 9, minute: 41, second: 16, millisecond: 522),

new TimeOnly(hour: 13, minute: 7, second: 51, millisecond: 250),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 118,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 17, minute: 58, second: 15, millisecond: 860),

new TimeOnly(hour: 18, minute: 40, second: 46, millisecond: 100),

new TimeOnly(hour: 0, minute: 40, second: 57, millisecond: 483),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 22, minute: 34, second: 0, millisecond: 501),

new TimeOnly(hour: 15, minute: 45, second: 17, millisecond: 533),

new TimeOnly(hour: 15, minute: 26, second: 10, millisecond: 911),

new TimeOnly(hour: 3, minute: 56, second: 43, millisecond: 369),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 4, minute: 22, second: 21, millisecond: 958),

new TimeOnly(hour: 12, minute: 15, second: 7, millisecond: 328),

new TimeOnly(hour: 11, minute: 55, second: 40, millisecond: 154),

},
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 125,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 12, minute: 7, second: 2, millisecond: 407),

new TimeOnly(hour: 5, minute: 25, second: 38, millisecond: 18),

new TimeOnly(hour: 9, minute: 26, second: 5, millisecond: 758),

new TimeOnly(hour: 15, minute: 2, second: 53, millisecond: 126),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 126,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 15, minute: 39, second: 53, millisecond: 121),

new TimeOnly(hour: 6, minute: 40, second: 2, millisecond: 605),

new TimeOnly(hour: 9, minute: 45, second: 28, millisecond: 138),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 18, minute: 40, second: 26, millisecond: 111),

new TimeOnly(hour: 17, minute: 29, second: 0, millisecond: 969),

new TimeOnly(hour: 10, minute: 38, second: 10, millisecond: 297),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 134,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 13, minute: 27, second: 44, millisecond: 370),

new TimeOnly(hour: 4, minute: 56, second: 56, millisecond: 864),

new TimeOnly(hour: 7, minute: 58, second: 51, millisecond: 223),

new TimeOnly(hour: 20, minute: 46, second: 38, millisecond: 195),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 11, minute: 14, second: 3, millisecond: 185),

new TimeOnly(hour: 3, minute: 26, second: 38, millisecond: 684),

new TimeOnly(hour: 21, minute: 9, second: 5, millisecond: 672),

new TimeOnly(hour: 9, minute: 9, second: 18, millisecond: 343),

},
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 136,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 15, minute: 51, second: 0, millisecond: 69),

new TimeOnly(hour: 14, minute: 15, second: 50, millisecond: 896),

new TimeOnly(hour: 1, minute: 46, second: 53, millisecond: 378),

new TimeOnly(hour: 12, minute: 5, second: 1, millisecond: 134),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 7, minute: 13, second: 7, millisecond: 1),

new TimeOnly(hour: 14, minute: 38, second: 22, millisecond: 542),

new TimeOnly(hour: 10, minute: 58, second: 32, millisecond: 251),

new TimeOnly(hour: 2, minute: 52, second: 30, millisecond: 238),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 141,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 17, minute: 6, second: 33, millisecond: 780),

new TimeOnly(hour: 2, minute: 1, second: 16, millisecond: 215),

new TimeOnly(hour: 13, minute: 24, second: 46, millisecond: 646),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 0, minute: 24, second: 6, millisecond: 596),

new TimeOnly(hour: 17, minute: 21, second: 58, millisecond: 582),

new TimeOnly(hour: 9, minute: 2, second: 22, millisecond: 806),

},
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 148,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 17, minute: 18, second: 54, millisecond: 51),

new TimeOnly(hour: 9, minute: 45, second: 58, millisecond: 746),

new TimeOnly(hour: 6, minute: 3, second: 46, millisecond: 31),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 11, minute: 48, second: 6, millisecond: 19),

new TimeOnly(hour: 9, minute: 51, second: 20, millisecond: 546),

new TimeOnly(hour: 18, minute: 43, second: 58, millisecond: 734),

new TimeOnly(hour: 10, minute: 1, second: 49, millisecond: 410),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 12, minute: 25, second: 6, millisecond: 634),

new TimeOnly(hour: 22, minute: 28, second: 52, millisecond: 982),

new TimeOnly(hour: 22, minute: 25, second: 40, millisecond: 596),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 1, minute: 2, second: 52, millisecond: 762),

new TimeOnly(hour: 21, minute: 36, second: 53, millisecond: 307),

new TimeOnly(hour: 20, minute: 50, second: 15, millisecond: 399),

new TimeOnly(hour: 21, minute: 12, second: 9, millisecond: 514),

},
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 157,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 0, minute: 37, second: 2, millisecond: 540),

new TimeOnly(hour: 14, minute: 13, second: 11, millisecond: 816),

new TimeOnly(hour: 6, minute: 21, second: 31, millisecond: 842),

new TimeOnly(hour: 9, minute: 23, second: 19, millisecond: 531),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 159,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 19, minute: 5, second: 43, millisecond: 315),

new TimeOnly(hour: 18, minute: 38, second: 43, millisecond: 72),

new TimeOnly(hour: 18, minute: 41, second: 41, millisecond: 283),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 91,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 15, minute: 19, second: 56, millisecond: 448),

new TimeOnly(hour: 20, minute: 52, second: 39, millisecond: 640),

new TimeOnly(hour: 4, minute: 6, second: 35, millisecond: 891),

new TimeOnly(hour: 1, minute: 23, second: 1, millisecond: 725),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 166,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 2, minute: 35, second: 57, millisecond: 147),

new TimeOnly(hour: 5, minute: 2, second: 30, millisecond: 628),

new TimeOnly(hour: 13, minute: 46, second: 15, millisecond: 484),

new TimeOnly(hour: 19, minute: 19, second: 35, millisecond: 187),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 17, minute: 3, second: 1, millisecond: 295),

new TimeOnly(hour: 9, minute: 14, second: 41, millisecond: 167),

new TimeOnly(hour: 14, minute: 24, second: 37, millisecond: 704),

new TimeOnly(hour: 16, minute: 44, second: 8, millisecond: 716),

},
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 168,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 22, minute: 53, second: 46, millisecond: 443),

new TimeOnly(hour: 11, minute: 6, second: 16, millisecond: 729),

new TimeOnly(hour: 13, minute: 43, second: 11, millisecond: 649),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 13, minute: 8, second: 14, millisecond: 307),

new TimeOnly(hour: 4, minute: 3, second: 31, millisecond: 584),

new TimeOnly(hour: 22, minute: 37, second: 58, millisecond: 666),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 16, minute: 38, second: 6, millisecond: 978),

new TimeOnly(hour: 19, minute: 22, second: 21, millisecond: 852),

new TimeOnly(hour: 3, minute: 14, second: 53, millisecond: 927),

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timeonlytime_without_time_zonearray2mi(
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
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneArray)),
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
INSERT INTO public.timeonlytime_without_time_zonearray2mi(
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
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneArray)),
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

                changedRows =  ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timeonlytime_without_time_zonearray2m(
	id,
    value,
    nullablevalue,
    timeonlytime_without_time_zonearray2mi_id
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
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneArray)), 
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
                methodParametrName: "timeonlytime_without_time_zonearray2mi_id", 
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
                changedRows =  ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timeonlytime_without_time_zonearray2m(
	id,
    value,
    nullablevalue,
    timeonlytime_without_time_zonearray2mi_id
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
    timeonlytime_without_time_zonearray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timeonlytime_without_time_zonearray2m(
	id,
    value,
    nullablevalue,
    timeonlytime_without_time_zonearray2mi_id
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
    timeonlytime_without_time_zonearray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneArray)),
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
                methodParametrName: "timeonlytime_without_time_zonearray2mi_id", 
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
                List<TimeOnlytime_without_time_zoneArray2M> models = null;

                models =  ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<TimeOnlytime_without_time_zoneArray2M> models = null;

                models = await ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeOnlytime_without_time_zoneArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneArray)),
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
FROM public.timeonlytime_without_time_zonearray2m m
LEFT JOIN public.timeonlytime_without_time_zonearray2mi mi ON mi.id = m.timeonlytime_without_time_zonearray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models = await ((ITimeOnlyListtime_without_time_zoneArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.timeonlytime_without_time_zonearray2m m
LEFT JOIN public.timeonlytime_without_time_zonearray2mi mi ON mi.id = m.timeonlytime_without_time_zonearray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models =  ((ITimeOnlyListtime_without_time_zoneArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.timeonlytime_without_time_zonearray2m m
LEFT JOIN public.timeonlytime_without_time_zonearray2mi mi ON mi.id = m.timeonlytime_without_time_zonearray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneArray)),
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

                var models = await ((ITimeOnlyListtime_without_time_zoneArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    TimeOnlytime_without_time_zoneArray2M.AssertModel(models[i],_testData[i], false);
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

                var models =  ((ITimeOnlyListtime_without_time_zoneArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    TimeOnlytime_without_time_zoneArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeOnlytime_without_time_zoneArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneArray)),
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
FROM public.timeonlytime_without_time_zonearray2m m
LEFT JOIN public.timeonlytime_without_time_zonearray2mi mi ON mi.id = m.timeonlytime_without_time_zonearray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((ITimeOnlyListtime_without_time_zoneArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.timeonlytime_without_time_zonearray2m m
LEFT JOIN public.timeonlytime_without_time_zonearray2mi mi ON mi.id = m.timeonlytime_without_time_zonearray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models =  ((ITimeOnlyListtime_without_time_zoneArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.timeonlytime_without_time_zonearray2m m
LEFT JOIN public.timeonlytime_without_time_zonearray2mi mi ON mi.id = m.timeonlytime_without_time_zonearray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneArray)),
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
                var models = await ((ITimeOnlyListtime_without_time_zoneArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    TimeOnlytime_without_time_zoneArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((ITimeOnlyListtime_without_time_zoneArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    TimeOnlytime_without_time_zoneArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeOnlytime_without_time_zoneArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneArray)),
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
FROM public.timeonlytime_without_time_zonearray2m m
LEFT JOIN public.timeonlytime_without_time_zonearray2mi mi ON mi.id = m.timeonlytime_without_time_zonearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models = await ((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 29;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 20;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.timeonlytime_without_time_zonearray2m m
LEFT JOIN public.timeonlytime_without_time_zonearray2mi mi ON mi.id = m.timeonlytime_without_time_zonearray2mi_id
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
FROM public.timeonlytime_without_time_zonearray2m m
LEFT JOIN public.timeonlytime_without_time_zonearray2mi mi ON mi.id = m.timeonlytime_without_time_zonearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[4], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[5], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[6], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[7], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[8], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[5],_testData[9], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[6],_testData[10], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[7],_testData[11], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[8],_testData[12], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[9],_testData[13], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[10],_testData[14], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[11],_testData[15], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[12],_testData[16], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[13],_testData[17], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[14],_testData[18], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[15],_testData[19], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[16],_testData[20], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[17],_testData[21], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[18],_testData[22], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[19],_testData[23], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[20],_testData[24], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[21],_testData[25], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[22],_testData[26], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[23],_testData[27], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[24],_testData[28], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[3], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[4], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[5], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[6], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[7], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[5],_testData[8], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[6],_testData[9], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[7],_testData[10], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[8],_testData[11], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[9],_testData[12], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[10],_testData[13], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[11],_testData[14], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[12],_testData[15], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[13],_testData[16], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[14],_testData[17], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[15],_testData[18], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[16],_testData[19], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[17],_testData[20], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[18],_testData[21], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[19],_testData[22], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[20],_testData[23], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[21],_testData[24], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[22],_testData[25], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[23],_testData[26], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[24],_testData[27], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[25],_testData[28], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[26],_testData[29], false);
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
FROM public.timeonlytime_without_time_zonearray2m m
LEFT JOIN public.timeonlytime_without_time_zonearray2mi mi ON mi.id = m.timeonlytime_without_time_zonearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models =  ((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 48;
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
FROM public.timeonlytime_without_time_zonearray2m m
LEFT JOIN public.timeonlytime_without_time_zonearray2mi mi ON mi.id = m.timeonlytime_without_time_zonearray2mi_id
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
FROM public.timeonlytime_without_time_zonearray2m m
LEFT JOIN public.timeonlytime_without_time_zonearray2mi mi ON mi.id = m.timeonlytime_without_time_zonearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));
FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[8], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[9], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[10], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[11], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[12], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[5],_testData[13], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[6],_testData[14], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[7],_testData[15], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[8],_testData[16], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[9],_testData[17], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[10],_testData[18], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[11],_testData[19], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[12],_testData[20], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[13],_testData[21], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[14],_testData[22], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[15],_testData[23], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[16],_testData[24], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[17],_testData[25], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[18],_testData[26], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[19],_testData[27], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[20],_testData[28], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[15], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[16], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[17], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[18], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[19], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[5],_testData[20], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[6],_testData[21], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[7],_testData[22], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[8],_testData[23], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[9],_testData[24], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[10],_testData[25], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[11],_testData[26], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[12],_testData[27], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[13],_testData[28], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[14],_testData[29], false);
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
FROM public.timeonlytime_without_time_zonearray2m m
LEFT JOIN public.timeonlytime_without_time_zonearray2mi mi ON mi.id = m.timeonlytime_without_time_zonearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneArray)),
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

                var models = await ((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    TimeOnlytime_without_time_zoneArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 136;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 86;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));
TimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[24], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[25], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[26], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[27], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[28], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
TimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[16], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[17], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[18], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[19], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[20], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[5],_testData[21], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[6],_testData[22], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[7],_testData[23], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[8],_testData[24], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[9],_testData[25], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[10],_testData[26], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[11],_testData[27], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[12],_testData[28], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[13],_testData[29], false);
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

                var models =  ((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    TimeOnlytime_without_time_zoneArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 103;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 9;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));
TimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[18], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[19], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[20], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[21], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[22], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[5],_testData[23], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[6],_testData[24], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[7],_testData[25], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[8],_testData[26], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[9],_testData[27], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[10],_testData[28], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));
TimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[1], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[2], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[3], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[4], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[5], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[5],_testData[6], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[6],_testData[7], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[7],_testData[8], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[8],_testData[9], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[9],_testData[10], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[10],_testData[11], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[11],_testData[12], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[12],_testData[13], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[13],_testData[14], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[14],_testData[15], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[15],_testData[16], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[16],_testData[17], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[17],_testData[18], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[18],_testData[19], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[19],_testData[20], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[20],_testData[21], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[21],_testData[22], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[22],_testData[23], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[23],_testData[24], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[24],_testData[25], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[25],_testData[26], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[26],_testData[27], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[27],_testData[28], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeOnlytime_without_time_zoneArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneArray)),
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
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneArray)),
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
FROM public.timeonlytime_without_time_zonearray2m m
LEFT JOIN public.timeonlytime_without_time_zonearray2mi mi ON mi.id = m.timeonlytime_without_time_zonearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.timeonlytime_without_time_zonearray2m m
LEFT JOIN public.timeonlytime_without_time_zonearray2mi mi ON mi.id = m.timeonlytime_without_time_zonearray2mi_id
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
FROM public.timeonlytime_without_time_zonearray2m m
LEFT JOIN public.timeonlytime_without_time_zonearray2mi mi ON mi.id = m.timeonlytime_without_time_zonearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 11, query1, 71, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));
FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[2], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[3], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[4], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[5], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[6], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[5],_testData[7], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[6],_testData[8], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[7],_testData[9], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[8],_testData[10], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[9],_testData[11], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[10],_testData[12], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[11],_testData[13], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[12],_testData[14], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[13],_testData[15], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[14],_testData[16], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[15],_testData[17], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[16],_testData[18], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[17],_testData[19], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[18],_testData[20], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[19],_testData[21], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[20],_testData[22], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[21],_testData[23], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[22],_testData[24], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[23],_testData[25], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[24],_testData[26], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[25],_testData[27], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[26],_testData[28], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[12], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[13], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[14], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[15], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[16], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[5],_testData[17], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[6],_testData[18], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[7],_testData[19], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[8],_testData[20], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[9],_testData[21], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[10],_testData[22], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[11],_testData[23], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[12],_testData[24], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[13],_testData[25], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[14],_testData[26], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[15],_testData[27], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[16],_testData[28], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[17],_testData[29], false);
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
FROM public.timeonlytime_without_time_zonearray2m m
LEFT JOIN public.timeonlytime_without_time_zonearray2mi mi ON mi.id = m.timeonlytime_without_time_zonearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.timeonlytime_without_time_zonearray2m m
LEFT JOIN public.timeonlytime_without_time_zonearray2mi mi ON mi.id = m.timeonlytime_without_time_zonearray2mi_id
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
FROM public.timeonlytime_without_time_zonearray2m m
LEFT JOIN public.timeonlytime_without_time_zonearray2mi mi ON mi.id = m.timeonlytime_without_time_zonearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionDynQuerySelectModelBatch(connection, 84, query1, 75, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[15], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[16], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[17], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[18], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[19], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[5],_testData[20], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[6],_testData[21], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[7],_testData[22], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[8],_testData[23], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[9],_testData[24], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[10],_testData[25], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[11],_testData[26], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[12],_testData[27], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[13],_testData[28], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));
FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[13], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[14], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[15], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[16], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[17], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[5],_testData[18], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[6],_testData[19], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[7],_testData[20], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[8],_testData[21], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[9],_testData[22], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[10],_testData[23], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[11],_testData[24], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[12],_testData[25], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[13],_testData[26], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[14],_testData[27], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[15],_testData[28], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[16],_testData[29], false);
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
FROM public.timeonlytime_without_time_zonearray2m m
LEFT JOIN public.timeonlytime_without_time_zonearray2mi mi ON mi.id = m.timeonlytime_without_time_zonearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneArray)),
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
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneArray)),
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
                var models = await ((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    TimeOnlytime_without_time_zoneArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionSelectModelBatchAsync(connection, 71, 159))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
TimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[12], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[13], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[14], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[15], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[16], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[5],_testData[17], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[6],_testData[18], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[7],_testData[19], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[8],_testData[20], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[9],_testData[21], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[10],_testData[22], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[11],_testData[23], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[12],_testData[24], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[13],_testData[25], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[14],_testData[26], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[15],_testData[27], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[16],_testData[28], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
TimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[28], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[29], false);
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
                var models =  ((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    TimeOnlytime_without_time_zoneArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionSelectModelBatch(connection, 148, 60))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));
TimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[26], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[27], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[28], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));
TimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[10], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[11], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[12], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[13], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[14], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[5],_testData[15], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[6],_testData[16], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[7],_testData[17], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[8],_testData[18], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[9],_testData[19], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[10],_testData[20], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[11],_testData[21], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[12],_testData[22], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[13],_testData[23], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[14],_testData[24], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[15],_testData[25], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[16],_testData[26], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[17],_testData[27], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[18],_testData[28], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[19],_testData[29], false);
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
                await using var cmd = await ((ITimeOnlyListtime_without_time_zoneArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((ITimeOnlyListtime_without_time_zoneArray)this).SetDbConnectionSelectModelParametrs(cmd, 95);
                var models = await ((ITimeOnlyListtime_without_time_zoneArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(13));
TimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[17], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[18], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[19], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[20], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[21], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[5],_testData[22], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[6],_testData[23], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[7],_testData[24], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[8],_testData[25], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[9],_testData[26], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[10],_testData[27], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[11],_testData[28], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[12],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ITimeOnlyListtime_without_time_zoneArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((ITimeOnlyListtime_without_time_zoneArray)this).SetDbConnectionSelectModelParametrs(cmd, 125);
                var models =  ((ITimeOnlyListtime_without_time_zoneArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(9));
TimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[21], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[22], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[23], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[24], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[25], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[5],_testData[26], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[6],_testData[27], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[7],_testData[28], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[8],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_timeonlytime_without_time_zonearray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneArray2MI)],
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
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneArray))]
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
FROM public.binary_timeonlytime_without_time_zonearray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<TimeOnlytime_without_time_zoneArray2MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((ITimeOnlyListtime_without_time_zoneArray)this).ImportModelInner(connection, importCollection);
                var models = ((ITimeOnlyListtime_without_time_zoneArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeOnlytime_without_time_zoneArray2MI.AssertModel(actual, expect, false);
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
                await ((ITimeOnlyListtime_without_time_zoneArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((ITimeOnlyListtime_without_time_zoneArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeOnlytime_without_time_zoneArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_timeonlytime_without_time_zonearray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
timeonlytime_without_time_zonearray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneArray2M)],
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
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneArray))]
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
FROM public.binary_timeonlytime_without_time_zonearray2m m
LEFT JOIN public.binary_timeonlytime_without_time_zonearray2mi mi ON mi.id = m.timeonlytime_without_time_zonearray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<TimeOnlytime_without_time_zoneArray2M>(15);

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
                ((ITimeOnlyListtime_without_time_zoneArray)this).ImportModel(connection, importCollection);
                var models = ((ITimeOnlyListtime_without_time_zoneArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                TimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[0], false);
                TimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[1], false);
                TimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[2], false);
                TimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[3], false);
                TimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[4], false);
                TimeOnlytime_without_time_zoneArray2M.AssertModel(models[5],_testData[5], false);
                TimeOnlytime_without_time_zoneArray2M.AssertModel(models[6],_testData[6], false);
                TimeOnlytime_without_time_zoneArray2M.AssertModel(models[7],_testData[7], false);
                TimeOnlytime_without_time_zoneArray2M.AssertModel(models[8],_testData[8], false);
                TimeOnlytime_without_time_zoneArray2M.AssertModel(models[9],_testData[9], false);
                TimeOnlytime_without_time_zoneArray2M.AssertModel(models[10],_testData[10], false);
                TimeOnlytime_without_time_zoneArray2M.AssertModel(models[11],_testData[11], false);
                TimeOnlytime_without_time_zoneArray2M.AssertModel(models[12],_testData[12], false);
                TimeOnlytime_without_time_zoneArray2M.AssertModel(models[13],_testData[13], false);
                TimeOnlytime_without_time_zoneArray2M.AssertModel(models[14],_testData[14], false);
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
                await ((ITimeOnlyListtime_without_time_zoneArray)this).ImportModelAsync(connection, importCollection);
                models = await ((ITimeOnlyListtime_without_time_zoneArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                TimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[0], false);
                TimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[1], false);
                TimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[2], false);
                TimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[3], false);
                TimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[4], false);
                TimeOnlytime_without_time_zoneArray2M.AssertModel(models[5],_testData[5], false);
                TimeOnlytime_without_time_zoneArray2M.AssertModel(models[6],_testData[6], false);
                TimeOnlytime_without_time_zoneArray2M.AssertModel(models[7],_testData[7], false);
                TimeOnlytime_without_time_zoneArray2M.AssertModel(models[8],_testData[8], false);
                TimeOnlytime_without_time_zoneArray2M.AssertModel(models[9],_testData[9], false);
                TimeOnlytime_without_time_zoneArray2M.AssertModel(models[10],_testData[10], false);
                TimeOnlytime_without_time_zoneArray2M.AssertModel(models[11],_testData[11], false);
                TimeOnlytime_without_time_zoneArray2M.AssertModel(models[12],_testData[12], false);
                TimeOnlytime_without_time_zoneArray2M.AssertModel(models[13],_testData[13], false);
                TimeOnlytime_without_time_zoneArray2M.AssertModel(models[14],_testData[14], false);
                TimeOnlytime_without_time_zoneArray2M.AssertModel(models[15],_testData[15], false);
                TimeOnlytime_without_time_zoneArray2M.AssertModel(models[16],_testData[16], false);
                TimeOnlytime_without_time_zoneArray2M.AssertModel(models[17],_testData[17], false);
                TimeOnlytime_without_time_zoneArray2M.AssertModel(models[18],_testData[18], false);
                TimeOnlytime_without_time_zoneArray2M.AssertModel(models[19],_testData[19], false);
                TimeOnlytime_without_time_zoneArray2M.AssertModel(models[20],_testData[20], false);
                TimeOnlytime_without_time_zoneArray2M.AssertModel(models[21],_testData[21], false);
                TimeOnlytime_without_time_zoneArray2M.AssertModel(models[22],_testData[22], false);
                TimeOnlytime_without_time_zoneArray2M.AssertModel(models[23],_testData[23], false);
                TimeOnlytime_without_time_zoneArray2M.AssertModel(models[24],_testData[24], false);
                TimeOnlytime_without_time_zoneArray2M.AssertModel(models[25],_testData[25], false);
                TimeOnlytime_without_time_zoneArray2M.AssertModel(models[26],_testData[26], false);
                TimeOnlytime_without_time_zoneArray2M.AssertModel(models[27],_testData[27], false);
                TimeOnlytime_without_time_zoneArray2M.AssertModel(models[28],_testData[28], false);
                TimeOnlytime_without_time_zoneArray2M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_timeonlytime_without_time_zonearray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    timeonlytime_without_time_zonearray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneArray2M)],
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
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((ITimeOnlyListtime_without_time_zoneArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    TimeOnlytime_without_time_zoneArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((ITimeOnlyListtime_without_time_zoneArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    TimeOnlytime_without_time_zoneArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_timeonlytime_without_time_zonearray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneArray2MI)],
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
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((ITimeOnlyListtime_without_time_zoneArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    TimeOnlytime_without_time_zoneArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((ITimeOnlyListtime_without_time_zoneArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    TimeOnlytime_without_time_zoneArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

