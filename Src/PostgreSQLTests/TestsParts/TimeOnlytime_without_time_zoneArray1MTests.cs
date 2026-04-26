

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
new System.TimeOnly[4]
{
new TimeOnly(hour: 4, minute: 57, second: 13, millisecond: 513),
new TimeOnly(hour: 13, minute: 15, second: 48, millisecond: 12),
new TimeOnly(hour: 0, minute: 18, second: 6, millisecond: 991),
new TimeOnly(hour: 19, minute: 42, second: 11, millisecond: 340),
},
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 3, minute: 56, second: 25, millisecond: 686),
new TimeOnly(hour: 9, minute: 4, second: 4, millisecond: 498),
new TimeOnly(hour: 15, minute: 2, second: 8, millisecond: 783),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 15,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 7, minute: 27, second: 53, millisecond: 704),
new TimeOnly(hour: 12, minute: 31, second: 20, millisecond: 321),
new TimeOnly(hour: 17, minute: 54, second: 5, millisecond: 833),
new TimeOnly(hour: 5, minute: 2, second: 18, millisecond: 562),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 1,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 2, minute: 37, second: 34, millisecond: 287),
new TimeOnly(hour: 22, minute: 31, second: 7, millisecond: 627),
new TimeOnly(hour: 21, minute: 29, second: 33, millisecond: 883),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 24,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 18, minute: 58, second: 52, millisecond: 852),
new TimeOnly(hour: 12, minute: 5, second: 39, millisecond: 928),
new TimeOnly(hour: 16, minute: 49, second: 55, millisecond: 980),
new TimeOnly(hour: 13, minute: 24, second: 42, millisecond: 542),
},
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 9, minute: 48, second: 51, millisecond: 250),
new TimeOnly(hour: 15, minute: 56, second: 58, millisecond: 511),
new TimeOnly(hour: 17, minute: 28, second: 5, millisecond: 366),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 28,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 22, minute: 48, second: 28, millisecond: 778),
new TimeOnly(hour: 10, minute: 56, second: 44, millisecond: 217),
new TimeOnly(hour: 0, minute: 57, second: 30, millisecond: 952),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 10,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 20, minute: 56, second: 55, millisecond: 521),
new TimeOnly(hour: 22, minute: 29, second: 34, millisecond: 655),
new TimeOnly(hour: 0, minute: 37, second: 28, millisecond: 232),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 17, minute: 3, second: 8, millisecond: 505),
new TimeOnly(hour: 5, minute: 26, second: 57, millisecond: 571),
new TimeOnly(hour: 2, minute: 14, second: 15, millisecond: 766),
new TimeOnly(hour: 14, minute: 24, second: 20, millisecond: 907),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 33,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 8, minute: 46, second: 19, millisecond: 60),
new TimeOnly(hour: 21, minute: 53, second: 48, millisecond: 151),
new TimeOnly(hour: 13, minute: 11, second: 1, millisecond: 920),
new TimeOnly(hour: 8, minute: 3, second: 37, millisecond: 672),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 38,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 0, minute: 41, second: 50, millisecond: 310),
new TimeOnly(hour: 8, minute: 6, second: 35, millisecond: 991),
new TimeOnly(hour: 11, minute: 21, second: 55, millisecond: 680),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 13,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 13, minute: 49, second: 27, millisecond: 833),
new TimeOnly(hour: 10, minute: 34, second: 0, millisecond: 373),
new TimeOnly(hour: 10, minute: 26, second: 41, millisecond: 852),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 47,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 21, minute: 10, second: 40, millisecond: 880),
new TimeOnly(hour: 18, minute: 50, second: 22, millisecond: 204),
new TimeOnly(hour: 22, minute: 47, second: 38, millisecond: 195),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 50,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 17, minute: 13, second: 17, millisecond: 867),
new TimeOnly(hour: 6, minute: 36, second: 34, millisecond: 834),
new TimeOnly(hour: 14, minute: 45, second: 32, millisecond: 61),
new TimeOnly(hour: 12, minute: 14, second: 29, millisecond: 797),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 17,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 3, minute: 15, second: 34, millisecond: 285),
new TimeOnly(hour: 12, minute: 13, second: 24, millisecond: 408),
new TimeOnly(hour: 3, minute: 35, second: 8, millisecond: 235),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 4, minute: 57, second: 24, millisecond: 187),
new TimeOnly(hour: 7, minute: 51, second: 32, millisecond: 269),
new TimeOnly(hour: 20, minute: 1, second: 36, millisecond: 691),
new TimeOnly(hour: 11, minute: 48, second: 20, millisecond: 585),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 52,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 6, minute: 53, second: 20, millisecond: 157),
new TimeOnly(hour: 12, minute: 23, second: 11, millisecond: 41),
new TimeOnly(hour: 17, minute: 13, second: 7, millisecond: 201),
new TimeOnly(hour: 2, minute: 9, second: 57, millisecond: 217),
},
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 4, minute: 52, second: 30, millisecond: 343),
new TimeOnly(hour: 15, minute: 5, second: 57, millisecond: 659),
new TimeOnly(hour: 1, minute: 14, second: 31, millisecond: 528),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 61,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 6, minute: 20, second: 42, millisecond: 272),
new TimeOnly(hour: 15, minute: 8, second: 38, millisecond: 252),
new TimeOnly(hour: 4, minute: 13, second: 2, millisecond: 117),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 19,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 27, second: 42, millisecond: 850),
new TimeOnly(hour: 5, minute: 28, second: 25, millisecond: 226),
new TimeOnly(hour: 11, minute: 17, second: 47, millisecond: 48),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 7, minute: 54, second: 52, millisecond: 146),
new TimeOnly(hour: 2, minute: 51, second: 28, millisecond: 852),
new TimeOnly(hour: 0, minute: 16, second: 48, millisecond: 373),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 62,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 13, minute: 21, second: 55, millisecond: 760),
new TimeOnly(hour: 9, minute: 4, second: 44, millisecond: 320),
new TimeOnly(hour: 2, minute: 50, second: 13, millisecond: 135),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 70,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 4, minute: 35, second: 10, millisecond: 447),
new TimeOnly(hour: 17, minute: 27, second: 1, millisecond: 637),
new TimeOnly(hour: 10, minute: 31, second: 52, millisecond: 410),
new TimeOnly(hour: 13, minute: 12, second: 18, millisecond: 726),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 25,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 2, minute: 49, second: 17, millisecond: 206),
new TimeOnly(hour: 13, minute: 16, second: 36, millisecond: 983),
new TimeOnly(hour: 8, minute: 57, second: 38, millisecond: 215),
},
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 21, minute: 25, second: 24, millisecond: 607),
new TimeOnly(hour: 19, minute: 43, second: 36, millisecond: 554),
new TimeOnly(hour: 18, minute: 55, second: 3, millisecond: 913),
},
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 75,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 4, minute: 23, second: 16, millisecond: 491),
new TimeOnly(hour: 22, minute: 56, second: 5, millisecond: 462),
new TimeOnly(hour: 4, minute: 44, second: 58, millisecond: 963),
new TimeOnly(hour: 13, minute: 44, second: 10, millisecond: 121),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 78,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 8, minute: 39, second: 54, millisecond: 342),
new TimeOnly(hour: 9, minute: 16, second: 20, millisecond: 713),
new TimeOnly(hour: 11, minute: 15, second: 15, millisecond: 860),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 34,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 7, minute: 33, second: 48, millisecond: 55),
new TimeOnly(hour: 0, minute: 32, second: 47, millisecond: 57),
new TimeOnly(hour: 4, minute: 45, second: 55, millisecond: 535),
},
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 1, minute: 3, second: 13, millisecond: 666),
new TimeOnly(hour: 5, minute: 4, second: 54, millisecond: 110),
new TimeOnly(hour: 2, minute: 18, second: 40, millisecond: 161),
},
},
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 12, minute: 24, second: 31, millisecond: 775),
new TimeOnly(hour: 2, minute: 11, second: 9, millisecond: 926),
new TimeOnly(hour: 7, minute: 1, second: 17, millisecond: 497),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 86,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 18, minute: 3, second: 28, millisecond: 175),
new TimeOnly(hour: 4, minute: 37, second: 52, millisecond: 301),
new TimeOnly(hour: 17, minute: 2, second: 51, millisecond: 984),
},
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 8, minute: 29, second: 8, millisecond: 708),
new TimeOnly(hour: 5, minute: 37, second: 52, millisecond: 944),
new TimeOnly(hour: 19, minute: 11, second: 12, millisecond: 960),
new TimeOnly(hour: 4, minute: 42, second: 0, millisecond: 676),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 95,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 8, minute: 14, second: 35, millisecond: 535),
new TimeOnly(hour: 14, minute: 55, second: 57, millisecond: 910),
new TimeOnly(hour: 1, minute: 3, second: 36, millisecond: 424),
new TimeOnly(hour: 1, minute: 44, second: 52, millisecond: 442),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 42,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 6, minute: 2, second: 56, millisecond: 691),
new TimeOnly(hour: 6, minute: 46, second: 33, millisecond: 620),
new TimeOnly(hour: 3, minute: 8, second: 55, millisecond: 113),
},
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 14, minute: 23, second: 25, millisecond: 237),
new TimeOnly(hour: 8, minute: 52, second: 30, millisecond: 300),
new TimeOnly(hour: 18, minute: 40, second: 30, millisecond: 425),
},
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 100,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 8, minute: 51, second: 29, millisecond: 171),
new TimeOnly(hour: 14, minute: 35, second: 8, millisecond: 62),
new TimeOnly(hour: 5, minute: 57, second: 53, millisecond: 564),
new TimeOnly(hour: 4, minute: 9, second: 14, millisecond: 354),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 103,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 12, minute: 5, second: 2, millisecond: 217),
new TimeOnly(hour: 19, minute: 6, second: 58, millisecond: 501),
new TimeOnly(hour: 13, minute: 13, second: 21, millisecond: 100),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 49,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 15, minute: 9, second: 5, millisecond: 317),
new TimeOnly(hour: 21, minute: 15, second: 13, millisecond: 400),
new TimeOnly(hour: 0, minute: 5, second: 29, millisecond: 527),
},
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 4, minute: 58, second: 54, millisecond: 232),
new TimeOnly(hour: 3, minute: 34, second: 43, millisecond: 904),
new TimeOnly(hour: 0, minute: 27, second: 47, millisecond: 152),
},
},
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 19, minute: 47, second: 32, millisecond: 183),
new TimeOnly(hour: 18, minute: 16, second: 23, millisecond: 890),
new TimeOnly(hour: 12, minute: 36, second: 18, millisecond: 558),
new TimeOnly(hour: 4, minute: 57, second: 25, millisecond: 283),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 106,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 12, minute: 43, second: 41, millisecond: 294),
new TimeOnly(hour: 1, minute: 34, second: 7, millisecond: 832),
new TimeOnly(hour: 15, minute: 38, second: 32, millisecond: 633),
new TimeOnly(hour: 14, minute: 36, second: 4, millisecond: 747),
},
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 14, minute: 15, second: 47, millisecond: 863),
new TimeOnly(hour: 6, minute: 26, second: 58, millisecond: 773),
new TimeOnly(hour: 2, minute: 38, second: 42, millisecond: 77),
new TimeOnly(hour: 7, minute: 35, second: 38, millisecond: 609),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 108,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 11, minute: 16, second: 6, millisecond: 52),
new TimeOnly(hour: 4, minute: 23, second: 33, millisecond: 755),
new TimeOnly(hour: 13, minute: 39, second: 43, millisecond: 221),
new TimeOnly(hour: 8, minute: 26, second: 32, millisecond: 695),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 54,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 0, minute: 56, second: 9, millisecond: 221),
new TimeOnly(hour: 4, minute: 6, second: 24, millisecond: 233),
new TimeOnly(hour: 21, minute: 40, second: 23, millisecond: 878),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 0, minute: 29, second: 41, millisecond: 654),
new TimeOnly(hour: 15, minute: 22, second: 16, millisecond: 509),
new TimeOnly(hour: 13, minute: 54, second: 22, millisecond: 960),
new TimeOnly(hour: 12, minute: 38, second: 44, millisecond: 342),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 111,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 17, minute: 56, second: 36, millisecond: 431),
new TimeOnly(hour: 17, minute: 27, second: 18, millisecond: 319),
new TimeOnly(hour: 21, minute: 56, second: 8, millisecond: 346),
new TimeOnly(hour: 1, minute: 9, second: 45, millisecond: 390),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 115,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 11, minute: 27, second: 31, millisecond: 855),
new TimeOnly(hour: 19, minute: 23, second: 35, millisecond: 307),
new TimeOnly(hour: 6, minute: 58, second: 24, millisecond: 666),
new TimeOnly(hour: 2, minute: 2, second: 58, millisecond: 426),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 63,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 0, minute: 3, second: 42, millisecond: 716),
new TimeOnly(hour: 3, minute: 27, second: 30, millisecond: 254),
new TimeOnly(hour: 13, minute: 25, second: 52, millisecond: 114),
},
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 20, minute: 51, second: 51, millisecond: 532),
new TimeOnly(hour: 19, minute: 6, second: 17, millisecond: 49),
new TimeOnly(hour: 21, minute: 58, second: 30, millisecond: 14),
new TimeOnly(hour: 14, minute: 57, second: 57, millisecond: 625),
},
},
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 0, minute: 28, second: 5, millisecond: 600),
new TimeOnly(hour: 9, minute: 15, second: 29, millisecond: 61),
new TimeOnly(hour: 21, minute: 33, second: 8, millisecond: 499),
new TimeOnly(hour: 8, minute: 15, second: 25, millisecond: 412),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 118,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 1, minute: 16, second: 29, millisecond: 736),
new TimeOnly(hour: 5, minute: 45, second: 30, millisecond: 78),
new TimeOnly(hour: 6, minute: 16, second: 54, millisecond: 830),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 123,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 5, minute: 57, second: 22, millisecond: 426),
new TimeOnly(hour: 3, minute: 11, second: 45, millisecond: 730),
new TimeOnly(hour: 17, minute: 11, second: 3, millisecond: 350),
new TimeOnly(hour: 18, minute: 13, second: 6, millisecond: 869),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 69,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 15, minute: 7, second: 54, millisecond: 58),
new TimeOnly(hour: 12, minute: 44, second: 56, millisecond: 24),
new TimeOnly(hour: 17, minute: 24, second: 39, millisecond: 604),
new TimeOnly(hour: 21, minute: 39, second: 38, millisecond: 977),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 0, minute: 18, second: 46, millisecond: 440),
new TimeOnly(hour: 11, minute: 52, second: 55, millisecond: 329),
new TimeOnly(hour: 9, minute: 51, second: 47, millisecond: 711),
new TimeOnly(hour: 4, minute: 28, second: 49, millisecond: 411),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 132,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 8, minute: 52, second: 37, millisecond: 872),
new TimeOnly(hour: 22, minute: 56, second: 38, millisecond: 944),
new TimeOnly(hour: 18, minute: 37, second: 10, millisecond: 309),
},
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 10, minute: 12, second: 58, millisecond: 384),
new TimeOnly(hour: 13, minute: 43, second: 56, millisecond: 712),
new TimeOnly(hour: 15, minute: 33, second: 1, millisecond: 924),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 133,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 11, minute: 4, second: 12, millisecond: 187),
new TimeOnly(hour: 20, minute: 16, second: 1, millisecond: 354),
new TimeOnly(hour: 11, minute: 50, second: 25, millisecond: 360),
new TimeOnly(hour: 13, minute: 51, second: 38, millisecond: 464),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 73,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 21, minute: 39, second: 49, millisecond: 709),
new TimeOnly(hour: 20, minute: 7, second: 22, millisecond: 889),
new TimeOnly(hour: 11, minute: 47, second: 4, millisecond: 629),
new TimeOnly(hour: 18, minute: 38, second: 3, millisecond: 701),
},
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 5, minute: 19, second: 51, millisecond: 726),
new TimeOnly(hour: 14, minute: 42, second: 9, millisecond: 140),
new TimeOnly(hour: 6, minute: 20, second: 11, millisecond: 381),
new TimeOnly(hour: 13, minute: 44, second: 35, millisecond: 354),
},
},
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 19, minute: 53, second: 48, millisecond: 1),
new TimeOnly(hour: 21, minute: 38, second: 9, millisecond: 185),
new TimeOnly(hour: 2, minute: 47, second: 34, millisecond: 227),
new TimeOnly(hour: 5, minute: 24, second: 36, millisecond: 35),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 135,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 2, minute: 27, second: 36, millisecond: 724),
new TimeOnly(hour: 8, minute: 6, second: 4, millisecond: 705),
new TimeOnly(hour: 20, minute: 44, second: 12, millisecond: 578),
},
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 13, minute: 10, second: 18, millisecond: 900),
new TimeOnly(hour: 8, minute: 43, second: 30, millisecond: 390),
new TimeOnly(hour: 13, minute: 42, second: 31, millisecond: 475),
new TimeOnly(hour: 0, minute: 46, second: 27, millisecond: 747),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 143,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 13, minute: 58, second: 48, millisecond: 9),
new TimeOnly(hour: 18, minute: 14, second: 27, millisecond: 519),
new TimeOnly(hour: 14, minute: 56, second: 12, millisecond: 930),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 78,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 11, minute: 36, second: 25, millisecond: 865),
new TimeOnly(hour: 21, minute: 36, second: 41, millisecond: 207),
new TimeOnly(hour: 21, minute: 49, second: 9, millisecond: 564),
new TimeOnly(hour: 9, minute: 5, second: 29, millisecond: 39),
},
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 2, minute: 52, second: 56, millisecond: 278),
new TimeOnly(hour: 17, minute: 2, second: 32, millisecond: 967),
new TimeOnly(hour: 10, minute: 0, second: 55, millisecond: 208),
new TimeOnly(hour: 20, minute: 2, second: 29, millisecond: 773),
},
},
    NullableValue = null,
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 145,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 15, minute: 22, second: 15, millisecond: 939),
new TimeOnly(hour: 1, minute: 56, second: 51, millisecond: 466),
new TimeOnly(hour: 19, minute: 53, second: 27, millisecond: 861),
},
    ModelInner = null,
    NullableValue = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 4, minute: 11, second: 3, millisecond: 386),
