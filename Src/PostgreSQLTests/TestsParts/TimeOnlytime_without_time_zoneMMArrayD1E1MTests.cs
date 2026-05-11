

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
    internal partial interface ITimeOnlyMArraytime_without_time_zoneMMArrayD1
    {
    }
    
    internal partial class TimeOnlyMArraytime_without_time_zoneMMArrayD1 : ITimeOnlyMArraytime_without_time_zoneMMArrayD1
    {


#region TestData

        private readonly TimeOnlytime_without_time_zoneMMArrayD1E1M[] _testData = new TimeOnlytime_without_time_zoneMMArrayD1E1M[]
        {
            new TimeOnlytime_without_time_zoneMMArrayD1E1M
{
    Id = 5,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 12, minute: 26, second: 9, millisecond: 311),
new TimeOnly(hour: 6, minute: 19, second: 29, millisecond: 195),
new TimeOnly(hour: 18, minute: 41, second: 19, millisecond: 40),
new TimeOnly(hour: 13, minute: 51, second: 42, millisecond: 405),
},
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 15, minute: 26, second: 45, millisecond: 537),
new TimeOnly(hour: 15, minute: 36, second: 44, millisecond: 333),
new TimeOnly(hour: 18, minute: 40, second: 30, millisecond: 475),
},
},
            new TimeOnlytime_without_time_zoneMMArrayD1E1M
{
    Id = 13,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 3, minute: 2, second: 55, millisecond: 878),
new TimeOnly(hour: 0, minute: 16, second: 56, millisecond: 67),
new TimeOnly(hour: 14, minute: 23, second: 18, millisecond: 707),
new TimeOnly(hour: 8, minute: 49, second: 56, millisecond: 663),
},
    ModelInner = new TimeOnlytime_without_time_zoneMMArrayD1E1MI
{
    Id = 4,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 17, minute: 57, second: 39, millisecond: 268),
new TimeOnly(hour: 16, minute: 39, second: 1, millisecond: 923),
new TimeOnly(hour: 14, minute: 49, second: 15, millisecond: 894),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 18, minute: 32, second: 48, millisecond: 618),
new TimeOnly(hour: 11, minute: 29, second: 15, millisecond: 600),
new TimeOnly(hour: 8, minute: 26, second: 26, millisecond: 174),
new TimeOnly(hour: 11, minute: 9, second: 9, millisecond: 700),
},
},
            new TimeOnlytime_without_time_zoneMMArrayD1E1M
{
    Id = 18,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 0, minute: 3, second: 28, millisecond: 498),
new TimeOnly(hour: 22, minute: 43, second: 34, millisecond: 798),
new TimeOnly(hour: 10, minute: 2, second: 32, millisecond: 841),
},
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 11, minute: 20, second: 31, millisecond: 691),
new TimeOnly(hour: 17, minute: 50, second: 15, millisecond: 718),
new TimeOnly(hour: 20, minute: 0, second: 9, millisecond: 613),
},
},
            new TimeOnlytime_without_time_zoneMMArrayD1E1M
{
    Id = 25,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 17, minute: 16, second: 49, millisecond: 35),
new TimeOnly(hour: 14, minute: 51, second: 13, millisecond: 345),
new TimeOnly(hour: 5, minute: 43, second: 25, millisecond: 136),
new TimeOnly(hour: 14, minute: 40, second: 48, millisecond: 965),
},
    ModelInner = new TimeOnlytime_without_time_zoneMMArrayD1E1MI
{
    Id = 11,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 10, minute: 40, second: 19, millisecond: 979),
new TimeOnly(hour: 17, minute: 10, second: 2, millisecond: 608),
new TimeOnly(hour: 14, minute: 55, second: 41, millisecond: 214),
new TimeOnly(hour: 0, minute: 10, second: 58, millisecond: 287),
},
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 6, minute: 40, second: 13, millisecond: 358),
new TimeOnly(hour: 1, minute: 46, second: 27, millisecond: 974),
new TimeOnly(hour: 10, minute: 34, second: 54, millisecond: 951),
new TimeOnly(hour: 0, minute: 37, second: 41, millisecond: 130),
},
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneMMArrayD1E1M
{
    Id = 31,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 17, minute: 34, second: 24, millisecond: 252),
new TimeOnly(hour: 17, minute: 8, second: 54, millisecond: 351),
new TimeOnly(hour: 7, minute: 25, second: 55, millisecond: 297),
},
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 13, minute: 53, second: 50, millisecond: 251),
new TimeOnly(hour: 7, minute: 1, second: 31, millisecond: 182),
new TimeOnly(hour: 10, minute: 8, second: 34, millisecond: 27),
},
},
            new TimeOnlytime_without_time_zoneMMArrayD1E1M
{
    Id = 38,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 8, minute: 10, second: 5, millisecond: 127),
new TimeOnly(hour: 17, minute: 44, second: 24, millisecond: 498),
new TimeOnly(hour: 11, minute: 34, second: 48, millisecond: 668),
},
    ModelInner = new TimeOnlytime_without_time_zoneMMArrayD1E1MI
{
    Id = 20,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 10, minute: 7, second: 4, millisecond: 817),
new TimeOnly(hour: 5, minute: 8, second: 56, millisecond: 398),
new TimeOnly(hour: 17, minute: 38, second: 12, millisecond: 595),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneMMArrayD1E1M
{
    Id = 41,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 6, minute: 29, second: 55, millisecond: 690),
new TimeOnly(hour: 6, minute: 30, second: 10, millisecond: 208),
new TimeOnly(hour: 3, minute: 24, second: 39, millisecond: 935),
new TimeOnly(hour: 12, minute: 28, second: 34, millisecond: 154),
},
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 21, minute: 6, second: 49, millisecond: 57),
new TimeOnly(hour: 19, minute: 43, second: 54, millisecond: 114),
new TimeOnly(hour: 13, minute: 32, second: 36, millisecond: 50),
},
},
            new TimeOnlytime_without_time_zoneMMArrayD1E1M
{
    Id = 42,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 53, second: 52, millisecond: 485),
new TimeOnly(hour: 10, minute: 10, second: 2, millisecond: 729),
new TimeOnly(hour: 21, minute: 32, second: 48, millisecond: 916),
},
    ModelInner = new TimeOnlytime_without_time_zoneMMArrayD1E1MI
{
    Id = 29,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 10, second: 35, millisecond: 511),
