

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
    Id = 1,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 57, second: 31, millisecond: 394),
new TimeOnly(hour: 18, minute: 41, second: 15, millisecond: 683),
new TimeOnly(hour: 5, minute: 41, second: 34, millisecond: 429),
},
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 2, minute: 1, second: 56, millisecond: 147),
new TimeOnly(hour: 8, minute: 15, second: 28, millisecond: 185),
new TimeOnly(hour: 18, minute: 19, second: 6, millisecond: 393),
new TimeOnly(hour: 4, minute: 57, second: 13, millisecond: 385),
},
},
            new TimeOnlytime_without_time_zoneMMArrayD1E1M
{
    Id = 3,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 21, minute: 19, second: 55, millisecond: 605),
new TimeOnly(hour: 6, minute: 15, second: 36, millisecond: 51),
new TimeOnly(hour: 5, minute: 12, second: 41, millisecond: 668),
},
    ModelInner = new TimeOnlytime_without_time_zoneMMArrayD1E1MI
{
    Id = 9,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 5, minute: 13, second: 6, millisecond: 508),
new TimeOnly(hour: 0, minute: 42, second: 26, millisecond: 492),
new TimeOnly(hour: 19, minute: 51, second: 42, millisecond: 178),
new TimeOnly(hour: 5, minute: 1, second: 22, millisecond: 526),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 8, minute: 39, second: 44, millisecond: 384),
new TimeOnly(hour: 12, minute: 5, second: 29, millisecond: 330),
new TimeOnly(hour: 9, minute: 30, second: 33, millisecond: 652),
},
},
            new TimeOnlytime_without_time_zoneMMArrayD1E1M
{
    Id = 7,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 11, minute: 51, second: 8, millisecond: 106),
new TimeOnly(hour: 8, minute: 28, second: 39, millisecond: 625),
new TimeOnly(hour: 18, minute: 26, second: 44, millisecond: 816),
new TimeOnly(hour: 22, minute: 38, second: 46, millisecond: 208),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneMMArrayD1E1M
{
    Id = 11,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 22, minute: 38, second: 18, millisecond: 35),
new TimeOnly(hour: 12, minute: 7, second: 35, millisecond: 790),
new TimeOnly(hour: 11, minute: 41, second: 51, millisecond: 419),
},
    ModelInner = new TimeOnlytime_without_time_zoneMMArrayD1E1MI
{
    Id = 17,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 8, minute: 17, second: 20, millisecond: 307),
new TimeOnly(hour: 19, minute: 4, second: 7, millisecond: 715),
new TimeOnly(hour: 9, minute: 33, second: 40, millisecond: 758),
},
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 12, minute: 10, second: 17, millisecond: 566),
new TimeOnly(hour: 2, minute: 5, second: 0, millisecond: 877),
new TimeOnly(hour: 0, minute: 10, second: 51, millisecond: 743),
new TimeOnly(hour: 12, minute: 48, second: 8, millisecond: 450),
},
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneMMArrayD1E1M
{
    Id = 20,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 7, minute: 13, second: 19, millisecond: 779),
new TimeOnly(hour: 4, minute: 34, second: 7, millisecond: 741),
new TimeOnly(hour: 17, minute: 6, second: 4, millisecond: 70),
new TimeOnly(hour: 15, minute: 32, second: 36, millisecond: 540),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneMMArrayD1E1M
{
    Id = 24,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 3, minute: 41, second: 5, millisecond: 377),
new TimeOnly(hour: 0, minute: 3, second: 25, millisecond: 184),
new TimeOnly(hour: 1, minute: 3, second: 13, millisecond: 922),
},
    ModelInner = new TimeOnlytime_without_time_zoneMMArrayD1E1MI
{
    Id = 23,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 21, minute: 19, second: 0, millisecond: 269),
new TimeOnly(hour: 12, minute: 12, second: 46, millisecond: 686),
new TimeOnly(hour: 13, minute: 47, second: 39, millisecond: 953),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 12, minute: 53, second: 2, millisecond: 445),
new TimeOnly(hour: 21, minute: 14, second: 58, millisecond: 156),
new TimeOnly(hour: 13, minute: 49, second: 51, millisecond: 217),
},
},
            new TimeOnlytime_without_time_zoneMMArrayD1E1M
{
    Id = 26,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 11, minute: 31, second: 30, millisecond: 9),
