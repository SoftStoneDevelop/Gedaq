

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
    internal partial interface ITimeSpanArrayintervalArray
    {
    }
    
    internal partial class TimeSpanArrayintervalArray : ITimeSpanArrayintervalArray
    {


#region TestData

        private readonly TimeSpanintervalArray1M[] _testData = new TimeSpanintervalArray1M[]
        {
            new TimeSpanintervalArray1M
{
    Id = 2,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 2, minutes: 42, seconds: 29, milliseconds: 304),
new TimeSpan(days: 0, hours: 2, minutes: 28, seconds: 49, milliseconds: 464),
new TimeSpan(days: 0, hours: 22, minutes: 3, seconds: 30, milliseconds: 459),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 21, minutes: 28, seconds: 33, milliseconds: 841),
new TimeSpan(days: 0, hours: 4, minutes: 6, seconds: 22, milliseconds: 342),
new TimeSpan(days: 0, hours: 15, minutes: 22, seconds: 20, milliseconds: 802),
},
},
            new TimeSpanintervalArray1M
{
    Id = 8,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 32, seconds: 43, milliseconds: 630),
new TimeSpan(days: 0, hours: 8, minutes: 37, seconds: 37, milliseconds: 936),
new TimeSpan(days: 0, hours: 12, minutes: 56, seconds: 0, milliseconds: 468),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 9,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 25, seconds: 42, milliseconds: 728),
new TimeSpan(days: 0, hours: 14, minutes: 16, seconds: 12, milliseconds: 272),
new TimeSpan(days: 0, hours: 16, minutes: 17, seconds: 30, milliseconds: 554),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 15,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 25, seconds: 50, milliseconds: 32),
new TimeSpan(days: 0, hours: 12, minutes: 5, seconds: 44, milliseconds: 616),
new TimeSpan(days: 0, hours: 5, minutes: 35, seconds: 37, milliseconds: 420),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 13, minutes: 4, seconds: 32, milliseconds: 94),
new TimeSpan(days: 0, hours: 17, minutes: 34, seconds: 38, milliseconds: 513),
new TimeSpan(days: 0, hours: 15, minutes: 55, seconds: 43, milliseconds: 538),
},
},
            new TimeSpanintervalArray1M
{
    Id = 20,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 6, minutes: 48, seconds: 18, milliseconds: 584),
new TimeSpan(days: 0, hours: 16, minutes: 47, seconds: 36, milliseconds: 193),
new TimeSpan(days: 0, hours: 9, minutes: 19, seconds: 29, milliseconds: 852),
new TimeSpan(days: 0, hours: 17, minutes: 7, seconds: 4, milliseconds: 625),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 10,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 0, minutes: 9, seconds: 45, milliseconds: 445),
new TimeSpan(days: 0, hours: 19, minutes: 32, seconds: 29, milliseconds: 15),
new TimeSpan(days: 0, hours: 16, minutes: 1, seconds: 9, milliseconds: 511),
new TimeSpan(days: 0, hours: 10, minutes: 29, seconds: 52, milliseconds: 90),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 27,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 30, seconds: 37, milliseconds: 998),
new TimeSpan(days: 0, hours: 0, minutes: 47, seconds: 5, milliseconds: 48),
new TimeSpan(days: 0, hours: 9, minutes: 53, seconds: 53, milliseconds: 777),
new TimeSpan(days: 0, hours: 14, minutes: 27, seconds: 28, milliseconds: 559),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 2, minutes: 21, seconds: 33, milliseconds: 866),
new TimeSpan(days: 0, hours: 0, minutes: 51, seconds: 31, milliseconds: 246),
new TimeSpan(days: 0, hours: 2, minutes: 38, seconds: 17, milliseconds: 705),
},
},
            new TimeSpanintervalArray1M
{
    Id = 28,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 4, seconds: 18, milliseconds: 719),
new TimeSpan(days: 0, hours: 4, minutes: 47, seconds: 1, milliseconds: 983),
new TimeSpan(days: 0, hours: 9, minutes: 24, seconds: 24, milliseconds: 431),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 15,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 12, minutes: 56, seconds: 16, milliseconds: 858),
new TimeSpan(days: 0, hours: 13, minutes: 46, seconds: 18, milliseconds: 881),
new TimeSpan(days: 0, hours: 18, minutes: 0, seconds: 29, milliseconds: 110),
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 9, seconds: 28, milliseconds: 310),
new TimeSpan(days: 0, hours: 13, minutes: 5, seconds: 1, milliseconds: 591),
new TimeSpan(days: 0, hours: 7, minutes: 21, seconds: 56, milliseconds: 456),
new TimeSpan(days: 0, hours: 13, minutes: 4, seconds: 24, milliseconds: 163),
},
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 16, minutes: 47, seconds: 36, milliseconds: 188),
new TimeSpan(days: 0, hours: 19, minutes: 14, seconds: 12, milliseconds: 89),
new TimeSpan(days: 0, hours: 0, minutes: 33, seconds: 28, milliseconds: 458),
},
},
            new TimeSpanintervalArray1M
{
    Id = 35,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 0, minutes: 14, seconds: 24, milliseconds: 150),
new TimeSpan(days: 0, hours: 7, minutes: 53, seconds: 34, milliseconds: 938),
new TimeSpan(days: 0, hours: 17, minutes: 20, seconds: 5, milliseconds: 231),
new TimeSpan(days: 0, hours: 17, minutes: 7, seconds: 4, milliseconds: 452),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 43,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 12, minutes: 44, seconds: 56, milliseconds: 366),
new TimeSpan(days: 0, hours: 22, minutes: 36, seconds: 19, milliseconds: 711),
new TimeSpan(days: 0, hours: 13, minutes: 10, seconds: 58, milliseconds: 219),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 23,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 1, minutes: 22, seconds: 20, milliseconds: 844),
new TimeSpan(days: 0, hours: 16, minutes: 38, seconds: 51, milliseconds: 291),
new TimeSpan(days: 0, hours: 15, minutes: 17, seconds: 18, milliseconds: 237),
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 4, seconds: 40, milliseconds: 642),
new TimeSpan(days: 0, hours: 10, minutes: 14, seconds: 19, milliseconds: 395),
new TimeSpan(days: 0, hours: 1, minutes: 47, seconds: 53, milliseconds: 232),
},
},
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 48,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 18, minutes: 55, seconds: 41, milliseconds: 471),
new TimeSpan(days: 0, hours: 19, minutes: 30, seconds: 22, milliseconds: 228),
new TimeSpan(days: 0, hours: 16, minutes: 58, seconds: 55, milliseconds: 653),
new TimeSpan(days: 0, hours: 2, minutes: 23, seconds: 11, milliseconds: 536),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 55,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 20, minutes: 37, seconds: 13, milliseconds: 115),
new TimeSpan(days: 0, hours: 8, minutes: 48, seconds: 6, milliseconds: 649),
new TimeSpan(days: 0, hours: 17, minutes: 3, seconds: 26, milliseconds: 113),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 30,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 4, minutes: 28, seconds: 25, milliseconds: 576),
new TimeSpan(days: 0, hours: 0, minutes: 30, seconds: 22, milliseconds: 550),
new TimeSpan(days: 0, hours: 1, minutes: 11, seconds: 30, milliseconds: 727),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 10, minutes: 24, seconds: 51, milliseconds: 747),
new TimeSpan(days: 0, hours: 7, minutes: 48, seconds: 14, milliseconds: 625),
new TimeSpan(days: 0, hours: 21, minutes: 6, seconds: 50, milliseconds: 576),
},
},
            new TimeSpanintervalArray1M
{
    Id = 64,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 16, minutes: 2, seconds: 49, milliseconds: 211),
