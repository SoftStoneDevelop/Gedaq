

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
    Id = 3,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 11, minute: 55, second: 30, millisecond: 230),

new TimeOnly(hour: 17, minute: 23, second: 34, millisecond: 626),

new TimeOnly(hour: 2, minute: 18, second: 36, millisecond: 48),

new TimeOnly(hour: 21, minute: 41, second: 55, millisecond: 406),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 10, minute: 44, second: 45, millisecond: 789),

new TimeOnly(hour: 9, minute: 0, second: 14, millisecond: 147),

new TimeOnly(hour: 9, minute: 52, second: 13, millisecond: 433),

new TimeOnly(hour: 0, minute: 51, second: 21, millisecond: 602),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 2,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 2, minute: 24, second: 26, millisecond: 207),

new TimeOnly(hour: 0, minute: 37, second: 30, millisecond: 213),

new TimeOnly(hour: 8, minute: 21, second: 32, millisecond: 161),

new TimeOnly(hour: 16, minute: 30, second: 41, millisecond: 440),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 4, minute: 56, second: 34, millisecond: 80),

new TimeOnly(hour: 15, minute: 38, second: 30, millisecond: 216),

new TimeOnly(hour: 1, minute: 26, second: 46, millisecond: 631),

new TimeOnly(hour: 21, minute: 44, second: 46, millisecond: 155),

},
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 16, minute: 20, second: 53, millisecond: 590),

new TimeOnly(hour: 5, minute: 22, second: 20, millisecond: 436),

new TimeOnly(hour: 20, minute: 27, second: 14, millisecond: 139),

new TimeOnly(hour: 13, minute: 33, second: 10, millisecond: 327),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 20, minute: 34, second: 34, millisecond: 846),

new TimeOnly(hour: 7, minute: 13, second: 23, millisecond: 565),

new TimeOnly(hour: 2, minute: 53, second: 47, millisecond: 101),

},
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 21, minute: 32, second: 36, millisecond: 134),

new TimeOnly(hour: 3, minute: 28, second: 43, millisecond: 87),

new TimeOnly(hour: 18, minute: 31, second: 23, millisecond: 107),

new TimeOnly(hour: 22, minute: 31, second: 32, millisecond: 942),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 2, minute: 52, second: 5, millisecond: 11),

new TimeOnly(hour: 1, minute: 32, second: 44, millisecond: 237),

new TimeOnly(hour: 8, minute: 48, second: 16, millisecond: 698),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 15, minute: 4, second: 33, millisecond: 431),

new TimeOnly(hour: 5, minute: 3, second: 4, millisecond: 343),

new TimeOnly(hour: 10, minute: 18, second: 5, millisecond: 10),

new TimeOnly(hour: 3, minute: 7, second: 15, millisecond: 409),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 2, minute: 29, second: 29, millisecond: 596),

new TimeOnly(hour: 0, minute: 12, second: 29, millisecond: 169),

new TimeOnly(hour: 20, minute: 11, second: 18, millisecond: 957),

new TimeOnly(hour: 8, minute: 51, second: 4, millisecond: 318),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 4, minute: 57, second: 18, millisecond: 313),

new TimeOnly(hour: 12, minute: 33, second: 15, millisecond: 837),

new TimeOnly(hour: 13, minute: 53, second: 0, millisecond: 7),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 12, minute: 7, second: 29, millisecond: 844),

new TimeOnly(hour: 21, minute: 19, second: 57, millisecond: 906),

new TimeOnly(hour: 20, minute: 7, second: 18, millisecond: 14),

new TimeOnly(hour: 3, minute: 10, second: 25, millisecond: 985),

},
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 5, minute: 14, second: 3, millisecond: 519),

new TimeOnly(hour: 9, minute: 11, second: 33, millisecond: 887),

new TimeOnly(hour: 3, minute: 14, second: 53, millisecond: 268),

new TimeOnly(hour: 14, minute: 47, second: 6, millisecond: 864),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 1, minute: 49, second: 6, millisecond: 330),

new TimeOnly(hour: 7, minute: 27, second: 55, millisecond: 54),

new TimeOnly(hour: 10, minute: 32, second: 54, millisecond: 619),

new TimeOnly(hour: 6, minute: 30, second: 10, millisecond: 308),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 21, minute: 21, second: 16, millisecond: 264),