new TimeOnly(hour: 7, minute: 9, second: 45, millisecond: 362),
new TimeOnly(hour: 9, minute: 48, second: 29, millisecond: 925),
new TimeOnly(hour: 2, minute: 8, second: 25, millisecond: 871),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneMMArrayD1E1M
{
    Id = 31,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 4, minute: 43, second: 52, millisecond: 559),
new TimeOnly(hour: 10, minute: 5, second: 50, millisecond: 625),
new TimeOnly(hour: 16, minute: 16, second: 35, millisecond: 989),
},
    ModelInner = new TimeOnlytime_without_time_zoneMMArrayD1E1MI
{
    Id = 30,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 7, minute: 11, second: 13, millisecond: 718),
new TimeOnly(hour: 11, minute: 20, second: 6, millisecond: 938),
new TimeOnly(hour: 17, minute: 11, second: 50, millisecond: 186),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 22, minute: 51, second: 34, millisecond: 836),
new TimeOnly(hour: 14, minute: 7, second: 37, millisecond: 320),
new TimeOnly(hour: 15, minute: 51, second: 1, millisecond: 917),
new TimeOnly(hour: 7, minute: 21, second: 12, millisecond: 870),
},
},
            new TimeOnlytime_without_time_zoneMMArrayD1E1M
{
    Id = 40,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 18, minute: 11, second: 33, millisecond: 646),
new TimeOnly(hour: 3, minute: 5, second: 19, millisecond: 197),
new TimeOnly(hour: 0, minute: 57, second: 40, millisecond: 833),
new TimeOnly(hour: 1, minute: 17, second: 22, millisecond: 485),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneMMArrayD1E1M
{
    Id = 48,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 16, minute: 53, second: 3, millisecond: 752),
new TimeOnly(hour: 17, minute: 50, second: 12, millisecond: 365),
new TimeOnly(hour: 14, minute: 8, second: 42, millisecond: 572),
new TimeOnly(hour: 21, minute: 33, second: 9, millisecond: 432),
},
    ModelInner = new TimeOnlytime_without_time_zoneMMArrayD1E1MI
{
    Id = 34,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 15, minute: 20, second: 27, millisecond: 794),
new TimeOnly(hour: 5, minute: 38, second: 8, millisecond: 213),
new TimeOnly(hour: 19, minute: 56, second: 9, millisecond: 950),
new TimeOnly(hour: 12, minute: 52, second: 3, millisecond: 708),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneMMArrayD1E1M
{
    Id = 51,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 6, minute: 15, second: 31, millisecond: 636),
new TimeOnly(hour: 10, minute: 55, second: 21, millisecond: 569),
new TimeOnly(hour: 4, minute: 9, second: 41, millisecond: 109),
},
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 26, second: 13, millisecond: 298),
new TimeOnly(hour: 15, minute: 18, second: 42, millisecond: 672),
new TimeOnly(hour: 9, minute: 21, second: 20, millisecond: 92),
},
},
            new TimeOnlytime_without_time_zoneMMArrayD1E1M
{
    Id = 60,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 21, minute: 31, second: 58, millisecond: 497),
new TimeOnly(hour: 0, minute: 0, second: 48, millisecond: 899),
new TimeOnly(hour: 8, minute: 29, second: 51, millisecond: 249),
},
    ModelInner = new TimeOnlytime_without_time_zoneMMArrayD1E1MI
{
    Id = 42,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 18, minute: 10, second: 5, millisecond: 939),
new TimeOnly(hour: 4, minute: 13, second: 22, millisecond: 758),
new TimeOnly(hour: 1, minute: 32, second: 12, millisecond: 382),
new TimeOnly(hour: 22, minute: 8, second: 44, millisecond: 342),
},
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 0, second: 9, millisecond: 3),
new TimeOnly(hour: 13, minute: 50, second: 47, millisecond: 330),
new TimeOnly(hour: 7, minute: 20, second: 40, millisecond: 818),
},
},
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 1, minute: 17, second: 47, millisecond: 348),
new TimeOnly(hour: 20, minute: 1, second: 50, millisecond: 310),
new TimeOnly(hour: 10, minute: 10, second: 47, millisecond: 587),
},
},
            new TimeOnlytime_without_time_zoneMMArrayD1E1M
{
    Id = 68,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 3, minute: 18, second: 50, millisecond: 281),
