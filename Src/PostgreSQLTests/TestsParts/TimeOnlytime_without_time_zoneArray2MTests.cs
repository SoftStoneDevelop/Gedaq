

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
new TimeOnly(hour: 4, minute: 29, second: 16, millisecond: 320),

new TimeOnly(hour: 8, minute: 13, second: 44, millisecond: 56),

new TimeOnly(hour: 1, minute: 22, second: 44, millisecond: 731),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 16, minute: 51, second: 20, millisecond: 717),

new TimeOnly(hour: 7, minute: 3, second: 45, millisecond: 783),

new TimeOnly(hour: 13, minute: 0, second: 31, millisecond: 64),

},
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 14, minute: 8, second: 1, millisecond: 349),

new TimeOnly(hour: 4, minute: 40, second: 7, millisecond: 757),

new TimeOnly(hour: 13, minute: 45, second: 58, millisecond: 808),

new TimeOnly(hour: 1, minute: 0, second: 55, millisecond: 355),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 1,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 12, minute: 48, second: 18, millisecond: 23),

new TimeOnly(hour: 2, minute: 4, second: 35, millisecond: 369),

new TimeOnly(hour: 5, minute: 15, second: 5, millisecond: 391),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 8, minute: 58, second: 11, millisecond: 63),

new TimeOnly(hour: 0, minute: 8, second: 54, millisecond: 285),

new TimeOnly(hour: 2, minute: 16, second: 19, millisecond: 830),

},
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 9, minute: 33, second: 19, millisecond: 424),

new TimeOnly(hour: 1, minute: 47, second: 43, millisecond: 643),

new TimeOnly(hour: 12, minute: 6, second: 51, millisecond: 139),

new TimeOnly(hour: 10, minute: 48, second: 11, millisecond: 785),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 20, minute: 44, second: 55, millisecond: 287),

new TimeOnly(hour: 11, minute: 30, second: 53, millisecond: 567),

new TimeOnly(hour: 12, minute: 19, second: 15, millisecond: 686),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 21, minute: 45, second: 50, millisecond: 960),

new TimeOnly(hour: 20, minute: 32, second: 34, millisecond: 346),

new TimeOnly(hour: 16, minute: 10, second: 55, millisecond: 877),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 2, minute: 8, second: 36, millisecond: 175),

new TimeOnly(hour: 14, minute: 20, second: 4, millisecond: 410),

new TimeOnly(hour: 12, minute: 47, second: 49, millisecond: 58),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 20, minute: 31, second: 5, millisecond: 30),

new TimeOnly(hour: 6, minute: 24, second: 23, millisecond: 69),

new TimeOnly(hour: 19, minute: 40, second: 40, millisecond: 61),

new TimeOnly(hour: 12, minute: 42, second: 47, millisecond: 491),

},
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 17, minute: 20, second: 27, millisecond: 320),

new TimeOnly(hour: 0, minute: 26, second: 29, millisecond: 908),

new TimeOnly(hour: 5, minute: 27, second: 12, millisecond: 133),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 0, minute: 5, second: 33, millisecond: 297),

new TimeOnly(hour: 1, minute: 57, second: 5, millisecond: 211),

new TimeOnly(hour: 18, minute: 12, second: 30, millisecond: 351),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 14, minute: 39, second: 35, millisecond: 900),

new TimeOnly(hour: 6, minute: 0, second: 6, millisecond: 282),

new TimeOnly(hour: 13, minute: 38, second: 18, millisecond: 773),

new TimeOnly(hour: 14, minute: 46, second: 34, millisecond: 210),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 8, minute: 23, second: 4, millisecond: 797),

new TimeOnly(hour: 21, minute: 11, second: 5, millisecond: 940),

new TimeOnly(hour: 11, minute: 57, second: 20, millisecond: 541),

new TimeOnly(hour: 13, minute: 49, second: 41, millisecond: 42),

},
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 20, minute: 23, second: 51, millisecond: 339),

new TimeOnly(hour: 19, minute: 56, second: 54, millisecond: 820),

new TimeOnly(hour: 4, minute: 8, second: 35, millisecond: 450),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 12, minute: 31, second: 29, millisecond: 726),

new TimeOnly(hour: 7, minute: 53, second: 13, millisecond: 400),

