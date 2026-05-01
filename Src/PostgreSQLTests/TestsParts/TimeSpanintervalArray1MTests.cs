

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
new TimeSpan(days: 0, hours: 2, minutes: 49, seconds: 5, milliseconds: 66),
new TimeSpan(days: 0, hours: 16, minutes: 3, seconds: 42, milliseconds: 845),
new TimeSpan(days: 0, hours: 0, minutes: 37, seconds: 21, milliseconds: 769),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 22, minutes: 36, seconds: 19, milliseconds: 985),
new TimeSpan(days: 0, hours: 17, minutes: 56, seconds: 37, milliseconds: 668),
new TimeSpan(days: 0, hours: 20, minutes: 18, seconds: 37, milliseconds: 748),
new TimeSpan(days: 0, hours: 3, minutes: 53, seconds: 52, milliseconds: 312),
},
},
            new TimeSpanintervalArray1M
{
    Id = 9,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 47, seconds: 23, milliseconds: 696),
new TimeSpan(days: 0, hours: 16, minutes: 30, seconds: 53, milliseconds: 102),
new TimeSpan(days: 0, hours: 15, minutes: 37, seconds: 3, milliseconds: 320),
new TimeSpan(days: 0, hours: 22, minutes: 19, seconds: 48, milliseconds: 684),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 4,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 14, minutes: 58, seconds: 20, milliseconds: 851),
new TimeSpan(days: 0, hours: 2, minutes: 2, seconds: 9, milliseconds: 964),
new TimeSpan(days: 0, hours: 2, minutes: 4, seconds: 35, milliseconds: 761),
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 9, minutes: 45, seconds: 10, milliseconds: 630),
new TimeSpan(days: 0, hours: 22, minutes: 39, seconds: 7, milliseconds: 173),
new TimeSpan(days: 0, hours: 13, minutes: 1, seconds: 47, milliseconds: 215),
new TimeSpan(days: 0, hours: 0, minutes: 53, seconds: 7, milliseconds: 713),
},
},
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 16,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 44, seconds: 48, milliseconds: 174),
new TimeSpan(days: 0, hours: 9, minutes: 0, seconds: 48, milliseconds: 957),
new TimeSpan(days: 0, hours: 14, minutes: 23, seconds: 34, milliseconds: 892),
new TimeSpan(days: 0, hours: 9, minutes: 30, seconds: 47, milliseconds: 160),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 21,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 12, minutes: 24, seconds: 31, milliseconds: 857),
new TimeSpan(days: 0, hours: 7, minutes: 43, seconds: 5, milliseconds: 402),
new TimeSpan(days: 0, hours: 12, minutes: 47, seconds: 13, milliseconds: 90),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 12,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 19, minutes: 39, seconds: 8, milliseconds: 277),
new TimeSpan(days: 0, hours: 13, minutes: 8, seconds: 15, milliseconds: 473),
new TimeSpan(days: 0, hours: 2, minutes: 42, seconds: 33, milliseconds: 655),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 5, minutes: 28, seconds: 12, milliseconds: 706),
new TimeSpan(days: 0, hours: 22, minutes: 56, seconds: 17, milliseconds: 852),
new TimeSpan(days: 0, hours: 10, minutes: 11, seconds: 56, milliseconds: 351),
new TimeSpan(days: 0, hours: 5, minutes: 28, seconds: 19, milliseconds: 792),
},
},
            new TimeSpanintervalArray1M
{
    Id = 29,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 1, minutes: 10, seconds: 20, milliseconds: 916),
new TimeSpan(days: 0, hours: 21, minutes: 31, seconds: 24, milliseconds: 649),
new TimeSpan(days: 0, hours: 22, minutes: 52, seconds: 54, milliseconds: 30),
new TimeSpan(days: 0, hours: 14, minutes: 26, seconds: 21, milliseconds: 982),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 34,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 18, minutes: 36, seconds: 28, milliseconds: 772),
new TimeSpan(days: 0, hours: 2, minutes: 31, seconds: 10, milliseconds: 438),
new TimeSpan(days: 0, hours: 6, minutes: 37, seconds: 48, milliseconds: 167),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 18,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 23, seconds: 41, milliseconds: 530),
new TimeSpan(days: 0, hours: 13, minutes: 51, seconds: 9, milliseconds: 567),
new TimeSpan(days: 0, hours: 15, minutes: 30, seconds: 43, milliseconds: 937),
new TimeSpan(days: 0, hours: 18, minutes: 1, seconds: 58, milliseconds: 751),
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 57, seconds: 20, milliseconds: 631),
new TimeSpan(days: 0, hours: 10, minutes: 39, seconds: 26, milliseconds: 847),
new TimeSpan(days: 0, hours: 21, minutes: 29, seconds: 27, milliseconds: 426),
new TimeSpan(days: 0, hours: 16, minutes: 20, seconds: 43, milliseconds: 63),
},
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 17, minutes: 20, seconds: 55, milliseconds: 516),
new TimeSpan(days: 0, hours: 22, minutes: 46, seconds: 19, milliseconds: 509),
new TimeSpan(days: 0, hours: 6, minutes: 47, seconds: 46, milliseconds: 801),
new TimeSpan(days: 0, hours: 1, minutes: 36, seconds: 45, milliseconds: 409),
},
},
            new TimeSpanintervalArray1M
{
    Id = 36,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 22, minutes: 55, seconds: 2, milliseconds: 881),
new TimeSpan(days: 0, hours: 0, minutes: 47, seconds: 1, milliseconds: 369),
new TimeSpan(days: 0, hours: 7, minutes: 25, seconds: 41, milliseconds: 822),
new TimeSpan(days: 0, hours: 16, minutes: 33, seconds: 34, milliseconds: 504),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 20, minutes: 15, seconds: 5, milliseconds: 169),
new TimeSpan(days: 0, hours: 15, minutes: 58, seconds: 12, milliseconds: 633),
new TimeSpan(days: 0, hours: 8, minutes: 12, seconds: 23, milliseconds: 835),
},
},
            new TimeSpanintervalArray1M
{
    Id = 45,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 39, seconds: 26, milliseconds: 223),
new TimeSpan(days: 0, hours: 20, minutes: 12, seconds: 58, milliseconds: 135),
new TimeSpan(days: 0, hours: 17, minutes: 43, seconds: 33, milliseconds: 961),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 21,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 0, minutes: 5, seconds: 14, milliseconds: 921),
new TimeSpan(days: 0, hours: 7, minutes: 37, seconds: 8, milliseconds: 143),
new TimeSpan(days: 0, hours: 22, minutes: 58, seconds: 31, milliseconds: 934),
new TimeSpan(days: 0, hours: 21, minutes: 18, seconds: 35, milliseconds: 439),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 41, seconds: 11, milliseconds: 878),
new TimeSpan(days: 0, hours: 2, minutes: 11, seconds: 12, milliseconds: 782),
new TimeSpan(days: 0, hours: 10, minutes: 0, seconds: 47, milliseconds: 318),
new TimeSpan(days: 0, hours: 2, minutes: 21, seconds: 33, milliseconds: 547),
},
},
            new TimeSpanintervalArray1M
{
    Id = 48,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 22, minutes: 17, seconds: 51, milliseconds: 457),