new TimeOnly(hour: 21, minute: 3, second: 11, millisecond: 523),
new TimeOnly(hour: 20, minute: 27, second: 28, millisecond: 995),
},
},
            new TimeOnlytime_without_time_zoneArray1M
{
    Id = 150,
    Value = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 10, minute: 48, second: 48, millisecond: 950),
new TimeOnly(hour: 22, minute: 30, second: 33, millisecond: 498),
new TimeOnly(hour: 11, minute: 55, second: 5, millisecond: 736),
new TimeOnly(hour: 8, minute: 16, second: 3, millisecond: 739),
},
    ModelInner = new TimeOnlytime_without_time_zoneArray1MI
{
    Id = 79,
    Value = 
new System.TimeOnly[3]
{
new TimeOnly(hour: 2, minute: 56, second: 24, millisecond: 284),
new TimeOnly(hour: 4, minute: 53, second: 24, millisecond: 331),
new TimeOnly(hour: 1, minute: 16, second: 13, millisecond: 698),
},
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 16, minute: 29, second: 28, millisecond: 609),
new TimeOnly(hour: 14, minute: 8, second: 37, millisecond: 909),
new TimeOnly(hour: 20, minute: 34, second: 12, millisecond: 813),
new TimeOnly(hour: 2, minute: 28, second: 42, millisecond: 558),
},
},
    NullableValue = 
