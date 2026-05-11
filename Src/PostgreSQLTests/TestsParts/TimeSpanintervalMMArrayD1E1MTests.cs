

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
    Id = 1,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 1, minutes: 52, seconds: 58, milliseconds: 179),
new TimeSpan(days: 0, hours: 15, minutes: 46, seconds: 30, milliseconds: 330),
new TimeSpan(days: 0, hours: 5, minutes: 14, seconds: 7, milliseconds: 573),
new TimeSpan(days: 0, hours: 5, minutes: 47, seconds: 19, milliseconds: 462),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 18, minutes: 27, seconds: 24, milliseconds: 305),
new TimeSpan(days: 0, hours: 18, minutes: 49, seconds: 11, milliseconds: 144),
new TimeSpan(days: 0, hours: 16, minutes: 28, seconds: 15, milliseconds: 241),
},
},
            new TimeSpanintervalMMArrayD1E1M
{
    Id = 9,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 9, minutes: 16, seconds: 26, milliseconds: 143),
new TimeSpan(days: 0, hours: 3, minutes: 0, seconds: 26, milliseconds: 428),
new TimeSpan(days: 0, hours: 18, minutes: 0, seconds: 31, milliseconds: 344),
new TimeSpan(days: 0, hours: 8, minutes: 50, seconds: 33, milliseconds: 751),
},
    ModelInner = new TimeSpanintervalMMArrayD1E1MI
{
    Id = 1,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 4, seconds: 56, milliseconds: 359),
new TimeSpan(days: 0, hours: 11, minutes: 21, seconds: 51, milliseconds: 933),
new TimeSpan(days: 0, hours: 20, minutes: 17, seconds: 50, milliseconds: 82),
new TimeSpan(days: 0, hours: 11, minutes: 17, seconds: 15, milliseconds: 888),
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 12, minutes: 38, seconds: 45, milliseconds: 717),
new TimeSpan(days: 0, hours: 11, minutes: 26, seconds: 25, milliseconds: 414),
new TimeSpan(days: 0, hours: 10, minutes: 45, seconds: 57, milliseconds: 325),
},
},
    NullableValue = null,
},
            new TimeSpanintervalMMArrayD1E1M
{
    Id = 10,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 1, seconds: 44, milliseconds: 770),
new TimeSpan(days: 0, hours: 14, minutes: 1, seconds: 5, milliseconds: 201),
new TimeSpan(days: 0, hours: 17, minutes: 7, seconds: 42, milliseconds: 35),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalMMArrayD1E1M
{
    Id = 19,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 2, minutes: 32, seconds: 29, milliseconds: 12),
new TimeSpan(days: 0, hours: 16, minutes: 11, seconds: 43, milliseconds: 892),
new TimeSpan(days: 0, hours: 6, minutes: 26, seconds: 48, milliseconds: 847),
new TimeSpan(days: 0, hours: 14, minutes: 20, seconds: 6, milliseconds: 174),
},
    ModelInner = new TimeSpanintervalMMArrayD1E1MI
{
    Id = 4,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 15, seconds: 40, milliseconds: 412),
new TimeSpan(days: 0, hours: 18, minutes: 58, seconds: 47, milliseconds: 773),
new TimeSpan(days: 0, hours: 13, minutes: 37, seconds: 38, milliseconds: 657),
new TimeSpan(days: 0, hours: 8, minutes: 43, seconds: 22, milliseconds: 819),
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 5, minutes: 53, seconds: 21, milliseconds: 320),
new TimeSpan(days: 0, hours: 12, minutes: 44, seconds: 38, milliseconds: 201),
new TimeSpan(days: 0, hours: 5, minutes: 9, seconds: 8, milliseconds: 504),
new TimeSpan(days: 0, hours: 5, minutes: 27, seconds: 11, milliseconds: 15),
},
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 16, minutes: 30, seconds: 54, milliseconds: 579),
new TimeSpan(days: 0, hours: 15, minutes: 41, seconds: 23, milliseconds: 176),
new TimeSpan(days: 0, hours: 14, minutes: 2, seconds: 57, milliseconds: 4),
},
},
            new TimeSpanintervalMMArrayD1E1M
{
    Id = 25,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 4, minutes: 44, seconds: 50, milliseconds: 300),
new TimeSpan(days: 0, hours: 21, minutes: 18, seconds: 40, milliseconds: 16),
new TimeSpan(days: 0, hours: 19, minutes: 12, seconds: 15, milliseconds: 436),
new TimeSpan(days: 0, hours: 7, minutes: 22, seconds: 49, milliseconds: 925),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 14, minutes: 39, seconds: 5, milliseconds: 535),
new TimeSpan(days: 0, hours: 11, minutes: 18, seconds: 20, milliseconds: 873),
new TimeSpan(days: 0, hours: 14, minutes: 43, seconds: 40, milliseconds: 281),
},
},
            new TimeSpanintervalMMArrayD1E1M
{
    Id = 31,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 10, minutes: 23, seconds: 28, milliseconds: 367),