new TimeOnly(hour: 2, minute: 33, second: 34, millisecond: 826),
new TimeOnly(hour: 16, minute: 5, second: 9, millisecond: 479),
},
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 3, minute: 8, second: 11, millisecond: 866),
new TimeOnly(hour: 3, minute: 46, second: 46, millisecond: 659),
new TimeOnly(hour: 19, minute: 34, second: 40, millisecond: 607),
new TimeOnly(hour: 3, minute: 23, second: 33, millisecond: 754),
},
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneMMArrayD1E1M
{
    Id = 45,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 11, minute: 45, second: 16, millisecond: 749),
new TimeOnly(hour: 10, minute: 3, second: 54, millisecond: 416),
new TimeOnly(hour: 19, minute: 24, second: 2, millisecond: 479),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneMMArrayD1E1M
{
    Id = 46,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 14, minute: 29, second: 57, millisecond: 54),
new TimeOnly(hour: 10, minute: 4, second: 42, millisecond: 992),
new TimeOnly(hour: 6, minute: 6, second: 53, millisecond: 924),
new TimeOnly(hour: 3, minute: 12, second: 17, millisecond: 246),
},
    ModelInner = new TimeOnlytime_without_time_zoneMMArrayD1E1MI
{
    Id = 35,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 11, minute: 27, second: 33, millisecond: 321),
new TimeOnly(hour: 20, minute: 2, second: 30, millisecond: 658),
new TimeOnly(hour: 8, minute: 23, second: 1, millisecond: 869),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 13, second: 0, millisecond: 243),
new TimeOnly(hour: 0, minute: 4, second: 27, millisecond: 958),
new TimeOnly(hour: 18, minute: 15, second: 42, millisecond: 424),
},
},
            new TimeOnlytime_without_time_zoneMMArrayD1E1M
{
    Id = 48,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 15, second: 25, millisecond: 771),
new TimeOnly(hour: 5, minute: 43, second: 15, millisecond: 770),
new TimeOnly(hour: 6, minute: 9, second: 16, millisecond: 985),
},
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 17, minute: 36, second: 45, millisecond: 70),
new TimeOnly(hour: 20, minute: 24, second: 43, millisecond: 547),
new TimeOnly(hour: 15, minute: 13, second: 31, millisecond: 147),
},
},
            new TimeOnlytime_without_time_zoneMMArrayD1E1M
{
    Id = 50,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 13, minute: 16, second: 7, millisecond: 28),
new TimeOnly(hour: 2, minute: 8, second: 22, millisecond: 928),
new TimeOnly(hour: 4, minute: 38, second: 50, millisecond: 25),
},
    ModelInner = new TimeOnlytime_without_time_zoneMMArrayD1E1MI
{
    Id = 41,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 2, minute: 54, second: 6, millisecond: 947),
new TimeOnly(hour: 21, minute: 10, second: 54, millisecond: 621),
new TimeOnly(hour: 8, minute: 51, second: 13, millisecond: 203),
new TimeOnly(hour: 11, minute: 43, second: 45, millisecond: 1),
},
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 20, minute: 54, second: 43, millisecond: 320),
new TimeOnly(hour: 15, minute: 43, second: 18, millisecond: 943),
new TimeOnly(hour: 18, minute: 27, second: 24, millisecond: 373),
},
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneMMArrayD1E1M
{
    Id = 51,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 1, minute: 7, second: 20, millisecond: 690),
new TimeOnly(hour: 22, minute: 3, second: 40, millisecond: 445),
new TimeOnly(hour: 0, minute: 5, second: 20, millisecond: 955),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneMMArrayD1E1M
{
    Id = 59,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 18, minute: 16, second: 12, millisecond: 650),
new TimeOnly(hour: 6, minute: 41, second: 48, millisecond: 872),
new TimeOnly(hour: 7, minute: 30, second: 13, millisecond: 580),
},
    ModelInner = new TimeOnlytime_without_time_zoneMMArrayD1E1MI
{
    Id = 50,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 21, minute: 9, second: 16, millisecond: 165),
new TimeOnly(hour: 7, minute: 55, second: 33, millisecond: 192),
new TimeOnly(hour: 15, minute: 5, second: 12, millisecond: 73),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 15, minute: 31, second: 9, millisecond: 482),
new TimeOnly(hour: 19, minute: 29, second: 29, millisecond: 773),
new TimeOnly(hour: 4, minute: 4, second: 27, millisecond: 417),
},
},
            new TimeOnlytime_without_time_zoneMMArrayD1E1M
{
    Id = 61,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 20, minute: 31, second: 55, millisecond: 801),
new TimeOnly(hour: 6, minute: 16, second: 52, millisecond: 976),
new TimeOnly(hour: 14, minute: 54, second: 27, millisecond: 758),
new TimeOnly(hour: 18, minute: 48, second: 25, millisecond: 91),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneMMArrayD1E1M
{
    Id = 70,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 13, minute: 46, second: 43, millisecond: 425),
new TimeOnly(hour: 8, minute: 13, second: 11, millisecond: 171),
new TimeOnly(hour: 5, minute: 48, second: 51, millisecond: 403),
},
    ModelInner = new TimeOnlytime_without_time_zoneMMArrayD1E1MI
{
    Id = 57,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 3, minute: 22, second: 12, millisecond: 742),
new TimeOnly(hour: 18, minute: 15, second: 42, millisecond: 370),
new TimeOnly(hour: 17, minute: 46, second: 27, millisecond: 361),
},
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 0, minute: 51, second: 27, millisecond: 142),
new TimeOnly(hour: 1, minute: 21, second: 33, millisecond: 315),
new TimeOnly(hour: 20, minute: 46, second: 15, millisecond: 938),
},
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneMMArrayD1E1M
{
    Id = 77,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 21, minute: 28, second: 16, millisecond: 363),
new TimeOnly(hour: 14, minute: 44, second: 8, millisecond: 131),
new TimeOnly(hour: 1, minute: 32, second: 24, millisecond: 897),
new TimeOnly(hour: 0, minute: 51, second: 27, millisecond: 306),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneMMArrayD1E1M
{
    Id = 79,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 11, minute: 49, second: 36, millisecond: 810),