new TimeOnly(hour: 22, minute: 55, second: 30, millisecond: 957),
new TimeOnly(hour: 19, minute: 23, second: 0, millisecond: 325),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneMMArrayD1E1M
{
    Id = 75,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 18, minute: 55, second: 21, millisecond: 49),
new TimeOnly(hour: 0, minute: 39, second: 57, millisecond: 242),
new TimeOnly(hour: 1, minute: 21, second: 26, millisecond: 890),
new TimeOnly(hour: 17, minute: 23, second: 14, millisecond: 915),
},
    ModelInner = new TimeOnlytime_without_time_zoneMMArrayD1E1MI
{
    Id = 45,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 17, minute: 24, second: 7, millisecond: 560),
new TimeOnly(hour: 11, minute: 36, second: 28, millisecond: 591),
new TimeOnly(hour: 4, minute: 58, second: 55, millisecond: 886),
new TimeOnly(hour: 12, minute: 18, second: 25, millisecond: 627),
},
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 12, minute: 31, second: 39, millisecond: 591),
new TimeOnly(hour: 9, minute: 20, second: 48, millisecond: 511),
new TimeOnly(hour: 4, minute: 47, second: 21, millisecond: 508),
new TimeOnly(hour: 22, minute: 39, second: 28, millisecond: 279),
},
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneMMArrayD1E1M
{
    Id = 83,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 20, minute: 43, second: 57, millisecond: 735),
new TimeOnly(hour: 19, minute: 46, second: 19, millisecond: 851),
new TimeOnly(hour: 5, minute: 35, second: 42, millisecond: 711),
new TimeOnly(hour: 14, minute: 46, second: 50, millisecond: 967),
},
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 3, minute: 15, second: 1, millisecond: 633),
new TimeOnly(hour: 12, minute: 8, second: 24, millisecond: 519),
new TimeOnly(hour: 16, minute: 38, second: 37, millisecond: 596),
},
},
            new TimeOnlytime_without_time_zoneMMArrayD1E1M
{
    Id = 86,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 22, minute: 26, second: 8, millisecond: 649),
new TimeOnly(hour: 0, minute: 23, second: 5, millisecond: 708),
new TimeOnly(hour: 10, minute: 4, second: 21, millisecond: 453),
new TimeOnly(hour: 18, minute: 2, second: 16, millisecond: 453),
},
    ModelInner = new TimeOnlytime_without_time_zoneMMArrayD1E1MI
{
    Id = 53,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 7, minute: 52, second: 7, millisecond: 54),
new TimeOnly(hour: 7, minute: 38, second: 50, millisecond: 731),
new TimeOnly(hour: 2, minute: 57, second: 8, millisecond: 391),
new TimeOnly(hour: 21, minute: 30, second: 46, millisecond: 69),
},
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 0, minute: 44, second: 26, millisecond: 609),
new TimeOnly(hour: 16, minute: 1, second: 21, millisecond: 449),
new TimeOnly(hour: 1, minute: 27, second: 16, millisecond: 246),
new TimeOnly(hour: 16, minute: 6, second: 48, millisecond: 866),
},
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneMMArrayD1E1M
{
    Id = 89,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 20, minute: 53, second: 21, millisecond: 978),
new TimeOnly(hour: 18, minute: 8, second: 20, millisecond: 938),
new TimeOnly(hour: 4, minute: 55, second: 3, millisecond: 439),
},
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 18, minute: 9, second: 15, millisecond: 531),
new TimeOnly(hour: 22, minute: 49, second: 20, millisecond: 860),
new TimeOnly(hour: 0, minute: 56, second: 12, millisecond: 410),
},
},
            new TimeOnlytime_without_time_zoneMMArrayD1E1M
{
    Id = 96,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 14, minute: 0, second: 56, millisecond: 105),