new TimeOnly(hour: 20, minute: 30, second: 47, millisecond: 365),

new TimeOnly(hour: 18, minute: 54, second: 39, millisecond: 487),

new TimeOnly(hour: 7, minute: 19, second: 23, millisecond: 806),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 4, minute: 27, second: 21, millisecond: 896),

new TimeOnly(hour: 17, minute: 40, second: 7, millisecond: 396),

new TimeOnly(hour: 5, minute: 12, second: 3, millisecond: 400),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 8, minute: 18, second: 56, millisecond: 692),

new TimeOnly(hour: 8, minute: 57, second: 7, millisecond: 867),

new TimeOnly(hour: 14, minute: 33, second: 34, millisecond: 912),

new TimeOnly(hour: 2, minute: 37, second: 32, millisecond: 101),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 21, minute: 37, second: 44, millisecond: 699),

new TimeOnly(hour: 0, minute: 35, second: 1, millisecond: 256),

new TimeOnly(hour: 11, minute: 50, second: 27, millisecond: 163),

new TimeOnly(hour: 5, minute: 40, second: 0, millisecond: 606),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 13, minute: 6, second: 39, millisecond: 93),

new TimeOnly(hour: 13, minute: 21, second: 54, millisecond: 644),

new TimeOnly(hour: 17, minute: 49, second: 3, millisecond: 314),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 14, minute: 53, second: 14, millisecond: 979),

new TimeOnly(hour: 6, minute: 57, second: 6, millisecond: 974),

new TimeOnly(hour: 13, minute: 54, second: 31, millisecond: 285),

new TimeOnly(hour: 9, minute: 26, second: 13, millisecond: 662),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 12, minute: 17, second: 48, millisecond: 602),

new TimeOnly(hour: 16, minute: 4, second: 29, millisecond: 413),

new TimeOnly(hour: 2, minute: 44, second: 21, millisecond: 228),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 10, minute: 8, second: 22, millisecond: 580),

new TimeOnly(hour: 16, minute: 49, second: 34, millisecond: 677),

new TimeOnly(hour: 18, minute: 10, second: 34, millisecond: 545),

new TimeOnly(hour: 12, minute: 8, second: 26, millisecond: 209),

},
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 0, minute: 51, second: 20, millisecond: 856),

new TimeOnly(hour: 22, minute: 20, second: 54, millisecond: 2),

new TimeOnly(hour: 7, minute: 30, second: 48, millisecond: 149),

new TimeOnly(hour: 18, minute: 52, second: 19, millisecond: 924),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 10, minute: 27, second: 16, millisecond: 694),

new TimeOnly(hour: 3, minute: 44, second: 35, millisecond: 808),

new TimeOnly(hour: 17, minute: 45, second: 0, millisecond: 436),

},
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 8, minute: 33, second: 48, millisecond: 53),

new TimeOnly(hour: 11, minute: 21, second: 57, millisecond: 27),

new TimeOnly(hour: 4, minute: 15, second: 52, millisecond: 906),

new TimeOnly(hour: 15, minute: 50, second: 21, millisecond: 739),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 22, minute: 31, second: 9, millisecond: 957),

new TimeOnly(hour: 20, minute: 28, second: 29, millisecond: 916),

new TimeOnly(hour: 12, minute: 34, second: 7, millisecond: 186),

new TimeOnly(hour: 5, minute: 17, second: 42, millisecond: 744),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 10, minute: 39, second: 56, millisecond: 152),

new TimeOnly(hour: 22, minute: 35, second: 40, millisecond: 963),

new TimeOnly(hour: 14, minute: 54, second: 40, millisecond: 861),

},
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 7, minute: 51, second: 26, millisecond: 82),

new TimeOnly(hour: 3, minute: 53, second: 15, millisecond: 668),

new TimeOnly(hour: 20, minute: 38, second: 6, millisecond: 712),

new TimeOnly(hour: 16, minute: 8, second: 37, millisecond: 471),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 14, minute: 8, second: 40, millisecond: 427),

new TimeOnly(hour: 0, minute: 35, second: 24, millisecond: 754),

new TimeOnly(hour: 6, minute: 33, second: 38, millisecond: 151),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 10, minute: 35, second: 12, millisecond: 109),

new TimeOnly(hour: 10, minute: 53, second: 17, millisecond: 679),