new TimeOnly(hour: 13, minute: 57, second: 29, millisecond: 196),
new TimeOnly(hour: 5, minute: 45, second: 33, millisecond: 76),
},
    ModelInner = new TimeOnlytime_without_time_zoneMMArrayD1E1MI
{
    Id = 62,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 13, minute: 41, second: 13, millisecond: 727),
new TimeOnly(hour: 15, minute: 40, second: 12, millisecond: 467),
new TimeOnly(hour: 6, minute: 3, second: 5, millisecond: 250),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneMMArrayD1E1M
{
    Id = 83,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 4, minute: 16, second: 9, millisecond: 361),
new TimeOnly(hour: 5, minute: 39, second: 36, millisecond: 85),
new TimeOnly(hour: 17, minute: 28, second: 27, millisecond: 428),
new TimeOnly(hour: 20, minute: 29, second: 47, millisecond: 549),
},
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 8, minute: 43, second: 40, millisecond: 267),
new TimeOnly(hour: 21, minute: 16, second: 7, millisecond: 605),
new TimeOnly(hour: 16, minute: 37, second: 5, millisecond: 773),
},
},
            new TimeOnlytime_without_time_zoneMMArrayD1E1M
{
    Id = 87,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 17, minute: 29, second: 20, millisecond: 217),
new TimeOnly(hour: 20, minute: 21, second: 1, millisecond: 74),
new TimeOnly(hour: 3, minute: 27, second: 25, millisecond: 818),
},
    ModelInner = new TimeOnlytime_without_time_zoneMMArrayD1E1MI
{
    Id = 70,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 16, minute: 24, second: 36, millisecond: 88),
new TimeOnly(hour: 4, minute: 22, second: 43, millisecond: 217),
new TimeOnly(hour: 8, minute: 4, second: 10, millisecond: 437),
new TimeOnly(hour: 18, minute: 8, second: 30, millisecond: 424),
},
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 11, minute: 3, second: 12, millisecond: 300),
new TimeOnly(hour: 6, minute: 13, second: 34, millisecond: 73),
new TimeOnly(hour: 5, minute: 8, second: 32, millisecond: 185),
new TimeOnly(hour: 1, minute: 25, second: 33, millisecond: 577),
},
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneMMArrayD1E1M
{
    Id = 93,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 7, minute: 5, second: 1, millisecond: 635),
new TimeOnly(hour: 0, minute: 43, second: 44, millisecond: 224),
new TimeOnly(hour: 4, minute: 18, second: 48, millisecond: 506),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneMMArrayD1E1M
{
    Id = 100,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 15, minute: 44, second: 26, millisecond: 50),
new TimeOnly(hour: 0, minute: 44, second: 44, millisecond: 143),
new TimeOnly(hour: 12, minute: 8, second: 13, millisecond: 128),
},
    ModelInner = new TimeOnlytime_without_time_zoneMMArrayD1E1MI
{
    Id = 79,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 19, minute: 9, second: 26, millisecond: 966),
new TimeOnly(hour: 2, minute: 2, second: 23, millisecond: 956),
new TimeOnly(hour: 17, minute: 48, second: 28, millisecond: 410),
new TimeOnly(hour: 8, minute: 8, second: 41, millisecond: 33),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 9, minute: 13, second: 32, millisecond: 439),
new TimeOnly(hour: 13, minute: 36, second: 27, millisecond: 465),
new TimeOnly(hour: 10, minute: 8, second: 1, millisecond: 219),
new TimeOnly(hour: 5, minute: 22, second: 35, millisecond: 5),
},
},
            new TimeOnlytime_without_time_zoneMMArrayD1E1M
{
    Id = 109,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 3, minute: 7, second: 22, millisecond: 382),
new TimeOnly(hour: 21, minute: 17, second: 44, millisecond: 808),
new TimeOnly(hour: 15, minute: 48, second: 39, millisecond: 679),
new TimeOnly(hour: 6, minute: 1, second: 48, millisecond: 465),
},
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 8, minute: 35, second: 29, millisecond: 70),
new TimeOnly(hour: 18, minute: 4, second: 22, millisecond: 934),
new TimeOnly(hour: 3, minute: 15, second: 13, millisecond: 232),
},
},
            new TimeOnlytime_without_time_zoneMMArrayD1E1M
{
    Id = 110,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 5, minute: 25, second: 45, millisecond: 120),
new TimeOnly(hour: 15, minute: 9, second: 40, millisecond: 240),
new TimeOnly(hour: 22, minute: 39, second: 44, millisecond: 92),
new TimeOnly(hour: 11, minute: 37, second: 52, millisecond: 395),
},
    ModelInner = new TimeOnlytime_without_time_zoneMMArrayD1E1MI
{
    Id = 83,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 6, minute: 23, second: 39, millisecond: 428),
new TimeOnly(hour: 2, minute: 10, second: 21, millisecond: 264),
new TimeOnly(hour: 22, minute: 24, second: 35, millisecond: 376),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneMMArrayD1E1M
{
    Id = 113,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 3, minute: 23, second: 12, millisecond: 105),
new TimeOnly(hour: 20, minute: 19, second: 24, millisecond: 609),
new TimeOnly(hour: 4, minute: 12, second: 0, millisecond: 182),
new TimeOnly(hour: 8, minute: 16, second: 32, millisecond: 360),
},
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 21, minute: 14, second: 43, millisecond: 578),
new TimeOnly(hour: 15, minute: 53, second: 18, millisecond: 709),
new TimeOnly(hour: 4, minute: 44, second: 46, millisecond: 147),
},
},
            new TimeOnlytime_without_time_zoneMMArrayD1E1M
{
    Id = 118,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 40, second: 0, millisecond: 781),
new TimeOnly(hour: 8, minute: 32, second: 53, millisecond: 38),
new TimeOnly(hour: 8, minute: 32, second: 21, millisecond: 274),
},
    ModelInner = new TimeOnlytime_without_time_zoneMMArrayD1E1MI
{
    Id = 89,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 1, minute: 50, second: 17, millisecond: 628),