new TimeSpan(days: 0, hours: 2, minutes: 55, seconds: 16, milliseconds: 695),
new TimeSpan(days: 0, hours: 3, minutes: 37, seconds: 54, milliseconds: 130),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 65,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 0, minutes: 18, seconds: 48, milliseconds: 64),
new TimeSpan(days: 0, hours: 11, minutes: 33, seconds: 30, milliseconds: 418),
new TimeSpan(days: 0, hours: 14, minutes: 21, seconds: 58, milliseconds: 71),
new TimeSpan(days: 0, hours: 12, minutes: 27, seconds: 21, milliseconds: 566),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 39,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 26, seconds: 46, milliseconds: 217),
new TimeSpan(days: 0, hours: 11, minutes: 6, seconds: 24, milliseconds: 41),
new TimeSpan(days: 0, hours: 17, minutes: 28, seconds: 44, milliseconds: 736),
new TimeSpan(days: 0, hours: 1, minutes: 16, seconds: 17, milliseconds: 151),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 10, minutes: 8, seconds: 37, milliseconds: 625),
new TimeSpan(days: 0, hours: 11, minutes: 31, seconds: 7, milliseconds: 60),
new TimeSpan(days: 0, hours: 2, minutes: 42, seconds: 16, milliseconds: 885),
new TimeSpan(days: 0, hours: 21, minutes: 19, seconds: 30, milliseconds: 79),
},
},
            new TimeSpanintervalArray1M
{
    Id = 73,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 2, minutes: 5, seconds: 32, milliseconds: 387),
new TimeSpan(days: 0, hours: 22, minutes: 13, seconds: 21, milliseconds: 571),
new TimeSpan(days: 0, hours: 3, minutes: 37, seconds: 5, milliseconds: 782),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 22, minutes: 7, seconds: 13, milliseconds: 462),
new TimeSpan(days: 0, hours: 8, minutes: 42, seconds: 29, milliseconds: 290),
new TimeSpan(days: 0, hours: 18, minutes: 37, seconds: 10, milliseconds: 897),
},
},
            new TimeSpanintervalArray1M
{
    Id = 80,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 0, minutes: 1, seconds: 8, milliseconds: 504),
new TimeSpan(days: 0, hours: 11, minutes: 33, seconds: 26, milliseconds: 355),
new TimeSpan(days: 0, hours: 8, minutes: 3, seconds: 18, milliseconds: 296),
new TimeSpan(days: 0, hours: 18, minutes: 35, seconds: 14, milliseconds: 902),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 46,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 17, minutes: 24, seconds: 26, milliseconds: 939),
new TimeSpan(days: 0, hours: 1, minutes: 14, seconds: 44, milliseconds: 605),
new TimeSpan(days: 0, hours: 22, minutes: 15, seconds: 27, milliseconds: 49),
new TimeSpan(days: 0, hours: 1, minutes: 35, seconds: 31, milliseconds: 404),
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 0, minutes: 44, seconds: 10, milliseconds: 628),
new TimeSpan(days: 0, hours: 0, minutes: 41, seconds: 46, milliseconds: 267),
new TimeSpan(days: 0, hours: 14, minutes: 26, seconds: 30, milliseconds: 406),
new TimeSpan(days: 0, hours: 13, minutes: 38, seconds: 15, milliseconds: 254),
},
},
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 87,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 14, minutes: 2, seconds: 6, milliseconds: 936),
new TimeSpan(days: 0, hours: 1, minutes: 37, seconds: 36, milliseconds: 214),
new TimeSpan(days: 0, hours: 12, minutes: 50, seconds: 58, milliseconds: 868),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 90,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 12, minutes: 34, seconds: 57, milliseconds: 592),
new TimeSpan(days: 0, hours: 5, minutes: 8, seconds: 8, milliseconds: 92),
new TimeSpan(days: 0, hours: 15, minutes: 1, seconds: 27, milliseconds: 627),
new TimeSpan(days: 0, hours: 19, minutes: 22, seconds: 19, milliseconds: 225),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 47,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 28, seconds: 37, milliseconds: 614),
new TimeSpan(days: 0, hours: 16, minutes: 16, seconds: 50, milliseconds: 773),
new TimeSpan(days: 0, hours: 8, minutes: 50, seconds: 13, milliseconds: 908),
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 8, minutes: 57, seconds: 26, milliseconds: 838),
new TimeSpan(days: 0, hours: 1, minutes: 19, seconds: 34, milliseconds: 400),
new TimeSpan(days: 0, hours: 17, minutes: 3, seconds: 20, milliseconds: 875),
},
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 10, minutes: 8, seconds: 11, milliseconds: 585),
new TimeSpan(days: 0, hours: 11, minutes: 15, seconds: 5, milliseconds: 881),
new TimeSpan(days: 0, hours: 22, minutes: 31, seconds: 46, milliseconds: 47),
},
},
            new TimeSpanintervalArray1M
{
    Id = 96,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 8, minutes: 9, seconds: 50, milliseconds: 814),
new TimeSpan(days: 0, hours: 6, minutes: 51, seconds: 24, milliseconds: 418),
new TimeSpan(days: 0, hours: 5, minutes: 9, seconds: 3, milliseconds: 432),
new TimeSpan(days: 0, hours: 7, minutes: 30, seconds: 21, milliseconds: 415),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 101,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 3, minutes: 5, seconds: 33, milliseconds: 493),
new TimeSpan(days: 0, hours: 13, minutes: 51, seconds: 11, milliseconds: 438),
new TimeSpan(days: 0, hours: 6, minutes: 6, seconds: 15, milliseconds: 370),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 55,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 11, minutes: 6, seconds: 24, milliseconds: 146),
new TimeSpan(days: 0, hours: 8, minutes: 0, seconds: 13, milliseconds: 645),
new TimeSpan(days: 0, hours: 20, minutes: 33, seconds: 7, milliseconds: 302),
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 6, seconds: 21, milliseconds: 398),
new TimeSpan(days: 0, hours: 20, minutes: 2, seconds: 18, milliseconds: 938),
new TimeSpan(days: 0, hours: 17, minutes: 39, seconds: 24, milliseconds: 525),
},
},
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 110,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 20, minutes: 44, seconds: 11, milliseconds: 112),
new TimeSpan(days: 0, hours: 0, minutes: 45, seconds: 46, milliseconds: 211),
new TimeSpan(days: 0, hours: 1, minutes: 9, seconds: 40, milliseconds: 609),
new TimeSpan(days: 0, hours: 18, minutes: 46, seconds: 34, milliseconds: 493),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 119,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 9, seconds: 25, milliseconds: 489),
new TimeSpan(days: 0, hours: 3, minutes: 26, seconds: 5, milliseconds: 531),
new TimeSpan(days: 0, hours: 18, minutes: 30, seconds: 43, milliseconds: 871),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 60,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 1, minutes: 35, seconds: 15, milliseconds: 333),
new TimeSpan(days: 0, hours: 10, minutes: 54, seconds: 0, milliseconds: 316),
new TimeSpan(days: 0, hours: 18, minutes: 56, seconds: 26, milliseconds: 174),
new TimeSpan(days: 0, hours: 0, minutes: 49, seconds: 12, milliseconds: 43),
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 52, seconds: 53, milliseconds: 540),
new TimeSpan(days: 0, hours: 21, minutes: 24, seconds: 15, milliseconds: 973),
new TimeSpan(days: 0, hours: 22, minutes: 27, seconds: 40, milliseconds: 669),
},
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 17, minutes: 27, seconds: 31, milliseconds: 340),
new TimeSpan(days: 0, hours: 22, minutes: 31, seconds: 38, milliseconds: 105),
new TimeSpan(days: 0, hours: 0, minutes: 50, seconds: 47, milliseconds: 28),
new TimeSpan(days: 0, hours: 19, minutes: 0, seconds: 30, milliseconds: 953),
},
},
            new TimeSpanintervalArray1M
{
    Id = 120,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 10, minutes: 37, seconds: 27, milliseconds: 36),
