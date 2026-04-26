

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
new TimeOnly(hour: 7, minute: 10, second: 53, millisecond: 521),
new TimeOnly(hour: 11, minute: 46, second: 31, millisecond: 416),
new TimeOnly(hour: 10, minute: 24, second: 6, millisecond: 839),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 10,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 3, minute: 40, second: 42, millisecond: 689),
new TimeOnly(hour: 3, minute: 19, second: 20, millisecond: 142),
new TimeOnly(hour: 12, minute: 25, second: 24, millisecond: 240),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 5,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 19, minute: 8, second: 33, millisecond: 639),
new TimeOnly(hour: 22, minute: 57, second: 0, millisecond: 325),
new TimeOnly(hour: 18, minute: 3, second: 17, millisecond: 275),
new TimeOnly(hour: 16, minute: 14, second: 50, millisecond: 530),
},
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 3, minute: 14, second: 11, millisecond: 48),
new TimeOnly(hour: 14, minute: 52, second: 43, millisecond: 586),
new TimeOnly(hour: 5, minute: 21, second: 47, millisecond: 186),
new TimeOnly(hour: 15, minute: 15, second: 40, millisecond: 830),
},
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 17,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 22, minute: 12, second: 5, millisecond: 774),
new TimeOnly(hour: 2, minute: 37, second: 27, millisecond: 229),
new TimeOnly(hour: 3, minute: 22, second: 1, millisecond: 200),
},
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 5, minute: 9, second: 30, millisecond: 505),
new TimeOnly(hour: 5, minute: 5, second: 28, millisecond: 361),
new TimeOnly(hour: 2, minute: 28, second: 7, millisecond: 228),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 20,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 4, minute: 56, second: 46, millisecond: 239),
new TimeOnly(hour: 22, minute: 13, second: 51, millisecond: 507),
new TimeOnly(hour: 17, minute: 30, second: 50, millisecond: 71),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 12,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 20, minute: 29, second: 38, millisecond: 692),
new TimeOnly(hour: 11, minute: 7, second: 38, millisecond: 810),
new TimeOnly(hour: 1, minute: 51, second: 52, millisecond: 523),
new TimeOnly(hour: 15, minute: 16, second: 22, millisecond: 516),
},
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 14, minute: 26, second: 12, millisecond: 828),
new TimeOnly(hour: 16, minute: 37, second: 7, millisecond: 339),
new TimeOnly(hour: 10, minute: 15, second: 21, millisecond: 41),
new TimeOnly(hour: 14, minute: 14, second: 56, millisecond: 3),
},
},
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 16, minute: 14, second: 2, millisecond: 695),
new TimeOnly(hour: 2, minute: 45, second: 0, millisecond: 565),
new TimeOnly(hour: 12, minute: 42, second: 57, millisecond: 50),
new TimeOnly(hour: 14, minute: 26, second: 53, millisecond: 426),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 28,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 5, minute: 33, second: 27, millisecond: 480),
new TimeOnly(hour: 17, minute: 29, second: 31, millisecond: 462),
new TimeOnly(hour: 9, minute: 44, second: 8, millisecond: 775),
new TimeOnly(hour: 9, minute: 19, second: 16, millisecond: 122),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 30,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 2, minute: 7, second: 10, millisecond: 402),
new TimeOnly(hour: 2, minute: 38, second: 39, millisecond: 362),
new TimeOnly(hour: 21, minute: 28, second: 13, millisecond: 380),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 15,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 8, minute: 0, second: 13, millisecond: 223),
new TimeOnly(hour: 3, minute: 11, second: 20, millisecond: 717),
new TimeOnly(hour: 5, minute: 39, second: 11, millisecond: 813),
},
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 7, minute: 15, second: 47, millisecond: 407),
new TimeOnly(hour: 20, minute: 26, second: 39, millisecond: 958),
new TimeOnly(hour: 3, minute: 20, second: 10, millisecond: 242),
},
},
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 1, minute: 9, second: 16, millisecond: 507),
new TimeOnly(hour: 16, minute: 12, second: 53, millisecond: 276),
new TimeOnly(hour: 7, minute: 11, second: 49, millisecond: 953),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 38,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 13, minute: 3, second: 31, millisecond: 140),
new TimeOnly(hour: 22, minute: 36, second: 18, millisecond: 97),
new TimeOnly(hour: 11, minute: 31, second: 28, millisecond: 498),
new TimeOnly(hour: 11, minute: 33, second: 47, millisecond: 236),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 41,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 10, minute: 45, second: 51, millisecond: 573),
new TimeOnly(hour: 17, minute: 52, second: 45, millisecond: 553),
new TimeOnly(hour: 9, minute: 15, second: 4, millisecond: 756),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 19,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 40, second: 4, millisecond: 474),
new TimeOnly(hour: 15, minute: 29, second: 47, millisecond: 603),
new TimeOnly(hour: 19, minute: 33, second: 14, millisecond: 104),
},
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 1, minute: 35, second: 27, millisecond: 106),
new TimeOnly(hour: 16, minute: 40, second: 39, millisecond: 705),
new TimeOnly(hour: 11, minute: 4, second: 22, millisecond: 162),
new TimeOnly(hour: 5, minute: 23, second: 55, millisecond: 665),
},
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 45,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 12, minute: 7, second: 35, millisecond: 19),
new TimeOnly(hour: 6, minute: 55, second: 3, millisecond: 102),
new TimeOnly(hour: 0, minute: 29, second: 34, millisecond: 894),
new TimeOnly(hour: 20, minute: 34, second: 48, millisecond: 381),
},
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 2, minute: 53, second: 25, millisecond: 101),
new TimeOnly(hour: 6, minute: 6, second: 58, millisecond: 955),
new TimeOnly(hour: 1, minute: 22, second: 10, millisecond: 343),
new TimeOnly(hour: 8, minute: 34, second: 16, millisecond: 622),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 52,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 7, minute: 51, second: 49, millisecond: 254),
new TimeOnly(hour: 7, minute: 5, second: 41, millisecond: 599),
new TimeOnly(hour: 8, minute: 30, second: 28, millisecond: 42),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 27,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 14, minute: 12, second: 7, millisecond: 301),
new TimeOnly(hour: 2, minute: 51, second: 24, millisecond: 409),
new TimeOnly(hour: 21, minute: 6, second: 12, millisecond: 716),
new TimeOnly(hour: 2, minute: 22, second: 20, millisecond: 534),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 0, minute: 50, second: 16, millisecond: 106),
new TimeOnly(hour: 17, minute: 1, second: 23, millisecond: 366),
new TimeOnly(hour: 4, minute: 48, second: 54, millisecond: 140),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 54,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 5, minute: 28, second: 19, millisecond: 978),
new TimeOnly(hour: 17, minute: 31, second: 19, millisecond: 923),
new TimeOnly(hour: 7, minute: 49, second: 46, millisecond: 550),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 60,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 7, minute: 58, second: 41, millisecond: 159),
new TimeOnly(hour: 4, minute: 3, second: 31, millisecond: 568),
new TimeOnly(hour: 22, minute: 22, second: 53, millisecond: 936),
new TimeOnly(hour: 8, minute: 50, second: 57, millisecond: 399),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 28,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 36, second: 47, millisecond: 647),
new TimeOnly(hour: 10, minute: 23, second: 12, millisecond: 807),
new TimeOnly(hour: 9, minute: 45, second: 15, millisecond: 105),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 61,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 45, second: 4, millisecond: 340),
new TimeOnly(hour: 16, minute: 52, second: 17, millisecond: 738),
new TimeOnly(hour: 7, minute: 7, second: 2, millisecond: 385),
},
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 0, minute: 14, second: 7, millisecond: 403),
new TimeOnly(hour: 1, minute: 6, second: 39, millisecond: 223),
new TimeOnly(hour: 19, minute: 54, second: 42, millisecond: 336),
new TimeOnly(hour: 4, minute: 49, second: 29, millisecond: 962),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 62,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 1, minute: 56, second: 49, millisecond: 619),
new TimeOnly(hour: 3, minute: 55, second: 48, millisecond: 391),
new TimeOnly(hour: 1, minute: 36, second: 53, millisecond: 215),
new TimeOnly(hour: 11, minute: 49, second: 56, millisecond: 310),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 32,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 1, minute: 15, second: 26, millisecond: 63),
new TimeOnly(hour: 21, minute: 21, second: 34, millisecond: 825),
new TimeOnly(hour: 16, minute: 55, second: 35, millisecond: 832),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 12, minute: 19, second: 29, millisecond: 550),
new TimeOnly(hour: 22, minute: 40, second: 6, millisecond: 477),
new TimeOnly(hour: 8, minute: 35, second: 33, millisecond: 847),
new TimeOnly(hour: 16, minute: 33, second: 3, millisecond: 891),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 64,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 22, minute: 36, second: 37, millisecond: 404),
new TimeOnly(hour: 19, minute: 38, second: 51, millisecond: 351),
new TimeOnly(hour: 0, minute: 58, second: 21, millisecond: 869),
},
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 10, minute: 6, second: 16, millisecond: 167),
new TimeOnly(hour: 16, minute: 20, second: 41, millisecond: 143),
new TimeOnly(hour: 6, minute: 6, second: 27, millisecond: 192),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 72,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 6, minute: 17, second: 15, millisecond: 877),
new TimeOnly(hour: 8, minute: 56, second: 46, millisecond: 35),
new TimeOnly(hour: 10, minute: 47, second: 46, millisecond: 410),
new TimeOnly(hour: 0, minute: 15, second: 12, millisecond: 380),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 33,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 18, minute: 47, second: 52, millisecond: 343),
new TimeOnly(hour: 10, minute: 12, second: 44, millisecond: 13),
new TimeOnly(hour: 19, minute: 22, second: 34, millisecond: 102),
new TimeOnly(hour: 3, minute: 56, second: 3, millisecond: 907),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 77,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 6, minute: 20, second: 45, millisecond: 442),
new TimeOnly(hour: 19, minute: 51, second: 13, millisecond: 950),
new TimeOnly(hour: 4, minute: 57, second: 23, millisecond: 16),
},
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 1, minute: 18, second: 20, millisecond: 318),
new TimeOnly(hour: 7, minute: 2, second: 4, millisecond: 477),
new TimeOnly(hour: 10, minute: 43, second: 19, millisecond: 316),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 78,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 13, minute: 17, second: 46, millisecond: 886),
new TimeOnly(hour: 4, minute: 16, second: 26, millisecond: 607),
new TimeOnly(hour: 6, minute: 36, second: 50, millisecond: 892),
new TimeOnly(hour: 4, minute: 56, second: 20, millisecond: 403),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 39,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 13, minute: 15, second: 22, millisecond: 710),
new TimeOnly(hour: 18, minute: 6, second: 41, millisecond: 363),
new TimeOnly(hour: 3, minute: 31, second: 55, millisecond: 716),
new TimeOnly(hour: 10, minute: 39, second: 28, millisecond: 878),
},
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 6, minute: 21, second: 8, millisecond: 566),
new TimeOnly(hour: 6, minute: 47, second: 18, millisecond: 767),
new TimeOnly(hour: 13, minute: 21, second: 32, millisecond: 210),
},
},
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 5, minute: 10, second: 8, millisecond: 928),
new TimeOnly(hour: 14, minute: 34, second: 41, millisecond: 760),
new TimeOnly(hour: 5, minute: 6, second: 11, millisecond: 115),
new TimeOnly(hour: 9, minute: 6, second: 41, millisecond: 477),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 81,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 12, minute: 15, second: 18, millisecond: 742),
new TimeOnly(hour: 3, minute: 11, second: 11, millisecond: 5),
new TimeOnly(hour: 6, minute: 37, second: 58, millisecond: 282),
new TimeOnly(hour: 22, minute: 18, second: 30, millisecond: 76),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 83,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 22, minute: 35, second: 43, millisecond: 677),
new TimeOnly(hour: 17, minute: 46, second: 16, millisecond: 571),
new TimeOnly(hour: 21, minute: 58, second: 7, millisecond: 489),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 44,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 11, minute: 58, second: 7, millisecond: 979),
new TimeOnly(hour: 18, minute: 21, second: 44, millisecond: 113),
new TimeOnly(hour: 15, minute: 25, second: 22, millisecond: 135),
new TimeOnly(hour: 20, minute: 24, second: 4, millisecond: 331),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 90,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 22, minute: 47, second: 52, millisecond: 589),
new TimeOnly(hour: 9, minute: 44, second: 33, millisecond: 527),
new TimeOnly(hour: 14, minute: 23, second: 26, millisecond: 923),
new TimeOnly(hour: 16, minute: 37, second: 42, millisecond: 638),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 92,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 56, second: 16, millisecond: 810),
new TimeOnly(hour: 7, minute: 52, second: 35, millisecond: 665),
new TimeOnly(hour: 10, minute: 49, second: 3, millisecond: 862),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 48,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 16, minute: 46, second: 51, millisecond: 9),
new TimeOnly(hour: 2, minute: 50, second: 46, millisecond: 535),
new TimeOnly(hour: 7, minute: 42, second: 34, millisecond: 588),
new TimeOnly(hour: 8, minute: 54, second: 12, millisecond: 357),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 98,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 6, minute: 33, second: 27, millisecond: 285),
new TimeOnly(hour: 8, minute: 9, second: 5, millisecond: 551),
new TimeOnly(hour: 2, minute: 48, second: 39, millisecond: 568),
new TimeOnly(hour: 4, minute: 20, second: 3, millisecond: 581),
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
new TimeOnly(hour: 20, minute: 35, second: 44, millisecond: 302),
new TimeOnly(hour: 15, minute: 31, second: 22, millisecond: 890),
new TimeOnly(hour: 16, minute: 8, second: 37, millisecond: 22),
new TimeOnly(hour: 18, minute: 13, second: 18, millisecond: 300),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 54,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 9, minute: 42, second: 13, millisecond: 936),
new TimeOnly(hour: 3, minute: 52, second: 49, millisecond: 620),
new TimeOnly(hour: 9, minute: 28, second: 9, millisecond: 481),
},
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 20, minute: 20, second: 26, millisecond: 163),
new TimeOnly(hour: 20, minute: 29, second: 2, millisecond: 225),
new TimeOnly(hour: 11, minute: 39, second: 8, millisecond: 705),
new TimeOnly(hour: 10, minute: 35, second: 23, millisecond: 121),
},
},
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 4, minute: 57, second: 46, millisecond: 294),
new TimeOnly(hour: 11, minute: 5, second: 32, millisecond: 32),
new TimeOnly(hour: 1, minute: 10, second: 58, millisecond: 695),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 106,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 0, minute: 25, second: 9, millisecond: 744),
new TimeOnly(hour: 21, minute: 40, second: 17, millisecond: 443),
new TimeOnly(hour: 12, minute: 14, second: 30, millisecond: 550),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 109,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 10, minute: 53, second: 28, millisecond: 144),
new TimeOnly(hour: 14, minute: 15, second: 57, millisecond: 170),
new TimeOnly(hour: 19, minute: 48, second: 8, millisecond: 527),
new TimeOnly(hour: 15, minute: 16, second: 22, millisecond: 415),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 63,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 9, minute: 34, second: 36, millisecond: 424),
new TimeOnly(hour: 9, minute: 24, second: 23, millisecond: 5),
new TimeOnly(hour: 19, minute: 21, second: 22, millisecond: 282),
new TimeOnly(hour: 21, minute: 30, second: 10, millisecond: 844),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 1, minute: 48, second: 50, millisecond: 583),
new TimeOnly(hour: 16, minute: 51, second: 38, millisecond: 944),
new TimeOnly(hour: 6, minute: 37, second: 16, millisecond: 947),
new TimeOnly(hour: 3, minute: 11, second: 6, millisecond: 366),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 113,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 0, minute: 28, second: 45, millisecond: 794),
new TimeOnly(hour: 2, minute: 9, second: 37, millisecond: 383),
new TimeOnly(hour: 5, minute: 3, second: 51, millisecond: 737),
},
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 4, minute: 39, second: 38, millisecond: 90),
new TimeOnly(hour: 18, minute: 23, second: 4, millisecond: 639),
new TimeOnly(hour: 18, minute: 58, second: 53, millisecond: 246),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 114,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 11, minute: 22, second: 5, millisecond: 129),
new TimeOnly(hour: 14, minute: 49, second: 35, millisecond: 645),
new TimeOnly(hour: 6, minute: 7, second: 22, millisecond: 684),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 67,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 9, minute: 8, second: 21, millisecond: 303),
new TimeOnly(hour: 13, minute: 33, second: 37, millisecond: 885),
new TimeOnly(hour: 14, minute: 48, second: 6, millisecond: 824),
},
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 16, minute: 17, second: 2, millisecond: 163),
new TimeOnly(hour: 22, minute: 40, second: 26, millisecond: 670),
new TimeOnly(hour: 6, minute: 7, second: 53, millisecond: 448),
new TimeOnly(hour: 15, minute: 11, second: 26, millisecond: 453),
},
},
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 15, minute: 12, second: 1, millisecond: 440),
new TimeOnly(hour: 10, minute: 1, second: 45, millisecond: 519),
new TimeOnly(hour: 19, minute: 55, second: 57, millisecond: 967),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 121,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 20, minute: 17, second: 13, millisecond: 687),
new TimeOnly(hour: 11, minute: 43, second: 21, millisecond: 463),
new TimeOnly(hour: 17, minute: 26, second: 10, millisecond: 853),
new TimeOnly(hour: 13, minute: 44, second: 29, millisecond: 955),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 130,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 1, minute: 34, second: 5, millisecond: 251),
new TimeOnly(hour: 3, minute: 10, second: 56, millisecond: 541),
new TimeOnly(hour: 19, minute: 32, second: 24, millisecond: 36),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 73,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 16, minute: 57, second: 22, millisecond: 124),
new TimeOnly(hour: 17, minute: 5, second: 52, millisecond: 544),
new TimeOnly(hour: 10, minute: 13, second: 39, millisecond: 132),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 17, minute: 57, second: 23, millisecond: 734),
new TimeOnly(hour: 4, minute: 30, second: 16, millisecond: 837),
new TimeOnly(hour: 0, minute: 53, second: 33, millisecond: 880),
new TimeOnly(hour: 1, minute: 13, second: 4, millisecond: 415),
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
                parametr1.Value = 90;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 17;
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
                        Assert.That(models, Has.Count.EqualTo(9));
FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[21], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[22], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[23], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[24], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[25], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[5],_testData[26], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[6],_testData[27], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[7],_testData[28], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[3], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[4], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[5], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[6], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[7], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[5],_testData[8], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[6],_testData[9], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[7],_testData[10], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[8],_testData[11], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[9],_testData[12], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[10],_testData[13], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[11],_testData[14], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[12],_testData[15], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[13],_testData[16], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[14],_testData[17], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[15],_testData[18], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[16],_testData[19], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[17],_testData[20], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[18],_testData[21], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[19],_testData[22], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[20],_testData[23], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[21],_testData[24], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[22],_testData[25], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[23],_testData[26], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[24],_testData[27], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[25],_testData[28], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[26],_testData[29], false);
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
                parametr2.Value = 92;
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
                        Assert.That(models, Has.Count.EqualTo(29));
FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[1], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[2], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[3], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[4], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[5], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[5],_testData[6], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[6],_testData[7], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[7],_testData[8], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[8],_testData[9], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[9],_testData[10], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[10],_testData[11], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[11],_testData[12], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[12],_testData[13], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[13],_testData[14], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[14],_testData[15], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[15],_testData[16], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[16],_testData[17], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[17],_testData[18], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[18],_testData[19], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[19],_testData[20], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[20],_testData[21], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[21],_testData[22], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[22],_testData[23], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[23],_testData[24], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[24],_testData[25], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[25],_testData[26], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[26],_testData[27], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[27],_testData[28], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[28],_testData[29], false);
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
                parametr1.Value = 78;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 106;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));
TimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[18], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[19], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[20], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[21], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[22], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[5],_testData[23], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[6],_testData[24], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[7],_testData[25], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[8],_testData[26], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[9],_testData[27], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[10],_testData[28], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[11],_testData[29], false);
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
                parametr1.Value = 106;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 60;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
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
                foreach(var batchResult in await ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 17, query1, 72, query2))
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
                        Assert.That(models, Has.Count.EqualTo(14));
FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[16], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[17], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[18], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[19], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[20], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[5],_testData[21], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[6],_testData[22], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[7],_testData[23], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[8],_testData[24], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[9],_testData[25], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[10],_testData[26], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[11],_testData[27], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[12],_testData[28], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[13],_testData[29], false);
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
                foreach(var batchResult in  ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionDynQuerySelectModelBatch(connection, 104, query1, 109, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));
FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[24], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[25], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[26], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[27], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[28], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));
FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[26], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[27], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[28], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[29], false);
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
                foreach(var batchResult in await ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionSelectModelBatchAsync(connection, 61, 113))
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
                        Assert.That(models, Has.Count.EqualTo(3));
TimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[27], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[28], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[29], false);
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
                foreach(var batchResult in  ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionSelectModelBatch(connection, 83, 78))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));
TimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[20], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[21], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[22], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[23], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[24], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[5],_testData[25], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[6],_testData[26], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[7],_testData[27], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[8],_testData[28], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));
TimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[18], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[19], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[20], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[21], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[22], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[5],_testData[23], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[6],_testData[24], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[7],_testData[25], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[8],_testData[26], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[9],_testData[27], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[10],_testData[28], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[11],_testData[29], false);
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
                ((ITimeOnlyArraytime_without_time_zoneArray)this).SetDbConnectionSelectModelParametrs(cmd, 10);
                var models = await ((ITimeOnlyArraytime_without_time_zoneArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(28));
TimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[2], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[3], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[4], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[5], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[6], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[5],_testData[7], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[6],_testData[8], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[7],_testData[9], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[8],_testData[10], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[9],_testData[11], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[10],_testData[12], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[11],_testData[13], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[12],_testData[14], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[13],_testData[15], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[14],_testData[16], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[15],_testData[17], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[16],_testData[18], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[17],_testData[19], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[18],_testData[20], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[19],_testData[21], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[20],_testData[22], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[21],_testData[23], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[22],_testData[24], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[23],_testData[25], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[24],_testData[26], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[25],_testData[27], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[26],_testData[28], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[27],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ITimeOnlyArraytime_without_time_zoneArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((ITimeOnlyArraytime_without_time_zoneArray)this).SetDbConnectionSelectModelParametrs(cmd, 98);
                var models =  ((ITimeOnlyArraytime_without_time_zoneArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(7));
TimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[23], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[24], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[25], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[26], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[27], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[5],_testData[28], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[6],_testData[29], false);
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

