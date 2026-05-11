

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
    internal partial interface ITimeSpanMArrayintervalMMArrayD1
    {
    }
    
    internal partial class TimeSpanMArrayintervalMMArrayD1 : ITimeSpanMArrayintervalMMArrayD1
    {


#region TestData

        private readonly TimeSpanintervalMMArrayD1E1M[] _testData = new TimeSpanintervalMMArrayD1E1M[]
        {
            new TimeSpanintervalMMArrayD1E1M
{
    Id = 5,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 22, seconds: 48, milliseconds: 741),
new TimeSpan(days: 0, hours: 4, minutes: 8, seconds: 6, milliseconds: 539),
new TimeSpan(days: 0, hours: 6, minutes: 21, seconds: 44, milliseconds: 135),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 12, minutes: 24, seconds: 55, milliseconds: 801),
new TimeSpan(days: 0, hours: 18, minutes: 16, seconds: 4, milliseconds: 76),
new TimeSpan(days: 0, hours: 5, minutes: 36, seconds: 24, milliseconds: 9),
},
},
            new TimeSpanintervalMMArrayD1E1M
{
    Id = 14,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 38, seconds: 16, milliseconds: 411),
new TimeSpan(days: 0, hours: 16, minutes: 36, seconds: 44, milliseconds: 982),
new TimeSpan(days: 0, hours: 1, minutes: 53, seconds: 14, milliseconds: 591),
new TimeSpan(days: 0, hours: 9, minutes: 15, seconds: 42, milliseconds: 414),
},
    ModelInner = new TimeSpanintervalMMArrayD1E1MI
{
    Id = 5,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 8, minutes: 52, seconds: 48, milliseconds: 928),
new TimeSpan(days: 0, hours: 0, minutes: 5, seconds: 12, milliseconds: 856),
new TimeSpan(days: 0, hours: 2, minutes: 1, seconds: 50, milliseconds: 939),
new TimeSpan(days: 0, hours: 10, minutes: 26, seconds: 0, milliseconds: 360),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 5, seconds: 22, milliseconds: 304),
new TimeSpan(days: 0, hours: 12, minutes: 53, seconds: 34, milliseconds: 224),
new TimeSpan(days: 0, hours: 20, minutes: 49, seconds: 52, milliseconds: 737),
new TimeSpan(days: 0, hours: 10, minutes: 0, seconds: 50, milliseconds: 689),
},
},
            new TimeSpanintervalMMArrayD1E1M
{
    Id = 18,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 20, minutes: 35, seconds: 30, milliseconds: 897),
new TimeSpan(days: 0, hours: 19, minutes: 46, seconds: 51, milliseconds: 49),
new TimeSpan(days: 0, hours: 5, minutes: 6, seconds: 44, milliseconds: 128),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 18, minutes: 6, seconds: 54, milliseconds: 850),
new TimeSpan(days: 0, hours: 10, minutes: 45, seconds: 30, milliseconds: 425),
new TimeSpan(days: 0, hours: 11, minutes: 43, seconds: 41, milliseconds: 519),
},
},
            new TimeSpanintervalMMArrayD1E1M
{
    Id = 24,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 6, minutes: 13, seconds: 27, milliseconds: 775),
new TimeSpan(days: 0, hours: 3, minutes: 20, seconds: 17, milliseconds: 701),
new TimeSpan(days: 0, hours: 5, minutes: 35, seconds: 46, milliseconds: 253),
},
    ModelInner = new TimeSpanintervalMMArrayD1E1MI
{
    Id = 9,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 19, minutes: 47, seconds: 31, milliseconds: 166),
new TimeSpan(days: 0, hours: 16, minutes: 32, seconds: 14, milliseconds: 988),
new TimeSpan(days: 0, hours: 20, minutes: 6, seconds: 23, milliseconds: 886),
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 2, minutes: 38, seconds: 42, milliseconds: 719),
new TimeSpan(days: 0, hours: 18, minutes: 46, seconds: 13, milliseconds: 621),
new TimeSpan(days: 0, hours: 4, minutes: 35, seconds: 50, milliseconds: 98),
new TimeSpan(days: 0, hours: 5, minutes: 38, seconds: 30, milliseconds: 822),
},
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 6, minutes: 25, seconds: 14, milliseconds: 834),
new TimeSpan(days: 0, hours: 7, minutes: 57, seconds: 16, milliseconds: 511),
new TimeSpan(days: 0, hours: 7, minutes: 25, seconds: 18, milliseconds: 385),
},
},
            new TimeSpanintervalMMArrayD1E1M
{
    Id = 32,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 15, minutes: 17, seconds: 15, milliseconds: 469),
new TimeSpan(days: 0, hours: 15, minutes: 53, seconds: 0, milliseconds: 945),
new TimeSpan(days: 0, hours: 19, minutes: 53, seconds: 55, milliseconds: 786),
new TimeSpan(days: 0, hours: 4, minutes: 20, seconds: 31, milliseconds: 207),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalMMArrayD1E1M
{
    Id = 34,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 12, minutes: 14, seconds: 2, milliseconds: 661),
new TimeSpan(days: 0, hours: 20, minutes: 9, seconds: 9, milliseconds: 417),
new TimeSpan(days: 0, hours: 17, minutes: 10, seconds: 8, milliseconds: 305),
new TimeSpan(days: 0, hours: 19, minutes: 10, seconds: 55, milliseconds: 253),
},
    ModelInner = new TimeSpanintervalMMArrayD1E1MI
{
    Id = 13,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 4, minutes: 44, seconds: 19, milliseconds: 340),
new TimeSpan(days: 0, hours: 12, minutes: 10, seconds: 27, milliseconds: 381),
new TimeSpan(days: 0, hours: 2, minutes: 52, seconds: 0, milliseconds: 602),
new TimeSpan(days: 0, hours: 15, minutes: 19, seconds: 28, milliseconds: 298),
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 22, minutes: 22, seconds: 43, milliseconds: 85),
new TimeSpan(days: 0, hours: 12, minutes: 22, seconds: 4, milliseconds: 525),
new TimeSpan(days: 0, hours: 4, minutes: 38, seconds: 7, milliseconds: 480),
new TimeSpan(days: 0, hours: 13, minutes: 43, seconds: 42, milliseconds: 74),
},
},
    NullableValue = null,
},
            new TimeSpanintervalMMArrayD1E1M
{
    Id = 35,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 18, minutes: 50, seconds: 44, milliseconds: 787),
new TimeSpan(days: 0, hours: 7, minutes: 46, seconds: 14, milliseconds: 661),
new TimeSpan(days: 0, hours: 19, minutes: 0, seconds: 9, milliseconds: 443),
new TimeSpan(days: 0, hours: 11, minutes: 8, seconds: 43, milliseconds: 480),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalMMArrayD1E1M
{
    Id = 41,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 2, minutes: 49, seconds: 0, milliseconds: 804),
new TimeSpan(days: 0, hours: 18, minutes: 39, seconds: 5, milliseconds: 154),
new TimeSpan(days: 0, hours: 16, minutes: 36, seconds: 9, milliseconds: 991),
new TimeSpan(days: 0, hours: 14, minutes: 53, seconds: 6, milliseconds: 171),
},
    ModelInner = new TimeSpanintervalMMArrayD1E1MI
{
    Id = 14,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 9, minutes: 51, seconds: 52, milliseconds: 336),
