

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
    Id = 6,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 13, minute: 22, second: 52, millisecond: 892),

new TimeOnly(hour: 21, minute: 37, second: 19, millisecond: 925),

new TimeOnly(hour: 4, minute: 9, second: 2, millisecond: 950),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 4, minute: 27, second: 3, millisecond: 502),

new TimeOnly(hour: 0, minute: 6, second: 38, millisecond: 343),

new TimeOnly(hour: 7, minute: 26, second: 19, millisecond: 950),

new TimeOnly(hour: 12, minute: 49, second: 1, millisecond: 428),

},
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 8, minute: 7, second: 43, millisecond: 601),

new TimeOnly(hour: 18, minute: 6, second: 25, millisecond: 270),

new TimeOnly(hour: 15, minute: 29, second: 56, millisecond: 178),

new TimeOnly(hour: 8, minute: 15, second: 44, millisecond: 502),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 1,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 12, minute: 35, second: 43, millisecond: 700),

new TimeOnly(hour: 22, minute: 16, second: 52, millisecond: 125),

new TimeOnly(hour: 9, minute: 39, second: 35, millisecond: 357),

new TimeOnly(hour: 7, minute: 57, second: 55, millisecond: 368),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 18, minute: 47, second: 18, millisecond: 395),

new TimeOnly(hour: 15, minute: 6, second: 38, millisecond: 400),

new TimeOnly(hour: 9, minute: 32, second: 32, millisecond: 568),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 15, minute: 0, second: 31, millisecond: 131),

new TimeOnly(hour: 19, minute: 22, second: 26, millisecond: 585),

new TimeOnly(hour: 14, minute: 12, second: 24, millisecond: 306),

},
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 20, minute: 24, second: 28, millisecond: 854),

new TimeOnly(hour: 15, minute: 44, second: 24, millisecond: 883),

new TimeOnly(hour: 12, minute: 32, second: 3, millisecond: 500),

new TimeOnly(hour: 2, minute: 1, second: 9, millisecond: 132),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 3, minute: 9, second: 41, millisecond: 343),

new TimeOnly(hour: 15, minute: 0, second: 45, millisecond: 585),

new TimeOnly(hour: 9, minute: 23, second: 49, millisecond: 949),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 12, minute: 44, second: 10, millisecond: 213),

new TimeOnly(hour: 12, minute: 0, second: 42, millisecond: 950),

new TimeOnly(hour: 19, minute: 30, second: 29, millisecond: 351),

},
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 8, minute: 31, second: 31, millisecond: 720),

new TimeOnly(hour: 8, minute: 43, second: 35, millisecond: 650),

new TimeOnly(hour: 4, minute: 22, second: 26, millisecond: 694),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 7, minute: 39, second: 5, millisecond: 201),

new TimeOnly(hour: 11, minute: 2, second: 9, millisecond: 459),

new TimeOnly(hour: 21, minute: 57, second: 51, millisecond: 0),

new TimeOnly(hour: 7, minute: 33, second: 56, millisecond: 993),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 13, minute: 29, second: 46, millisecond: 416),

new TimeOnly(hour: 7, minute: 43, second: 30, millisecond: 280),

new TimeOnly(hour: 20, minute: 18, second: 42, millisecond: 321),

new TimeOnly(hour: 22, minute: 1, second: 7, millisecond: 369),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 18, minute: 21, second: 30, millisecond: 939),

new TimeOnly(hour: 19, minute: 10, second: 19, millisecond: 586),

new TimeOnly(hour: 20, minute: 21, second: 26, millisecond: 586),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 22, minute: 18, second: 9, millisecond: 60),

new TimeOnly(hour: 14, minute: 12, second: 34, millisecond: 839),

new TimeOnly(hour: 15, minute: 51, second: 10, millisecond: 951),

},
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 3, minute: 41, second: 12, millisecond: 850),

new TimeOnly(hour: 14, minute: 44, second: 3, millisecond: 760),

new TimeOnly(hour: 19, minute: 2, second: 37, millisecond: 301),