new TimeOnly(hour: 19, minute: 8, second: 7, millisecond: 882),

new TimeOnly(hour: 2, minute: 53, second: 21, millisecond: 967),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 7, minute: 24, second: 6, millisecond: 463),

new TimeOnly(hour: 14, minute: 11, second: 37, millisecond: 457),

new TimeOnly(hour: 7, minute: 58, second: 39, millisecond: 370),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 8, minute: 28, second: 51, millisecond: 130),

new TimeOnly(hour: 15, minute: 53, second: 33, millisecond: 155),

new TimeOnly(hour: 1, minute: 6, second: 35, millisecond: 429),

new TimeOnly(hour: 3, minute: 30, second: 15, millisecond: 963),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 10, minute: 49, second: 46, millisecond: 111),

new TimeOnly(hour: 14, minute: 20, second: 50, millisecond: 77),

new TimeOnly(hour: 13, minute: 47, second: 48, millisecond: 625),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 10, minute: 32, second: 14, millisecond: 994),

new TimeOnly(hour: 22, minute: 31, second: 57, millisecond: 273),

new TimeOnly(hour: 9, minute: 52, second: 2, millisecond: 884),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 8, minute: 5, second: 58, millisecond: 609),

new TimeOnly(hour: 10, minute: 20, second: 12, millisecond: 678),

new TimeOnly(hour: 22, minute: 41, second: 13, millisecond: 716),

new TimeOnly(hour: 14, minute: 34, second: 16, millisecond: 822),

},
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 8, minute: 4, second: 32, millisecond: 983),

new TimeOnly(hour: 8, minute: 36, second: 57, millisecond: 381),

new TimeOnly(hour: 22, minute: 33, second: 51, millisecond: 9),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 10, minute: 11, second: 19, millisecond: 45),

new TimeOnly(hour: 2, minute: 8, second: 23, millisecond: 486),

new TimeOnly(hour: 10, minute: 54, second: 19, millisecond: 120),

new TimeOnly(hour: 3, minute: 10, second: 34, millisecond: 19),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 17, minute: 54, second: 24, millisecond: 661),

new TimeOnly(hour: 22, minute: 41, second: 40, millisecond: 442),

new TimeOnly(hour: 0, minute: 42, second: 41, millisecond: 541),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 10, minute: 21, second: 15, millisecond: 795),

new TimeOnly(hour: 20, minute: 42, second: 17, millisecond: 936),

new TimeOnly(hour: 16, minute: 19, second: 24, millisecond: 308),

new TimeOnly(hour: 7, minute: 43, second: 9, millisecond: 655),

},
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 3, minute: 27, second: 28, millisecond: 292),

new TimeOnly(hour: 10, minute: 21, second: 42, millisecond: 356),

new TimeOnly(hour: 16, minute: 45, second: 7, millisecond: 260),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 2, minute: 46, second: 42, millisecond: 331),

new TimeOnly(hour: 14, minute: 2, second: 19, millisecond: 833),

new TimeOnly(hour: 1, minute: 33, second: 3, millisecond: 774),

},
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 108,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 4, minute: 29, second: 10, millisecond: 597),

new TimeOnly(hour: 7, minute: 33, second: 48, millisecond: 89),

new TimeOnly(hour: 10, minute: 40, second: 2, millisecond: 358),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 20, minute: 50, second: 36, millisecond: 168),

new TimeOnly(hour: 19, minute: 38, second: 56, millisecond: 194),

new TimeOnly(hour: 15, minute: 6, second: 13, millisecond: 795),

new TimeOnly(hour: 8, minute: 42, second: 37, millisecond: 243),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 116,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 10, minute: 15, second: 28, millisecond: 113),

new TimeOnly(hour: 8, minute: 11, second: 34, millisecond: 862),

new TimeOnly(hour: 4, minute: 28, second: 47, millisecond: 213),

new TimeOnly(hour: 22, minute: 13, second: 40, millisecond: 173),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 15, minute: 32, second: 52, millisecond: 331),

new TimeOnly(hour: 10, minute: 47, second: 13, millisecond: 809),

new TimeOnly(hour: 4, minute: 15, second: 49, millisecond: 152),

new TimeOnly(hour: 0, minute: 52, second: 12, millisecond: 513),

},
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 125,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 1, minute: 9, second: 38, millisecond: 448),

