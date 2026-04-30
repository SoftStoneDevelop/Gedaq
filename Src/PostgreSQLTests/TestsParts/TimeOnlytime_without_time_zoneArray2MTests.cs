

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
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 12, minute: 29, second: 13, millisecond: 759),

new TimeOnly(hour: 0, minute: 58, second: 19, millisecond: 567),

new TimeOnly(hour: 12, minute: 42, second: 51, millisecond: 174),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 6, minute: 25, second: 44, millisecond: 397),

new TimeOnly(hour: 14, minute: 8, second: 31, millisecond: 894),

new TimeOnly(hour: 15, minute: 16, second: 43, millisecond: 535),

new TimeOnly(hour: 7, minute: 45, second: 10, millisecond: 114),

},
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 17, minute: 27, second: 3, millisecond: 936),

new TimeOnly(hour: 13, minute: 47, second: 29, millisecond: 554),

new TimeOnly(hour: 5, minute: 22, second: 53, millisecond: 465),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 19, minute: 53, second: 15, millisecond: 352),

new TimeOnly(hour: 17, minute: 25, second: 11, millisecond: 889),

new TimeOnly(hour: 17, minute: 32, second: 35, millisecond: 824),

new TimeOnly(hour: 2, minute: 18, second: 52, millisecond: 752),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 4, minute: 40, second: 40, millisecond: 711),

new TimeOnly(hour: 4, minute: 48, second: 31, millisecond: 778),

new TimeOnly(hour: 16, minute: 28, second: 49, millisecond: 34),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 3, minute: 29, second: 12, millisecond: 628),

new TimeOnly(hour: 21, minute: 23, second: 2, millisecond: 844),

new TimeOnly(hour: 22, minute: 49, second: 9, millisecond: 356),

new TimeOnly(hour: 21, minute: 54, second: 42, millisecond: 163),

},
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 9, minute: 46, second: 33, millisecond: 320),

new TimeOnly(hour: 6, minute: 54, second: 36, millisecond: 58),

new TimeOnly(hour: 13, minute: 50, second: 35, millisecond: 392),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 21, minute: 9, second: 18, millisecond: 458),

new TimeOnly(hour: 22, minute: 23, second: 43, millisecond: 118),

new TimeOnly(hour: 18, minute: 55, second: 9, millisecond: 753),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 17, minute: 37, second: 32, millisecond: 928),

new TimeOnly(hour: 16, minute: 43, second: 10, millisecond: 643),

new TimeOnly(hour: 3, minute: 4, second: 29, millisecond: 796),

new TimeOnly(hour: 6, minute: 48, second: 54, millisecond: 605),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 19, minute: 14, second: 45, millisecond: 782),

new TimeOnly(hour: 14, minute: 17, second: 4, millisecond: 971),

new TimeOnly(hour: 5, minute: 6, second: 36, millisecond: 322),

new TimeOnly(hour: 15, minute: 58, second: 30, millisecond: 17),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 22, minute: 36, second: 55, millisecond: 541),

new TimeOnly(hour: 5, minute: 6, second: 7, millisecond: 300),

new TimeOnly(hour: 10, minute: 38, second: 52, millisecond: 909),

},
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 7, minute: 19, second: 54, millisecond: 666),

new TimeOnly(hour: 18, minute: 56, second: 1, millisecond: 220),

new TimeOnly(hour: 19, minute: 48, second: 50, millisecond: 508),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 0, minute: 27, second: 31, millisecond: 990),

new TimeOnly(hour: 21, minute: 47, second: 0, millisecond: 770),

new TimeOnly(hour: 9, minute: 20, second: 31, millisecond: 648),

new TimeOnly(hour: 6, minute: 56, second: 43, millisecond: 402),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 18, minute: 45, second: 12, millisecond: 979),

new TimeOnly(hour: 2, minute: 17, second: 46, millisecond: 519),

new TimeOnly(hour: 22, minute: 46, second: 53, millisecond: 861),

new TimeOnly(hour: 12, minute: 33, second: 49, millisecond: 972),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 7, minute: 18, second: 37, millisecond: 142),

new TimeOnly(hour: 18, minute: 7, second: 24, millisecond: 599),

new TimeOnly(hour: 9, minute: 21, second: 2, millisecond: 658),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 18, minute: 1, second: 32, millisecond: 206),

new TimeOnly(hour: 4, minute: 26, second: 27, millisecond: 433),