new TimeSpan(days: 0, hours: 13, minutes: 34, seconds: 18, milliseconds: 980),
new TimeSpan(days: 0, hours: 15, minutes: 49, seconds: 53, milliseconds: 992),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 1, minutes: 50, seconds: 8, milliseconds: 341),
new TimeSpan(days: 0, hours: 4, minutes: 42, seconds: 47, milliseconds: 375),
new TimeSpan(days: 0, hours: 19, minutes: 32, seconds: 27, milliseconds: 304),
new TimeSpan(days: 0, hours: 14, minutes: 19, seconds: 21, milliseconds: 18),
},
},
            new TimeSpanintervalArray1M
{
    Id = 56,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 8, minutes: 9, seconds: 32, milliseconds: 363),
new TimeSpan(days: 0, hours: 1, minutes: 34, seconds: 29, milliseconds: 640),
new TimeSpan(days: 0, hours: 9, minutes: 2, seconds: 54, milliseconds: 807),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 30,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 24, seconds: 22, milliseconds: 616),
new TimeSpan(days: 0, hours: 5, minutes: 30, seconds: 50, milliseconds: 808),
new TimeSpan(days: 0, hours: 15, minutes: 19, seconds: 42, milliseconds: 605),
new TimeSpan(days: 0, hours: 22, minutes: 21, seconds: 1, milliseconds: 328),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 2, minutes: 18, seconds: 19, milliseconds: 272),
new TimeSpan(days: 0, hours: 1, minutes: 58, seconds: 55, milliseconds: 642),
new TimeSpan(days: 0, hours: 2, minutes: 4, seconds: 39, milliseconds: 272),
},
},
            new TimeSpanintervalArray1M
{
    Id = 63,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 7, minutes: 33, seconds: 20, milliseconds: 56),
new TimeSpan(days: 0, hours: 11, minutes: 1, seconds: 13, milliseconds: 943),
new TimeSpan(days: 0, hours: 22, minutes: 28, seconds: 11, milliseconds: 797),
new TimeSpan(days: 0, hours: 3, minutes: 9, seconds: 36, milliseconds: 517),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 70,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 8, minutes: 25, seconds: 34, milliseconds: 184),
new TimeSpan(days: 0, hours: 11, minutes: 4, seconds: 53, milliseconds: 393),
new TimeSpan(days: 0, hours: 14, minutes: 47, seconds: 35, milliseconds: 654),
new TimeSpan(days: 0, hours: 20, minutes: 8, seconds: 36, milliseconds: 206),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 37,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 22, minutes: 4, seconds: 41, milliseconds: 636),
new TimeSpan(days: 0, hours: 7, minutes: 40, seconds: 2, milliseconds: 960),
new TimeSpan(days: 0, hours: 1, minutes: 38, seconds: 10, milliseconds: 534),
new TimeSpan(days: 0, hours: 13, minutes: 22, seconds: 19, milliseconds: 143),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 6, minutes: 44, seconds: 29, milliseconds: 753),
new TimeSpan(days: 0, hours: 10, minutes: 25, seconds: 6, milliseconds: 689),
new TimeSpan(days: 0, hours: 13, minutes: 42, seconds: 2, milliseconds: 85),
new TimeSpan(days: 0, hours: 14, minutes: 29, seconds: 11, milliseconds: 8),
},
},
            new TimeSpanintervalArray1M
{
    Id = 76,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 0, minutes: 24, seconds: 53, milliseconds: 505),
new TimeSpan(days: 0, hours: 10, minutes: 36, seconds: 16, milliseconds: 674),
new TimeSpan(days: 0, hours: 12, minutes: 57, seconds: 11, milliseconds: 215),
new TimeSpan(days: 0, hours: 0, minutes: 52, seconds: 30, milliseconds: 935),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 85,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 20, minutes: 15, seconds: 37, milliseconds: 880),
new TimeSpan(days: 0, hours: 16, minutes: 52, seconds: 17, milliseconds: 463),
new TimeSpan(days: 0, hours: 13, minutes: 20, seconds: 56, milliseconds: 916),
new TimeSpan(days: 0, hours: 3, minutes: 56, seconds: 42, milliseconds: 451),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 38,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 3, minutes: 57, seconds: 2, milliseconds: 171),
new TimeSpan(days: 0, hours: 3, minutes: 37, seconds: 14, milliseconds: 164),
new TimeSpan(days: 0, hours: 17, minutes: 53, seconds: 31, milliseconds: 558),
new TimeSpan(days: 0, hours: 15, minutes: 38, seconds: 18, milliseconds: 508),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 11, minutes: 42, seconds: 14, milliseconds: 169),
new TimeSpan(days: 0, hours: 1, minutes: 20, seconds: 8, milliseconds: 252),
new TimeSpan(days: 0, hours: 4, minutes: 52, seconds: 6, milliseconds: 932),
new TimeSpan(days: 0, hours: 2, minutes: 31, seconds: 52, milliseconds: 809),
},
},
            new TimeSpanintervalArray1M
{
    Id = 94,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 11, minutes: 52, seconds: 49, milliseconds: 327),
new TimeSpan(days: 0, hours: 14, minutes: 20, seconds: 18, milliseconds: 451),
new TimeSpan(days: 0, hours: 22, minutes: 40, seconds: 11, milliseconds: 814),
new TimeSpan(days: 0, hours: 4, minutes: 12, seconds: 49, milliseconds: 760),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 97,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 48, seconds: 56, milliseconds: 739),
new TimeSpan(days: 0, hours: 12, minutes: 27, seconds: 19, milliseconds: 385),
new TimeSpan(days: 0, hours: 6, minutes: 33, seconds: 5, milliseconds: 601),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 40,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 10, minutes: 6, seconds: 3, milliseconds: 892),
new TimeSpan(days: 0, hours: 4, minutes: 11, seconds: 15, milliseconds: 305),
new TimeSpan(days: 0, hours: 16, minutes: 18, seconds: 15, milliseconds: 718),
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 58, seconds: 17, milliseconds: 136),
new TimeSpan(days: 0, hours: 13, minutes: 12, seconds: 1, milliseconds: 175),
new TimeSpan(days: 0, hours: 1, minutes: 53, seconds: 51, milliseconds: 282),
new TimeSpan(days: 0, hours: 19, minutes: 20, seconds: 4, milliseconds: 141),
},
},
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 105,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 6, minutes: 17, seconds: 17, milliseconds: 661),
new TimeSpan(days: 0, hours: 2, minutes: 0, seconds: 8, milliseconds: 662),
new TimeSpan(days: 0, hours: 20, minutes: 52, seconds: 14, milliseconds: 487),
new TimeSpan(days: 0, hours: 14, minutes: 52, seconds: 47, milliseconds: 208),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 111,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 3, minutes: 4, seconds: 24, milliseconds: 322),
new TimeSpan(days: 0, hours: 6, minutes: 47, seconds: 53, milliseconds: 428),
new TimeSpan(days: 0, hours: 2, minutes: 4, seconds: 39, milliseconds: 831),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 47,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 10, minutes: 9, seconds: 2, milliseconds: 699),
new TimeSpan(days: 0, hours: 4, minutes: 54, seconds: 48, milliseconds: 162),
new TimeSpan(days: 0, hours: 13, minutes: 9, seconds: 24, milliseconds: 435),
new TimeSpan(days: 0, hours: 7, minutes: 53, seconds: 9, milliseconds: 709),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 12, minutes: 30, seconds: 23, milliseconds: 45),
new TimeSpan(days: 0, hours: 11, minutes: 14, seconds: 8, milliseconds: 123),
new TimeSpan(days: 0, hours: 15, minutes: 27, seconds: 20, milliseconds: 276),
},
},
            new TimeSpanintervalArray1M
{
    Id = 113,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 7, minutes: 40, seconds: 57, milliseconds: 97),