new TimeOnly(hour: 21, minute: 41, second: 10, millisecond: 189),
new TimeOnly(hour: 20, minute: 55, second: 29, millisecond: 60),
new TimeOnly(hour: 4, minute: 3, second: 32, millisecond: 601),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 11, minute: 3, second: 52, millisecond: 833),
new TimeOnly(hour: 8, minute: 57, second: 50, millisecond: 345),
new TimeOnly(hour: 4, minute: 31, second: 36, millisecond: 611),
new TimeOnly(hour: 12, minute: 50, second: 18, millisecond: 105),
},
},
            new TimeOnlytime_without_time_zoneMMArrayD1E1M
{
    Id = 119,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 1, minute: 46, second: 7, millisecond: 68),
new TimeOnly(hour: 18, minute: 13, second: 42, millisecond: 922),
new TimeOnly(hour: 5, minute: 9, second: 22, millisecond: 140),
new TimeOnly(hour: 4, minute: 54, second: 52, millisecond: 826),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneMMArrayD1E1M
{
    Id = 128,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 2, minute: 54, second: 34, millisecond: 873),
new TimeOnly(hour: 16, minute: 47, second: 45, millisecond: 963),
new TimeOnly(hour: 18, minute: 17, second: 46, millisecond: 680),
new TimeOnly(hour: 21, minute: 22, second: 38, millisecond: 537),
},
    ModelInner = new TimeOnlytime_without_time_zoneMMArrayD1E1MI
{
    Id = 90,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 21, minute: 7, second: 49, millisecond: 297),
new TimeOnly(hour: 6, minute: 11, second: 39, millisecond: 231),
new TimeOnly(hour: 17, minute: 17, second: 10, millisecond: 937),
new TimeOnly(hour: 9, minute: 16, second: 3, millisecond: 672),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneMMArrayD1E1M
{
    Id = 137,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 12, minute: 1, second: 2, millisecond: 563),
new TimeOnly(hour: 8, minute: 24, second: 31, millisecond: 683),
new TimeOnly(hour: 7, minute: 45, second: 9, millisecond: 759),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneMMArrayD1E1M
{
    Id = 138,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 18, minute: 32, second: 8, millisecond: 615),
new TimeOnly(hour: 3, minute: 24, second: 27, millisecond: 111),
new TimeOnly(hour: 15, minute: 42, second: 2, millisecond: 794),
new TimeOnly(hour: 8, minute: 20, second: 5, millisecond: 740),
},
    ModelInner = new TimeOnlytime_without_time_zoneMMArrayD1E1MI
{
    Id = 93,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 6, minute: 21, second: 34, millisecond: 829),
new TimeOnly(hour: 17, minute: 27, second: 20, millisecond: 296),
new TimeOnly(hour: 9, minute: 13, second: 18, millisecond: 21),
},
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 5, minute: 58, second: 17, millisecond: 195),
new TimeOnly(hour: 22, minute: 19, second: 1, millisecond: 530),
new TimeOnly(hour: 8, minute: 36, second: 7, millisecond: 140),
},
},
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 10, minute: 0, second: 46, millisecond: 845),
new TimeOnly(hour: 7, minute: 37, second: 29, millisecond: 233),
new TimeOnly(hour: 14, minute: 25, second: 0, millisecond: 463),
},
},
            new TimeOnlytime_without_time_zoneMMArrayD1E1M
{
    Id = 140,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 9, minute: 44, second: 32, millisecond: 484),
new TimeOnly(hour: 22, minute: 57, second: 17, millisecond: 348),
new TimeOnly(hour: 3, minute: 24, second: 44, millisecond: 204),
new TimeOnly(hour: 0, minute: 31, second: 27, millisecond: 197),
},
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 13, minute: 49, second: 11, millisecond: 980),
new TimeOnly(hour: 10, minute: 36, second: 16, millisecond: 785),
new TimeOnly(hour: 17, minute: 17, second: 21, millisecond: 0),
},
},
            new TimeOnlytime_without_time_zoneMMArrayD1E1M
{
    Id = 148,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 19, minute: 1, second: 25, millisecond: 316),
new TimeOnly(hour: 22, minute: 35, second: 3, millisecond: 7),
new TimeOnly(hour: 12, minute: 20, second: 20, millisecond: 29),
new TimeOnly(hour: 3, minute: 30, second: 4, millisecond: 451),
},
    ModelInner = new TimeOnlytime_without_time_zoneMMArrayD1E1MI
{
    Id = 95,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 7, minute: 20, second: 49, millisecond: 371),
new TimeOnly(hour: 17, minute: 0, second: 6, millisecond: 204),
new TimeOnly(hour: 13, minute: 27, second: 25, millisecond: 121),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 19, minute: 16, second: 30, millisecond: 277),
new TimeOnly(hour: 3, minute: 30, second: 19, millisecond: 660),
new TimeOnly(hour: 13, minute: 2, second: 26, millisecond: 665),
},
},
            new TimeOnlytime_without_time_zoneMMArrayD1E1M
{
    Id = 153,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 14, minute: 6, second: 31, millisecond: 657),
new TimeOnly(hour: 0, minute: 49, second: 27, millisecond: 212),
new TimeOnly(hour: 15, minute: 37, second: 50, millisecond: 463),
new TimeOnly(hour: 12, minute: 47, second: 56, millisecond: 359),
},
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 21, minute: 33, second: 16, millisecond: 956),
new TimeOnly(hour: 5, minute: 5, second: 58, millisecond: 812),
new TimeOnly(hour: 8, minute: 37, second: 37, millisecond: 874),
new TimeOnly(hour: 13, minute: 37, second: 31, millisecond: 147),
},
},
            new TimeOnlytime_without_time_zoneMMArrayD1E1M
{
    Id = 157,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 20, minute: 56, second: 49, millisecond: 775),
new TimeOnly(hour: 5, minute: 30, second: 33, millisecond: 374),
new TimeOnly(hour: 1, minute: 17, second: 36, millisecond: 315),
new TimeOnly(hour: 3, minute: 52, second: 45, millisecond: 968),
},
    ModelInner = new TimeOnlytime_without_time_zoneMMArrayD1E1MI
{
    Id = 96,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 10, minute: 34, second: 12, millisecond: 213),
