

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
    Id = 9,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 9, minute: 14, second: 13, millisecond: 855),
new TimeOnly(hour: 15, minute: 28, second: 25, millisecond: 56),
new TimeOnly(hour: 10, minute: 29, second: 4, millisecond: 483),
},
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 1, minute: 4, second: 26, millisecond: 33),
new TimeOnly(hour: 15, minute: 40, second: 13, millisecond: 871),
new TimeOnly(hour: 11, minute: 43, second: 39, millisecond: 476),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 18,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 4, minute: 16, second: 0, millisecond: 66),
new TimeOnly(hour: 5, minute: 8, second: 8, millisecond: 945),
new TimeOnly(hour: 19, minute: 5, second: 31, millisecond: 519),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 6,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 6, minute: 57, second: 7, millisecond: 408),
new TimeOnly(hour: 1, minute: 16, second: 54, millisecond: 152),
new TimeOnly(hour: 18, minute: 47, second: 52, millisecond: 616),
new TimeOnly(hour: 19, minute: 38, second: 25, millisecond: 154),
},
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 4, minute: 14, second: 34, millisecond: 680),
new TimeOnly(hour: 22, minute: 0, second: 54, millisecond: 480),
new TimeOnly(hour: 18, minute: 47, second: 57, millisecond: 648),
},
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 20,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 4, minute: 21, second: 47, millisecond: 360),
new TimeOnly(hour: 1, minute: 55, second: 38, millisecond: 859),
new TimeOnly(hour: 14, minute: 34, second: 26, millisecond: 969),
},
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 3, minute: 22, second: 32, millisecond: 816),
new TimeOnly(hour: 3, minute: 8, second: 2, millisecond: 808),
new TimeOnly(hour: 3, minute: 37, second: 56, millisecond: 843),
new TimeOnly(hour: 10, minute: 51, second: 40, millisecond: 753),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 29,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 9, minute: 16, second: 26, millisecond: 183),
new TimeOnly(hour: 9, minute: 48, second: 48, millisecond: 215),
new TimeOnly(hour: 14, minute: 38, second: 24, millisecond: 97),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 13,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 12, minute: 56, second: 35, millisecond: 325),
new TimeOnly(hour: 15, minute: 18, second: 17, millisecond: 216),
new TimeOnly(hour: 14, minute: 37, second: 9, millisecond: 442),
new TimeOnly(hour: 3, minute: 47, second: 43, millisecond: 569),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 32,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 22, minute: 17, second: 47, millisecond: 546),
new TimeOnly(hour: 17, minute: 51, second: 45, millisecond: 978),
new TimeOnly(hour: 21, minute: 12, second: 1, millisecond: 493),
},
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 18, minute: 48, second: 54, millisecond: 469),
new TimeOnly(hour: 17, minute: 33, second: 48, millisecond: 228),
new TimeOnly(hour: 11, minute: 43, second: 58, millisecond: 353),
new TimeOnly(hour: 19, minute: 45, second: 28, millisecond: 441),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 37,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 2, minute: 13, second: 4, millisecond: 647),
new TimeOnly(hour: 0, minute: 38, second: 17, millisecond: 783),
new TimeOnly(hour: 15, minute: 0, second: 37, millisecond: 228),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 22,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 6, minute: 19, second: 37, millisecond: 585),
new TimeOnly(hour: 10, minute: 16, second: 9, millisecond: 452),
new TimeOnly(hour: 10, minute: 8, second: 37, millisecond: 946),
new TimeOnly(hour: 8, minute: 37, second: 36, millisecond: 212),
},
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 12, minute: 6, second: 57, millisecond: 110),
new TimeOnly(hour: 17, minute: 29, second: 47, millisecond: 218),
new TimeOnly(hour: 20, minute: 45, second: 40, millisecond: 399),
},
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 38,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 18, minute: 47, second: 10, millisecond: 624),
new TimeOnly(hour: 13, minute: 57, second: 15, millisecond: 870),
new TimeOnly(hour: 19, minute: 13, second: 23, millisecond: 211),
},
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 6, minute: 21, second: 31, millisecond: 320),
new TimeOnly(hour: 17, minute: 37, second: 24, millisecond: 578),
new TimeOnly(hour: 9, minute: 18, second: 41, millisecond: 222),
new TimeOnly(hour: 19, minute: 2, second: 9, millisecond: 99),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 47,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 27, second: 18, millisecond: 413),
new TimeOnly(hour: 6, minute: 9, second: 31, millisecond: 651),
new TimeOnly(hour: 11, minute: 25, second: 12, millisecond: 644),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 31,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 15, minute: 16, second: 54, millisecond: 576),
new TimeOnly(hour: 17, minute: 48, second: 12, millisecond: 444),
new TimeOnly(hour: 5, minute: 41, second: 51, millisecond: 652),
new TimeOnly(hour: 4, minute: 51, second: 39, millisecond: 944),
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
new TimeOnly(hour: 21, minute: 8, second: 39, millisecond: 374),
new TimeOnly(hour: 16, minute: 26, second: 8, millisecond: 329),
new TimeOnly(hour: 14, minute: 0, second: 39, millisecond: 905),
new TimeOnly(hour: 3, minute: 31, second: 19, millisecond: 481),
},
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 15, minute: 7, second: 36, millisecond: 407),
new TimeOnly(hour: 5, minute: 41, second: 42, millisecond: 271),
new TimeOnly(hour: 21, minute: 34, second: 5, millisecond: 946),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 61,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 6, minute: 21, second: 13, millisecond: 85),
new TimeOnly(hour: 5, minute: 39, second: 38, millisecond: 588),
new TimeOnly(hour: 2, minute: 2, second: 33, millisecond: 949),
new TimeOnly(hour: 4, minute: 58, second: 41, millisecond: 872),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 35,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 8, minute: 4, second: 5, millisecond: 853),
new TimeOnly(hour: 14, minute: 50, second: 13, millisecond: 703),
new TimeOnly(hour: 1, minute: 34, second: 42, millisecond: 587),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 70,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 10, minute: 53, second: 57, millisecond: 154),
new TimeOnly(hour: 1, minute: 50, second: 41, millisecond: 692),
new TimeOnly(hour: 3, minute: 8, second: 18, millisecond: 460),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 74,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 15, minute: 6, second: 42, millisecond: 961),
new TimeOnly(hour: 6, minute: 0, second: 49, millisecond: 374),
new TimeOnly(hour: 18, minute: 29, second: 57, millisecond: 365),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 44,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 19, minute: 52, second: 47, millisecond: 188),
new TimeOnly(hour: 1, minute: 43, second: 5, millisecond: 915),
new TimeOnly(hour: 0, minute: 9, second: 51, millisecond: 19),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 78,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 50, second: 57, millisecond: 953),
new TimeOnly(hour: 12, minute: 19, second: 7, millisecond: 172),
new TimeOnly(hour: 3, minute: 40, second: 36, millisecond: 95),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 79,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 18, minute: 25, second: 38, millisecond: 754),
new TimeOnly(hour: 13, minute: 17, second: 1, millisecond: 367),
new TimeOnly(hour: 5, minute: 47, second: 36, millisecond: 334),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 45,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 8, minute: 17, second: 29, millisecond: 702),
new TimeOnly(hour: 20, minute: 40, second: 39, millisecond: 727),
new TimeOnly(hour: 10, minute: 33, second: 22, millisecond: 783),
new TimeOnly(hour: 6, minute: 31, second: 5, millisecond: 711),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 88,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 40, second: 14, millisecond: 568),
new TimeOnly(hour: 3, minute: 23, second: 21, millisecond: 437),
new TimeOnly(hour: 11, minute: 54, second: 40, millisecond: 994),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 94,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 1, minute: 53, second: 28, millisecond: 514),
new TimeOnly(hour: 10, minute: 0, second: 38, millisecond: 53),
new TimeOnly(hour: 4, minute: 46, second: 57, millisecond: 756),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 53,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 10, minute: 4, second: 25, millisecond: 643),
new TimeOnly(hour: 8, minute: 21, second: 6, millisecond: 950),
new TimeOnly(hour: 5, minute: 49, second: 5, millisecond: 736),
},
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 5, minute: 47, second: 46, millisecond: 938),
new TimeOnly(hour: 20, minute: 25, second: 4, millisecond: 248),
new TimeOnly(hour: 0, minute: 28, second: 11, millisecond: 509),
},
},
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 8, minute: 1, second: 16, millisecond: 591),
new TimeOnly(hour: 4, minute: 3, second: 58, millisecond: 722),
new TimeOnly(hour: 20, minute: 2, second: 30, millisecond: 994),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 98,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 7, minute: 57, second: 43, millisecond: 750),
new TimeOnly(hour: 12, minute: 43, second: 9, millisecond: 673),
new TimeOnly(hour: 14, minute: 46, second: 57, millisecond: 173),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 105,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 0, minute: 19, second: 17, millisecond: 615),
new TimeOnly(hour: 12, minute: 28, second: 14, millisecond: 734),
new TimeOnly(hour: 3, minute: 56, second: 34, millisecond: 747),
new TimeOnly(hour: 15, minute: 19, second: 9, millisecond: 476),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 59,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 22, minute: 27, second: 57, millisecond: 193),
new TimeOnly(hour: 11, minute: 47, second: 42, millisecond: 973),
new TimeOnly(hour: 1, minute: 35, second: 30, millisecond: 295),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 11, minute: 8, second: 21, millisecond: 422),
new TimeOnly(hour: 4, minute: 31, second: 53, millisecond: 734),
new TimeOnly(hour: 9, minute: 12, second: 14, millisecond: 793),
new TimeOnly(hour: 18, minute: 24, second: 4, millisecond: 303),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 111,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 6, minute: 24, second: 30, millisecond: 841),
new TimeOnly(hour: 15, minute: 0, second: 36, millisecond: 927),
new TimeOnly(hour: 13, minute: 32, second: 13, millisecond: 907),
new TimeOnly(hour: 1, minute: 3, second: 20, millisecond: 16),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 112,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 7, minute: 19, second: 56, millisecond: 347),
new TimeOnly(hour: 2, minute: 58, second: 34, millisecond: 389),
new TimeOnly(hour: 18, minute: 23, second: 11, millisecond: 759),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 60,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 0, minute: 21, second: 47, millisecond: 141),
new TimeOnly(hour: 14, minute: 26, second: 1, millisecond: 276),
new TimeOnly(hour: 13, minute: 10, second: 38, millisecond: 826),
},
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 21, minute: 58, second: 7, millisecond: 238),
new TimeOnly(hour: 6, minute: 56, second: 1, millisecond: 633),
new TimeOnly(hour: 8, minute: 38, second: 50, millisecond: 891),
},
},
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 19, minute: 50, second: 37, millisecond: 188),
new TimeOnly(hour: 10, minute: 47, second: 0, millisecond: 734),
new TimeOnly(hour: 17, minute: 34, second: 24, millisecond: 753),
new TimeOnly(hour: 6, minute: 46, second: 17, millisecond: 637),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 114,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 20, minute: 3, second: 57, millisecond: 98),
new TimeOnly(hour: 18, minute: 5, second: 58, millisecond: 189),
new TimeOnly(hour: 11, minute: 39, second: 49, millisecond: 498),
new TimeOnly(hour: 18, minute: 48, second: 40, millisecond: 155),
},
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 22, minute: 3, second: 56, millisecond: 367),
new TimeOnly(hour: 16, minute: 34, second: 32, millisecond: 105),
new TimeOnly(hour: 3, minute: 41, second: 26, millisecond: 208),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 118,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 7, minute: 12, second: 33, millisecond: 31),
new TimeOnly(hour: 3, minute: 16, second: 22, millisecond: 166),
new TimeOnly(hour: 8, minute: 18, second: 51, millisecond: 337),
new TimeOnly(hour: 14, minute: 17, second: 31, millisecond: 665),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 64,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 15, minute: 2, second: 17, millisecond: 696),
new TimeOnly(hour: 3, minute: 26, second: 8, millisecond: 394),
new TimeOnly(hour: 13, minute: 29, second: 1, millisecond: 942),
},
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 19, minute: 36, second: 0, millisecond: 82),
new TimeOnly(hour: 17, minute: 47, second: 38, millisecond: 636),
new TimeOnly(hour: 19, minute: 29, second: 43, millisecond: 888),
},
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 125,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 20, minute: 34, second: 42, millisecond: 536),
new TimeOnly(hour: 8, minute: 23, second: 53, millisecond: 962),
new TimeOnly(hour: 5, minute: 37, second: 44, millisecond: 68),
new TimeOnly(hour: 18, minute: 14, second: 35, millisecond: 345),
},
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 17, minute: 24, second: 28, millisecond: 732),
new TimeOnly(hour: 15, minute: 23, second: 1, millisecond: 700),
new TimeOnly(hour: 16, minute: 17, second: 45, millisecond: 250),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 133,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 6, minute: 41, second: 27, millisecond: 593),
new TimeOnly(hour: 3, minute: 55, second: 27, millisecond: 333),
new TimeOnly(hour: 6, minute: 14, second: 2, millisecond: 472),
new TimeOnly(hour: 7, minute: 16, second: 23, millisecond: 411),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 70,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 16, minute: 2, second: 29, millisecond: 342),
new TimeOnly(hour: 0, minute: 30, second: 51, millisecond: 117),
new TimeOnly(hour: 1, minute: 53, second: 19, millisecond: 403),
new TimeOnly(hour: 11, minute: 32, second: 0, millisecond: 545),
},
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 6, minute: 31, second: 41, millisecond: 330),
new TimeOnly(hour: 3, minute: 15, second: 23, millisecond: 482),
new TimeOnly(hour: 13, minute: 26, second: 53, millisecond: 198),
new TimeOnly(hour: 15, minute: 13, second: 47, millisecond: 379),
},
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 135,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 9, minute: 35, second: 57, millisecond: 804),
new TimeOnly(hour: 14, minute: 32, second: 39, millisecond: 57),
new TimeOnly(hour: 1, minute: 32, second: 40, millisecond: 817),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 139,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 11, minute: 32, second: 31, millisecond: 947),
new TimeOnly(hour: 20, minute: 21, second: 10, millisecond: 710),
new TimeOnly(hour: 18, minute: 32, second: 41, millisecond: 366),
new TimeOnly(hour: 20, minute: 31, second: 13, millisecond: 631),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 72,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 21, second: 41, millisecond: 901),
new TimeOnly(hour: 14, minute: 49, second: 8, millisecond: 136),
new TimeOnly(hour: 0, minute: 13, second: 29, millisecond: 277),
},
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 6, minute: 43, second: 39, millisecond: 525),
new TimeOnly(hour: 6, minute: 28, second: 44, millisecond: 620),
new TimeOnly(hour: 10, minute: 4, second: 17, millisecond: 3),
new TimeOnly(hour: 17, minute: 30, second: 42, millisecond: 81),
},
},
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 16, minute: 15, second: 29, millisecond: 357),
new TimeOnly(hour: 1, minute: 42, second: 58, millisecond: 943),
new TimeOnly(hour: 8, minute: 33, second: 53, millisecond: 465),
new TimeOnly(hour: 5, minute: 22, second: 26, millisecond: 982),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 144,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 0, minute: 41, second: 36, millisecond: 512),
new TimeOnly(hour: 18, minute: 33, second: 5, millisecond: 586),
new TimeOnly(hour: 2, minute: 13, second: 4, millisecond: 400),
new TimeOnly(hour: 3, minute: 7, second: 33, millisecond: 745),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 152,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 6, minute: 43, second: 49, millisecond: 295),
new TimeOnly(hour: 11, minute: 31, second: 29, millisecond: 670),
new TimeOnly(hour: 19, minute: 11, second: 29, millisecond: 522),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 76,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 9, minute: 33, second: 48, millisecond: 294),
new TimeOnly(hour: 15, minute: 44, second: 12, millisecond: 292),
new TimeOnly(hour: 6, minute: 28, second: 35, millisecond: 689),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 21, minute: 22, second: 49, millisecond: 551),
new TimeOnly(hour: 0, minute: 10, second: 30, millisecond: 967),
new TimeOnly(hour: 17, minute: 20, second: 39, millisecond: 26),
new TimeOnly(hour: 13, minute: 57, second: 20, millisecond: 111),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 155,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 17, minute: 9, second: 25, millisecond: 304),
new TimeOnly(hour: 8, minute: 46, second: 7, millisecond: 334),
new TimeOnly(hour: 22, minute: 37, second: 42, millisecond: 923),
new TimeOnly(hour: 16, minute: 52, second: 23, millisecond: 101),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 156,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 16, minute: 40, second: 47, millisecond: 28),
new TimeOnly(hour: 1, minute: 17, second: 3, millisecond: 739),
new TimeOnly(hour: 5, minute: 56, second: 57, millisecond: 48),
new TimeOnly(hour: 13, minute: 55, second: 48, millisecond: 214),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 78,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 20, minute: 42, second: 19, millisecond: 108),
new TimeOnly(hour: 9, minute: 43, second: 13, millisecond: 753),
new TimeOnly(hour: 18, minute: 19, second: 26, millisecond: 761),
new TimeOnly(hour: 20, minute: 19, second: 47, millisecond: 750),
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 37;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 61;
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
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[19],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 98;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 111;
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
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[10],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 47;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 20;
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
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[26],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
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
                parametr2.Value = 88;
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
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[14],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 61;
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
                foreach(var batchResult in await ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 20;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 105;
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
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[11],_testData[30], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 133;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 105;
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
                foreach(var batchResult in  ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[5],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[6],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[7],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[8],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[9],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[10],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[11],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 144;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 32;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[24],_testData[30], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 152;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 78;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[28], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 118;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 139;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[22], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[23], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[24], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[25], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[26], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[5],_testData[27], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[6],_testData[28], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[7],_testData[29], false);
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
                int resultIndex = 0;
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
                await ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 118, query1, 61, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[19],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
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
                await ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 98, query1, 32, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[24],_testData[29], false);
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
                int resultIndex = 0;
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
                 ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 88, query1, 78, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[16],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
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
                 ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 133, query1, 152, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[1],_testData[29], false);
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
                foreach(var batchResult in await ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 9, query1, 114, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[1], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[2], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[3], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[4], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[5], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[5],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[6],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[7],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[8],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[9],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[10],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[11],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[12],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[13],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[14],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[15],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[16],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[17],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[18],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[19],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[20],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[21],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[22],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[23],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[24],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[25],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[26],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[27],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[5],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[6],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[7],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[8],_testData[29], false);
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
                await ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 29, query1, 144, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[2],_testData[30], false);
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
                foreach(var batchResult in  ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 112, query1, 79, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[5],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[6],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[7],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[8],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[9],_testData[29], false);
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
                 ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionDynQuerySelectModelBatch(connection, 61, query1, 98, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[12],_testData[30], false);
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
                foreach(var batchResult in await ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionSTSelectModelBatchAsync(connection, 135, 53))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[25], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[26], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[27], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[28], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[9], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[10], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[11], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[12], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[13], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[5],_testData[14], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[6],_testData[15], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[7],_testData[16], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[8],_testData[17], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[9],_testData[18], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[10],_testData[19], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[11],_testData[20], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[12],_testData[21], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[13],_testData[22], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[14],_testData[23], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[15],_testData[24], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[16],_testData[25], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[17],_testData[26], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[18],_testData[27], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[19],_testData[28], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[20],_testData[29], false);
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
                foreach(var batchResult in  ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionSTSelectModelBatch(connection, 114, 47))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[21], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[22], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[23], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[24], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[25], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[5],_testData[26], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[6],_testData[27], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[7],_testData[28], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[8], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[9], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[10], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[11], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[12], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[5],_testData[13], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[6],_testData[14], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[7],_testData[15], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[8],_testData[16], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[9],_testData[17], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[10],_testData[18], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[11],_testData[19], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[12],_testData[20], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[13],_testData[21], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[14],_testData[22], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[15],_testData[23], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[16],_testData[24], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[17],_testData[25], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[18],_testData[26], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[19],_testData[27], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[20],_testData[28], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[21],_testData[29], false);
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
                ((ITimeOnlyArraytime_without_time_zoneArray)this).SetDbConnectionSelectModelParametrs(cmd, 20);
                var models = await ((ITimeOnlyArraytime_without_time_zoneArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(27));
TimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[3], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[4], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[5], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[6], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[7], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[5],_testData[8], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[6],_testData[9], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[7],_testData[10], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[8],_testData[11], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[9],_testData[12], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[10],_testData[13], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[11],_testData[14], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[12],_testData[15], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[13],_testData[16], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[14],_testData[17], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[15],_testData[18], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[16],_testData[19], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[17],_testData[20], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[18],_testData[21], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[19],_testData[22], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[20],_testData[23], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[21],_testData[24], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[22],_testData[25], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[23],_testData[26], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[24],_testData[27], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[25],_testData[28], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[26],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ITimeOnlyArraytime_without_time_zoneArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((ITimeOnlyArraytime_without_time_zoneArray)this).SetDbConnectionSelectModelParametrs(cmd, 74);
                var models =  ((ITimeOnlyArraytime_without_time_zoneArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(18));
TimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[12], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[13], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[14], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[15], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[16], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[5],_testData[17], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[6],_testData[18], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[7],_testData[19], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[8],_testData[20], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[9],_testData[21], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[10],_testData[22], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[11],_testData[23], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[12],_testData[24], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[13],_testData[25], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[14],_testData[26], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[15],_testData[27], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[16],_testData[28], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[17],_testData[29], false);
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