new TimeSpan(days: 0, hours: 13, minutes: 8, seconds: 26, milliseconds: 52),
new TimeSpan(days: 0, hours: 7, minutes: 20, seconds: 11, milliseconds: 983),
new TimeSpan(days: 0, hours: 10, minutes: 9, seconds: 33, milliseconds: 578),
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 19, minutes: 5, seconds: 42, milliseconds: 197),
new TimeSpan(days: 0, hours: 11, minutes: 20, seconds: 14, milliseconds: 781),
new TimeSpan(days: 0, hours: 22, minutes: 40, seconds: 18, milliseconds: 947),
},
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 25, seconds: 45, milliseconds: 647),
new TimeSpan(days: 0, hours: 19, minutes: 1, seconds: 8, milliseconds: 477),
new TimeSpan(days: 0, hours: 20, minutes: 23, seconds: 5, milliseconds: 214),
},
},
            new TimeSpanintervalMMArrayD1E1M
{
    Id = 44,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 17, minutes: 0, seconds: 56, milliseconds: 390),
new TimeSpan(days: 0, hours: 19, minutes: 42, seconds: 49, milliseconds: 637),
new TimeSpan(days: 0, hours: 18, minutes: 50, seconds: 18, milliseconds: 478),
new TimeSpan(days: 0, hours: 21, minutes: 2, seconds: 54, milliseconds: 732),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalMMArrayD1E1M
{
    Id = 49,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 12, minutes: 55, seconds: 35, milliseconds: 600),
new TimeSpan(days: 0, hours: 19, minutes: 39, seconds: 29, milliseconds: 659),
new TimeSpan(days: 0, hours: 12, minutes: 15, seconds: 3, milliseconds: 601),
},
    ModelInner = new TimeSpanintervalMMArrayD1E1MI
{
    Id = 17,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 4, minutes: 41, seconds: 50, milliseconds: 683),
new TimeSpan(days: 0, hours: 7, minutes: 54, seconds: 1, milliseconds: 457),
new TimeSpan(days: 0, hours: 1, minutes: 44, seconds: 34, milliseconds: 225),
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 25, seconds: 51, milliseconds: 641),
new TimeSpan(days: 0, hours: 4, minutes: 58, seconds: 10, milliseconds: 884),
new TimeSpan(days: 0, hours: 14, minutes: 4, seconds: 4, milliseconds: 227),
new TimeSpan(days: 0, hours: 4, minutes: 56, seconds: 23, milliseconds: 180),
},
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 55, seconds: 1, milliseconds: 153),
new TimeSpan(days: 0, hours: 18, minutes: 11, seconds: 41, milliseconds: 636),
new TimeSpan(days: 0, hours: 16, minutes: 9, seconds: 42, milliseconds: 848),
},
},
            new TimeSpanintervalMMArrayD1E1M
{
    Id = 57,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 5, minutes: 2, seconds: 37, milliseconds: 168),
new TimeSpan(days: 0, hours: 2, minutes: 5, seconds: 9, milliseconds: 736),
new TimeSpan(days: 0, hours: 9, minutes: 52, seconds: 12, milliseconds: 617),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalMMArrayD1E1M
{
    Id = 64,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 19, minutes: 29, seconds: 3, milliseconds: 948),
new TimeSpan(days: 0, hours: 14, minutes: 3, seconds: 44, milliseconds: 199),
new TimeSpan(days: 0, hours: 14, minutes: 29, seconds: 33, milliseconds: 801),
},
    ModelInner = new TimeSpanintervalMMArrayD1E1MI
{
    Id = 20,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 2, seconds: 53, milliseconds: 170),
new TimeSpan(days: 0, hours: 7, minutes: 34, seconds: 36, milliseconds: 799),
new TimeSpan(days: 0, hours: 14, minutes: 30, seconds: 26, milliseconds: 639),
new TimeSpan(days: 0, hours: 6, minutes: 35, seconds: 41, milliseconds: 963),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalMMArrayD1E1M
{
    Id = 66,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 12, minutes: 3, seconds: 23, milliseconds: 627),
new TimeSpan(days: 0, hours: 18, minutes: 15, seconds: 32, milliseconds: 892),
new TimeSpan(days: 0, hours: 20, minutes: 24, seconds: 49, milliseconds: 701),
new TimeSpan(days: 0, hours: 14, minutes: 56, seconds: 2, milliseconds: 40),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalMMArrayD1E1M
{
    Id = 67,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 13, minutes: 11, seconds: 23, milliseconds: 355),
new TimeSpan(days: 0, hours: 10, minutes: 37, seconds: 33, milliseconds: 825),
new TimeSpan(days: 0, hours: 17, minutes: 29, seconds: 54, milliseconds: 711),
},
    ModelInner = new TimeSpanintervalMMArrayD1E1MI
{
    Id = 27,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 12, minutes: 29, seconds: 47, milliseconds: 766),
new TimeSpan(days: 0, hours: 17, minutes: 41, seconds: 44, milliseconds: 114),
new TimeSpan(days: 0, hours: 17, minutes: 1, seconds: 40, milliseconds: 946),
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 9, minutes: 49, seconds: 13, milliseconds: 266),
new TimeSpan(days: 0, hours: 18, minutes: 55, seconds: 40, milliseconds: 947),
new TimeSpan(days: 0, hours: 20, minutes: 3, seconds: 4, milliseconds: 300),
},
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 3, minutes: 28, seconds: 25, milliseconds: 665),
new TimeSpan(days: 0, hours: 12, minutes: 3, seconds: 48, milliseconds: 841),
new TimeSpan(days: 0, hours: 19, minutes: 8, seconds: 54, milliseconds: 69),
},
},
            new TimeSpanintervalMMArrayD1E1M
{
    Id = 69,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 6, minutes: 42, seconds: 25, milliseconds: 754),
new TimeSpan(days: 0, hours: 2, minutes: 9, seconds: 37, milliseconds: 713),
new TimeSpan(days: 0, hours: 10, minutes: 2, seconds: 13, milliseconds: 267),
new TimeSpan(days: 0, hours: 15, minutes: 53, seconds: 1, milliseconds: 280),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalMMArrayD1E1M
{
    Id = 73,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 50, seconds: 19, milliseconds: 808),
new TimeSpan(days: 0, hours: 14, minutes: 28, seconds: 31, milliseconds: 505),
new TimeSpan(days: 0, hours: 16, minutes: 25, seconds: 51, milliseconds: 141),
new TimeSpan(days: 0, hours: 4, minutes: 50, seconds: 37, milliseconds: 746),
},
    ModelInner = new TimeSpanintervalMMArrayD1E1MI
{
    Id = 29,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 14, minutes: 52, seconds: 38, milliseconds: 172),
new TimeSpan(days: 0, hours: 1, minutes: 48, seconds: 39, milliseconds: 242),
new TimeSpan(days: 0, hours: 12, minutes: 12, seconds: 57, milliseconds: 12),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalMMArrayD1E1M
{
    Id = 79,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 6, minutes: 48, seconds: 4, milliseconds: 866),
new TimeSpan(days: 0, hours: 2, minutes: 13, seconds: 10, milliseconds: 954),
new TimeSpan(days: 0, hours: 2, minutes: 7, seconds: 4, milliseconds: 767),
new TimeSpan(days: 0, hours: 0, minutes: 27, seconds: 32, milliseconds: 49),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 8, seconds: 56, milliseconds: 546),
new TimeSpan(days: 0, hours: 20, minutes: 19, seconds: 12, milliseconds: 532),
new TimeSpan(days: 0, hours: 21, minutes: 7, seconds: 48, milliseconds: 741),
new TimeSpan(days: 0, hours: 13, minutes: 33, seconds: 48, milliseconds: 516),
},
},
            new TimeSpanintervalMMArrayD1E1M
{
    Id = 82,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 12, minutes: 7, seconds: 28, milliseconds: 843),
new TimeSpan(days: 0, hours: 18, minutes: 30, seconds: 42, milliseconds: 934),
new TimeSpan(days: 0, hours: 22, minutes: 41, seconds: 2, milliseconds: 311),
new TimeSpan(days: 0, hours: 13, minutes: 36, seconds: 53, milliseconds: 394),
},
    ModelInner = new TimeSpanintervalMMArrayD1E1MI
{
    Id = 31,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 6, minutes: 49, seconds: 42, milliseconds: 42),
