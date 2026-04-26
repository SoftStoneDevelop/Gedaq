

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
    Id = 1,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 18, minutes: 9, seconds: 2, milliseconds: 836),
new TimeSpan(days: 0, hours: 14, minutes: 56, seconds: 10, milliseconds: 97),
new TimeSpan(days: 0, hours: 17, minutes: 29, seconds: 45, milliseconds: 751),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 5, minutes: 24, seconds: 14, milliseconds: 417),
new TimeSpan(days: 0, hours: 11, minutes: 24, seconds: 10, milliseconds: 777),
new TimeSpan(days: 0, hours: 16, minutes: 24, seconds: 46, milliseconds: 300),
new TimeSpan(days: 0, hours: 1, minutes: 43, seconds: 31, milliseconds: 996),
},
},
            new TimeSpanintervalArray1M
{
    Id = 8,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 38, seconds: 15, milliseconds: 881),
new TimeSpan(days: 0, hours: 10, minutes: 17, seconds: 27, milliseconds: 84),
new TimeSpan(days: 0, hours: 9, minutes: 52, seconds: 2, milliseconds: 524),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 1,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 10, minutes: 56, seconds: 28, milliseconds: 675),
new TimeSpan(days: 0, hours: 2, minutes: 17, seconds: 4, milliseconds: 729),
new TimeSpan(days: 0, hours: 6, minutes: 7, seconds: 25, milliseconds: 250),
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 5, minutes: 15, seconds: 13, milliseconds: 496),
new TimeSpan(days: 0, hours: 19, minutes: 49, seconds: 35, milliseconds: 815),
new TimeSpan(days: 0, hours: 10, minutes: 22, seconds: 49, milliseconds: 33),
new TimeSpan(days: 0, hours: 13, minutes: 19, seconds: 45, milliseconds: 304),
},
},
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 14,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 4, minutes: 10, seconds: 12, milliseconds: 578),
new TimeSpan(days: 0, hours: 20, minutes: 41, seconds: 36, milliseconds: 649),
new TimeSpan(days: 0, hours: 13, minutes: 33, seconds: 49, milliseconds: 516),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 2, minutes: 27, seconds: 40, milliseconds: 717),
new TimeSpan(days: 0, hours: 16, minutes: 37, seconds: 29, milliseconds: 247),
new TimeSpan(days: 0, hours: 8, minutes: 41, seconds: 17, milliseconds: 226),
},
},
            new TimeSpanintervalArray1M
{
    Id = 21,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 22, minutes: 37, seconds: 53, milliseconds: 913),
new TimeSpan(days: 0, hours: 5, minutes: 16, seconds: 58, milliseconds: 726),
new TimeSpan(days: 0, hours: 6, minutes: 45, seconds: 12, milliseconds: 876),
new TimeSpan(days: 0, hours: 17, minutes: 56, seconds: 42, milliseconds: 316),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 5,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 4, minutes: 49, seconds: 13, milliseconds: 372),
new TimeSpan(days: 0, hours: 9, minutes: 24, seconds: 53, milliseconds: 384),
new TimeSpan(days: 0, hours: 12, minutes: 24, seconds: 50, milliseconds: 230),
new TimeSpan(days: 0, hours: 14, minutes: 40, seconds: 25, milliseconds: 867),
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 0, minutes: 16, seconds: 30, milliseconds: 511),
new TimeSpan(days: 0, hours: 15, minutes: 45, seconds: 49, milliseconds: 22),
new TimeSpan(days: 0, hours: 12, minutes: 1, seconds: 41, milliseconds: 776),
},
},
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 27,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 31, seconds: 38, milliseconds: 73),
new TimeSpan(days: 0, hours: 11, minutes: 35, seconds: 18, milliseconds: 187),
new TimeSpan(days: 0, hours: 3, minutes: 33, seconds: 57, milliseconds: 461),
new TimeSpan(days: 0, hours: 14, minutes: 47, seconds: 56, milliseconds: 995),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 17, minutes: 55, seconds: 9, milliseconds: 185),
new TimeSpan(days: 0, hours: 8, minutes: 55, seconds: 29, milliseconds: 503),
new TimeSpan(days: 0, hours: 11, minutes: 12, seconds: 46, milliseconds: 353),
new TimeSpan(days: 0, hours: 20, minutes: 32, seconds: 42, milliseconds: 953),
},
},
            new TimeSpanintervalArray1M
{
    Id = 28,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 2, minutes: 28, seconds: 4, milliseconds: 501),