new TimeSpan(days: 0, hours: 3, minutes: 54, seconds: 34, milliseconds: 963),
new TimeSpan(days: 0, hours: 4, minutes: 48, seconds: 12, milliseconds: 328),
new TimeSpan(days: 0, hours: 4, minutes: 14, seconds: 44, milliseconds: 781),
},
    ModelInner = new TimeSpanintervalMMArrayD1E1MI
{
    Id = 6,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 8, minutes: 7, seconds: 4, milliseconds: 127),
new TimeSpan(days: 0, hours: 3, minutes: 48, seconds: 12, milliseconds: 454),
new TimeSpan(days: 0, hours: 1, minutes: 3, seconds: 47, milliseconds: 290),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 18, minutes: 4, seconds: 45, milliseconds: 667),
new TimeSpan(days: 0, hours: 10, minutes: 27, seconds: 28, milliseconds: 244),
new TimeSpan(days: 0, hours: 9, minutes: 46, seconds: 11, milliseconds: 2),
},
},
            new TimeSpanintervalMMArrayD1E1M
{
    Id = 36,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 13, minutes: 3, seconds: 3, milliseconds: 88),
new TimeSpan(days: 0, hours: 4, minutes: 49, seconds: 42, milliseconds: 453),
new TimeSpan(days: 0, hours: 11, minutes: 11, seconds: 32, milliseconds: 540),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalMMArrayD1E1M
{
    Id = 44,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 4, minutes: 3, seconds: 8, milliseconds: 800),
new TimeSpan(days: 0, hours: 14, minutes: 54, seconds: 57, milliseconds: 435),
new TimeSpan(days: 0, hours: 4, minutes: 41, seconds: 3, milliseconds: 541),
new TimeSpan(days: 0, hours: 15, minutes: 0, seconds: 30, milliseconds: 840),
},
    ModelInner = new TimeSpanintervalMMArrayD1E1MI
{
    Id = 14,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 18, minutes: 46, seconds: 10, milliseconds: 115),
new TimeSpan(days: 0, hours: 11, minutes: 24, seconds: 56, milliseconds: 576),
new TimeSpan(days: 0, hours: 12, minutes: 56, seconds: 23, milliseconds: 398),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 22, minutes: 23, seconds: 42, milliseconds: 769),
new TimeSpan(days: 0, hours: 6, minutes: 57, seconds: 2, milliseconds: 419),
new TimeSpan(days: 0, hours: 21, minutes: 37, seconds: 56, milliseconds: 343),
new TimeSpan(days: 0, hours: 9, minutes: 7, seconds: 10, milliseconds: 483),
},
},
            new TimeSpanintervalMMArrayD1E1M
{
    Id = 48,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 18, minutes: 3, seconds: 37, milliseconds: 86),
new TimeSpan(days: 0, hours: 22, minutes: 34, seconds: 29, milliseconds: 666),
new TimeSpan(days: 0, hours: 1, minutes: 7, seconds: 21, milliseconds: 636),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalMMArrayD1E1M
{
    Id = 53,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 19, minutes: 2, seconds: 15, milliseconds: 197),
new TimeSpan(days: 0, hours: 17, minutes: 11, seconds: 6, milliseconds: 637),
new TimeSpan(days: 0, hours: 18, minutes: 25, seconds: 27, milliseconds: 230),
},
    ModelInner = new TimeSpanintervalMMArrayD1E1MI
{
    Id = 17,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 2, minutes: 50, seconds: 1, milliseconds: 826),
new TimeSpan(days: 0, hours: 0, minutes: 6, seconds: 12, milliseconds: 406),
new TimeSpan(days: 0, hours: 22, minutes: 44, seconds: 36, milliseconds: 765),
new TimeSpan(days: 0, hours: 22, minutes: 49, seconds: 20, milliseconds: 693),
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 20, minutes: 55, seconds: 40, milliseconds: 359),
new TimeSpan(days: 0, hours: 4, minutes: 49, seconds: 53, milliseconds: 885),
new TimeSpan(days: 0, hours: 14, minutes: 48, seconds: 38, milliseconds: 558),
new TimeSpan(days: 0, hours: 6, minutes: 56, seconds: 34, milliseconds: 675),
},
},
    NullableValue = null,
},
            new TimeSpanintervalMMArrayD1E1M
{
    Id = 61,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 1, minutes: 51, seconds: 13, milliseconds: 129),
new TimeSpan(days: 0, hours: 3, minutes: 45, seconds: 53, milliseconds: 795),
new TimeSpan(days: 0, hours: 21, minutes: 52, seconds: 49, milliseconds: 312),
new TimeSpan(days: 0, hours: 7, minutes: 15, seconds: 40, milliseconds: 27),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 0, minutes: 56, seconds: 2, milliseconds: 780),
new TimeSpan(days: 0, hours: 5, minutes: 6, seconds: 55, milliseconds: 871),
new TimeSpan(days: 0, hours: 9, minutes: 23, seconds: 26, milliseconds: 185),
new TimeSpan(days: 0, hours: 6, minutes: 17, seconds: 53, milliseconds: 395),
},
},
            new TimeSpanintervalMMArrayD1E1M
{
    Id = 62,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 58, seconds: 35, milliseconds: 983),
