

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
    Id = 6,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 13, minute: 26, second: 21, millisecond: 703),
new TimeOnly(hour: 13, minute: 1, second: 2, millisecond: 398),
new TimeOnly(hour: 0, minute: 0, second: 11, millisecond: 551),
},
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 18, minute: 48, second: 33, millisecond: 177),
new TimeOnly(hour: 14, minute: 49, second: 49, millisecond: 382),
new TimeOnly(hour: 11, minute: 53, second: 17, millisecond: 901),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 8,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 28, second: 7, millisecond: 61),
new TimeOnly(hour: 21, minute: 12, second: 57, millisecond: 739),
new TimeOnly(hour: 8, minute: 6, second: 3, millisecond: 974),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 6,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 17, minute: 56, second: 35, millisecond: 513),
new TimeOnly(hour: 8, minute: 33, second: 12, millisecond: 242),
new TimeOnly(hour: 6, minute: 21, second: 31, millisecond: 971),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 6, minute: 22, second: 45, millisecond: 221),
new TimeOnly(hour: 5, minute: 45, second: 21, millisecond: 427),
new TimeOnly(hour: 4, minute: 30, second: 18, millisecond: 256),
new TimeOnly(hour: 21, minute: 14, second: 17, millisecond: 295),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 10,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 18, second: 25, millisecond: 46),
new TimeOnly(hour: 6, minute: 19, second: 37, millisecond: 961),
new TimeOnly(hour: 20, minute: 3, second: 20, millisecond: 60),
},
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 13, minute: 45, second: 54, millisecond: 949),
new TimeOnly(hour: 19, minute: 14, second: 51, millisecond: 882),
new TimeOnly(hour: 14, minute: 7, second: 20, millisecond: 207),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 18,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 3, minute: 8, second: 50, millisecond: 925),
new TimeOnly(hour: 4, minute: 48, second: 8, millisecond: 35),
new TimeOnly(hour: 11, minute: 1, second: 38, millisecond: 815),
new TimeOnly(hour: 6, minute: 27, second: 8, millisecond: 597),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 7,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 19, minute: 31, second: 58, millisecond: 383),
new TimeOnly(hour: 12, minute: 47, second: 31, millisecond: 761),
new TimeOnly(hour: 2, minute: 33, second: 14, millisecond: 16),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 6, minute: 25, second: 10, millisecond: 293),
new TimeOnly(hour: 12, minute: 9, second: 16, millisecond: 576),
new TimeOnly(hour: 22, minute: 6, second: 48, millisecond: 599),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 19,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 4, minute: 37, second: 35, millisecond: 874),
new TimeOnly(hour: 4, minute: 15, second: 30, millisecond: 542),
new TimeOnly(hour: 0, minute: 8, second: 5, millisecond: 873),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 25,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 10, minute: 23, second: 47, millisecond: 541),
new TimeOnly(hour: 5, minute: 8, second: 57, millisecond: 419),
new TimeOnly(hour: 15, minute: 7, second: 25, millisecond: 97),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 12,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 17, minute: 30, second: 4, millisecond: 751),
new TimeOnly(hour: 12, minute: 5, second: 41, millisecond: 390),
new TimeOnly(hour: 13, minute: 41, second: 12, millisecond: 958),
new TimeOnly(hour: 14, minute: 48, second: 18, millisecond: 818),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 34,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 12, minute: 39, second: 21, millisecond: 246),
new TimeOnly(hour: 15, minute: 50, second: 15, millisecond: 471),
new TimeOnly(hour: 18, minute: 45, second: 35, millisecond: 109),
new TimeOnly(hour: 14, minute: 24, second: 22, millisecond: 251),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 36,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 22, minute: 38, second: 35, millisecond: 132),
new TimeOnly(hour: 7, minute: 44, second: 8, millisecond: 194),
new TimeOnly(hour: 20, minute: 0, second: 17, millisecond: 39),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 17,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 5, minute: 1, second: 44, millisecond: 956),
new TimeOnly(hour: 16, minute: 10, second: 10, millisecond: 750),
new TimeOnly(hour: 0, minute: 15, second: 24, millisecond: 606),
},
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 3, minute: 36, second: 9, millisecond: 977),
new TimeOnly(hour: 1, minute: 16, second: 25, millisecond: 888),
new TimeOnly(hour: 17, minute: 53, second: 48, millisecond: 135),
},
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 44,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 9, minute: 13, second: 34, millisecond: 791),
new TimeOnly(hour: 11, minute: 16, second: 37, millisecond: 251),
new TimeOnly(hour: 2, minute: 7, second: 52, millisecond: 836),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 46,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 2, minute: 34, second: 44, millisecond: 559),
new TimeOnly(hour: 21, minute: 23, second: 21, millisecond: 827),
new TimeOnly(hour: 14, minute: 41, second: 57, millisecond: 117),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 19,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 17, minute: 9, second: 41, millisecond: 209),
new TimeOnly(hour: 2, minute: 5, second: 26, millisecond: 272),
new TimeOnly(hour: 19, minute: 17, second: 11, millisecond: 408),
new TimeOnly(hour: 6, minute: 39, second: 11, millisecond: 811),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 48,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 13, minute: 42, second: 48, millisecond: 166),
new TimeOnly(hour: 7, minute: 52, second: 11, millisecond: 41),
new TimeOnly(hour: 13, minute: 51, second: 2, millisecond: 168),
},
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 3, minute: 24, second: 8, millisecond: 9),
new TimeOnly(hour: 0, minute: 31, second: 4, millisecond: 188),
new TimeOnly(hour: 9, minute: 41, second: 58, millisecond: 214),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 54,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 19, minute: 13, second: 49, millisecond: 323),
new TimeOnly(hour: 15, minute: 5, second: 35, millisecond: 216),
new TimeOnly(hour: 7, minute: 46, second: 55, millisecond: 961),
new TimeOnly(hour: 15, minute: 51, second: 32, millisecond: 371),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 25,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 2, minute: 37, second: 9, millisecond: 361),
new TimeOnly(hour: 13, minute: 14, second: 15, millisecond: 403),
new TimeOnly(hour: 11, minute: 10, second: 40, millisecond: 129),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 56,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 21, second: 15, millisecond: 992),
new TimeOnly(hour: 16, minute: 25, second: 5, millisecond: 450),
new TimeOnly(hour: 18, minute: 38, second: 43, millisecond: 728),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 58,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 16, minute: 38, second: 41, millisecond: 800),
new TimeOnly(hour: 1, minute: 42, second: 29, millisecond: 573),
new TimeOnly(hour: 16, minute: 57, second: 9, millisecond: 858),
new TimeOnly(hour: 0, minute: 16, second: 1, millisecond: 978),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 34,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 17, minute: 56, second: 3, millisecond: 876),
new TimeOnly(hour: 11, minute: 25, second: 56, millisecond: 477),
new TimeOnly(hour: 0, minute: 46, second: 55, millisecond: 177),
new TimeOnly(hour: 0, minute: 47, second: 46, millisecond: 254),
},
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 8, minute: 14, second: 17, millisecond: 484),
new TimeOnly(hour: 5, minute: 50, second: 15, millisecond: 480),
new TimeOnly(hour: 5, minute: 27, second: 25, millisecond: 592),
},
},
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 19, minute: 39, second: 13, millisecond: 676),
new TimeOnly(hour: 12, minute: 28, second: 53, millisecond: 423),
new TimeOnly(hour: 17, minute: 1, second: 14, millisecond: 549),
new TimeOnly(hour: 18, minute: 43, second: 31, millisecond: 713),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 59,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 8, minute: 47, second: 34, millisecond: 237),
new TimeOnly(hour: 13, minute: 21, second: 10, millisecond: 30),
new TimeOnly(hour: 13, minute: 12, second: 4, millisecond: 572),
new TimeOnly(hour: 19, minute: 1, second: 53, millisecond: 529),
},
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 2, minute: 52, second: 50, millisecond: 250),
new TimeOnly(hour: 8, minute: 8, second: 3, millisecond: 276),
new TimeOnly(hour: 19, minute: 52, second: 12, millisecond: 354),
new TimeOnly(hour: 3, minute: 12, second: 3, millisecond: 969),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 61,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 21, minute: 25, second: 22, millisecond: 819),
new TimeOnly(hour: 1, minute: 18, second: 41, millisecond: 926),
new TimeOnly(hour: 15, minute: 3, second: 45, millisecond: 855),
new TimeOnly(hour: 15, minute: 42, second: 27, millisecond: 126),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 40,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 12, minute: 40, second: 54, millisecond: 956),
new TimeOnly(hour: 17, minute: 16, second: 4, millisecond: 724),
new TimeOnly(hour: 10, minute: 49, second: 34, millisecond: 791),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 13, minute: 22, second: 47, millisecond: 595),
new TimeOnly(hour: 9, minute: 37, second: 21, millisecond: 537),
new TimeOnly(hour: 15, minute: 54, second: 39, millisecond: 766),
new TimeOnly(hour: 17, minute: 28, second: 5, millisecond: 953),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 68,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 11, minute: 22, second: 25, millisecond: 928),
new TimeOnly(hour: 11, minute: 46, second: 19, millisecond: 634),
new TimeOnly(hour: 21, minute: 19, second: 4, millisecond: 625),
new TimeOnly(hour: 7, minute: 8, second: 5, millisecond: 961),
},
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 15, minute: 23, second: 33, millisecond: 132),
new TimeOnly(hour: 1, minute: 27, second: 12, millisecond: 673),
new TimeOnly(hour: 19, minute: 22, second: 34, millisecond: 57),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 73,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 58, second: 24, millisecond: 182),
new TimeOnly(hour: 20, minute: 53, second: 46, millisecond: 606),
new TimeOnly(hour: 19, minute: 11, second: 4, millisecond: 986),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 47,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 43, second: 3, millisecond: 155),
new TimeOnly(hour: 0, minute: 8, second: 6, millisecond: 104),
new TimeOnly(hour: 21, minute: 9, second: 24, millisecond: 542),
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
new TimeOnly(hour: 8, minute: 3, second: 0, millisecond: 527),
new TimeOnly(hour: 1, minute: 25, second: 36, millisecond: 407),
new TimeOnly(hour: 10, minute: 37, second: 38, millisecond: 852),
},
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 19, minute: 55, second: 41, millisecond: 810),
new TimeOnly(hour: 8, minute: 2, second: 11, millisecond: 702),
new TimeOnly(hour: 6, minute: 26, second: 27, millisecond: 644),
new TimeOnly(hour: 17, minute: 6, second: 11, millisecond: 148),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 83,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 9, minute: 51, second: 11, millisecond: 512),
new TimeOnly(hour: 12, minute: 28, second: 22, millisecond: 214),
new TimeOnly(hour: 2, minute: 30, second: 14, millisecond: 662),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 50,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 9, minute: 27, second: 26, millisecond: 316),
new TimeOnly(hour: 11, minute: 12, second: 4, millisecond: 325),
new TimeOnly(hour: 21, minute: 19, second: 46, millisecond: 889),
},
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 3, minute: 33, second: 55, millisecond: 511),
new TimeOnly(hour: 3, minute: 37, second: 11, millisecond: 116),
new TimeOnly(hour: 3, minute: 19, second: 34, millisecond: 208),
new TimeOnly(hour: 9, minute: 51, second: 57, millisecond: 699),
},
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 90,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 13, minute: 50, second: 24, millisecond: 254),
new TimeOnly(hour: 2, minute: 45, second: 4, millisecond: 938),
new TimeOnly(hour: 7, minute: 43, second: 15, millisecond: 602),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 98,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 18, minute: 7, second: 23, millisecond: 519),
new TimeOnly(hour: 19, minute: 32, second: 51, millisecond: 636),
new TimeOnly(hour: 9, minute: 12, second: 29, millisecond: 941),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 57,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 8, minute: 23, second: 5, millisecond: 319),
new TimeOnly(hour: 22, minute: 8, second: 31, millisecond: 955),
new TimeOnly(hour: 2, minute: 53, second: 35, millisecond: 271),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 8, minute: 55, second: 34, millisecond: 484),
new TimeOnly(hour: 10, minute: 15, second: 30, millisecond: 607),
new TimeOnly(hour: 17, minute: 6, second: 53, millisecond: 493),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 102,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 17, minute: 35, second: 39, millisecond: 304),
new TimeOnly(hour: 8, minute: 25, second: 9, millisecond: 204),
new TimeOnly(hour: 20, minute: 0, second: 12, millisecond: 821),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 104,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 17, minute: 10, second: 19, millisecond: 725),
new TimeOnly(hour: 4, minute: 26, second: 20, millisecond: 820),
new TimeOnly(hour: 8, minute: 4, second: 0, millisecond: 883),
new TimeOnly(hour: 21, minute: 31, second: 28, millisecond: 666),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 64,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 21, minute: 13, second: 1, millisecond: 916),
new TimeOnly(hour: 9, minute: 48, second: 6, millisecond: 995),
new TimeOnly(hour: 22, minute: 5, second: 38, millisecond: 929),
new TimeOnly(hour: 19, minute: 35, second: 37, millisecond: 728),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 106,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 18, minute: 45, second: 15, millisecond: 269),
new TimeOnly(hour: 21, minute: 36, second: 39, millisecond: 912),
new TimeOnly(hour: 4, minute: 34, second: 29, millisecond: 718),
new TimeOnly(hour: 15, minute: 29, second: 31, millisecond: 129),
},
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 22, minute: 10, second: 1, millisecond: 641),
new TimeOnly(hour: 4, minute: 34, second: 0, millisecond: 457),
new TimeOnly(hour: 3, minute: 53, second: 43, millisecond: 98),
new TimeOnly(hour: 16, minute: 19, second: 2, millisecond: 180),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 115,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 27, second: 42, millisecond: 672),
new TimeOnly(hour: 2, minute: 26, second: 45, millisecond: 135),
new TimeOnly(hour: 22, minute: 35, second: 32, millisecond: 860),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 70,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 18, minute: 25, second: 37, millisecond: 468),
new TimeOnly(hour: 20, minute: 2, second: 23, millisecond: 558),
new TimeOnly(hour: 2, minute: 7, second: 5, millisecond: 566),
new TimeOnly(hour: 20, minute: 55, second: 28, millisecond: 631),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 122,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 16, minute: 20, second: 55, millisecond: 446),
new TimeOnly(hour: 21, minute: 26, second: 5, millisecond: 215),
new TimeOnly(hour: 9, minute: 40, second: 19, millisecond: 210),
new TimeOnly(hour: 0, minute: 54, second: 27, millisecond: 757),
},
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 9, minute: 19, second: 34, millisecond: 21),
new TimeOnly(hour: 7, minute: 3, second: 14, millisecond: 997),
new TimeOnly(hour: 18, minute: 28, second: 37, millisecond: 173),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 123,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 19, second: 50, millisecond: 337),
new TimeOnly(hour: 0, minute: 10, second: 32, millisecond: 279),
new TimeOnly(hour: 20, minute: 52, second: 5, millisecond: 32),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 71,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 17, minute: 52, second: 35, millisecond: 355),
new TimeOnly(hour: 15, minute: 29, second: 25, millisecond: 607),
new TimeOnly(hour: 14, minute: 54, second: 34, millisecond: 946),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 17, minute: 44, second: 13, millisecond: 595),
new TimeOnly(hour: 16, minute: 0, second: 6, millisecond: 461),
new TimeOnly(hour: 13, minute: 29, second: 23, millisecond: 233),
new TimeOnly(hour: 18, minute: 34, second: 35, millisecond: 498),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 125,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 22, minute: 41, second: 24, millisecond: 339),
new TimeOnly(hour: 2, minute: 45, second: 14, millisecond: 600),
new TimeOnly(hour: 9, minute: 38, second: 19, millisecond: 772),
new TimeOnly(hour: 22, minute: 58, second: 8, millisecond: 447),
},
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 3, minute: 48, second: 22, millisecond: 343),
new TimeOnly(hour: 12, minute: 51, second: 36, millisecond: 322),
new TimeOnly(hour: 7, minute: 29, second: 40, millisecond: 390),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 132,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 34, second: 53, millisecond: 199),
new TimeOnly(hour: 4, minute: 35, second: 25, millisecond: 937),
new TimeOnly(hour: 1, minute: 44, second: 42, millisecond: 435),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 76,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 2, minute: 15, second: 44, millisecond: 558),
new TimeOnly(hour: 17, minute: 7, second: 55, millisecond: 765),
new TimeOnly(hour: 14, minute: 28, second: 47, millisecond: 553),
new TimeOnly(hour: 3, minute: 10, second: 42, millisecond: 343),
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
                parametr1.Value = 10;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 106;
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
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[4],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 44;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 123;
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
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[1],_testData[29], false);
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
                parametr1.Value = 90;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 36;
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
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[21],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 25;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 48;
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
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[18],_testData[29], false);
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
                parametr1.Value = 8;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 59;
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
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[2], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[3], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[4], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[5], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[5],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[6],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[7],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[8],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[9],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[10],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[11],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[12],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[13],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[14],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[15],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[16],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[17],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[18],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[19],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[20],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[21],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[22],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[23],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[24],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[25],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[26],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[27],_testData[29], false);
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
                parametr1.Value = 46;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 19;
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
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[24],_testData[29], false);
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
                parametr1.Value = 56;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 115;
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 98;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 36;
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
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[21],_testData[29], false);
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
                parametr1.Value = 46;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 10;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
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
                parametr2.Value = 44;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[16], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[17], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[18], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[19], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[20], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[5],_testData[21], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[6],_testData[22], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[7],_testData[23], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[8],_testData[24], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[9],_testData[25], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[10],_testData[26], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[11],_testData[27], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[12],_testData[28], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[13],_testData[29], false);
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
                await ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 25, query1, 58, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[15],_testData[29], false);
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
                await ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 59, query1, 104, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[5],_testData[29], false);
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
                 ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 8, query1, 61, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[13],_testData[29], false);
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
                 ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 102, query1, 54, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems2[6],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[17],_testData[29], false);
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
                foreach(var batchResult in await ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 75, query1, 104, query2))
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
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[5],_testData[29], false);
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
                await ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 68, query1, 123, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[1],_testData[29], false);
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
                foreach(var batchResult in  ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 104, query1, 115, query2))
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
                 ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionDynQuerySelectModelBatch(connection, 122, query1, 98, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(firstItems1[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(secondItems2[7],_testData[29], false);
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
                foreach(var batchResult in await ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionSTSelectModelBatchAsync(connection, 48, 59))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[11], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[12], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[13], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[14], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[15], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[5],_testData[16], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[6],_testData[17], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[7],_testData[18], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[8],_testData[19], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[9],_testData[20], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[10],_testData[21], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[11],_testData[22], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[12],_testData[23], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[13],_testData[24], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[14],_testData[25], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[15],_testData[26], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[16],_testData[27], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[17],_testData[28], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[15], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[16], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[17], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[18], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[19], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[5],_testData[20], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[6],_testData[21], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[7],_testData[22], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[8],_testData[23], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[9],_testData[24], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[10],_testData[25], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[11],_testData[26], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[12],_testData[27], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[13],_testData[28], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[14],_testData[29], false);
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
                foreach(var batchResult in  ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionSTSelectModelBatch(connection, 123, 106))
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
                        Assert.That(models, Has.Count.EqualTo(5));

                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[25], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[26], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[27], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[28], false);
                        TimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[29], false);
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
                ((ITimeOnlyArraytime_without_time_zoneArray)this).SetDbConnectionSelectModelParametrs(cmd, 58);
                var models = await ((ITimeOnlyArraytime_without_time_zoneArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(16));
TimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[14], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[15], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[16], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[17], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[18], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[5],_testData[19], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[6],_testData[20], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[7],_testData[21], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[8],_testData[22], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[9],_testData[23], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[10],_testData[24], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[11],_testData[25], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[12],_testData[26], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[13],_testData[27], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[14],_testData[28], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[15],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ITimeOnlyArraytime_without_time_zoneArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((ITimeOnlyArraytime_without_time_zoneArray)this).SetDbConnectionSelectModelParametrs(cmd, 34);
                var models =  ((ITimeOnlyArraytime_without_time_zoneArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(23));
TimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[7], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[8], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[9], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[10], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[11], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[5],_testData[12], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[6],_testData[13], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[7],_testData[14], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[8],_testData[15], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[9],_testData[16], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[10],_testData[17], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[11],_testData[18], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[12],_testData[19], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[13],_testData[20], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[14],_testData[21], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[15],_testData[22], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[16],_testData[23], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[17],_testData[24], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[18],_testData[25], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[19],_testData[26], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[20],_testData[27], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[21],_testData[28], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[22],_testData[29], false);
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
FROM public.binary_timeonlytime_without_time_zonearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyArraytime_without_time_zoneArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(TimeOnlytime_without_time_zoneArray1MIWA),
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
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<TimeOnlytime_without_time_zoneArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeOnlytime_without_time_zoneArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ITimeOnlyArraytime_without_time_zoneArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_timeonlytime_without_time_zonearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((ITimeOnlyArraytime_without_time_zoneArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeOnlytime_without_time_zoneArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<TimeOnlytime_without_time_zoneArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeOnlytime_without_time_zoneArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ITimeOnlyArraytime_without_time_zoneArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_timeonlytime_without_time_zonearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((ITimeOnlyArraytime_without_time_zoneArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeOnlytime_without_time_zoneArray1MIWA.AssertModel(actual, expect, false);
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

        [Test, Order(2)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<TimeOnlytime_without_time_zoneArray1MI>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((ITimeOnlyArraytime_without_time_zoneArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((ITimeOnlyArraytime_without_time_zoneArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeOnlytime_without_time_zoneArray1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<TimeOnlytime_without_time_zoneArray1MI>(2);
                for (int i = 12; i < 30; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((ITimeOnlyArraytime_without_time_zoneArray)this).ImportModelInner(connection, importCollection);
                var models = ((ITimeOnlyArraytime_without_time_zoneArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeOnlytime_without_time_zoneArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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

        [Test, Order(5)]
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

        [Test, Order(6)]
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

        [Test, Order(6)]
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
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneArray1MIWA)],
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
        private void DynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task DynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((ITimeOnlyArraytime_without_time_zoneArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_timeonlytime_without_time_zonearray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    TimeOnlytime_without_time_zoneArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(6)]
        public  void DynQueryExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((ITimeOnlyArraytime_without_time_zoneArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_timeonlytime_without_time_zonearray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    TimeOnlytime_without_time_zoneArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

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

        [Test, Order(6)]
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

        [Test, Order(6)]
        public  void ExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((ITimeOnlyArraytime_without_time_zoneArray)this).ExportModelInner(connection).ToList();
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