new TimeOnly(hour: 5, minute: 38, second: 30, millisecond: 506),

new TimeOnly(hour: 7, minute: 56, second: 2, millisecond: 752),

},
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 5, minute: 26, second: 36, millisecond: 20),

new TimeOnly(hour: 17, minute: 41, second: 16, millisecond: 487),

new TimeOnly(hour: 9, minute: 40, second: 9, millisecond: 679),

new TimeOnly(hour: 0, minute: 49, second: 43, millisecond: 368),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 8, minute: 47, second: 22, millisecond: 748),

new TimeOnly(hour: 16, minute: 58, second: 41, millisecond: 5),

new TimeOnly(hour: 17, minute: 57, second: 19, millisecond: 1),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 0, minute: 48, second: 29, millisecond: 821),

new TimeOnly(hour: 5, minute: 16, second: 25, millisecond: 544),

new TimeOnly(hour: 19, minute: 58, second: 16, millisecond: 302),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 18, minute: 12, second: 55, millisecond: 428),

new TimeOnly(hour: 12, minute: 4, second: 52, millisecond: 489),

new TimeOnly(hour: 11, minute: 7, second: 52, millisecond: 4),

new TimeOnly(hour: 16, minute: 12, second: 11, millisecond: 72),

},
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 19, minute: 38, second: 27, millisecond: 855),

new TimeOnly(hour: 4, minute: 18, second: 43, millisecond: 45),

new TimeOnly(hour: 9, minute: 58, second: 38, millisecond: 147),

new TimeOnly(hour: 2, minute: 0, second: 32, millisecond: 540),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 0, minute: 30, second: 28, millisecond: 155),

new TimeOnly(hour: 1, minute: 38, second: 27, millisecond: 693),

new TimeOnly(hour: 12, minute: 33, second: 27, millisecond: 126),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 5, minute: 56, second: 33, millisecond: 279),

new TimeOnly(hour: 20, minute: 7, second: 11, millisecond: 444),

new TimeOnly(hour: 16, minute: 37, second: 38, millisecond: 22),

new TimeOnly(hour: 4, minute: 39, second: 58, millisecond: 453),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 6, minute: 26, second: 39, millisecond: 792),

new TimeOnly(hour: 8, minute: 20, second: 38, millisecond: 327),

new TimeOnly(hour: 4, minute: 28, second: 5, millisecond: 70),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 11, minute: 3, second: 33, millisecond: 376),

new TimeOnly(hour: 16, minute: 18, second: 5, millisecond: 294),

new TimeOnly(hour: 18, minute: 57, second: 16, millisecond: 809),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 4, minute: 50, second: 21, millisecond: 850),

new TimeOnly(hour: 6, minute: 18, second: 31, millisecond: 703),

new TimeOnly(hour: 8, minute: 46, second: 45, millisecond: 465),

new TimeOnly(hour: 2, minute: 34, second: 34, millisecond: 500),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 2, minute: 55, second: 11, millisecond: 712),

new TimeOnly(hour: 15, minute: 22, second: 46, millisecond: 929),

new TimeOnly(hour: 18, minute: 0, second: 34, millisecond: 448),

new TimeOnly(hour: 15, minute: 5, second: 56, millisecond: 642),

},
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 16, minute: 57, second: 37, millisecond: 393),

new TimeOnly(hour: 4, minute: 42, second: 26, millisecond: 234),

new TimeOnly(hour: 12, minute: 5, second: 17, millisecond: 530),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 15, minute: 15, second: 7, millisecond: 396),

new TimeOnly(hour: 8, minute: 34, second: 46, millisecond: 101),

new TimeOnly(hour: 9, minute: 29, second: 8, millisecond: 523),

},
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 6, minute: 16, second: 0, millisecond: 101),

new TimeOnly(hour: 17, minute: 26, second: 50, millisecond: 307),

new TimeOnly(hour: 7, minute: 17, second: 31, millisecond: 777),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 8, minute: 51, second: 49, millisecond: 281),

new TimeOnly(hour: 22, minute: 38, second: 2, millisecond: 582),

new TimeOnly(hour: 13, minute: 31, second: 38, millisecond: 366),

new TimeOnly(hour: 3, minute: 0, second: 27, millisecond: 690),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 20, minute: 16, second: 8, millisecond: 507),

new TimeOnly(hour: 11, minute: 17, second: 16, millisecond: 765),