new TimeSpan(days: 0, hours: 14, minutes: 8, seconds: 0, milliseconds: 140),
new TimeSpan(days: 0, hours: 10, minutes: 57, seconds: 31, milliseconds: 331),
},
    ModelInner = new TimeSpanintervalMMArrayD1E1MI
{
    Id = 22,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 20, seconds: 14, milliseconds: 87),
new TimeSpan(days: 0, hours: 4, minutes: 17, seconds: 10, milliseconds: 207),
new TimeSpan(days: 0, hours: 17, minutes: 15, seconds: 7, milliseconds: 159),
new TimeSpan(days: 0, hours: 9, minutes: 55, seconds: 14, milliseconds: 243),
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 10, minutes: 51, seconds: 28, milliseconds: 637),
new TimeSpan(days: 0, hours: 19, minutes: 32, seconds: 14, milliseconds: 555),
new TimeSpan(days: 0, hours: 12, minutes: 46, seconds: 25, milliseconds: 299),
},
},
    NullableValue = null,
},
            new TimeSpanintervalMMArrayD1E1M
{
    Id = 71,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 55, seconds: 42, milliseconds: 899),
new TimeSpan(days: 0, hours: 21, minutes: 58, seconds: 29, milliseconds: 74),
new TimeSpan(days: 0, hours: 19, minutes: 31, seconds: 30, milliseconds: 865),
new TimeSpan(days: 0, hours: 13, minutes: 49, seconds: 27, milliseconds: 906),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 17, minutes: 30, seconds: 13, milliseconds: 10),
new TimeSpan(days: 0, hours: 19, minutes: 4, seconds: 26, milliseconds: 439),
new TimeSpan(days: 0, hours: 3, minutes: 37, seconds: 57, milliseconds: 672),
},
},
            new TimeSpanintervalMMArrayD1E1M
{
    Id = 79,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 3, seconds: 43, milliseconds: 901),
new TimeSpan(days: 0, hours: 8, minutes: 8, seconds: 16, milliseconds: 175),
new TimeSpan(days: 0, hours: 0, minutes: 57, seconds: 49, milliseconds: 368),
new TimeSpan(days: 0, hours: 16, minutes: 58, seconds: 14, milliseconds: 453),
},
    ModelInner = new TimeSpanintervalMMArrayD1E1MI
{
    Id = 23,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 8, minutes: 56, seconds: 6, milliseconds: 292),
new TimeSpan(days: 0, hours: 4, minutes: 53, seconds: 18, milliseconds: 870),
new TimeSpan(days: 0, hours: 6, minutes: 7, seconds: 52, milliseconds: 262),
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 12, minutes: 13, seconds: 17, milliseconds: 585),
new TimeSpan(days: 0, hours: 10, minutes: 29, seconds: 15, milliseconds: 641),
new TimeSpan(days: 0, hours: 8, minutes: 25, seconds: 55, milliseconds: 603),
},
},
    NullableValue = null,
},
            new TimeSpanintervalMMArrayD1E1M
{
    Id = 86,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 15, seconds: 12, milliseconds: 545),
new TimeSpan(days: 0, hours: 2, minutes: 27, seconds: 25, milliseconds: 396),
new TimeSpan(days: 0, hours: 22, minutes: 5, seconds: 26, milliseconds: 455),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalMMArrayD1E1M
{
    Id = 91,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 2, minutes: 39, seconds: 27, milliseconds: 412),
new TimeSpan(days: 0, hours: 18, minutes: 4, seconds: 0, milliseconds: 632),
new TimeSpan(days: 0, hours: 3, minutes: 47, seconds: 27, milliseconds: 607),
new TimeSpan(days: 0, hours: 1, minutes: 13, seconds: 15, milliseconds: 107),
},
    ModelInner = new TimeSpanintervalMMArrayD1E1MI
{
    Id = 26,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 11, minutes: 37, seconds: 28, milliseconds: 280),
new TimeSpan(days: 0, hours: 20, minutes: 24, seconds: 31, milliseconds: 443),
new TimeSpan(days: 0, hours: 11, minutes: 46, seconds: 6, milliseconds: 938),
new TimeSpan(days: 0, hours: 7, minutes: 23, seconds: 31, milliseconds: 761),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalMMArrayD1E1M
{
    Id = 94,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 2, minutes: 37, seconds: 30, milliseconds: 103),
new TimeSpan(days: 0, hours: 13, minutes: 23, seconds: 51, milliseconds: 288),
new TimeSpan(days: 0, hours: 22, minutes: 49, seconds: 51, milliseconds: 20),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 10, minutes: 50, seconds: 49, milliseconds: 946),
new TimeSpan(days: 0, hours: 19, minutes: 41, seconds: 13, milliseconds: 251),
new TimeSpan(days: 0, hours: 8, minutes: 5, seconds: 1, milliseconds: 272),
},
},
            new TimeSpanintervalMMArrayD1E1M
{
    Id = 95,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 22, minutes: 32, seconds: 9, milliseconds: 39),