new TimeOnly(hour: 9, minute: 17, second: 32, millisecond: 631),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 21, minute: 45, second: 27, millisecond: 203),

new TimeOnly(hour: 17, minute: 26, second: 46, millisecond: 932),

new TimeOnly(hour: 11, minute: 28, second: 28, millisecond: 493),

new TimeOnly(hour: 6, minute: 54, second: 56, millisecond: 243),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 3, minute: 53, second: 50, millisecond: 31),

new TimeOnly(hour: 3, minute: 23, second: 17, millisecond: 508),

new TimeOnly(hour: 16, minute: 37, second: 15, millisecond: 985),

new TimeOnly(hour: 10, minute: 26, second: 7, millisecond: 270),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 17, minute: 58, second: 54, millisecond: 570),

new TimeOnly(hour: 13, minute: 12, second: 16, millisecond: 667),

new TimeOnly(hour: 0, minute: 21, second: 12, millisecond: 181),

new TimeOnly(hour: 18, minute: 18, second: 58, millisecond: 551),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 7, minute: 20, second: 4, millisecond: 208),

new TimeOnly(hour: 3, minute: 51, second: 14, millisecond: 250),

new TimeOnly(hour: 21, minute: 25, second: 8, millisecond: 21),

},
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 12, minute: 7, second: 29, millisecond: 325),

new TimeOnly(hour: 16, minute: 10, second: 40, millisecond: 769),

new TimeOnly(hour: 11, minute: 12, second: 48, millisecond: 292),

new TimeOnly(hour: 6, minute: 25, second: 42, millisecond: 440),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 0, minute: 54, second: 44, millisecond: 672),

new TimeOnly(hour: 21, minute: 39, second: 48, millisecond: 585),

new TimeOnly(hour: 13, minute: 42, second: 50, millisecond: 360),

new TimeOnly(hour: 7, minute: 3, second: 17, millisecond: 917),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 11, minute: 54, second: 51, millisecond: 833),

new TimeOnly(hour: 7, minute: 38, second: 13, millisecond: 14),

new TimeOnly(hour: 18, minute: 42, second: 38, millisecond: 419),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 21, minute: 44, second: 13, millisecond: 432),

new TimeOnly(hour: 1, minute: 35, second: 52, millisecond: 566),

new TimeOnly(hour: 19, minute: 58, second: 39, millisecond: 122),

new TimeOnly(hour: 19, minute: 8, second: 15, millisecond: 370),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 19, minute: 8, second: 41, millisecond: 319),

new TimeOnly(hour: 14, minute: 15, second: 2, millisecond: 432),

new TimeOnly(hour: 8, minute: 47, second: 30, millisecond: 101),

},
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 18, minute: 52, second: 14, millisecond: 279),

new TimeOnly(hour: 5, minute: 52, second: 25, millisecond: 953),

new TimeOnly(hour: 20, minute: 55, second: 35, millisecond: 859),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 1, minute: 52, second: 26, millisecond: 315),

new TimeOnly(hour: 15, minute: 49, second: 36, millisecond: 440),

new TimeOnly(hour: 21, minute: 43, second: 52, millisecond: 54),

new TimeOnly(hour: 16, minute: 9, second: 55, millisecond: 563),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 14, minute: 42, second: 4, millisecond: 536),

new TimeOnly(hour: 3, minute: 0, second: 21, millisecond: 737),

new TimeOnly(hour: 22, minute: 4, second: 49, millisecond: 139),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 14, minute: 42, second: 47, millisecond: 306),

new TimeOnly(hour: 5, minute: 24, second: 28, millisecond: 652),

new TimeOnly(hour: 14, minute: 3, second: 15, millisecond: 255),

},
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 17, minute: 46, second: 13, millisecond: 203),

new TimeOnly(hour: 12, minute: 34, second: 2, millisecond: 534),

new TimeOnly(hour: 2, minute: 52, second: 33, millisecond: 436),

new TimeOnly(hour: 22, minute: 15, second: 41, millisecond: 232),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 17, minute: 15, second: 1, millisecond: 329),

new TimeOnly(hour: 4, minute: 16, second: 17, millisecond: 10),