new TimeSpan(days: 0, hours: 18, minutes: 16, seconds: 41, milliseconds: 946),
new TimeSpan(days: 0, hours: 15, minutes: 51, seconds: 4, milliseconds: 545),
new TimeSpan(days: 0, hours: 22, minutes: 4, seconds: 18, milliseconds: 953),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 13,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 13, minutes: 33, seconds: 40, milliseconds: 311),
new TimeSpan(days: 0, hours: 4, minutes: 16, seconds: 26, milliseconds: 92),
new TimeSpan(days: 0, hours: 5, minutes: 53, seconds: 7, milliseconds: 458),
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 3, minutes: 23, seconds: 5, milliseconds: 844),
new TimeSpan(days: 0, hours: 14, minutes: 37, seconds: 48, milliseconds: 127),
new TimeSpan(days: 0, hours: 1, minutes: 24, seconds: 55, milliseconds: 592),
new TimeSpan(days: 0, hours: 6, minutes: 50, seconds: 39, milliseconds: 872),
},
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 18, minutes: 24, seconds: 35, milliseconds: 783),
new TimeSpan(days: 0, hours: 4, minutes: 16, seconds: 51, milliseconds: 547),
new TimeSpan(days: 0, hours: 20, minutes: 11, seconds: 58, milliseconds: 996),
},
},
            new TimeSpanintervalArray1M
{
    Id = 30,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 9, minutes: 47, seconds: 50, milliseconds: 267),
new TimeSpan(days: 0, hours: 14, minutes: 32, seconds: 49, milliseconds: 133),
new TimeSpan(days: 0, hours: 1, minutes: 2, seconds: 40, milliseconds: 261),
new TimeSpan(days: 0, hours: 14, minutes: 32, seconds: 3, milliseconds: 411),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 32,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 20, minutes: 49, seconds: 2, milliseconds: 105),
new TimeSpan(days: 0, hours: 21, minutes: 32, seconds: 44, milliseconds: 372),
new TimeSpan(days: 0, hours: 2, minutes: 42, seconds: 8, milliseconds: 304),
new TimeSpan(days: 0, hours: 16, minutes: 4, seconds: 4, milliseconds: 559),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 14,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 9, minutes: 25, seconds: 45, milliseconds: 501),
new TimeSpan(days: 0, hours: 22, minutes: 32, seconds: 53, milliseconds: 107),
new TimeSpan(days: 0, hours: 6, minutes: 44, seconds: 23, milliseconds: 777),
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 3, minutes: 28, seconds: 6, milliseconds: 501),
new TimeSpan(days: 0, hours: 17, minutes: 40, seconds: 7, milliseconds: 44),
new TimeSpan(days: 0, hours: 15, minutes: 5, seconds: 50, milliseconds: 723),
new TimeSpan(days: 0, hours: 9, minutes: 31, seconds: 25, milliseconds: 378),
},
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 1, minutes: 46, seconds: 6, milliseconds: 595),
new TimeSpan(days: 0, hours: 5, minutes: 48, seconds: 37, milliseconds: 285),
new TimeSpan(days: 0, hours: 22, minutes: 37, seconds: 48, milliseconds: 834),
},
},
            new TimeSpanintervalArray1M
{
    Id = 37,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 2, minutes: 16, seconds: 58, milliseconds: 601),
new TimeSpan(days: 0, hours: 12, minutes: 48, seconds: 19, milliseconds: 602),
new TimeSpan(days: 0, hours: 0, minutes: 43, seconds: 40, milliseconds: 211),
new TimeSpan(days: 0, hours: 9, minutes: 43, seconds: 25, milliseconds: 497),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 41,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 3, minutes: 25, seconds: 35, milliseconds: 508),
new TimeSpan(days: 0, hours: 2, minutes: 42, seconds: 44, milliseconds: 183),
new TimeSpan(days: 0, hours: 21, minutes: 4, seconds: 33, milliseconds: 709),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 23,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 13, seconds: 15, milliseconds: 997),
new TimeSpan(days: 0, hours: 15, minutes: 3, seconds: 30, milliseconds: 775),
new TimeSpan(days: 0, hours: 4, minutes: 26, seconds: 19, milliseconds: 749),
new TimeSpan(days: 0, hours: 8, minutes: 43, seconds: 25, milliseconds: 481),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 50,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 6, minutes: 49, seconds: 34, milliseconds: 531),
new TimeSpan(days: 0, hours: 14, minutes: 53, seconds: 9, milliseconds: 76),
new TimeSpan(days: 0, hours: 22, minutes: 34, seconds: 22, milliseconds: 911),
new TimeSpan(days: 0, hours: 6, minutes: 40, seconds: 52, milliseconds: 40),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 59,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 6, minutes: 24, seconds: 10, milliseconds: 199),
new TimeSpan(days: 0, hours: 20, minutes: 2, seconds: 25, milliseconds: 399),
new TimeSpan(days: 0, hours: 11, minutes: 23, seconds: 3, milliseconds: 996),
new TimeSpan(days: 0, hours: 6, minutes: 18, seconds: 8, milliseconds: 902),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 32,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 9, minutes: 6, seconds: 25, milliseconds: 419),
new TimeSpan(days: 0, hours: 7, minutes: 48, seconds: 43, milliseconds: 996),
new TimeSpan(days: 0, hours: 9, minutes: 40, seconds: 34, milliseconds: 754),
new TimeSpan(days: 0, hours: 18, minutes: 43, seconds: 49, milliseconds: 832),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 18, minutes: 30, seconds: 25, milliseconds: 955),
new TimeSpan(days: 0, hours: 13, minutes: 34, seconds: 28, milliseconds: 67),
new TimeSpan(days: 0, hours: 17, minutes: 48, seconds: 18, milliseconds: 665),
new TimeSpan(days: 0, hours: 21, minutes: 10, seconds: 6, milliseconds: 607),
},
},
            new TimeSpanintervalArray1M
{
    Id = 67,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 12, minutes: 21, seconds: 37, milliseconds: 294),