new TimeOnly(hour: 11, minute: 4, second: 20, millisecond: 711),
new TimeOnly(hour: 5, minute: 24, second: 40, millisecond: 361),
new TimeOnly(hour: 11, minute: 37, second: 1, millisecond: 439),
},
    ModelInner = new TimeOnlytime_without_time_zoneMMArrayD1E1MI
{
    Id = 58,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 13, minute: 14, second: 21, millisecond: 885),
new TimeOnly(hour: 9, minute: 8, second: 19, millisecond: 996),
new TimeOnly(hour: 3, minute: 55, second: 13, millisecond: 948),
new TimeOnly(hour: 12, minute: 23, second: 20, millisecond: 666),
},
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 13, minute: 7, second: 46, millisecond: 795),
new TimeOnly(hour: 2, minute: 54, second: 41, millisecond: 679),
new TimeOnly(hour: 5, minute: 47, second: 37, millisecond: 754),
},
},
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 4, minute: 56, second: 11, millisecond: 709),
new TimeOnly(hour: 13, minute: 12, second: 16, millisecond: 711),
new TimeOnly(hour: 3, minute: 32, second: 21, millisecond: 303),
new TimeOnly(hour: 10, minute: 15, second: 36, millisecond: 561),
},
},
            new TimeOnlytime_without_time_zoneMMArrayD1E1M
{
    Id = 101,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 22, minute: 45, second: 11, millisecond: 129),
new TimeOnly(hour: 18, minute: 5, second: 13, millisecond: 741),
new TimeOnly(hour: 11, minute: 54, second: 12, millisecond: 163),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneMMArrayD1E1M
{
    Id = 102,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 11, minute: 55, second: 29, millisecond: 263),
new TimeOnly(hour: 21, minute: 20, second: 36, millisecond: 135),
new TimeOnly(hour: 21, minute: 16, second: 44, millisecond: 303),
},
    ModelInner = new TimeOnlytime_without_time_zoneMMArrayD1E1MI
{
    Id = 66,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 18, minute: 26, second: 48, millisecond: 857),
new TimeOnly(hour: 18, minute: 54, second: 39, millisecond: 979),
new TimeOnly(hour: 3, minute: 21, second: 0, millisecond: 133),
new TimeOnly(hour: 14, minute: 1, second: 4, millisecond: 913),
},
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 4, minute: 16, second: 41, millisecond: 106),
new TimeOnly(hour: 1, minute: 7, second: 15, millisecond: 467),
new TimeOnly(hour: 19, minute: 44, second: 31, millisecond: 194),
new TimeOnly(hour: 19, minute: 44, second: 51, millisecond: 333),
},
},
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 3, minute: 22, second: 43, millisecond: 982),
new TimeOnly(hour: 5, minute: 43, second: 13, millisecond: 834),
new TimeOnly(hour: 16, minute: 33, second: 37, millisecond: 496),
new TimeOnly(hour: 1, minute: 32, second: 6, millisecond: 579),
},
},
            new TimeOnlytime_without_time_zoneMMArrayD1E1M
{
    Id = 111,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 0, minute: 47, second: 30, millisecond: 125),
new TimeOnly(hour: 10, minute: 16, second: 46, millisecond: 322),
new TimeOnly(hour: 11, minute: 36, second: 26, millisecond: 966),
},
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 9, minute: 4, second: 9, millisecond: 106),
new TimeOnly(hour: 10, minute: 48, second: 37, millisecond: 840),
new TimeOnly(hour: 20, minute: 12, second: 35, millisecond: 580),
},
},
            new TimeOnlytime_without_time_zoneMMArrayD1E1M
{
    Id = 120,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 16, minute: 1, second: 12, millisecond: 176),
new TimeOnly(hour: 7, minute: 28, second: 21, millisecond: 240),
new TimeOnly(hour: 3, minute: 46, second: 16, millisecond: 577),
new TimeOnly(hour: 0, minute: 45, second: 17, millisecond: 19),
},
    ModelInner = new TimeOnlytime_without_time_zoneMMArrayD1E1MI
{
    Id = 73,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 15, minute: 58, second: 54, millisecond: 89),
