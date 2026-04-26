

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
    internal partial interface ITimeOnlyArraytime_without_time_zoneArray
    {
    }
    
    internal partial class TimeOnlyArraytime_without_time_zoneArray : ITimeOnlyArraytime_without_time_zoneArray
    {


#region TestData

        private readonly TimeOnlytime_without_time_zoneArray1M[] _testData = new TimeOnlytime_without_time_zoneArray1M[]
        {
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 4,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 6, minute: 20, second: 51, millisecond: 12),
new TimeOnly(hour: 20, minute: 55, second: 22, millisecond: 736),
new TimeOnly(hour: 9, minute: 0, second: 16, millisecond: 441),
new TimeOnly(hour: 10, minute: 50, second: 17, millisecond: 953),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 8,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 20, minute: 42, second: 41, millisecond: 415),
new TimeOnly(hour: 5, minute: 21, second: 27, millisecond: 196),
new TimeOnly(hour: 13, minute: 38, second: 39, millisecond: 887),
new TimeOnly(hour: 17, minute: 40, second: 26, millisecond: 967),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 8,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 7, minute: 3, second: 2, millisecond: 965),
new TimeOnly(hour: 2, minute: 31, second: 15, millisecond: 100),
new TimeOnly(hour: 12, minute: 15, second: 14, millisecond: 978),
new TimeOnly(hour: 11, minute: 7, second: 48, millisecond: 809),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 15,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 5, minute: 10, second: 27, millisecond: 210),
new TimeOnly(hour: 17, minute: 37, second: 36, millisecond: 442),
new TimeOnly(hour: 21, minute: 40, second: 15, millisecond: 3),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 23,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 2, minute: 58, second: 28, millisecond: 469),
new TimeOnly(hour: 1, minute: 48, second: 2, millisecond: 4),
new TimeOnly(hour: 19, minute: 56, second: 43, millisecond: 681),
new TimeOnly(hour: 11, minute: 19, second: 16, millisecond: 426),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 16,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 19, minute: 33, second: 57, millisecond: 626),
new TimeOnly(hour: 20, minute: 6, second: 31, millisecond: 984),
new TimeOnly(hour: 16, minute: 35, second: 18, millisecond: 603),
new TimeOnly(hour: 5, minute: 8, second: 54, millisecond: 297),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 21, minute: 3, second: 57, millisecond: 640),
new TimeOnly(hour: 3, minute: 13, second: 16, millisecond: 324),
new TimeOnly(hour: 21, minute: 41, second: 26, millisecond: 271),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 26,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 18, minute: 45, second: 20, millisecond: 991),
new TimeOnly(hour: 6, minute: 46, second: 35, millisecond: 607),
new TimeOnly(hour: 10, minute: 58, second: 41, millisecond: 63),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 27,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 2, minute: 30, second: 5, millisecond: 410),
new TimeOnly(hour: 15, minute: 5, second: 51, millisecond: 725),
new TimeOnly(hour: 6, minute: 44, second: 47, millisecond: 314),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 20,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 12, minute: 19, second: 10, millisecond: 839),
new TimeOnly(hour: 4, minute: 14, second: 46, millisecond: 929),
new TimeOnly(hour: 14, minute: 23, second: 13, millisecond: 411),
new TimeOnly(hour: 13, minute: 58, second: 32, millisecond: 781),
},
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 8, minute: 49, second: 1, millisecond: 260),
new TimeOnly(hour: 19, minute: 31, second: 57, millisecond: 793),
new TimeOnly(hour: 22, minute: 7, second: 46, millisecond: 126),
},
},
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 1, minute: 47, second: 37, millisecond: 424),
new TimeOnly(hour: 0, minute: 5, second: 35, millisecond: 995),
new TimeOnly(hour: 22, minute: 18, second: 44, millisecond: 599),
new TimeOnly(hour: 11, minute: 17, second: 58, millisecond: 317),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 35,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 2, minute: 30, second: 45, millisecond: 954),
new TimeOnly(hour: 12, minute: 37, second: 23, millisecond: 412),
new TimeOnly(hour: 0, minute: 12, second: 56, millisecond: 982),
new TimeOnly(hour: 22, minute: 53, second: 34, millisecond: 556),
},
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 51, second: 10, millisecond: 705),
new TimeOnly(hour: 15, minute: 6, second: 42, millisecond: 802),
new TimeOnly(hour: 17, minute: 8, second: 19, millisecond: 766),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 37,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 8, minute: 32, second: 56, millisecond: 93),
new TimeOnly(hour: 14, minute: 56, second: 43, millisecond: 39),
new TimeOnly(hour: 1, minute: 0, second: 49, millisecond: 256),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 29,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 13, minute: 32, second: 26, millisecond: 326),
new TimeOnly(hour: 8, minute: 6, second: 38, millisecond: 50),
new TimeOnly(hour: 2, minute: 5, second: 15, millisecond: 727),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 5, minute: 18, second: 57, millisecond: 588),
new TimeOnly(hour: 15, minute: 31, second: 25, millisecond: 805),
new TimeOnly(hour: 12, minute: 18, second: 19, millisecond: 358),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 41,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 0, minute: 48, second: 39, millisecond: 594),
new TimeOnly(hour: 21, minute: 32, second: 34, millisecond: 780),
new TimeOnly(hour: 10, minute: 46, second: 20, millisecond: 830),
new TimeOnly(hour: 14, minute: 47, second: 24, millisecond: 923),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 44,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 5, second: 53, millisecond: 108),
new TimeOnly(hour: 1, minute: 6, second: 38, millisecond: 339),
new TimeOnly(hour: 6, minute: 12, second: 30, millisecond: 973),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 33,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 15, minute: 49, second: 30, millisecond: 470),
new TimeOnly(hour: 20, minute: 18, second: 41, millisecond: 568),
new TimeOnly(hour: 6, minute: 32, second: 51, millisecond: 335),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 52,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 17, minute: 3, second: 19, millisecond: 537),
new TimeOnly(hour: 14, minute: 11, second: 40, millisecond: 662),
new TimeOnly(hour: 17, minute: 45, second: 38, millisecond: 808),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 61,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 7, minute: 43, second: 34, millisecond: 854),
new TimeOnly(hour: 2, minute: 6, second: 37, millisecond: 674),
new TimeOnly(hour: 12, minute: 3, second: 37, millisecond: 746),
new TimeOnly(hour: 4, minute: 44, second: 4, millisecond: 559),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 35,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 1, minute: 0, second: 43, millisecond: 840),
new TimeOnly(hour: 10, minute: 55, second: 9, millisecond: 306),
new TimeOnly(hour: 12, minute: 8, second: 43, millisecond: 134),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 4, minute: 14, second: 44, millisecond: 779),
new TimeOnly(hour: 18, minute: 36, second: 40, millisecond: 510),
new TimeOnly(hour: 10, minute: 44, second: 56, millisecond: 711),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 65,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 1, minute: 51, second: 8, millisecond: 104),
new TimeOnly(hour: 9, minute: 25, second: 48, millisecond: 166),
new TimeOnly(hour: 8, minute: 21, second: 5, millisecond: 698),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 72,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 7, minute: 46, second: 53, millisecond: 8),
new TimeOnly(hour: 13, minute: 40, second: 20, millisecond: 328),
new TimeOnly(hour: 2, minute: 57, second: 13, millisecond: 322),
new TimeOnly(hour: 3, minute: 15, second: 55, millisecond: 437),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 36,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 12, minute: 53, second: 53, millisecond: 278),
new TimeOnly(hour: 17, minute: 28, second: 55, millisecond: 441),
new TimeOnly(hour: 5, minute: 51, second: 36, millisecond: 55),
new TimeOnly(hour: 12, minute: 47, second: 33, millisecond: 612),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 75,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 22, minute: 38, second: 47, millisecond: 241),
new TimeOnly(hour: 11, minute: 30, second: 19, millisecond: 470),
new TimeOnly(hour: 1, minute: 35, second: 29, millisecond: 831),
},
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 10, minute: 27, second: 52, millisecond: 110),
new TimeOnly(hour: 11, minute: 34, second: 8, millisecond: 340),
new TimeOnly(hour: 2, minute: 5, second: 15, millisecond: 951),
new TimeOnly(hour: 0, minute: 7, second: 22, millisecond: 898),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 77,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 17, minute: 43, second: 23, millisecond: 575),
new TimeOnly(hour: 13, minute: 40, second: 55, millisecond: 752),
new TimeOnly(hour: 4, minute: 46, second: 25, millisecond: 782),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 38,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 0, minute: 2, second: 6, millisecond: 424),
new TimeOnly(hour: 9, minute: 55, second: 15, millisecond: 373),
new TimeOnly(hour: 16, minute: 47, second: 57, millisecond: 542),
new TimeOnly(hour: 16, minute: 43, second: 57, millisecond: 773),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 82,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 16, second: 23, millisecond: 422),
new TimeOnly(hour: 0, minute: 29, second: 11, millisecond: 165),
new TimeOnly(hour: 7, minute: 14, second: 23, millisecond: 430),
},
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 11, minute: 57, second: 6, millisecond: 338),
new TimeOnly(hour: 13, minute: 13, second: 11, millisecond: 644),
new TimeOnly(hour: 11, minute: 16, second: 41, millisecond: 401),
new TimeOnly(hour: 20, minute: 50, second: 19, millisecond: 25),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 84,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 2, minute: 43, second: 24, millisecond: 290),
new TimeOnly(hour: 3, minute: 2, second: 52, millisecond: 976),
new TimeOnly(hour: 21, minute: 21, second: 33, millisecond: 492),
new TimeOnly(hour: 17, minute: 40, second: 30, millisecond: 36),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 41,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 21, minute: 53, second: 43, millisecond: 319),
new TimeOnly(hour: 0, minute: 48, second: 25, millisecond: 391),
new TimeOnly(hour: 6, minute: 47, second: 30, millisecond: 605),
},
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 9, minute: 57, second: 51, millisecond: 815),
new TimeOnly(hour: 6, minute: 42, second: 8, millisecond: 490),
new TimeOnly(hour: 13, minute: 0, second: 26, millisecond: 983),
new TimeOnly(hour: 6, minute: 35, second: 15, millisecond: 80),
},
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 85,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 4, minute: 47, second: 47, millisecond: 554),
new TimeOnly(hour: 12, minute: 24, second: 20, millisecond: 241),
new TimeOnly(hour: 17, minute: 3, second: 22, millisecond: 862),
},
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 8, minute: 3, second: 41, millisecond: 812),
new TimeOnly(hour: 1, minute: 23, second: 55, millisecond: 818),
new TimeOnly(hour: 22, minute: 31, second: 0, millisecond: 922),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 88,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 15, minute: 28, second: 44, millisecond: 28),
new TimeOnly(hour: 12, minute: 39, second: 16, millisecond: 119),
new TimeOnly(hour: 14, minute: 2, second: 28, millisecond: 978),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 44,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 10, minute: 27, second: 1, millisecond: 832),
new TimeOnly(hour: 9, minute: 23, second: 0, millisecond: 582),
new TimeOnly(hour: 8, minute: 30, second: 10, millisecond: 952),
new TimeOnly(hour: 10, minute: 56, second: 0, millisecond: 313),
},
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 20, minute: 22, second: 49, millisecond: 527),
new TimeOnly(hour: 9, minute: 1, second: 11, millisecond: 40),
new TimeOnly(hour: 7, minute: 23, second: 31, millisecond: 552),
},
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 92,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 43, second: 8, millisecond: 69),
new TimeOnly(hour: 3, minute: 0, second: 18, millisecond: 397),
new TimeOnly(hour: 2, minute: 13, second: 25, millisecond: 484),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 101,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 11, minute: 39, second: 58, millisecond: 331),
new TimeOnly(hour: 14, minute: 1, second: 43, millisecond: 35),
new TimeOnly(hour: 21, minute: 44, second: 46, millisecond: 35),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 47,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 19, minute: 37, second: 18, millisecond: 739),
new TimeOnly(hour: 14, minute: 47, second: 46, millisecond: 704),
new TimeOnly(hour: 13, minute: 21, second: 3, millisecond: 245),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 9, minute: 44, second: 15, millisecond: 237),
new TimeOnly(hour: 16, minute: 33, second: 56, millisecond: 771),
new TimeOnly(hour: 3, minute: 39, second: 14, millisecond: 241),
new TimeOnly(hour: 1, minute: 48, second: 57, millisecond: 92),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 110,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 17, minute: 57, second: 6, millisecond: 959),
new TimeOnly(hour: 0, minute: 40, second: 1, millisecond: 175),
new TimeOnly(hour: 15, minute: 31, second: 55, millisecond: 386),
new TimeOnly(hour: 0, minute: 2, second: 29, millisecond: 196),
},
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 3, minute: 49, second: 55, millisecond: 245),
new TimeOnly(hour: 10, minute: 43, second: 53, millisecond: 536),
new TimeOnly(hour: 4, minute: 41, second: 33, millisecond: 359),
new TimeOnly(hour: 2, minute: 13, second: 13, millisecond: 982),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 114,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 19, minute: 6, second: 46, millisecond: 144),
new TimeOnly(hour: 3, minute: 41, second: 51, millisecond: 723),
new TimeOnly(hour: 13, minute: 27, second: 38, millisecond: 54),
new TimeOnly(hour: 14, minute: 38, second: 35, millisecond: 64),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 53,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 0, minute: 11, second: 15, millisecond: 355),
new TimeOnly(hour: 7, minute: 33, second: 24, millisecond: 799),
new TimeOnly(hour: 6, minute: 55, second: 3, millisecond: 432),
new TimeOnly(hour: 14, minute: 31, second: 33, millisecond: 224),
},
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 14, minute: 21, second: 0, millisecond: 955),
new TimeOnly(hour: 11, minute: 27, second: 48, millisecond: 197),
new TimeOnly(hour: 9, minute: 50, second: 39, millisecond: 637),
new TimeOnly(hour: 10, minute: 46, second: 14, millisecond: 858),
},
},
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 21, minute: 3, second: 35, millisecond: 209),
new TimeOnly(hour: 3, minute: 58, second: 15, millisecond: 123),
new TimeOnly(hour: 8, minute: 36, second: 42, millisecond: 203),
new TimeOnly(hour: 19, minute: 1, second: 51, millisecond: 353),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 122,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 8, minute: 9, second: 49, millisecond: 238),
new TimeOnly(hour: 18, minute: 58, second: 30, millisecond: 718),
new TimeOnly(hour: 16, minute: 41, second: 40, millisecond: 364),
new TimeOnly(hour: 17, minute: 28, second: 0, millisecond: 93),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 131,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 5, minute: 15, second: 2, millisecond: 89),
new TimeOnly(hour: 19, minute: 7, second: 11, millisecond: 540),
new TimeOnly(hour: 8, minute: 8, second: 21, millisecond: 25),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 57,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 17, minute: 34, second: 36, millisecond: 190),
new TimeOnly(hour: 19, minute: 40, second: 45, millisecond: 401),
new TimeOnly(hour: 15, minute: 4, second: 22, millisecond: 540),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 2, minute: 29, second: 21, millisecond: 748),
new TimeOnly(hour: 20, minute: 39, second: 10, millisecond: 638),
new TimeOnly(hour: 21, minute: 1, second: 15, millisecond: 927),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 136,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 3, minute: 12, second: 57, millisecond: 908),
new TimeOnly(hour: 7, minute: 22, second: 31, millisecond: 157),
new TimeOnly(hour: 16, minute: 27, second: 42, millisecond: 590),
},
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 20, minute: 51, second: 12, millisecond: 310),
new TimeOnly(hour: 16, minute: 0, second: 9, millisecond: 129),
new TimeOnly(hour: 4, minute: 21, second: 28, millisecond: 544),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 142,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 18, minute: 38, second: 35, millisecond: 394),
new TimeOnly(hour: 15, minute: 29, second: 25, millisecond: 283),
new TimeOnly(hour: 0, minute: 32, second: 40, millisecond: 805),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 58,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 6, minute: 5, second: 11, millisecond: 416),
new TimeOnly(hour: 6, minute: 6, second: 55, millisecond: 749),
new TimeOnly(hour: 13, minute: 14, second: 16, millisecond: 370),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 6, minute: 58, second: 19, millisecond: 618),
new TimeOnly(hour: 12, minute: 35, second: 12, millisecond: 339),
new TimeOnly(hour: 18, minute: 48, second: 15, millisecond: 765),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 147,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 19, minute: 20, second: 25, millisecond: 669),
new TimeOnly(hour: 16, minute: 38, second: 42, millisecond: 710),
new TimeOnly(hour: 2, minute: 19, second: 5, millisecond: 755),
},
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 7, minute: 36, second: 20, millisecond: 892),
new TimeOnly(hour: 17, minute: 8, second: 38, millisecond: 472),
new TimeOnly(hour: 2, minute: 7, second: 38, millisecond: 272),
new TimeOnly(hour: 20, minute: 1, second: 27, millisecond: 981),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 148,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 8, minute: 26, second: 41, millisecond: 666),
new TimeOnly(hour: 7, minute: 30, second: 50, millisecond: 668),
new TimeOnly(hour: 3, minute: 28, second: 56, millisecond: 353),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 66,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 2, minute: 54, second: 12, millisecond: 955),
new TimeOnly(hour: 4, minute: 22, second: 56, millisecond: 67),
new TimeOnly(hour: 1, minute: 41, second: 5, millisecond: 705),
new TimeOnly(hour: 12, minute: 51, second: 22, millisecond: 876),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 13, minute: 54, second: 11, millisecond: 167),
new TimeOnly(hour: 5, minute: 29, second: 39, millisecond: 626),
new TimeOnly(hour: 15, minute: 24, second: 22, millisecond: 619),
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timeonlytime_without_time_zonearray1mi(
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
            asPartInterface: typeof(ITimeOnlyArraytime_without_time_zoneArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeOnly[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483628)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeOnly[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483628))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timeonlytime_without_time_zonearray1mi(
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
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyArraytime_without_time_zoneArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeOnly[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483628)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeOnly[]), 
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

                changedRows =  ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timeonlytime_without_time_zonearray1m(
	id,
    value,
    nullablevalue,
    timeonlytime_without_time_zonearray1mi_id
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
            asPartInterface: typeof(ITimeOnlyArraytime_without_time_zoneArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeOnly[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483628)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeOnly[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483628)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "timeonlytime_without_time_zonearray1mi_id", 
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
                changedRows =  ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timeonlytime_without_time_zonearray1m(
	id,
    value,
    nullablevalue,
    timeonlytime_without_time_zonearray1mi_id
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
    timeonlytime_without_time_zonearray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyArraytime_without_time_zoneArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

        [Ignore("Invalid cast, ExecuteScalar provider return wrong type")]
        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalar()
        {
        }

        [Ignore("Invalid cast, ExecuteScalar provider return wrong type")]
        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timeonlytime_without_time_zonearray1m(
	id,
    value,
    nullablevalue,
    timeonlytime_without_time_zonearray1mi_id
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
    timeonlytime_without_time_zonearray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyArraytime_without_time_zoneArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeOnly[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483628)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeOnly[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483628)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "timeonlytime_without_time_zonearray1mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelReturningConfig()
        {
        }

        [Ignore("Invalid cast, ExecuteScalar provider return wrong type")]
        [Test, Order(1)]
        public async Task InsertModelTestReturningScalar()
        {
        }

        [Ignore("Invalid cast, ExecuteScalar provider return wrong type")]
        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<TimeOnlytime_without_time_zoneArray1M> models = null;

                models =  ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[4], true);
                models =  ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[5], true);
                models =  ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[6], true);
                models =  ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<TimeOnlytime_without_time_zoneArray1M> models = null;

                models = await ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[8], true);
                models = await ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[9], true);
                models = await ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[10], true);
                models = await ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[11], true);
                models = await ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[12], true);
                models = await ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[13], true);
                models = await ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[14], true);
                models = await ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[15], true);
                models = await ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((ITimeOnlyArraytime_without_time_zoneArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeOnlytime_without_time_zoneArray1M), typeof(FlatTimeOnlytime_without_time_zoneArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyArraytime_without_time_zoneArray)),
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
FROM public.timeonlytime_without_time_zonearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatTimeOnlytime_without_time_zoneArray1M>();
                var models2 = new List<FlatTimeOnlytime_without_time_zoneArray1M>();
                await ((ITimeOnlyArraytime_without_time_zoneArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.timeonlytime_without_time_zonearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatTimeOnlytime_without_time_zoneArray1M>();
                var models2 = new List<FlatTimeOnlytime_without_time_zoneArray1M>();
                ((ITimeOnlyArraytime_without_time_zoneArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeOnlytime_without_time_zoneArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyArraytime_without_time_zoneArray)),
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
FROM public.timeonlytime_without_time_zonearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((ITimeOnlyArraytime_without_time_zoneArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.timeonlytime_without_time_zonearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((ITimeOnlyArraytime_without_time_zoneArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.timeonlytime_without_time_zonearray1m m
LEFT JOIN public.timeonlytime_without_time_zonearray1mi mi ON mi.id = m.timeonlytime_without_time_zonearray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyArraytime_without_time_zoneArray)),
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
                var models = await ((ITimeOnlyArraytime_without_time_zoneArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    TimeOnlytime_without_time_zoneArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((ITimeOnlyArraytime_without_time_zoneArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    TimeOnlytime_without_time_zoneArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeOnlytime_without_time_zoneArray1M), typeof(FlatTimeOnlytime_without_time_zoneArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyArraytime_without_time_zoneArray)),
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
FROM public.timeonlytime_without_time_zonearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatTimeOnlytime_without_time_zoneArray1M>();
                var models2 = new List<FlatTimeOnlytime_without_time_zoneArray1M>();
                await ((ITimeOnlyArraytime_without_time_zoneArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.timeonlytime_without_time_zonearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatTimeOnlytime_without_time_zoneArray1M>();
                var models2 = new List<FlatTimeOnlytime_without_time_zoneArray1M>();
                ((ITimeOnlyArraytime_without_time_zoneArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeOnlytime_without_time_zoneArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyArraytime_without_time_zoneArray)),
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
FROM public.timeonlytime_without_time_zonearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((ITimeOnlyArraytime_without_time_zoneArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.timeonlytime_without_time_zonearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((ITimeOnlyArraytime_without_time_zoneArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.timeonlytime_without_time_zonearray1m m
LEFT JOIN public.timeonlytime_without_time_zonearray1mi mi ON mi.id = m.timeonlytime_without_time_zonearray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyArraytime_without_time_zoneArray)),
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
                var models = await ((ITimeOnlyArraytime_without_time_zoneArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    TimeOnlytime_without_time_zoneArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((ITimeOnlyArraytime_without_time_zoneArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    TimeOnlytime_without_time_zoneArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeOnlytime_without_time_zoneArray1M), typeof(FlatTimeOnlytime_without_time_zoneArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyArraytime_without_time_zoneArray)),
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
FROM public.timeonlytime_without_time_zonearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatTimeOnlytime_without_time_zoneArray1M>();
                var models2 = new List<FlatTimeOnlytime_without_time_zoneArray1M>();
                await((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.timeonlytime_without_time_zonearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatTimeOnlytime_without_time_zoneArray1M>();
                var models2 = new List<FlatTimeOnlytime_without_time_zoneArray1M>();
                ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeOnlytime_without_time_zoneArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyArraytime_without_time_zoneArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyArraytime_without_time_zoneArray)),
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
FROM public.timeonlytime_without_time_zonearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 77;
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
FROM public.timeonlytime_without_time_zonearray1m m
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
FROM public.timeonlytime_without_time_zonearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[16], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[17], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[18], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[19], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[20], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[5],_testData[21], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[6],_testData[22], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[7],_testData[23], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[8],_testData[24], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[9],_testData[25], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[10],_testData[26], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[11],_testData[27], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[12],_testData[28], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[7], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[8], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[9], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[10], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[11], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[5],_testData[12], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[6],_testData[13], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[7],_testData[14], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[8],_testData[15], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[9],_testData[16], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[10],_testData[17], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[11],_testData[18], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[12],_testData[19], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[13],_testData[20], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[14],_testData[21], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[15],_testData[22], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[16],_testData[23], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[17],_testData[24], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[18],_testData[25], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[19],_testData[26], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[20],_testData[27], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[21],_testData[28], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[22],_testData[29], false);
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
FROM public.timeonlytime_without_time_zonearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 122;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 92;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.timeonlytime_without_time_zonearray1m m
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
FROM public.timeonlytime_without_time_zonearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));
FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[25], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[26], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[27], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[28], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));
FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[21], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[22], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[23], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[24], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[25], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[5],_testData[26], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[6],_testData[27], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[7],_testData[28], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[8],_testData[29], false);
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
FROM public.timeonlytime_without_time_zonearray1m m
LEFT JOIN public.timeonlytime_without_time_zonearray1mi mi ON mi.id = m.timeonlytime_without_time_zonearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyArraytime_without_time_zoneArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyArraytime_without_time_zoneArray)),
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
                var models = await((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    TimeOnlytime_without_time_zoneArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr2.Value = 77;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));
TimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[27], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[28], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
TimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[16], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[17], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[18], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[19], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[20], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[5],_testData[21], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[6],_testData[22], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[7],_testData[23], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[8],_testData[24], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[9],_testData[25], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[10],_testData[26], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[11],_testData[27], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[12],_testData[28], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[13],_testData[29], false);
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
                var models = ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    TimeOnlytime_without_time_zoneArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 65;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 75;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));
TimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[13], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[14], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[15], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[16], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[17], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[5],_testData[18], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[6],_testData[19], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[7],_testData[20], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[8],_testData[21], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[9],_testData[22], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[10],_testData[23], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[11],_testData[24], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[12],_testData[25], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[13],_testData[26], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[14],_testData[27], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[15],_testData[28], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
TimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[15], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[16], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[17], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[18], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[19], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[5],_testData[20], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[6],_testData[21], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[7],_testData[22], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[8],_testData[23], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[9],_testData[24], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[10],_testData[25], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[11],_testData[26], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[12],_testData[27], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[13],_testData[28], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeOnlytime_without_time_zoneArray1M), typeof(FlatTimeOnlytime_without_time_zoneArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyArraytime_without_time_zoneArray)),
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
FROM public.timeonlytime_without_time_zonearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatTimeOnlytime_without_time_zoneArray1M>();
                var models2 = new List<FlatTimeOnlytime_without_time_zoneArray1M>();
                await((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.timeonlytime_without_time_zonearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatTimeOnlytime_without_time_zoneArray1M>();
                var models2 = new List<FlatTimeOnlytime_without_time_zoneArray1M>();
                ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeOnlytime_without_time_zoneArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyArraytime_without_time_zoneArray)),
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
            asPartInterface: typeof(ITimeOnlyArraytime_without_time_zoneArray)),
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
FROM public.timeonlytime_without_time_zonearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.timeonlytime_without_time_zonearray1m m
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
FROM public.timeonlytime_without_time_zonearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 15, query1, 101, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[3], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[4], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[5], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[6], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[7], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[5],_testData[8], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[6],_testData[9], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[7],_testData[10], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[8],_testData[11], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[9],_testData[12], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[10],_testData[13], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[11],_testData[14], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[12],_testData[15], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[13],_testData[16], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[14],_testData[17], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[15],_testData[18], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[16],_testData[19], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[17],_testData[20], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[18],_testData[21], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[19],_testData[22], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[20],_testData[23], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[21],_testData[24], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[22],_testData[25], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[23],_testData[26], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[24],_testData[27], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[25],_testData[28], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));
FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[22], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[23], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[24], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[25], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[26], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[5],_testData[27], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[6],_testData[28], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[7],_testData[29], false);
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
FROM public.timeonlytime_without_time_zonearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.timeonlytime_without_time_zonearray1m m
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
FROM public.timeonlytime_without_time_zonearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionDynQuerySelectModelBatch(connection, 72, query1, 8, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[14], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[15], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[16], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[17], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[18], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[5],_testData[19], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[6],_testData[20], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[7],_testData[21], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[8],_testData[22], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[9],_testData[23], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[10],_testData[24], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[11],_testData[25], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[12],_testData[26], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[13],_testData[27], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[14],_testData[28], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));
FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[2], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[3], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[4], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[5], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[6], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[5],_testData[7], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[6],_testData[8], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[7],_testData[9], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[8],_testData[10], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[9],_testData[11], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[10],_testData[12], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[11],_testData[13], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[12],_testData[14], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[13],_testData[15], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[14],_testData[16], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[15],_testData[17], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[16],_testData[18], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[17],_testData[19], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[18],_testData[20], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[19],_testData[21], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[20],_testData[22], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[21],_testData[23], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[22],_testData[24], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[23],_testData[25], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[24],_testData[26], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[25],_testData[27], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[26],_testData[28], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[27],_testData[29], false);
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
FROM public.timeonlytime_without_time_zonearray1m m
LEFT JOIN public.timeonlytime_without_time_zonearray1mi mi ON mi.id = m.timeonlytime_without_time_zonearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyArraytime_without_time_zoneArray)),
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
            asPartInterface: typeof(ITimeOnlyArraytime_without_time_zoneArray)),
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
                var models = await((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    TimeOnlytime_without_time_zoneArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionSelectModelBatchAsync(connection, 85, 122))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));
TimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[19], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[20], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[21], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[22], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[23], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[5],_testData[24], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[6],_testData[25], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[7],_testData[26], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[8],_testData[27], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[9],_testData[28], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));
TimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[25], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[26], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[27], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[28], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[29], false);
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
                var models = ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    TimeOnlytime_without_time_zoneArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionSelectModelBatch(connection, 15, 65))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
TimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[3], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[4], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[5], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[6], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[7], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[5],_testData[8], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[6],_testData[9], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[7],_testData[10], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[8],_testData[11], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[9],_testData[12], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[10],_testData[13], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[11],_testData[14], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[12],_testData[15], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[13],_testData[16], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[14],_testData[17], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[15],_testData[18], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[16],_testData[19], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[17],_testData[20], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[18],_testData[21], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[19],_testData[22], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[20],_testData[23], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[21],_testData[24], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[22],_testData[25], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[23],_testData[26], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[24],_testData[27], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[25],_testData[28], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));
TimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[13], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[14], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[15], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[16], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[17], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[5],_testData[18], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[6],_testData[19], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[7],_testData[20], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[8],_testData[21], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[9],_testData[22], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[10],_testData[23], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[11],_testData[24], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[12],_testData[25], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[13],_testData[26], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[14],_testData[27], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[15],_testData[28], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[16],_testData[29], false);
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
                await using var cmd = await ((ITimeOnlyArraytime_without_time_zoneArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((ITimeOnlyArraytime_without_time_zoneArray)this).SetDbConnectionSelectModelParametrs(cmd, 101);
                var models = await ((ITimeOnlyArraytime_without_time_zoneArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(8));
TimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[22], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[23], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[24], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[25], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[26], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[5],_testData[27], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[6],_testData[28], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[7],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ITimeOnlyArraytime_without_time_zoneArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((ITimeOnlyArraytime_without_time_zoneArray)this).SetDbConnectionSelectModelParametrs(cmd, 26);
                var models =  ((ITimeOnlyArraytime_without_time_zoneArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(25));
TimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[5], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[6], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[7], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[8], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[9], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[5],_testData[10], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[6],_testData[11], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[7],_testData[12], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[8],_testData[13], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[9],_testData[14], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[10],_testData[15], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[11],_testData[16], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[12],_testData[17], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[13],_testData[18], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[14],_testData[19], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[15],_testData[20], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[16],_testData[21], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[17],_testData[22], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[18],_testData[23], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[19],_testData[24], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[20],_testData[25], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[21],_testData[26], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[22],_testData[27], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[23],_testData[28], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[24],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_timeonlytime_without_time_zonearray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneArray1MI)],
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
            asPartInterface: typeof(ITimeOnlyArraytime_without_time_zoneArray))]
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
FROM public.binary_timeonlytime_without_time_zonearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyArraytime_without_time_zoneArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<TimeOnlytime_without_time_zoneArray1MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((ITimeOnlyArraytime_without_time_zoneArray)this).ImportModelInner(connection, importCollection);
                var models = ((ITimeOnlyArraytime_without_time_zoneArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeOnlytime_without_time_zoneArray1MI.AssertModel(actual, expect, false);
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
                await ((ITimeOnlyArraytime_without_time_zoneArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((ITimeOnlyArraytime_without_time_zoneArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeOnlytime_without_time_zoneArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_timeonlytime_without_time_zonearray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
timeonlytime_without_time_zonearray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneArray1M)],
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
            asPartInterface: typeof(ITimeOnlyArraytime_without_time_zoneArray))]
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
FROM public.binary_timeonlytime_without_time_zonearray1m m
LEFT JOIN public.binary_timeonlytime_without_time_zonearray1mi mi ON mi.id = m.timeonlytime_without_time_zonearray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyArraytime_without_time_zoneArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<TimeOnlytime_without_time_zoneArray1M>(15);

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
                ((ITimeOnlyArraytime_without_time_zoneArray)this).ImportModel(connection, importCollection);
                var models = ((ITimeOnlyArraytime_without_time_zoneArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                TimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[0], false);
                TimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[1], false);
                TimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[2], false);
                TimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[3], false);
                TimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[4], false);
                TimeOnlytime_without_time_zoneArray1M.AssertModel(models[5],_testData[5], false);
                TimeOnlytime_without_time_zoneArray1M.AssertModel(models[6],_testData[6], false);
                TimeOnlytime_without_time_zoneArray1M.AssertModel(models[7],_testData[7], false);
                TimeOnlytime_without_time_zoneArray1M.AssertModel(models[8],_testData[8], false);
                TimeOnlytime_without_time_zoneArray1M.AssertModel(models[9],_testData[9], false);
                TimeOnlytime_without_time_zoneArray1M.AssertModel(models[10],_testData[10], false);
                TimeOnlytime_without_time_zoneArray1M.AssertModel(models[11],_testData[11], false);
                TimeOnlytime_without_time_zoneArray1M.AssertModel(models[12],_testData[12], false);
                TimeOnlytime_without_time_zoneArray1M.AssertModel(models[13],_testData[13], false);
                TimeOnlytime_without_time_zoneArray1M.AssertModel(models[14],_testData[14], false);
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
                await ((ITimeOnlyArraytime_without_time_zoneArray)this).ImportModelAsync(connection, importCollection);
                models = await ((ITimeOnlyArraytime_without_time_zoneArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                TimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[0], false);
                TimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[1], false);
                TimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[2], false);
                TimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[3], false);
                TimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[4], false);
                TimeOnlytime_without_time_zoneArray1M.AssertModel(models[5],_testData[5], false);
                TimeOnlytime_without_time_zoneArray1M.AssertModel(models[6],_testData[6], false);
                TimeOnlytime_without_time_zoneArray1M.AssertModel(models[7],_testData[7], false);
                TimeOnlytime_without_time_zoneArray1M.AssertModel(models[8],_testData[8], false);
                TimeOnlytime_without_time_zoneArray1M.AssertModel(models[9],_testData[9], false);
                TimeOnlytime_without_time_zoneArray1M.AssertModel(models[10],_testData[10], false);
                TimeOnlytime_without_time_zoneArray1M.AssertModel(models[11],_testData[11], false);
                TimeOnlytime_without_time_zoneArray1M.AssertModel(models[12],_testData[12], false);
                TimeOnlytime_without_time_zoneArray1M.AssertModel(models[13],_testData[13], false);
                TimeOnlytime_without_time_zoneArray1M.AssertModel(models[14],_testData[14], false);
                TimeOnlytime_without_time_zoneArray1M.AssertModel(models[15],_testData[15], false);
                TimeOnlytime_without_time_zoneArray1M.AssertModel(models[16],_testData[16], false);
                TimeOnlytime_without_time_zoneArray1M.AssertModel(models[17],_testData[17], false);
                TimeOnlytime_without_time_zoneArray1M.AssertModel(models[18],_testData[18], false);
                TimeOnlytime_without_time_zoneArray1M.AssertModel(models[19],_testData[19], false);
                TimeOnlytime_without_time_zoneArray1M.AssertModel(models[20],_testData[20], false);
                TimeOnlytime_without_time_zoneArray1M.AssertModel(models[21],_testData[21], false);
                TimeOnlytime_without_time_zoneArray1M.AssertModel(models[22],_testData[22], false);
                TimeOnlytime_without_time_zoneArray1M.AssertModel(models[23],_testData[23], false);
                TimeOnlytime_without_time_zoneArray1M.AssertModel(models[24],_testData[24], false);
                TimeOnlytime_without_time_zoneArray1M.AssertModel(models[25],_testData[25], false);
                TimeOnlytime_without_time_zoneArray1M.AssertModel(models[26],_testData[26], false);
                TimeOnlytime_without_time_zoneArray1M.AssertModel(models[27],_testData[27], false);
                TimeOnlytime_without_time_zoneArray1M.AssertModel(models[28],_testData[28], false);
                TimeOnlytime_without_time_zoneArray1M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_timeonlytime_without_time_zonearray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    timeonlytime_without_time_zonearray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneArray1M)],
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
            asPartInterface: typeof(ITimeOnlyArraytime_without_time_zoneArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((ITimeOnlyArraytime_without_time_zoneArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    TimeOnlytime_without_time_zoneArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((ITimeOnlyArraytime_without_time_zoneArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    TimeOnlytime_without_time_zoneArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_timeonlytime_without_time_zonearray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneArray1MI)],
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
            asPartInterface: typeof(ITimeOnlyArraytime_without_time_zoneArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((ITimeOnlyArraytime_without_time_zoneArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    TimeOnlytime_without_time_zoneArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((ITimeOnlyArraytime_without_time_zoneArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    TimeOnlytime_without_time_zoneArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