new TimeOnly(hour: 18, minute: 7, second: 34, millisecond: 878),

},
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 7, minute: 58, second: 53, millisecond: 869),

new TimeOnly(hour: 17, minute: 20, second: 33, millisecond: 845),

new TimeOnly(hour: 21, minute: 18, second: 30, millisecond: 38),

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
new TimeOnly(hour: 4, minute: 5, second: 45, millisecond: 373),

new TimeOnly(hour: 2, minute: 26, second: 54, millisecond: 131),

new TimeOnly(hour: 1, minute: 50, second: 14, millisecond: 573),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 20, minute: 10, second: 5, millisecond: 104),

new TimeOnly(hour: 18, minute: 16, second: 10, millisecond: 900),

new TimeOnly(hour: 17, minute: 44, second: 57, millisecond: 35),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 17, minute: 47, second: 32, millisecond: 619),

new TimeOnly(hour: 17, minute: 53, second: 40, millisecond: 478),

new TimeOnly(hour: 4, minute: 55, second: 10, millisecond: 91),

new TimeOnly(hour: 8, minute: 29, second: 31, millisecond: 773),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 4, minute: 44, second: 14, millisecond: 615),

new TimeOnly(hour: 15, minute: 26, second: 35, millisecond: 727),

new TimeOnly(hour: 18, minute: 14, second: 56, millisecond: 569),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 15, minute: 26, second: 47, millisecond: 436),

new TimeOnly(hour: 7, minute: 34, second: 37, millisecond: 646),

new TimeOnly(hour: 11, minute: 23, second: 45, millisecond: 526),

new TimeOnly(hour: 19, minute: 6, second: 51, millisecond: 730),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 22, minute: 20, second: 18, millisecond: 461),

new TimeOnly(hour: 14, minute: 47, second: 56, millisecond: 294),

new TimeOnly(hour: 9, minute: 45, second: 55, millisecond: 834),

},
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 20, minute: 49, second: 11, millisecond: 307),

new TimeOnly(hour: 2, minute: 36, second: 22, millisecond: 401),

new TimeOnly(hour: 22, minute: 1, second: 3, millisecond: 612),

new TimeOnly(hour: 21, minute: 8, second: 4, millisecond: 356),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 17, minute: 21, second: 46, millisecond: 506),

new TimeOnly(hour: 16, minute: 30, second: 46, millisecond: 540),

new TimeOnly(hour: 15, minute: 36, second: 43, millisecond: 388),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 20, minute: 37, second: 44, millisecond: 379),

new TimeOnly(hour: 12, minute: 46, second: 26, millisecond: 901),

new TimeOnly(hour: 10, minute: 50, second: 50, millisecond: 672),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 6, minute: 24, second: 17, millisecond: 238),

new TimeOnly(hour: 6, minute: 21, second: 3, millisecond: 459),

new TimeOnly(hour: 18, minute: 1, second: 12, millisecond: 0),

new TimeOnly(hour: 5, minute: 22, second: 50, millisecond: 828),

},
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 0, minute: 13, second: 43, millisecond: 410),

new TimeOnly(hour: 9, minute: 34, second: 9, millisecond: 235),

new TimeOnly(hour: 3, minute: 11, second: 9, millisecond: 173),

new TimeOnly(hour: 8, minute: 40, second: 42, millisecond: 548),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 16, minute: 54, second: 55, millisecond: 62),

new TimeOnly(hour: 9, minute: 52, second: 8, millisecond: 557),

new TimeOnly(hour: 2, minute: 7, second: 16, millisecond: 272),

new TimeOnly(hour: 13, minute: 43, second: 5, millisecond: 167),

},
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 96,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 15, minute: 58, second: 8, millisecond: 473),

new TimeOnly(hour: 10, minute: 14, second: 49, millisecond: 458),

new TimeOnly(hour: 16, minute: 32, second: 18, millisecond: 659),

new TimeOnly(hour: 6, minute: 7, second: 42, millisecond: 486),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 6, minute: 41, second: 7, millisecond: 56),

new TimeOnly(hour: 4, minute: 47, second: 51, millisecond: 186),

new TimeOnly(hour: 20, minute: 55, second: 18, millisecond: 446),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 19, minute: 58, second: 33, millisecond: 850),

new TimeOnly(hour: 11, minute: 47, second: 20, millisecond: 693),

new TimeOnly(hour: 22, minute: 40, second: 3, millisecond: 887),

},
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 100,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 17, minute: 7, second: 46, millisecond: 554),