new TimeOnly(hour: 20, minute: 27, second: 34, millisecond: 402),
new TimeOnly(hour: 14, minute: 49, second: 34, millisecond: 548),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneMMArrayD1E1M
{
    Id = 160,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 4, minute: 19, second: 19, millisecond: 810),
new TimeOnly(hour: 14, minute: 13, second: 53, millisecond: 506),
new TimeOnly(hour: 0, minute: 38, second: 41, millisecond: 260),
},
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 20, minute: 38, second: 41, millisecond: 142),
new TimeOnly(hour: 18, minute: 53, second: 2, millisecond: 963),
new TimeOnly(hour: 18, minute: 1, second: 10, millisecond: 176),
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timeonlytime_without_time_zonemmarrayd1e1mi(
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
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD1)),
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
INSERT INTO public.timeonlytime_without_time_zonemmarrayd1e1mi(
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
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD1)),
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

                changedRows =  ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timeonlytime_without_time_zonemmarrayd1e1m(
	id,
    value,
    nullablevalue,
    timeonlytime_without_time_zonemmarrayd1e1mi_id
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
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD1)), 
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
                methodParametrName: "timeonlytime_without_time_zonemmarrayd1e1mi_id", 
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
                changedRows =  ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timeonlytime_without_time_zonemmarrayd1e1m(
	id,
    value,
    nullablevalue,
    timeonlytime_without_time_zonemmarrayd1e1mi_id
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
    timeonlytime_without_time_zonemmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD1)),
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
INSERT INTO public.timeonlytime_without_time_zonemmarrayd1e1m(
	id,
    value,
    nullablevalue,
    timeonlytime_without_time_zonemmarrayd1e1mi_id
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
    timeonlytime_without_time_zonemmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD1)),
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
                methodParametrName: "timeonlytime_without_time_zonemmarrayd1e1mi_id", 
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
                List<TimeOnlytime_without_time_zoneMMArrayD1E1M> models = null;

                models =  ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[0],_testData[4], true);
                models =  ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[0],_testData[5], true);
                models =  ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[0],_testData[6], true);
                models =  ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<TimeOnlytime_without_time_zoneMMArrayD1E1M> models = null;

                models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[0],_testData[8], true);
                models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[0],_testData[9], true);
                models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[0],_testData[10], true);
                models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[0],_testData[11], true);
                models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[0],_testData[12], true);
                models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[0],_testData[13], true);
                models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[0],_testData[14], true);
                models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[0],_testData[15], true);
                models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[0],_testData[16], true);
                models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[0],_testData[17], true);
                models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[0],_testData[18], true);
                models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[0],_testData[19], true);
                models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[0],_testData[20], true);
                models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[0],_testData[21], true);
                models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[0],_testData[22], true);
                models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[0],_testData[23], true);
                models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[0],_testData[24], true);
                models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[0],_testData[25], true);
                models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[0],_testData[26], true);
                models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[0],_testData[27], true);
                models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[0],_testData[28], true);
                models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[0],_testData[29], true);
                models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[0],_testData[30], true);
                models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[0],_testData[31], true);
                models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[0],_testData[32], true);
                models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[0],_testData[33], true);
                models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeOnlytime_without_time_zoneMMArrayD1E1M), typeof(FlatTimeOnlytime_without_time_zoneMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD1)),
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
FROM public.timeonlytime_without_time_zonemmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD1E1M>();
                var models2 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD1E1M>();
                await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.timeonlytime_without_time_zonemmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD1E1M>();
                var models2 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD1E1M>();
                ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeOnlytime_without_time_zoneMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD1)),
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
FROM public.timeonlytime_without_time_zonemmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.timeonlytime_without_time_zonemmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.timeonlytime_without_time_zonemmarrayd1e1m m
LEFT JOIN public.timeonlytime_without_time_zonemmarrayd1e1mi mi ON mi.id = m.timeonlytime_without_time_zonemmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD1)),
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
                var models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeOnlytime_without_time_zoneMMArrayD1E1M), typeof(FlatTimeOnlytime_without_time_zoneMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD1)),
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
FROM public.timeonlytime_without_time_zonemmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD1E1M>();
                var models2 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD1E1M>();
                await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.timeonlytime_without_time_zonemmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD1E1M>();
                var models2 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD1E1M>();
                ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeOnlytime_without_time_zoneMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD1)),
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
FROM public.timeonlytime_without_time_zonemmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.timeonlytime_without_time_zonemmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.timeonlytime_without_time_zonemmarrayd1e1m m
LEFT JOIN public.timeonlytime_without_time_zonemmarrayd1e1mi mi ON mi.id = m.timeonlytime_without_time_zonemmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD1)),
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
                var models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeOnlytime_without_time_zoneMMArrayD1E1M), typeof(FlatTimeOnlytime_without_time_zoneMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD1)),
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
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD1)),
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
FROM public.timeonlytime_without_time_zonemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD1E1M>();
                var models2 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD1E1M>();
                await((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 109;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 31;
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
FROM public.timeonlytime_without_time_zonemmarrayd1e1m m
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
FROM public.timeonlytime_without_time_zonemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD1E1M>();
                var firstItems2 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD1E1M>();
                var secondItems1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD1E1M>();
                var secondItems2 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD1E1M>();
                await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[29],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 109;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 79;
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
FROM public.timeonlytime_without_time_zonemmarrayd1e1m m
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
FROM public.timeonlytime_without_time_zonemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD1E1M>();
                var firstItems2 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD1E1M>();
                var secondItems1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD1E1M>();
                await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[16],_testData[34], false);
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
FROM public.timeonlytime_without_time_zonemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD1E1M>();
                var models2 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD1E1M>();
                ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 59;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 93;
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
FROM public.timeonlytime_without_time_zonemmarrayd1e1m m
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
FROM public.timeonlytime_without_time_zonemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD1E1M>();
                var firstItems2 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD1E1M>();
                var secondItems1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD1E1M>();
                var secondItems2 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD1E1M>();
                 ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[13],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 100;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 50;
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
FROM public.timeonlytime_without_time_zonemmarrayd1e1m m
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
FROM public.timeonlytime_without_time_zonemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD1E1M>();
                var firstItems2 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD1E1M>();
                var secondItems1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD1E1M>();
                 ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[22],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeOnlytime_without_time_zoneMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD1)),
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
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD1)),
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
FROM public.timeonlytime_without_time_zonemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 45;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 41;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.timeonlytime_without_time_zonemmarrayd1e1m m
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
FROM public.timeonlytime_without_time_zonemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[0],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[1],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[2],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[3],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[4],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[5],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[6],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[7],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[8],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[9],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[10],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[11],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[12],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[13],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[14],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[15],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[16],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[17],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[18],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[19],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[20],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[21],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[22],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[23],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[24],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[0],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[1],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[2],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[3],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[4],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[5],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[6],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[7],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[8],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[9],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[10],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[11],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[12],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[13],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[14],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[15],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[16],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[17],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[18],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[19],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[20],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[21],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[22],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[23],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[24],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[25],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[26],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[27],_testData[34], false);
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
                parametr1.Value = 18;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 93;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.timeonlytime_without_time_zonemmarrayd1e1m m
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
FROM public.timeonlytime_without_time_zonemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD1E1M>();
                var secondItems1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD1E1M>();
                var secondItems2 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD1E1M>();
                await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[13],_testData[34], false);
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
FROM public.timeonlytime_without_time_zonemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 140;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 51;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.timeonlytime_without_time_zonemmarrayd1e1m m
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
FROM public.timeonlytime_without_time_zonemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[0],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[1],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[2],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[0],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[1],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[2],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[3],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[4],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[5],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[6],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[7],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[8],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[9],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[10],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[11],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[12],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[13],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[14],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[15],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[16],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[17],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[18],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[19],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[20],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[21],_testData[34], false);
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
                parametr1.Value = 45;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 25;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.timeonlytime_without_time_zonemmarrayd1e1m m
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
FROM public.timeonlytime_without_time_zonemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD1E1M>();
                var secondItems1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD1E1M>();
                var secondItems2 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD1E1M>();
                 ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.timeonlytime_without_time_zonemmarrayd1e1m m
