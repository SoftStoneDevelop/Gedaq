

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
    Id = 4,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 4, minute: 14, second: 31, millisecond: 473),

new TimeOnly(hour: 10, minute: 46, second: 12, millisecond: 687),

new TimeOnly(hour: 13, minute: 40, second: 39, millisecond: 292),

new TimeOnly(hour: 8, minute: 31, second: 23, millisecond: 816),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 8, minute: 51, second: 35, millisecond: 649),

new TimeOnly(hour: 4, minute: 37, second: 30, millisecond: 241),

new TimeOnly(hour: 11, minute: 47, second: 50, millisecond: 980),

},
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 3, minute: 25, second: 5, millisecond: 988),

new TimeOnly(hour: 5, minute: 47, second: 51, millisecond: 343),

new TimeOnly(hour: 11, minute: 14, second: 1, millisecond: 297),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 21, minute: 46, second: 38, millisecond: 689),

new TimeOnly(hour: 22, minute: 45, second: 20, millisecond: 832),

new TimeOnly(hour: 11, minute: 56, second: 23, millisecond: 750),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 19, minute: 33, second: 35, millisecond: 55),

new TimeOnly(hour: 5, minute: 15, second: 45, millisecond: 934),

new TimeOnly(hour: 8, minute: 49, second: 49, millisecond: 62),

new TimeOnly(hour: 22, minute: 10, second: 24, millisecond: 556),

},
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 16, minute: 3, second: 34, millisecond: 481),

new TimeOnly(hour: 1, minute: 39, second: 9, millisecond: 590),

new TimeOnly(hour: 18, minute: 23, second: 12, millisecond: 672),

new TimeOnly(hour: 0, minute: 32, second: 44, millisecond: 980),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 15, minute: 39, second: 27, millisecond: 639),

new TimeOnly(hour: 1, minute: 41, second: 19, millisecond: 913),

new TimeOnly(hour: 4, minute: 34, second: 18, millisecond: 472),

new TimeOnly(hour: 2, minute: 26, second: 8, millisecond: 735),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 14, minute: 57, second: 35, millisecond: 119),

new TimeOnly(hour: 15, minute: 50, second: 38, millisecond: 161),

new TimeOnly(hour: 0, minute: 18, second: 12, millisecond: 517),

new TimeOnly(hour: 7, minute: 22, second: 0, millisecond: 969),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 9, minute: 49, second: 10, millisecond: 299),

new TimeOnly(hour: 18, minute: 41, second: 5, millisecond: 891),

new TimeOnly(hour: 6, minute: 14, second: 6, millisecond: 468),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 9, minute: 10, second: 20, millisecond: 890),

new TimeOnly(hour: 8, minute: 38, second: 22, millisecond: 335),

new TimeOnly(hour: 8, minute: 48, second: 3, millisecond: 938),

new TimeOnly(hour: 18, minute: 34, second: 32, millisecond: 439),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 21, minute: 1, second: 28, millisecond: 159),

new TimeOnly(hour: 22, minute: 13, second: 2, millisecond: 508),

new TimeOnly(hour: 21, minute: 36, second: 11, millisecond: 73),

new TimeOnly(hour: 17, minute: 20, second: 40, millisecond: 959),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 21, minute: 7, second: 33, millisecond: 631),

new TimeOnly(hour: 1, minute: 36, second: 9, millisecond: 569),

new TimeOnly(hour: 1, minute: 37, second: 39, millisecond: 941),

new TimeOnly(hour: 19, minute: 13, second: 12, millisecond: 895),

},
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 0, minute: 20, second: 46, millisecond: 21),

new TimeOnly(hour: 21, minute: 55, second: 12, millisecond: 653),

new TimeOnly(hour: 6, minute: 31, second: 35, millisecond: 310),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 13, minute: 3, second: 11, millisecond: 417),

new TimeOnly(hour: 18, minute: 52, second: 15, millisecond: 232),

new TimeOnly(hour: 18, minute: 15, second: 1, millisecond: 79),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 2, minute: 53, second: 33, millisecond: 948),

new TimeOnly(hour: 22, minute: 10, second: 25, millisecond: 245),

new TimeOnly(hour: 19, minute: 33, second: 3, millisecond: 672),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 19, minute: 55, second: 13, millisecond: 648),