new TimeOnly(hour: 5, minute: 26, second: 27, millisecond: 578),

new TimeOnly(hour: 15, minute: 9, second: 56, millisecond: 310),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 1, minute: 8, second: 49, millisecond: 857),

new TimeOnly(hour: 0, minute: 40, second: 48, millisecond: 723),

new TimeOnly(hour: 7, minute: 15, second: 58, millisecond: 314),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 19, minute: 42, second: 49, millisecond: 989),

new TimeOnly(hour: 12, minute: 39, second: 25, millisecond: 508),

new TimeOnly(hour: 18, minute: 41, second: 20, millisecond: 538),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 7, minute: 36, second: 2, millisecond: 5),

new TimeOnly(hour: 3, minute: 50, second: 42, millisecond: 385),

new TimeOnly(hour: 3, minute: 44, second: 4, millisecond: 467),

new TimeOnly(hour: 14, minute: 17, second: 46, millisecond: 421),

},
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 10, minute: 26, second: 21, millisecond: 579),

new TimeOnly(hour: 9, minute: 23, second: 0, millisecond: 673),

new TimeOnly(hour: 2, minute: 41, second: 19, millisecond: 668),

new TimeOnly(hour: 22, minute: 29, second: 57, millisecond: 739),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 14, minute: 8, second: 52, millisecond: 930),

new TimeOnly(hour: 14, minute: 26, second: 13, millisecond: 615),

new TimeOnly(hour: 6, minute: 16, second: 4, millisecond: 136),

new TimeOnly(hour: 1, minute: 18, second: 45, millisecond: 205),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 20, minute: 33, second: 11, millisecond: 887),

new TimeOnly(hour: 6, minute: 42, second: 28, millisecond: 435),

new TimeOnly(hour: 18, minute: 35, second: 29, millisecond: 304),

new TimeOnly(hour: 0, minute: 11, second: 52, millisecond: 324),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 19, minute: 3, second: 18, millisecond: 252),

new TimeOnly(hour: 12, minute: 34, second: 26, millisecond: 932),

new TimeOnly(hour: 22, minute: 4, second: 12, millisecond: 916),

new TimeOnly(hour: 15, minute: 25, second: 56, millisecond: 48),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 97,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 19, minute: 42, second: 37, millisecond: 27),

new TimeOnly(hour: 21, minute: 38, second: 16, millisecond: 523),

new TimeOnly(hour: 11, minute: 7, second: 34, millisecond: 108),

new TimeOnly(hour: 15, minute: 6, second: 11, millisecond: 327),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 0, minute: 42, second: 33, millisecond: 138),

new TimeOnly(hour: 18, minute: 7, second: 24, millisecond: 440),

new TimeOnly(hour: 12, minute: 43, second: 9, millisecond: 391),

new TimeOnly(hour: 9, minute: 48, second: 17, millisecond: 37),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 17, minute: 34, second: 39, millisecond: 814),

new TimeOnly(hour: 4, minute: 50, second: 19, millisecond: 910),

new TimeOnly(hour: 17, minute: 32, second: 21, millisecond: 658),

new TimeOnly(hour: 16, minute: 20, second: 48, millisecond: 491),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 14, minute: 31, second: 55, millisecond: 770),

new TimeOnly(hour: 14, minute: 25, second: 49, millisecond: 971),

new TimeOnly(hour: 0, minute: 1, second: 7, millisecond: 38),

new TimeOnly(hour: 15, minute: 42, second: 34, millisecond: 140),

},
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 107,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 19, minute: 37, second: 47, millisecond: 985),

new TimeOnly(hour: 11, minute: 7, second: 35, millisecond: 155),

new TimeOnly(hour: 4, minute: 0, second: 4, millisecond: 80),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 16, minute: 22, second: 56, millisecond: 948),

new TimeOnly(hour: 1, minute: 53, second: 39, millisecond: 765),

new TimeOnly(hour: 21, minute: 31, second: 23, millisecond: 345),

new TimeOnly(hour: 22, minute: 58, second: 6, millisecond: 58),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 111,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 10, minute: 19, second: 0, millisecond: 976),