new TimeSpan(days: 0, hours: 22, minutes: 9, seconds: 5, milliseconds: 918),
new TimeSpan(days: 0, hours: 11, minutes: 5, seconds: 28, milliseconds: 944),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 0, minutes: 12, seconds: 0, milliseconds: 573),
new TimeSpan(days: 0, hours: 13, minutes: 31, seconds: 9, milliseconds: 18),
new TimeSpan(days: 0, hours: 12, minutes: 6, seconds: 13, milliseconds: 323),
new TimeSpan(days: 0, hours: 22, minutes: 23, seconds: 18, milliseconds: 990),
},
},
            new TimeSpanintervalArray1M
{
    Id = 123,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 35, seconds: 38, milliseconds: 842),
new TimeSpan(days: 0, hours: 20, minutes: 5, seconds: 32, milliseconds: 322),
new TimeSpan(days: 0, hours: 12, minutes: 52, seconds: 42, milliseconds: 302),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 67,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 12, minutes: 46, seconds: 38, milliseconds: 497),
new TimeSpan(days: 0, hours: 1, minutes: 41, seconds: 13, milliseconds: 270),
new TimeSpan(days: 0, hours: 2, minutes: 21, seconds: 26, milliseconds: 684),
new TimeSpan(days: 0, hours: 21, minutes: 17, seconds: 42, milliseconds: 738),
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 22, minutes: 27, seconds: 40, milliseconds: 674),
new TimeSpan(days: 0, hours: 1, minutes: 21, seconds: 55, milliseconds: 543),
new TimeSpan(days: 0, hours: 2, minutes: 17, seconds: 0, milliseconds: 353),
},
},
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 124,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 7, minutes: 8, seconds: 8, milliseconds: 864),
new TimeSpan(days: 0, hours: 0, minutes: 37, seconds: 40, milliseconds: 818),
new TimeSpan(days: 0, hours: 12, minutes: 31, seconds: 53, milliseconds: 162),
new TimeSpan(days: 0, hours: 4, minutes: 37, seconds: 13, milliseconds: 657),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 1, minutes: 27, seconds: 31, milliseconds: 417),
new TimeSpan(days: 0, hours: 12, minutes: 1, seconds: 29, milliseconds: 350),
new TimeSpan(days: 0, hours: 15, minutes: 36, seconds: 3, milliseconds: 339),
},
},
            new TimeSpanintervalArray1M
{
    Id = 128,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 53, seconds: 51, milliseconds: 136),
new TimeSpan(days: 0, hours: 8, minutes: 34, seconds: 37, milliseconds: 214),
new TimeSpan(days: 0, hours: 18, minutes: 58, seconds: 32, milliseconds: 437),
new TimeSpan(days: 0, hours: 15, minutes: 57, seconds: 36, milliseconds: 791),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 76,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 18, minutes: 51, seconds: 23, milliseconds: 538),
new TimeSpan(days: 0, hours: 1, minutes: 34, seconds: 2, milliseconds: 377),
new TimeSpan(days: 0, hours: 19, minutes: 13, seconds: 58, milliseconds: 881),
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 2, minutes: 55, seconds: 41, milliseconds: 886),
new TimeSpan(days: 0, hours: 12, minutes: 54, seconds: 58, milliseconds: 9),
new TimeSpan(days: 0, hours: 20, minutes: 5, seconds: 4, milliseconds: 872),
new TimeSpan(days: 0, hours: 22, minutes: 1, seconds: 52, milliseconds: 116),
},
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 19, minutes: 53, seconds: 21, milliseconds: 562),
new TimeSpan(days: 0, hours: 8, minutes: 20, seconds: 51, milliseconds: 643),
new TimeSpan(days: 0, hours: 19, minutes: 22, seconds: 34, milliseconds: 530),
},
},
            new TimeSpanintervalArray1M
{
    Id = 133,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 43, seconds: 16, milliseconds: 550),
new TimeSpan(days: 0, hours: 2, minutes: 24, seconds: 51, milliseconds: 209),
new TimeSpan(days: 0, hours: 17, minutes: 43, seconds: 18, milliseconds: 195),
new TimeSpan(days: 0, hours: 17, minutes: 14, seconds: 16, milliseconds: 517),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 138,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 9, minutes: 26, seconds: 36, milliseconds: 983),
new TimeSpan(days: 0, hours: 21, minutes: 27, seconds: 36, milliseconds: 182),
new TimeSpan(days: 0, hours: 7, minutes: 22, seconds: 46, milliseconds: 480),
new TimeSpan(days: 0, hours: 8, minutes: 9, seconds: 15, milliseconds: 973),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 77,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 1, minutes: 49, seconds: 21, milliseconds: 350),
new TimeSpan(days: 0, hours: 22, minutes: 36, seconds: 48, milliseconds: 642),
new TimeSpan(days: 0, hours: 6, minutes: 27, seconds: 56, milliseconds: 266),
new TimeSpan(days: 0, hours: 22, minutes: 12, seconds: 48, milliseconds: 455),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 0, minutes: 6, seconds: 7, milliseconds: 944),
new TimeSpan(days: 0, hours: 4, minutes: 37, seconds: 16, milliseconds: 829),
new TimeSpan(days: 0, hours: 2, minutes: 33, seconds: 9, milliseconds: 726),
new TimeSpan(days: 0, hours: 5, minutes: 52, seconds: 38, milliseconds: 60),
},
},
            new TimeSpanintervalArray1M
{
    Id = 139,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 10, minutes: 2, seconds: 7, milliseconds: 872),
new TimeSpan(days: 0, hours: 22, minutes: 3, seconds: 44, milliseconds: 687),
new TimeSpan(days: 0, hours: 18, minutes: 10, seconds: 27, milliseconds: 302),
new TimeSpan(days: 0, hours: 11, minutes: 24, seconds: 45, milliseconds: 138),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 148,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 11, minutes: 24, seconds: 42, milliseconds: 627),
new TimeSpan(days: 0, hours: 11, minutes: 15, seconds: 57, milliseconds: 282),
new TimeSpan(days: 0, hours: 5, minutes: 46, seconds: 20, milliseconds: 366),
new TimeSpan(days: 0, hours: 15, minutes: 37, seconds: 30, milliseconds: 271),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 86,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 12, minutes: 57, seconds: 52, milliseconds: 44),
new TimeSpan(days: 0, hours: 7, minutes: 7, seconds: 9, milliseconds: 772),
new TimeSpan(days: 0, hours: 10, minutes: 47, seconds: 15, milliseconds: 327),
new TimeSpan(days: 0, hours: 20, minutes: 33, seconds: 49, milliseconds: 228),
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 4, minutes: 25, seconds: 20, milliseconds: 972),
new TimeSpan(days: 0, hours: 10, minutes: 52, seconds: 31, milliseconds: 595),
new TimeSpan(days: 0, hours: 15, minutes: 34, seconds: 39, milliseconds: 160),
new TimeSpan(days: 0, hours: 11, minutes: 5, seconds: 0, milliseconds: 205),
},
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 5, minutes: 48, seconds: 42, milliseconds: 639),
new TimeSpan(days: 0, hours: 17, minutes: 15, seconds: 20, milliseconds: 274),
new TimeSpan(days: 0, hours: 8, minutes: 1, seconds: 7, milliseconds: 857),
},
},
            new TimeSpanintervalArray1M
{
    Id = 156,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 9, minutes: 10, seconds: 52, milliseconds: 380),