new System.TimeOnly[4]
{
new TimeOnly(hour: 16, minute: 12, second: 6, millisecond: 424),
new TimeOnly(hour: 9, minute: 36, second: 11, millisecond: 820),
new TimeOnly(hour: 16, minute: 33, second: 7, millisecond: 412),
new TimeOnly(hour: 12, minute: 38, second: 7, millisecond: 916),
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
                parametr1.Value = 62;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 123;
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
                        Assert.That(models, Has.Count.EqualTo(19));
FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[11], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[12], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[13], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[14], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[15], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[5],_testData[16], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[6],_testData[17], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[7],_testData[18], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[8],_testData[19], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[9],_testData[20], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[10],_testData[21], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[11],_testData[22], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[12],_testData[23], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[13],_testData[24], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[14],_testData[25], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[15],_testData[26], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[16],_testData[27], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[17],_testData[28], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));
FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[24], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[25], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[26], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[27], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[28], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[5],_testData[29], false);
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
                parametr1.Value = 61;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 106;
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
                        Assert.That(models, Has.Count.EqualTo(20));
FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[10], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[11], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[12], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[13], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[14], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[5],_testData[15], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[6],_testData[16], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[7],_testData[17], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[8],_testData[18], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[9],_testData[19], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[10],_testData[20], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[11],_testData[21], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[12],_testData[22], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[13],_testData[23], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[14],_testData[24], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[15],_testData[25], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[16],_testData[26], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[17],_testData[27], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[18],_testData[28], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));
FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[19], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[20], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[21], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[22], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[23], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[5],_testData[24], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[6],_testData[25], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[7],_testData[26], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[8],_testData[27], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[9],_testData[28], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[10],_testData[29], false);
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
                parametr1.Value = 115;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 62;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));
TimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[22], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[23], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[24], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[25], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[26], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[5],_testData[27], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[6],_testData[28], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[7],_testData[29], false);
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
                parametr1.Value = 15;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 38;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));
TimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[2], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[3], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[4], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[5], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[6], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[5],_testData[7], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[6],_testData[8], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[7],_testData[9], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[8],_testData[10], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[9],_testData[11], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[10],_testData[12], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[11],_testData[13], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[12],_testData[14], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[13],_testData[15], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[14],_testData[16], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[15],_testData[17], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[16],_testData[18], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[17],_testData[19], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[18],_testData[20], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[19],_testData[21], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[20],_testData[22], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[21],_testData[23], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[22],_testData[24], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[23],_testData[25], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[24],_testData[26], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[25],_testData[27], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[26],_testData[28], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
TimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[6], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[7], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[8], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[9], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[10], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[5],_testData[11], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[6],_testData[12], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[7],_testData[13], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[8],_testData[14], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[9],_testData[15], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[10],_testData[16], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[11],_testData[17], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[12],_testData[18], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[13],_testData[19], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[14],_testData[20], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[15],_testData[21], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[16],_testData[22], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[17],_testData[23], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[18],_testData[24], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[19],_testData[25], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[20],_testData[26], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[21],_testData[27], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[22],_testData[28], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[23],_testData[29], false);
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
                foreach(var batchResult in await ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 75, query1, 6, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));
FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[13], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[14], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[15], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[16], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[17], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[5],_testData[18], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[6],_testData[19], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[7],_testData[20], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[8],_testData[21], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[9],_testData[22], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[10],_testData[23], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[11],_testData[24], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[12],_testData[25], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[13],_testData[26], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[14],_testData[27], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[15],_testData[28], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[16],_testData[29], false);
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
                foreach(var batchResult in  ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionDynQuerySelectModelBatch(connection, 50, query1, 6, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));
FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[8], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[9], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[10], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[11], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[12], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[5],_testData[13], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[6],_testData[14], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[7],_testData[15], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[8],_testData[16], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[9],_testData[17], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[10],_testData[18], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[11],_testData[19], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[12],_testData[20], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[13],_testData[21], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[14],_testData[22], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[15],_testData[23], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[16],_testData[24], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[17],_testData[25], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[18],_testData[26], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[19],_testData[27], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[20],_testData[28], false);FlatTimeOnlytime_without_time_zoneArray1M.AssertModel(models[21],_testData[29], false);
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
                foreach(var batchResult in await ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionSelectModelBatchAsync(connection, 52, 106))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));
TimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[9], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[10], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[11], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[12], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[13], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[5],_testData[14], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[6],_testData[15], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[7],_testData[16], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[8],_testData[17], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[9],_testData[18], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[10],_testData[19], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[11],_testData[20], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[12],_testData[21], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[13],_testData[22], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[14],_testData[23], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[15],_testData[24], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[16],_testData[25], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[17],_testData[26], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[18],_testData[27], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[19],_testData[28], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));
TimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[19], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[20], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[21], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[22], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[23], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[5],_testData[24], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[6],_testData[25], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[7],_testData[26], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[8],_testData[27], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[9],_testData[28], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[10],_testData[29], false);
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
                foreach(var batchResult in  ((ITimeOnlyArraytime_without_time_zoneArray)this).DbConnectionSelectModelBatch(connection, 70, 86))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
TimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[12], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[13], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[14], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[15], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[16], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[5],_testData[17], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[6],_testData[18], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[7],_testData[19], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[8],_testData[20], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[9],_testData[21], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[10],_testData[22], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[11],_testData[23], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[12],_testData[24], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[13],_testData[25], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[14],_testData[26], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[15],_testData[27], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[16],_testData[28], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[17],_testData[29], false);
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

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((ITimeOnlyArraytime_without_time_zoneArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((ITimeOnlyArraytime_without_time_zoneArray)this).SetDbConnectionSelectModelParametrs(cmd, 115);
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
                ((ITimeOnlyArraytime_without_time_zoneArray)this).SetDbConnectionSelectModelParametrs(cmd, 62);
                var models =  ((ITimeOnlyArraytime_without_time_zoneArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(19));
TimeOnlytime_without_time_zoneArray1M.AssertModel(models[0],_testData[11], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[1],_testData[12], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[2],_testData[13], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[3],_testData[14], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[4],_testData[15], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[5],_testData[16], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[6],_testData[17], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[7],_testData[18], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[8],_testData[19], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[9],_testData[20], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[10],_testData[21], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[11],_testData[22], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[12],_testData[23], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[13],_testData[24], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[14],_testData[25], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[15],_testData[26], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[16],_testData[27], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[17],_testData[28], false);TimeOnlytime_without_time_zoneArray1M.AssertModel(models[18],_testData[29], false);
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