new TimeSpan(days: 0, hours: 0, minutes: 16, seconds: 44, milliseconds: 806),
new TimeSpan(days: 0, hours: 18, minutes: 38, seconds: 51, milliseconds: 344),
new TimeSpan(days: 0, hours: 21, minutes: 35, seconds: 49, milliseconds: 925),
},
    ModelInner = new TimeSpanintervalMMArrayD1E1MI
{
    Id = 31,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 13, minutes: 48, seconds: 5, milliseconds: 714),
new TimeSpan(days: 0, hours: 13, minutes: 25, seconds: 32, milliseconds: 678),
new TimeSpan(days: 0, hours: 1, minutes: 38, seconds: 30, milliseconds: 498),
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 17, seconds: 11, milliseconds: 30),
new TimeSpan(days: 0, hours: 8, minutes: 47, seconds: 14, milliseconds: 176),
new TimeSpan(days: 0, hours: 8, minutes: 52, seconds: 57, milliseconds: 928),
},
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 15, minutes: 19, seconds: 42, milliseconds: 451),
new TimeSpan(days: 0, hours: 16, minutes: 48, seconds: 0, milliseconds: 968),
new TimeSpan(days: 0, hours: 17, minutes: 1, seconds: 8, milliseconds: 330),
new TimeSpan(days: 0, hours: 7, minutes: 43, seconds: 19, milliseconds: 213),
},
},
            new TimeSpanintervalMMArrayD1E1M
{
    Id = 99,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 14, minutes: 2, seconds: 57, milliseconds: 554),
new TimeSpan(days: 0, hours: 5, minutes: 51, seconds: 22, milliseconds: 75),
new TimeSpan(days: 0, hours: 1, minutes: 0, seconds: 33, milliseconds: 170),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 20, minutes: 0, seconds: 49, milliseconds: 279),
new TimeSpan(days: 0, hours: 10, minutes: 5, seconds: 31, milliseconds: 405),
new TimeSpan(days: 0, hours: 7, minutes: 58, seconds: 21, milliseconds: 319),
new TimeSpan(days: 0, hours: 0, minutes: 9, seconds: 33, milliseconds: 158),
},
},
            new TimeSpanintervalMMArrayD1E1M
{
    Id = 108,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 12, minutes: 20, seconds: 55, milliseconds: 462),
new TimeSpan(days: 0, hours: 5, minutes: 16, seconds: 17, milliseconds: 6),
new TimeSpan(days: 0, hours: 12, minutes: 12, seconds: 53, milliseconds: 182),
new TimeSpan(days: 0, hours: 11, minutes: 44, seconds: 6, milliseconds: 663),
},
    ModelInner = new TimeSpanintervalMMArrayD1E1MI
{
    Id = 32,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 34, seconds: 4, milliseconds: 950),
new TimeSpan(days: 0, hours: 18, minutes: 41, seconds: 21, milliseconds: 990),
new TimeSpan(days: 0, hours: 1, minutes: 55, seconds: 5, milliseconds: 714),
new TimeSpan(days: 0, hours: 11, minutes: 28, seconds: 32, milliseconds: 512),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalMMArrayD1E1M
{
    Id = 116,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 17, minutes: 40, seconds: 38, milliseconds: 565),
new TimeSpan(days: 0, hours: 17, minutes: 32, seconds: 6, milliseconds: 500),
new TimeSpan(days: 0, hours: 7, minutes: 40, seconds: 18, milliseconds: 46),
new TimeSpan(days: 0, hours: 21, minutes: 58, seconds: 47, milliseconds: 703),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 15, minutes: 35, seconds: 15, milliseconds: 489),
new TimeSpan(days: 0, hours: 11, minutes: 13, seconds: 39, milliseconds: 198),
new TimeSpan(days: 0, hours: 10, minutes: 56, seconds: 33, milliseconds: 726),
new TimeSpan(days: 0, hours: 21, minutes: 0, seconds: 6, milliseconds: 541),
},
},
            new TimeSpanintervalMMArrayD1E1M
{
    Id = 123,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 7, minutes: 43, seconds: 1, milliseconds: 221),
new TimeSpan(days: 0, hours: 22, minutes: 21, seconds: 12, milliseconds: 997),
new TimeSpan(days: 0, hours: 22, minutes: 45, seconds: 41, milliseconds: 448),
new TimeSpan(days: 0, hours: 13, minutes: 15, seconds: 52, milliseconds: 848),
},
    ModelInner = new TimeSpanintervalMMArrayD1E1MI
{
    Id = 33,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 8, minutes: 40, seconds: 6, milliseconds: 358),
new TimeSpan(days: 0, hours: 3, minutes: 47, seconds: 11, milliseconds: 257),
new TimeSpan(days: 0, hours: 19, minutes: 13, seconds: 22, milliseconds: 364),
new TimeSpan(days: 0, hours: 11, minutes: 58, seconds: 40, milliseconds: 904),
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 0, minutes: 14, seconds: 9, milliseconds: 892),
new TimeSpan(days: 0, hours: 2, minutes: 37, seconds: 52, milliseconds: 633),
new TimeSpan(days: 0, hours: 14, minutes: 3, seconds: 10, milliseconds: 550),
new TimeSpan(days: 0, hours: 3, minutes: 44, seconds: 18, milliseconds: 991),
},
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 1, seconds: 39, milliseconds: 630),
new TimeSpan(days: 0, hours: 21, minutes: 12, seconds: 44, milliseconds: 250),
new TimeSpan(days: 0, hours: 5, minutes: 50, seconds: 4, milliseconds: 360),
new TimeSpan(days: 0, hours: 11, minutes: 47, seconds: 43, milliseconds: 940),
},
},
            new TimeSpanintervalMMArrayD1E1M
{
    Id = 125,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 21, minutes: 7, seconds: 49, milliseconds: 988),