new TimeOnly(hour: 19, minute: 44, second: 53, millisecond: 591),

new TimeOnly(hour: 10, minute: 13, second: 47, millisecond: 334),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 106,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 9, minute: 52, second: 47, millisecond: 161),

new TimeOnly(hour: 21, minute: 10, second: 33, millisecond: 422),

new TimeOnly(hour: 10, minute: 38, second: 42, millisecond: 855),

new TimeOnly(hour: 15, minute: 55, second: 22, millisecond: 839),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 11, minute: 26, second: 43, millisecond: 543),

new TimeOnly(hour: 12, minute: 34, second: 30, millisecond: 178),

new TimeOnly(hour: 14, minute: 0, second: 47, millisecond: 346),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 18, minute: 24, second: 24, millisecond: 811),

new TimeOnly(hour: 5, minute: 4, second: 48, millisecond: 871),

new TimeOnly(hour: 20, minute: 38, second: 34, millisecond: 80),

new TimeOnly(hour: 9, minute: 27, second: 8, millisecond: 71),

},
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 108,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 10, minute: 20, second: 49, millisecond: 686),

new TimeOnly(hour: 5, minute: 1, second: 36, millisecond: 898),

new TimeOnly(hour: 16, minute: 25, second: 40, millisecond: 29),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 7, minute: 4, second: 34, millisecond: 855),

new TimeOnly(hour: 12, minute: 37, second: 12, millisecond: 330),

new TimeOnly(hour: 2, minute: 48, second: 22, millisecond: 524),

},
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 110,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 4, minute: 23, second: 55, millisecond: 555),

new TimeOnly(hour: 2, minute: 20, second: 31, millisecond: 651),

new TimeOnly(hour: 18, minute: 48, second: 53, millisecond: 735),

new TimeOnly(hour: 3, minute: 57, second: 4, millisecond: 941),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 11, minute: 25, second: 37, millisecond: 255),

new TimeOnly(hour: 19, minute: 54, second: 30, millisecond: 949),

new TimeOnly(hour: 11, minute: 28, second: 7, millisecond: 818),

new TimeOnly(hour: 18, minute: 36, second: 2, millisecond: 517),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 21, minute: 20, second: 15, millisecond: 803),

new TimeOnly(hour: 14, minute: 1, second: 38, millisecond: 603),

new TimeOnly(hour: 3, minute: 36, second: 41, millisecond: 843),

new TimeOnly(hour: 20, minute: 24, second: 45, millisecond: 950),

},
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 3, minute: 37, second: 50, millisecond: 19),

new TimeOnly(hour: 8, minute: 53, second: 9, millisecond: 872),

new TimeOnly(hour: 19, minute: 40, second: 22, millisecond: 625),

new TimeOnly(hour: 14, minute: 23, second: 58, millisecond: 3),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 6, minute: 17, second: 1, millisecond: 969),

new TimeOnly(hour: 4, minute: 16, second: 23, millisecond: 842),

new TimeOnly(hour: 18, minute: 15, second: 20, millisecond: 567),

},
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 118,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 21, minute: 9, second: 29, millisecond: 970),

new TimeOnly(hour: 17, minute: 22, second: 39, millisecond: 131),

new TimeOnly(hour: 15, minute: 25, second: 3, millisecond: 635),

new TimeOnly(hour: 20, minute: 12, second: 5, millisecond: 952),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 9, minute: 42, second: 9, millisecond: 184),

new TimeOnly(hour: 9, minute: 50, second: 9, millisecond: 809),

new TimeOnly(hour: 18, minute: 12, second: 53, millisecond: 388),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 124,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 5, minute: 5, second: 38, millisecond: 806),

new TimeOnly(hour: 1, minute: 41, second: 47, millisecond: 731),

new TimeOnly(hour: 17, minute: 27, second: 14, millisecond: 299),

},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 129,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 3, minute: 42, second: 18, millisecond: 415),

new TimeOnly(hour: 3, minute: 5, second: 45, millisecond: 677),

new TimeOnly(hour: 22, minute: 32, second: 15, millisecond: 519),

new TimeOnly(hour: 1, minute: 43, second: 54, millisecond: 356),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 7, minute: 31, second: 9, millisecond: 171),

new TimeOnly(hour: 3, minute: 43, second: 52, millisecond: 489),

new TimeOnly(hour: 16, minute: 5, second: 14, millisecond: 117),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 10, minute: 18, second: 14, millisecond: 866),