new TimeOnly(hour: 13, minute: 24, second: 42, millisecond: 727),

new TimeOnly(hour: 4, minute: 48, second: 13, millisecond: 914),

new TimeOnly(hour: 16, minute: 46, second: 7, millisecond: 453),

},
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 10, minute: 15, second: 19, millisecond: 197),

new TimeOnly(hour: 2, minute: 49, second: 51, millisecond: 16),

new TimeOnly(hour: 10, minute: 45, second: 25, millisecond: 571),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 6, minute: 20, second: 31, millisecond: 896),

new TimeOnly(hour: 21, minute: 11, second: 45, millisecond: 562),

new TimeOnly(hour: 2, minute: 48, second: 17, millisecond: 382),

new TimeOnly(hour: 11, minute: 34, second: 19, millisecond: 485),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 15, minute: 31, second: 12, millisecond: 723),

new TimeOnly(hour: 9, minute: 7, second: 58, millisecond: 812),

new TimeOnly(hour: 16, minute: 4, second: 49, millisecond: 364),

new TimeOnly(hour: 19, minute: 52, second: 43, millisecond: 395),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 22, minute: 25, second: 38, millisecond: 440),

new TimeOnly(hour: 3, minute: 53, second: 44, millisecond: 97),

new TimeOnly(hour: 7, minute: 13, second: 50, millisecond: 690),

},
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 21, minute: 51, second: 58, millisecond: 349),

new TimeOnly(hour: 8, minute: 53, second: 49, millisecond: 212),

new TimeOnly(hour: 17, minute: 41, second: 9, millisecond: 697),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 5, minute: 30, second: 26, millisecond: 521),

new TimeOnly(hour: 1, minute: 31, second: 29, millisecond: 886),

new TimeOnly(hour: 6, minute: 14, second: 53, millisecond: 781),

},
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 18, minute: 26, second: 14, millisecond: 687),

new TimeOnly(hour: 15, minute: 5, second: 52, millisecond: 580),

new TimeOnly(hour: 0, minute: 57, second: 10, millisecond: 863),

new TimeOnly(hour: 9, minute: 40, second: 58, millisecond: 230),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 9, minute: 21, second: 13, millisecond: 66),

new TimeOnly(hour: 12, minute: 41, second: 52, millisecond: 736),

new TimeOnly(hour: 11, minute: 14, second: 32, millisecond: 163),

new TimeOnly(hour: 16, minute: 22, second: 42, millisecond: 54),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 0, minute: 11, second: 43, millisecond: 908),

new TimeOnly(hour: 22, minute: 19, second: 8, millisecond: 937),

new TimeOnly(hour: 1, minute: 42, second: 36, millisecond: 310),

new TimeOnly(hour: 14, minute: 16, second: 10, millisecond: 32),

},
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 0, minute: 4, second: 29, millisecond: 464),

new TimeOnly(hour: 8, minute: 8, second: 7, millisecond: 971),

new TimeOnly(hour: 17, minute: 50, second: 47, millisecond: 920),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 13, minute: 19, second: 8, millisecond: 603),

new TimeOnly(hour: 21, minute: 43, second: 34, millisecond: 580),

new TimeOnly(hour: 20, minute: 52, second: 27, millisecond: 79),

new TimeOnly(hour: 15, minute: 46, second: 17, millisecond: 596),

},
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 1, minute: 38, second: 15, millisecond: 106),

new TimeOnly(hour: 17, minute: 50, second: 42, millisecond: 32),

new TimeOnly(hour: 6, minute: 26, second: 21, millisecond: 731),

new TimeOnly(hour: 13, minute: 53, second: 13, millisecond: 904),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 6, minute: 55, second: 17, millisecond: 816),

new TimeOnly(hour: 1, minute: 55, second: 38, millisecond: 445),

new TimeOnly(hour: 0, minute: 34, second: 6, millisecond: 73),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 1, minute: 30, second: 32, millisecond: 34),

new TimeOnly(hour: 21, minute: 20, second: 45, millisecond: 975),

new TimeOnly(hour: 8, minute: 27, second: 4, millisecond: 318),

},
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 4, minute: 34, second: 18, millisecond: 58),

new TimeOnly(hour: 10, minute: 7, second: 17, millisecond: 351),