new TimeSpan(days: 0, hours: 22, minutes: 23, seconds: 47, milliseconds: 344),
new TimeSpan(days: 0, hours: 18, minutes: 21, seconds: 46, milliseconds: 558),
new TimeSpan(days: 0, hours: 2, minutes: 1, seconds: 17, milliseconds: 152),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 26, seconds: 56, milliseconds: 529),
new TimeSpan(days: 0, hours: 14, minutes: 32, seconds: 32, milliseconds: 812),
new TimeSpan(days: 0, hours: 1, minutes: 19, seconds: 14, milliseconds: 973),
new TimeSpan(days: 0, hours: 18, minutes: 0, seconds: 41, milliseconds: 660),
},
},
            new TimeSpanintervalMMArrayD1E1M
{
    Id = 85,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 3, minutes: 21, seconds: 0, milliseconds: 746),
new TimeSpan(days: 0, hours: 0, minutes: 36, seconds: 46, milliseconds: 463),
new TimeSpan(days: 0, hours: 8, minutes: 33, seconds: 27, milliseconds: 215),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 19, minutes: 26, seconds: 50, milliseconds: 923),
new TimeSpan(days: 0, hours: 8, minutes: 19, seconds: 57, milliseconds: 554),
new TimeSpan(days: 0, hours: 12, minutes: 41, seconds: 30, milliseconds: 970),
},
},
            new TimeSpanintervalMMArrayD1E1M
{
    Id = 87,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 44, seconds: 3, milliseconds: 889),
new TimeSpan(days: 0, hours: 0, minutes: 45, seconds: 29, milliseconds: 947),
new TimeSpan(days: 0, hours: 22, minutes: 42, seconds: 45, milliseconds: 706),
},
    ModelInner = new TimeSpanintervalMMArrayD1E1MI
{
    Id = 33,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 22, minutes: 33, seconds: 21, milliseconds: 543),
new TimeSpan(days: 0, hours: 6, minutes: 42, seconds: 51, milliseconds: 368),
new TimeSpan(days: 0, hours: 0, minutes: 13, seconds: 35, milliseconds: 424),
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 20, minutes: 20, seconds: 45, milliseconds: 683),
new TimeSpan(days: 0, hours: 3, minutes: 40, seconds: 34, milliseconds: 754),
new TimeSpan(days: 0, hours: 11, minutes: 39, seconds: 57, milliseconds: 174),
new TimeSpan(days: 0, hours: 0, minutes: 25, seconds: 45, milliseconds: 23),
},
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 1, minutes: 24, seconds: 2, milliseconds: 327),
new TimeSpan(days: 0, hours: 16, minutes: 25, seconds: 54, milliseconds: 190),
new TimeSpan(days: 0, hours: 8, minutes: 42, seconds: 13, milliseconds: 287),
},
},
            new TimeSpanintervalMMArrayD1E1M
{
    Id = 88,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 22, minutes: 6, seconds: 19, milliseconds: 112),
new TimeSpan(days: 0, hours: 5, minutes: 38, seconds: 35, milliseconds: 407),
new TimeSpan(days: 0, hours: 13, minutes: 56, seconds: 31, milliseconds: 550),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalMMArrayD1E1M
{
    Id = 93,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 5, minutes: 57, seconds: 41, milliseconds: 476),
new TimeSpan(days: 0, hours: 2, minutes: 55, seconds: 47, milliseconds: 125),
new TimeSpan(days: 0, hours: 19, minutes: 5, seconds: 16, milliseconds: 130),
},
    ModelInner = new TimeSpanintervalMMArrayD1E1MI
{
    Id = 38,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 22, minutes: 44, seconds: 21, milliseconds: 963),
new TimeSpan(days: 0, hours: 10, minutes: 34, seconds: 32, milliseconds: 322),
new TimeSpan(days: 0, hours: 12, minutes: 4, seconds: 12, milliseconds: 226),
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 5, minutes: 44, seconds: 53, milliseconds: 829),
new TimeSpan(days: 0, hours: 0, minutes: 28, seconds: 49, milliseconds: 211),
new TimeSpan(days: 0, hours: 2, minutes: 26, seconds: 0, milliseconds: 207),
},
},
    NullableValue = null,
},
            new TimeSpanintervalMMArrayD1E1M
{
    Id = 95,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 31, seconds: 37, milliseconds: 380),
new TimeSpan(days: 0, hours: 8, minutes: 14, seconds: 1, milliseconds: 274),
new TimeSpan(days: 0, hours: 10, minutes: 16, seconds: 24, milliseconds: 317),
new TimeSpan(days: 0, hours: 19, minutes: 28, seconds: 17, milliseconds: 265),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalMMArrayD1E1M
{
    Id = 102,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 6, minutes: 24, seconds: 0, milliseconds: 833),
new TimeSpan(days: 0, hours: 15, minutes: 55, seconds: 17, milliseconds: 440),
new TimeSpan(days: 0, hours: 13, minutes: 14, seconds: 0, milliseconds: 24),
},
    ModelInner = new TimeSpanintervalMMArrayD1E1MI
{
    Id = 43,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 21, seconds: 26, milliseconds: 343),
new TimeSpan(days: 0, hours: 12, minutes: 13, seconds: 26, milliseconds: 64),
new TimeSpan(days: 0, hours: 4, minutes: 21, seconds: 43, milliseconds: 597),
new TimeSpan(days: 0, hours: 12, minutes: 18, seconds: 51, milliseconds: 703),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalMMArrayD1E1M
{
    Id = 107,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 3, minutes: 55, seconds: 23, milliseconds: 672),
new TimeSpan(days: 0, hours: 5, minutes: 15, seconds: 30, milliseconds: 878),
new TimeSpan(days: 0, hours: 2, minutes: 36, seconds: 50, milliseconds: 74),
new TimeSpan(days: 0, hours: 6, minutes: 30, seconds: 6, milliseconds: 24),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 18, minutes: 10, seconds: 27, milliseconds: 0),
new TimeSpan(days: 0, hours: 14, minutes: 13, seconds: 38, milliseconds: 65),
new TimeSpan(days: 0, hours: 4, minutes: 24, seconds: 49, milliseconds: 508),
},
},
            new TimeSpanintervalMMArrayD1E1M
{
    Id = 116,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 26, seconds: 45, milliseconds: 653),
new TimeSpan(days: 0, hours: 0, minutes: 29, seconds: 34, milliseconds: 386),
new TimeSpan(days: 0, hours: 8, minutes: 8, seconds: 12, milliseconds: 247),
new TimeSpan(days: 0, hours: 8, minutes: 3, seconds: 1, milliseconds: 732),
},
    ModelInner = new TimeSpanintervalMMArrayD1E1MI
{
    Id = 52,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 4, minutes: 53, seconds: 32, milliseconds: 142),
new TimeSpan(days: 0, hours: 9, minutes: 8, seconds: 13, milliseconds: 934),
new TimeSpan(days: 0, hours: 3, minutes: 37, seconds: 48, milliseconds: 252),
new TimeSpan(days: 0, hours: 12, minutes: 29, seconds: 37, milliseconds: 249),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 4, minutes: 50, seconds: 54, milliseconds: 816),
new TimeSpan(days: 0, hours: 2, minutes: 33, seconds: 17, milliseconds: 162),
new TimeSpan(days: 0, hours: 5, minutes: 37, seconds: 6, milliseconds: 403),
},
},
            new TimeSpanintervalMMArrayD1E1M
{
    Id = 124,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 5, minutes: 12, seconds: 9, milliseconds: 330),