new TimeOnly(hour: 6, minute: 47, second: 57, millisecond: 279),
new TimeOnly(hour: 21, minute: 7, second: 24, millisecond: 705),
},
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 10, minute: 7, second: 22, millisecond: 843),
new TimeOnly(hour: 8, minute: 26, second: 53, millisecond: 556),
new TimeOnly(hour: 8, minute: 38, second: 22, millisecond: 413),
new TimeOnly(hour: 2, minute: 7, second: 1, millisecond: 624),
},
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneMMArrayD1E1M
{
    Id = 129,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 20, minute: 37, second: 7, millisecond: 843),
new TimeOnly(hour: 22, minute: 6, second: 33, millisecond: 910),
new TimeOnly(hour: 11, minute: 0, second: 12, millisecond: 16),
new TimeOnly(hour: 22, minute: 47, second: 49, millisecond: 758),
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
new TimeOnly(hour: 22, minute: 54, second: 19, millisecond: 698),
new TimeOnly(hour: 19, minute: 58, second: 20, millisecond: 413),
new TimeOnly(hour: 16, minute: 20, second: 51, millisecond: 360),
new TimeOnly(hour: 1, minute: 40, second: 10, millisecond: 969),
},
    ModelInner = new TimeOnlytime_without_time_zoneMMArrayD1E1MI
{
    Id = 74,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 0, minute: 33, second: 0, millisecond: 150),
new TimeOnly(hour: 4, minute: 26, second: 32, millisecond: 587),
new TimeOnly(hour: 20, minute: 16, second: 21, millisecond: 297),
},
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 20, minute: 12, second: 15, millisecond: 42),
new TimeOnly(hour: 16, minute: 39, second: 43, millisecond: 508),
new TimeOnly(hour: 2, minute: 39, second: 3, millisecond: 529),
new TimeOnly(hour: 9, minute: 6, second: 38, millisecond: 904),
},
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneMMArrayD1E1M
{
    Id = 146,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 13, minute: 38, second: 45, millisecond: 949),
new TimeOnly(hour: 12, minute: 19, second: 26, millisecond: 275),
new TimeOnly(hour: 6, minute: 40, second: 23, millisecond: 629),
new TimeOnly(hour: 12, minute: 12, second: 12, millisecond: 677),
},
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 25, second: 37, millisecond: 29),
new TimeOnly(hour: 19, minute: 5, second: 20, millisecond: 345),
new TimeOnly(hour: 13, minute: 33, second: 4, millisecond: 25),
},
},
            new TimeOnlytime_without_time_zoneMMArrayD1E1M
{
    Id = 155,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 4, minute: 2, second: 57, millisecond: 956),
new TimeOnly(hour: 7, minute: 36, second: 9, millisecond: 376),
new TimeOnly(hour: 18, minute: 36, second: 9, millisecond: 270),
},
    ModelInner = new TimeOnlytime_without_time_zoneMMArrayD1E1MI
{
    Id = 81,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 18, minute: 28, second: 11, millisecond: 888),
new TimeOnly(hour: 4, minute: 1, second: 51, millisecond: 533),
new TimeOnly(hour: 3, minute: 45, second: 27, millisecond: 529),
},
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 0, second: 44, millisecond: 813),
new TimeOnly(hour: 4, minute: 37, second: 28, millisecond: 88),
new TimeOnly(hour: 11, minute: 55, second: 38, millisecond: 913),
},
},
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 19, minute: 50, second: 0, millisecond: 228),
new TimeOnly(hour: 14, minute: 48, second: 55, millisecond: 896),
new TimeOnly(hour: 15, minute: 52, second: 49, millisecond: 129),
},
},
            new TimeOnlytime_without_time_zoneMMArrayD1E1M
{
    Id = 163,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 5, minute: 44, second: 52, millisecond: 719),