new TimeOnly(hour: 13, minute: 13, second: 47, millisecond: 466),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 6, minute: 27, second: 12, millisecond: 359),

new TimeOnly(hour: 15, minute: 50, second: 35, millisecond: 215),

new TimeOnly(hour: 21, minute: 0, second: 47, millisecond: 17),

new TimeOnly(hour: 12, minute: 15, second: 47, millisecond: 925),

},
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 12, minute: 26, second: 30, millisecond: 843),

new TimeOnly(hour: 18, minute: 19, second: 51, millisecond: 993),

new TimeOnly(hour: 13, minute: 2, second: 14, millisecond: 122),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 4, minute: 26, second: 29, millisecond: 180),

new TimeOnly(hour: 0, minute: 20, second: 53, millisecond: 188),

new TimeOnly(hour: 13, minute: 26, second: 49, millisecond: 423),

new TimeOnly(hour: 13, minute: 18, second: 39, millisecond: 502),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 9, minute: 17, second: 35, millisecond: 560),

new TimeOnly(hour: 4, minute: 42, second: 8, millisecond: 579),

new TimeOnly(hour: 5, minute: 46, second: 2, millisecond: 122),

new TimeOnly(hour: 10, minute: 34, second: 52, millisecond: 722),

},
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 19, minute: 47, second: 42, millisecond: 125),

new TimeOnly(hour: 5, minute: 40, second: 26, millisecond: 852),

new TimeOnly(hour: 17, minute: 12, second: 47, millisecond: 460),

new TimeOnly(hour: 10, minute: 42, second: 43, millisecond: 905),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 11, minute: 43, second: 26, millisecond: 282),

new TimeOnly(hour: 14, minute: 0, second: 43, millisecond: 282),

new TimeOnly(hour: 9, minute: 10, second: 53, millisecond: 742),

new TimeOnly(hour: 16, minute: 51, second: 24, millisecond: 112),

},
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 8, minute: 1, second: 40, millisecond: 700),

new TimeOnly(hour: 15, minute: 57, second: 44, millisecond: 344),

new TimeOnly(hour: 3, minute: 32, second: 24, millisecond: 474),

new TimeOnly(hour: 18, minute: 27, second: 33, millisecond: 948),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 5, minute: 4, second: 57, millisecond: 235),

new TimeOnly(hour: 7, minute: 40, second: 55, millisecond: 394),

new TimeOnly(hour: 9, minute: 22, second: 54, millisecond: 547),

new TimeOnly(hour: 5, minute: 25, second: 58, millisecond: 1),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 20, minute: 22, second: 2, millisecond: 474),

new TimeOnly(hour: 0, minute: 31, second: 23, millisecond: 537),

new TimeOnly(hour: 21, minute: 26, second: 44, millisecond: 36),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 14, minute: 37, second: 21, millisecond: 841),

new TimeOnly(hour: 20, minute: 55, second: 0, millisecond: 821),

new TimeOnly(hour: 17, minute: 52, second: 6, millisecond: 174),

new TimeOnly(hour: 22, minute: 46, second: 24, millisecond: 29),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 5, minute: 23, second: 1, millisecond: 615),

new TimeOnly(hour: 12, minute: 54, second: 17, millisecond: 341),

new TimeOnly(hour: 10, minute: 55, second: 21, millisecond: 192),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 5, minute: 55, second: 41, millisecond: 835),

new TimeOnly(hour: 5, minute: 30, second: 56, millisecond: 890),

new TimeOnly(hour: 9, minute: 44, second: 14, millisecond: 626),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 9, minute: 9, second: 51, millisecond: 251),

new TimeOnly(hour: 7, minute: 53, second: 25, millisecond: 978),

new TimeOnly(hour: 0, minute: 14, second: 34, millisecond: 143),

},
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 101,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 6, minute: 9, second: 43, millisecond: 53),

new TimeOnly(hour: 6, minute: 31, second: 20, millisecond: 113),

new TimeOnly(hour: 4, minute: 16, second: 48, millisecond: 437),

new TimeOnly(hour: 5, minute: 56, second: 15, millisecond: 488),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 102,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 15, minute: 14, second: 16, millisecond: 798),

new TimeOnly(hour: 11, minute: 7, second: 42, millisecond: 845),

new TimeOnly(hour: 8, minute: 48, second: 39, millisecond: 330),