new TimeSpan(days: 0, hours: 6, minutes: 9, seconds: 23, milliseconds: 39),
new TimeSpan(days: 0, hours: 18, minutes: 12, seconds: 16, milliseconds: 736),
new TimeSpan(days: 0, hours: 0, minutes: 41, seconds: 19, milliseconds: 93),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 116,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 55, seconds: 56, milliseconds: 408),
new TimeSpan(days: 0, hours: 8, minutes: 36, seconds: 23, milliseconds: 680),
new TimeSpan(days: 0, hours: 8, minutes: 51, seconds: 36, milliseconds: 807),
new TimeSpan(days: 0, hours: 2, minutes: 58, seconds: 55, milliseconds: 369),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 55,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 16, minutes: 26, seconds: 39, milliseconds: 433),
new TimeSpan(days: 0, hours: 22, minutes: 14, seconds: 26, milliseconds: 479),
new TimeSpan(days: 0, hours: 14, minutes: 1, seconds: 28, milliseconds: 983),
new TimeSpan(days: 0, hours: 18, minutes: 4, seconds: 47, milliseconds: 407),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 125,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 15, minutes: 26, seconds: 43, milliseconds: 369),
new TimeSpan(days: 0, hours: 5, minutes: 4, seconds: 29, milliseconds: 50),
new TimeSpan(days: 0, hours: 20, minutes: 52, seconds: 32, milliseconds: 724),
new TimeSpan(days: 0, hours: 1, minutes: 27, seconds: 45, milliseconds: 800),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 129,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 14, minutes: 10, seconds: 2, milliseconds: 796),
new TimeSpan(days: 0, hours: 19, minutes: 41, seconds: 48, milliseconds: 584),
new TimeSpan(days: 0, hours: 11, minutes: 37, seconds: 14, milliseconds: 691),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 62,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 6, minutes: 45, seconds: 15, milliseconds: 465),
new TimeSpan(days: 0, hours: 9, minutes: 50, seconds: 47, milliseconds: 207),
new TimeSpan(days: 0, hours: 9, minutes: 17, seconds: 58, milliseconds: 76),
new TimeSpan(days: 0, hours: 9, minutes: 18, seconds: 38, milliseconds: 793),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 137,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 2, minutes: 1, seconds: 50, milliseconds: 176),
new TimeSpan(days: 0, hours: 1, minutes: 7, seconds: 54, milliseconds: 612),
new TimeSpan(days: 0, hours: 19, minutes: 0, seconds: 55, milliseconds: 715),
new TimeSpan(days: 0, hours: 7, minutes: 55, seconds: 6, milliseconds: 265),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 141,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 19, minutes: 3, seconds: 51, milliseconds: 924),
new TimeSpan(days: 0, hours: 13, minutes: 25, seconds: 18, milliseconds: 696),
new TimeSpan(days: 0, hours: 12, minutes: 44, seconds: 17, milliseconds: 351),
new TimeSpan(days: 0, hours: 18, minutes: 51, seconds: 7, milliseconds: 622),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 65,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 22, minutes: 29, seconds: 40, milliseconds: 957),
new TimeSpan(days: 0, hours: 3, minutes: 31, seconds: 53, milliseconds: 974),
new TimeSpan(days: 0, hours: 7, minutes: 10, seconds: 24, milliseconds: 175),
new TimeSpan(days: 0, hours: 9, minutes: 1, seconds: 22, milliseconds: 343),
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 3, minutes: 5, seconds: 50, milliseconds: 372),
new TimeSpan(days: 0, hours: 0, minutes: 55, seconds: 47, milliseconds: 903),
new TimeSpan(days: 0, hours: 7, minutes: 10, seconds: 7, milliseconds: 625),
new TimeSpan(days: 0, hours: 22, minutes: 31, seconds: 13, milliseconds: 222),
},
},
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 143,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 12, minutes: 12, seconds: 20, milliseconds: 717),
new TimeSpan(days: 0, hours: 11, minutes: 51, seconds: 7, milliseconds: 975),
new TimeSpan(days: 0, hours: 11, minutes: 31, seconds: 41, milliseconds: 709),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 0, minutes: 44, seconds: 30, milliseconds: 667),
new TimeSpan(days: 0, hours: 15, minutes: 5, seconds: 10, milliseconds: 665),
new TimeSpan(days: 0, hours: 2, minutes: 44, seconds: 35, milliseconds: 12),
new TimeSpan(days: 0, hours: 8, minutes: 32, seconds: 25, milliseconds: 617),
},
},
            new TimeSpanintervalArray1M
{
    Id = 147,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 12, minutes: 30, seconds: 12, milliseconds: 26),
new TimeSpan(days: 0, hours: 8, minutes: 23, seconds: 33, milliseconds: 255),
new TimeSpan(days: 0, hours: 11, minutes: 55, seconds: 4, milliseconds: 366),
new TimeSpan(days: 0, hours: 18, minutes: 34, seconds: 36, milliseconds: 955),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 69,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 3, minutes: 11, seconds: 27, milliseconds: 995),
new TimeSpan(days: 0, hours: 1, minutes: 15, seconds: 33, milliseconds: 306),
new TimeSpan(days: 0, hours: 1, minutes: 34, seconds: 41, milliseconds: 557),
new TimeSpan(days: 0, hours: 20, minutes: 51, seconds: 30, milliseconds: 149),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 10, minutes: 16, seconds: 40, milliseconds: 891),
new TimeSpan(days: 0, hours: 20, minutes: 29, seconds: 42, milliseconds: 76),
new TimeSpan(days: 0, hours: 18, minutes: 38, seconds: 9, milliseconds: 769),
},
},
            new TimeSpanintervalArray1M
{
    Id = 152,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 35, seconds: 0, milliseconds: 17),