new TimeOnly(hour: 18, minute: 50, second: 11, millisecond: 994),
new TimeOnly(hour: 18, minute: 32, second: 16, millisecond: 444),
},
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 3, minute: 12, second: 30, millisecond: 467),
new TimeOnly(hour: 3, minute: 53, second: 34, millisecond: 155),
new TimeOnly(hour: 16, minute: 45, second: 31, millisecond: 297),
new TimeOnly(hour: 3, minute: 34, second: 14, millisecond: 186),
},
},
            new TimeOnlytime_without_time_zoneMMArrayD1E1M
{
    Id = 165,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 13, minute: 35, second: 17, millisecond: 214),
new TimeOnly(hour: 10, minute: 2, second: 39, millisecond: 164),
new TimeOnly(hour: 20, minute: 41, second: 50, millisecond: 487),
new TimeOnly(hour: 1, minute: 42, second: 16, millisecond: 89),
},
    ModelInner = new TimeOnlytime_without_time_zoneMMArrayD1E1MI
{
    Id = 90,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 8, minute: 31, second: 41, millisecond: 735),
new TimeOnly(hour: 13, minute: 1, second: 27, millisecond: 348),
new TimeOnly(hour: 12, minute: 7, second: 46, millisecond: 682),
new TimeOnly(hour: 8, minute: 9, second: 13, millisecond: 922),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneMMArrayD1E1M
{
    Id = 166,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 20, minute: 22, second: 55, millisecond: 952),
new TimeOnly(hour: 1, minute: 14, second: 17, millisecond: 347),
new TimeOnly(hour: 10, minute: 33, second: 40, millisecond: 624),
},
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 8, minute: 24, second: 15, millisecond: 244),
new TimeOnly(hour: 14, minute: 58, second: 2, millisecond: 929),
new TimeOnly(hour: 2, minute: 53, second: 4, millisecond: 889),
new TimeOnly(hour: 13, minute: 36, second: 42, millisecond: 457),
},
},
            new TimeOnlytime_without_time_zoneMMArrayD1E1M
{
    Id = 167,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 8, minute: 3, second: 8, millisecond: 88),
new TimeOnly(hour: 4, minute: 14, second: 32, millisecond: 799),
new TimeOnly(hour: 22, minute: 45, second: 4, millisecond: 165),
new TimeOnly(hour: 19, minute: 49, second: 46, millisecond: 850),
},
    ModelInner = new TimeOnlytime_without_time_zoneMMArrayD1E1MI
{
    Id = 91,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 19, minute: 31, second: 32, millisecond: 189),
new TimeOnly(hour: 12, minute: 45, second: 10, millisecond: 159),
new TimeOnly(hour: 3, minute: 38, second: 28, millisecond: 793),
new TimeOnly(hour: 22, minute: 29, second: 9, millisecond: 9),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneMMArrayD1E1M
{
    Id = 168,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 4, minute: 45, second: 16, millisecond: 498),
new TimeOnly(hour: 2, minute: 33, second: 14, millisecond: 670),
new TimeOnly(hour: 2, minute: 46, second: 24, millisecond: 657),
},
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 9, minute: 20, second: 57, millisecond: 761),
new TimeOnly(hour: 6, minute: 30, second: 43, millisecond: 786),
new TimeOnly(hour: 9, minute: 55, second: 27, millisecond: 424),
},
},
            new TimeOnlytime_without_time_zoneMMArrayD1E1M
{
    Id = 177,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 6, minute: 29, second: 6, millisecond: 204),
new TimeOnly(hour: 10, minute: 46, second: 57, millisecond: 26),
new TimeOnly(hour: 11, minute: 1, second: 46, millisecond: 635),
},
    ModelInner = new TimeOnlytime_without_time_zoneMMArrayD1E1MI
{
    Id = 97,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 13, minute: 48, second: 0, millisecond: 229),
new TimeOnly(hour: 2, minute: 56, second: 15, millisecond: 161),
new TimeOnly(hour: 3, minute: 56, second: 47, millisecond: 976),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 9, minute: 23, second: 41, millisecond: 832),
new TimeOnly(hour: 4, minute: 35, second: 0, millisecond: 834),
new TimeOnly(hour: 18, minute: 3, second: 14, millisecond: 288),
},
},
            new TimeOnlytime_without_time_zoneMMArrayD1E1M
{
    Id = 184,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 13, minute: 31, second: 37, millisecond: 967),