new TimeSpan(days: 0, hours: 2, minutes: 17, seconds: 2, milliseconds: 313),
new TimeSpan(days: 0, hours: 5, minutes: 33, seconds: 58, milliseconds: 965),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 75,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 9, minutes: 25, seconds: 7, milliseconds: 639),
new TimeSpan(days: 0, hours: 17, minutes: 42, seconds: 46, milliseconds: 50),
new TimeSpan(days: 0, hours: 1, minutes: 7, seconds: 33, milliseconds: 10),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 37,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 3, minutes: 6, seconds: 50, milliseconds: 898),
new TimeSpan(days: 0, hours: 5, minutes: 9, seconds: 28, milliseconds: 285),
new TimeSpan(days: 0, hours: 0, minutes: 38, seconds: 22, milliseconds: 189),
new TimeSpan(days: 0, hours: 9, minutes: 47, seconds: 56, milliseconds: 41),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 77,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 0, minutes: 32, seconds: 19, milliseconds: 423),
new TimeSpan(days: 0, hours: 9, minutes: 29, seconds: 56, milliseconds: 502),
new TimeSpan(days: 0, hours: 2, minutes: 46, seconds: 4, milliseconds: 645),
new TimeSpan(days: 0, hours: 16, minutes: 1, seconds: 20, milliseconds: 348),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 11, minutes: 34, seconds: 23, milliseconds: 255),
new TimeSpan(days: 0, hours: 2, minutes: 35, seconds: 47, milliseconds: 139),
new TimeSpan(days: 0, hours: 0, minutes: 51, seconds: 16, milliseconds: 79),
new TimeSpan(days: 0, hours: 21, minutes: 42, seconds: 22, milliseconds: 804),
},
},
            new TimeSpanintervalArray1M
{
    Id = 81,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 11, minutes: 55, seconds: 44, milliseconds: 336),
new TimeSpan(days: 0, hours: 20, minutes: 32, seconds: 28, milliseconds: 252),
new TimeSpan(days: 0, hours: 10, minutes: 51, seconds: 22, milliseconds: 545),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 42,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 3, minutes: 31, seconds: 37, milliseconds: 282),
new TimeSpan(days: 0, hours: 19, minutes: 28, seconds: 43, milliseconds: 637),
new TimeSpan(days: 0, hours: 10, minutes: 4, seconds: 30, milliseconds: 625),
new TimeSpan(days: 0, hours: 1, minutes: 31, seconds: 14, milliseconds: 63),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 82,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 2, minutes: 44, seconds: 26, milliseconds: 175),
new TimeSpan(days: 0, hours: 2, minutes: 7, seconds: 11, milliseconds: 585),
new TimeSpan(days: 0, hours: 14, minutes: 28, seconds: 56, milliseconds: 819),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 18, minutes: 24, seconds: 25, milliseconds: 579),
new TimeSpan(days: 0, hours: 0, minutes: 49, seconds: 31, milliseconds: 737),
new TimeSpan(days: 0, hours: 11, minutes: 56, seconds: 5, milliseconds: 815),
new TimeSpan(days: 0, hours: 18, minutes: 40, seconds: 33, milliseconds: 436),
},
},
            new TimeSpanintervalArray1M
{
    Id = 87,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 1, minutes: 25, seconds: 6, milliseconds: 957),
new TimeSpan(days: 0, hours: 9, minutes: 16, seconds: 3, milliseconds: 197),
new TimeSpan(days: 0, hours: 15, minutes: 40, seconds: 57, milliseconds: 54),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 46,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 21, minutes: 55, seconds: 14, milliseconds: 115),
new TimeSpan(days: 0, hours: 7, minutes: 32, seconds: 20, milliseconds: 22),
new TimeSpan(days: 0, hours: 8, minutes: 22, seconds: 57, milliseconds: 985),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 1, minutes: 4, seconds: 0, milliseconds: 182),
new TimeSpan(days: 0, hours: 18, minutes: 25, seconds: 8, milliseconds: 179),
new TimeSpan(days: 0, hours: 9, minutes: 47, seconds: 51, milliseconds: 541),
new TimeSpan(days: 0, hours: 4, minutes: 21, seconds: 49, milliseconds: 571),
},
},
            new TimeSpanintervalArray1M
{
    Id = 94,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 4, minutes: 7, seconds: 9, milliseconds: 254),