new TimeSpan(days: 0, hours: 17, minutes: 21, seconds: 51, milliseconds: 310),
new TimeSpan(days: 0, hours: 6, minutes: 56, seconds: 39, milliseconds: 937),
new TimeSpan(days: 0, hours: 20, minutes: 4, seconds: 34, milliseconds: 643),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 17, minutes: 15, seconds: 6, milliseconds: 461),
new TimeSpan(days: 0, hours: 10, minutes: 42, seconds: 51, milliseconds: 295),
new TimeSpan(days: 0, hours: 16, minutes: 1, seconds: 33, milliseconds: 615),
new TimeSpan(days: 0, hours: 11, minutes: 0, seconds: 2, milliseconds: 458),
},
},
            new TimeSpanintervalArray1M
{
    Id = 158,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 17, minutes: 29, seconds: 9, milliseconds: 654),
new TimeSpan(days: 0, hours: 7, minutes: 47, seconds: 57, milliseconds: 188),
new TimeSpan(days: 0, hours: 8, minutes: 8, seconds: 23, milliseconds: 860),
new TimeSpan(days: 0, hours: 8, minutes: 19, seconds: 44, milliseconds: 366),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 72,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 22, minutes: 39, seconds: 13, milliseconds: 250),
new TimeSpan(days: 0, hours: 20, minutes: 53, seconds: 7, milliseconds: 889),
new TimeSpan(days: 0, hours: 6, minutes: 30, seconds: 46, milliseconds: 603),
new TimeSpan(days: 0, hours: 2, minutes: 16, seconds: 36, milliseconds: 858),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 20, minutes: 9, seconds: 2, milliseconds: 570),
new TimeSpan(days: 0, hours: 6, minutes: 29, seconds: 40, milliseconds: 736),
new TimeSpan(days: 0, hours: 6, minutes: 54, seconds: 56, milliseconds: 719),
new TimeSpan(days: 0, hours: 18, minutes: 10, seconds: 6, milliseconds: 968),
},
},
            new TimeSpanintervalArray1M
{
    Id = 161,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 21, minutes: 16, seconds: 48, milliseconds: 970),
new TimeSpan(days: 0, hours: 22, minutes: 54, seconds: 19, milliseconds: 519),
new TimeSpan(days: 0, hours: 0, minutes: 37, seconds: 28, milliseconds: 407),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 165,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 7, minutes: 58, seconds: 3, milliseconds: 564),
new TimeSpan(days: 0, hours: 20, minutes: 23, seconds: 9, milliseconds: 455),
new TimeSpan(days: 0, hours: 16, minutes: 52, seconds: 27, milliseconds: 486),
new TimeSpan(days: 0, hours: 10, minutes: 14, seconds: 17, milliseconds: 864),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 79,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 2, minutes: 28, seconds: 36, milliseconds: 183),
new TimeSpan(days: 0, hours: 17, minutes: 53, seconds: 42, milliseconds: 415),
new TimeSpan(days: 0, hours: 18, minutes: 0, seconds: 51, milliseconds: 62),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 170,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 34, seconds: 0, milliseconds: 104),
new TimeSpan(days: 0, hours: 7, minutes: 5, seconds: 27, milliseconds: 821),
new TimeSpan(days: 0, hours: 0, minutes: 36, seconds: 24, milliseconds: 426),
},
    ModelInner = null,
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 179,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 7, minutes: 13, seconds: 57, milliseconds: 737),
new TimeSpan(days: 0, hours: 9, minutes: 13, seconds: 52, milliseconds: 898),
new TimeSpan(days: 0, hours: 3, minutes: 13, seconds: 5, milliseconds: 748),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 83,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 22, minutes: 0, seconds: 1, milliseconds: 767),
new TimeSpan(days: 0, hours: 2, minutes: 17, seconds: 30, milliseconds: 241),
new TimeSpan(days: 0, hours: 22, minutes: 32, seconds: 18, milliseconds: 438),
},
    NullableValue = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 20, minutes: 20, seconds: 40, milliseconds: 506),
new TimeSpan(days: 0, hours: 8, minutes: 22, seconds: 32, milliseconds: 209),
new TimeSpan(days: 0, hours: 19, minutes: 40, seconds: 38, milliseconds: 975),
new TimeSpan(days: 0, hours: 16, minutes: 52, seconds: 32, milliseconds: 172),
},
},
    NullableValue = null,
},
            new TimeSpanintervalArray1M
{
    Id = 188,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 8, minutes: 5, seconds: 8, milliseconds: 447),
new TimeSpan(days: 0, hours: 1, minutes: 9, seconds: 11, milliseconds: 516),
new TimeSpan(days: 0, hours: 4, minutes: 13, seconds: 10, milliseconds: 246),
new TimeSpan(days: 0, hours: 18, minutes: 7, seconds: 24, milliseconds: 190),
},
    ModelInner = null,
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 11, minutes: 32, seconds: 25, milliseconds: 914),
new TimeSpan(days: 0, hours: 15, minutes: 40, seconds: 4, milliseconds: 374),
new TimeSpan(days: 0, hours: 15, minutes: 23, seconds: 45, milliseconds: 282),
},
},
            new TimeSpanintervalArray1M
{
    Id = 189,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 15, minutes: 48, seconds: 7, milliseconds: 617),
new TimeSpan(days: 0, hours: 15, minutes: 8, seconds: 33, milliseconds: 361),
new TimeSpan(days: 0, hours: 13, minutes: 55, seconds: 50, milliseconds: 709),
},
    ModelInner = new TimeSpanintervalArray1MI
{
    Id = 91,
    Value = 
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 14, minutes: 26, seconds: 7, milliseconds: 95),
new TimeSpan(days: 0, hours: 2, minutes: 7, seconds: 47, milliseconds: 35),
new TimeSpan(days: 0, hours: 18, minutes: 45, seconds: 45, milliseconds: 18),
new TimeSpan(days: 0, hours: 17, minutes: 37, seconds: 44, milliseconds: 279),
},
    NullableValue = null,
},
    NullableValue = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 18, minutes: 37, seconds: 51, milliseconds: 937),