new TimeSpan(days: 0, hours: 11, minutes: 0, seconds: 16, milliseconds: 56),
new TimeSpan(days: 0, hours: 20, minutes: 3, seconds: 28, milliseconds: 395),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalMMArrayD1E1M
{
    Id = 133,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 29, seconds: 32, milliseconds: 103),
new TimeSpan(days: 0, hours: 12, minutes: 44, seconds: 51, milliseconds: 178),
new TimeSpan(days: 0, hours: 15, minutes: 38, seconds: 6, milliseconds: 280),
},
    ModelInner = new TimeSpanintervalMMArrayD1E1MI
{
    Id = 37,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 3, minutes: 50, seconds: 33, milliseconds: 827),
new TimeSpan(days: 0, hours: 6, minutes: 11, seconds: 54, milliseconds: 899),
new TimeSpan(days: 0, hours: 18, minutes: 53, seconds: 37, milliseconds: 12),
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 50, seconds: 30, milliseconds: 473),
new TimeSpan(days: 0, hours: 11, minutes: 29, seconds: 17, milliseconds: 516),
new TimeSpan(days: 0, hours: 10, minutes: 52, seconds: 44, milliseconds: 193),
},
},
    NullableValue = null,
},
            new TimeSpanintervalMMArrayD1E1M
{
    Id = 135,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 8, seconds: 6, milliseconds: 998),
new TimeSpan(days: 0, hours: 5, minutes: 55, seconds: 27, milliseconds: 223),
new TimeSpan(days: 0, hours: 15, minutes: 41, seconds: 44, milliseconds: 480),
new TimeSpan(days: 0, hours: 7, minutes: 19, seconds: 22, milliseconds: 600),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 5, minutes: 54, seconds: 8, milliseconds: 52),
new TimeSpan(days: 0, hours: 11, minutes: 52, seconds: 38, milliseconds: 724),
new TimeSpan(days: 0, hours: 3, minutes: 26, seconds: 52, milliseconds: 915),
new TimeSpan(days: 0, hours: 17, minutes: 31, seconds: 3, milliseconds: 695),
},
},
            new TimeSpanintervalMMArrayD1E1M
{
    Id = 139,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 22, seconds: 21, milliseconds: 309),
new TimeSpan(days: 0, hours: 1, minutes: 46, seconds: 28, milliseconds: 541),
new TimeSpan(days: 0, hours: 8, minutes: 36, seconds: 30, milliseconds: 674),
new TimeSpan(days: 0, hours: 22, minutes: 12, seconds: 49, milliseconds: 353),
},
    ModelInner = new TimeSpanintervalMMArrayD1E1MI
{
    Id = 41,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 43, seconds: 10, milliseconds: 64),
new TimeSpan(days: 0, hours: 6, minutes: 58, seconds: 11, milliseconds: 113),
new TimeSpan(days: 0, hours: 14, minutes: 26, seconds: 49, milliseconds: 633),
new TimeSpan(days: 0, hours: 13, minutes: 10, seconds: 32, milliseconds: 602),
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 18, minutes: 3, seconds: 37, milliseconds: 696),
new TimeSpan(days: 0, hours: 10, minutes: 4, seconds: 28, milliseconds: 581),
new TimeSpan(days: 0, hours: 18, minutes: 38, seconds: 37, milliseconds: 171),
new TimeSpan(days: 0, hours: 5, minutes: 27, seconds: 51, milliseconds: 113),
},
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 3, minutes: 1, seconds: 21, milliseconds: 505),
new TimeSpan(days: 0, hours: 22, minutes: 22, seconds: 51, milliseconds: 731),
new TimeSpan(days: 0, hours: 17, minutes: 38, seconds: 0, milliseconds: 442),
new TimeSpan(days: 0, hours: 3, minutes: 58, seconds: 40, milliseconds: 610),
},
},
            new TimeSpanintervalMMArrayD1E1M
{
    Id = 142,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 8, minutes: 21, seconds: 20, milliseconds: 905),
new TimeSpan(days: 0, hours: 9, minutes: 56, seconds: 4, milliseconds: 783),
new TimeSpan(days: 0, hours: 7, minutes: 8, seconds: 55, milliseconds: 897),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalMMArrayD1E1M
{
    Id = 147,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 11, minutes: 13, seconds: 3, milliseconds: 241),