new TimeOnly(hour: 16, minute: 48, second: 55, millisecond: 856),

new TimeOnly(hour: 3, minute: 43, second: 21, millisecond: 992),

},
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 136,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 13, minute: 8, second: 47, millisecond: 983),

new TimeOnly(hour: 16, minute: 56, second: 12, millisecond: 436),

new TimeOnly(hour: 0, minute: 52, second: 31, millisecond: 615),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 3, minute: 50, second: 36, millisecond: 252),

new TimeOnly(hour: 18, minute: 27, second: 25, millisecond: 649),

new TimeOnly(hour: 14, minute: 44, second: 2, millisecond: 523),

new TimeOnly(hour: 5, minute: 23, second: 21, millisecond: 117),

},
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 141,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 8, minute: 31, second: 41, millisecond: 579),

new TimeOnly(hour: 17, minute: 33, second: 9, millisecond: 703),

new TimeOnly(hour: 20, minute: 24, second: 39, millisecond: 742),

new TimeOnly(hour: 1, minute: 9, second: 29, millisecond: 308),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 4, minute: 7, second: 7, millisecond: 58),

new TimeOnly(hour: 9, minute: 13, second: 29, millisecond: 128),

new TimeOnly(hour: 6, minute: 58, second: 58, millisecond: 90),

new TimeOnly(hour: 7, minute: 10, second: 14, millisecond: 446),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 7, minute: 12, second: 38, millisecond: 401),

new TimeOnly(hour: 6, minute: 47, second: 36, millisecond: 642),

new TimeOnly(hour: 0, minute: 46, second: 54, millisecond: 599),

new TimeOnly(hour: 5, minute: 55, second: 41, millisecond: 542),

},
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 142,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 2, minute: 8, second: 54, millisecond: 332),

new TimeOnly(hour: 8, minute: 36, second: 33, millisecond: 780),

new TimeOnly(hour: 6, minute: 29, second: 38, millisecond: 980),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 0, minute: 27, second: 50, millisecond: 734),

new TimeOnly(hour: 14, minute: 56, second: 7, millisecond: 84),

new TimeOnly(hour: 10, minute: 35, second: 26, millisecond: 523),

new TimeOnly(hour: 17, minute: 25, second: 55, millisecond: 57),

},
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 146,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 12, minute: 35, second: 49, millisecond: 84),

new TimeOnly(hour: 0, minute: 23, second: 49, millisecond: 616),

new TimeOnly(hour: 2, minute: 4, second: 22, millisecond: 565),

},
    ModelInner = new TimeOnlytime_without_time_zoneArray2MI
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 5, minute: 39, second: 12, millisecond: 650),

new TimeOnly(hour: 6, minute: 58, second: 45, millisecond: 547),

new TimeOnly(hour: 18, minute: 21, second: 43, millisecond: 737),

},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 9, minute: 55, second: 36, millisecond: 961),

new TimeOnly(hour: 22, minute: 40, second: 11, millisecond: 889),

new TimeOnly(hour: 15, minute: 6, second: 50, millisecond: 38),

new TimeOnly(hour: 10, minute: 5, second: 24, millisecond: 776),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(4)
{
new TimeOnly(hour: 13, minute: 15, second: 40, millisecond: 355),

new TimeOnly(hour: 7, minute: 18, second: 54, millisecond: 822),

new TimeOnly(hour: 12, minute: 45, second: 47, millisecond: 596),

new TimeOnly(hour: 11, minute: 5, second: 38, millisecond: 585),

},
},
            new TimeOnlytime_without_time_zoneArray2M
{
    Id = 154,
    Value = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 3, minute: 32, second: 46, millisecond: 48),

new TimeOnly(hour: 2, minute: 8, second: 15, millisecond: 645),