new TimeSpan(days: 0, hours: 21, minutes: 1, seconds: 44, milliseconds: 539),
new TimeSpan(days: 0, hours: 8, minutes: 17, seconds: 54, milliseconds: 431),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 6, minutes: 40, seconds: 1, milliseconds: 209),
new TimeSpan(days: 0, hours: 3, minutes: 20, seconds: 34, milliseconds: 746),
new TimeSpan(days: 0, hours: 6, minutes: 34, seconds: 43, milliseconds: 896),
new TimeSpan(days: 0, hours: 21, minutes: 47, seconds: 5, milliseconds: 163),
},
},
            new TimeSpanintervalMMArrayD1E1M
{
    Id = 127,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 11, minutes: 27, seconds: 46, milliseconds: 861),
new TimeSpan(days: 0, hours: 10, minutes: 55, seconds: 14, milliseconds: 615),
new TimeSpan(days: 0, hours: 7, minutes: 34, seconds: 23, milliseconds: 528),
new TimeSpan(days: 0, hours: 19, minutes: 30, seconds: 52, milliseconds: 893),
},
    ModelInner = new TimeSpanintervalMMArrayD1E1MI
{
    Id = 57,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 18, minutes: 58, seconds: 2, milliseconds: 181),
new TimeSpan(days: 0, hours: 0, minutes: 13, seconds: 58, milliseconds: 911),
new TimeSpan(days: 0, hours: 16, minutes: 45, seconds: 10, milliseconds: 868),
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 42, seconds: 55, milliseconds: 250),
new TimeSpan(days: 0, hours: 13, minutes: 21, seconds: 0, milliseconds: 150),
new TimeSpan(days: 0, hours: 0, minutes: 38, seconds: 12, milliseconds: 488),
},
},
    NullableValue = null,
},
            new TimeSpanintervalMMArrayD1E1M
{
    Id = 132,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 16, minutes: 27, seconds: 27, milliseconds: 537),
new TimeSpan(days: 0, hours: 21, minutes: 57, seconds: 2, milliseconds: 17),
new TimeSpan(days: 0, hours: 22, minutes: 39, seconds: 35, milliseconds: 553),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 6, minutes: 39, seconds: 53, milliseconds: 311),
new TimeSpan(days: 0, hours: 15, minutes: 52, seconds: 44, milliseconds: 977),
new TimeSpan(days: 0, hours: 11, minutes: 15, seconds: 58, milliseconds: 247),
},
},
            new TimeSpanintervalMMArrayD1E1M
{
    Id = 133,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 12, minutes: 34, seconds: 22, milliseconds: 106),
new TimeSpan(days: 0, hours: 18, minutes: 6, seconds: 51, milliseconds: 520),
new TimeSpan(days: 0, hours: 18, minutes: 8, seconds: 33, milliseconds: 283),
new TimeSpan(days: 0, hours: 13, minutes: 39, seconds: 2, milliseconds: 664),
},
    ModelInner = new TimeSpanintervalMMArrayD1E1MI
{
    Id = 66,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 37, seconds: 57, milliseconds: 135),
new TimeSpan(days: 0, hours: 19, minutes: 46, seconds: 37, milliseconds: 438),
new TimeSpan(days: 0, hours: 14, minutes: 55, seconds: 47, milliseconds: 654),
new TimeSpan(days: 0, hours: 2, minutes: 52, seconds: 13, milliseconds: 233),
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 17, minutes: 7, seconds: 12, milliseconds: 66),
new TimeSpan(days: 0, hours: 21, minutes: 8, seconds: 37, milliseconds: 590),
new TimeSpan(days: 0, hours: 16, minutes: 53, seconds: 32, milliseconds: 556),
new TimeSpan(days: 0, hours: 5, minutes: 43, seconds: 46, milliseconds: 157),
},
},
    NullableValue = null,
},
            new TimeSpanintervalMMArrayD1E1M
{
    Id = 135,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 16, minutes: 10, seconds: 18, milliseconds: 196),
new TimeSpan(days: 0, hours: 22, minutes: 47, seconds: 5, milliseconds: 575),
new TimeSpan(days: 0, hours: 4, minutes: 49, seconds: 34, milliseconds: 754),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalMMArrayD1E1M
{
    Id = 142,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 5, minutes: 12, seconds: 3, milliseconds: 984),
new TimeSpan(days: 0, hours: 2, minutes: 25, seconds: 21, milliseconds: 778),
new TimeSpan(days: 0, hours: 10, minutes: 32, seconds: 1, milliseconds: 647),
new TimeSpan(days: 0, hours: 17, minutes: 52, seconds: 15, milliseconds: 473),
},
    ModelInner = new TimeSpanintervalMMArrayD1E1MI
{
    Id = 71,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 1, minutes: 11, seconds: 22, milliseconds: 651),
new TimeSpan(days: 0, hours: 8, minutes: 3, seconds: 5, milliseconds: 634),
new TimeSpan(days: 0, hours: 12, minutes: 17, seconds: 24, milliseconds: 903),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalMMArrayD1E1M
{
    Id = 148,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 4, minutes: 14, seconds: 1, milliseconds: 686),
new TimeSpan(days: 0, hours: 5, minutes: 30, seconds: 33, milliseconds: 506),
new TimeSpan(days: 0, hours: 21, minutes: 7, seconds: 0, milliseconds: 61),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 12, minutes: 23, seconds: 38, milliseconds: 332),
new TimeSpan(days: 0, hours: 2, minutes: 42, seconds: 3, milliseconds: 876),
new TimeSpan(days: 0, hours: 2, minutes: 18, seconds: 29, milliseconds: 759),
new TimeSpan(days: 0, hours: 6, minutes: 17, seconds: 38, milliseconds: 170),
},
},
            new TimeSpanintervalMMArrayD1E1M
{
    Id = 156,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 4, minutes: 28, seconds: 24, milliseconds: 357),
new TimeSpan(days: 0, hours: 14, minutes: 43, seconds: 51, milliseconds: 42),
new TimeSpan(days: 0, hours: 3, minutes: 16, seconds: 7, milliseconds: 32),
},
    ModelInner = new TimeSpanintervalMMArrayD1E1MI
{
    Id = 77,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 21, seconds: 58, milliseconds: 662),
new TimeSpan(days: 0, hours: 5, minutes: 23, seconds: 30, milliseconds: 54),
new TimeSpan(days: 0, hours: 19, minutes: 30, seconds: 14, milliseconds: 257),
new TimeSpan(days: 0, hours: 10, minutes: 24, seconds: 27, milliseconds: 971),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalMMArrayD1E1M
{
    Id = 158,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 51, seconds: 41, milliseconds: 138),