new TimeOnly(hour: 1, minute: 3, second: 24, millisecond: 196),
new TimeOnly(hour: 3, minute: 43, second: 15, millisecond: 565),
new TimeOnly(hour: 10, minute: 54, second: 5, millisecond: 46),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneMMArrayD1E1M
{
    Id = 185,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 5, minute: 12, second: 24, millisecond: 970),
new TimeOnly(hour: 16, minute: 30, second: 45, millisecond: 600),
new TimeOnly(hour: 14, minute: 53, second: 45, millisecond: 903),
},
    ModelInner = new TimeOnlytime_without_time_zoneMMArrayD1E1MI
{
    Id = 102,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 21, minute: 11, second: 28, millisecond: 807),
new TimeOnly(hour: 18, minute: 23, second: 43, millisecond: 376),
new TimeOnly(hour: 19, minute: 5, second: 16, millisecond: 925),
},
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 1, minute: 41, second: 53, millisecond: 320),
new TimeOnly(hour: 6, minute: 47, second: 56, millisecond: 730),
new TimeOnly(hour: 15, minute: 12, second: 19, millisecond: 178),
new TimeOnly(hour: 21, minute: 55, second: 15, millisecond: 566),
},
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneMMArrayD1E1M
{
    Id = 189,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 4, minute: 50, second: 7, millisecond: 885),