new TimeOnly(hour: 12, minute: 43, second: 58, millisecond: 844),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 5, minute: 14, second: 54, millisecond: 565),

new TimeOnly(hour: 2, minute: 0, second: 9, millisecond: 386),

new TimeOnly(hour: 5, minute: 40, second: 8, millisecond: 989),

new TimeOnly(hour: 15, minute: 48, second: 46, millisecond: 22),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 9, minute: 18, second: 37, millisecond: 456),

new TimeOnly(hour: 4, minute: 32, second: 26, millisecond: 651),

new TimeOnly(hour: 16, minute: 43, second: 36, millisecond: 506),

new TimeOnly(hour: 11, minute: 11, second: 16, millisecond: 323),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 2, minute: 39, second: 42, millisecond: 720),

new TimeOnly(hour: 19, minute: 42, second: 24, millisecond: 612),

new TimeOnly(hour: 9, minute: 30, second: 49, millisecond: 493),

},
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 9, minute: 54, second: 5, millisecond: 940),

new TimeOnly(hour: 10, minute: 57, second: 26, millisecond: 866),

new TimeOnly(hour: 5, minute: 51, second: 26, millisecond: 863),

new TimeOnly(hour: 2, minute: 27, second: 58, millisecond: 585),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 14, minute: 33, second: 35, millisecond: 426),

new TimeOnly(hour: 17, minute: 21, second: 27, millisecond: 179),

new TimeOnly(hour: 19, minute: 54, second: 28, millisecond: 43),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 12, minute: 36, second: 35, millisecond: 932),

new TimeOnly(hour: 14, minute: 49, second: 43, millisecond: 686),

new TimeOnly(hour: 13, minute: 21, second: 17, millisecond: 570),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 12, minute: 45, second: 32, millisecond: 462),

new TimeOnly(hour: 1, minute: 52, second: 3, millisecond: 665),

new TimeOnly(hour: 0, minute: 6, second: 3, millisecond: 749),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 21, minute: 54, second: 7, millisecond: 182),

new TimeOnly(hour: 10, minute: 15, second: 18, millisecond: 2),

new TimeOnly(hour: 7, minute: 6, second: 17, millisecond: 604),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 19, minute: 1, second: 29, millisecond: 24),

new TimeOnly(hour: 5, minute: 57, second: 36, millisecond: 847),

new TimeOnly(hour: 11, minute: 39, second: 45, millisecond: 835),

new TimeOnly(hour: 10, minute: 28, second: 36, millisecond: 821),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 12, minute: 58, second: 13, millisecond: 48),

new TimeOnly(hour: 16, minute: 44, second: 39, millisecond: 925),

new TimeOnly(hour: 17, minute: 22, second: 36, millisecond: 471),

new TimeOnly(hour: 7, minute: 15, second: 27, millisecond: 538),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 22, minute: 10, second: 9, millisecond: 9),

new TimeOnly(hour: 15, minute: 40, second: 3, millisecond: 830),

new TimeOnly(hour: 8, minute: 1, second: 49, millisecond: 253),

new TimeOnly(hour: 20, minute: 10, second: 46, millisecond: 539),

},
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 14, minute: 55, second: 37, millisecond: 973),

new TimeOnly(hour: 18, minute: 5, second: 37, millisecond: 325),

new TimeOnly(hour: 12, minute: 54, second: 13, millisecond: 435),

new TimeOnly(hour: 8, minute: 1, second: 25, millisecond: 95),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 6, minute: 19, second: 53, millisecond: 361),

new TimeOnly(hour: 15, minute: 5, second: 47, millisecond: 618),

new TimeOnly(hour: 5, minute: 38, second: 56, millisecond: 15),

new TimeOnly(hour: 4, minute: 45, second: 54, millisecond: 829),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 2, minute: 8, second: 54, millisecond: 119),

new TimeOnly(hour: 17, minute: 31, second: 37, millisecond: 587),

new TimeOnly(hour: 22, minute: 1, second: 54, millisecond: 605),

},
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 5, minute: 55, second: 12, millisecond: 180),

new TimeOnly(hour: 13, minute: 50, second: 57, millisecond: 147),

new TimeOnly(hour: 16, minute: 48, second: 11, millisecond: 817),