new TimeSpan(days: 0, hours: 17, minutes: 16, seconds: 18, milliseconds: 837),
new TimeSpan(days: 0, hours: 9, minutes: 21, seconds: 55, milliseconds: 587),
new TimeSpan(days: 0, hours: 18, minutes: 13, seconds: 27, milliseconds: 167),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 20, minutes: 6, seconds: 58, milliseconds: 364),
new TimeSpan(days: 0, hours: 8, minutes: 56, seconds: 46, milliseconds: 877),
new TimeSpan(days: 0, hours: 16, minutes: 37, seconds: 3, milliseconds: 675),
new TimeSpan(days: 0, hours: 22, minutes: 8, seconds: 14, milliseconds: 166),
},
},
            new TimeSpanintervalArray1M
{
    Id = 165,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 46, seconds: 42, milliseconds: 961),
new TimeSpan(days: 0, hours: 21, minutes: 6, seconds: 50, milliseconds: 895),
new TimeSpan(days: 0, hours: 7, minutes: 41, seconds: 21, milliseconds: 722),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 92,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 6, minutes: 33, seconds: 32, milliseconds: 934),
new TimeSpan(days: 0, hours: 6, minutes: 51, seconds: 53, milliseconds: 732),
new TimeSpan(days: 0, hours: 14, minutes: 30, seconds: 40, milliseconds: 900),
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 18, minutes: 45, seconds: 32, milliseconds: 186),
new TimeSpan(days: 0, hours: 14, minutes: 44, seconds: 42, milliseconds: 703),
new TimeSpan(days: 0, hours: 4, minutes: 44, seconds: 48, milliseconds: 721),
},
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timespanintervalarray1mi(
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
            asPartInterface: typeof(ITimeSpanArrayintervalArray)),
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
INSERT INTO public.timespanintervalarray1mi(
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
            queryMapTypes: [typeof(TimeSpanintervalArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanArrayintervalArray)),
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

                changedRows =  ((ITimeSpanArrayintervalArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ITimeSpanArrayintervalArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((ITimeSpanArrayintervalArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ITimeSpanArrayintervalArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((ITimeSpanArrayintervalArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((ITimeSpanArrayintervalArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((ITimeSpanArrayintervalArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((ITimeSpanArrayintervalArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((ITimeSpanArrayintervalArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((ITimeSpanArrayintervalArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((ITimeSpanArrayintervalArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((ITimeSpanArrayintervalArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((ITimeSpanArrayintervalArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((ITimeSpanArrayintervalArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((ITimeSpanArrayintervalArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timespanintervalarray1m(
	id,
    value,
    nullablevalue,
    timespanintervalarray1mi_id
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
            asPartInterface: typeof(ITimeSpanArrayintervalArray)), 
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
                methodParametrName: "timespanintervalarray1mi_id", 
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
                changedRows =  ((ITimeSpanArrayintervalArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((ITimeSpanArrayintervalArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((ITimeSpanArrayintervalArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((ITimeSpanArrayintervalArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timespanintervalarray1m(
	id,
    value,
    nullablevalue,
    timespanintervalarray1mi_id
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
    timespanintervalarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(TimeSpanintervalArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanArrayintervalArray)),
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

                    nullable =  ((ITimeSpanArrayintervalArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 2, minutes: 21, seconds: 33, milliseconds: 866),
new TimeSpan(days: 0, hours: 0, minutes: 51, seconds: 31, milliseconds: 246),
new TimeSpan(days: 0, hours: 2, minutes: 38, seconds: 17, milliseconds: 705),
}));
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

                    nullable =  ((ITimeSpanArrayintervalArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 16, minutes: 47, seconds: 36, milliseconds: 188),
new TimeSpan(days: 0, hours: 19, minutes: 14, seconds: 12, milliseconds: 89),
new TimeSpan(days: 0, hours: 0, minutes: 33, seconds: 28, milliseconds: 458),
}));
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

                    nullable = await ((ITimeSpanArrayintervalArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
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

                    nullable = await ((ITimeSpanArrayintervalArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.timespanintervalarray1m(
	id,
    value,
    nullablevalue,
    timespanintervalarray1mi_id
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
    timespanintervalarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(TimeSpanintervalArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanArrayintervalArray)),
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
                methodParametrName: "timespanintervalarray1mi_id", 
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
                nullable =  ((ITimeSpanArrayintervalArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((ITimeSpanArrayintervalArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 10, minutes: 24, seconds: 51, milliseconds: 747),
new TimeSpan(days: 0, hours: 7, minutes: 48, seconds: 14, milliseconds: 625),
new TimeSpan(days: 0, hours: 21, minutes: 6, seconds: 50, milliseconds: 576),
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
                nullable = await ((ITimeSpanArrayintervalArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((ITimeSpanArrayintervalArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 10, minutes: 8, seconds: 37, milliseconds: 625),
new TimeSpan(days: 0, hours: 11, minutes: 31, seconds: 7, milliseconds: 60),
new TimeSpan(days: 0, hours: 2, minutes: 42, seconds: 16, milliseconds: 885),
new TimeSpan(days: 0, hours: 21, minutes: 19, seconds: 30, milliseconds: 79),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<TimeSpanintervalArray1M> models = null;

                models =  ((ITimeSpanArrayintervalArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((ITimeSpanArrayintervalArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((ITimeSpanArrayintervalArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((ITimeSpanArrayintervalArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<TimeSpanintervalArray1M> models = null;

                models = await ((ITimeSpanArrayintervalArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((ITimeSpanArrayintervalArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((ITimeSpanArrayintervalArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((ITimeSpanArrayintervalArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((ITimeSpanArrayintervalArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((ITimeSpanArrayintervalArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((ITimeSpanArrayintervalArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((ITimeSpanArrayintervalArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((ITimeSpanArrayintervalArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((ITimeSpanArrayintervalArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((ITimeSpanArrayintervalArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((ITimeSpanArrayintervalArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((ITimeSpanArrayintervalArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((ITimeSpanArrayintervalArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalArray1M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeSpanintervalArray1M), typeof(FlatTimeSpanintervalArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanArrayintervalArray)),
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
FROM public.timespanintervalarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatTimeSpanintervalArray1M>();
                var models2 = new List<FlatTimeSpanintervalArray1M>();
                await ((ITimeSpanArrayintervalArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpanintervalArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpanintervalArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.timespanintervalarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatTimeSpanintervalArray1M>();
                var models2 = new List<FlatTimeSpanintervalArray1M>();
                ((ITimeSpanArrayintervalArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpanintervalArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpanintervalArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeSpanintervalArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanArrayintervalArray)),
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
FROM public.timespanintervalarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((ITimeSpanArrayintervalArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpanintervalArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.timespanintervalarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((ITimeSpanArrayintervalArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpanintervalArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.timespanintervalarray1m m
LEFT JOIN public.timespanintervalarray1mi mi ON mi.id = m.timespanintervalarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(TimeSpanintervalArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanArrayintervalArray)),
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
                var models = await ((ITimeSpanArrayintervalArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    TimeSpanintervalArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((ITimeSpanArrayintervalArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    TimeSpanintervalArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeSpanintervalArray1M), typeof(FlatTimeSpanintervalArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanArrayintervalArray)),
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
FROM public.timespanintervalarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatTimeSpanintervalArray1M>();
                var models2 = new List<FlatTimeSpanintervalArray1M>();
                await ((ITimeSpanArrayintervalArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpanintervalArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpanintervalArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.timespanintervalarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatTimeSpanintervalArray1M>();
                var models2 = new List<FlatTimeSpanintervalArray1M>();
                ((ITimeSpanArrayintervalArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpanintervalArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpanintervalArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeSpanintervalArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanArrayintervalArray)),
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
FROM public.timespanintervalarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((ITimeSpanArrayintervalArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpanintervalArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.timespanintervalarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((ITimeSpanArrayintervalArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpanintervalArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.timespanintervalarray1m m
LEFT JOIN public.timespanintervalarray1mi mi ON mi.id = m.timespanintervalarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(TimeSpanintervalArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanArrayintervalArray)),
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
                var models = await ((ITimeSpanArrayintervalArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    TimeSpanintervalArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((ITimeSpanArrayintervalArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    TimeSpanintervalArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeSpanintervalArray1M), typeof(FlatTimeSpanintervalArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanArrayintervalArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanArrayintervalArray)),
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
            asPartInterface: typeof(ITimeSpanArrayintervalArray)),
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
FROM public.timespanintervalarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatTimeSpanintervalArray1M>();
                var models2 = new List<FlatTimeSpanintervalArray1M>();
                await((ITimeSpanArrayintervalArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpanintervalArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpanintervalArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 48;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 8;
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
FROM public.timespanintervalarray1m m
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
FROM public.timespanintervalarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalArray1M>();
                var firstItems2 = new List<FlatTimeSpanintervalArray1M>();
                var secondItems1 = new List<FlatTimeSpanintervalArray1M>();
                var secondItems2 = new List<FlatTimeSpanintervalArray1M>();
                await ((ITimeSpanArrayintervalArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[27],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 128;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 64;
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
FROM public.timespanintervalarray1m m
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
FROM public.timespanintervalarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalArray1M>();
                var firstItems2 = new List<FlatTimeSpanintervalArray1M>();
                var secondItems1 = new List<FlatTimeSpanintervalArray1M>();
                await ((ITimeSpanArrayintervalArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[18],_testData[29], false);
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
FROM public.timespanintervalarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatTimeSpanintervalArray1M>();
                var models2 = new List<FlatTimeSpanintervalArray1M>();
                ((ITimeSpanArrayintervalArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpanintervalArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpanintervalArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 8;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 148;
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
FROM public.timespanintervalarray1m m
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
FROM public.timespanintervalarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalArray1M>();
                var firstItems2 = new List<FlatTimeSpanintervalArray1M>();
                var secondItems1 = new List<FlatTimeSpanintervalArray1M>();
                var secondItems2 = new List<FlatTimeSpanintervalArray1M>();
                 ((ITimeSpanArrayintervalArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[1],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 48;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 124;
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
FROM public.timespanintervalarray1m m
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
FROM public.timespanintervalarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalArray1M>();
                var firstItems2 = new List<FlatTimeSpanintervalArray1M>();
                var secondItems1 = new List<FlatTimeSpanintervalArray1M>();
                 ((ITimeSpanArrayintervalArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[6],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatTimeSpanintervalArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanArrayintervalArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanArrayintervalArray)),
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
            asPartInterface: typeof(ITimeSpanArrayintervalArray)),
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
FROM public.timespanintervalarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((ITimeSpanArrayintervalArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpanintervalArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 64;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 133;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.timespanintervalarray1m m
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
FROM public.timespanintervalarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((ITimeSpanArrayintervalArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatTimeSpanintervalArray1M.AssertModel(models[0],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[1],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[2],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[3],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[4],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[5],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[6],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[7],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[8],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[9],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[10],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[11],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[12],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[13],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[14],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[15],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[16],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[17],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatTimeSpanintervalArray1M.AssertModel(models[0],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[1],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[2],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[3],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[4],_testData[29], false);
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
                parametr1.Value = 133;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 119;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.timespanintervalarray1m m
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
FROM public.timespanintervalarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalArray1M>();
                var secondItems1 = new List<FlatTimeSpanintervalArray1M>();
                var secondItems2 = new List<FlatTimeSpanintervalArray1M>();
                await ((ITimeSpanArrayintervalArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[4],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[9],_testData[29], false);
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
FROM public.timespanintervalarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((ITimeSpanArrayintervalArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpanintervalArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 148;
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
FROM public.timespanintervalarray1m m
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
FROM public.timespanintervalarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((ITimeSpanArrayintervalArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatTimeSpanintervalArray1M.AssertModel(models[0],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatTimeSpanintervalArray1M.AssertModel(models[0],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[1],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[2],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[3],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[4],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[5],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[6],_testData[29], false);
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
                parametr1.Value = 28;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 43;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.timespanintervalarray1m m
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
FROM public.timespanintervalarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalArray1M>();
                var secondItems1 = new List<FlatTimeSpanintervalArray1M>();
                var secondItems2 = new List<FlatTimeSpanintervalArray1M>();
                 ((ITimeSpanArrayintervalArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[23],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[21],_testData[29], false);
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
FROM public.timespanintervalarray1m m
LEFT JOIN public.timespanintervalarray1mi mi ON mi.id = m.timespanintervalarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(TimeSpanintervalArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanArrayintervalArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanArrayintervalArray)),
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
                var models = await((ITimeSpanArrayintervalArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    TimeSpanintervalArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 110;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 35;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((ITimeSpanArrayintervalArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        TimeSpanintervalArray1M.AssertModel(models[0],_testData[19], false);
                        TimeSpanintervalArray1M.AssertModel(models[1],_testData[20], false);
                        TimeSpanintervalArray1M.AssertModel(models[2],_testData[21], false);
                        TimeSpanintervalArray1M.AssertModel(models[3],_testData[22], false);
                        TimeSpanintervalArray1M.AssertModel(models[4],_testData[23], false);
                        TimeSpanintervalArray1M.AssertModel(models[5],_testData[24], false);
                        TimeSpanintervalArray1M.AssertModel(models[6],_testData[25], false);
                        TimeSpanintervalArray1M.AssertModel(models[7],_testData[26], false);
                        TimeSpanintervalArray1M.AssertModel(models[8],_testData[27], false);
                        TimeSpanintervalArray1M.AssertModel(models[9],_testData[28], false);
                        TimeSpanintervalArray1M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        TimeSpanintervalArray1M.AssertModel(models[0],_testData[7], false);
                        TimeSpanintervalArray1M.AssertModel(models[1],_testData[8], false);
                        TimeSpanintervalArray1M.AssertModel(models[2],_testData[9], false);
                        TimeSpanintervalArray1M.AssertModel(models[3],_testData[10], false);
                        TimeSpanintervalArray1M.AssertModel(models[4],_testData[11], false);
                        TimeSpanintervalArray1M.AssertModel(models[5],_testData[12], false);
                        TimeSpanintervalArray1M.AssertModel(models[6],_testData[13], false);
                        TimeSpanintervalArray1M.AssertModel(models[7],_testData[14], false);
                        TimeSpanintervalArray1M.AssertModel(models[8],_testData[15], false);
                        TimeSpanintervalArray1M.AssertModel(models[9],_testData[16], false);
                        TimeSpanintervalArray1M.AssertModel(models[10],_testData[17], false);
                        TimeSpanintervalArray1M.AssertModel(models[11],_testData[18], false);
                        TimeSpanintervalArray1M.AssertModel(models[12],_testData[19], false);
                        TimeSpanintervalArray1M.AssertModel(models[13],_testData[20], false);
                        TimeSpanintervalArray1M.AssertModel(models[14],_testData[21], false);
                        TimeSpanintervalArray1M.AssertModel(models[15],_testData[22], false);
                        TimeSpanintervalArray1M.AssertModel(models[16],_testData[23], false);
                        TimeSpanintervalArray1M.AssertModel(models[17],_testData[24], false);
                        TimeSpanintervalArray1M.AssertModel(models[18],_testData[25], false);
                        TimeSpanintervalArray1M.AssertModel(models[19],_testData[26], false);
                        TimeSpanintervalArray1M.AssertModel(models[20],_testData[27], false);
                        TimeSpanintervalArray1M.AssertModel(models[21],_testData[28], false);
                        TimeSpanintervalArray1M.AssertModel(models[22],_testData[29], false);
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
                var models = ((ITimeSpanArrayintervalArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    TimeSpanintervalArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 55;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 110;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((ITimeSpanArrayintervalArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        TimeSpanintervalArray1M.AssertModel(models[0],_testData[10], false);
                        TimeSpanintervalArray1M.AssertModel(models[1],_testData[11], false);
                        TimeSpanintervalArray1M.AssertModel(models[2],_testData[12], false);
                        TimeSpanintervalArray1M.AssertModel(models[3],_testData[13], false);
                        TimeSpanintervalArray1M.AssertModel(models[4],_testData[14], false);
                        TimeSpanintervalArray1M.AssertModel(models[5],_testData[15], false);
                        TimeSpanintervalArray1M.AssertModel(models[6],_testData[16], false);
                        TimeSpanintervalArray1M.AssertModel(models[7],_testData[17], false);
                        TimeSpanintervalArray1M.AssertModel(models[8],_testData[18], false);
                        TimeSpanintervalArray1M.AssertModel(models[9],_testData[19], false);
                        TimeSpanintervalArray1M.AssertModel(models[10],_testData[20], false);
                        TimeSpanintervalArray1M.AssertModel(models[11],_testData[21], false);
                        TimeSpanintervalArray1M.AssertModel(models[12],_testData[22], false);
                        TimeSpanintervalArray1M.AssertModel(models[13],_testData[23], false);
                        TimeSpanintervalArray1M.AssertModel(models[14],_testData[24], false);
                        TimeSpanintervalArray1M.AssertModel(models[15],_testData[25], false);
                        TimeSpanintervalArray1M.AssertModel(models[16],_testData[26], false);
                        TimeSpanintervalArray1M.AssertModel(models[17],_testData[27], false);
                        TimeSpanintervalArray1M.AssertModel(models[18],_testData[28], false);
                        TimeSpanintervalArray1M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        TimeSpanintervalArray1M.AssertModel(models[0],_testData[19], false);
                        TimeSpanintervalArray1M.AssertModel(models[1],_testData[20], false);
                        TimeSpanintervalArray1M.AssertModel(models[2],_testData[21], false);
                        TimeSpanintervalArray1M.AssertModel(models[3],_testData[22], false);
                        TimeSpanintervalArray1M.AssertModel(models[4],_testData[23], false);
                        TimeSpanintervalArray1M.AssertModel(models[5],_testData[24], false);
                        TimeSpanintervalArray1M.AssertModel(models[6],_testData[25], false);
                        TimeSpanintervalArray1M.AssertModel(models[7],_testData[26], false);
                        TimeSpanintervalArray1M.AssertModel(models[8],_testData[27], false);
                        TimeSpanintervalArray1M.AssertModel(models[9],_testData[28], false);
                        TimeSpanintervalArray1M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeSpanintervalArray1M), typeof(FlatTimeSpanintervalArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanArrayintervalArray)),
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
            asPartInterface: typeof(ITimeSpanArrayintervalArray)),
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
            asPartInterface: typeof(ITimeSpanArrayintervalArray)),
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
FROM public.timespanintervalarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatTimeSpanintervalArray1M>();
                var models2 = new List<FlatTimeSpanintervalArray1M>();
                await((ITimeSpanArrayintervalArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpanintervalArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpanintervalArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.timespanintervalarray1m m
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
FROM public.timespanintervalarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalArray1M>();
                var firstItems2 = new List<FlatTimeSpanintervalArray1M>();
                var secondItems1 = new List<FlatTimeSpanintervalArray1M>();
                var secondItems2 = new List<FlatTimeSpanintervalArray1M>();
                await ((ITimeSpanArrayintervalArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 138, query1, 35, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[22],_testData[29], false);
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
FROM public.timespanintervalarray1m m
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
FROM public.timespanintervalarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalArray1M>();
                var firstItems2 = new List<FlatTimeSpanintervalArray1M>();
                var secondItems1 = new List<FlatTimeSpanintervalArray1M>();
                await ((ITimeSpanArrayintervalArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 96, query1, 119, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[9],_testData[29], false);
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
FROM public.timespanintervalarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatTimeSpanintervalArray1M>();
                var models2 = new List<FlatTimeSpanintervalArray1M>();
                ((ITimeSpanArrayintervalArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpanintervalArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpanintervalArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.timespanintervalarray1m m
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
FROM public.timespanintervalarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalArray1M>();
                var firstItems2 = new List<FlatTimeSpanintervalArray1M>();
                var secondItems1 = new List<FlatTimeSpanintervalArray1M>();
                var secondItems2 = new List<FlatTimeSpanintervalArray1M>();
                 ((ITimeSpanArrayintervalArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 80, query1, 87, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[14],_testData[29], false);
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
FROM public.timespanintervalarray1m m
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
FROM public.timespanintervalarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalArray1M>();
                var firstItems2 = new List<FlatTimeSpanintervalArray1M>();
                var secondItems1 = new List<FlatTimeSpanintervalArray1M>();
                 ((ITimeSpanArrayintervalArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 8, query1, 123, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[7],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatTimeSpanintervalArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanArrayintervalArray)),
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
            asPartInterface: typeof(ITimeSpanArrayintervalArray)),
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
            asPartInterface: typeof(ITimeSpanArrayintervalArray)),
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
FROM public.timespanintervalarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((ITimeSpanArrayintervalArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpanintervalArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.timespanintervalarray1m m
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
FROM public.timespanintervalarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((ITimeSpanArrayintervalArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 65, query1, 133, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatTimeSpanintervalArray1M.AssertModel(models[0],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[1],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[2],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[3],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[4],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[5],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[6],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[7],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[8],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[9],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[10],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[11],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[12],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[13],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[14],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[15],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[16],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatTimeSpanintervalArray1M.AssertModel(models[0],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[1],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[2],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[3],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[4],_testData[29], false);
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
FROM public.timespanintervalarray1m m
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
FROM public.timespanintervalarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalArray1M>();
                var secondItems1 = new List<FlatTimeSpanintervalArray1M>();
                var secondItems2 = new List<FlatTimeSpanintervalArray1M>();
                await ((ITimeSpanArrayintervalArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 73, query1, 119, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[16],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[9],_testData[29], false);
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
FROM public.timespanintervalarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((ITimeSpanArrayintervalArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatTimeSpanintervalArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.timespanintervalarray1m m
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
FROM public.timespanintervalarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((ITimeSpanArrayintervalArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 148, query1, 15, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatTimeSpanintervalArray1M.AssertModel(models[0],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatTimeSpanintervalArray1M.AssertModel(models[0],_testData[3], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[1],_testData[4], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[2],_testData[5], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[3],_testData[6], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[4],_testData[7], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[5],_testData[8], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[6],_testData[9], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[7],_testData[10], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[8],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[9],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[10],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[11],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[12],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[13],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[14],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[15],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[16],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[17],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[18],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[19],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[20],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[21],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[22],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[23],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[24],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[25],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[26],_testData[29], false);
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
FROM public.timespanintervalarray1m m
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
FROM public.timespanintervalarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatTimeSpanintervalArray1M>();
                var secondItems1 = new List<FlatTimeSpanintervalArray1M>();
                var secondItems2 = new List<FlatTimeSpanintervalArray1M>();
                 ((ITimeSpanArrayintervalArray)this).DbConnectionDynQuerySelectModelBatch(connection, 65, query1, 65, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[17],_testData[29], false);
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
FROM public.timespanintervalarray1m m
LEFT JOIN public.timespanintervalarray1mi mi ON mi.id = m.timespanintervalarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(TimeSpanintervalArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanArrayintervalArray)),
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
            asPartInterface: typeof(ITimeSpanArrayintervalArray)),
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
                var models = await((ITimeSpanArrayintervalArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    TimeSpanintervalArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((ITimeSpanArrayintervalArray)this).DbConnectionSTSelectModelBatchAsync(connection, 20, 80))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        TimeSpanintervalArray1M.AssertModel(models[0],_testData[4], false);
                        TimeSpanintervalArray1M.AssertModel(models[1],_testData[5], false);
                        TimeSpanintervalArray1M.AssertModel(models[2],_testData[6], false);
                        TimeSpanintervalArray1M.AssertModel(models[3],_testData[7], false);
                        TimeSpanintervalArray1M.AssertModel(models[4],_testData[8], false);
                        TimeSpanintervalArray1M.AssertModel(models[5],_testData[9], false);
                        TimeSpanintervalArray1M.AssertModel(models[6],_testData[10], false);
                        TimeSpanintervalArray1M.AssertModel(models[7],_testData[11], false);
                        TimeSpanintervalArray1M.AssertModel(models[8],_testData[12], false);
                        TimeSpanintervalArray1M.AssertModel(models[9],_testData[13], false);
                        TimeSpanintervalArray1M.AssertModel(models[10],_testData[14], false);
                        TimeSpanintervalArray1M.AssertModel(models[11],_testData[15], false);
                        TimeSpanintervalArray1M.AssertModel(models[12],_testData[16], false);
                        TimeSpanintervalArray1M.AssertModel(models[13],_testData[17], false);
                        TimeSpanintervalArray1M.AssertModel(models[14],_testData[18], false);
                        TimeSpanintervalArray1M.AssertModel(models[15],_testData[19], false);
                        TimeSpanintervalArray1M.AssertModel(models[16],_testData[20], false);
                        TimeSpanintervalArray1M.AssertModel(models[17],_testData[21], false);
                        TimeSpanintervalArray1M.AssertModel(models[18],_testData[22], false);
                        TimeSpanintervalArray1M.AssertModel(models[19],_testData[23], false);
                        TimeSpanintervalArray1M.AssertModel(models[20],_testData[24], false);
                        TimeSpanintervalArray1M.AssertModel(models[21],_testData[25], false);
                        TimeSpanintervalArray1M.AssertModel(models[22],_testData[26], false);
                        TimeSpanintervalArray1M.AssertModel(models[23],_testData[27], false);
                        TimeSpanintervalArray1M.AssertModel(models[24],_testData[28], false);
                        TimeSpanintervalArray1M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        TimeSpanintervalArray1M.AssertModel(models[0],_testData[14], false);
                        TimeSpanintervalArray1M.AssertModel(models[1],_testData[15], false);
                        TimeSpanintervalArray1M.AssertModel(models[2],_testData[16], false);
                        TimeSpanintervalArray1M.AssertModel(models[3],_testData[17], false);
                        TimeSpanintervalArray1M.AssertModel(models[4],_testData[18], false);
                        TimeSpanintervalArray1M.AssertModel(models[5],_testData[19], false);
                        TimeSpanintervalArray1M.AssertModel(models[6],_testData[20], false);
                        TimeSpanintervalArray1M.AssertModel(models[7],_testData[21], false);
                        TimeSpanintervalArray1M.AssertModel(models[8],_testData[22], false);
                        TimeSpanintervalArray1M.AssertModel(models[9],_testData[23], false);
                        TimeSpanintervalArray1M.AssertModel(models[10],_testData[24], false);
                        TimeSpanintervalArray1M.AssertModel(models[11],_testData[25], false);
                        TimeSpanintervalArray1M.AssertModel(models[12],_testData[26], false);
                        TimeSpanintervalArray1M.AssertModel(models[13],_testData[27], false);
                        TimeSpanintervalArray1M.AssertModel(models[14],_testData[28], false);
                        TimeSpanintervalArray1M.AssertModel(models[15],_testData[29], false);
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
                var models = ((ITimeSpanArrayintervalArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    TimeSpanintervalArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((ITimeSpanArrayintervalArray)this).DbConnectionSTSelectModelBatch(connection, 139, 119))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        TimeSpanintervalArray1M.AssertModel(models[0],_testData[27], false);
                        TimeSpanintervalArray1M.AssertModel(models[1],_testData[28], false);
                        TimeSpanintervalArray1M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        TimeSpanintervalArray1M.AssertModel(models[0],_testData[20], false);
                        TimeSpanintervalArray1M.AssertModel(models[1],_testData[21], false);
                        TimeSpanintervalArray1M.AssertModel(models[2],_testData[22], false);
                        TimeSpanintervalArray1M.AssertModel(models[3],_testData[23], false);
                        TimeSpanintervalArray1M.AssertModel(models[4],_testData[24], false);
                        TimeSpanintervalArray1M.AssertModel(models[5],_testData[25], false);
                        TimeSpanintervalArray1M.AssertModel(models[6],_testData[26], false);
                        TimeSpanintervalArray1M.AssertModel(models[7],_testData[27], false);
                        TimeSpanintervalArray1M.AssertModel(models[8],_testData[28], false);
                        TimeSpanintervalArray1M.AssertModel(models[9],_testData[29], false);
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
                await using var cmd = await ((ITimeSpanArrayintervalArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((ITimeSpanArrayintervalArray)this).SetDbConnectionSelectModelParametrs(cmd, 120);
                var models = await ((ITimeSpanArrayintervalArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(9));
TimeSpanintervalArray1M.AssertModel(models[0],_testData[21], false);TimeSpanintervalArray1M.AssertModel(models[1],_testData[22], false);TimeSpanintervalArray1M.AssertModel(models[2],_testData[23], false);TimeSpanintervalArray1M.AssertModel(models[3],_testData[24], false);TimeSpanintervalArray1M.AssertModel(models[4],_testData[25], false);TimeSpanintervalArray1M.AssertModel(models[5],_testData[26], false);TimeSpanintervalArray1M.AssertModel(models[6],_testData[27], false);TimeSpanintervalArray1M.AssertModel(models[7],_testData[28], false);TimeSpanintervalArray1M.AssertModel(models[8],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ITimeSpanArrayintervalArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((ITimeSpanArrayintervalArray)this).SetDbConnectionSelectModelParametrs(cmd, 35);
                var models =  ((ITimeSpanArrayintervalArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(23));
TimeSpanintervalArray1M.AssertModel(models[0],_testData[7], false);TimeSpanintervalArray1M.AssertModel(models[1],_testData[8], false);TimeSpanintervalArray1M.AssertModel(models[2],_testData[9], false);TimeSpanintervalArray1M.AssertModel(models[3],_testData[10], false);TimeSpanintervalArray1M.AssertModel(models[4],_testData[11], false);TimeSpanintervalArray1M.AssertModel(models[5],_testData[12], false);TimeSpanintervalArray1M.AssertModel(models[6],_testData[13], false);TimeSpanintervalArray1M.AssertModel(models[7],_testData[14], false);TimeSpanintervalArray1M.AssertModel(models[8],_testData[15], false);TimeSpanintervalArray1M.AssertModel(models[9],_testData[16], false);TimeSpanintervalArray1M.AssertModel(models[10],_testData[17], false);TimeSpanintervalArray1M.AssertModel(models[11],_testData[18], false);TimeSpanintervalArray1M.AssertModel(models[12],_testData[19], false);TimeSpanintervalArray1M.AssertModel(models[13],_testData[20], false);TimeSpanintervalArray1M.AssertModel(models[14],_testData[21], false);TimeSpanintervalArray1M.AssertModel(models[15],_testData[22], false);TimeSpanintervalArray1M.AssertModel(models[16],_testData[23], false);TimeSpanintervalArray1M.AssertModel(models[17],_testData[24], false);TimeSpanintervalArray1M.AssertModel(models[18],_testData[25], false);TimeSpanintervalArray1M.AssertModel(models[19],_testData[26], false);TimeSpanintervalArray1M.AssertModel(models[20],_testData[27], false);TimeSpanintervalArray1M.AssertModel(models[21],_testData[28], false);TimeSpanintervalArray1M.AssertModel(models[22],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_timespanintervalarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(TimeSpanintervalArray1MI),
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
            asPartInterface: typeof(ITimeSpanArrayintervalArray))]
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
FROM public.binary_timespanintervalarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanArrayintervalArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<TimeSpanintervalArray1MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((ITimeSpanArrayintervalArray)this).ImportModelInner(connection, importCollection);
                var models = ((ITimeSpanArrayintervalArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeSpanintervalArray1MI.AssertModel(actual, expect, false);
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
                await ((ITimeSpanArrayintervalArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((ITimeSpanArrayintervalArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeSpanintervalArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_timespanintervalarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
timespanintervalarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(TimeSpanintervalArray1M),
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
            asPartInterface: typeof(ITimeSpanArrayintervalArray))]
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
FROM public.binary_timespanintervalarray1m m
LEFT JOIN public.binary_timespanintervalarray1mi mi ON mi.id = m.timespanintervalarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(TimeSpanintervalArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanArrayintervalArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<TimeSpanintervalArray1M>(15);

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
                ((ITimeSpanArrayintervalArray)this).ImportModel(connection, importCollection);
                var models = ((ITimeSpanArrayintervalArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                TimeSpanintervalArray1M.AssertModel(models[0],_testData[0], false);
                TimeSpanintervalArray1M.AssertModel(models[1],_testData[1], false);
                TimeSpanintervalArray1M.AssertModel(models[2],_testData[2], false);
                TimeSpanintervalArray1M.AssertModel(models[3],_testData[3], false);
                TimeSpanintervalArray1M.AssertModel(models[4],_testData[4], false);
                TimeSpanintervalArray1M.AssertModel(models[5],_testData[5], false);
                TimeSpanintervalArray1M.AssertModel(models[6],_testData[6], false);
                TimeSpanintervalArray1M.AssertModel(models[7],_testData[7], false);
                TimeSpanintervalArray1M.AssertModel(models[8],_testData[8], false);
                TimeSpanintervalArray1M.AssertModel(models[9],_testData[9], false);
                TimeSpanintervalArray1M.AssertModel(models[10],_testData[10], false);
                TimeSpanintervalArray1M.AssertModel(models[11],_testData[11], false);
                TimeSpanintervalArray1M.AssertModel(models[12],_testData[12], false);
                TimeSpanintervalArray1M.AssertModel(models[13],_testData[13], false);
                TimeSpanintervalArray1M.AssertModel(models[14],_testData[14], false);
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
                await ((ITimeSpanArrayintervalArray)this).ImportModelAsync(connection, importCollection);
                models = await ((ITimeSpanArrayintervalArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                TimeSpanintervalArray1M.AssertModel(models[0],_testData[0], false);
                TimeSpanintervalArray1M.AssertModel(models[1],_testData[1], false);
                TimeSpanintervalArray1M.AssertModel(models[2],_testData[2], false);
                TimeSpanintervalArray1M.AssertModel(models[3],_testData[3], false);
                TimeSpanintervalArray1M.AssertModel(models[4],_testData[4], false);
                TimeSpanintervalArray1M.AssertModel(models[5],_testData[5], false);
                TimeSpanintervalArray1M.AssertModel(models[6],_testData[6], false);
                TimeSpanintervalArray1M.AssertModel(models[7],_testData[7], false);
                TimeSpanintervalArray1M.AssertModel(models[8],_testData[8], false);
                TimeSpanintervalArray1M.AssertModel(models[9],_testData[9], false);
                TimeSpanintervalArray1M.AssertModel(models[10],_testData[10], false);
                TimeSpanintervalArray1M.AssertModel(models[11],_testData[11], false);
                TimeSpanintervalArray1M.AssertModel(models[12],_testData[12], false);
                TimeSpanintervalArray1M.AssertModel(models[13],_testData[13], false);
                TimeSpanintervalArray1M.AssertModel(models[14],_testData[14], false);
                TimeSpanintervalArray1M.AssertModel(models[15],_testData[15], false);
                TimeSpanintervalArray1M.AssertModel(models[16],_testData[16], false);
                TimeSpanintervalArray1M.AssertModel(models[17],_testData[17], false);
                TimeSpanintervalArray1M.AssertModel(models[18],_testData[18], false);
                TimeSpanintervalArray1M.AssertModel(models[19],_testData[19], false);
                TimeSpanintervalArray1M.AssertModel(models[20],_testData[20], false);
                TimeSpanintervalArray1M.AssertModel(models[21],_testData[21], false);
                TimeSpanintervalArray1M.AssertModel(models[22],_testData[22], false);
                TimeSpanintervalArray1M.AssertModel(models[23],_testData[23], false);
                TimeSpanintervalArray1M.AssertModel(models[24],_testData[24], false);
                TimeSpanintervalArray1M.AssertModel(models[25],_testData[25], false);
                TimeSpanintervalArray1M.AssertModel(models[26],_testData[26], false);
                TimeSpanintervalArray1M.AssertModel(models[27],_testData[27], false);
                TimeSpanintervalArray1M.AssertModel(models[28],_testData[28], false);
                TimeSpanintervalArray1M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_timespanintervalarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    timespanintervalarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(TimeSpanintervalArray1M)],
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
            asPartInterface: typeof(ITimeSpanArrayintervalArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((ITimeSpanArrayintervalArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    TimeSpanintervalArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((ITimeSpanArrayintervalArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    TimeSpanintervalArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_timespanintervalarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalArray1MI)],
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
            asPartInterface: typeof(ITimeSpanArrayintervalArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((ITimeSpanArrayintervalArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    TimeSpanintervalArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((ITimeSpanArrayintervalArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    TimeSpanintervalArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