LEFT JOIN public.timeonlytime_without_time_zonemmarrayd1e1mi mi ON mi.id = m.timeonlytime_without_time_zonemmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD1)),
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
                var models = await((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 42;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 42;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[0],_testData[8], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[1],_testData[9], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[2],_testData[10], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[3],_testData[11], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[4],_testData[12], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[5],_testData[13], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[6],_testData[14], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[7],_testData[15], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[8],_testData[16], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[9],_testData[17], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[10],_testData[18], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[11],_testData[19], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[12],_testData[20], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[13],_testData[21], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[14],_testData[22], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[15],_testData[23], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[16],_testData[24], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[17],_testData[25], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[18],_testData[26], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[19],_testData[27], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[20],_testData[28], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[21],_testData[29], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[22],_testData[30], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[23],_testData[31], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[24],_testData[32], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[25],_testData[33], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[0],_testData[8], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[1],_testData[9], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[2],_testData[10], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[3],_testData[11], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[4],_testData[12], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[5],_testData[13], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[6],_testData[14], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[7],_testData[15], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[8],_testData[16], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[9],_testData[17], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[10],_testData[18], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[11],_testData[19], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[12],_testData[20], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[13],_testData[21], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[14],_testData[22], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[15],_testData[23], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[16],_testData[24], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[17],_testData[25], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[18],_testData[26], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[19],_testData[27], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[20],_testData[28], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[21],_testData[29], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[22],_testData[30], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[23],_testData[31], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[24],_testData[32], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[25],_testData[33], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[26],_testData[34], false);
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
                var models = ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 25;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 46;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[0],_testData[4], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[1],_testData[5], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[2],_testData[6], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[3],_testData[7], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[4],_testData[8], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[5],_testData[9], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[6],_testData[10], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[7],_testData[11], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[8],_testData[12], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[9],_testData[13], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[10],_testData[14], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[11],_testData[15], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[12],_testData[16], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[13],_testData[17], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[14],_testData[18], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[15],_testData[19], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[16],_testData[20], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[17],_testData[21], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[18],_testData[22], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[19],_testData[23], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[20],_testData[24], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[21],_testData[25], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[22],_testData[26], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[23],_testData[27], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[24],_testData[28], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[25],_testData[29], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[26],_testData[30], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[27],_testData[31], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[28],_testData[32], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[29],_testData[33], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[0],_testData[10], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[1],_testData[11], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[2],_testData[12], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[3],_testData[13], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[4],_testData[14], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[5],_testData[15], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[6],_testData[16], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[7],_testData[17], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[8],_testData[18], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[9],_testData[19], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[10],_testData[20], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[11],_testData[21], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[12],_testData[22], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[13],_testData[23], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[14],_testData[24], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[15],_testData[25], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[16],_testData[26], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[17],_testData[27], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[18],_testData[28], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[19],_testData[29], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[20],_testData[30], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[21],_testData[31], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[22],_testData[32], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[23],_testData[33], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeOnlytime_without_time_zoneMMArrayD1E1M), typeof(FlatTimeOnlytime_without_time_zoneMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD1)),
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
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD1)),
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
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD1)),
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
FROM public.timeonlytime_without_time_zonemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD1E1M>();
                var models2 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD1E1M>();
                await((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.timeonlytime_without_time_zonemmarrayd1e1m m
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
FROM public.timeonlytime_without_time_zonemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD1E1M>();
                var firstItems2 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD1E1M>();
                var secondItems1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD1E1M>();
                var secondItems2 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD1E1M>();
                await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 70, query1, 119, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[7],_testData[34], false);
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
FROM public.timeonlytime_without_time_zonemmarrayd1e1m m
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
FROM public.timeonlytime_without_time_zonemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD1E1M>();
                var firstItems2 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD1E1M>();
                var secondItems1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD1E1M>();
                await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 110, query1, 77, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[17],_testData[34], false);
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
FROM public.timeonlytime_without_time_zonemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD1E1M>();
                var models2 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD1E1M>();
                ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.timeonlytime_without_time_zonemmarrayd1e1m m
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
FROM public.timeonlytime_without_time_zonemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD1E1M>();
                var firstItems2 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD1E1M>();
                var secondItems1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD1E1M>();
                var secondItems2 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD1E1M>();
                 ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 140, query1, 110, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[10],_testData[34], false);
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
FROM public.timeonlytime_without_time_zonemmarrayd1e1m m
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
FROM public.timeonlytime_without_time_zonemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD1E1M>();
                var firstItems2 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD1E1M>();
                var secondItems1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD1E1M>();
                 ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 38, query1, 128, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[6],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeOnlytime_without_time_zoneMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD1)),
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
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD1)),
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
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD1)),
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
FROM public.timeonlytime_without_time_zonemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.timeonlytime_without_time_zonemmarrayd1e1m m
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
FROM public.timeonlytime_without_time_zonemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 79, query1, 79, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[0],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[1],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[2],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[3],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[4],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[5],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[6],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[7],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[8],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[9],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[10],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[11],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[12],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[13],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[14],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[15],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[0],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[1],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[2],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[3],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[4],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[5],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[6],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[7],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[8],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[9],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[10],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[11],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[12],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[13],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[14],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[15],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[16],_testData[34], false);
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
FROM public.timeonlytime_without_time_zonemmarrayd1e1m m
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
FROM public.timeonlytime_without_time_zonemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD1E1M>();
                var secondItems1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD1E1M>();
                var secondItems2 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD1E1M>();
                await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 100, query1, 77, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[17],_testData[34], false);
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
FROM public.timeonlytime_without_time_zonemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.timeonlytime_without_time_zonemmarrayd1e1m m
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
FROM public.timeonlytime_without_time_zonemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 13, query1, 113, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[0],_testData[2], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[1],_testData[3], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[2],_testData[4], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[3],_testData[5], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[4],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[5],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[6],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[7],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[8],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[9],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[10],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[11],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[12],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[13],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[14],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[15],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[16],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[17],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[18],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[19],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[20],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[21],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[22],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[23],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[24],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[25],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[26],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[27],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[28],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[29],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[30],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[31],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[0],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[1],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[2],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[3],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[4],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[5],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[6],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[7],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[8],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[9],_testData[34], false);
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
FROM public.timeonlytime_without_time_zonemmarrayd1e1m m
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
FROM public.timeonlytime_without_time_zonemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD1E1M>();
                var secondItems1 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD1E1M>();
                var secondItems2 = new List<FlatTimeOnlytime_without_time_zoneMMArrayD1E1M>();
                 ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 153, query1, 70, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[18],_testData[34], false);
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
FROM public.timeonlytime_without_time_zonemmarrayd1e1m m
LEFT JOIN public.timeonlytime_without_time_zonemmarrayd1e1mi mi ON mi.id = m.timeonlytime_without_time_zonemmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD1)),
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
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD1)),
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
                var models = await((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 70, 51))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[0],_testData[16], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[1],_testData[17], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[2],_testData[18], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[3],_testData[19], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[4],_testData[20], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[5],_testData[21], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[6],_testData[22], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[7],_testData[23], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[8],_testData[24], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[9],_testData[25], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[10],_testData[26], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[11],_testData[27], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[12],_testData[28], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[13],_testData[29], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[14],_testData[30], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[15],_testData[31], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[16],_testData[32], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[17],_testData[33], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[0],_testData[13], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[1],_testData[14], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[2],_testData[15], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[3],_testData[16], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[4],_testData[17], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[5],_testData[18], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[6],_testData[19], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[7],_testData[20], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[8],_testData[21], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[9],_testData[22], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[10],_testData[23], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[11],_testData[24], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[12],_testData[25], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[13],_testData[26], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[14],_testData[27], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[15],_testData[28], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[16],_testData[29], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[17],_testData[30], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[18],_testData[31], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[19],_testData[32], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[20],_testData[33], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[21],_testData[34], false);
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
                var models = ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 109, 113))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[0],_testData[23], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[1],_testData[24], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[2],_testData[25], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[3],_testData[26], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[4],_testData[27], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[5],_testData[28], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[6],_testData[29], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[7],_testData[30], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[8],_testData[31], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[9],_testData[32], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[10],_testData[33], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[0],_testData[25], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[1],_testData[26], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[2],_testData[27], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[3],_testData[28], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[4],_testData[29], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[5],_testData[30], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[6],_testData[31], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[7],_testData[32], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[8],_testData[33], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[9],_testData[34], false);
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
                await using var cmd = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 61);
                var models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(20));

                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[0],_testData[15], false);
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[1],_testData[16], false);
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[2],_testData[17], false);
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[3],_testData[18], false);
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[4],_testData[19], false);
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[5],_testData[20], false);
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[6],_testData[21], false);
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[7],_testData[22], false);
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[8],_testData[23], false);
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[9],_testData[24], false);
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[10],_testData[25], false);
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[11],_testData[26], false);
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[12],_testData[27], false);
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[13],_testData[28], false);
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[14],_testData[29], false);
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[15],_testData[30], false);
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[16],_testData[31], false);
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[17],_testData[32], false);
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[18],_testData[33], false);
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[19],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 100);
                var models =  ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(13));

                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[0],_testData[22], false);
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[1],_testData[23], false);
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[2],_testData[24], false);
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[3],_testData[25], false);
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[4],_testData[26], false);
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[5],_testData[27], false);
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[6],_testData[28], false);
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[7],_testData[29], false);
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[8],_testData[30], false);
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[9],_testData[31], false);
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[10],_testData[32], false);
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[11],_testData[33], false);
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[12],_testData[34], false);
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
FROM public.binary_timeonlytime_without_time_zonemmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(TimeOnlytime_without_time_zoneMMArrayD1E1MIWA),
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
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<TimeOnlytime_without_time_zoneMMArrayD1E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeOnlytime_without_time_zoneMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_timeonlytime_without_time_zonemmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeOnlytime_without_time_zoneMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<TimeOnlytime_without_time_zoneMMArrayD1E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeOnlytime_without_time_zoneMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_timeonlytime_without_time_zonemmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeOnlytime_without_time_zoneMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_timeonlytime_without_time_zonemmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(TimeOnlytime_without_time_zoneMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<TimeOnlytime_without_time_zoneMMArrayD1E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeOnlytime_without_time_zoneMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_timeonlytime_without_time_zonemmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeOnlytime_without_time_zoneMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<TimeOnlytime_without_time_zoneMMArrayD1E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeOnlytime_without_time_zoneMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_timeonlytime_without_time_zonemmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeOnlytime_without_time_zoneMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_timeonlytime_without_time_zonemmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_timeonlytime_without_time_zonemmarrayd1e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(TimeOnlytime_without_time_zoneMMArrayD1E1MI),
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
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<TimeOnlytime_without_time_zoneMMArrayD1E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeOnlytime_without_time_zoneMMArrayD1E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<TimeOnlytime_without_time_zoneMMArrayD1E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).WAImportModelInner(connection, importCollection);
                var models = ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeOnlytime_without_time_zoneMMArrayD1E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_timeonlytime_without_time_zonemmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_timeonlytime_without_time_zonemmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(TimeOnlytime_without_time_zoneMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<TimeOnlytime_without_time_zoneMMArrayD1E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeOnlytime_without_time_zoneMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeOnlytime_without_time_zoneMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<TimeOnlytime_without_time_zoneMMArrayD1E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeOnlytime_without_time_zoneMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).ImportModelInner(connection, importCollection);
                var models = ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeOnlytime_without_time_zoneMMArrayD1E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_timeonlytime_without_time_zonemmarrayd1e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