new TimeOnly(hour: 9, minute: 56, second: 52, millisecond: 139),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 0, minute: 47, second: 5, millisecond: 855),

new TimeOnly(hour: 11, minute: 28, second: 57, millisecond: 547),

new TimeOnly(hour: 16, minute: 46, second: 11, millisecond: 243),

new TimeOnly(hour: 12, minute: 18, second: 6, millisecond: 362),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 6, minute: 21, second: 47, millisecond: 454),

new TimeOnly(hour: 10, minute: 20, second: 11, millisecond: 394),

new TimeOnly(hour: 15, minute: 10, second: 17, millisecond: 872),

new TimeOnly(hour: 4, minute: 54, second: 3, millisecond: 236),

},
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 109,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 4, minute: 13, second: 15, millisecond: 991),

new TimeOnly(hour: 0, minute: 11, second: 22, millisecond: 93),

new TimeOnly(hour: 20, minute: 58, second: 41, millisecond: 330),

new TimeOnly(hour: 21, minute: 34, second: 1, millisecond: 608),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 116,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 9, minute: 24, second: 49, millisecond: 662),

new TimeOnly(hour: 21, minute: 55, second: 15, millisecond: 840),

new TimeOnly(hour: 18, minute: 39, second: 53, millisecond: 310),

new TimeOnly(hour: 5, minute: 6, second: 30, millisecond: 901),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 22, minute: 17, second: 55, millisecond: 247),

new TimeOnly(hour: 19, minute: 1, second: 13, millisecond: 222),

new TimeOnly(hour: 4, minute: 11, second: 19, millisecond: 277),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 0, minute: 21, second: 42, millisecond: 711),

new TimeOnly(hour: 22, minute: 14, second: 50, millisecond: 582),

new TimeOnly(hour: 16, minute: 50, second: 10, millisecond: 346),

},
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 120,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 17, minute: 1, second: 8, millisecond: 222),

new TimeOnly(hour: 10, minute: 49, second: 18, millisecond: 814),

new TimeOnly(hour: 17, minute: 33, second: 6, millisecond: 715),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 129,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 20, minute: 11, second: 57, millisecond: 489),

new TimeOnly(hour: 10, minute: 24, second: 58, millisecond: 750),

new TimeOnly(hour: 12, minute: 40, second: 22, millisecond: 456),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 22, minute: 2, second: 33, millisecond: 76),

new TimeOnly(hour: 9, minute: 56, second: 8, millisecond: 909),

new TimeOnly(hour: 0, minute: 24, second: 39, millisecond: 927),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 135,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 21, minute: 48, second: 7, millisecond: 279),

new TimeOnly(hour: 6, minute: 23, second: 42, millisecond: 301),

new TimeOnly(hour: 0, minute: 43, second: 14, millisecond: 108),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 144,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 18, minute: 18, second: 53, millisecond: 132),

new TimeOnly(hour: 0, minute: 22, second: 8, millisecond: 989),

new TimeOnly(hour: 6, minute: 37, second: 37, millisecond: 780),

new TimeOnly(hour: 21, minute: 35, second: 9, millisecond: 757),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 12, minute: 23, second: 28, millisecond: 594),

new TimeOnly(hour: 1, minute: 28, second: 50, millisecond: 331),

new TimeOnly(hour: 4, minute: 51, second: 52, millisecond: 436),

new TimeOnly(hour: 4, minute: 51, second: 47, millisecond: 784),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 8, minute: 23, second: 14, millisecond: 646),

new TimeOnly(hour: 17, minute: 56, second: 32, millisecond: 294),

new TimeOnly(hour: 20, minute: 42, second: 7, millisecond: 73),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 19, minute: 4, second: 24, millisecond: 901),

new TimeOnly(hour: 17, minute: 43, second: 12, millisecond: 543),

new TimeOnly(hour: 17, minute: 0, second: 26, millisecond: 534),

},
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 148,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 9, minute: 31, second: 50, millisecond: 9),

new TimeOnly(hour: 5, minute: 17, second: 50, millisecond: 732),

new TimeOnly(hour: 12, minute: 14, second: 1, millisecond: 159),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 2, minute: 49, second: 13, millisecond: 476),

new TimeOnly(hour: 21, minute: 45, second: 47, millisecond: 650),