new TimeOnly(hour: 2, minute: 8, second: 20, millisecond: 638),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 13, minute: 54, second: 40, millisecond: 812),

new TimeOnly(hour: 7, minute: 14, second: 43, millisecond: 630),

new TimeOnly(hour: 7, minute: 30, second: 34, millisecond: 656),

new TimeOnly(hour: 3, minute: 6, second: 8, millisecond: 317),

},
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 7, minute: 25, second: 47, millisecond: 698),

new TimeOnly(hour: 9, minute: 29, second: 54, millisecond: 279),

new TimeOnly(hour: 20, minute: 38, second: 56, millisecond: 98),

new TimeOnly(hour: 13, minute: 17, second: 22, millisecond: 256),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 4, minute: 17, second: 16, millisecond: 358),

new TimeOnly(hour: 11, minute: 47, second: 9, millisecond: 237),

new TimeOnly(hour: 4, minute: 46, second: 11, millisecond: 491),

new TimeOnly(hour: 15, minute: 24, second: 4, millisecond: 921),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 3, minute: 6, second: 12, millisecond: 842),

new TimeOnly(hour: 22, minute: 40, second: 20, millisecond: 152),

new TimeOnly(hour: 12, minute: 41, second: 56, millisecond: 189),

new TimeOnly(hour: 9, minute: 24, second: 51, millisecond: 950),

},
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 7, minute: 0, second: 42, millisecond: 302),

new TimeOnly(hour: 11, minute: 40, second: 26, millisecond: 765),

new TimeOnly(hour: 5, minute: 31, second: 45, millisecond: 672),

new TimeOnly(hour: 6, minute: 13, second: 43, millisecond: 260),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 0, minute: 24, second: 24, millisecond: 285),

new TimeOnly(hour: 10, minute: 28, second: 15, millisecond: 475),

new TimeOnly(hour: 5, minute: 38, second: 56, millisecond: 381),

},
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 7, minute: 2, second: 21, millisecond: 510),

new TimeOnly(hour: 18, minute: 46, second: 27, millisecond: 535),

new TimeOnly(hour: 7, minute: 6, second: 12, millisecond: 87),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 8, minute: 48, second: 20, millisecond: 834),

new TimeOnly(hour: 16, minute: 37, second: 2, millisecond: 291),

new TimeOnly(hour: 9, minute: 3, second: 16, millisecond: 197),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 9, minute: 22, second: 43, millisecond: 85),

new TimeOnly(hour: 14, minute: 57, second: 16, millisecond: 711),

new TimeOnly(hour: 13, minute: 53, second: 53, millisecond: 918),

new TimeOnly(hour: 9, minute: 42, second: 42, millisecond: 235),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 11, minute: 56, second: 50, millisecond: 875),

new TimeOnly(hour: 10, minute: 24, second: 14, millisecond: 38),

new TimeOnly(hour: 21, minute: 50, second: 28, millisecond: 872),

},
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 96,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 8, minute: 3, second: 31, millisecond: 580),

new TimeOnly(hour: 19, minute: 0, second: 52, millisecond: 899),

new TimeOnly(hour: 22, minute: 50, second: 38, millisecond: 157),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 103,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 6, minute: 54, second: 46, millisecond: 647),

new TimeOnly(hour: 1, minute: 7, second: 20, millisecond: 614),

new TimeOnly(hour: 8, minute: 13, second: 33, millisecond: 41),

new TimeOnly(hour: 21, minute: 52, second: 25, millisecond: 114),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 11, minute: 26, second: 53, millisecond: 416),

new TimeOnly(hour: 22, minute: 7, second: 45, millisecond: 955),

new TimeOnly(hour: 12, minute: 31, second: 45, millisecond: 818),

new TimeOnly(hour: 18, minute: 5, second: 17, millisecond: 720),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 18, minute: 45, second: 18, millisecond: 620),

new TimeOnly(hour: 17, minute: 44, second: 18, millisecond: 905),

new TimeOnly(hour: 16, minute: 2, second: 17, millisecond: 49),

},
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 110,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 5, minute: 14, second: 0, millisecond: 977),

new TimeOnly(hour: 20, minute: 38, second: 49, millisecond: 717),

new TimeOnly(hour: 15, minute: 46, second: 24, millisecond: 921),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 16, minute: 0, second: 27, millisecond: 315),