new TimeSpan(days: 0, hours: 6, minutes: 23, seconds: 40, milliseconds: 908),
new TimeSpan(days: 0, hours: 16, minutes: 10, seconds: 10, milliseconds: 322),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 18, minutes: 53, seconds: 41, milliseconds: 814),
new TimeSpan(days: 0, hours: 18, minutes: 57, seconds: 29, milliseconds: 122),
new TimeSpan(days: 0, hours: 11, minutes: 17, seconds: 41, milliseconds: 412),
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timespanintervalmmarrayd1e1mi(
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
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timespanintervalmmarrayd1e1mi(
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
            queryMapTypes: [typeof(TimeSpanintervalMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618))]
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

                changedRows =  ((ITimeSpanMArrayintervalMMArrayD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ITimeSpanMArrayintervalMMArrayD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((ITimeSpanMArrayintervalMMArrayD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanMArrayintervalMMArrayD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((ITimeSpanMArrayintervalMMArrayD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((ITimeSpanMArrayintervalMMArrayD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((ITimeSpanMArrayintervalMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((ITimeSpanMArrayintervalMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((ITimeSpanMArrayintervalMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((ITimeSpanMArrayintervalMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((ITimeSpanMArrayintervalMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((ITimeSpanMArrayintervalMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((ITimeSpanMArrayintervalMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((ITimeSpanMArrayintervalMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((ITimeSpanMArrayintervalMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((ITimeSpanMArrayintervalMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((ITimeSpanMArrayintervalMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timespanintervalmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    timespanintervalmmarrayd1e1mi_id
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
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD1)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "timespanintervalmmarrayd1e1mi_id", 
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
                changedRows =  ((ITimeSpanMArrayintervalMMArrayD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((ITimeSpanMArrayintervalMMArrayD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((ITimeSpanMArrayintervalMMArrayD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((ITimeSpanMArrayintervalMMArrayD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timespanintervalmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    timespanintervalmmarrayd1e1mi_id
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
    timespanintervalmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(TimeSpanintervalMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD1)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.TimeSpan[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.TimeSpan[]>();
                    ((NpgsqlParameter<System.TimeSpan[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483618);
                    ((NpgsqlParameter<System.TimeSpan[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483618);
                    if (_testData[4].NullableValue != null)
                    {
                        parameters[2].Value = _testData[4].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[4].ModelInner != null)
                    {
                        parameters[3].Value = _testData[4].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable =  ((ITimeSpanMArrayintervalMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.TimeSpan[]>();
                    ((NpgsqlParameter<System.TimeSpan[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483618);
                    ((NpgsqlParameter<System.TimeSpan[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483618);
                    if (_testData[5].NullableValue != null)
                    {
                        parameters[2].Value = _testData[5].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[5].ModelInner != null)
                    {
                        parameters[3].Value = _testData[5].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable =  ((ITimeSpanMArrayintervalMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.TimeSpan[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.TimeSpan[]>();
                    ((NpgsqlParameter<System.TimeSpan[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483618);
                    ((NpgsqlParameter<System.TimeSpan[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483618);
                    if (_testData[6].NullableValue != null)
                    {
                        parameters[2].Value = _testData[6].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[6].ModelInner != null)
                    {
                        parameters[3].Value = _testData[6].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable = await ((ITimeSpanMArrayintervalMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.TimeSpan[]>();
                    ((NpgsqlParameter<System.TimeSpan[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483618);
                    ((NpgsqlParameter<System.TimeSpan[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483618);
                    if (_testData[7].NullableValue != null)
                    {
                        parameters[2].Value = _testData[7].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[7].ModelInner != null)
                    {
                        parameters[3].Value = _testData[7].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable = await ((ITimeSpanMArrayintervalMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 25, seconds: 45, milliseconds: 647),
new TimeSpan(days: 0, hours: 19, minutes: 1, seconds: 8, milliseconds: 477),
new TimeSpan(days: 0, hours: 20, minutes: 23, seconds: 5, milliseconds: 214),
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timespanintervalmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    timespanintervalmmarrayd1e1mi_id
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
    timespanintervalmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(TimeSpanintervalMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.TimeSpan[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483618)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "timespanintervalmmarrayd1e1mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.TimeSpan[] nullable = null;
                nullable =  ((ITimeSpanMArrayintervalMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((ITimeSpanMArrayintervalMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 55, seconds: 1, milliseconds: 153),
new TimeSpan(days: 0, hours: 18, minutes: 11, seconds: 41, milliseconds: 636),
new TimeSpan(days: 0, hours: 16, minutes: 9, seconds: 42, milliseconds: 848),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.TimeSpan[] nullable = null;
                nullable = await ((ITimeSpanMArrayintervalMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((ITimeSpanMArrayintervalMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<TimeSpanintervalMMArrayD1E1M> models = null;

                models =  ((ITimeSpanMArrayintervalMMArrayD1)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[0],_testData[12], true);
                models =  ((ITimeSpanMArrayintervalMMArrayD1)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[0],_testData[13], true);
                models =  ((ITimeSpanMArrayintervalMMArrayD1)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[0],_testData[14], true);
                models =  ((ITimeSpanMArrayintervalMMArrayD1)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<TimeSpanintervalMMArrayD1E1M> models = null;

                models = await ((ITimeSpanMArrayintervalMMArrayD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[0],_testData[16], true);
                models = await ((ITimeSpanMArrayintervalMMArrayD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[0],_testData[17], true);
                models = await ((ITimeSpanMArrayintervalMMArrayD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[0],_testData[18], true);
                models = await ((ITimeSpanMArrayintervalMMArrayD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[0],_testData[19], true);
                models = await ((ITimeSpanMArrayintervalMMArrayD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[0],_testData[20], true);
                models = await ((ITimeSpanMArrayintervalMMArrayD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[0],_testData[21], true);
                models = await ((ITimeSpanMArrayintervalMMArrayD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[0],_testData[22], true);
                models = await ((ITimeSpanMArrayintervalMMArrayD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[0],_testData[23], true);
                models = await ((ITimeSpanMArrayintervalMMArrayD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[0],_testData[24], true);
                models = await ((ITimeSpanMArrayintervalMMArrayD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[0],_testData[25], true);
                models = await ((ITimeSpanMArrayintervalMMArrayD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[0],_testData[26], true);
                models = await ((ITimeSpanMArrayintervalMMArrayD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[0],_testData[27], true);
                models = await ((ITimeSpanMArrayintervalMMArrayD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[0],_testData[28], true);
                models = await ((ITimeSpanMArrayintervalMMArrayD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[0],_testData[29], true);
                models = await ((ITimeSpanMArrayintervalMMArrayD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[0],_testData[30], true);
                models = await ((ITimeSpanMArrayintervalMMArrayD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[0],_testData[31], true);
                models = await ((ITimeSpanMArrayintervalMMArrayD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[0],_testData[32], true);
                models = await ((ITimeSpanMArrayintervalMMArrayD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[0],_testData[33], true);
                models = await ((ITimeSpanMArrayintervalMMArrayD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeSpanintervalMMArrayD1E1M), typeof(FlatTimeSpanintervalMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD1)),
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
FROM public.timespanintervalmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatTimeSpanintervalMMArrayD1E1M>();
                var models2 = new List<FlatTimeSpanintervalMMArrayD1E1M>();
                await ((ITimeSpanMArrayintervalMMArrayD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.timespanintervalmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatTimeSpanintervalMMArrayD1E1M>();
                var models2 = new List<FlatTimeSpanintervalMMArrayD1E1M>();
                ((ITimeSpanMArrayintervalMMArrayD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeSpanintervalMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD1)),
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
FROM public.timespanintervalmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((ITimeSpanMArrayintervalMMArrayD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.timespanintervalmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((ITimeSpanMArrayintervalMMArrayD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.timespanintervalmmarrayd1e1m m
LEFT JOIN public.timespanintervalmmarrayd1e1mi mi ON mi.id = m.timespanintervalmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(TimeSpanintervalMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD1)),
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
                var models = await ((ITimeSpanMArrayintervalMMArrayD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeSpanintervalMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((ITimeSpanMArrayintervalMMArrayD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeSpanintervalMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeSpanintervalMMArrayD1E1M), typeof(FlatTimeSpanintervalMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD1)),
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
FROM public.timespanintervalmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatTimeSpanintervalMMArrayD1E1M>();
                var models2 = new List<FlatTimeSpanintervalMMArrayD1E1M>();
                await ((ITimeSpanMArrayintervalMMArrayD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.timespanintervalmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatTimeSpanintervalMMArrayD1E1M>();
                var models2 = new List<FlatTimeSpanintervalMMArrayD1E1M>();
                ((ITimeSpanMArrayintervalMMArrayD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeSpanintervalMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD1)),
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
FROM public.timespanintervalmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((ITimeSpanMArrayintervalMMArrayD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.timespanintervalmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((ITimeSpanMArrayintervalMMArrayD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.timespanintervalmmarrayd1e1m m
LEFT JOIN public.timespanintervalmmarrayd1e1mi mi ON mi.id = m.timespanintervalmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(TimeSpanintervalMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD1)),
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
                var models = await ((ITimeSpanMArrayintervalMMArrayD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeSpanintervalMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((ITimeSpanMArrayintervalMMArrayD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeSpanintervalMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeSpanintervalMMArrayD1E1M), typeof(FlatTimeSpanintervalMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD1)),
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
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD1)),
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
FROM public.timespanintervalmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatTimeSpanintervalMMArrayD1E1M>();
                var models2 = new List<FlatTimeSpanintervalMMArrayD1E1M>();
                await((ITimeSpanMArrayintervalMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 35;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 116;
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
FROM public.timespanintervalmmarrayd1e1m m
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
FROM public.timespanintervalmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalMMArrayD1E1M>();
                var firstItems2 = new List<FlatTimeSpanintervalMMArrayD1E1M>();
                var secondItems1 = new List<FlatTimeSpanintervalMMArrayD1E1M>();
                var secondItems2 = new List<FlatTimeSpanintervalMMArrayD1E1M>();
                await ((ITimeSpanMArrayintervalMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[8],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 18;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 44;
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
FROM public.timespanintervalmmarrayd1e1m m
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
FROM public.timespanintervalmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalMMArrayD1E1M>();
                var firstItems2 = new List<FlatTimeSpanintervalMMArrayD1E1M>();
                var secondItems1 = new List<FlatTimeSpanintervalMMArrayD1E1M>();
                await ((ITimeSpanMArrayintervalMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[25],_testData[34], false);
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
FROM public.timespanintervalmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatTimeSpanintervalMMArrayD1E1M>();
                var models2 = new List<FlatTimeSpanintervalMMArrayD1E1M>();
                ((ITimeSpanMArrayintervalMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 34;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 32;
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
FROM public.timespanintervalmmarrayd1e1m m
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
FROM public.timespanintervalmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalMMArrayD1E1M>();
                var firstItems2 = new List<FlatTimeSpanintervalMMArrayD1E1M>();
                var secondItems1 = new List<FlatTimeSpanintervalMMArrayD1E1M>();
                var secondItems2 = new List<FlatTimeSpanintervalMMArrayD1E1M>();
                 ((ITimeSpanMArrayintervalMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[29],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 69;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 24;
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
FROM public.timespanintervalmmarrayd1e1m m
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
FROM public.timespanintervalmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalMMArrayD1E1M>();
                var firstItems2 = new List<FlatTimeSpanintervalMMArrayD1E1M>();
                var secondItems1 = new List<FlatTimeSpanintervalMMArrayD1E1M>();
                 ((ITimeSpanMArrayintervalMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[30],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeSpanintervalMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD1)),
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
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD1)),
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
FROM public.timespanintervalmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((ITimeSpanMArrayintervalMMArrayD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 66;
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
FROM public.timespanintervalmmarrayd1e1m m
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
FROM public.timespanintervalmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((ITimeSpanMArrayintervalMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[0],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[1],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[2],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[3],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[4],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[5],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[6],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[7],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[8],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[9],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[10],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[11],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[12],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[13],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[14],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[15],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[16],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[17],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[18],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[19],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[20],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[0],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[1],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[2],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[3],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[4],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[5],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[6],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[7],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[8],_testData[34], false);
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
                parametr1.Value = 93;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 148;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.timespanintervalmmarrayd1e1m m
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
FROM public.timespanintervalmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalMMArrayD1E1M>();
                var secondItems1 = new List<FlatTimeSpanintervalMMArrayD1E1M>();
                var secondItems2 = new List<FlatTimeSpanintervalMMArrayD1E1M>();
                await ((ITimeSpanMArrayintervalMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM public.timespanintervalmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((ITimeSpanMArrayintervalMMArrayD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 82;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 87;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.timespanintervalmmarrayd1e1m m
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
FROM public.timespanintervalmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((ITimeSpanMArrayintervalMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[0],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[1],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[2],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[3],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[4],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[5],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[6],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[7],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[8],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[9],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[10],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[11],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[12],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[13],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[14],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[15],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[0],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[1],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[2],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[3],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[4],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[5],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[6],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[7],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[8],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[9],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[10],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[11],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[12],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[13],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[14],_testData[34], false);
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
                parametr1.Value = 127;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 88;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.timespanintervalmmarrayd1e1m m
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
FROM public.timespanintervalmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalMMArrayD1E1M>();
                var secondItems1 = new List<FlatTimeSpanintervalMMArrayD1E1M>();
                var secondItems2 = new List<FlatTimeSpanintervalMMArrayD1E1M>();
                 ((ITimeSpanMArrayintervalMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[13],_testData[34], false);
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
FROM public.timespanintervalmmarrayd1e1m m
LEFT JOIN public.timespanintervalmmarrayd1e1mi mi ON mi.id = m.timespanintervalmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(TimeSpanintervalMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD1)),
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
                var models = await((ITimeSpanMArrayintervalMMArrayD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeSpanintervalMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 148;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 14;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((ITimeSpanMArrayintervalMMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[0],_testData[33], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[0],_testData[2], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[1],_testData[3], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[2],_testData[4], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[3],_testData[5], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[4],_testData[6], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[5],_testData[7], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[6],_testData[8], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[7],_testData[9], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[8],_testData[10], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[9],_testData[11], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[10],_testData[12], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[11],_testData[13], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[12],_testData[14], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[13],_testData[15], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[14],_testData[16], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[15],_testData[17], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[16],_testData[18], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[17],_testData[19], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[18],_testData[20], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[19],_testData[21], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[20],_testData[22], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[21],_testData[23], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[22],_testData[24], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[23],_testData[25], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[24],_testData[26], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[25],_testData[27], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[26],_testData[28], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[27],_testData[29], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[28],_testData[30], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[29],_testData[31], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[30],_testData[32], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[31],_testData[33], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[32],_testData[34], false);
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
                var models = ((ITimeSpanMArrayintervalMMArrayD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeSpanintervalMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 132;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 41;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((ITimeSpanMArrayintervalMMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[0],_testData[29], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[1],_testData[30], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[2],_testData[31], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[3],_testData[32], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[4],_testData[33], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[0],_testData[8], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[1],_testData[9], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[2],_testData[10], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[3],_testData[11], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[4],_testData[12], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[5],_testData[13], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[6],_testData[14], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[7],_testData[15], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[8],_testData[16], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[9],_testData[17], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[10],_testData[18], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[11],_testData[19], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[12],_testData[20], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[13],_testData[21], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[14],_testData[22], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[15],_testData[23], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[16],_testData[24], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[17],_testData[25], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[18],_testData[26], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[19],_testData[27], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[20],_testData[28], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[21],_testData[29], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[22],_testData[30], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[23],_testData[31], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[24],_testData[32], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[25],_testData[33], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeSpanintervalMMArrayD1E1M), typeof(FlatTimeSpanintervalMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD1)),
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
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD1)),
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
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD1)),
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
FROM public.timespanintervalmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatTimeSpanintervalMMArrayD1E1M>();
                var models2 = new List<FlatTimeSpanintervalMMArrayD1E1M>();
                await((ITimeSpanMArrayintervalMMArrayD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.timespanintervalmmarrayd1e1m m
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
FROM public.timespanintervalmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalMMArrayD1E1M>();
                var firstItems2 = new List<FlatTimeSpanintervalMMArrayD1E1M>();
                var secondItems1 = new List<FlatTimeSpanintervalMMArrayD1E1M>();
                var secondItems2 = new List<FlatTimeSpanintervalMMArrayD1E1M>();
                await ((ITimeSpanMArrayintervalMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 57, query1, 35, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[27],_testData[34], false);
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
FROM public.timespanintervalmmarrayd1e1m m
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
FROM public.timespanintervalmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalMMArrayD1E1M>();
                var firstItems2 = new List<FlatTimeSpanintervalMMArrayD1E1M>();
                var secondItems1 = new List<FlatTimeSpanintervalMMArrayD1E1M>();
                await ((ITimeSpanMArrayintervalMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 57, query1, 107, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[9],_testData[34], false);
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
FROM public.timespanintervalmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatTimeSpanintervalMMArrayD1E1M>();
                var models2 = new List<FlatTimeSpanintervalMMArrayD1E1M>();
                ((ITimeSpanMArrayintervalMMArrayD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.timespanintervalmmarrayd1e1m m
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
FROM public.timespanintervalmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalMMArrayD1E1M>();
                var firstItems2 = new List<FlatTimeSpanintervalMMArrayD1E1M>();
                var secondItems1 = new List<FlatTimeSpanintervalMMArrayD1E1M>();
                var secondItems2 = new List<FlatTimeSpanintervalMMArrayD1E1M>();
                 ((ITimeSpanMArrayintervalMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 73, query1, 142, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[2],_testData[34], false);
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
FROM public.timespanintervalmmarrayd1e1m m
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
FROM public.timespanintervalmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalMMArrayD1E1M>();
                var firstItems2 = new List<FlatTimeSpanintervalMMArrayD1E1M>();
                var secondItems1 = new List<FlatTimeSpanintervalMMArrayD1E1M>();
                 ((ITimeSpanMArrayintervalMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 93, query1, 14, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[32],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeSpanintervalMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD1)),
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
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD1)),
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
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD1)),
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
FROM public.timespanintervalmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((ITimeSpanMArrayintervalMMArrayD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.timespanintervalmmarrayd1e1m m
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
FROM public.timespanintervalmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((ITimeSpanMArrayintervalMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 142, query1, 87, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[0],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[1],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[0],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[1],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[2],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[3],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[4],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[5],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[6],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[7],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[8],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[9],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[10],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[11],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[12],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[13],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[14],_testData[34], false);
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
FROM public.timespanintervalmmarrayd1e1m m
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
FROM public.timespanintervalmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalMMArrayD1E1M>();
                var secondItems1 = new List<FlatTimeSpanintervalMMArrayD1E1M>();
                var secondItems2 = new List<FlatTimeSpanintervalMMArrayD1E1M>();
                await ((ITimeSpanMArrayintervalMMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 95, query1, 132, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[5],_testData[34], false);
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
FROM public.timespanintervalmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((ITimeSpanMArrayintervalMMArrayD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.timespanintervalmmarrayd1e1m m
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
FROM public.timespanintervalmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((ITimeSpanMArrayintervalMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 49, query1, 88, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[0],_testData[10], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[1],_testData[11], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[2],_testData[12], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[3],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[4],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[5],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[6],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[7],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[8],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[9],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[10],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[11],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[12],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[13],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[14],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[15],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[16],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[17],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[18],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[19],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[20],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[21],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[22],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[23],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[0],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[1],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[2],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[3],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[4],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[5],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[6],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[7],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[8],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[9],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[10],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[11],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[12],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[13],_testData[34], false);
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
FROM public.timespanintervalmmarrayd1e1m m
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
FROM public.timespanintervalmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalMMArrayD1E1M>();
                var secondItems1 = new List<FlatTimeSpanintervalMMArrayD1E1M>();
                var secondItems2 = new List<FlatTimeSpanintervalMMArrayD1E1M>();
                 ((ITimeSpanMArrayintervalMMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 102, query1, 18, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[31],_testData[34], false);
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
FROM public.timespanintervalmmarrayd1e1m m
LEFT JOIN public.timespanintervalmmarrayd1e1mi mi ON mi.id = m.timespanintervalmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(TimeSpanintervalMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD1)),
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
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD1)),
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
                var models = await((ITimeSpanMArrayintervalMMArrayD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeSpanintervalMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((ITimeSpanMArrayintervalMMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 41, 24))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[0],_testData[8], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[1],_testData[9], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[2],_testData[10], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[3],_testData[11], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[4],_testData[12], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[5],_testData[13], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[6],_testData[14], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[7],_testData[15], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[8],_testData[16], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[9],_testData[17], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[10],_testData[18], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[11],_testData[19], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[12],_testData[20], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[13],_testData[21], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[14],_testData[22], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[15],_testData[23], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[16],_testData[24], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[17],_testData[25], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[18],_testData[26], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[19],_testData[27], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[20],_testData[28], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[21],_testData[29], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[22],_testData[30], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[23],_testData[31], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[24],_testData[32], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[25],_testData[33], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[0],_testData[4], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[1],_testData[5], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[2],_testData[6], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[3],_testData[7], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[4],_testData[8], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[5],_testData[9], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[6],_testData[10], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[7],_testData[11], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[8],_testData[12], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[9],_testData[13], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[10],_testData[14], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[11],_testData[15], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[12],_testData[16], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[13],_testData[17], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[14],_testData[18], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[15],_testData[19], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[16],_testData[20], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[17],_testData[21], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[18],_testData[22], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[19],_testData[23], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[20],_testData[24], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[21],_testData[25], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[22],_testData[26], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[23],_testData[27], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[24],_testData[28], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[25],_testData[29], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[26],_testData[30], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[27],_testData[31], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[28],_testData[32], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[29],_testData[33], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[30],_testData[34], false);
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
                var models = ((ITimeSpanMArrayintervalMMArrayD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    TimeSpanintervalMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((ITimeSpanMArrayintervalMMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 135, 57))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[0],_testData[31], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[1],_testData[32], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[2],_testData[33], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[0],_testData[11], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[1],_testData[12], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[2],_testData[13], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[3],_testData[14], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[4],_testData[15], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[5],_testData[16], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[6],_testData[17], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[7],_testData[18], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[8],_testData[19], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[9],_testData[20], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[10],_testData[21], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[11],_testData[22], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[12],_testData[23], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[13],_testData[24], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[14],_testData[25], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[15],_testData[26], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[16],_testData[27], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[17],_testData[28], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[18],_testData[29], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[19],_testData[30], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[20],_testData[31], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[21],_testData[32], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[22],_testData[33], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[23],_testData[34], false);
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
                await using var cmd = await ((ITimeSpanMArrayintervalMMArrayD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((ITimeSpanMArrayintervalMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 73);
                var models = await ((ITimeSpanMArrayintervalMMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(19));

                TimeSpanintervalMMArrayD1E1M.AssertModel(models[0],_testData[16], false);
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[1],_testData[17], false);
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[2],_testData[18], false);
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[3],_testData[19], false);
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[4],_testData[20], false);
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[5],_testData[21], false);
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[6],_testData[22], false);
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[7],_testData[23], false);
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[8],_testData[24], false);
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[9],_testData[25], false);
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[10],_testData[26], false);
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[11],_testData[27], false);
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[12],_testData[28], false);
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[13],_testData[29], false);
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[14],_testData[30], false);
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[15],_testData[31], false);
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[16],_testData[32], false);
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[17],_testData[33], false);
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[18],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ITimeSpanMArrayintervalMMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((ITimeSpanMArrayintervalMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 66);
                var models =  ((ITimeSpanMArrayintervalMMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(22));

                TimeSpanintervalMMArrayD1E1M.AssertModel(models[0],_testData[13], false);
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[1],_testData[14], false);
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[2],_testData[15], false);
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[3],_testData[16], false);
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[4],_testData[17], false);
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[5],_testData[18], false);
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[6],_testData[19], false);
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[7],_testData[20], false);
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[8],_testData[21], false);
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[9],_testData[22], false);
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[10],_testData[23], false);
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[11],_testData[24], false);
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[12],_testData[25], false);
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[13],_testData[26], false);
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[14],_testData[27], false);
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[15],_testData[28], false);
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[16],_testData[29], false);
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[17],_testData[30], false);
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[18],_testData[31], false);
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[19],_testData[32], false);
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[20],_testData[33], false);
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[21],_testData[34], false);
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
FROM public.binary_timespanintervalmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(TimeSpanintervalMMArrayD1E1MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483618),
                (NpgsqlTypes.NpgsqlDbType)(-2147483618)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<TimeSpanintervalMMArrayD1E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeSpanintervalMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ITimeSpanMArrayintervalMMArrayD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_timespanintervalmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((ITimeSpanMArrayintervalMMArrayD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeSpanintervalMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<TimeSpanintervalMMArrayD1E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeSpanintervalMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ITimeSpanMArrayintervalMMArrayD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_timespanintervalmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((ITimeSpanMArrayintervalMMArrayD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeSpanintervalMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_timespanintervalmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(TimeSpanintervalMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<TimeSpanintervalMMArrayD1E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeSpanintervalMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ITimeSpanMArrayintervalMMArrayD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_timespanintervalmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((ITimeSpanMArrayintervalMMArrayD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeSpanintervalMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<TimeSpanintervalMMArrayD1E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeSpanintervalMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ITimeSpanMArrayintervalMMArrayD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_timespanintervalmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((ITimeSpanMArrayintervalMMArrayD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeSpanintervalMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_timespanintervalmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_timespanintervalmmarrayd1e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(TimeSpanintervalMMArrayD1E1MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483618),
                (NpgsqlTypes.NpgsqlDbType)(-2147483618)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<TimeSpanintervalMMArrayD1E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((ITimeSpanMArrayintervalMMArrayD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((ITimeSpanMArrayintervalMMArrayD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeSpanintervalMMArrayD1E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<TimeSpanintervalMMArrayD1E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((ITimeSpanMArrayintervalMMArrayD1)this).WAImportModelInner(connection, importCollection);
                var models = ((ITimeSpanMArrayintervalMMArrayD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeSpanintervalMMArrayD1E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_timespanintervalmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_timespanintervalmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(TimeSpanintervalMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<TimeSpanintervalMMArrayD1E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeSpanintervalMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ITimeSpanMArrayintervalMMArrayD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((ITimeSpanMArrayintervalMMArrayD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeSpanintervalMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<TimeSpanintervalMMArrayD1E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeSpanintervalMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ITimeSpanMArrayintervalMMArrayD1)this).ImportModelInner(connection, importCollection);
                var models = ((ITimeSpanMArrayintervalMMArrayD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeSpanintervalMMArrayD1E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_timespanintervalmmarrayd1e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
timespanintervalmmarrayd1e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(TimeSpanintervalMMArrayD1E1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483618),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483618)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD1))]
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
FROM public.binary_timespanintervalmmarrayd1e1m m
LEFT JOIN public.binary_timespanintervalmmarrayd1e1mi mi ON mi.id = m.timespanintervalmmarrayd1e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(TimeSpanintervalMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<TimeSpanintervalMMArrayD1E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((ITimeSpanMArrayintervalMMArrayD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((ITimeSpanMArrayintervalMMArrayD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    TimeSpanintervalMMArrayD1E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<TimeSpanintervalMMArrayD1E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((ITimeSpanMArrayintervalMMArrayD1)this).ImportModel(connection, importCollection);
                var models = ((ITimeSpanMArrayintervalMMArrayD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    TimeSpanintervalMMArrayD1E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_timespanintervalmmarrayd1e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    timespanintervalmmarrayd1e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(TimeSpanintervalMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483618),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483618)
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
                var models =  ((ITimeSpanMArrayintervalMMArrayD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    TimeSpanintervalMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((ITimeSpanMArrayintervalMMArrayD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    TimeSpanintervalMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalMMArrayD1E1MIWA), typeof(TimeSpanintervalMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483618),
                (NpgsqlTypes.NpgsqlDbType)(-2147483618)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483618),
                (NpgsqlTypes.NpgsqlDbType)(-2147483618)
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
                var models1 = new List<TimeSpanintervalMMArrayD1E1MIWA>();
                var models2 = new List<TimeSpanintervalMMArrayD1E1MIWA>();
                await ((ITimeSpanMArrayintervalMMArrayD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_timespanintervalmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeSpanintervalMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeSpanintervalMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<TimeSpanintervalMMArrayD1E1MIWA>();
                var models2 = new List<TimeSpanintervalMMArrayD1E1MIWA>();
                ((ITimeSpanMArrayintervalMMArrayD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_timespanintervalmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeSpanintervalMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeSpanintervalMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483618),
                (NpgsqlTypes.NpgsqlDbType)(-2147483618)
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
                var models = await ((ITimeSpanMArrayintervalMMArrayD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_timespanintervalmmarrayd1e1mi
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
                    TimeSpanintervalMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((ITimeSpanMArrayintervalMMArrayD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_timespanintervalmmarrayd1e1mi
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
                    TimeSpanintervalMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalMMArrayD1E1MIWA), typeof(TimeSpanintervalMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD1))]
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
                var models1 = new List<TimeSpanintervalMMArrayD1E1MIWA>();
                var models2 = new List<TimeSpanintervalMMArrayD1E1MIWA>();
                await ((ITimeSpanMArrayintervalMMArrayD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_timespanintervalmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeSpanintervalMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeSpanintervalMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<TimeSpanintervalMMArrayD1E1MIWA>();
                var models2 = new List<TimeSpanintervalMMArrayD1E1MIWA>();
                ((ITimeSpanMArrayintervalMMArrayD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_timespanintervalmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeSpanintervalMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeSpanintervalMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD1))]
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
                var models = await ((ITimeSpanMArrayintervalMMArrayD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_timespanintervalmmarrayd1e1mi
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
                    TimeSpanintervalMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((ITimeSpanMArrayintervalMMArrayD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_timespanintervalmmarrayd1e1mi
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
                    TimeSpanintervalMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_timespanintervalmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalMMArrayD1E1MI), typeof(TimeSpanintervalMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483618),
                (NpgsqlTypes.NpgsqlDbType)(-2147483618)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483618),
                (NpgsqlTypes.NpgsqlDbType)(-2147483618)
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
                var models1 = new List<TimeSpanintervalMMArrayD1E1MI>();
                var models2 = new List<TimeSpanintervalMMArrayD1E1MI>();
                await ((ITimeSpanMArrayintervalMMArrayD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeSpanintervalMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeSpanintervalMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<TimeSpanintervalMMArrayD1E1MI>();
                var models2 = new List<TimeSpanintervalMMArrayD1E1MI>();
                ((ITimeSpanMArrayintervalMMArrayD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeSpanintervalMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeSpanintervalMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_timespanintervalmmarrayd1e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483618),
                (NpgsqlTypes.NpgsqlDbType)(-2147483618)
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
                var models = await ((ITimeSpanMArrayintervalMMArrayD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    TimeSpanintervalMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((ITimeSpanMArrayintervalMMArrayD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    TimeSpanintervalMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_timespanintervalmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalMMArrayD1E1MIWA), typeof(TimeSpanintervalMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD1))]
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
                var models1 = new List<TimeSpanintervalMMArrayD1E1MIWA>();
                var models2 = new List<TimeSpanintervalMMArrayD1E1MIWA>();
                await ((ITimeSpanMArrayintervalMMArrayD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeSpanintervalMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeSpanintervalMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<TimeSpanintervalMMArrayD1E1MIWA>();
                var models2 = new List<TimeSpanintervalMMArrayD1E1MIWA>();
                ((ITimeSpanMArrayintervalMMArrayD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeSpanintervalMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeSpanintervalMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_timespanintervalmmarrayd1e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanMArrayintervalMMArrayD1))]
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
                var models = await ((ITimeSpanMArrayintervalMMArrayD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    TimeSpanintervalMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((ITimeSpanMArrayintervalMMArrayD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    TimeSpanintervalMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