new TimeSpan(days: 0, hours: 20, minutes: 6, seconds: 34, milliseconds: 856),
new TimeSpan(days: 0, hours: 13, minutes: 44, seconds: 13, milliseconds: 885),
},
},
            new TimeSpanintervalArray1M
{
    Id = 195,
    Value = 
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 3, minutes: 0, seconds: 25, milliseconds: 426),
new TimeSpan(days: 0, hours: 0, minutes: 13, seconds: 3, milliseconds: 68),
new TimeSpan(days: 0, hours: 17, minutes: 28, seconds: 55, milliseconds: 731),
},
    ModelInner = null,
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

                id = await ((ITimeSpanArrayintervalArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((ITimeSpanArrayintervalArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

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

                    nullable =  ((ITimeSpanArrayintervalArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 17, minutes: 20, seconds: 55, milliseconds: 516),
new TimeSpan(days: 0, hours: 22, minutes: 46, seconds: 19, milliseconds: 509),
new TimeSpan(days: 0, hours: 6, minutes: 47, seconds: 46, milliseconds: 801),
new TimeSpan(days: 0, hours: 1, minutes: 36, seconds: 45, milliseconds: 409),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 20, minutes: 15, seconds: 5, milliseconds: 169),
new TimeSpan(days: 0, hours: 15, minutes: 58, seconds: 12, milliseconds: 633),
new TimeSpan(days: 0, hours: 8, minutes: 12, seconds: 23, milliseconds: 835),
}));
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
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 13, minutes: 41, seconds: 11, milliseconds: 878),
new TimeSpan(days: 0, hours: 2, minutes: 11, seconds: 12, milliseconds: 782),
new TimeSpan(days: 0, hours: 10, minutes: 0, seconds: 47, milliseconds: 318),
new TimeSpan(days: 0, hours: 2, minutes: 21, seconds: 33, milliseconds: 547),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.TimeSpan[4]
{
new TimeSpan(days: 0, hours: 1, minutes: 50, seconds: 8, milliseconds: 341),
new TimeSpan(days: 0, hours: 4, minutes: 42, seconds: 47, milliseconds: 375),
new TimeSpan(days: 0, hours: 19, minutes: 32, seconds: 27, milliseconds: 304),
new TimeSpan(days: 0, hours: 14, minutes: 19, seconds: 21, milliseconds: 18),
}));
                nullable =  ((ITimeSpanArrayintervalArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.TimeSpan[3]
{
new TimeSpan(days: 0, hours: 2, minutes: 18, seconds: 19, milliseconds: 272),
new TimeSpan(days: 0, hours: 1, minutes: 58, seconds: 55, milliseconds: 642),
new TimeSpan(days: 0, hours: 2, minutes: 4, seconds: 39, milliseconds: 272),
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
new TimeSpan(days: 0, hours: 6, minutes: 44, seconds: 29, milliseconds: 753),
new TimeSpan(days: 0, hours: 10, minutes: 25, seconds: 6, milliseconds: 689),
new TimeSpan(days: 0, hours: 13, minutes: 42, seconds: 2, milliseconds: 85),
new TimeSpan(days: 0, hours: 14, minutes: 29, seconds: 11, milliseconds: 8),
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
                models = await ((ITimeSpanArrayintervalArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalArray1M.AssertModel(models[0],_testData[30], true);
                models = await ((ITimeSpanArrayintervalArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalArray1M.AssertModel(models[0],_testData[31], true);
                models = await ((ITimeSpanArrayintervalArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalArray1M.AssertModel(models[0],_testData[32], true);
                models = await ((ITimeSpanArrayintervalArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalArray1M.AssertModel(models[0],_testData[33], true);
                models = await ((ITimeSpanArrayintervalArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                TimeSpanintervalArray1M.AssertModel(models[0],_testData[34], true);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalArray1M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 158;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 105;
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
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[17],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 97;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 34;
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
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[28],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalArray1M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 97;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 45;
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
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
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
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[26],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 85;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 113;
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
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[15],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 141;
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
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatTimeSpanintervalArray1M.AssertModel(models[0],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[1],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[2],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[3],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[4],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[5],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[6],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[7],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[8],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[9],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatTimeSpanintervalArray1M.AssertModel(models[0],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[1],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[2],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[3],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[4],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[5],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[6],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[7],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[8],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[9],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[10],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[11],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[12],_testData[34], false);
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
                parametr1.Value = 137;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 143;
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
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[9],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 141;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 143;
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
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatTimeSpanintervalArray1M.AssertModel(models[0],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[1],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[2],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[3],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[4],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[5],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[6],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[7],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[8],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[9],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatTimeSpanintervalArray1M.AssertModel(models[0],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[1],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[2],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[3],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[4],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[5],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[6],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[7],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[8],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[9],_testData[34], false);
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
                parametr1.Value = 85;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 113;
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
                Assert.That(firstItems1, Has.Count.EqualTo(21));
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
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[15],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 85;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 16;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((ITimeSpanArrayintervalArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

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
                        TimeSpanintervalArray1M.AssertModel(models[16],_testData[30], false);
                        TimeSpanintervalArray1M.AssertModel(models[17],_testData[31], false);
                        TimeSpanintervalArray1M.AssertModel(models[18],_testData[32], false);
                        TimeSpanintervalArray1M.AssertModel(models[19],_testData[33], false);
                        TimeSpanintervalArray1M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        TimeSpanintervalArray1M.AssertModel(models[0],_testData[3], false);
                        TimeSpanintervalArray1M.AssertModel(models[1],_testData[4], false);
                        TimeSpanintervalArray1M.AssertModel(models[2],_testData[5], false);
                        TimeSpanintervalArray1M.AssertModel(models[3],_testData[6], false);
                        TimeSpanintervalArray1M.AssertModel(models[4],_testData[7], false);
                        TimeSpanintervalArray1M.AssertModel(models[5],_testData[8], false);
                        TimeSpanintervalArray1M.AssertModel(models[6],_testData[9], false);
                        TimeSpanintervalArray1M.AssertModel(models[7],_testData[10], false);
                        TimeSpanintervalArray1M.AssertModel(models[8],_testData[11], false);
                        TimeSpanintervalArray1M.AssertModel(models[9],_testData[12], false);
                        TimeSpanintervalArray1M.AssertModel(models[10],_testData[13], false);
                        TimeSpanintervalArray1M.AssertModel(models[11],_testData[14], false);
                        TimeSpanintervalArray1M.AssertModel(models[12],_testData[15], false);
                        TimeSpanintervalArray1M.AssertModel(models[13],_testData[16], false);
                        TimeSpanintervalArray1M.AssertModel(models[14],_testData[17], false);
                        TimeSpanintervalArray1M.AssertModel(models[15],_testData[18], false);
                        TimeSpanintervalArray1M.AssertModel(models[16],_testData[19], false);
                        TimeSpanintervalArray1M.AssertModel(models[17],_testData[20], false);
                        TimeSpanintervalArray1M.AssertModel(models[18],_testData[21], false);
                        TimeSpanintervalArray1M.AssertModel(models[19],_testData[22], false);
                        TimeSpanintervalArray1M.AssertModel(models[20],_testData[23], false);
                        TimeSpanintervalArray1M.AssertModel(models[21],_testData[24], false);
                        TimeSpanintervalArray1M.AssertModel(models[22],_testData[25], false);
                        TimeSpanintervalArray1M.AssertModel(models[23],_testData[26], false);
                        TimeSpanintervalArray1M.AssertModel(models[24],_testData[27], false);
                        TimeSpanintervalArray1M.AssertModel(models[25],_testData[28], false);
                        TimeSpanintervalArray1M.AssertModel(models[26],_testData[29], false);
                        TimeSpanintervalArray1M.AssertModel(models[27],_testData[30], false);
                        TimeSpanintervalArray1M.AssertModel(models[28],_testData[31], false);
                        TimeSpanintervalArray1M.AssertModel(models[29],_testData[32], false);
                        TimeSpanintervalArray1M.AssertModel(models[30],_testData[33], false);
                        TimeSpanintervalArray1M.AssertModel(models[31],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 170;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 34;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((ITimeSpanArrayintervalArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        TimeSpanintervalArray1M.AssertModel(models[0],_testData[31], false);
                        TimeSpanintervalArray1M.AssertModel(models[1],_testData[32], false);
                        TimeSpanintervalArray1M.AssertModel(models[2],_testData[33], false);
                        TimeSpanintervalArray1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        TimeSpanintervalArray1M.AssertModel(models[0],_testData[6], false);
                        TimeSpanintervalArray1M.AssertModel(models[1],_testData[7], false);
                        TimeSpanintervalArray1M.AssertModel(models[2],_testData[8], false);
                        TimeSpanintervalArray1M.AssertModel(models[3],_testData[9], false);
                        TimeSpanintervalArray1M.AssertModel(models[4],_testData[10], false);
                        TimeSpanintervalArray1M.AssertModel(models[5],_testData[11], false);
                        TimeSpanintervalArray1M.AssertModel(models[6],_testData[12], false);
                        TimeSpanintervalArray1M.AssertModel(models[7],_testData[13], false);
                        TimeSpanintervalArray1M.AssertModel(models[8],_testData[14], false);
                        TimeSpanintervalArray1M.AssertModel(models[9],_testData[15], false);
                        TimeSpanintervalArray1M.AssertModel(models[10],_testData[16], false);
                        TimeSpanintervalArray1M.AssertModel(models[11],_testData[17], false);
                        TimeSpanintervalArray1M.AssertModel(models[12],_testData[18], false);
                        TimeSpanintervalArray1M.AssertModel(models[13],_testData[19], false);
                        TimeSpanintervalArray1M.AssertModel(models[14],_testData[20], false);
                        TimeSpanintervalArray1M.AssertModel(models[15],_testData[21], false);
                        TimeSpanintervalArray1M.AssertModel(models[16],_testData[22], false);
                        TimeSpanintervalArray1M.AssertModel(models[17],_testData[23], false);
                        TimeSpanintervalArray1M.AssertModel(models[18],_testData[24], false);
                        TimeSpanintervalArray1M.AssertModel(models[19],_testData[25], false);
                        TimeSpanintervalArray1M.AssertModel(models[20],_testData[26], false);
                        TimeSpanintervalArray1M.AssertModel(models[21],_testData[27], false);
                        TimeSpanintervalArray1M.AssertModel(models[22],_testData[28], false);
                        TimeSpanintervalArray1M.AssertModel(models[23],_testData[29], false);
                        TimeSpanintervalArray1M.AssertModel(models[24],_testData[30], false);
                        TimeSpanintervalArray1M.AssertModel(models[25],_testData[31], false);
                        TimeSpanintervalArray1M.AssertModel(models[26],_testData[32], false);
                        TimeSpanintervalArray1M.AssertModel(models[27],_testData[33], false);
                        TimeSpanintervalArray1M.AssertModel(models[28],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalArray1M.AssertModel(models1[i],_testData[i], false);
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
                await ((ITimeSpanArrayintervalArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 97, query1, 141, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[10],_testData[34], false);
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
                await ((ITimeSpanArrayintervalArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 56, query1, 161, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[5],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatTimeSpanintervalArray1M.AssertModel(models1[i],_testData[i], false);
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
                 ((ITimeSpanArrayintervalArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 116, query1, 170, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
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
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[3],_testData[34], false);
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
                 ((ITimeSpanArrayintervalArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 21, query1, 16, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
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
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[31],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((ITimeSpanArrayintervalArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 137, query1, 141, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatTimeSpanintervalArray1M.AssertModel(models[0],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[1],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[2],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[3],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[4],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[5],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[6],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[7],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[8],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[9],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[10],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatTimeSpanintervalArray1M.AssertModel(models[0],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[1],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[2],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[3],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[4],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[5],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[6],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[7],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[8],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[9],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[10],_testData[34], false);
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
                await ((ITimeSpanArrayintervalArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 111, query1, 143, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[9],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((ITimeSpanArrayintervalArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 45, query1, 63, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

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
                        FlatTimeSpanintervalArray1M.AssertModel(models[22],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[23],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[24],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[25],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

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
                        FlatTimeSpanintervalArray1M.AssertModel(models[19],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[20],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[21],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[22],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(models[23],_testData[34], false);
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
                 ((ITimeSpanArrayintervalArray)this).DbConnectionDynQuerySelectModelBatch(connection, 45, query1, 85, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(firstItems1[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
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
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatTimeSpanintervalArray1M.AssertModel(secondItems2[20],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((ITimeSpanArrayintervalArray)this).DbConnectionSTSelectModelBatchAsync(connection, 63, 36))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        TimeSpanintervalArray1M.AssertModel(models[0],_testData[11], false);
                        TimeSpanintervalArray1M.AssertModel(models[1],_testData[12], false);
                        TimeSpanintervalArray1M.AssertModel(models[2],_testData[13], false);
                        TimeSpanintervalArray1M.AssertModel(models[3],_testData[14], false);
                        TimeSpanintervalArray1M.AssertModel(models[4],_testData[15], false);
                        TimeSpanintervalArray1M.AssertModel(models[5],_testData[16], false);
                        TimeSpanintervalArray1M.AssertModel(models[6],_testData[17], false);
                        TimeSpanintervalArray1M.AssertModel(models[7],_testData[18], false);
                        TimeSpanintervalArray1M.AssertModel(models[8],_testData[19], false);
                        TimeSpanintervalArray1M.AssertModel(models[9],_testData[20], false);
                        TimeSpanintervalArray1M.AssertModel(models[10],_testData[21], false);
                        TimeSpanintervalArray1M.AssertModel(models[11],_testData[22], false);
                        TimeSpanintervalArray1M.AssertModel(models[12],_testData[23], false);
                        TimeSpanintervalArray1M.AssertModel(models[13],_testData[24], false);
                        TimeSpanintervalArray1M.AssertModel(models[14],_testData[25], false);
                        TimeSpanintervalArray1M.AssertModel(models[15],_testData[26], false);
                        TimeSpanintervalArray1M.AssertModel(models[16],_testData[27], false);
                        TimeSpanintervalArray1M.AssertModel(models[17],_testData[28], false);
                        TimeSpanintervalArray1M.AssertModel(models[18],_testData[29], false);
                        TimeSpanintervalArray1M.AssertModel(models[19],_testData[30], false);
                        TimeSpanintervalArray1M.AssertModel(models[20],_testData[31], false);
                        TimeSpanintervalArray1M.AssertModel(models[21],_testData[32], false);
                        TimeSpanintervalArray1M.AssertModel(models[22],_testData[33], false);
                        TimeSpanintervalArray1M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

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
                        TimeSpanintervalArray1M.AssertModel(models[23],_testData[30], false);
                        TimeSpanintervalArray1M.AssertModel(models[24],_testData[31], false);
                        TimeSpanintervalArray1M.AssertModel(models[25],_testData[32], false);
                        TimeSpanintervalArray1M.AssertModel(models[26],_testData[33], false);
                        TimeSpanintervalArray1M.AssertModel(models[27],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((ITimeSpanArrayintervalArray)this).DbConnectionSTSelectModelBatch(connection, 63, 113))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        TimeSpanintervalArray1M.AssertModel(models[0],_testData[11], false);
                        TimeSpanintervalArray1M.AssertModel(models[1],_testData[12], false);
                        TimeSpanintervalArray1M.AssertModel(models[2],_testData[13], false);
                        TimeSpanintervalArray1M.AssertModel(models[3],_testData[14], false);
                        TimeSpanintervalArray1M.AssertModel(models[4],_testData[15], false);
                        TimeSpanintervalArray1M.AssertModel(models[5],_testData[16], false);
                        TimeSpanintervalArray1M.AssertModel(models[6],_testData[17], false);
                        TimeSpanintervalArray1M.AssertModel(models[7],_testData[18], false);
                        TimeSpanintervalArray1M.AssertModel(models[8],_testData[19], false);
                        TimeSpanintervalArray1M.AssertModel(models[9],_testData[20], false);
                        TimeSpanintervalArray1M.AssertModel(models[10],_testData[21], false);
                        TimeSpanintervalArray1M.AssertModel(models[11],_testData[22], false);
                        TimeSpanintervalArray1M.AssertModel(models[12],_testData[23], false);
                        TimeSpanintervalArray1M.AssertModel(models[13],_testData[24], false);
                        TimeSpanintervalArray1M.AssertModel(models[14],_testData[25], false);
                        TimeSpanintervalArray1M.AssertModel(models[15],_testData[26], false);
                        TimeSpanintervalArray1M.AssertModel(models[16],_testData[27], false);
                        TimeSpanintervalArray1M.AssertModel(models[17],_testData[28], false);
                        TimeSpanintervalArray1M.AssertModel(models[18],_testData[29], false);
                        TimeSpanintervalArray1M.AssertModel(models[19],_testData[30], false);
                        TimeSpanintervalArray1M.AssertModel(models[20],_testData[31], false);
                        TimeSpanintervalArray1M.AssertModel(models[21],_testData[32], false);
                        TimeSpanintervalArray1M.AssertModel(models[22],_testData[33], false);
                        TimeSpanintervalArray1M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

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
                        TimeSpanintervalArray1M.AssertModel(models[11],_testData[30], false);
                        TimeSpanintervalArray1M.AssertModel(models[12],_testData[31], false);
                        TimeSpanintervalArray1M.AssertModel(models[13],_testData[32], false);
                        TimeSpanintervalArray1M.AssertModel(models[14],_testData[33], false);
                        TimeSpanintervalArray1M.AssertModel(models[15],_testData[34], false);
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
                ((ITimeSpanArrayintervalArray)this).SetDbConnectionSelectModelParametrs(cmd, 1);
                var models = await ((ITimeSpanArrayintervalArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(34));

                TimeSpanintervalArray1M.AssertModel(models[0],_testData[1], false);
                TimeSpanintervalArray1M.AssertModel(models[1],_testData[2], false);
                TimeSpanintervalArray1M.AssertModel(models[2],_testData[3], false);
                TimeSpanintervalArray1M.AssertModel(models[3],_testData[4], false);
                TimeSpanintervalArray1M.AssertModel(models[4],_testData[5], false);
                TimeSpanintervalArray1M.AssertModel(models[5],_testData[6], false);
                TimeSpanintervalArray1M.AssertModel(models[6],_testData[7], false);
                TimeSpanintervalArray1M.AssertModel(models[7],_testData[8], false);
                TimeSpanintervalArray1M.AssertModel(models[8],_testData[9], false);
                TimeSpanintervalArray1M.AssertModel(models[9],_testData[10], false);
                TimeSpanintervalArray1M.AssertModel(models[10],_testData[11], false);
                TimeSpanintervalArray1M.AssertModel(models[11],_testData[12], false);
                TimeSpanintervalArray1M.AssertModel(models[12],_testData[13], false);
                TimeSpanintervalArray1M.AssertModel(models[13],_testData[14], false);
                TimeSpanintervalArray1M.AssertModel(models[14],_testData[15], false);
                TimeSpanintervalArray1M.AssertModel(models[15],_testData[16], false);
                TimeSpanintervalArray1M.AssertModel(models[16],_testData[17], false);
                TimeSpanintervalArray1M.AssertModel(models[17],_testData[18], false);
                TimeSpanintervalArray1M.AssertModel(models[18],_testData[19], false);
                TimeSpanintervalArray1M.AssertModel(models[19],_testData[20], false);
                TimeSpanintervalArray1M.AssertModel(models[20],_testData[21], false);
                TimeSpanintervalArray1M.AssertModel(models[21],_testData[22], false);
                TimeSpanintervalArray1M.AssertModel(models[22],_testData[23], false);
                TimeSpanintervalArray1M.AssertModel(models[23],_testData[24], false);
                TimeSpanintervalArray1M.AssertModel(models[24],_testData[25], false);
                TimeSpanintervalArray1M.AssertModel(models[25],_testData[26], false);
                TimeSpanintervalArray1M.AssertModel(models[26],_testData[27], false);
                TimeSpanintervalArray1M.AssertModel(models[27],_testData[28], false);
                TimeSpanintervalArray1M.AssertModel(models[28],_testData[29], false);
                TimeSpanintervalArray1M.AssertModel(models[29],_testData[30], false);
                TimeSpanintervalArray1M.AssertModel(models[30],_testData[31], false);
                TimeSpanintervalArray1M.AssertModel(models[31],_testData[32], false);
                TimeSpanintervalArray1M.AssertModel(models[32],_testData[33], false);
                TimeSpanintervalArray1M.AssertModel(models[33],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ITimeSpanArrayintervalArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((ITimeSpanArrayintervalArray)this).SetDbConnectionSelectModelParametrs(cmd, 63);
                var models =  ((ITimeSpanArrayintervalArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(24));

                TimeSpanintervalArray1M.AssertModel(models[0],_testData[11], false);
                TimeSpanintervalArray1M.AssertModel(models[1],_testData[12], false);
                TimeSpanintervalArray1M.AssertModel(models[2],_testData[13], false);
                TimeSpanintervalArray1M.AssertModel(models[3],_testData[14], false);
                TimeSpanintervalArray1M.AssertModel(models[4],_testData[15], false);
                TimeSpanintervalArray1M.AssertModel(models[5],_testData[16], false);
                TimeSpanintervalArray1M.AssertModel(models[6],_testData[17], false);
                TimeSpanintervalArray1M.AssertModel(models[7],_testData[18], false);
                TimeSpanintervalArray1M.AssertModel(models[8],_testData[19], false);
                TimeSpanintervalArray1M.AssertModel(models[9],_testData[20], false);
                TimeSpanintervalArray1M.AssertModel(models[10],_testData[21], false);
                TimeSpanintervalArray1M.AssertModel(models[11],_testData[22], false);
                TimeSpanintervalArray1M.AssertModel(models[12],_testData[23], false);
                TimeSpanintervalArray1M.AssertModel(models[13],_testData[24], false);
                TimeSpanintervalArray1M.AssertModel(models[14],_testData[25], false);
                TimeSpanintervalArray1M.AssertModel(models[15],_testData[26], false);
                TimeSpanintervalArray1M.AssertModel(models[16],_testData[27], false);
                TimeSpanintervalArray1M.AssertModel(models[17],_testData[28], false);
                TimeSpanintervalArray1M.AssertModel(models[18],_testData[29], false);
                TimeSpanintervalArray1M.AssertModel(models[19],_testData[30], false);
                TimeSpanintervalArray1M.AssertModel(models[20],_testData[31], false);
                TimeSpanintervalArray1M.AssertModel(models[21],_testData[32], false);
                TimeSpanintervalArray1M.AssertModel(models[22],_testData[33], false);
                TimeSpanintervalArray1M.AssertModel(models[23],_testData[34], false);
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
FROM public.binary_timespanintervalarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanArrayintervalArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(TimeSpanintervalArray1MIWA),
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
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<TimeSpanintervalArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeSpanintervalArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ITimeSpanArrayintervalArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_timespanintervalarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((ITimeSpanArrayintervalArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeSpanintervalArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<TimeSpanintervalArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeSpanintervalArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ITimeSpanArrayintervalArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_timespanintervalarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((ITimeSpanArrayintervalArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeSpanintervalArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_timespanintervalarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanArrayintervalArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(TimeSpanintervalArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanArrayintervalArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<TimeSpanintervalArray1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeSpanintervalArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ITimeSpanArrayintervalArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_timespanintervalarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((ITimeSpanArrayintervalArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeSpanintervalArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<TimeSpanintervalArray1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeSpanintervalArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ITimeSpanArrayintervalArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_timespanintervalarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((ITimeSpanArrayintervalArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeSpanintervalArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_timespanintervalarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanArrayintervalArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

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
            methodName:"WAImportModelInner",
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
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<TimeSpanintervalArray1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((ITimeSpanArrayintervalArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((ITimeSpanArrayintervalArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeSpanintervalArray1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<TimeSpanintervalArray1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((ITimeSpanArrayintervalArray)this).WAImportModelInner(connection, importCollection);
                var models = ((ITimeSpanArrayintervalArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeSpanintervalArray1MI.AssertModel(actual, expect, false);
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
FROM public.binary_timespanintervalarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanArrayintervalArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_timespanintervalarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(TimeSpanintervalArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanArrayintervalArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<TimeSpanintervalArray1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeSpanintervalArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((ITimeSpanArrayintervalArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((ITimeSpanArrayintervalArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeSpanintervalArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<TimeSpanintervalArray1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new TimeSpanintervalArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((ITimeSpanArrayintervalArray)this).ImportModelInner(connection, importCollection);
                var models = ((ITimeSpanArrayintervalArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    TimeSpanintervalArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<TimeSpanintervalArray1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((ITimeSpanArrayintervalArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((ITimeSpanArrayintervalArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    TimeSpanintervalArray1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<TimeSpanintervalArray1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((ITimeSpanArrayintervalArray)this).ImportModel(connection, importCollection);
                var models = ((ITimeSpanArrayintervalArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    TimeSpanintervalArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanArrayintervalArray)),
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

        [Test, Order(13)]
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
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalArray1MIWA), typeof(TimeSpanintervalArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanArrayintervalArray)),
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
                var models1 = new List<TimeSpanintervalArray1MIWA>();
                var models2 = new List<TimeSpanintervalArray1MIWA>();
                await ((ITimeSpanArrayintervalArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_timespanintervalarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeSpanintervalArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeSpanintervalArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<TimeSpanintervalArray1MIWA>();
                var models2 = new List<TimeSpanintervalArray1MIWA>();
                ((ITimeSpanArrayintervalArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_timespanintervalarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeSpanintervalArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeSpanintervalArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanArrayintervalArray)),
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
                var models = await ((ITimeSpanArrayintervalArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_timespanintervalarray1mi
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
                    TimeSpanintervalArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((ITimeSpanArrayintervalArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_timespanintervalarray1mi
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
                    TimeSpanintervalArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalArray1MIWA), typeof(TimeSpanintervalArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanArrayintervalArray))]
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
                var models1 = new List<TimeSpanintervalArray1MIWA>();
                var models2 = new List<TimeSpanintervalArray1MIWA>();
                await ((ITimeSpanArrayintervalArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_timespanintervalarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeSpanintervalArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeSpanintervalArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<TimeSpanintervalArray1MIWA>();
                var models2 = new List<TimeSpanintervalArray1MIWA>();
                ((ITimeSpanArrayintervalArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_timespanintervalarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeSpanintervalArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeSpanintervalArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanArrayintervalArray))]
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
                var models = await ((ITimeSpanArrayintervalArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_timespanintervalarray1mi
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
                    TimeSpanintervalArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((ITimeSpanArrayintervalArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_timespanintervalarray1mi
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
                    TimeSpanintervalArray1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_timespanintervalarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalArray1MI), typeof(TimeSpanintervalArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanArrayintervalArray)),
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
                var models1 = new List<TimeSpanintervalArray1MI>();
                var models2 = new List<TimeSpanintervalArray1MI>();
                await ((ITimeSpanArrayintervalArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeSpanintervalArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeSpanintervalArray1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<TimeSpanintervalArray1MI>();
                var models2 = new List<TimeSpanintervalArray1MI>();
                ((ITimeSpanArrayintervalArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeSpanintervalArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeSpanintervalArray1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_timespanintervalarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanArrayintervalArray)),
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
                var models = await ((ITimeSpanArrayintervalArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    TimeSpanintervalArray1MI.AssertModel(model, expectedModel, false);
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
                var models = ((ITimeSpanArrayintervalArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    TimeSpanintervalArray1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_timespanintervalarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalArray1MIWA), typeof(TimeSpanintervalArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanArrayintervalArray))]
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
                var models1 = new List<TimeSpanintervalArray1MIWA>();
                var models2 = new List<TimeSpanintervalArray1MIWA>();
                await ((ITimeSpanArrayintervalArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeSpanintervalArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeSpanintervalArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<TimeSpanintervalArray1MIWA>();
                var models2 = new List<TimeSpanintervalArray1MIWA>();
                ((ITimeSpanArrayintervalArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    TimeSpanintervalArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    TimeSpanintervalArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_timespanintervalarray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(TimeSpanintervalArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ITimeSpanArrayintervalArray))]
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
                var models = await ((ITimeSpanArrayintervalArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    TimeSpanintervalArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((ITimeSpanArrayintervalArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    TimeSpanintervalArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