new TimeOnly(hour: 20, minute: 33, second: 39, millisecond: 441),

new TimeOnly(hour: 12, minute: 24, second: 54, millisecond: 319),

new TimeOnly(hour: 7, minute: 38, second: 10, millisecond: 19),

},
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 111,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 12, minute: 16, second: 46, millisecond: 174),

new TimeOnly(hour: 15, minute: 2, second: 57, millisecond: 769),

new TimeOnly(hour: 16, minute: 4, second: 26, millisecond: 863),

new TimeOnly(hour: 3, minute: 16, second: 11, millisecond: 510),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 22, minute: 34, second: 31, millisecond: 906),

new TimeOnly(hour: 21, minute: 0, second: 39, millisecond: 881),

new TimeOnly(hour: 15, minute: 39, second: 4, millisecond: 415),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 118,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 0, minute: 51, second: 37, millisecond: 853),

new TimeOnly(hour: 20, minute: 43, second: 52, millisecond: 336),

new TimeOnly(hour: 7, minute: 47, second: 12, millisecond: 244),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 126,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 4, minute: 10, second: 34, millisecond: 254),

new TimeOnly(hour: 5, minute: 23, second: 33, millisecond: 528),

new TimeOnly(hour: 11, minute: 20, second: 13, millisecond: 109),

new TimeOnly(hour: 3, minute: 38, second: 26, millisecond: 993),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 11, minute: 33, second: 17, millisecond: 699),

new TimeOnly(hour: 2, minute: 21, second: 24, millisecond: 325),

new TimeOnly(hour: 19, minute: 57, second: 4, millisecond: 420),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 11, minute: 21, second: 42, millisecond: 755),

new TimeOnly(hour: 18, minute: 33, second: 40, millisecond: 559),

new TimeOnly(hour: 5, minute: 12, second: 13, millisecond: 80),

new TimeOnly(hour: 12, minute: 13, second: 1, millisecond: 728),

},
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 133,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 8, minute: 53, second: 22, millisecond: 619),

new TimeOnly(hour: 9, minute: 56, second: 24, millisecond: 639),

new TimeOnly(hour: 0, minute: 56, second: 56, millisecond: 829),

new TimeOnly(hour: 19, minute: 2, second: 2, millisecond: 133),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 140,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 0, minute: 28, second: 0, millisecond: 187),

new TimeOnly(hour: 9, minute: 15, second: 46, millisecond: 292),

new TimeOnly(hour: 10, minute: 20, second: 9, millisecond: 335),

new TimeOnly(hour: 0, minute: 4, second: 1, millisecond: 111),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 3, minute: 14, second: 4, millisecond: 700),

new TimeOnly(hour: 17, minute: 5, second: 37, millisecond: 430),

new TimeOnly(hour: 18, minute: 52, second: 14, millisecond: 957),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 9, minute: 40, second: 32, millisecond: 515),

new TimeOnly(hour: 11, minute: 4, second: 41, millisecond: 457),

new TimeOnly(hour: 22, minute: 48, second: 55, millisecond: 761),

new TimeOnly(hour: 21, minute: 37, second: 8, millisecond: 762),

},
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 146,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 12, minute: 0, second: 54, millisecond: 613),

new TimeOnly(hour: 11, minute: 27, second: 19, millisecond: 64),

new TimeOnly(hour: 12, minute: 40, second: 28, millisecond: 484),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 155,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 19, minute: 36, second: 12, millisecond: 521),

new TimeOnly(hour: 5, minute: 28, second: 41, millisecond: 691),

new TimeOnly(hour: 21, minute: 26, second: 28, millisecond: 596),

new TimeOnly(hour: 2, minute: 43, second: 0, millisecond: 746),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 5, minute: 43, second: 36, millisecond: 843),

new TimeOnly(hour: 4, minute: 1, second: 17, millisecond: 415),

new TimeOnly(hour: 0, minute: 58, second: 17, millisecond: 694),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 16, minute: 5, second: 39, millisecond: 250),

new TimeOnly(hour: 3, minute: 7, second: 55, millisecond: 323),

new TimeOnly(hour: 0, minute: 49, second: 39, millisecond: 141),

new TimeOnly(hour: 6, minute: 22, second: 49, millisecond: 364),

},
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 164,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 8, minute: 29, second: 5, millisecond: 496),