new TimeOnly(hour: 8, minute: 23, second: 5, millisecond: 258),

new TimeOnly(hour: 0, minute: 18, second: 26, millisecond: 499),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 3, minute: 45, second: 46, millisecond: 490),

new TimeOnly(hour: 19, minute: 8, second: 11, millisecond: 345),

new TimeOnly(hour: 4, minute: 32, second: 38, millisecond: 913),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 132,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 21, minute: 15, second: 49, millisecond: 508),

new TimeOnly(hour: 11, minute: 50, second: 14, millisecond: 630),

new TimeOnly(hour: 8, minute: 43, second: 16, millisecond: 475),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 133,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 18, minute: 9, second: 13, millisecond: 488),

new TimeOnly(hour: 10, minute: 37, second: 23, millisecond: 431),

new TimeOnly(hour: 0, minute: 25, second: 6, millisecond: 204),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 18, minute: 10, second: 13, millisecond: 684),

new TimeOnly(hour: 22, minute: 33, second: 40, millisecond: 153),

new TimeOnly(hour: 13, minute: 40, second: 2, millisecond: 720),

new TimeOnly(hour: 5, minute: 43, second: 48, millisecond: 563),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 0, minute: 12, second: 54, millisecond: 850),

new TimeOnly(hour: 15, minute: 55, second: 34, millisecond: 780),

new TimeOnly(hour: 1, minute: 48, second: 55, millisecond: 829),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 6, minute: 11, second: 9, millisecond: 220),

new TimeOnly(hour: 16, minute: 0, second: 16, millisecond: 771),

new TimeOnly(hour: 0, minute: 43, second: 46, millisecond: 804),

new TimeOnly(hour: 12, minute: 33, second: 2, millisecond: 415),

},
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 135,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 9, minute: 39, second: 26, millisecond: 955),

new TimeOnly(hour: 7, minute: 29, second: 37, millisecond: 554),

new TimeOnly(hour: 19, minute: 7, second: 17, millisecond: 678),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 14, minute: 46, second: 37, millisecond: 503),

new TimeOnly(hour: 3, minute: 13, second: 53, millisecond: 965),

new TimeOnly(hour: 5, minute: 10, second: 21, millisecond: 359),

},
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 140,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 21, minute: 27, second: 52, millisecond: 494),

new TimeOnly(hour: 3, minute: 19, second: 13, millisecond: 512),

new TimeOnly(hour: 11, minute: 3, second: 11, millisecond: 915),

new TimeOnly(hour: 16, minute: 25, second: 42, millisecond: 189),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 5, minute: 34, second: 2, millisecond: 37),

new TimeOnly(hour: 10, minute: 10, second: 58, millisecond: 513),

new TimeOnly(hour: 9, minute: 29, second: 58, millisecond: 502),

new TimeOnly(hour: 12, minute: 35, second: 39, millisecond: 487),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 12, minute: 5, second: 57, millisecond: 22),

new TimeOnly(hour: 3, minute: 19, second: 2, millisecond: 554),

new TimeOnly(hour: 5, minute: 50, second: 0, millisecond: 556),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 5, minute: 21, second: 9, millisecond: 798),

new TimeOnly(hour: 1, minute: 6, second: 33, millisecond: 218),

new TimeOnly(hour: 10, minute: 19, second: 46, millisecond: 664),

new TimeOnly(hour: 19, minute: 18, second: 33, millisecond: 577),

},
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 145,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 1, minute: 14, second: 13, millisecond: 159),

new TimeOnly(hour: 12, minute: 58, second: 9, millisecond: 837),

new TimeOnly(hour: 5, minute: 20, second: 52, millisecond: 750),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 15, minute: 58, second: 8, millisecond: 737),

new TimeOnly(hour: 4, minute: 39, second: 13, millisecond: 688),

new TimeOnly(hour: 4, minute: 2, second: 19, millisecond: 490),

},
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 154,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 10, minute: 21, second: 38, millisecond: 179),

new TimeOnly(hour: 21, minute: 22, second: 49, millisecond: 878),

new TimeOnly(hour: 1, minute: 3, second: 55, millisecond: 893),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 21, minute: 19, second: 36, millisecond: 597),

new TimeOnly(hour: 4, minute: 13, second: 43, millisecond: 249),