new TimeSpan(days: 0, hours: 5, minutes: 28, seconds: 40, milliseconds: 178),
new TimeSpan(days: 0, hours: 11, minutes: 13, seconds: 11, milliseconds: 666),
new TimeSpan(days: 0, hours: 7, minutes: 7, seconds: 51, milliseconds: 807),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 11, minutes: 49, seconds: 58, milliseconds: 469),
new TimeSpan(days: 0, hours: 19, minutes: 26, seconds: 42, milliseconds: 99),
new TimeSpan(days: 0, hours: 0, minutes: 16, seconds: 15, milliseconds: 687),
},
},
            new TimeSpanintervalArray1M
{
    Id = 97,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 22, minutes: 32, seconds: 7, milliseconds: 531),
new TimeSpan(days: 0, hours: 16, minutes: 52, seconds: 58, milliseconds: 226),
new TimeSpan(days: 0, hours: 5, minutes: 41, seconds: 10, milliseconds: 221),
new TimeSpan(days: 0, hours: 19, minutes: 12, seconds: 50, milliseconds: 280),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 53,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 15, minutes: 31, seconds: 36, milliseconds: 704),
new TimeSpan(days: 0, hours: 1, minutes: 39, seconds: 41, milliseconds: 427),
new TimeSpan(days: 0, hours: 12, minutes: 33, seconds: 17, milliseconds: 166),
new TimeSpan(days: 0, hours: 6, minutes: 32, seconds: 30, milliseconds: 89),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 10, minutes: 57, seconds: 13, milliseconds: 126),
new TimeSpan(days: 0, hours: 11, minutes: 50, seconds: 21, milliseconds: 64),
new TimeSpan(days: 0, hours: 9, minutes: 45, seconds: 21, milliseconds: 933),
},
},
            new TimeSpanintervalArray1M
{
    Id = 99,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 8, minutes: 52, seconds: 6, milliseconds: 723),
new TimeSpan(days: 0, hours: 13, minutes: 48, seconds: 9, milliseconds: 132),
new TimeSpan(days: 0, hours: 6, minutes: 54, seconds: 2, milliseconds: 904),
new TimeSpan(days: 0, hours: 8, minutes: 49, seconds: 34, milliseconds: 392),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 107,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 5, minutes: 11, seconds: 54, milliseconds: 157),
new TimeSpan(days: 0, hours: 20, minutes: 21, seconds: 49, milliseconds: 876),
new TimeSpan(days: 0, hours: 13, minutes: 7, seconds: 25, milliseconds: 892),
new TimeSpan(days: 0, hours: 2, minutes: 24, seconds: 58, milliseconds: 801),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 62,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 13, minutes: 55, seconds: 53, milliseconds: 549),
new TimeSpan(days: 0, hours: 21, minutes: 18, seconds: 14, milliseconds: 353),
new TimeSpan(days: 0, hours: 15, minutes: 26, seconds: 29, milliseconds: 37),
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 9, minutes: 4, seconds: 34, milliseconds: 547),
new TimeSpan(days: 0, hours: 21, minutes: 40, seconds: 22, milliseconds: 481),
new TimeSpan(days: 0, hours: 14, minutes: 44, seconds: 57, milliseconds: 534),
new TimeSpan(days: 0, hours: 15, minutes: 7, seconds: 0, milliseconds: 354),
},
},
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 110,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 48, seconds: 2, milliseconds: 404),
new TimeSpan(days: 0, hours: 14, minutes: 48, seconds: 53, milliseconds: 687),
new TimeSpan(days: 0, hours: 21, minutes: 1, seconds: 21, milliseconds: 280),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 2, minutes: 43, seconds: 12, milliseconds: 359),
new TimeSpan(days: 0, hours: 1, minutes: 52, seconds: 22, milliseconds: 877),
new TimeSpan(days: 0, hours: 19, minutes: 11, seconds: 32, milliseconds: 410),
new TimeSpan(days: 0, hours: 2, minutes: 56, seconds: 54, milliseconds: 901),
},
},
            new TimeSpanintervalArray1M
{
    Id = 118,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 6, minutes: 0, seconds: 22, milliseconds: 492),