new TimeSpan(days: 0, hours: 12, minutes: 22, seconds: 17, milliseconds: 573),
new TimeSpan(days: 0, hours: 18, minutes: 15, seconds: 11, milliseconds: 538),
},
    ModelInner = new TimeSpanintervalMMArrayD1E1MI
{
    Id = 49,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 7, minutes: 52, seconds: 19, milliseconds: 490),
new TimeSpan(days: 0, hours: 6, minutes: 42, seconds: 15, milliseconds: 493),
new TimeSpan(days: 0, hours: 18, minutes: 44, seconds: 22, milliseconds: 211),
new TimeSpan(days: 0, hours: 3, minutes: 27, seconds: 36, milliseconds: 305),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalMMArrayD1E1M
{
    Id = 148,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 21, minutes: 26, seconds: 21, milliseconds: 649),
new TimeSpan(days: 0, hours: 15, minutes: 42, seconds: 45, milliseconds: 738),
new TimeSpan(days: 0, hours: 21, minutes: 22, seconds: 21, milliseconds: 336),
new TimeSpan(days: 0, hours: 18, minutes: 57, seconds: 23, milliseconds: 68),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalMMArrayD1E1M
{
    Id = 154,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 12, minutes: 35, seconds: 12, milliseconds: 384),
new TimeSpan(days: 0, hours: 9, minutes: 55, seconds: 54, milliseconds: 240),
new TimeSpan(days: 0, hours: 3, minutes: 35, seconds: 25, milliseconds: 191),
},
    ModelInner = new TimeSpanintervalMMArrayD1E1MI
{
    Id = 56,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 11, minutes: 40, seconds: 11, milliseconds: 837),
new TimeSpan(days: 0, hours: 16, minutes: 14, seconds: 40, milliseconds: 41),
new TimeSpan(days: 0, hours: 12, minutes: 6, seconds: 25, milliseconds: 666),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 11, minutes: 47, seconds: 30, milliseconds: 185),
new TimeSpan(days: 0, hours: 8, minutes: 41, seconds: 36, milliseconds: 181),
new TimeSpan(days: 0, hours: 18, minutes: 19, seconds: 16, milliseconds: 614),
new TimeSpan(days: 0, hours: 10, minutes: 16, seconds: 4, milliseconds: 724),
},
},
            new TimeSpanintervalMMArrayD1E1M
{
    Id = 162,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 11, minutes: 3, seconds: 26, milliseconds: 606),
new TimeSpan(days: 0, hours: 4, minutes: 26, seconds: 52, milliseconds: 486),
new TimeSpan(days: 0, hours: 21, minutes: 19, seconds: 41, milliseconds: 800),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalMMArrayD1E1M
{
    Id = 169,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 4, minutes: 23, seconds: 17, milliseconds: 457),
new TimeSpan(days: 0, hours: 3, minutes: 9, seconds: 36, milliseconds: 993),
new TimeSpan(days: 0, hours: 11, minutes: 33, seconds: 37, milliseconds: 126),
},
    ModelInner = new TimeSpanintervalMMArrayD1E1MI
{
    Id = 58,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 14, minutes: 51, seconds: 2, milliseconds: 198),
new TimeSpan(days: 0, hours: 1, minutes: 20, seconds: 58, milliseconds: 73),
new TimeSpan(days: 0, hours: 15, minutes: 2, seconds: 43, milliseconds: 244),
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 1, minutes: 10, seconds: 40, milliseconds: 595),
new TimeSpan(days: 0, hours: 19, minutes: 21, seconds: 10, milliseconds: 908),
new TimeSpan(days: 0, hours: 12, minutes: 31, seconds: 34, milliseconds: 686),
new TimeSpan(days: 0, hours: 0, minutes: 50, seconds: 51, milliseconds: 307),
},
},
    NullableValue = null,
},
            new TimeSpanintervalMMArrayD1E1M
{
    Id = 174,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 18, minutes: 4, seconds: 49, milliseconds: 806),
new TimeSpan(days: 0, hours: 12, minutes: 42, seconds: 12, milliseconds: 862),
new TimeSpan(days: 0, hours: 20, minutes: 31, seconds: 34, milliseconds: 964),
new TimeSpan(days: 0, hours: 5, minutes: 51, seconds: 10, milliseconds: 205),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 1, minutes: 21, seconds: 19, milliseconds: 762),
new TimeSpan(days: 0, hours: 13, minutes: 45, seconds: 16, milliseconds: 222),
new TimeSpan(days: 0, hours: 14, minutes: 1, seconds: 43, milliseconds: 342),
new TimeSpan(days: 0, hours: 22, minutes: 33, seconds: 23, milliseconds: 448),
},
},
            new TimeSpanintervalMMArrayD1E1M
{
    Id = 175,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 14, minutes: 27, seconds: 9, milliseconds: 777),
new TimeSpan(days: 0, hours: 11, minutes: 26, seconds: 12, milliseconds: 202),
new TimeSpan(days: 0, hours: 9, minutes: 41, seconds: 9, milliseconds: 755),
},
    ModelInner = new TimeSpanintervalMMArrayD1E1MI
{
    Id = 63,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 14, minutes: 22, seconds: 28, milliseconds: 518),