timeonlytime_without_time_zonemmarrayd1e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(TimeOnlytime_without_time_zoneMMArrayD1E1M),
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
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD1))]
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
FROM public.binary_timeonlytime_without_time_zonemmarrayd1e1m m
LEFT JOIN public.binary_timeonlytime_without_time_zonemmarrayd1e1mi mi ON mi.id = m.timeonlytime_without_time_zonemmarrayd1e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<TimeOnlytime_without_time_zoneMMArrayD1E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<TimeOnlytime_without_time_zoneMMArrayD1E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).ImportModel(connection, importCollection);
                var models = ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_timeonlytime_without_time_zonemmarrayd1e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    timeonlytime_without_time_zonemmarrayd1e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483628),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483628)
            })]
        private void ExportModelConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneMMArrayD1E1MIWA), typeof(TimeOnlytime_without_time_zoneMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483628),
                (NpgsqlTypes.NpgsqlDbType)(-2147483628)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483628),
                (NpgsqlTypes.NpgsqlDbType)(-2147483628)
            })]
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
                var models1 = new List<TimeOnlytime_without_time_zoneMMArrayD1E1MIWA>();
                var models2 = new List<TimeOnlytime_without_time_zoneMMArrayD1E1MIWA>();
                await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_timeonlytime_without_time_zonemmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeOnlytime_without_time_zoneMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeOnlytime_without_time_zoneMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<TimeOnlytime_without_time_zoneMMArrayD1E1MIWA>();
                var models2 = new List<TimeOnlytime_without_time_zoneMMArrayD1E1MIWA>();
                ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_timeonlytime_without_time_zonemmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeOnlytime_without_time_zoneMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeOnlytime_without_time_zoneMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483628),
                (NpgsqlTypes.NpgsqlDbType)(-2147483628)
            })]
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
                var models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_timeonlytime_without_time_zonemmarrayd1e1mi
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
                    TimeOnlytime_without_time_zoneMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_timeonlytime_without_time_zonemmarrayd1e1mi
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
                    TimeOnlytime_without_time_zoneMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneMMArrayD1E1MIWA), typeof(TimeOnlytime_without_time_zoneMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD1))]
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
                var models1 = new List<TimeOnlytime_without_time_zoneMMArrayD1E1MIWA>();
                var models2 = new List<TimeOnlytime_without_time_zoneMMArrayD1E1MIWA>();
                await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_timeonlytime_without_time_zonemmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeOnlytime_without_time_zoneMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeOnlytime_without_time_zoneMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<TimeOnlytime_without_time_zoneMMArrayD1E1MIWA>();
                var models2 = new List<TimeOnlytime_without_time_zoneMMArrayD1E1MIWA>();
                ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_timeonlytime_without_time_zonemmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeOnlytime_without_time_zoneMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeOnlytime_without_time_zoneMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD1))]
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
                var models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_timeonlytime_without_time_zonemmarrayd1e1mi
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
                    TimeOnlytime_without_time_zoneMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_timeonlytime_without_time_zonemmarrayd1e1mi
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
                    TimeOnlytime_without_time_zoneMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_timeonlytime_without_time_zonemmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneMMArrayD1E1MI), typeof(TimeOnlytime_without_time_zoneMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483628),
                (NpgsqlTypes.NpgsqlDbType)(-2147483628)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483628),
                (NpgsqlTypes.NpgsqlDbType)(-2147483628)
            })]
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
                var models1 = new List<TimeOnlytime_without_time_zoneMMArrayD1E1MI>();
                var models2 = new List<TimeOnlytime_without_time_zoneMMArrayD1E1MI>();
                await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeOnlytime_without_time_zoneMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeOnlytime_without_time_zoneMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<TimeOnlytime_without_time_zoneMMArrayD1E1MI>();
                var models2 = new List<TimeOnlytime_without_time_zoneMMArrayD1E1MI>();
                ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeOnlytime_without_time_zoneMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeOnlytime_without_time_zoneMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_timeonlytime_without_time_zonemmarrayd1e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483628),
                (NpgsqlTypes.NpgsqlDbType)(-2147483628)
            })]
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
                var models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    TimeOnlytime_without_time_zoneMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    TimeOnlytime_without_time_zoneMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_timeonlytime_without_time_zonemmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneMMArrayD1E1MIWA), typeof(TimeOnlytime_without_time_zoneMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD1))]
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
                var models1 = new List<TimeOnlytime_without_time_zoneMMArrayD1E1MIWA>();
                var models2 = new List<TimeOnlytime_without_time_zoneMMArrayD1E1MIWA>();
                await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeOnlytime_without_time_zoneMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeOnlytime_without_time_zoneMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<TimeOnlytime_without_time_zoneMMArrayD1E1MIWA>();
                var models2 = new List<TimeOnlytime_without_time_zoneMMArrayD1E1MIWA>();
                ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeOnlytime_without_time_zoneMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeOnlytime_without_time_zoneMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_timeonlytime_without_time_zonemmarrayd1e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(TimeOnlytime_without_time_zoneMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeOnlyMArraytime_without_time_zoneMMArrayD1))]
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
                var models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    TimeOnlytime_without_time_zoneMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    TimeOnlytime_without_time_zoneMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