new TimeOnly(hour: 7, minute: 18, second: 9, millisecond: 381),

new TimeOnly(hour: 5, minute: 33, second: 24, millisecond: 537),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 12, minute: 7, second: 13, millisecond: 384),

new TimeOnly(hour: 6, minute: 30, second: 0, millisecond: 198),

new TimeOnly(hour: 20, minute: 37, second: 54, millisecond: 231),

},
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 116,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 11, minute: 32, second: 8, millisecond: 681),

new TimeOnly(hour: 12, minute: 4, second: 47, millisecond: 915),

new TimeOnly(hour: 21, minute: 36, second: 48, millisecond: 825),

new TimeOnly(hour: 6, minute: 19, second: 17, millisecond: 495),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 22, minute: 49, second: 43, millisecond: 539),

new TimeOnly(hour: 22, minute: 26, second: 25, millisecond: 836),

new TimeOnly(hour: 3, minute: 9, second: 44, millisecond: 753),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 0, minute: 23, second: 32, millisecond: 608),

new TimeOnly(hour: 0, minute: 19, second: 21, millisecond: 446),

new TimeOnly(hour: 16, minute: 42, second: 6, millisecond: 888),

new TimeOnly(hour: 8, minute: 34, second: 24, millisecond: 207),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 20, minute: 39, second: 14, millisecond: 199),

new TimeOnly(hour: 17, minute: 55, second: 45, millisecond: 33),

new TimeOnly(hour: 13, minute: 0, second: 6, millisecond: 932),

new TimeOnly(hour: 17, minute: 11, second: 28, millisecond: 146),

},
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 123,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 19, minute: 28, second: 13, millisecond: 315),

new TimeOnly(hour: 0, minute: 53, second: 58, millisecond: 141),

new TimeOnly(hour: 20, minute: 18, second: 47, millisecond: 722),

new TimeOnly(hour: 14, minute: 6, second: 42, millisecond: 990),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 12, minute: 47, second: 4, millisecond: 717),

new TimeOnly(hour: 8, minute: 23, second: 31, millisecond: 129),

new TimeOnly(hour: 20, minute: 19, second: 6, millisecond: 577),

new TimeOnly(hour: 15, minute: 58, second: 2, millisecond: 458),

},
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 131,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 3, minute: 34, second: 4, millisecond: 779),

new TimeOnly(hour: 7, minute: 22, second: 2, millisecond: 281),

new TimeOnly(hour: 19, minute: 21, second: 9, millisecond: 316),

new TimeOnly(hour: 18, minute: 51, second: 11, millisecond: 644),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 18, minute: 0, second: 58, millisecond: 6),

new TimeOnly(hour: 10, minute: 41, second: 33, millisecond: 96),

new TimeOnly(hour: 22, minute: 18, second: 44, millisecond: 383),

new TimeOnly(hour: 18, minute: 15, second: 20, millisecond: 701),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 12, minute: 28, second: 42, millisecond: 936),

new TimeOnly(hour: 17, minute: 53, second: 11, millisecond: 639),

new TimeOnly(hour: 10, minute: 55, second: 18, millisecond: 195),

},
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 139,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 3, minute: 32, second: 47, millisecond: 576),

new TimeOnly(hour: 17, minute: 45, second: 15, millisecond: 256),

new TimeOnly(hour: 7, minute: 27, second: 14, millisecond: 826),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 4, minute: 13, second: 33, millisecond: 499),

new TimeOnly(hour: 16, minute: 46, second: 36, millisecond: 324),

new TimeOnly(hour: 18, minute: 40, second: 11, millisecond: 394),

new TimeOnly(hour: 8, minute: 46, second: 30, millisecond: 334),

},
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 140,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 15, minute: 49, second: 23, millisecond: 259),

new TimeOnly(hour: 20, minute: 16, second: 37, millisecond: 142),

new TimeOnly(hour: 5, minute: 22, second: 13, millisecond: 925),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 10, minute: 50, second: 42, millisecond: 41),

