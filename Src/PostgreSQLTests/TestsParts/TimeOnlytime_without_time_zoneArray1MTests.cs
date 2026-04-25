

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
new TimeOnly(hour: 9, minute: 55, second: 25, millisecond: 268),
new TimeOnly(hour: 7, minute: 54, second: 26, millisecond: 559),
new TimeOnly(hour: 8, minute: 3, second: 32, millisecond: 397),
new TimeOnly(hour: 7, minute: 57, second: 22, millisecond: 63),
},
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 17, minute: 56, second: 33, millisecond: 198),
new TimeOnly(hour: 1, minute: 22, second: 34, millisecond: 236),
new TimeOnly(hour: 17, minute: 52, second: 27, millisecond: 116),
new TimeOnly(hour: 8, minute: 44, second: 21, millisecond: 606),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 7,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 13, minute: 30, second: 49, millisecond: 43),
new TimeOnly(hour: 20, minute: 25, second: 50, millisecond: 821),
new TimeOnly(hour: 8, minute: 3, second: 12, millisecond: 175),
new TimeOnly(hour: 13, minute: 53, second: 56, millisecond: 184),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 3,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 18, minute: 26, second: 45, millisecond: 237),
new TimeOnly(hour: 6, minute: 27, second: 14, millisecond: 202),
new TimeOnly(hour: 0, minute: 25, second: 3, millisecond: 257),
},
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 10, minute: 53, second: 36, millisecond: 483),
new TimeOnly(hour: 22, minute: 24, second: 48, millisecond: 846),
new TimeOnly(hour: 8, minute: 34, second: 0, millisecond: 838),
},
},
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 21, minute: 40, second: 19, millisecond: 445),
new TimeOnly(hour: 2, minute: 5, second: 40, millisecond: 378),
new TimeOnly(hour: 15, minute: 3, second: 7, millisecond: 691),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 9,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 14, minute: 31, second: 58, millisecond: 683),
new TimeOnly(hour: 14, minute: 52, second: 14, millisecond: 500),
new TimeOnly(hour: 21, minute: 39, second: 2, millisecond: 955),
new TimeOnly(hour: 2, minute: 48, second: 27, millisecond: 444),
},
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 15, minute: 39, second: 3, millisecond: 619),
new TimeOnly(hour: 16, minute: 50, second: 12, millisecond: 43),
new TimeOnly(hour: 12, minute: 12, second: 12, millisecond: 244),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 11,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 20, minute: 31, second: 8, millisecond: 129),
new TimeOnly(hour: 20, minute: 16, second: 25, millisecond: 574),
new TimeOnly(hour: 15, minute: 33, second: 41, millisecond: 778),
new TimeOnly(hour: 8, minute: 53, second: 41, millisecond: 890),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 8,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 11, minute: 52, second: 57, millisecond: 466),
new TimeOnly(hour: 10, minute: 31, second: 16, millisecond: 138),
new TimeOnly(hour: 12, minute: 15, second: 21, millisecond: 734),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 8, minute: 26, second: 4, millisecond: 938),
new TimeOnly(hour: 20, minute: 14, second: 25, millisecond: 466),
new TimeOnly(hour: 21, minute: 43, second: 54, millisecond: 489),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 19,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 5, minute: 11, second: 29, millisecond: 562),
new TimeOnly(hour: 0, minute: 12, second: 41, millisecond: 874),
new TimeOnly(hour: 13, minute: 22, second: 56, millisecond: 911),
},
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 0, minute: 9, second: 32, millisecond: 61),
new TimeOnly(hour: 20, minute: 22, second: 2, millisecond: 61),
new TimeOnly(hour: 6, minute: 56, second: 58, millisecond: 36),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 28,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 11, minute: 48, second: 11, millisecond: 572),
new TimeOnly(hour: 21, minute: 13, second: 21, millisecond: 892),
new TimeOnly(hour: 1, minute: 35, second: 15, millisecond: 769),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 10,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 12, minute: 19, second: 36, millisecond: 227),
new TimeOnly(hour: 12, minute: 46, second: 32, millisecond: 308),
new TimeOnly(hour: 0, minute: 23, second: 20, millisecond: 946),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 30,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 6, minute: 9, second: 37, millisecond: 324),
new TimeOnly(hour: 19, minute: 55, second: 20, millisecond: 362),
new TimeOnly(hour: 7, minute: 1, second: 16, millisecond: 214),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 32,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 3, minute: 35, second: 38, millisecond: 272),
new TimeOnly(hour: 7, minute: 39, second: 55, millisecond: 221),
new TimeOnly(hour: 20, minute: 10, second: 31, millisecond: 225),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 18,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 3, minute: 7, second: 31, millisecond: 95),
new TimeOnly(hour: 17, minute: 4, second: 21, millisecond: 116),
new TimeOnly(hour: 15, minute: 29, second: 14, millisecond: 630),
},
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 1, second: 46, millisecond: 159),
new TimeOnly(hour: 5, minute: 58, second: 16, millisecond: 557),
new TimeOnly(hour: 4, minute: 3, second: 10, millisecond: 889),
},
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 34,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 16, second: 35, millisecond: 127),
new TimeOnly(hour: 8, minute: 35, second: 9, millisecond: 822),
new TimeOnly(hour: 17, minute: 32, second: 25, millisecond: 153),
},
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 12, minute: 5, second: 2, millisecond: 765),
new TimeOnly(hour: 19, minute: 19, second: 57, millisecond: 778),
new TimeOnly(hour: 18, minute: 38, second: 13, millisecond: 547),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 35,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 21, minute: 29, second: 53, millisecond: 889),
new TimeOnly(hour: 15, minute: 6, second: 42, millisecond: 588),
new TimeOnly(hour: 15, minute: 14, second: 24, millisecond: 104),
new TimeOnly(hour: 0, minute: 51, second: 33, millisecond: 262),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 24,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 18, minute: 9, second: 10, millisecond: 637),
new TimeOnly(hour: 13, minute: 50, second: 20, millisecond: 575),
new TimeOnly(hour: 13, minute: 1, second: 28, millisecond: 211),
},
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 12, minute: 2, second: 16, millisecond: 143),
new TimeOnly(hour: 9, minute: 14, second: 29, millisecond: 10),
new TimeOnly(hour: 18, minute: 12, second: 11, millisecond: 739),
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
new TimeOnly(hour: 13, minute: 5, second: 21, millisecond: 354),
new TimeOnly(hour: 5, minute: 58, second: 37, millisecond: 702),
new TimeOnly(hour: 16, minute: 34, second: 45, millisecond: 319),
},
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 19, minute: 38, second: 37, millisecond: 700),
new TimeOnly(hour: 17, minute: 14, second: 58, millisecond: 221),
new TimeOnly(hour: 8, minute: 8, second: 35, millisecond: 556),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 46,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 15, minute: 33, second: 7, millisecond: 731),
new TimeOnly(hour: 15, minute: 53, second: 7, millisecond: 685),
new TimeOnly(hour: 16, minute: 4, second: 8, millisecond: 863),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 29,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 11, minute: 25, second: 57, millisecond: 179),
new TimeOnly(hour: 22, minute: 24, second: 18, millisecond: 600),
new TimeOnly(hour: 18, minute: 17, second: 31, millisecond: 931),
new TimeOnly(hour: 8, minute: 20, second: 37, millisecond: 954),
},
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 9, minute: 33, second: 55, millisecond: 484),
new TimeOnly(hour: 22, minute: 22, second: 42, millisecond: 181),
new TimeOnly(hour: 1, minute: 51, second: 31, millisecond: 420),
new TimeOnly(hour: 1, minute: 54, second: 33, millisecond: 323),
},
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 52,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 15, minute: 4, second: 23, millisecond: 797),
new TimeOnly(hour: 3, minute: 57, second: 57, millisecond: 182),
new TimeOnly(hour: 12, minute: 56, second: 7, millisecond: 307),
},
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 9, minute: 53, second: 31, millisecond: 21),
new TimeOnly(hour: 0, minute: 17, second: 34, millisecond: 234),
new TimeOnly(hour: 18, minute: 15, second: 25, millisecond: 709),
new TimeOnly(hour: 11, minute: 20, second: 11, millisecond: 7),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 57,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 22, minute: 49, second: 40, millisecond: 727),
new TimeOnly(hour: 0, minute: 24, second: 58, millisecond: 373),
new TimeOnly(hour: 13, minute: 19, second: 22, millisecond: 792),
new TimeOnly(hour: 22, minute: 39, second: 18, millisecond: 940),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 31,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 29, second: 48, millisecond: 479),
new TimeOnly(hour: 2, minute: 0, second: 51, millisecond: 612),
new TimeOnly(hour: 4, minute: 49, second: 55, millisecond: 525),
},
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 12, minute: 23, second: 48, millisecond: 392),
new TimeOnly(hour: 15, minute: 52, second: 5, millisecond: 162),
new TimeOnly(hour: 18, minute: 19, second: 25, millisecond: 733),
new TimeOnly(hour: 3, minute: 18, second: 1, millisecond: 409),
},
},
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 9, minute: 52, second: 10, millisecond: 992),
new TimeOnly(hour: 7, minute: 34, second: 32, millisecond: 932),
new TimeOnly(hour: 1, minute: 27, second: 13, millisecond: 352),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 66,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 13, minute: 53, second: 38, millisecond: 945),
new TimeOnly(hour: 22, minute: 58, second: 54, millisecond: 942),
new TimeOnly(hour: 6, minute: 51, second: 0, millisecond: 979),
},
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 13, minute: 26, second: 57, millisecond: 445),
new TimeOnly(hour: 9, minute: 13, second: 32, millisecond: 805),
new TimeOnly(hour: 22, minute: 17, second: 40, millisecond: 381),
new TimeOnly(hour: 13, minute: 30, second: 45, millisecond: 89),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 68,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 9, minute: 5, second: 9, millisecond: 412),
new TimeOnly(hour: 9, minute: 11, second: 57, millisecond: 612),
new TimeOnly(hour: 14, minute: 34, second: 24, millisecond: 587),
new TimeOnly(hour: 3, minute: 51, second: 16, millisecond: 677),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 38,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 0, minute: 5, second: 41, millisecond: 334),
new TimeOnly(hour: 12, minute: 50, second: 23, millisecond: 918),
new TimeOnly(hour: 21, minute: 20, second: 21, millisecond: 551),
},
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 20, minute: 32, second: 14, millisecond: 79),
new TimeOnly(hour: 15, minute: 5, second: 8, millisecond: 385),
new TimeOnly(hour: 3, minute: 29, second: 53, millisecond: 551),
new TimeOnly(hour: 0, minute: 22, second: 7, millisecond: 141),
},
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 72,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 18, minute: 25, second: 55, millisecond: 46),
new TimeOnly(hour: 20, minute: 35, second: 57, millisecond: 99),
new TimeOnly(hour: 1, minute: 44, second: 13, millisecond: 975),
new TimeOnly(hour: 6, minute: 49, second: 57, millisecond: 270),
},
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 15, minute: 22, second: 17, millisecond: 911),
new TimeOnly(hour: 1, minute: 41, second: 54, millisecond: 759),
new TimeOnly(hour: 6, minute: 54, second: 18, millisecond: 983),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 76,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 4, minute: 54, second: 43, millisecond: 9),
new TimeOnly(hour: 2, minute: 53, second: 58, millisecond: 297),
new TimeOnly(hour: 20, minute: 40, second: 45, millisecond: 873),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 47,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 18, minute: 22, second: 53, millisecond: 332),
new TimeOnly(hour: 19, minute: 47, second: 13, millisecond: 284),
new TimeOnly(hour: 12, minute: 52, second: 58, millisecond: 332),
new TimeOnly(hour: 16, minute: 38, second: 57, millisecond: 184),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 82,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 19, minute: 42, second: 38, millisecond: 690),
new TimeOnly(hour: 7, minute: 45, second: 35, millisecond: 130),
new TimeOnly(hour: 14, minute: 9, second: 39, millisecond: 546),
new TimeOnly(hour: 22, minute: 43, second: 0, millisecond: 530),
},
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 9, minute: 18, second: 38, millisecond: 540),
new TimeOnly(hour: 15, minute: 5, second: 22, millisecond: 725),
new TimeOnly(hour: 18, minute: 26, second: 48, millisecond: 108),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 88,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 5, minute: 14, second: 47, millisecond: 362),
new TimeOnly(hour: 16, minute: 4, second: 1, millisecond: 209),
new TimeOnly(hour: 16, minute: 4, second: 27, millisecond: 205),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 52,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 9, minute: 25, second: 36, millisecond: 693),
new TimeOnly(hour: 6, minute: 13, second: 23, millisecond: 882),
new TimeOnly(hour: 5, minute: 3, second: 19, millisecond: 41),
new TimeOnly(hour: 14, minute: 5, second: 47, millisecond: 682),
},
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 22, minute: 27, second: 31, millisecond: 636),
new TimeOnly(hour: 3, minute: 34, second: 11, millisecond: 3),
new TimeOnly(hour: 5, minute: 31, second: 28, millisecond: 898),
},
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 92,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 3, minute: 18, second: 27, millisecond: 313),
new TimeOnly(hour: 13, minute: 31, second: 36, millisecond: 549),
new TimeOnly(hour: 7, minute: 52, second: 58, millisecond: 127),
new TimeOnly(hour: 17, minute: 42, second: 3, millisecond: 740),
},
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 15, minute: 21, second: 36, millisecond: 736),
new TimeOnly(hour: 13, minute: 28, second: 40, millisecond: 477),
new TimeOnly(hour: 17, minute: 28, second: 8, millisecond: 274),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 101,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 4, minute: 6, second: 9, millisecond: 327),
new TimeOnly(hour: 9, minute: 22, second: 23, millisecond: 990),
new TimeOnly(hour: 19, minute: 39, second: 46, millisecond: 496),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 54,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 5, minute: 30, second: 33, millisecond: 544),
new TimeOnly(hour: 5, minute: 19, second: 0, millisecond: 455),
new TimeOnly(hour: 0, minute: 4, second: 30, millisecond: 259),
new TimeOnly(hour: 14, minute: 44, second: 48, millisecond: 844),
},
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 10, minute: 14, second: 21, millisecond: 184),
new TimeOnly(hour: 12, minute: 23, second: 40, millisecond: 685),
new TimeOnly(hour: 7, minute: 19, second: 16, millisecond: 654),
new TimeOnly(hour: 14, minute: 58, second: 42, millisecond: 345),
},
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 110,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 7, minute: 34, second: 9, millisecond: 907),
new TimeOnly(hour: 21, minute: 43, second: 39, millisecond: 340),
new TimeOnly(hour: 20, minute: 29, second: 20, millisecond: 341),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 114,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 16, minute: 29, second: 7, millisecond: 820),
new TimeOnly(hour: 17, minute: 29, second: 46, millisecond: 79),
new TimeOnly(hour: 21, minute: 53, second: 17, millisecond: 404),
new TimeOnly(hour: 17, minute: 44, second: 26, millisecond: 885),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 61,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 11, minute: 55, second: 28, millisecond: 638),
new TimeOnly(hour: 11, minute: 11, second: 17, millisecond: 851),
new TimeOnly(hour: 21, minute: 48, second: 42, millisecond: 441),
new TimeOnly(hour: 2, minute: 21, second: 40, millisecond: 903),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 119,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 17, minute: 45, second: 2, millisecond: 571),
new TimeOnly(hour: 13, minute: 55, second: 21, millisecond: 926),
new TimeOnly(hour: 2, minute: 18, second: 10, millisecond: 101),
new TimeOnly(hour: 20, minute: 9, second: 31, millisecond: 552),
},
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 4, minute: 51, second: 17, millisecond: 272),
new TimeOnly(hour: 15, minute: 49, second: 56, millisecond: 850),
new TimeOnly(hour: 17, minute: 15, second: 25, millisecond: 765),
new TimeOnly(hour: 21, minute: 36, second: 17, millisecond: 175),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 125,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 6, minute: 57, second: 44, millisecond: 278),
new TimeOnly(hour: 13, minute: 40, second: 37, millisecond: 478),
new TimeOnly(hour: 7, minute: 54, second: 18, millisecond: 664),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 68,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 9, minute: 40, second: 18, millisecond: 29),
new TimeOnly(hour: 21, minute: 18, second: 50, millisecond: 309),
new TimeOnly(hour: 2, minute: 12, second: 33, millisecond: 936),
},
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 1, minute: 15, second: 3, millisecond: 913),
new TimeOnly(hour: 1, minute: 55, second: 47, millisecond: 559),
new TimeOnly(hour: 9, minute: 56, second: 27, millisecond: 572),
new TimeOnly(hour: 2, minute: 37, second: 17, millisecond: 70),
},
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 129,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 22, minute: 55, second: 19, millisecond: 644),
new TimeOnly(hour: 18, minute: 25, second: 50, millisecond: 497),
new TimeOnly(hour: 14, minute: 26, second: 0, millisecond: 797),
new TimeOnly(hour: 15, minute: 24, second: 1, millisecond: 903),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 136,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 7, minute: 5, second: 28, millisecond: 481),
new TimeOnly(hour: 3, minute: 41, second: 48, millisecond: 211),
new TimeOnly(hour: 17, minute: 29, second: 45, millisecond: 484),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 74,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 10, minute: 10, second: 14, millisecond: 499),
new TimeOnly(hour: 4, minute: 45, second: 34, millisecond: 943),
new TimeOnly(hour: 16, minute: 41, second: 1, millisecond: 326),
},
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 15, minute: 33, second: 47, millisecond: 54),
new TimeOnly(hour: 21, minute: 24, second: 24, millisecond: 290),
new TimeOnly(hour: 8, minute: 31, second: 31, millisecond: 332),
},
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 142,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 1, minute: 12, second: 40, millisecond: 250),
new TimeOnly(hour: 12, minute: 22, second: 56, millisecond: 39),
new TimeOnly(hour: 18, minute: 48, second: 54, millisecond: 455),
new TimeOnly(hour: 15, minute: 15, second: 28, millisecond: 755),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 144,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 18, minute: 30, second: 51, millisecond: 75),
new TimeOnly(hour: 8, minute: 21, second: 18, millisecond: 872),
new TimeOnly(hour: 4, minute: 18, second: 31, millisecond: 277),
new TimeOnly(hour: 4, minute: 54, second: 7, millisecond: 846),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 76,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 1, minute: 9, second: 40, millisecond: 293),
new TimeOnly(hour: 22, minute: 28, second: 46, millisecond: 874),
new TimeOnly(hour: 11, minute: 43, second: 35, millisecond: 244),
},
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 7, minute: 19, second: 24, millisecond: 683),
new TimeOnly(hour: 20, minute: 28, second: 15, millisecond: 354),
new TimeOnly(hour: 0, minute: 19, second: 4, millisecond: 493),
new TimeOnly(hour: 14, minute: 22, second: 40, millisecond: 761),
},
},
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 1, minute: 56, second: 45, millisecond: 41),
new TimeOnly(hour: 3, minute: 56, second: 23, millisecond: 116),
new TimeOnly(hour: 16, minute: 27, second: 26, millisecond: 424),
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
LEFT JOIN public.timeonlytime_without_time_zonearray1mi mi ON mi.id = m.timeonlytime_without_time_zonearray1mi_id
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
LEFT JOIN public.timeonlytime_without_time_zonearray1mi mi ON mi.id = m.timeonlytime_without_time_zonearray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models =  ((ITimeOnlyArraytime_without_time_zoneArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
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

                var models =  ((ITimeOnlyArraytime_without_time_zoneArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    TimeOnlytime_without_time_zoneArray1M.AssertModel(models[i],_testData[i], false);
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
LEFT JOIN public.timeonlytime_without_time_zonearray1mi mi ON mi.id = m.timeonlytime_without_time_zonearray1mi_id
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
LEFT JOIN public.timeonlytime_without_time_zonearray1mi mi ON mi.id = m.timeonlytime_without_time_zonearray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models =  ((ITimeOnlyArraytime_without_time_zoneArray)this).DynQuerySelectModel(connection,  query, 0);
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
                var models =  ((ITimeOnlyArraytime_without_time_zoneArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    TimeOnlytime_without_time_zoneArray1M.AssertModel(models[i],_testData[i], false);
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
LEFT JOIN public.timeonlytime_without_time_zonearray1mi mi ON mi.id = m.timeonlytime_without_time_zonearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models = await ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
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
                parametr1.Value = 68;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 129;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.timeonlytime_without_time_zonearray1m m
LEFT JOIN public.timeonlytime_without_time_zonearray1mi mi ON mi.id = m.timeonlytime_without_time_zonearray1mi_id
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
LEFT JOIN public.timeonlytime_without_time_zonearray1mi mi ON mi.id = m.timeonlytime_without_time_zonearray1mi_id
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
                        Assert.That(models, Has.Count.EqualTo(3));
FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[27], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[28], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[29], false);
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
LEFT JOIN public.timeonlytime_without_time_zonearray1mi mi ON mi.id = m.timeonlytime_without_time_zonearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models =  ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
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
                parametr1.Value = 9;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 46;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.timeonlytime_without_time_zonearray1m m
LEFT JOIN public.timeonlytime_without_time_zonearray1mi mi ON mi.id = m.timeonlytime_without_time_zonearray1mi_id
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
LEFT JOIN public.timeonlytime_without_time_zonearray1mi mi ON mi.id = m.timeonlytime_without_time_zonearray1mi_id
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
                        Assert.That(models, Has.Count.EqualTo(27));
FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[3], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[4], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[5], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[6], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[7], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[5],_testData[8], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[6],_testData[9], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[7],_testData[10], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[8],_testData[11], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[9],_testData[12], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[10],_testData[13], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[11],_testData[14], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[12],_testData[15], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[13],_testData[16], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[14],_testData[17], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[15],_testData[18], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[16],_testData[19], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[17],_testData[20], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[18],_testData[21], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[19],_testData[22], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[20],_testData[23], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[21],_testData[24], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[22],_testData[25], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[23],_testData[26], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[24],_testData[27], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[25],_testData[28], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[12], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[13], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[14], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[15], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[16], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[5],_testData[17], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[6],_testData[18], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[7],_testData[19], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[8],_testData[20], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[9],_testData[21], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[10],_testData[22], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[11],_testData[23], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[12],_testData[24], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[13],_testData[25], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[14],_testData[26], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[15],_testData[27], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[16],_testData[28], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[17],_testData[29], false);
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

                var models = await ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
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
                parametr1.Value = 114;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 125;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));
TimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[24], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[25], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[26], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[27], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[28], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));
TimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[26], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[27], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[28], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[29], false);
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

                var models =  ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
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
                parametr1.Value = 72;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 19;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));
TimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[17], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[18], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[19], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[20], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[21], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[5],_testData[22], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[6],_testData[23], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[7],_testData[24], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[8],_testData[25], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[9],_testData[26], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[10],_testData[27], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[11],_testData[28], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));
TimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[5], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[6], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[7], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[8], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[9], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[5],_testData[10], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[6],_testData[11], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[7],_testData[12], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[8],_testData[13], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[9],_testData[14], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[10],_testData[15], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[11],_testData[16], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[12],_testData[17], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[13],_testData[18], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[14],_testData[19], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[15],_testData[20], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[16],_testData[21], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[17],_testData[22], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[18],_testData[23], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[19],_testData[24], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[20],_testData[25], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[21],_testData[26], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[22],_testData[27], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[23],_testData[28], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
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
LEFT JOIN public.timeonlytime_without_time_zonearray1mi mi ON mi.id = m.timeonlytime_without_time_zonearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
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
LEFT JOIN public.timeonlytime_without_time_zonearray1mi mi ON mi.id = m.timeonlytime_without_time_zonearray1mi_id
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
LEFT JOIN public.timeonlytime_without_time_zonearray1mi mi ON mi.id = m.timeonlytime_without_time_zonearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 46, query1, 88, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[12], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[13], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[14], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[15], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[16], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[5],_testData[17], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[6],_testData[18], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[7],_testData[19], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[8],_testData[20], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[9],_testData[21], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[10],_testData[22], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[11],_testData[23], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[12],_testData[24], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[13],_testData[25], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[14],_testData[26], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[15],_testData[27], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[16],_testData[28], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));
FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[20], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[21], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[22], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[23], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[24], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[5],_testData[25], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[6],_testData[26], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[7],_testData[27], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[8],_testData[28], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[9],_testData[29], false);
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
LEFT JOIN public.timeonlytime_without_time_zonearray1mi mi ON mi.id = m.timeonlytime_without_time_zonearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
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
LEFT JOIN public.timeonlytime_without_time_zonearray1mi mi ON mi.id = m.timeonlytime_without_time_zonearray1mi_id
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
LEFT JOIN public.timeonlytime_without_time_zonearray1mi mi ON mi.id = m.timeonlytime_without_time_zonearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionDynQuerySelectModelBatch(connection, 9, query1, 4, query2))
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
                        Assert.That(models, Has.Count.EqualTo(29));
FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[1], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[2], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[3], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[4], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[5], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[5],_testData[6], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[6],_testData[7], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[7],_testData[8], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[8],_testData[9], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[9],_testData[10], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[10],_testData[11], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[11],_testData[12], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[12],_testData[13], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[13],_testData[14], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[14],_testData[15], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[15],_testData[16], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[16],_testData[17], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[17],_testData[18], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[18],_testData[19], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[19],_testData[20], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[20],_testData[21], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[21],_testData[22], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[22],_testData[23], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[23],_testData[24], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[24],_testData[25], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[25],_testData[26], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[26],_testData[27], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[27],_testData[28], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[28],_testData[29], false);
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
                var models = await ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionSelectModelAsync(connection, 0);
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
                foreach(var batchResult in await ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionSelectModelBatchAsync(connection, 57, 40))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
TimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[14], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[15], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[16], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[17], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[18], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[5],_testData[19], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[6],_testData[20], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[7],_testData[21], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[8],_testData[22], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[9],_testData[23], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[10],_testData[24], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[11],_testData[25], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[12],_testData[26], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[13],_testData[27], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[14],_testData[28], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));
TimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[11], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[12], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[13], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[14], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[15], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[5],_testData[16], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[6],_testData[17], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[7],_testData[18], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[8],_testData[19], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[9],_testData[20], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[10],_testData[21], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[11],_testData[22], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[12],_testData[23], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[13],_testData[24], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[14],_testData[25], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[15],_testData[26], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[16],_testData[27], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[17],_testData[28], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[18],_testData[29], false);
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
                var models =  ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionSelectModel(connection, 0);
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
                foreach(var batchResult in  ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionSelectModelBatch(connection, 119, 46))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));
TimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[25], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[26], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[27], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[28], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
TimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[12], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[13], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[14], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[15], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[16], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[5],_testData[17], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[6],_testData[18], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[7],_testData[19], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[8],_testData[20], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[9],_testData[21], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[10],_testData[22], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[11],_testData[23], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[12],_testData[24], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[13],_testData[25], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[14],_testData[26], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[15],_testData[27], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[16],_testData[28], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[17],_testData[29], false);
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
                ((ITimeOnlyArraytime_without_time_zoneArray)this).SetDbConnectionSelectModelParametrs(cmd, 28);
                var models =  ((ITimeOnlyArraytime_without_time_zoneArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(24));
TimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[6], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[7], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[8], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[9], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[10], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[5],_testData[11], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[6],_testData[12], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[7],_testData[13], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[8],_testData[14], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[9],_testData[15], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[10],_testData[16], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[11],_testData[17], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[12],_testData[18], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[13],_testData[19], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[14],_testData[20], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[15],_testData[21], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[16],_testData[22], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[17],_testData[23], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[18],_testData[24], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[19],_testData[25], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[20],_testData[26], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[21],_testData[27], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[22],_testData[28], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[23],_testData[29], false);
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

