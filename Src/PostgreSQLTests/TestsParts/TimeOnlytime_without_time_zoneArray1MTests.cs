

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
    Id = 5,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 17, minute: 49, second: 10, millisecond: 53),
new TimeOnly(hour: 12, minute: 43, second: 41, millisecond: 449),
new TimeOnly(hour: 4, minute: 32, second: 49, millisecond: 776),
new TimeOnly(hour: 15, minute: 33, second: 0, millisecond: 336),
},
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 18, minute: 23, second: 50, millisecond: 910),
new TimeOnly(hour: 13, minute: 45, second: 58, millisecond: 384),
new TimeOnly(hour: 2, minute: 31, second: 9, millisecond: 608),
new TimeOnly(hour: 21, minute: 12, second: 46, millisecond: 254),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 10,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 18, minute: 31, second: 4, millisecond: 802),
new TimeOnly(hour: 1, minute: 18, second: 7, millisecond: 766),
new TimeOnly(hour: 22, minute: 15, second: 19, millisecond: 314),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 5,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 19, minute: 6, second: 16, millisecond: 715),
new TimeOnly(hour: 15, minute: 3, second: 21, millisecond: 135),
new TimeOnly(hour: 9, minute: 38, second: 40, millisecond: 70),
new TimeOnly(hour: 10, minute: 48, second: 3, millisecond: 882),
},
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 35, second: 2, millisecond: 171),
new TimeOnly(hour: 19, minute: 5, second: 54, millisecond: 50),
new TimeOnly(hour: 17, minute: 39, second: 27, millisecond: 899),
},
},
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 21, minute: 39, second: 30, millisecond: 837),
new TimeOnly(hour: 9, minute: 47, second: 20, millisecond: 781),
new TimeOnly(hour: 12, minute: 18, second: 12, millisecond: 826),
new TimeOnly(hour: 2, minute: 55, second: 38, millisecond: 304),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 19,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 4, minute: 25, second: 30, millisecond: 456),
new TimeOnly(hour: 5, minute: 16, second: 46, millisecond: 220),
new TimeOnly(hour: 5, minute: 28, second: 10, millisecond: 413),
new TimeOnly(hour: 11, minute: 31, second: 47, millisecond: 151),
},
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 17, minute: 10, second: 7, millisecond: 729),
new TimeOnly(hour: 2, minute: 57, second: 53, millisecond: 31),
new TimeOnly(hour: 22, minute: 57, second: 20, millisecond: 326),
new TimeOnly(hour: 13, minute: 19, second: 3, millisecond: 942),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 20,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 0, minute: 32, second: 16, millisecond: 990),
new TimeOnly(hour: 14, minute: 12, second: 6, millisecond: 137),
new TimeOnly(hour: 18, minute: 15, second: 52, millisecond: 168),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 9,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 4, minute: 23, second: 16, millisecond: 311),
new TimeOnly(hour: 18, minute: 8, second: 0, millisecond: 683),
new TimeOnly(hour: 10, minute: 11, second: 45, millisecond: 272),
new TimeOnly(hour: 7, minute: 27, second: 45, millisecond: 591),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 15, minute: 33, second: 19, millisecond: 412),
new TimeOnly(hour: 2, minute: 5, second: 37, millisecond: 853),
new TimeOnly(hour: 2, minute: 26, second: 10, millisecond: 103),
new TimeOnly(hour: 8, minute: 25, second: 25, millisecond: 275),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 22,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 19, minute: 27, second: 6, millisecond: 93),
new TimeOnly(hour: 18, minute: 48, second: 2, millisecond: 333),
new TimeOnly(hour: 10, minute: 57, second: 35, millisecond: 769),
new TimeOnly(hour: 7, minute: 26, second: 24, millisecond: 467),
},
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 1, minute: 49, second: 9, millisecond: 122),
new TimeOnly(hour: 15, minute: 20, second: 40, millisecond: 71),
new TimeOnly(hour: 7, minute: 54, second: 26, millisecond: 570),
new TimeOnly(hour: 5, minute: 50, second: 39, millisecond: 601),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 29,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 16, minute: 7, second: 24, millisecond: 271),
new TimeOnly(hour: 18, minute: 48, second: 55, millisecond: 653),
new TimeOnly(hour: 21, minute: 42, second: 50, millisecond: 85),
new TimeOnly(hour: 13, minute: 40, second: 10, millisecond: 637),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 14,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 18, minute: 43, second: 22, millisecond: 446),
new TimeOnly(hour: 15, minute: 25, second: 35, millisecond: 116),
new TimeOnly(hour: 11, minute: 30, second: 30, millisecond: 500),
new TimeOnly(hour: 19, minute: 51, second: 49, millisecond: 87),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 17, minute: 58, second: 17, millisecond: 835),
new TimeOnly(hour: 16, minute: 11, second: 56, millisecond: 104),
new TimeOnly(hour: 21, minute: 0, second: 18, millisecond: 373),
new TimeOnly(hour: 1, minute: 4, second: 19, millisecond: 358),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 30,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 17, minute: 35, second: 49, millisecond: 690),
new TimeOnly(hour: 14, minute: 51, second: 42, millisecond: 108),
new TimeOnly(hour: 17, minute: 54, second: 15, millisecond: 538),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 34,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 8, minute: 53, second: 51, millisecond: 169),
new TimeOnly(hour: 21, minute: 58, second: 17, millisecond: 265),
new TimeOnly(hour: 7, minute: 4, second: 35, millisecond: 593),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 16,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 3, minute: 31, second: 49, millisecond: 119),
new TimeOnly(hour: 19, minute: 35, second: 58, millisecond: 749),
new TimeOnly(hour: 1, minute: 26, second: 41, millisecond: 929),
},
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 0, minute: 24, second: 27, millisecond: 870),
new TimeOnly(hour: 2, minute: 42, second: 28, millisecond: 326),
new TimeOnly(hour: 20, minute: 39, second: 38, millisecond: 165),
new TimeOnly(hour: 18, minute: 44, second: 25, millisecond: 261),
},
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 40,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 20, minute: 5, second: 6, millisecond: 581),
new TimeOnly(hour: 19, minute: 18, second: 54, millisecond: 52),
new TimeOnly(hour: 16, minute: 12, second: 16, millisecond: 66),
},
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 16, minute: 7, second: 1, millisecond: 216),
new TimeOnly(hour: 4, minute: 25, second: 44, millisecond: 106),
new TimeOnly(hour: 19, minute: 52, second: 4, millisecond: 385),
new TimeOnly(hour: 14, minute: 46, second: 33, millisecond: 490),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 45,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 13, minute: 48, second: 52, millisecond: 959),
new TimeOnly(hour: 14, minute: 41, second: 25, millisecond: 817),
new TimeOnly(hour: 5, minute: 45, second: 11, millisecond: 446),
new TimeOnly(hour: 2, minute: 16, second: 32, millisecond: 778),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 25,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 8, second: 33, millisecond: 785),
new TimeOnly(hour: 11, minute: 34, second: 19, millisecond: 748),
new TimeOnly(hour: 5, minute: 4, second: 21, millisecond: 684),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 53,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 4, minute: 48, second: 6, millisecond: 201),
new TimeOnly(hour: 18, minute: 13, second: 44, millisecond: 409),
new TimeOnly(hour: 11, minute: 25, second: 5, millisecond: 675),
new TimeOnly(hour: 13, minute: 4, second: 19, millisecond: 732),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 54,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 21, minute: 43, second: 7, millisecond: 696),
new TimeOnly(hour: 20, minute: 11, second: 28, millisecond: 309),
new TimeOnly(hour: 17, minute: 48, second: 6, millisecond: 929),
new TimeOnly(hour: 20, minute: 57, second: 4, millisecond: 406),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 28,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 17, minute: 49, second: 55, millisecond: 524),
new TimeOnly(hour: 3, minute: 54, second: 0, millisecond: 19),
new TimeOnly(hour: 1, minute: 2, second: 39, millisecond: 863),
},
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 39, second: 17, millisecond: 619),
new TimeOnly(hour: 18, minute: 27, second: 41, millisecond: 434),
new TimeOnly(hour: 19, minute: 41, second: 46, millisecond: 73),
},
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 61,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 7, minute: 48, second: 47, millisecond: 110),
new TimeOnly(hour: 1, minute: 22, second: 17, millisecond: 34),
new TimeOnly(hour: 15, minute: 54, second: 26, millisecond: 863),
},
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 15, minute: 56, second: 10, millisecond: 478),
new TimeOnly(hour: 18, minute: 20, second: 35, millisecond: 508),
new TimeOnly(hour: 14, minute: 25, second: 39, millisecond: 61),
new TimeOnly(hour: 10, minute: 14, second: 21, millisecond: 762),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 63,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 7, minute: 17, second: 16, millisecond: 380),
new TimeOnly(hour: 7, minute: 9, second: 45, millisecond: 464),
new TimeOnly(hour: 8, minute: 51, second: 55, millisecond: 815),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 35,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 11, minute: 31, second: 25, millisecond: 657),
new TimeOnly(hour: 14, minute: 15, second: 22, millisecond: 680),
new TimeOnly(hour: 22, minute: 8, second: 50, millisecond: 573),
new TimeOnly(hour: 4, minute: 43, second: 13, millisecond: 311),
},
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 6, minute: 52, second: 15, millisecond: 353),
new TimeOnly(hour: 19, minute: 14, second: 57, millisecond: 749),
new TimeOnly(hour: 10, minute: 24, second: 50, millisecond: 955),
},
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 65,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 48, second: 43, millisecond: 364),
new TimeOnly(hour: 10, minute: 42, second: 43, millisecond: 843),
new TimeOnly(hour: 21, minute: 29, second: 47, millisecond: 733),
},
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 1, minute: 23, second: 10, millisecond: 245),
new TimeOnly(hour: 16, minute: 28, second: 12, millisecond: 701),
new TimeOnly(hour: 22, minute: 27, second: 53, millisecond: 339),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 71,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 17, minute: 12, second: 32, millisecond: 918),
new TimeOnly(hour: 0, minute: 36, second: 4, millisecond: 751),
new TimeOnly(hour: 2, minute: 12, second: 25, millisecond: 213),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 43,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 18, minute: 22, second: 30, millisecond: 409),
new TimeOnly(hour: 14, minute: 27, second: 32, millisecond: 807),
new TimeOnly(hour: 12, minute: 51, second: 55, millisecond: 512),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 80,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 22, minute: 7, second: 28, millisecond: 692),
new TimeOnly(hour: 7, minute: 6, second: 32, millisecond: 677),
new TimeOnly(hour: 17, minute: 49, second: 55, millisecond: 39),
},
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 1, minute: 10, second: 5, millisecond: 905),
new TimeOnly(hour: 12, minute: 14, second: 57, millisecond: 754),
new TimeOnly(hour: 12, minute: 29, second: 5, millisecond: 61),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 85,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 21, minute: 27, second: 32, millisecond: 646),
new TimeOnly(hour: 12, minute: 49, second: 4, millisecond: 36),
new TimeOnly(hour: 12, minute: 48, second: 2, millisecond: 732),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 45,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 16, minute: 32, second: 2, millisecond: 667),
new TimeOnly(hour: 15, minute: 32, second: 4, millisecond: 344),
new TimeOnly(hour: 5, minute: 53, second: 6, millisecond: 117),
new TimeOnly(hour: 2, minute: 41, second: 0, millisecond: 711),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 89,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 10, minute: 49, second: 49, millisecond: 729),
new TimeOnly(hour: 22, minute: 25, second: 6, millisecond: 605),
new TimeOnly(hour: 4, minute: 16, second: 24, millisecond: 528),
new TimeOnly(hour: 14, minute: 21, second: 49, millisecond: 78),
},
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 0, minute: 35, second: 12, millisecond: 878),
new TimeOnly(hour: 6, minute: 14, second: 19, millisecond: 126),
new TimeOnly(hour: 12, minute: 19, second: 1, millisecond: 41),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 96,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 10, minute: 46, second: 26, millisecond: 95),
new TimeOnly(hour: 7, minute: 14, second: 16, millisecond: 766),
new TimeOnly(hour: 18, minute: 22, second: 1, millisecond: 326),
new TimeOnly(hour: 12, minute: 25, second: 32, millisecond: 386),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 52,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 12, minute: 47, second: 2, millisecond: 965),
new TimeOnly(hour: 11, minute: 44, second: 1, millisecond: 136),
new TimeOnly(hour: 19, minute: 41, second: 18, millisecond: 249),
new TimeOnly(hour: 3, minute: 32, second: 0, millisecond: 711),
},
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 10, minute: 26, second: 25, millisecond: 359),
new TimeOnly(hour: 17, minute: 9, second: 15, millisecond: 123),
new TimeOnly(hour: 21, minute: 23, second: 41, millisecond: 65),
},
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 104,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 5, minute: 55, second: 57, millisecond: 648),
new TimeOnly(hour: 13, minute: 53, second: 8, millisecond: 372),
new TimeOnly(hour: 16, minute: 11, second: 30, millisecond: 518),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 106,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 8, minute: 24, second: 33, millisecond: 768),
new TimeOnly(hour: 20, minute: 12, second: 12, millisecond: 780),
new TimeOnly(hour: 6, minute: 13, second: 50, millisecond: 29),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 54,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 21, minute: 42, second: 36, millisecond: 108),
new TimeOnly(hour: 0, minute: 15, second: 56, millisecond: 951),
new TimeOnly(hour: 0, minute: 10, second: 47, millisecond: 687),
new TimeOnly(hour: 20, minute: 53, second: 26, millisecond: 417),
},
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 15, minute: 40, second: 43, millisecond: 932),
new TimeOnly(hour: 6, minute: 17, second: 6, millisecond: 482),
new TimeOnly(hour: 5, minute: 17, second: 54, millisecond: 265),
},
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 110,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 6, minute: 45, second: 34, millisecond: 955),
new TimeOnly(hour: 0, minute: 37, second: 3, millisecond: 766),
new TimeOnly(hour: 12, minute: 20, second: 13, millisecond: 826),
new TimeOnly(hour: 18, minute: 16, second: 18, millisecond: 251),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 116,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 8, minute: 41, second: 51, millisecond: 810),
new TimeOnly(hour: 4, minute: 56, second: 33, millisecond: 174),
new TimeOnly(hour: 20, minute: 47, second: 55, millisecond: 463),
new TimeOnly(hour: 6, minute: 26, second: 7, millisecond: 581),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 58,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 16, minute: 36, second: 0, millisecond: 94),
new TimeOnly(hour: 19, minute: 16, second: 52, millisecond: 724),
new TimeOnly(hour: 1, minute: 20, second: 14, millisecond: 14),
new TimeOnly(hour: 6, minute: 31, second: 14, millisecond: 845),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 118,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 17, minute: 21, second: 40, millisecond: 175),
new TimeOnly(hour: 8, minute: 25, second: 54, millisecond: 687),
new TimeOnly(hour: 22, minute: 10, second: 14, millisecond: 276),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 120,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 13, minute: 46, second: 58, millisecond: 106),
new TimeOnly(hour: 13, minute: 32, second: 55, millisecond: 980),
new TimeOnly(hour: 6, minute: 17, second: 3, millisecond: 810),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 65,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 3, minute: 14, second: 55, millisecond: 453),
new TimeOnly(hour: 16, minute: 49, second: 6, millisecond: 481),
new TimeOnly(hour: 17, minute: 32, second: 1, millisecond: 137),
new TimeOnly(hour: 16, minute: 17, second: 36, millisecond: 99),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 124,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 14, minute: 29, second: 9, millisecond: 94),
new TimeOnly(hour: 4, minute: 39, second: 31, millisecond: 434),
new TimeOnly(hour: 3, minute: 25, second: 8, millisecond: 16),
new TimeOnly(hour: 8, minute: 31, second: 56, millisecond: 56),
},
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 21, minute: 1, second: 12, millisecond: 623),
new TimeOnly(hour: 13, minute: 22, second: 47, millisecond: 97),
new TimeOnly(hour: 8, minute: 9, second: 33, millisecond: 820),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 128,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 10, minute: 31, second: 36, millisecond: 836),
new TimeOnly(hour: 21, minute: 30, second: 20, millisecond: 659),
new TimeOnly(hour: 2, minute: 50, second: 58, millisecond: 651),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 67,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 11, second: 44, millisecond: 39),
new TimeOnly(hour: 0, minute: 46, second: 27, millisecond: 971),
new TimeOnly(hour: 12, minute: 30, second: 34, millisecond: 467),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 130,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 22, second: 21, millisecond: 649),
new TimeOnly(hour: 11, minute: 40, second: 45, millisecond: 707),
new TimeOnly(hour: 15, minute: 30, second: 48, millisecond: 682),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 137,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 20, second: 18, millisecond: 805),
new TimeOnly(hour: 2, minute: 0, second: 27, millisecond: 38),
new TimeOnly(hour: 5, minute: 46, second: 56, millisecond: 128),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 74,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 13, minute: 53, second: 31, millisecond: 244),
new TimeOnly(hour: 7, minute: 46, second: 23, millisecond: 89),
new TimeOnly(hour: 9, minute: 48, second: 44, millisecond: 726),
new TimeOnly(hour: 16, minute: 31, second: 0, millisecond: 75),
},
    NullableValue = null,
},
    NullableValue = null,
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
            overrideAliasPrefixs: ["item1", "item2"],
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
            overrideAliasPrefixs: null,
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
            overrideAliasPrefixs: null,
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
            overrideAliasPrefixs: ["item1", "item2"],
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
            overrideAliasPrefixs: null,
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
            overrideAliasPrefixs: null,
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
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyArraytime_without_time_zoneArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyArraytime_without_time_zoneArray)),
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
            asPartInterface: typeof(ITimeOnlyArraytime_without_time_zoneArray)),
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
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 118;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 104;
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
FROM public.timeonlytime_without_time_zonearray1m m
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
FROM public.timeonlytime_without_time_zonearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeOnlytime_without_time_zoneArray1M>();
                var firstItems2 = new List<FlatTimeOnlytime_without_time_zoneArray1M>();
                var secondItems1 = new List<FlatTimeOnlytime_without_time_zoneArray1M>();
                var secondItems2 = new List<FlatTimeOnlytime_without_time_zoneArray1M>();
                await ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[4],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[8],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 34;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 85;
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
                var firstItems1 = new List<FlatTimeOnlytime_without_time_zoneArray1M>();
                var firstItems2 = new List<FlatTimeOnlytime_without_time_zoneArray1M>();
                var secondItems1 = new List<FlatTimeOnlytime_without_time_zoneArray1M>();
                await ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[21],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[11],_testData[29], false);
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

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 53;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 5;
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
FROM public.timeonlytime_without_time_zonearray1m m
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
FROM public.timeonlytime_without_time_zonearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeOnlytime_without_time_zoneArray1M>();
                var firstItems2 = new List<FlatTimeOnlytime_without_time_zoneArray1M>();
                var secondItems1 = new List<FlatTimeOnlytime_without_time_zoneArray1M>();
                var secondItems2 = new List<FlatTimeOnlytime_without_time_zoneArray1M>();
                 ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[28],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 116;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 34;
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
                var firstItems1 = new List<FlatTimeOnlytime_without_time_zoneArray1M>();
                var firstItems2 = new List<FlatTimeOnlytime_without_time_zoneArray1M>();
                var secondItems1 = new List<FlatTimeOnlytime_without_time_zoneArray1M>();
                 ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[21],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeOnlytime_without_time_zoneArray1M)],
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
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
        private void DbConnectionSTDynQuerySelectModelDynParBatchConfig()
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
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 53;
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
                int resultIndex = 0;
                foreach(var batchResult in await ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[5],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[6],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[7],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[8],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[9],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[10],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[11],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[12],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[13],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[14],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[15],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[16],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[17],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[5],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[6],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[7],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[8],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[9],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[10],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[11],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[12],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[13],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[14],_testData[29], false);
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
                parametr1.Value = 53;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 124;
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
                var firstItems1 = new List<FlatTimeOnlytime_without_time_zoneArray1M>();
                var secondItems1 = new List<FlatTimeOnlytime_without_time_zoneArray1M>();
                var secondItems2 = new List<FlatTimeOnlytime_without_time_zoneArray1M>();
                await ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[2],_testData[29], false);
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
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 89;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 61;
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
                int resultIndex = 0;
                foreach(var batchResult in  ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[5],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[6],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[7],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[8],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[9],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[5],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[6],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[7],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[8],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[9],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[10],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[11],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[12],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[13],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[14],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[15],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[16],_testData[29], false);
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
                parametr1.Value = 34;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 116;
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
                var firstItems1 = new List<FlatTimeOnlytime_without_time_zoneArray1M>();
                var secondItems1 = new List<FlatTimeOnlytime_without_time_zoneArray1M>();
                var secondItems2 = new List<FlatTimeOnlytime_without_time_zoneArray1M>();
                 ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[21],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[5],_testData[29], false);
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
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTSelectModelDynParBatch",
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
                var models = await((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    TimeOnlytime_without_time_zoneArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 5;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 120;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[1], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[2], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[3], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[4], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[5], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[5],_testData[6], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[6],_testData[7], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[7],_testData[8], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[8],_testData[9], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[9],_testData[10], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[10],_testData[11], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[11],_testData[12], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[12],_testData[13], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[13],_testData[14], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[14],_testData[15], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[15],_testData[16], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[16],_testData[17], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[17],_testData[18], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[18],_testData[19], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[19],_testData[20], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[20],_testData[21], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[21],_testData[22], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[22],_testData[23], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[23],_testData[24], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[24],_testData[25], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[25],_testData[26], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[26],_testData[27], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[27],_testData[28], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[26], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[27], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[28], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[29], false);
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
        public async Task DbConnectionSTSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 61;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 30;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[13], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[14], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[15], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[16], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[17], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[5],_testData[18], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[6],_testData[19], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[7],_testData[20], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[8],_testData[21], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[9],_testData[22], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[10],_testData[23], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[11],_testData[24], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[12],_testData[25], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[13],_testData[26], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[14],_testData[27], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[15],_testData[28], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[7], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[8], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[9], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[10], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[11], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[5],_testData[12], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[6],_testData[13], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[7],_testData[14], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[8],_testData[15], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[9],_testData[16], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[10],_testData[17], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[11],_testData[18], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[12],_testData[19], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[13],_testData[20], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[14],_testData[21], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[15],_testData[22], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[16],_testData[23], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[17],_testData[24], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[18],_testData[25], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[19],_testData[26], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[20],_testData[27], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[21],_testData[28], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[22],_testData[29], false);
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
            overrideAliasPrefixs: ["item1", "item2"],
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

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyArraytime_without_time_zoneArray)),
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
            asPartInterface: typeof(ITimeOnlyArraytime_without_time_zoneArray)),
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
FROM public.timeonlytime_without_time_zonearray1m m
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
FROM public.timeonlytime_without_time_zonearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeOnlytime_without_time_zoneArray1M>();
                var firstItems2 = new List<FlatTimeOnlytime_without_time_zoneArray1M>();
                var secondItems1 = new List<FlatTimeOnlytime_without_time_zoneArray1M>();
                var secondItems2 = new List<FlatTimeOnlytime_without_time_zoneArray1M>();
                await ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 89, query1, 128, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[10],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[1],_testData[29], false);
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
                var firstItems1 = new List<FlatTimeOnlytime_without_time_zoneArray1M>();
                var firstItems2 = new List<FlatTimeOnlytime_without_time_zoneArray1M>();
                var secondItems1 = new List<FlatTimeOnlytime_without_time_zoneArray1M>();
                await ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 40, query1, 118, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[4],_testData[29], false);
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
FROM public.timeonlytime_without_time_zonearray1m m
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
FROM public.timeonlytime_without_time_zonearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeOnlytime_without_time_zoneArray1M>();
                var firstItems2 = new List<FlatTimeOnlytime_without_time_zoneArray1M>();
                var secondItems1 = new List<FlatTimeOnlytime_without_time_zoneArray1M>();
                var secondItems2 = new List<FlatTimeOnlytime_without_time_zoneArray1M>();
                 ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 29, query1, 45, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[23],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[19],_testData[29], false);
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
                var firstItems1 = new List<FlatTimeOnlytime_without_time_zoneArray1M>();
                var firstItems2 = new List<FlatTimeOnlytime_without_time_zoneArray1M>();
                var secondItems1 = new List<FlatTimeOnlytime_without_time_zoneArray1M>();
                 ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 5, query1, 34, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[21],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeOnlytime_without_time_zoneArray1M)],
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTDynQuerySelectModelBatch",
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
        private void DbConnectionSTDynQuerySelectModelBatchConfig()
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
                int resultIndex = 0;
                foreach(var batchResult in await ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 65, query1, 63, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[5],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[6],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[7],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[8],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[9],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[10],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[11],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[12],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[13],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[5],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[6],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[7],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[8],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[9],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[10],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[11],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[12],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[13],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[14],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[15],_testData[29], false);
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
FROM public.timeonlytime_without_time_zonearray1m m
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
FROM public.timeonlytime_without_time_zonearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeOnlytime_without_time_zoneArray1M>();
                var secondItems1 = new List<FlatTimeOnlytime_without_time_zoneArray1M>();
                var secondItems2 = new List<FlatTimeOnlytime_without_time_zoneArray1M>();
                await ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 63, query1, 53, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[18],_testData[29], false);
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
                int resultIndex = 0;
                foreach(var batchResult in  ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 45, query1, 120, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[5],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[6],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[7],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[8],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[9],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[10],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[11],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[12],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[13],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[14],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[15],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[16],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[17],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[18],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[29], false);
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
FROM public.timeonlytime_without_time_zonearray1m m
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
FROM public.timeonlytime_without_time_zonearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeOnlytime_without_time_zoneArray1M>();
                var secondItems1 = new List<FlatTimeOnlytime_without_time_zoneArray1M>();
                var secondItems2 = new List<FlatTimeOnlytime_without_time_zoneArray1M>();
                 ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionDynQuerySelectModelBatch(connection, 116, query1, 5, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[28],_testData[29], false);
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
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTSelectModelBatch",
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
        private void DbConnectionSTSelectModelBatchConfig()
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
        public async Task DbConnectionSTSelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in await ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionSTSelectModelBatchAsync(connection, 124, 19))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[27], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[28], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[3], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[4], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[5], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[6], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[7], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[5],_testData[8], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[6],_testData[9], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[7],_testData[10], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[8],_testData[11], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[9],_testData[12], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[10],_testData[13], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[11],_testData[14], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[12],_testData[15], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[13],_testData[16], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[14],_testData[17], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[15],_testData[18], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[16],_testData[19], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[17],_testData[20], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[18],_testData[21], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[19],_testData[22], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[20],_testData[23], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[21],_testData[24], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[22],_testData[25], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[23],_testData[26], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[24],_testData[27], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[25],_testData[28], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[26],_testData[29], false);
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
        public async Task DbConnectionSTSelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in  ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionSTSelectModelBatch(connection, 45, 10))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[10], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[11], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[12], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[13], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[14], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[5],_testData[15], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[6],_testData[16], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[7],_testData[17], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[8],_testData[18], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[9],_testData[19], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[10],_testData[20], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[11],_testData[21], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[12],_testData[22], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[13],_testData[23], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[14],_testData[24], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[15],_testData[25], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[16],_testData[26], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[17],_testData[27], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[18],_testData[28], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[2], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[3], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[4], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[5], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[6], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[5],_testData[7], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[6],_testData[8], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[7],_testData[9], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[8],_testData[10], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[9],_testData[11], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[10],_testData[12], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[11],_testData[13], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[12],_testData[14], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[13],_testData[15], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[14],_testData[16], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[15],_testData[17], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[16],_testData[18], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[17],_testData[19], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[18],_testData[20], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[19],_testData[21], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[20],_testData[22], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[21],_testData[23], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[22],_testData[24], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[23],_testData[25], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[24],_testData[26], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[25],_testData[27], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[26],_testData[28], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[27],_testData[29], false);
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
                ((ITimeOnlyArraytime_without_time_zoneArray)this).SetDbConnectionSelectModelParametrs(cmd, 61);
                var models = await ((ITimeOnlyArraytime_without_time_zoneArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(17));
TimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[13], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[14], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[15], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[16], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[17], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[5],_testData[18], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[6],_testData[19], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[7],_testData[20], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[8],_testData[21], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[9],_testData[22], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[10],_testData[23], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[11],_testData[24], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[12],_testData[25], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[13],_testData[26], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[14],_testData[27], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[15],_testData[28], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[16],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ITimeOnlyArraytime_without_time_zoneArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((ITimeOnlyArraytime_without_time_zoneArray)this).SetDbConnectionSelectModelParametrs(cmd, 104);
                var models =  ((ITimeOnlyArraytime_without_time_zoneArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(9));
TimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[21], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[22], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[23], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[24], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[25], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[5],_testData[26], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[6],_testData[27], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[7],_testData[28], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[8],_testData[29], false);
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
            queryMapType: typeof(TimeOnlytime_without_time_zoneArray1MI),
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
            queryMapType: typeof(TimeOnlytime_without_time_zoneArray1M),
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