new TimeOnly(hour: 18, minute: 8, second: 18, millisecond: 247),

},
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 150,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 7, minute: 35, second: 0, millisecond: 24),

new TimeOnly(hour: 6, minute: 2, second: 2, millisecond: 531),

new TimeOnly(hour: 18, minute: 16, second: 48, millisecond: 780),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 1, minute: 28, second: 17, millisecond: 748),

new TimeOnly(hour: 4, minute: 6, second: 32, millisecond: 223),

new TimeOnly(hour: 13, minute: 27, second: 36, millisecond: 206),

new TimeOnly(hour: 3, minute: 53, second: 58, millisecond: 299),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 17, minute: 29, second: 11, millisecond: 355),

new TimeOnly(hour: 2, minute: 53, second: 15, millisecond: 297),

new TimeOnly(hour: 9, minute: 12, second: 39, millisecond: 462),

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
                parametr1.Value = 45;
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
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[9],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 15;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 109;
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
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[6],_testData[29], false);
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
                parametr1.Value = 51;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 54;
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
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[15],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 61;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 135;
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
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[2],_testData[29], false);
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
                parametr1.Value = 15;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 30;
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[5],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[6],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[7],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[8],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[9],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[10],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[11],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[12],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[13],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[14],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[15],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[16],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[17],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[18],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[19],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[20],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[21],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[22],_testData[29], false);
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
                parametr1.Value = 35;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 144;
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
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[21],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[1],_testData[29], false);
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
                parametr1.Value = 129;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 35;
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
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[5],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[6],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[7],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[8],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[9],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[10],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[11],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[12],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[13],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[14],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[15],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[16],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[17],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[18],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[19],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[20],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[21],_testData[29], false);
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
                parametr1.Value = 89;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 144;
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
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[10],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[1],_testData[29], false);
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
                parametr1.Value = 30;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 15;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[7], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[8], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[9], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[10], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[11], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[5],_testData[12], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[6],_testData[13], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[7],_testData[14], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[8],_testData[15], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[9],_testData[16], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[10],_testData[17], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[11],_testData[18], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[12],_testData[19], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[13],_testData[20], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[14],_testData[21], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[15],_testData[22], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[16],_testData[23], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[17],_testData[24], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[18],_testData[25], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[19],_testData[26], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[20],_testData[27], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[21],_testData[28], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[3], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[4], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[5], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[6], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[7], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[5],_testData[8], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[6],_testData[9], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[7],_testData[10], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[8],_testData[11], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[9],_testData[12], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[10],_testData[13], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[11],_testData[14], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[12],_testData[15], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[13],_testData[16], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[14],_testData[17], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[15],_testData[18], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[16],_testData[19], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[17],_testData[20], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[18],_testData[21], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[19],_testData[22], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[20],_testData[23], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[21],_testData[24], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[22],_testData[25], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[23],_testData[26], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[24],_testData[27], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[25],_testData[28], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[26],_testData[29], false);
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
                parametr1.Value = 116;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 85;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[24], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[25], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[26], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[27], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[28], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[18], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[19], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[20], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[21], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[22], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[5],_testData[23], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[6],_testData[24], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[7],_testData[25], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[8],_testData[26], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[9],_testData[27], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[10],_testData[28], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[11],_testData[29], false);
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
                await ((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 53, query1, 54, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[16],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[15],_testData[29], false);
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
                await ((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 109, query1, 77, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[6],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[12],_testData[29], false);
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
                 ((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 4, query1, 89, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[10],_testData[29], false);
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
                 ((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 61, query1, 116, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[5],_testData[29], false);
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
                foreach(var batchResult in await ((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 120, query1, 54, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[5],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[6],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[7],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[8],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[9],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[10],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[11],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[12],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[13],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[14],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[15],_testData[29], false);
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
                await ((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 15, query1, 15, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[26],_testData[29], false);
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
                foreach(var batchResult in  ((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 4, query1, 51, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[1], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[2], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[3], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[4], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[5], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[5],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[6],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[7],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[8],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[9],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[10],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[11],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[12],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[13],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[14],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[15],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[16],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[17],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[18],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[19],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[20],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[21],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[22],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[23],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[24],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[25],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[26],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[27],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[5],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[6],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[7],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[8],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[9],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[10],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[11],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[12],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[13],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[14],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[15],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[16],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[17],_testData[29], false);
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
                 ((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionDynQuerySelectModelBatch(connection, 120, query1, 35, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[4],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[21],_testData[29], false);
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
                foreach(var batchResult in await ((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionSTSelectModelBatchAsync(connection, 54, 30))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[14], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[15], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[16], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[17], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[18], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[5],_testData[19], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[6],_testData[20], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[7],_testData[21], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[8],_testData[22], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[9],_testData[23], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[10],_testData[24], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[11],_testData[25], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[12],_testData[26], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[13],_testData[27], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[14],_testData[28], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[7], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[8], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[9], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[10], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[11], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[5],_testData[12], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[6],_testData[13], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[7],_testData[14], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[8],_testData[15], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[9],_testData[16], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[10],_testData[17], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[11],_testData[18], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[12],_testData[19], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[13],_testData[20], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[14],_testData[21], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[15],_testData[22], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[16],_testData[23], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[17],_testData[24], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[18],_testData[25], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[19],_testData[26], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[20],_testData[27], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[21],_testData[28], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[22],_testData[29], false);
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
                foreach(var batchResult in  ((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionSTSelectModelBatch(connection, 18, 53))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[5], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[6], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[7], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[8], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[9], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[5],_testData[10], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[6],_testData[11], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[7],_testData[12], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[8],_testData[13], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[9],_testData[14], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[10],_testData[15], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[11],_testData[16], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[12],_testData[17], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[13],_testData[18], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[14],_testData[19], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[15],_testData[20], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[16],_testData[21], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[17],_testData[22], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[18],_testData[23], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[19],_testData[24], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[20],_testData[25], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[21],_testData[26], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[22],_testData[27], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[23],_testData[28], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[13], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[14], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[15], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[16], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[17], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[5],_testData[18], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[6],_testData[19], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[7],_testData[20], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[8],_testData[21], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[9],_testData[22], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[10],_testData[23], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[11],_testData[24], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[12],_testData[25], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[13],_testData[26], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[14],_testData[27], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[15],_testData[28], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[16],_testData[29], false);
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
                ((ITimeOnlyListtime_without_time_zoneArray)this).SetDbConnectionSelectModelParametrs(cmd, 144);
                var models = await ((ITimeOnlyListtime_without_time_zoneArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(2));
TimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[28], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ITimeOnlyListtime_without_time_zoneArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((ITimeOnlyListtime_without_time_zoneArray)this).SetDbConnectionSelectModelParametrs(cmd, 89);
                var models =  ((ITimeOnlyListtime_without_time_zoneArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(11));
TimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[19], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[20], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[21], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[22], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[23], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[5],_testData[24], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[6],_testData[25], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[7],_testData[26], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[8],_testData[27], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[9],_testData[28], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[10],_testData[29], false);
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
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(TimeOnlytime_without_time_zoneArray2MIWA),
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
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<TimeOnlytime_without_time_zoneArray2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeOnlytime_without_time_zoneArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ITimeOnlyListtime_without_time_zoneArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_timeonlytime_without_time_zonearray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((ITimeOnlyListtime_without_time_zoneArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeOnlytime_without_time_zoneArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<TimeOnlytime_without_time_zoneArray2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeOnlytime_without_time_zoneArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ITimeOnlyListtime_without_time_zoneArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_timeonlytime_without_time_zonearray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((ITimeOnlyListtime_without_time_zoneArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeOnlytime_without_time_zoneArray2MIWA.AssertModel(actual, expect, false);
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

        [Test, Order(2)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<TimeOnlytime_without_time_zoneArray2MI>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((ITimeOnlyListtime_without_time_zoneArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((ITimeOnlyListtime_without_time_zoneArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeOnlytime_without_time_zoneArray2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<TimeOnlytime_without_time_zoneArray2MI>(2);
                for (int i = 12; i < 30; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((ITimeOnlyListtime_without_time_zoneArray)this).ImportModelInner(connection, importCollection);
                var models = ((ITimeOnlyListtime_without_time_zoneArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeOnlytime_without_time_zoneArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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

        [Test, Order(5)]
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

        [Test, Order(6)]
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

        [Test, Order(6)]
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

        [Test, Order(6)]
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

        [Test, Order(6)]
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