new TimeOnly(hour: 6, minute: 5, second: 17, millisecond: 798),

new TimeOnly(hour: 1, minute: 13, second: 0, millisecond: 633),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 1, minute: 52, second: 10, millisecond: 336),

new TimeOnly(hour: 12, minute: 43, second: 52, millisecond: 839),

new TimeOnly(hour: 3, minute: 30, second: 36, millisecond: 800),

new TimeOnly(hour: 21, minute: 36, second: 16, millisecond: 604),

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
            overrideAliasPrefixs: ["item1", "item2"],
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
            overrideAliasPrefixs: null,
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
            overrideAliasPrefixs: null,
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
            overrideAliasPrefixs: ["item1", "item2"],
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
            overrideAliasPrefixs: null,
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
            overrideAliasPrefixs: null,
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
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneArray)),
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
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneArray)),
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
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 10;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 33;
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
FROM public.timeonlytime_without_time_zonearray2m m
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
FROM public.timeonlytime_without_time_zonearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeOnlytime_without_time_zoneArray2M>();
                var firstItems2 = new List<FlatTimeOnlytime_without_time_zoneArray2M>();
                var secondItems1 = new List<FlatTimeOnlytime_without_time_zoneArray2M>();
                var secondItems2 = new List<FlatTimeOnlytime_without_time_zoneArray2M>();
                await ((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[23],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 90;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 10;
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
                var firstItems1 = new List<FlatTimeOnlytime_without_time_zoneArray2M>();
                var firstItems2 = new List<FlatTimeOnlytime_without_time_zoneArray2M>();
                var secondItems1 = new List<FlatTimeOnlytime_without_time_zoneArray2M>();
                await ((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[10],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[27],_testData[29], false);
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

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 29;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 133;
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
FROM public.timeonlytime_without_time_zonearray2m m
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
FROM public.timeonlytime_without_time_zonearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeOnlytime_without_time_zoneArray2M>();
                var firstItems2 = new List<FlatTimeOnlytime_without_time_zoneArray2M>();
                var secondItems1 = new List<FlatTimeOnlytime_without_time_zoneArray2M>();
                var secondItems2 = new List<FlatTimeOnlytime_without_time_zoneArray2M>();
                 ((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[3],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 3;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 99;
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
                var firstItems1 = new List<FlatTimeOnlytime_without_time_zoneArray2M>();
                var firstItems2 = new List<FlatTimeOnlytime_without_time_zoneArray2M>();
                var secondItems1 = new List<FlatTimeOnlytime_without_time_zoneArray2M>();
                 ((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[8],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeOnlytime_without_time_zoneArray2M)],
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
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
        private void DbConnectionSTDynQuerySelectModelDynParBatchConfig()
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
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 140;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 99;
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
                int resultIndex = 0;
                foreach(var batchResult in await ((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[5],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[6],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[7],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[8],_testData[29], false);
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
                parametr1.Value = 99;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 18;
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
                var firstItems1 = new List<FlatTimeOnlytime_without_time_zoneArray2M>();
                var secondItems1 = new List<FlatTimeOnlytime_without_time_zoneArray2M>();
                var secondItems2 = new List<FlatTimeOnlytime_without_time_zoneArray2M>();
                await ((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[26],_testData[29], false);
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
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 78;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 29;
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
                int resultIndex = 0;
                foreach(var batchResult in  ((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[5],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[6],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[7],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[8],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[9],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[10],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[11],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[12],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[5], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[5],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[6],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[7],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[8],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[9],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[10],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[11],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[12],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[13],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[14],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[15],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[16],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[17],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[18],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[19],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[20],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[21],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[22],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[23],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[24],_testData[29], false);
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
                parametr1.Value = 65;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 133;
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
                var firstItems1 = new List<FlatTimeOnlytime_without_time_zoneArray2M>();
                var secondItems1 = new List<FlatTimeOnlytime_without_time_zoneArray2M>();
                var secondItems2 = new List<FlatTimeOnlytime_without_time_zoneArray2M>();
                 ((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[3],_testData[29], false);
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
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTSelectModelDynParBatch",
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
                var models = await((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    TimeOnlytime_without_time_zoneArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 135;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 42;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[27], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[28], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[10], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[11], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[12], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[13], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[14], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[5],_testData[15], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[6],_testData[16], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[7],_testData[17], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[8],_testData[18], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[9],_testData[19], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[10],_testData[20], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[11],_testData[21], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[12],_testData[22], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[13],_testData[23], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[14],_testData[24], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[15],_testData[25], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[16],_testData[26], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[17],_testData[27], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[18],_testData[28], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[19],_testData[29], false);
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
        public async Task DbConnectionSTSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 99;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 42;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[21], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[22], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[23], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[24], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[25], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[5],_testData[26], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[6],_testData[27], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[7],_testData[28], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[10], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[11], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[12], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[13], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[14], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[5],_testData[15], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[6],_testData[16], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[7],_testData[17], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[8],_testData[18], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[9],_testData[19], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[10],_testData[20], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[11],_testData[21], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[12],_testData[22], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[13],_testData[23], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[14],_testData[24], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[15],_testData[25], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[16],_testData[26], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[17],_testData[27], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[18],_testData[28], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[19],_testData[29], false);
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
            overrideAliasPrefixs: ["item1", "item2"],
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

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneArray)),
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
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneArray)),
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
FROM public.timeonlytime_without_time_zonearray2m m
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
FROM public.timeonlytime_without_time_zonearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeOnlytime_without_time_zoneArray2M>();
                var firstItems2 = new List<FlatTimeOnlytime_without_time_zoneArray2M>();
                var secondItems1 = new List<FlatTimeOnlytime_without_time_zoneArray2M>();
                var secondItems2 = new List<FlatTimeOnlytime_without_time_zoneArray2M>();
                await ((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 132, query1, 132, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[4],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[4],_testData[29], false);
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
                var firstItems1 = new List<FlatTimeOnlytime_without_time_zoneArray2M>();
                var firstItems2 = new List<FlatTimeOnlytime_without_time_zoneArray2M>();
                var secondItems1 = new List<FlatTimeOnlytime_without_time_zoneArray2M>();
                await ((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 37, query1, 41, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[20],_testData[29], false);
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
FROM public.timeonlytime_without_time_zonearray2m m
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
FROM public.timeonlytime_without_time_zonearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeOnlytime_without_time_zoneArray2M>();
                var firstItems2 = new List<FlatTimeOnlytime_without_time_zoneArray2M>();
                var secondItems1 = new List<FlatTimeOnlytime_without_time_zoneArray2M>();
                var secondItems2 = new List<FlatTimeOnlytime_without_time_zoneArray2M>();
                 ((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 84, query1, 41, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[20],_testData[29], false);
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
                var firstItems1 = new List<FlatTimeOnlytime_without_time_zoneArray2M>();
                var firstItems2 = new List<FlatTimeOnlytime_without_time_zoneArray2M>();
                var secondItems1 = new List<FlatTimeOnlytime_without_time_zoneArray2M>();
                 ((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 41, query1, 90, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[10],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeOnlytime_without_time_zoneArray2M)],
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTDynQuerySelectModelBatch",
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
        private void DbConnectionSTDynQuerySelectModelBatchConfig()
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
                int resultIndex = 0;
                foreach(var batchResult in await ((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 99, query1, 18, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[5],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[6],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[7],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[3], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[4], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[5], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[5],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[6],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[7],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[8],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[9],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[10],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[11],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[12],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[13],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[14],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[15],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[16],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[17],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[18],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[19],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[20],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[21],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[22],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[23],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[24],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[25],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[26],_testData[29], false);
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
FROM public.timeonlytime_without_time_zonearray2m m
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
FROM public.timeonlytime_without_time_zonearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeOnlytime_without_time_zoneArray2M>();
                var secondItems1 = new List<FlatTimeOnlytime_without_time_zoneArray2M>();
                var secondItems2 = new List<FlatTimeOnlytime_without_time_zoneArray2M>();
                await ((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 135, query1, 42, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[19],_testData[29], false);
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
                int resultIndex = 0;
                foreach(var batchResult in  ((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 78, query1, 125, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[5],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[6],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[7],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[8],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[9],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[10],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[11],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[12],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[5],_testData[29], false);
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
FROM public.timeonlytime_without_time_zonearray2m m
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
FROM public.timeonlytime_without_time_zonearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeOnlytime_without_time_zoneArray2M>();
                var secondItems1 = new List<FlatTimeOnlytime_without_time_zoneArray2M>();
                var secondItems2 = new List<FlatTimeOnlytime_without_time_zoneArray2M>();
                 ((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionDynQuerySelectModelBatch(connection, 84, query1, 84, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[12],_testData[29], false);
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
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTSelectModelBatch",
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
        private void DbConnectionSTSelectModelBatchConfig()
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
        public async Task DbConnectionSTSelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in await ((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionSTSelectModelBatchAsync(connection, 42, 70))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[10], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[11], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[12], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[13], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[14], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[5],_testData[15], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[6],_testData[16], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[7],_testData[17], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[8],_testData[18], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[9],_testData[19], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[10],_testData[20], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[11],_testData[21], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[12],_testData[22], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[13],_testData[23], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[14],_testData[24], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[15],_testData[25], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[16],_testData[26], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[17],_testData[27], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[18],_testData[28], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[15], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[16], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[17], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[18], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[19], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[5],_testData[20], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[6],_testData[21], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[7],_testData[22], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[8],_testData[23], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[9],_testData[24], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[10],_testData[25], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[11],_testData[26], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[12],_testData[27], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[13],_testData[28], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[14],_testData[29], false);
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
        public async Task DbConnectionSTSelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in  ((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionSTSelectModelBatch(connection, 42, 38))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[10], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[11], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[12], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[13], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[14], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[5],_testData[15], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[6],_testData[16], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[7],_testData[17], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[8],_testData[18], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[9],_testData[19], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[10],_testData[20], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[11],_testData[21], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[12],_testData[22], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[13],_testData[23], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[14],_testData[24], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[15],_testData[25], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[16],_testData[26], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[17],_testData[27], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[18],_testData[28], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[8], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[9], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[10], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[11], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[12], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[5],_testData[13], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[6],_testData[14], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[7],_testData[15], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[8],_testData[16], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[9],_testData[17], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[10],_testData[18], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[11],_testData[19], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[12],_testData[20], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[13],_testData[21], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[14],_testData[22], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[15],_testData[23], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[16],_testData[24], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[17],_testData[25], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[18],_testData[26], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[19],_testData[27], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[20],_testData[28], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[21],_testData[29], false);
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
                ((ITimeOnlyListtime_without_time_zoneArray)this).SetDbConnectionSelectModelParametrs(cmd, 3);
                var models = await ((ITimeOnlyListtime_without_time_zoneArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(29));
TimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[1], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[2], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[3], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[4], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[5], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[5],_testData[6], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[6],_testData[7], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[7],_testData[8], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[8],_testData[9], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[9],_testData[10], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[10],_testData[11], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[11],_testData[12], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[12],_testData[13], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[13],_testData[14], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[14],_testData[15], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[15],_testData[16], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[16],_testData[17], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[17],_testData[18], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[18],_testData[19], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[19],_testData[20], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[20],_testData[21], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[21],_testData[22], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[22],_testData[23], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[23],_testData[24], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[24],_testData[25], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[25],_testData[26], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[26],_testData[27], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[27],_testData[28], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[28],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ITimeOnlyListtime_without_time_zoneArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((ITimeOnlyListtime_without_time_zoneArray)this).SetDbConnectionSelectModelParametrs(cmd, 38);
                var models =  ((ITimeOnlyListtime_without_time_zoneArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(22));
TimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[8], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[9], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[10], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[11], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[12], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[5],_testData[13], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[6],_testData[14], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[7],_testData[15], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[8],_testData[16], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[9],_testData[17], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[10],_testData[18], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[11],_testData[19], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[12],_testData[20], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[13],_testData[21], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[14],_testData[22], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[15],_testData[23], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[16],_testData[24], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[17],_testData[25], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[18],_testData[26], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[19],_testData[27], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[20],_testData[28], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[21],_testData[29], false);
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

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(TimeOnlytime_without_time_zoneArray2MI),
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
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerTest()
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
                ((ITimeOnlyListtime_without_time_zoneArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_timeonlytime_without_time_zonearray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
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
                await ((ITimeOnlyListtime_without_time_zoneArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_timeonlytime_without_time_zonearray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
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
            queryMapType: typeof(TimeOnlytime_without_time_zoneArray2MI),
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
            queryMapType: typeof(TimeOnlytime_without_time_zoneArray2M),
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