new TimeOnly(hour: 10, minute: 42, second: 20, millisecond: 844),

new TimeOnly(hour: 22, minute: 42, second: 38, millisecond: 167),

new TimeOnly(hour: 18, minute: 16, second: 44, millisecond: 825),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 8, minute: 51, second: 32, millisecond: 163),

new TimeOnly(hour: 8, minute: 29, second: 52, millisecond: 249),

new TimeOnly(hour: 7, minute: 37, second: 23, millisecond: 487),

},
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 148,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 12, minute: 53, second: 11, millisecond: 480),

new TimeOnly(hour: 8, minute: 10, second: 45, millisecond: 367),

new TimeOnly(hour: 0, minute: 38, second: 32, millisecond: 84),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 156,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 12, minute: 55, second: 10, millisecond: 733),

new TimeOnly(hour: 7, minute: 10, second: 1, millisecond: 635),

new TimeOnly(hour: 12, minute: 38, second: 27, millisecond: 23),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 18, minute: 57, second: 31, millisecond: 928),

new TimeOnly(hour: 19, minute: 48, second: 8, millisecond: 599),

new TimeOnly(hour: 10, minute: 56, second: 38, millisecond: 585),

new TimeOnly(hour: 15, minute: 24, second: 16, millisecond: 341),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 4, minute: 43, second: 42, millisecond: 430),

new TimeOnly(hour: 6, minute: 37, second: 21, millisecond: 865),

new TimeOnly(hour: 2, minute: 37, second: 24, millisecond: 105),

new TimeOnly(hour: 7, minute: 30, second: 42, millisecond: 747),

},
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 162,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 14, minute: 31, second: 38, millisecond: 832),

new TimeOnly(hour: 21, minute: 21, second: 43, millisecond: 556),

new TimeOnly(hour: 10, minute: 50, second: 29, millisecond: 225),

new TimeOnly(hour: 18, minute: 27, second: 9, millisecond: 164),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 4, minute: 20, second: 8, millisecond: 111),

new TimeOnly(hour: 17, minute: 21, second: 55, millisecond: 453),

new TimeOnly(hour: 2, minute: 47, second: 45, millisecond: 14),

},
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 168,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 16, minute: 8, second: 52, millisecond: 924),

new TimeOnly(hour: 1, minute: 39, second: 22, millisecond: 580),

new TimeOnly(hour: 16, minute: 37, second: 10, millisecond: 90),

new TimeOnly(hour: 0, minute: 24, second: 39, millisecond: 544),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 19, minute: 43, second: 13, millisecond: 42),

new TimeOnly(hour: 12, minute: 39, second: 2, millisecond: 587),

new TimeOnly(hour: 19, minute: 27, second: 23, millisecond: 500),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 12, minute: 22, second: 23, millisecond: 983),

new TimeOnly(hour: 10, minute: 15, second: 53, millisecond: 467),

new TimeOnly(hour: 15, minute: 48, second: 32, millisecond: 423),