new TimeSpan(days: 0, hours: 5, minutes: 49, seconds: 38, milliseconds: 372),
new TimeSpan(days: 0, hours: 20, minutes: 50, seconds: 34, milliseconds: 449),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalMMArrayD1E1M
{
    Id = 182,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 1, minutes: 1, seconds: 11, milliseconds: 198),
new TimeSpan(days: 0, hours: 14, minutes: 25, seconds: 15, milliseconds: 825),
new TimeSpan(days: 0, hours: 17, minutes: 31, seconds: 52, milliseconds: 547),
new TimeSpan(days: 0, hours: 5, minutes: 8, seconds: 39, milliseconds: 957),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 8, minutes: 8, seconds: 52, milliseconds: 595),
new TimeSpan(days: 0, hours: 21, minutes: 36, seconds: 17, milliseconds: 587),
new TimeSpan(days: 0, hours: 22, minutes: 15, seconds: 23, milliseconds: 627),
new TimeSpan(days: 0, hours: 17, minutes: 3, seconds: 1, milliseconds: 498),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 14, minutes: 39, seconds: 5, milliseconds: 535),
new TimeSpan(days: 0, hours: 11, minutes: 18, seconds: 20, milliseconds: 873),
new TimeSpan(days: 0, hours: 14, minutes: 43, seconds: 40, milliseconds: 281),
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

                    nullable =  ((ITimeSpanMArrayintervalMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 18, minutes: 4, seconds: 45, milliseconds: 667),
new TimeSpan(days: 0, hours: 10, minutes: 27, seconds: 28, milliseconds: 244),
new TimeSpan(days: 0, hours: 9, minutes: 46, seconds: 11, milliseconds: 2),
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
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 22, minutes: 23, seconds: 42, milliseconds: 769),
new TimeSpan(days: 0, hours: 6, minutes: 57, seconds: 2, milliseconds: 419),
new TimeSpan(days: 0, hours: 21, minutes: 37, seconds: 56, milliseconds: 343),
new TimeSpan(days: 0, hours: 9, minutes: 7, seconds: 10, milliseconds: 483),
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 0, minutes: 56, seconds: 2, milliseconds: 780),
new TimeSpan(days: 0, hours: 5, minutes: 6, seconds: 55, milliseconds: 871),
new TimeSpan(days: 0, hours: 9, minutes: 23, seconds: 26, milliseconds: 185),
new TimeSpan(days: 0, hours: 6, minutes: 17, seconds: 53, milliseconds: 395),
}));
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
                parametr1.Value = 71;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 91;
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
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[18],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 91;
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
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[20],_testData[34], false);
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
                parametr1.Value = 36;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 139;
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 9;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 125;
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
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[11],_testData[34], false);
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
                parametr1.Value = 31;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 1;
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
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[0],_testData[6], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[1],_testData[7], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[2],_testData[8], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[3],_testData[9], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[4],_testData[10], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[5],_testData[11], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[6],_testData[12], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[7],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[8],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[9],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[10],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[11],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[12],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[13],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[14],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[15],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[16],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[17],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[18],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[19],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[20],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[21],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[22],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[23],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[24],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[25],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[26],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[27],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[0],_testData[1], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[1],_testData[2], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[2],_testData[3], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[3],_testData[4], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[4],_testData[5], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[5],_testData[6], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[6],_testData[7], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[7],_testData[8], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[8],_testData[9], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[9],_testData[10], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[10],_testData[11], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[11],_testData[12], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[12],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[13],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[14],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[15],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[16],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[17],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[18],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[19],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[20],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[21],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[22],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[23],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[24],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[25],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[26],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[27],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[28],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[29],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[30],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[31],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[32],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[33],_testData[34], false);
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
                parametr1.Value = 61;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 169;
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
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[23],_testData[34], false);
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
                parametr1.Value = 53;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 142;
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
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[0],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[1],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[2],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[3],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[4],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[5],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[6],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[7],_testData[34], false);
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
                parametr1.Value = 44;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 44;
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
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[26],_testData[34], false);
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
                parametr1.Value = 108;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 142;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((ITimeSpanMArrayintervalMMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[0],_testData[20], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[1],_testData[21], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[2],_testData[22], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[3],_testData[23], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[4],_testData[24], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[5],_testData[25], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[6],_testData[26], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[7],_testData[27], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[8],_testData[28], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[9],_testData[29], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[10],_testData[30], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[11],_testData[31], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[12],_testData[32], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[13],_testData[33], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[0],_testData[27], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[1],_testData[28], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[2],_testData[29], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[3],_testData[30], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[4],_testData[31], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[5],_testData[32], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[6],_testData[33], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[7],_testData[34], false);
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
                parametr1.Value = 133;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 123;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((ITimeSpanMArrayintervalMMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[0],_testData[24], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[1],_testData[25], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[2],_testData[26], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[3],_testData[27], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[4],_testData[28], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[5],_testData[29], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[6],_testData[30], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[7],_testData[31], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[8],_testData[32], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[9],_testData[33], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[0],_testData[22], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[1],_testData[23], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[2],_testData[24], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[3],_testData[25], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[4],_testData[26], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[5],_testData[27], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[6],_testData[28], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[7],_testData[29], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[8],_testData[30], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[9],_testData[31], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[10],_testData[32], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[11],_testData[33], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[12],_testData[34], false);
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
                await ((ITimeSpanMArrayintervalMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 142, query1, 1, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[33],_testData[34], false);
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
                await ((ITimeSpanMArrayintervalMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 61, query1, 79, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[20],_testData[34], false);
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
                 ((ITimeSpanMArrayintervalMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 139, query1, 62, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems2[22],_testData[34], false);
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
                 ((ITimeSpanMArrayintervalMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 19, query1, 79, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(secondItems1[20],_testData[34], false);
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
                foreach(var batchResult in await ((ITimeSpanMArrayintervalMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 44, query1, 36, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[0],_testData[8], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[1],_testData[9], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[2],_testData[10], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[3],_testData[11], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[4],_testData[12], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[5],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[6],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[7],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[8],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[9],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[10],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[11],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[12],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[13],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[14],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[15],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[16],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[17],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[18],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[19],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[20],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[21],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[22],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[23],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[24],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[25],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[0],_testData[7], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[1],_testData[8], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[2],_testData[9], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[3],_testData[10], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[4],_testData[11], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[5],_testData[12], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[6],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[7],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[8],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[9],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[10],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[11],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[12],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[13],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[14],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[15],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[16],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[17],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[18],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[19],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[20],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[21],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[22],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[23],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[24],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[25],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[26],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[27],_testData[34], false);
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
                await ((ITimeSpanMArrayintervalMMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 94, query1, 116, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[17],_testData[34], false);
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
                foreach(var batchResult in  ((ITimeSpanMArrayintervalMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 139, query1, 25, query2))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[0],_testData[5], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[1],_testData[6], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[2],_testData[7], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[3],_testData[8], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[4],_testData[9], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[5],_testData[10], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[6],_testData[11], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[7],_testData[12], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[8],_testData[13], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[9],_testData[14], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[10],_testData[15], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[11],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[12],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[13],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[14],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[15],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[16],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[17],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[18],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[19],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[20],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[21],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[22],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[23],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[24],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[25],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[26],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[27],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[28],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(models[29],_testData[34], false);
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
                 ((ITimeSpanMArrayintervalMMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 91, query1, 116, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatTimeSpanintervalMMArrayD1E1M.AssertModel(firstItems1[18],_testData[34], false);
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
                foreach(var batchResult in await ((ITimeSpanMArrayintervalMMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 139, 125))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[0],_testData[26], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[1],_testData[27], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[2],_testData[28], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[3],_testData[29], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[4],_testData[30], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[5],_testData[31], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[6],_testData[32], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[7],_testData[33], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[0],_testData[23], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[1],_testData[24], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[2],_testData[25], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[3],_testData[26], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[4],_testData[27], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[5],_testData[28], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[6],_testData[29], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[7],_testData[30], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[8],_testData[31], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[9],_testData[32], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[10],_testData[33], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[11],_testData[34], false);
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
                foreach(var batchResult in  ((ITimeSpanMArrayintervalMMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 139, 139))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[0],_testData[26], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[1],_testData[27], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[2],_testData[28], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[3],_testData[29], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[4],_testData[30], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[5],_testData[31], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[6],_testData[32], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[7],_testData[33], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[0],_testData[26], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[1],_testData[27], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[2],_testData[28], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[3],_testData[29], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[4],_testData[30], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[5],_testData[31], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[6],_testData[32], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[7],_testData[33], false);
                        TimeSpanintervalMMArrayD1E1M.AssertModel(models[8],_testData[34], false);
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
                ((ITimeSpanMArrayintervalMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 95);
                var models = await ((ITimeSpanMArrayintervalMMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(17));

                TimeSpanintervalMMArrayD1E1M.AssertModel(models[0],_testData[18], false);
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[1],_testData[19], false);
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[2],_testData[20], false);
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[3],_testData[21], false);
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[4],_testData[22], false);
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[5],_testData[23], false);
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[6],_testData[24], false);
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[7],_testData[25], false);
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[8],_testData[26], false);
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[9],_testData[27], false);
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[10],_testData[28], false);
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[11],_testData[29], false);
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[12],_testData[30], false);
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[13],_testData[31], false);
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[14],_testData[32], false);
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[15],_testData[33], false);
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[16],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ITimeSpanMArrayintervalMMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((ITimeSpanMArrayintervalMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 99);
                var models =  ((ITimeSpanMArrayintervalMMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(16));

                TimeSpanintervalMMArrayD1E1M.AssertModel(models[0],_testData[19], false);
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[1],_testData[20], false);
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[2],_testData[21], false);
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[3],_testData[22], false);
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[4],_testData[23], false);
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[5],_testData[24], false);
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[6],_testData[25], false);
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[7],_testData[26], false);
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[8],_testData[27], false);
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[9],_testData[28], false);
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[10],_testData[29], false);
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[11],_testData[30], false);
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[12],_testData[31], false);
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[13],_testData[32], false);
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[14],_testData[33], false);
                TimeSpanintervalMMArrayD1E1M.AssertModel(models[15],_testData[34], false);
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