new TimeOnly(hour: 16, minute: 48, second: 39, millisecond: 799),

new TimeOnly(hour: 10, minute: 54, second: 35, millisecond: 855),

new TimeOnly(hour: 14, minute: 2, second: 4, millisecond: 545),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 6, minute: 20, second: 5, millisecond: 923),

new TimeOnly(hour: 14, minute: 35, second: 54, millisecond: 945),

new TimeOnly(hour: 16, minute: 16, second: 5, millisecond: 728),

},
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 172,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 1, minute: 6, second: 42, millisecond: 485),

new TimeOnly(hour: 12, minute: 48, second: 18, millisecond: 723),

new TimeOnly(hour: 14, minute: 55, second: 13, millisecond: 523),

new TimeOnly(hour: 7, minute: 9, second: 27, millisecond: 492),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 11, minute: 13, second: 22, millisecond: 385),

new TimeOnly(hour: 3, minute: 27, second: 36, millisecond: 337),

new TimeOnly(hour: 5, minute: 24, second: 40, millisecond: 75),

new TimeOnly(hour: 19, minute: 50, second: 49, millisecond: 661),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 9, minute: 9, second: 34, millisecond: 82),

new TimeOnly(hour: 0, minute: 3, second: 37, millisecond: 74),

new TimeOnly(hour: 5, minute: 27, second: 24, millisecond: 296),

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
                parametr1.Value = 19;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 68;
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
                        Assert.That(models, Has.Count.EqualTo(27));
FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[3], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[4], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[5], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[6], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[7], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[5],_testData[8], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[6],_testData[9], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[7],_testData[10], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[8],_testData[11], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[9],_testData[12], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[10],_testData[13], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[11],_testData[14], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[12],_testData[15], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[13],_testData[16], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[14],_testData[17], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[15],_testData[18], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[16],_testData[19], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[17],_testData[20], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[18],_testData[21], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[19],_testData[22], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[20],_testData[23], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[21],_testData[24], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[22],_testData[25], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[23],_testData[26], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[24],_testData[27], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[25],_testData[28], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[14], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[15], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[16], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[17], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[18], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[5],_testData[19], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[6],_testData[20], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[7],_testData[21], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[8],_testData[22], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[9],_testData[23], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[10],_testData[24], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[11],_testData[25], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[12],_testData[26], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[13],_testData[27], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[14],_testData[28], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[15],_testData[29], false);
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
                parametr1.Value = 10;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 110;
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
                        Assert.That(models, Has.Count.EqualTo(28));
FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[2], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[3], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[4], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[5], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[6], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[5],_testData[7], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[6],_testData[8], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[7],_testData[9], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[8],_testData[10], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[9],_testData[11], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[10],_testData[12], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[11],_testData[13], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[12],_testData[14], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[13],_testData[15], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[14],_testData[16], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[15],_testData[17], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[16],_testData[18], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[17],_testData[19], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[18],_testData[20], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[19],_testData[21], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[20],_testData[22], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[21],_testData[23], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[22],_testData[24], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[23],_testData[25], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[24],_testData[26], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[25],_testData[27], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[26],_testData[28], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));
FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[21], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[22], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[23], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[24], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[25], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[5],_testData[26], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[6],_testData[27], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[7],_testData[28], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[8],_testData[29], false);
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
                parametr1.Value = 110;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 96;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
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
                        Assert.That(models, Has.Count.EqualTo(11));
TimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[19], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[20], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[21], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[22], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[23], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[5],_testData[24], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[6],_testData[25], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[7],_testData[26], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[8],_testData[27], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[9],_testData[28], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[10],_testData[29], false);
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
                parametr1.Value = 67;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 82;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));
TimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[13], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[14], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[15], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[16], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[17], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[5],_testData[18], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[6],_testData[19], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[7],_testData[20], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[8],_testData[21], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[9],_testData[22], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[10],_testData[23], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[11],_testData[24], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[12],_testData[25], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[13],_testData[26], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[14],_testData[27], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[15],_testData[28], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));
TimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[17], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[18], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[19], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[20], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[21], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[5],_testData[22], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[6],_testData[23], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[7],_testData[24], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[8],_testData[25], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[9],_testData[26], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[10],_testData[27], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[11],_testData[28], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[12],_testData[29], false);
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
                foreach(var batchResult in await ((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 118, query1, 71, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));
FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[23], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[24], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[25], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[26], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[27], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[5],_testData[28], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[6],_testData[29], false);
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
                foreach(var batchResult in  ((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionDynQuerySelectModelBatch(connection, 140, query1, 41, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));
FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[26], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[27], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[28], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[7], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[8], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[9], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[10], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[11], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[5],_testData[12], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[6],_testData[13], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[7],_testData[14], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[8],_testData[15], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[9],_testData[16], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[10],_testData[17], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[11],_testData[18], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[12],_testData[19], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[13],_testData[20], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[14],_testData[21], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[15],_testData[22], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[16],_testData[23], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[17],_testData[24], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[18],_testData[25], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[19],_testData[26], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[20],_testData[27], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[21],_testData[28], false);FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[22],_testData[29], false);
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
                foreach(var batchResult in await ((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionSelectModelBatchAsync(connection, 50, 67))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));
TimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[8], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[9], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[10], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[11], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[12], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[5],_testData[13], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[6],_testData[14], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[7],_testData[15], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[8],_testData[16], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[9],_testData[17], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[10],_testData[18], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[11],_testData[19], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[12],_testData[20], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[13],_testData[21], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[14],_testData[22], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[15],_testData[23], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[16],_testData[24], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[17],_testData[25], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[18],_testData[26], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[19],_testData[27], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[20],_testData[28], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));
TimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[13], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[14], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[15], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[16], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[17], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[5],_testData[18], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[6],_testData[19], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[7],_testData[20], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[8],_testData[21], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[9],_testData[22], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[10],_testData[23], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[11],_testData[24], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[12],_testData[25], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[13],_testData[26], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[14],_testData[27], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[15],_testData[28], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[16],_testData[29], false);
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
                foreach(var batchResult in  ((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionSelectModelBatch(connection, 68, 35))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
TimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[14], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[15], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[16], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[17], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[18], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[5],_testData[19], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[6],_testData[20], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[7],_testData[21], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[8],_testData[22], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[9],_testData[23], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[10],_testData[24], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[11],_testData[25], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[12],_testData[26], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[13],_testData[27], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[14],_testData[28], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
TimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[6], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[7], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[8], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[9], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[10], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[5],_testData[11], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[6],_testData[12], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[7],_testData[13], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[8],_testData[14], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[9],_testData[15], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[10],_testData[16], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[11],_testData[17], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[12],_testData[18], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[13],_testData[19], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[14],_testData[20], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[15],_testData[21], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[16],_testData[22], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[17],_testData[23], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[18],_testData[24], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[19],_testData[25], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[20],_testData[26], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[21],_testData[27], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[22],_testData[28], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[23],_testData[29], false);
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
                ((ITimeOnlyListtime_without_time_zoneArray)this).SetDbConnectionSelectModelParametrs(cmd, 50);
                var models = await ((ITimeOnlyListtime_without_time_zoneArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(22));
TimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[8], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[9], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[10], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[11], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[12], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[5],_testData[13], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[6],_testData[14], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[7],_testData[15], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[8],_testData[16], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[9],_testData[17], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[10],_testData[18], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[11],_testData[19], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[12],_testData[20], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[13],_testData[21], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[14],_testData[22], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[15],_testData[23], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[16],_testData[24], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[17],_testData[25], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[18],_testData[26], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[19],_testData[27], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[20],_testData[28], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[21],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ITimeOnlyListtime_without_time_zoneArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((ITimeOnlyListtime_without_time_zoneArray)this).SetDbConnectionSelectModelParametrs(cmd, 50);
                var models =  ((ITimeOnlyListtime_without_time_zoneArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(22));
TimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[8], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[9], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[10], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[11], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[12], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[5],_testData[13], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[6],_testData[14], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[7],_testData[15], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[8],_testData[16], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[9],_testData[17], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[10],_testData[18], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[11],_testData[19], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[12],_testData[20], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[13],_testData[21], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[14],_testData[22], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[15],_testData[23], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[16],_testData[24], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[17],_testData[25], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[18],_testData[26], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[19],_testData[27], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[20],_testData[28], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[21],_testData[29], false);
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