new TimeOnly(hour: 16, minute: 53, second: 48, millisecond: 179),
new TimeOnly(hour: 2, minute: 11, second: 32, millisecond: 780),
new TimeOnly(hour: 5, minute: 58, second: 29, millisecond: 188),
},
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 3, minute: 36, second: 31, millisecond: 964),
new TimeOnly(hour: 4, minute: 25, second: 41, millisecond: 422),
new TimeOnly(hour: 21, minute: 39, second: 45, millisecond: 638),
new TimeOnly(hour: 10, minute: 58, second: 25, millisecond: 30),
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
                parametr1.Value = 146;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 168;
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
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[3],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 3;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 120;
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
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[12],_testData[34], false);
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
                parametr1.Value = 20;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 60;
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
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[22],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 165;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 120;
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
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[12],_testData[34], false);
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
                parametr1.Value = 7;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 40;
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
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[0],_testData[3], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[1],_testData[4], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[2],_testData[5], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[3],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[4],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[5],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[6],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[7],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[8],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[9],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[10],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[11],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[12],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[13],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[14],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[15],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[16],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[17],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[18],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[19],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[20],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[21],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[22],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[23],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[24],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[25],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[26],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[27],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[28],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[29],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[30],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                parametr1.Value = 89;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 155;
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
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[8],_testData[34], false);
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
                parametr1.Value = 75;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 166;
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
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[0],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[1],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[2],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[3],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[4],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[5],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[6],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[7],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[8],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[9],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[10],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[11],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[12],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[13],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[14],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[15],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[16],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[17],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[18],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[19],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[0],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[1],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[2],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[3],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[4],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[5],_testData[34], false);
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
                parametr1.Value = 167;
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
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[21],_testData[34], false);
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
                parametr1.Value = 1;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 68;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[0],_testData[1], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[1],_testData[2], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[2],_testData[3], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[3],_testData[4], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[4],_testData[5], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[5],_testData[6], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[6],_testData[7], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[7],_testData[8], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[8],_testData[9], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[9],_testData[10], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[10],_testData[11], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[11],_testData[12], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[12],_testData[13], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[13],_testData[14], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[14],_testData[15], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[15],_testData[16], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[16],_testData[17], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[17],_testData[18], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[18],_testData[19], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[19],_testData[20], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[20],_testData[21], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[21],_testData[22], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[22],_testData[23], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[23],_testData[24], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[24],_testData[25], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[25],_testData[26], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[26],_testData[27], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[27],_testData[28], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[28],_testData[29], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[29],_testData[30], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[30],_testData[31], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[31],_testData[32], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[32],_testData[33], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[33],_testData[34], false);
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
                parametr1.Value = 163;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 177;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[0],_testData[27], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[1],_testData[28], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[2],_testData[29], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[3],_testData[30], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[4],_testData[31], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[5],_testData[32], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[6],_testData[33], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[0],_testData[32], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[1],_testData[33], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[2],_testData[34], false);
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
                await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 1, query1, 60, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[22],_testData[34], false);
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
                await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 163, query1, 177, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[2],_testData[34], false);
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
                 ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 31, query1, 68, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[21],_testData[34], false);
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
                 ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 89, query1, 3, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[32],_testData[34], false);
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
                foreach(var batchResult in await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 165, query1, 167, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[0],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[1],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[2],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[3],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[4],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[5],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[0],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[1],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[2],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[3],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[4],_testData[34], false);
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
                await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 163, query1, 168, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[3],_testData[34], false);
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
                foreach(var batchResult in  ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 3, query1, 166, query2))
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
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[0],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[1],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[2],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[3],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[4],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[5],_testData[34], false);
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
                 ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 31, query1, 155, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(firstItems1[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatTimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(secondItems2[8],_testData[34], false);
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
                foreach(var batchResult in await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 60, 68))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[0],_testData[12], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[1],_testData[13], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[2],_testData[14], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[3],_testData[15], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[4],_testData[16], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[5],_testData[17], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[6],_testData[18], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[7],_testData[19], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[8],_testData[20], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[9],_testData[21], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[10],_testData[22], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[11],_testData[23], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[12],_testData[24], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[13],_testData[25], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[14],_testData[26], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[15],_testData[27], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[16],_testData[28], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[17],_testData[29], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[18],_testData[30], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[19],_testData[31], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[20],_testData[32], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[21],_testData[33], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[22],_testData[34], false);
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
                foreach(var batchResult in  ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 20, 60))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[0],_testData[5], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[1],_testData[6], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[2],_testData[7], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[3],_testData[8], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[4],_testData[9], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[5],_testData[10], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[6],_testData[11], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[7],_testData[12], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[8],_testData[13], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[9],_testData[14], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[10],_testData[15], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[11],_testData[16], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[12],_testData[17], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[13],_testData[18], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[14],_testData[19], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[15],_testData[20], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[16],_testData[21], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[17],_testData[22], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[18],_testData[23], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[19],_testData[24], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[20],_testData[25], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[21],_testData[26], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[22],_testData[27], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[23],_testData[28], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[24],_testData[29], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[25],_testData[30], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[26],_testData[31], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[27],_testData[32], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[28],_testData[33], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[0],_testData[12], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[1],_testData[13], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[2],_testData[14], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[3],_testData[15], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[4],_testData[16], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[5],_testData[17], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[6],_testData[18], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[7],_testData[19], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[8],_testData[20], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[9],_testData[21], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[10],_testData[22], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[11],_testData[23], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[12],_testData[24], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[13],_testData[25], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[14],_testData[26], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[15],_testData[27], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[16],_testData[28], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[17],_testData[29], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[18],_testData[30], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[19],_testData[31], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[20],_testData[32], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[21],_testData[33], false);
                        TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[22],_testData[34], false);
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
                ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 96);
                var models = await ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(17));

                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[0],_testData[18], false);
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[1],_testData[19], false);
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[2],_testData[20], false);
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[3],_testData[21], false);
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[4],_testData[22], false);
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[5],_testData[23], false);
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[6],_testData[24], false);
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[7],_testData[25], false);
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[8],_testData[26], false);
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[9],_testData[27], false);
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[10],_testData[28], false);
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[11],_testData[29], false);
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[12],_testData[30], false);
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[13],_testData[31], false);
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[14],_testData[32], false);
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[15],_testData[33], false);
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[16],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 138);
                var models =  ((ITimeOnlyMArraytime_without_time_zoneMMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(11));

                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[0],_testData[24], false);
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[1],_testData[25], false);
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[2],_testData[26], false);
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[3],_testData[27], false);
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[4],_testData[28], false);
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[5],_testData[29], false);
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[6],_testData[30], false);
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[7],_testData[31], false);
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[8],_testData[32], false);
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[9],_testData[33], false);
                TimeOnlytime_without_time_zoneMMArrayD1E1M.AssertModel(models[10],_testData[34], false);
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