new TimeSpan(days: 0, hours: 1, minutes: 2, seconds: 57, milliseconds: 450),
new TimeSpan(days: 0, hours: 22, minutes: 46, seconds: 58, milliseconds: 732),
new TimeSpan(days: 0, hours: 6, minutes: 48, seconds: 3, milliseconds: 520),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 63,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 22, minutes: 38, seconds: 4, milliseconds: 714),
new TimeSpan(days: 0, hours: 22, minutes: 27, seconds: 41, milliseconds: 188),
new TimeSpan(days: 0, hours: 9, minutes: 7, seconds: 10, milliseconds: 501),
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 36, seconds: 53, milliseconds: 266),
new TimeSpan(days: 0, hours: 16, minutes: 22, seconds: 40, milliseconds: 718),
new TimeSpan(days: 0, hours: 10, minutes: 50, seconds: 7, milliseconds: 747),
new TimeSpan(days: 0, hours: 14, minutes: 46, seconds: 39, milliseconds: 66),
},
},
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 126,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 6, minutes: 2, seconds: 45, milliseconds: 963),
new TimeSpan(days: 0, hours: 17, minutes: 9, seconds: 42, milliseconds: 634),
new TimeSpan(days: 0, hours: 14, minutes: 31, seconds: 33, milliseconds: 727),
new TimeSpan(days: 0, hours: 11, minutes: 47, seconds: 35, milliseconds: 843),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 131,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 53, seconds: 15, milliseconds: 282),
new TimeSpan(days: 0, hours: 9, minutes: 51, seconds: 51, milliseconds: 282),
new TimeSpan(days: 0, hours: 11, minutes: 13, seconds: 47, milliseconds: 48),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 69,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 15, minutes: 42, seconds: 38, milliseconds: 882),
new TimeSpan(days: 0, hours: 2, minutes: 14, seconds: 31, milliseconds: 414),
new TimeSpan(days: 0, hours: 11, minutes: 16, seconds: 57, milliseconds: 66),
new TimeSpan(days: 0, hours: 0, minutes: 41, seconds: 29, milliseconds: 290),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 135,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 11, minutes: 48, seconds: 47, milliseconds: 52),
new TimeSpan(days: 0, hours: 22, minutes: 21, seconds: 37, milliseconds: 561),
new TimeSpan(days: 0, hours: 6, minutes: 47, seconds: 21, milliseconds: 485),
new TimeSpan(days: 0, hours: 8, minutes: 56, seconds: 30, milliseconds: 9),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 136,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 27, seconds: 22, milliseconds: 10),
new TimeSpan(days: 0, hours: 18, minutes: 39, seconds: 34, milliseconds: 244),
new TimeSpan(days: 0, hours: 21, minutes: 35, seconds: 42, milliseconds: 622),
new TimeSpan(days: 0, hours: 19, minutes: 11, seconds: 28, milliseconds: 179),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 72,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 17, minutes: 15, seconds: 10, milliseconds: 463),
new TimeSpan(days: 0, hours: 11, minutes: 43, seconds: 28, milliseconds: 708),
new TimeSpan(days: 0, hours: 22, minutes: 34, seconds: 29, milliseconds: 344),
new TimeSpan(days: 0, hours: 4, minutes: 30, seconds: 24, milliseconds: 498),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 141,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 18, minutes: 12, seconds: 27, milliseconds: 49),
new TimeSpan(days: 0, hours: 7, minutes: 42, seconds: 50, milliseconds: 507),
new TimeSpan(days: 0, hours: 10, minutes: 18, seconds: 52, milliseconds: 68),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 142,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 3, minutes: 1, seconds: 5, milliseconds: 89),
new TimeSpan(days: 0, hours: 7, minutes: 8, seconds: 32, milliseconds: 199),
new TimeSpan(days: 0, hours: 18, minutes: 25, seconds: 17, milliseconds: 319),
new TimeSpan(days: 0, hours: 7, minutes: 16, seconds: 27, milliseconds: 479),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 78,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 8, minutes: 46, seconds: 9, milliseconds: 298),
new TimeSpan(days: 0, hours: 19, minutes: 15, seconds: 13, milliseconds: 78),
new TimeSpan(days: 0, hours: 14, minutes: 29, seconds: 52, milliseconds: 852),
new TimeSpan(days: 0, hours: 21, minutes: 21, seconds: 9, milliseconds: 889),
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
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 17, minutes: 55, seconds: 9, milliseconds: 185),
new TimeSpan(days: 0, hours: 8, minutes: 55, seconds: 29, milliseconds: 503),
new TimeSpan(days: 0, hours: 11, minutes: 12, seconds: 46, milliseconds: 353),
new TimeSpan(days: 0, hours: 20, minutes: 32, seconds: 42, milliseconds: 953),
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
new TimeSpan(days: 0, hours: 18, minutes: 24, seconds: 35, milliseconds: 783),
new TimeSpan(days: 0, hours: 4, minutes: 16, seconds: 51, milliseconds: 547),
new TimeSpan(days: 0, hours: 20, minutes: 11, seconds: 58, milliseconds: 996),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 1, minutes: 46, seconds: 6, milliseconds: 595),
new TimeSpan(days: 0, hours: 5, minutes: 48, seconds: 37, milliseconds: 285),
new TimeSpan(days: 0, hours: 22, minutes: 37, seconds: 48, milliseconds: 834),
}));
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
                nullable = await ((ITimeSpanArrayintervalArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((ITimeSpanArrayintervalArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 18, minutes: 30, seconds: 25, milliseconds: 955),
new TimeSpan(days: 0, hours: 13, minutes: 34, seconds: 28, milliseconds: 67),
new TimeSpan(days: 0, hours: 17, minutes: 48, seconds: 18, milliseconds: 665),
new TimeSpan(days: 0, hours: 21, minutes: 10, seconds: 6, milliseconds: 607),
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
                parametr1.Value = 1;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 30;
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
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[28],_testData[29], false);
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 87;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 21;
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
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[11],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[25],_testData[29], false);
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
                parametr1.Value = 94;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 97;
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
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[10],_testData[29], false);
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 97;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 136;
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
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[9],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[1],_testData[29], false);
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
                parametr1.Value = 136;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 81;
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
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatTimeSpanintervalArray1M.AssertModel(models[0],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatTimeSpanintervalArray1M.AssertModel(models[0],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[1],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[2],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[3],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[4],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[5],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[6],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[7],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[8],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[9],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[10],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[11],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[12],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[13],_testData[29], false);
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
                parametr1.Value = 81;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 107;
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
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[7],_testData[29], false);
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
                parametr1.Value = 32;
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
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatTimeSpanintervalArray1M.AssertModel(models[0],_testData[8], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[1],_testData[9], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[2],_testData[10], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[3],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[4],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[5],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[6],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[7],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[8],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[9],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[10],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[11],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[12],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[13],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[14],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[15],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[16],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[17],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[18],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[19],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[20],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatTimeSpanintervalArray1M.AssertModel(models[0],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[1],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[2],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[3],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[4],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[5],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[6],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[7],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[8],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[9],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[10],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[11],_testData[29], false);
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
                parametr2.Value = 99;
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
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[8],_testData[29], false);
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
                parametr1.Value = 59;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 32;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((ITimeSpanArrayintervalArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        TimeSpanintervalArray1M.AssertModel(models[0],_testData[12], false);
                        TimeSpanintervalArray1M.AssertModel(models[1],_testData[13], false);
                        TimeSpanintervalArray1M.AssertModel(models[2],_testData[14], false);
                        TimeSpanintervalArray1M.AssertModel(models[3],_testData[15], false);
                        TimeSpanintervalArray1M.AssertModel(models[4],_testData[16], false);
                        TimeSpanintervalArray1M.AssertModel(models[5],_testData[17], false);
                        TimeSpanintervalArray1M.AssertModel(models[6],_testData[18], false);
                        TimeSpanintervalArray1M.AssertModel(models[7],_testData[19], false);
                        TimeSpanintervalArray1M.AssertModel(models[8],_testData[20], false);
                        TimeSpanintervalArray1M.AssertModel(models[9],_testData[21], false);
                        TimeSpanintervalArray1M.AssertModel(models[10],_testData[22], false);
                        TimeSpanintervalArray1M.AssertModel(models[11],_testData[23], false);
                        TimeSpanintervalArray1M.AssertModel(models[12],_testData[24], false);
                        TimeSpanintervalArray1M.AssertModel(models[13],_testData[25], false);
                        TimeSpanintervalArray1M.AssertModel(models[14],_testData[26], false);
                        TimeSpanintervalArray1M.AssertModel(models[15],_testData[27], false);
                        TimeSpanintervalArray1M.AssertModel(models[16],_testData[28], false);
                        TimeSpanintervalArray1M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        TimeSpanintervalArray1M.AssertModel(models[0],_testData[8], false);
                        TimeSpanintervalArray1M.AssertModel(models[1],_testData[9], false);
                        TimeSpanintervalArray1M.AssertModel(models[2],_testData[10], false);
                        TimeSpanintervalArray1M.AssertModel(models[3],_testData[11], false);
                        TimeSpanintervalArray1M.AssertModel(models[4],_testData[12], false);
                        TimeSpanintervalArray1M.AssertModel(models[5],_testData[13], false);
                        TimeSpanintervalArray1M.AssertModel(models[6],_testData[14], false);
                        TimeSpanintervalArray1M.AssertModel(models[7],_testData[15], false);
                        TimeSpanintervalArray1M.AssertModel(models[8],_testData[16], false);
                        TimeSpanintervalArray1M.AssertModel(models[9],_testData[17], false);
                        TimeSpanintervalArray1M.AssertModel(models[10],_testData[18], false);
                        TimeSpanintervalArray1M.AssertModel(models[11],_testData[19], false);
                        TimeSpanintervalArray1M.AssertModel(models[12],_testData[20], false);
                        TimeSpanintervalArray1M.AssertModel(models[13],_testData[21], false);
                        TimeSpanintervalArray1M.AssertModel(models[14],_testData[22], false);
                        TimeSpanintervalArray1M.AssertModel(models[15],_testData[23], false);
                        TimeSpanintervalArray1M.AssertModel(models[16],_testData[24], false);
                        TimeSpanintervalArray1M.AssertModel(models[17],_testData[25], false);
                        TimeSpanintervalArray1M.AssertModel(models[18],_testData[26], false);
                        TimeSpanintervalArray1M.AssertModel(models[19],_testData[27], false);
                        TimeSpanintervalArray1M.AssertModel(models[20],_testData[28], false);
                        TimeSpanintervalArray1M.AssertModel(models[21],_testData[29], false);
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
                parametr1.Value = 75;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 32;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((ITimeSpanArrayintervalArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        TimeSpanintervalArray1M.AssertModel(models[0],_testData[8], false);
                        TimeSpanintervalArray1M.AssertModel(models[1],_testData[9], false);
                        TimeSpanintervalArray1M.AssertModel(models[2],_testData[10], false);
                        TimeSpanintervalArray1M.AssertModel(models[3],_testData[11], false);
                        TimeSpanintervalArray1M.AssertModel(models[4],_testData[12], false);
                        TimeSpanintervalArray1M.AssertModel(models[5],_testData[13], false);
                        TimeSpanintervalArray1M.AssertModel(models[6],_testData[14], false);
                        TimeSpanintervalArray1M.AssertModel(models[7],_testData[15], false);
                        TimeSpanintervalArray1M.AssertModel(models[8],_testData[16], false);
                        TimeSpanintervalArray1M.AssertModel(models[9],_testData[17], false);
                        TimeSpanintervalArray1M.AssertModel(models[10],_testData[18], false);
                        TimeSpanintervalArray1M.AssertModel(models[11],_testData[19], false);
                        TimeSpanintervalArray1M.AssertModel(models[12],_testData[20], false);
                        TimeSpanintervalArray1M.AssertModel(models[13],_testData[21], false);
                        TimeSpanintervalArray1M.AssertModel(models[14],_testData[22], false);
                        TimeSpanintervalArray1M.AssertModel(models[15],_testData[23], false);
                        TimeSpanintervalArray1M.AssertModel(models[16],_testData[24], false);
                        TimeSpanintervalArray1M.AssertModel(models[17],_testData[25], false);
                        TimeSpanintervalArray1M.AssertModel(models[18],_testData[26], false);
                        TimeSpanintervalArray1M.AssertModel(models[19],_testData[27], false);
                        TimeSpanintervalArray1M.AssertModel(models[20],_testData[28], false);
                        TimeSpanintervalArray1M.AssertModel(models[21],_testData[29], false);
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
                await ((ITimeSpanArrayintervalArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 1, query1, 135, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[2],_testData[29], false);
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
                await ((ITimeSpanArrayintervalArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 21, query1, 32, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[21],_testData[29], false);
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
                 ((ITimeSpanArrayintervalArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 75, query1, 14, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[26],_testData[29], false);
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
                 ((ITimeSpanArrayintervalArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 82, query1, 32, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[21],_testData[29], false);
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
                foreach(var batchResult in await ((ITimeSpanArrayintervalArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 118, query1, 136, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatTimeSpanintervalArray1M.AssertModel(models[0],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[1],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[2],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[3],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[4],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatTimeSpanintervalArray1M.AssertModel(models[0],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[1],_testData[29], false);
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
                await ((ITimeSpanArrayintervalArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 75, query1, 75, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[15],_testData[29], false);
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
                foreach(var batchResult in  ((ITimeSpanArrayintervalArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 136, query1, 59, query2))
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
                 ((ITimeSpanArrayintervalArray)this).DbConnectionDynQuerySelectModelBatch(connection, 107, query1, 28, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[23],_testData[29], false);
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
                foreach(var batchResult in await ((ITimeSpanArrayintervalArray)this).DbConnectionSTSelectModelBatchAsync(connection, 118, 77))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        TimeSpanintervalArray1M.AssertModel(models[0],_testData[24], false);
                        TimeSpanintervalArray1M.AssertModel(models[1],_testData[25], false);
                        TimeSpanintervalArray1M.AssertModel(models[2],_testData[26], false);
                        TimeSpanintervalArray1M.AssertModel(models[3],_testData[27], false);
                        TimeSpanintervalArray1M.AssertModel(models[4],_testData[28], false);
                        TimeSpanintervalArray1M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        TimeSpanintervalArray1M.AssertModel(models[0],_testData[15], false);
                        TimeSpanintervalArray1M.AssertModel(models[1],_testData[16], false);
                        TimeSpanintervalArray1M.AssertModel(models[2],_testData[17], false);
                        TimeSpanintervalArray1M.AssertModel(models[3],_testData[18], false);
                        TimeSpanintervalArray1M.AssertModel(models[4],_testData[19], false);
                        TimeSpanintervalArray1M.AssertModel(models[5],_testData[20], false);
                        TimeSpanintervalArray1M.AssertModel(models[6],_testData[21], false);
                        TimeSpanintervalArray1M.AssertModel(models[7],_testData[22], false);
                        TimeSpanintervalArray1M.AssertModel(models[8],_testData[23], false);
                        TimeSpanintervalArray1M.AssertModel(models[9],_testData[24], false);
                        TimeSpanintervalArray1M.AssertModel(models[10],_testData[25], false);
                        TimeSpanintervalArray1M.AssertModel(models[11],_testData[26], false);
                        TimeSpanintervalArray1M.AssertModel(models[12],_testData[27], false);
                        TimeSpanintervalArray1M.AssertModel(models[13],_testData[28], false);
                        TimeSpanintervalArray1M.AssertModel(models[14],_testData[29], false);
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
                foreach(var batchResult in  ((ITimeSpanArrayintervalArray)this).DbConnectionSTSelectModelBatch(connection, 75, 136))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        TimeSpanintervalArray1M.AssertModel(models[0],_testData[28], false);
                        TimeSpanintervalArray1M.AssertModel(models[1],_testData[29], false);
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
                ((ITimeSpanArrayintervalArray)this).SetDbConnectionSelectModelParametrs(cmd, 107);
                var models = await ((ITimeSpanArrayintervalArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(8));
TimeSpanintervalArray1M.AssertModel(models[0],_testData[22], false);TimeSpanintervalArray1M.AssertModel(models[1],_testData[23], false);TimeSpanintervalArray1M.AssertModel(models[2],_testData[24], false);TimeSpanintervalArray1M.AssertModel(models[3],_testData[25], false);TimeSpanintervalArray1M.AssertModel(models[4],_testData[26], false);TimeSpanintervalArray1M.AssertModel(models[5],_testData[27], false);TimeSpanintervalArray1M.AssertModel(models[6],_testData[28], false);TimeSpanintervalArray1M.AssertModel(models[7],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ITimeSpanArrayintervalArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((ITimeSpanArrayintervalArray)this).SetDbConnectionSelectModelParametrs(cmd, 1);
                var models =  ((ITimeSpanArrayintervalArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(29));
TimeSpanintervalArray1M.AssertModel(models[0],_testData[1], false);TimeSpanintervalArray1M.AssertModel(models[1],_testData[2], false);TimeSpanintervalArray1M.AssertModel(models[2],_testData[3], false);TimeSpanintervalArray1M.AssertModel(models[3],_testData[4], false);TimeSpanintervalArray1M.AssertModel(models[4],_testData[5], false);TimeSpanintervalArray1M.AssertModel(models[5],_testData[6], false);TimeSpanintervalArray1M.AssertModel(models[6],_testData[7], false);TimeSpanintervalArray1M.AssertModel(models[7],_testData[8], false);TimeSpanintervalArray1M.AssertModel(models[8],_testData[9], false);TimeSpanintervalArray1M.AssertModel(models[9],_testData[10], false);TimeSpanintervalArray1M.AssertModel(models[10],_testData[11], false);TimeSpanintervalArray1M.AssertModel(models[11],_testData[12], false);TimeSpanintervalArray1M.AssertModel(models[12],_testData[13], false);TimeSpanintervalArray1M.AssertModel(models[13],_testData[14], false);TimeSpanintervalArray1M.AssertModel(models[14],_testData[15], false);TimeSpanintervalArray1M.AssertModel(models[15],_testData[16], false);TimeSpanintervalArray1M.AssertModel(models[16],_testData[17], false);TimeSpanintervalArray1M.AssertModel(models[17],_testData[18], false);TimeSpanintervalArray1M.AssertModel(models[18],_testData[19], false);TimeSpanintervalArray1M.AssertModel(models[19],_testData[20], false);TimeSpanintervalArray1M.AssertModel(models[20],_testData[21], false);TimeSpanintervalArray1M.AssertModel(models[21],_testData[22], false);TimeSpanintervalArray1M.AssertModel(models[22],_testData[23], false);TimeSpanintervalArray1M.AssertModel(models[23],_testData[24], false);TimeSpanintervalArray1M.AssertModel(models[24],_testData[25], false);TimeSpanintervalArray1M.AssertModel(models[25],_testData[26], false);TimeSpanintervalArray1M.AssertModel(models[26],_testData[27], false);TimeSpanintervalArray1M.AssertModel(models[27],_testData[28], false);TimeSpanintervalArray1M.AssertModel(models[28],_testData[29], false);
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