new TimeOnly(hour: 20, minute: 38, second: 58, millisecond: 978),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.TimeOnly>(3)
{
new TimeOnly(hour: 4, minute: 46, second: 41, millisecond: 31),

new TimeOnly(hour: 10, minute: 45, second: 56, millisecond: 814),

new TimeOnly(hour: 5, minute: 20, second: 29, millisecond: 559),

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

                id = await ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

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
                models = await ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[30], true);
                models = await ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[31], true);
                models = await ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[32], true);
                models = await ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[33], true);
                models = await ((ITimeOnlyListtime_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[34], true);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 3;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 11;
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
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
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
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[30],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 84;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 18;
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
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
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
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[28],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 78;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 78;
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
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[18],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 65;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 142;
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
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
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
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[1],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 63;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 11;
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
                        Assert.That(models, Has.Count.EqualTo(23));

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
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[18],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[19],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[20],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[21],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[4], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[5], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[5],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[6],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[7],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[8],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[9],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[10],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[11],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[12],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[13],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[14],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[15],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[16],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[17],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[18],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[19],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[20],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[21],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[22],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[23],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[24],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[25],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[26],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[27],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[28],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[29],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[30],_testData[34], false);
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
                parametr1.Value = 11;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 65;
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
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[21],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 76;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 63;
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
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[5],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[6],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[7],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[8],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[9],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[10],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[11],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[12],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[13],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[14],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[15],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[16],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[17],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[18],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

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
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[18],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[19],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[20],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[21],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[22],_testData[34], false);
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
                parametr1.Value = 136;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 76;
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
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[19],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 124;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 3;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[29], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[30], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[31], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[32], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[33], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[1], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[2], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[3], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[4], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[5], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[5],_testData[6], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[6],_testData[7], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[7],_testData[8], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[8],_testData[9], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[9],_testData[10], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[10],_testData[11], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[11],_testData[12], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[12],_testData[13], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[13],_testData[14], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[14],_testData[15], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[15],_testData[16], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[16],_testData[17], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[17],_testData[18], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[18],_testData[19], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[19],_testData[20], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[20],_testData[21], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[21],_testData[22], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[22],_testData[23], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[23],_testData[24], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[24],_testData[25], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[25],_testData[26], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[26],_testData[27], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[27],_testData[28], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[28],_testData[29], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[29],_testData[30], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[30],_testData[31], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[31],_testData[32], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[32],_testData[33], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[33],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 63;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 78;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[12], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[13], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[14], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[15], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[16], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[5],_testData[17], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[6],_testData[18], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[7],_testData[19], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[8],_testData[20], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[9],_testData[21], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[10],_testData[22], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[11],_testData[23], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[12],_testData[24], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[13],_testData[25], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[14],_testData[26], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[15],_testData[27], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[16],_testData[28], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[17],_testData[29], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[18],_testData[30], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[19],_testData[31], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[20],_testData[32], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[21],_testData[33], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[16], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[17], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[18], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[19], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[20], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[5],_testData[21], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[6],_testData[22], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[7],_testData[23], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[8],_testData[24], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[9],_testData[25], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[10],_testData[26], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[11],_testData[27], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[12],_testData[28], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[13],_testData[29], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[14],_testData[30], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[15],_testData[31], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[16],_testData[32], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[17],_testData[33], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[18],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                await ((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 78, query1, 142, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[1],_testData[34], false);
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
                await ((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 136, query1, 81, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[16],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                 ((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 136, query1, 6, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
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
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[31],_testData[34], false);
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
                 ((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 55, query1, 86, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[14],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 118, query1, 76, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[5],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[5],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[6],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[7],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[8],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[9],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[10],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[11],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[12],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[13],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[14],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[15],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[16],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[17],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[18],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[19],_testData[34], false);
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
                await ((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 84, query1, 3, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
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
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[33],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 78, query1, 141, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

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
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[14],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[15],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[16],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[17],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[34], false);
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
                 ((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionDynQuerySelectModelBatch(connection, 141, query1, 100, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(firstItems1[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneArray2M.AssertModel(secondItems2[11],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionSTSelectModelBatchAsync(connection, 73, 129))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

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
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[16],_testData[30], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[17],_testData[31], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[18],_testData[32], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[19],_testData[33], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[30], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[31], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[32], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[33], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((ITimeOnlyListtime_without_time_zoneArray)this).DbConnectionSTSelectModelBatch(connection, 47, 65))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

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
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[20],_testData[30], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[21],_testData[31], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[22],_testData[32], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[23],_testData[33], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

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
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[17],_testData[30], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[18],_testData[31], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[19],_testData[32], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[20],_testData[33], false);
                        TimeOnlytime_without_time_zoneArray2M.AssertModel(models[21],_testData[34], false);
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
                ((ITimeOnlyListtime_without_time_zoneArray)this).SetDbConnectionSelectModelParametrs(cmd, 96);
                var models = await ((ITimeOnlyListtime_without_time_zoneArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(13));
TimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[22], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[23], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[24], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[25], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[26], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[5],_testData[27], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[6],_testData[28], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[7],_testData[29], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[8],_testData[30], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[9],_testData[31], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[10],_testData[32], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[11],_testData[33], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[12],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ITimeOnlyListtime_without_time_zoneArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((ITimeOnlyListtime_without_time_zoneArray)this).SetDbConnectionSelectModelParametrs(cmd, 5);
                var models =  ((ITimeOnlyListtime_without_time_zoneArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(33));
TimeOnlytime_without_time_zoneArray2M.AssertModel(models[0],_testData[2], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[1],_testData[3], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[2],_testData[4], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[3],_testData[5], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[4],_testData[6], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[5],_testData[7], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[6],_testData[8], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[7],_testData[9], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[8],_testData[10], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[9],_testData[11], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[10],_testData[12], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[11],_testData[13], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[12],_testData[14], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[13],_testData[15], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[14],_testData[16], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[15],_testData[17], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[16],_testData[18], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[17],_testData[19], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[18],_testData[20], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[19],_testData[21], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[20],_testData[22], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[21],_testData[23], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[22],_testData[24], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[23],_testData[25], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[24],_testData[26], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[25],_testData[27], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[26],_testData[28], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[27],_testData[29], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[28],_testData[30], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[29],_testData[31], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[30],_testData[32], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[31],_testData[33], false);TimeOnlytime_without_time_zoneArray2M.AssertModel(models[32],_testData[34], false);
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
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
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
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
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

                await ((ITimeOnlyListtime_without_time_zoneArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_timeonlytime_without_time_zonearray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((ITimeOnlyListtime_without_time_zoneArray)this).DynQueryWASelectImportModelInnerAsync(connection);
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
        public  void DynQueryWAImportModelInnerTest()
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

                ((ITimeOnlyListtime_without_time_zoneArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_timeonlytime_without_time_zonearray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((ITimeOnlyListtime_without_time_zoneArray)this).DynQueryWASelectImportModelInner(connection);
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
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<TimeOnlytime_without_time_zoneArray2MIWA>(2);
                for (int i = 8; i < 12; i++)
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
                Assert.That(models, Has.Count.EqualTo(6));
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

        [Test, Order(3)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<TimeOnlytime_without_time_zoneArray2MIWA>(2);
                for (int i = 12; i < 16; i++)
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
                Assert.That(models, Has.Count.EqualTo(8));
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
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneArray))]
        private void WASelectImportModelInnerConfig()
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
            methodName:"WAImportModelInner",
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
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<TimeOnlytime_without_time_zoneArray2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((ITimeOnlyListtime_without_time_zoneArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((ITimeOnlyListtime_without_time_zoneArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
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

        [Test, Order(5)]
        public  void WAImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<TimeOnlytime_without_time_zoneArray2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((ITimeOnlyListtime_without_time_zoneArray)this).WAImportModelInner(connection, importCollection);
                var models = ((ITimeOnlyListtime_without_time_zoneArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
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
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneArray2MIWA)],
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
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(TimeOnlytime_without_time_zoneArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyListtime_without_time_zoneArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<TimeOnlytime_without_time_zoneArray2MIWA>(2);
                for (int i = 24; i < 28; i++)
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

                await ((ITimeOnlyListtime_without_time_zoneArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((ITimeOnlyListtime_without_time_zoneArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
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

        [Test, Order(7)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<TimeOnlytime_without_time_zoneArray2MIWA>(2);
                for (int i = 28; i < 35; i++)
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

                ((ITimeOnlyListtime_without_time_zoneArray)this).ImportModelInner(connection, importCollection);
                var models = ((ITimeOnlyListtime_without_time_zoneArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
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

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<TimeOnlytime_without_time_zoneArray2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((ITimeOnlyListtime_without_time_zoneArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((ITimeOnlyListtime_without_time_zoneArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    TimeOnlytime_without_time_zoneArray2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<TimeOnlytime_without_time_zoneArray2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((ITimeOnlyListtime_without_time_zoneArray)this).ImportModel(connection, importCollection);
                var models = ((ITimeOnlyListtime_without_time_zoneArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    TimeOnlytime_without_time_zoneArray2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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

        [Test, Order(13)]
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

        [Test, Order(13)]
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
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneArray2MIWA), typeof(TimeOnlytime_without_time_zoneArray2MIWA)],
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
                var models1 = new List<TimeOnlytime_without_time_zoneArray2MIWA>();
                var models2 = new List<TimeOnlytime_without_time_zoneArray2MIWA>();
                await ((ITimeOnlyListtime_without_time_zoneArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_timeonlytime_without_time_zonearray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeOnlytime_without_time_zoneArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeOnlytime_without_time_zoneArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<TimeOnlytime_without_time_zoneArray2MIWA>();
                var models2 = new List<TimeOnlytime_without_time_zoneArray2MIWA>();
                ((ITimeOnlyListtime_without_time_zoneArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_timeonlytime_without_time_zonearray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeOnlytime_without_time_zoneArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeOnlytime_without_time_zoneArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneArray2MIWA)],
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
                var models = await ((ITimeOnlyListtime_without_time_zoneArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_timeonlytime_without_time_zonearray2mi
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
                    TimeOnlytime_without_time_zoneArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((ITimeOnlyListtime_without_time_zoneArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_timeonlytime_without_time_zonearray2mi
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
                    TimeOnlytime_without_time_zoneArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneArray2MIWA), typeof(TimeOnlytime_without_time_zoneArray2MIWA)],
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
                var models1 = new List<TimeOnlytime_without_time_zoneArray2MIWA>();
                var models2 = new List<TimeOnlytime_without_time_zoneArray2MIWA>();
                await ((ITimeOnlyListtime_without_time_zoneArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_timeonlytime_without_time_zonearray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeOnlytime_without_time_zoneArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeOnlytime_without_time_zoneArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<TimeOnlytime_without_time_zoneArray2MIWA>();
                var models2 = new List<TimeOnlytime_without_time_zoneArray2MIWA>();
                ((ITimeOnlyListtime_without_time_zoneArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_timeonlytime_without_time_zonearray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeOnlytime_without_time_zoneArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeOnlytime_without_time_zoneArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneArray2MIWA)],
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
                var models = await ((ITimeOnlyListtime_without_time_zoneArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_timeonlytime_without_time_zonearray2mi
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
                    TimeOnlytime_without_time_zoneArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((ITimeOnlyListtime_without_time_zoneArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_timeonlytime_without_time_zonearray2mi
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
                    TimeOnlytime_without_time_zoneArray2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_timeonlytime_without_time_zonearray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneArray2MI), typeof(TimeOnlytime_without_time_zoneArray2MI)],
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
                var models1 = new List<TimeOnlytime_without_time_zoneArray2MI>();
                var models2 = new List<TimeOnlytime_without_time_zoneArray2MI>();
                await ((ITimeOnlyListtime_without_time_zoneArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeOnlytime_without_time_zoneArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeOnlytime_without_time_zoneArray2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<TimeOnlytime_without_time_zoneArray2MI>();
                var models2 = new List<TimeOnlytime_without_time_zoneArray2MI>();
                ((ITimeOnlyListtime_without_time_zoneArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeOnlytime_without_time_zoneArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeOnlytime_without_time_zoneArray2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_timeonlytime_without_time_zonearray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
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
                var models = await ((ITimeOnlyListtime_without_time_zoneArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    TimeOnlytime_without_time_zoneArray2MI.AssertModel(model, expectedModel, false);
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
                var models = ((ITimeOnlyListtime_without_time_zoneArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    TimeOnlytime_without_time_zoneArray2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_timeonlytime_without_time_zonearray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneArray2MIWA), typeof(TimeOnlytime_without_time_zoneArray2MIWA)],
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
                var models1 = new List<TimeOnlytime_without_time_zoneArray2MIWA>();
                var models2 = new List<TimeOnlytime_without_time_zoneArray2MIWA>();
                await ((ITimeOnlyListtime_without_time_zoneArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeOnlytime_without_time_zoneArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeOnlytime_without_time_zoneArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<TimeOnlytime_without_time_zoneArray2MIWA>();
                var models2 = new List<TimeOnlytime_without_time_zoneArray2MIWA>();
                ((ITimeOnlyListtime_without_time_zoneArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeOnlytime_without_time_zoneArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeOnlytime_without_time_zoneArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_timeonlytime_without_time_zonearray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneArray2MIWA)],
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

        [Test, Order(13)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((ITimeOnlyListtime_without_time_zoneArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    TimeOnlytime_without_time_zoneArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((ITimeOnlyListtime_without_time_zoneArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    TimeOnlytime_without_time_zoneArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