new TimeOnly(hour: 17, minute: 13, second: 56, millisecond: 440),

},
},
    NullableValue = null,
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
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeOnlytime_without_time_zoneArray2M), typeof(FlatTimeOnlytime_without_time_zoneArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneArray)),
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
FROM public.timeonlytime_without_time_zonearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatTimeOnlytime_without_time_zoneArray2M>();
                var models2 = new List<FlatTimeOnlytime_without_time_zoneArray2M>();
                await ((ITimeOnlyListtime_without_time_zoneArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.timeonlytime_without_time_zonearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatTimeOnlytime_without_time_zoneArray2M>();
                var models2 = new List<FlatTimeOnlytime_without_time_zoneArray2M>();
                ((ITimeOnlyListtime_without_time_zoneArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

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
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((ITimeOnlyListtime_without_time_zoneArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
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
                var models = ((ITimeOnlyListtime_without_time_zoneArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    TimeOnlytime_without_time_zoneArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeOnlytime_without_time_zoneArray2M), typeof(FlatTimeOnlytime_without_time_zoneArray2M)],
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
FROM public.timeonlytime_without_time_zonearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatTimeOnlytime_without_time_zoneArray2M>();
                var models2 = new List<FlatTimeOnlytime_without_time_zoneArray2M>();
                await ((ITimeOnlyListtime_without_time_zoneArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.timeonlytime_without_time_zonearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatTimeOnlytime_without_time_zoneArray2M>();
                var models2 = new List<FlatTimeOnlytime_without_time_zoneArray2M>();
                ((ITimeOnlyListtime_without_time_zoneArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models2[i],_testData[i], false);
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
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((ITimeOnlyListtime_without_time_zoneArray)this).DynQuerySelectModel(connection,  query, 0);
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
                var models = ((ITimeOnlyListtime_without_time_zoneArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    TimeOnlytime_without_time_zoneArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeOnlytime_without_time_zoneArray2M), typeof(FlatTimeOnlytime_without_time_zoneArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
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
FROM public.timeonlytime_without_time_zonearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatTimeOnlytime_without_time_zoneArray2M>();
                var models2 = new List<FlatTimeOnlytime_without_time_zoneArray2M>();
                await((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models2[i],_testData[i], false);
                }
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
FROM public.timeonlytime_without_time_zonearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatTimeOnlytime_without_time_zoneArray2M>();
                var models2 = new List<FlatTimeOnlytime_without_time_zoneArray2M>();
                ((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models2[i],_testData[i], false);
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
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
                parametr1.Value = 69;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 148;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.timeonlytime_without_time_zonearray2m m
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
                        Assert.That(models, Has.Count.EqualTo(16));
FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[14], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[15], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[16], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[17], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[18], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[5],_testData[19], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[6],_testData[20], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[7],_testData[21], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[8],_testData[22], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[9],_testData[23], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[10],_testData[24], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[11],_testData[25], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[12],_testData[26], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[13],_testData[27], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[14],_testData[28], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));
FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[27], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[28], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[29], false);
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
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
                parametr1.Value = 55;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 48;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.timeonlytime_without_time_zonearray2m m
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
                        Assert.That(models, Has.Count.EqualTo(19));
FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[11], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[12], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[13], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[14], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[15], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[5],_testData[16], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[6],_testData[17], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[7],_testData[18], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[8],_testData[19], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[9],_testData[20], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[10],_testData[21], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[11],_testData[22], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[12],_testData[23], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[13],_testData[24], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[14],_testData[25], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[15],_testData[26], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[16],_testData[27], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[17],_testData[28], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));
FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[10], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[11], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[12], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[13], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[14], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[5],_testData[15], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[6],_testData[16], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[7],_testData[17], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[8],_testData[18], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[9],_testData[19], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[10],_testData[20], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[11],_testData[21], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[12],_testData[22], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[13],_testData[23], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[14],_testData[24], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[15],_testData[25], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[16],_testData[26], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[17],_testData[27], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[18],_testData[28], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[19],_testData[29], false);
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
                var models = await((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
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
                parametr1.Value = 97;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 6;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
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
                var models = ((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
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
                parametr1.Value = 32;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 12;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
TimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[6], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[7], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[8], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[9], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[10], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[5],_testData[11], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[6],_testData[12], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[7],_testData[13], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[8],_testData[14], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[9],_testData[15], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[10],_testData[16], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[11],_testData[17], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[12],_testData[18], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[13],_testData[19], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[14],_testData[20], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[15],_testData[21], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[16],_testData[22], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[17],_testData[23], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[18],_testData[24], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[19],_testData[25], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[20],_testData[26], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[21],_testData[27], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[22],_testData[28], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));
TimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[2], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[3], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[4], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[5], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[6], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[5],_testData[7], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[6],_testData[8], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[7],_testData[9], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[8],_testData[10], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[9],_testData[11], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[10],_testData[12], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[11],_testData[13], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[12],_testData[14], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[13],_testData[15], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[14],_testData[16], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[15],_testData[17], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[16],_testData[18], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[17],_testData[19], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[18],_testData[20], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[19],_testData[21], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[20],_testData[22], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[21],_testData[23], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[22],_testData[24], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[23],_testData[25], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[24],_testData[26], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[25],_testData[27], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[26],_testData[28], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeOnlytime_without_time_zoneArray2M), typeof(FlatTimeOnlytime_without_time_zoneArray2M)],
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
        private void DbConnectionMMDynQuerySelectModelConfig()
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
FROM public.timeonlytime_without_time_zonearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatTimeOnlytime_without_time_zoneArray2M>();
                var models2 = new List<FlatTimeOnlytime_without_time_zoneArray2M>();
                await((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models2[i],_testData[i], false);
                }
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
FROM public.timeonlytime_without_time_zonearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatTimeOnlytime_without_time_zoneArray2M>();
                var models2 = new List<FlatTimeOnlytime_without_time_zoneArray2M>();
                ((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models2[i],_testData[i], false);
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 29, query1, 74, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));
FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[5], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[6], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[7], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[8], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[9], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[5],_testData[10], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[6],_testData[11], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[7],_testData[12], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[8],_testData[13], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[9],_testData[14], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[10],_testData[15], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[11],_testData[16], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[12],_testData[17], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[13],_testData[18], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[14],_testData[19], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[15],_testData[20], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[16],_testData[21], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[17],_testData[22], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[18],_testData[23], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[19],_testData[24], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[20],_testData[25], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[21],_testData[26], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[22],_testData[27], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[23],_testData[28], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[24],_testData[29], false);
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionDynQuerySelectModelBatch(connection, 80, query1, 107, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[16], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[17], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[18], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[19], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[20], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[5],_testData[21], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[6],_testData[22], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[7],_testData[23], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[8],_testData[24], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[9],_testData[25], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[10],_testData[26], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[11],_testData[27], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[12],_testData[28], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));
FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[20], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[21], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[22], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[23], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[24], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[5],_testData[25], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[6],_testData[26], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[7],_testData[27], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[8],_testData[28], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[9],_testData[29], false);
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
                var models = await((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionSelectModelAsync(connection, 0);
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
                foreach(var batchResult in await ((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionSelectModelBatchAsync(connection, 131, 156))
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
                var models = ((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionSelectModel(connection, 0);
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
                foreach(var batchResult in  ((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionSelectModelBatch(connection, 111, 69))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));
TimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[21], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[22], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[23], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[24], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[25], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[5],_testData[26], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[6],_testData[27], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[7],_testData[28], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
TimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[14], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[15], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[16], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[17], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[18], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[5],_testData[19], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[6],_testData[20], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[7],_testData[21], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[8],_testData[22], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[9],_testData[23], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[10],_testData[24], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[11],_testData[25], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[12],_testData[26], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[13],_testData[27], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[14],_testData[28], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[15],_testData[29], false);
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
                ((ITimeOnlyListtime_without_time_zoneArray)this).SetDbConnectionSelectModelParametrs(cmd, 29);
                var models = await ((ITimeOnlyListtime_without_time_zoneArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(25));
TimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[5], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[6], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[7], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[8], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[9], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[5],_testData[10], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[6],_testData[11], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[7],_testData[12], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[8],_testData[13], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[9],_testData[14], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[10],_testData[15], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[11],_testData[16], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[12],_testData[17], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[13],_testData[18], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[14],_testData[19], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[15],_testData[20], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[16],_testData[21], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[17],_testData[22], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[18],_testData[23], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[19],_testData[24], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[20],_testData[25], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[21],_testData[26], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[22],_testData[27], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[23],_testData[28], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[24],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ITimeOnlyListtime_without_time_zoneArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((ITimeOnlyListtime_without_time_zoneArray)this).SetDbConnectionSelectModelParametrs(cmd, 88);
                var models =  ((ITimeOnlyListtime_without_time_zoneArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(13));
TimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[17], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[18], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[19], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[20], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[21], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[5],_testData[22], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[6],_testData[23], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[7],_testData[24], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[8],_testData[25], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[9],_testData[26], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[10],_testData[27], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[11],_testData[28], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[12],_testData[29], false);
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

